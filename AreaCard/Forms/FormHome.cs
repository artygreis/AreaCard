using AreaCard.Type;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using Word = Microsoft.Office.Interop.Word;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace AreaCard.Forms
{
    public partial class FormHome : Form
    {
        private LogInformation logInformation;
        private CardCollection cardCollection;
        private string currentYear;
        public Word.Document Document { get; set; }
        public Word.Application Application { get; set; }
        public FormHome()
        {
            InitializeComponent();
        }

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            string source = "";

            if (!ExistDefaultSource(out source))
            {
                if (fbdBrowserFolder.ShowDialog() == DialogResult.OK)
                {
                    source = fbdBrowserFolder.SelectedPath;
                    var dialogResult = MessageBox.Show("Хотите ли вы сохранить путь к папке?", "Сохранение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogResult == DialogResult.Yes)
                    {
                        Properties.Settings.Default.SourceToFolder = source;
                        Properties.Settings.Default.UseDefault = true;
                        chbUseDefaultSource.Checked = Properties.Settings.Default.UseDefault;
                        txtSourceToFolder.Text = Properties.Settings.Default.SourceToFolder;
                    }
                    else
                    {
                        Properties.Settings.Default.UseDefault = false;
                        chbUseDefaultSource.Checked = Properties.Settings.Default.UseDefault;
                    }
                    Properties.Settings.Default.Save();
                }
                else
                    return;
            }

            GetAndLoadFiles(source);

            ChangeDesignAndAvailableControls(1);
        }

        private bool ExistDefaultSource(out string source)
        {
            source = "";
            if (chbUseDefaultSource.Checked)
            {
                if (Directory.Exists(Properties.Settings.Default.SourceToFolder))
                {
                    source = Properties.Settings.Default.SourceToFolder;
                    return true;
                }
                else
                {
                    MessageBox.Show("Путь к картотеке не найден, поэтому укажите другую папку.", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            return false;
        }

        private void GetAndLoadFiles(string source)
        {
            if (Directory.Exists(Properties.Settings.Default.SourceLogDefault))
            {
                new DirectoryInfo(Properties.Settings.Default.SourceLogDefault).Delete(true);
            }

            cardCollection = new CardCollection();
            logInformation = new LogInformation();

            List<string> files = Directory.GetFiles(source, "*.docx",
                                                SearchOption.AllDirectories).Where(f => !f.Contains("$")).ToList();

            logInformation.CountAllFiles = files.Count;

            PreloadForm preload = new PreloadForm();
            preload.Files = files;
            preload.BackgroundWorker.DoWork += ReadFile;
            preload.ShowDialog();

            var logForm = new LogInformationForm();
            logInformation.CountCards = cardCollection.GetCountCards();
            logForm.LogInformation = logInformation;
            logForm.ShowDialog();
        }

        private void ReadFile(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;

            var files = (List<string>)e.Argument;

            //цикл для прохода по docx-файлам
            for (int i = 0; i < files.Count; i++)
            {
                worker.ReportProgress(i + 1);
                Log.Logger.Info($"Файл {files[i]} принят в обработку.");
                if (!ReadDataFromFile(files[i], out List<Card> cardsResult))
                {
                    Log.Logger.Info($"Файл не был обработан из-за обнаруженных ошибок.");
                    continue;
                }
                else
                {
                    cardCollection.AddToColletion(cardsResult);
                }
                logInformation.CountReadyFiles++;
                Log.Logger.Info($"Файл успешно обработан.");
            }
        }

        /// <summary>
        /// Чтение информации из файла
        /// </summary>
        /// <param name="sourceFile"></param>
        /// <param name="cardsFromDocument"></param>
        /// <returns></returns>
        private bool ReadDataFromFile(string sourceFile, out List<Card> cardsFromDocument)
        {
            cardsFromDocument = new List<Card>();

            Application = new Word.Application();
            Document = Application.Documents.Open(sourceFile);
            Application.Visible = false;
            try
            {
                if (!ValidationDataTable(Document.Tables)) return false;

                if (!ValidatedDataYear(Document.Tables[1].Cell(1, 2).Range.Text)) return false;

                var cards = new List<Card>();

                var table = Document.Tables[2];

                for (int row = 3; row <= 41; row += 2)
                {
                    var currentCard = new Card() { CardInfos = new List<CardInfo>() };

                    var currentNumber = ClearFromSpecialSymbols(table.Cell(row, 1).Range.Text);
                    if (string.IsNullOrEmpty(currentNumber))
                    {
                        Log.Logger.Warn($"Отсутствует Номер участка в строке {row}.");
                        continue;
                    }
                    currentCard.Number = currentNumber;

                    var currentLastDate = ClearFromSpecialSymbols(table.Cell(row, 2).Range.Text);
                    if (DateTime.TryParse(currentLastDate, out DateTime resultLastDate))
                        currentCard.LastDate = resultLastDate;

                    var k = 0;
                    for (int col = 3; col <= 6; col++)
                    {
                        if (ValidatedDataCardInfo(table.Cell(row, col).Range.Text, table.Cell(row + 1, col + k).Range.Text, table.Cell(row + 1, col + k + 1).Range.Text,
                                out string name, out DateTime? outDate, out DateTime? inDate))
                        {
                            if (string.IsNullOrEmpty(name))
                            {
                                Log.Logger.Warn($"Отсутствует информация об Имени возвещателя с номером участка {currentCard.Number}");
                            }

                            currentCard.CardInfos.Add(new CardInfo() { Name = name, Out = outDate, In = inDate });
                        }
                        k++;
                    }

                    cards.Add(currentCard);
                }

                cardsFromDocument = cards;
            }
            catch (Exception exp)
            {
                Log.Logger.Error($"{exp}. Необрабатываемое исключение в файле.");
                return false;
            }
            finally
            {
                if (Document != null)
                    Document.Close();
                if (Application != null)
                    Application.Quit();
            }
            return true;
        }

        /// <summary>
        /// Проверка таблиц в файле на соответсвие шаблону
        /// </summary>
        /// <param name="tables">Таблицы из документа</param>
        /// <returns></returns>
        private bool ValidationDataTable(Word.Tables tables)
        {
            if (tables.Count != 2)
            {
                Log.Logger.Warn($"Количество таблиц в файле не равно 2.");
                return false;
            }

            if (tables[1].Rows.Count != 1 || tables[1].Columns.Count != 2)
            {
                Log.Logger.Warn($"Первая таблица не соответствует шаблону.");
                return false;
            }

            if (tables[2].Rows.Count != 42 || tables[2].Columns.Count != 10)
            {
                Log.Logger.Warn($"Вторая таблица не соответствует шаблону.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Проверка информации о служебном годе
        /// </summary>
        /// <param name="yearFromTable">Год из документа</param>
        /// <returns></returns>
        private bool ValidatedDataYear(string yearFromTable)
        {
            var year = ClearFromSpecialSymbols(yearFromTable);
            
            if (string.IsNullOrEmpty(year))
            {
                Log.Logger.Warn($"Отсутствует информация о служебном годе.");
                return false;
            }

            if (!Regex.IsMatch(year, @"\d") && (year.Count() != 4 || year.Count() != 2))
            {
                Log.Logger.Warn($"Неверный формат года. Должно быть только число, например, 22 или 2022.");
                return false;
            }

            if (string.IsNullOrEmpty(currentYear))
                currentYear = year;

            if (currentYear != year)
            {
                Log.Logger.Warn($"Данные за разные служебные года. Основной год: {currentYear}; год, полученный из файла: {year}.");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Проверка информация о данных участка
        /// </summary>
        /// <param name="nameFromTable"></param>
        /// <param name="outFromTable"></param>
        /// <param name="inFromTable"></param>
        /// <param name="resultName"></param>
        /// <param name="resultOutDate"></param>
        /// <param name="resultInDate"></param>
        /// <returns></returns>
        private bool ValidatedDataCardInfo(string nameFromTable, string outFromTable, string inFromTable,
            out string resultName, out DateTime? resultOutDate, out DateTime? resultInDate)
        {
            resultName = "";
            resultOutDate = null;
            resultInDate = null;

            var name = ClearFromSpecialSymbols(nameFromTable);
            var outClear = ClearFromSpecialSymbols(outFromTable);
            var inClear = ClearFromSpecialSymbols(inFromTable);

            if (string.IsNullOrEmpty(name) && string.IsNullOrEmpty(outClear) && string.IsNullOrEmpty(inClear))
            {
                return false;
            }

            resultName = name;
            if (DateTime.TryParse(outClear, out DateTime parseOutDate))
                resultOutDate = parseOutDate;
            else if (!string.IsNullOrEmpty(outClear))
                Log.Logger.Warn($"Не удалось получить дату из строки {outClear}.");
            if (DateTime.TryParse(inClear, out DateTime parseInDate))
                resultInDate = parseInDate;
            else if (!string.IsNullOrEmpty(inClear))
                Log.Logger.Warn($"Не удалось получить дату из строки {inClear}.");

            return true;
        }
        
        /// <summary>
        /// Очистка строки от спец символов
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string ClearFromSpecialSymbols(string str)
        {
            if (str == null)
                return "";
            else
                return str.Trim(new Char[] { '\r', '\a' });
        }

        private void btnLoadData_Click(object sender, EventArgs e)
        {
            rdbAll.Checked = true;
            ChangeDesignAndAvailableControls(2);
        }

        private void SelectFilter(object sender, EventArgs e)
        {
            dtgCardInfo.DataSource = null;
            rdbAll.Text = "Все";
            rdbOnHands.Text = "На руках";
            rdbBack.Text = "Просроченные";
            rdbLastDate.Text = "Дата последней обработки";
            dtpDateLast.Style.ForeColor = Color.Black;
            dtpDateLast.Enabled = false;

            var allCards = new List<CardView>();

            if (((RadioButton)sender).Name == "rdbAll")
            {
                allCards = cardCollection.GetCardsAll();
            }

            if (((RadioButton)sender).Name == "rdbOnHands")
            {
                allCards = cardCollection.GetCardsOnHands();
            }

            if (((RadioButton)sender).Name == "rdbBack")
            {
                allCards = cardCollection.GetCardsBack();
            }

            if (((RadioButton)sender).Name == "rdbLastDate")
            {
                dtpDateLast.Enabled = true;
                dtpDateLast.Style.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            }

            ((RadioButton)sender).Text += $" ({allCards.Count})";
            dtgCardInfo.DataSource = allCards;
        }

        /// <summary>
        /// Изменение доступности контролов в зависмости от пройденного шага
        /// </summary>
        /// <param name="stepNumber"></param>
        private void ChangeDesignAndAvailableControls(int stepNumber)
        {
            switch (stepNumber)
            {
                case 1:
                    if (cardCollection.GetCardsAll().Count > 0)
                    {
                        btnLoadData.Enabled = true;
                        btnLoadData.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));

                        lblStep2.Enabled = true;
                        lblStep2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));

                        rdbAll.Checked = false;
                        rdbOnHands.Checked = false;
                        rdbBack.Checked = false;
                        rdbLastDate.Checked = false;

                        dtgCardInfo.DataSource = null;
                    }
                    else
                    {
                        btnLoadData.Enabled = false;
                        btnLoadData.BackColor = Color.Gray;

                        lblStep2.Enabled = false;
                    }

                    dtgCardInfo.Enabled = false;
                    dtgCardInfo.BackColor = System.Drawing.Color.DarkGray;
                    dtgCardInfo.Style.HeaderStyle.BackColor = System.Drawing.Color.Gray;

                    grpFilter.Enabled = false;

                    break;

                case 2:
                    grpFilter.Enabled = true;
                    grpFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));

                    dtgCardInfo.Enabled = true;
                    dtgCardInfo.BackColor = System.Drawing.Color.White;
                    dtgCardInfo.Style.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));

                    break;
            }
        }

        private void FormHome_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.SourceToFolder))
            {
                chbUseDefaultSource.Checked = Properties.Settings.Default.UseDefault;
                txtSourceToFolder.Text = Properties.Settings.Default.SourceToFolder;
            }
        }

        private void chbUseDefaultSource_CheckedChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.UseDefault != chbUseDefaultSource.Checked)
                Properties.Settings.Default.UseDefault = chbUseDefaultSource.Checked;
        }

        public CardCollection GetCardCollection(string source)
        {
            GetAndLoadFiles(source);

            return cardCollection;
        }

        private void dtpDateLast_ValueChanged(object sender, Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventArgs e)
        {
            if (rdbLastDate.Checked)
            {
                dtgCardInfo.DataSource = null;
                var allCards = cardCollection.GetCardsLastDate(e.NewValue.GetValueOrDefault());
                dtgCardInfo.DataSource = allCards;

                rdbLastDate.Text = $"Дата последней обработки ({allCards.Count})";
            }
        }
    }
}
