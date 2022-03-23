using AreaCard.Properties;
using AreaCard.Type;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Xceed.Words.NET;
using Xceed.Document.NET;

namespace AreaCard.Forms
{
    public partial class FormAdditionally : Form
    {
        private CardCollection cardCollection;
        private string sourceEndFolder;

        public FormAdditionally()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Выбор папки с картотекой
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            if (fbdBrowserFolder.ShowDialog() == DialogResult.OK)
            {
                pnlResult.Visible = false;

                cardCollection = new CardCollection();

                var source = fbdBrowserFolder.SelectedPath;
                var formHome = new FormHome();
                cardCollection = formHome.GetCardCollection(source);

                txtSourceToFolder.Text = source;

                lblStep3.Enabled = false;
                txtYear.Text = "";
                txtYear.Enabled = false;

                btnWork.Enabled = false;
                btnWork.BackColor = Color.Gray;

                txtSourceEndFolder.Text = "";
                
                if (cardCollection.GetCardsAll().Count > 0)
                {
                    lblStep2.Enabled = true;
                    txtSourceEndFolder.Enabled = true;
                    btnSelectEndFolder.Enabled = true;
                    btnSelectEndFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
                }
                else
                {
                    lblStep2.Enabled = false;
                    txtSourceEndFolder.Enabled = false;
                    btnSelectEndFolder.Enabled = false;
                    btnSelectEndFolder.BackColor = Color.Gray;
                }
            }
        }

        /// <summary>
        /// Выбор конечной папки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSelectEndFolder_Click(object sender, EventArgs e)
        {
            if (fbdBrowserFolder.ShowDialog() == DialogResult.OK)
            {
                sourceEndFolder = fbdBrowserFolder.SelectedPath;

                txtSourceEndFolder.Text = sourceEndFolder;

                lblStep3.Enabled = true;
                txtYear.Text = "";
                txtYear.Enabled = true;

                btnWork.Enabled = true;
                btnWork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            }
        }

        /// <summary>
        /// Запуск обработки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnWork_Click(object sender, EventArgs e)
        {
            if (!File.Exists(Properties.Settings.Default.FileTemplate))
            {
                MessageBox.Show("Не найден шаблон для заолнения данных. Проверьте, чтобы шаблон был здесь:\n" +
                    $"{Assembly.GetExecutingAssembly().Location.Substring(0, Assembly.GetExecutingAssembly().Location.LastIndexOf('\\')+1)}{Properties.Settings.Default.FileTemplate}", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (txtYear.Text.Length == 2 || txtYear.Text.Length == 4)
            {
                var nameFiles = new List<string>();
                var numberCards = cardCollection.GetNumberCards();
                for (var i = 0; i < numberCards.Count; i += 20)
                {
                    nameFiles.Add($"{numberCards[i]}-{(i + 19 < numberCards.Count ? numberCards[i + 19] : numberCards.Last())} ({txtYear.Text}).docx");
                }

                PreloadForm preload = new PreloadForm();
                preload.NameFiles = nameFiles;
                preload.BackgroundWorker.DoWork += SaveFiles;
                preload.ShowDialog();

                pnlResult.Visible = true;
            }
            else
            {
                MessageBox.Show("Введите служебный год в нужном формате: 2 или 4 цифры", "Предупреждение!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }

        /// <summary>
        /// Сохранение документа
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveFiles(object sender, DoWorkEventArgs e)
        {
            var worker = sender as BackgroundWorker;

            var nameFiles = (List<string>)e.Argument;

            var firstIndex = 0;

            //цикл для прохода по файлам
            for (int i = 0; i < nameFiles.Count; i++)
            {
                worker.ReportProgress(i + 1);

                if (!WriteDataToFile(nameFiles[i], ref firstIndex))
                {
                    picResult.Image = Resources.Error;
                    lblResult.Text = "Операция не была завершена до конца";
                    break;
                }
            }
        }

        /// <summary>
        /// Запись данных в файл
        /// </summary>
        /// <param name="nameFile"></param>
        /// <param name="firstIndex"></param>
        /// <returns></returns>
        private bool WriteDataToFile(string nameFile, ref int firstIndex)
        {
            var sourceTemplate = $"{Assembly.GetExecutingAssembly().Location.Substring(0, Assembly.GetExecutingAssembly().Location.LastIndexOf('\\') + 1)}{Properties.Settings.Default.FileTemplate}";
            try
            {

                using (DocX document = DocX.Load(sourceTemplate))
                {
                    document.Tables[0].Rows[0].Cells[1].Paragraphs.First().Append(txtYear.Text).Bold();

                    var table = document.Tables[1];

                    var cards = cardCollection.GetCardsAll();
                    var lastIndex = firstIndex;
                    if (cards.Count > firstIndex + 19)
                        lastIndex = firstIndex + 20;
                    else
                        lastIndex = cards.IndexOf(cards.Last());
                    var k = 0;

                    for (int i = firstIndex; i < lastIndex; i++)
                    {
                        table.Rows[2 + k].Cells[0].Paragraphs.First().Append(cards[i].Number);

                        var lastDate = "";
                        if (cards[i].In.GetValueOrDefault() > cards[i].LastDate.GetValueOrDefault())
                        {
                            lastDate = cards[i].In.GetValueOrDefault().ToString("dd.MM.yy");
                        }
                        else if (cards[i].In.GetValueOrDefault() == DateTime.MinValue && (!string.IsNullOrEmpty(cards[i].Name) || cards[i].Out.GetValueOrDefault() != DateTime.MinValue))
                        {
                            lastDate = "не сдан";
                        }
                        else if (cards[i].LastDate.GetValueOrDefault() != DateTime.MinValue)
                        {
                            lastDate = cards[i].LastDate.GetValueOrDefault().ToString("dd.MM.yy");
                        }
                        else
                        {
                            lastDate = "";
                        }
                        table.Rows[2 + k].Cells[1].Paragraphs.First().Append(lastDate);
                        k += 2;
                    }
                    firstIndex = lastIndex;
                    document.SaveAs(sourceEndFolder + '\\' + nameFile);
                }
            }
            catch
            {
                MessageBox.Show("Возникла критическая ошибка, дальнейшее формирование буде прервано", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void btnShowEndFolder_Click(object sender, EventArgs e)
        {
            Process.Start(sourceEndFolder);
        }
    }
}
