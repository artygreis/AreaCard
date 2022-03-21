using AreaCard.Settings;
using Squirrel;
using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace AreaCard.Forms
{
    public partial class FormSettings : Form
    {
        public Button ButtonSettings { get; set; }
        public bool AvailableUpdate { get; set; }
        public FormSettings()
        {
            InitializeComponent();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            picLoading.Visible = true;
            lblVersion.Visible = false;
            btnInstallUpdate.Visible = false;
#if (!DEBUG)
            UpdateCheck();
#endif
        }
        private async void UpdateCheck()
        {
            var result = await Settings.Update.CheckForUpdates();
            picLoading.Visible = false;
            if (result)
            {
                lblVersion.Text = "Найдена новая версия!!!";
                btnInstallUpdate.Visible = true;
                if (ButtonSettings != null)
                    SettingsPicture.AddTextToPicture(ButtonSettings);
            }
            else
            {
                lblVersion.Text = "Обновлений нет.";
                btnInstallUpdate.Visible = false;
            }
        }
        private void FormSettings_Load(object sender, EventArgs e)
        {
            picLoading.Visible = false;
            if (AvailableUpdate)
            {
                lblVersion.Text = "Найдена новая версия!!!";
            }
            lblVersion.Visible = AvailableUpdate;
            btnInstallUpdate.Visible = AvailableUpdate;
        }

        private void btnInstallUpdate_Click(object sender, EventArgs e)
        {
            UpdateManager.RestartApp(Path.GetFileName(Assembly.GetEntryAssembly().Location).Replace(".dll", ".exe"));
        }
    }
}
