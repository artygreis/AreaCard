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
    public partial class FormInfoVersion : Form
    {
        public FormInfoVersion()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FormInfoVersion_Load(object sender, EventArgs e)
        {
            string info = Properties.Resources.app_ver;
            if (!string.IsNullOrEmpty(info))
            {
                rchbInfo.Text = info;
            }
        }
    }
}
