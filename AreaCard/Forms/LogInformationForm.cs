using AreaCard.Type;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaCard.Forms
{
    public partial class LogInformationForm : Form
    {
        public LogInformation LogInformation { get; set; }

        RowAutoFitOptions autoFitOptions = new RowAutoFitOptions();
        public LogInformationForm()
        {
            InitializeComponent();
            dtgLog.QueryRowStyle += DtgLog_QueryRowStyle;
            dtgLog.QueryRowHeight += DtgLog_QueryRowHeight;
        }
        int autoHeight;
        private void DtgLog_QueryRowHeight(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowHeightEventArgs e)
        {
            if (dtgLog.AutoSizeController.GetAutoRowHeight(e.RowIndex, autoFitOptions, out autoHeight))
            {
                if (autoHeight > 28)
                {
                    e.Height = autoHeight;
                    e.Handled = true;
                }
            }
        }

        private void DtgLog_QueryRowStyle(object sender, Syncfusion.WinForms.DataGrid.Events.QueryRowStyleEventArgs e)
        {
            if (e.RowType == RowType.DefaultRow)
            {
                if ((e.RowData as LogData).TypeRecord == "WARN")
                    e.Style.BackColor = Color.LightCoral;
                if ((e.RowData as LogData).TypeRecord == "INFO")
                    e.Style.BackColor = Color.LightBlue;
            }
        }

        private void LogInformation_Load(object sender, EventArgs e)
        {
            if (LogInformation != null)
            {
                lblCountAllFiles.Text += $" {LogInformation.CountAllFiles}";
                lblCountReadyFiles.Text += $" {LogInformation.CountReadyFiles}";
                lblCountCards.Text += $" {LogInformation.CountCards}";
            }

            dtgLog.DataSource = null;

            string file = Directory.GetFiles(Properties.Settings.Default.SourceLogDefault, "*.log",
                                                SearchOption.AllDirectories).Where(f => !f.Contains("$")).FirstOrDefault();
            var logs = new List<LogData>();

            if (!string.IsNullOrEmpty(file))
            {
                string[] lines = File.ReadAllLines(file, Encoding.GetEncoding(1251));

                foreach (var line in lines)
                {
                    var result = line.Split(new char[] { ' ' }, 4);
                    logs.Add(new LogData() { DateTimeRecord = Convert.ToDateTime($"{result[0]} {result[1]}"), TypeRecord = result[2], DescriptionRecord = result[3] });

                }
            }
            if (logs.Count > 0)
                dtgLog.DataSource = logs;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
