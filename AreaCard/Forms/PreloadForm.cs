using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AreaCard.Forms
{
    public partial class PreloadForm : Form
    {
        public List<string> Files { get; set; }
        public List<string> NameFiles { get; set; }
        public PreloadForm()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.PreloadForm_Load);
            this.BackgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(this.BackgroundWorker_RunWorkerCompleted);
            lblInfo.Text = "";
        }

        private void BackgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            Close();
        }

        private void PreloadForm_Load(object sender, EventArgs e)
        {
            if (Files != null)
                BackgroundWorker.RunWorkerAsync(Files);

            if (NameFiles != null)
                BackgroundWorker.RunWorkerAsync(NameFiles);
        }

        private void BackgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if ((Files?.Count() ?? 0) != 0)
            {
                lblInfo.Text = $"{e.ProgressPercentage} из {Files.Count()}";
                var i = Convert.ToInt32(e.ProgressPercentage);
                lblNameFile.Text = $"файл: {Files[i - 1].Substring(Files[i - 1].LastIndexOf('\\') + 1)}";
            }

            if ((NameFiles?.Count() ?? 0) != 0)
            {
                lblInfo.Text = $"{e.ProgressPercentage} из {NameFiles.Count()}";
                var i = Convert.ToInt32(e.ProgressPercentage);
                lblNameFile.Text = $"заполнение файла: {NameFiles[i-1]}";
            }
        }
    }
}
