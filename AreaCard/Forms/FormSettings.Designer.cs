
namespace AreaCard.Forms
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
            this.label2 = new System.Windows.Forms.Label();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnInstallUpdate = new System.Windows.Forms.Button();
            this.picLoading = new System.Windows.Forms.PictureBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.txtInformation = new System.Windows.Forms.TextBox();
            this.lnkLbInfo = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(775, 40);
            this.label2.TabIndex = 9;
            this.label2.Text = "Обновление программы";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnCheck.FlatAppearance.BorderSize = 0;
            this.btnCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheck.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnCheck.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCheck.Image = ((System.Drawing.Image)(resources.GetObject("btnCheck.Image")));
            this.btnCheck.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCheck.Location = new System.Drawing.Point(268, 63);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnCheck.Size = new System.Drawing.Size(239, 34);
            this.btnCheck.TabIndex = 10;
            this.btnCheck.Text = "  Проверить обновление";
            this.btnCheck.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnInstallUpdate
            // 
            this.btnInstallUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnInstallUpdate.FlatAppearance.BorderSize = 0;
            this.btnInstallUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInstallUpdate.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnInstallUpdate.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInstallUpdate.Image = ((System.Drawing.Image)(resources.GetObject("btnInstallUpdate.Image")));
            this.btnInstallUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInstallUpdate.Location = new System.Drawing.Point(252, 158);
            this.btnInstallUpdate.Name = "btnInstallUpdate";
            this.btnInstallUpdate.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnInstallUpdate.Size = new System.Drawing.Size(270, 34);
            this.btnInstallUpdate.TabIndex = 11;
            this.btnInstallUpdate.Text = " Перезапустить программу";
            this.btnInstallUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInstallUpdate.UseVisualStyleBackColor = false;
            this.btnInstallUpdate.Visible = false;
            this.btnInstallUpdate.Click += new System.EventHandler(this.btnInstallUpdate_Click);
            // 
            // picLoading
            // 
            this.picLoading.Image = ((System.Drawing.Image)(resources.GetObject("picLoading.Image")));
            this.picLoading.Location = new System.Drawing.Point(311, 116);
            this.picLoading.Name = "picLoading";
            this.picLoading.Size = new System.Drawing.Size(152, 19);
            this.picLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLoading.TabIndex = 12;
            this.picLoading.TabStop = false;
            this.picLoading.Visible = false;
            // 
            // lblVersion
            // 
            this.lblVersion.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblVersion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblVersion.Location = new System.Drawing.Point(268, 116);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(239, 18);
            this.lblVersion.TabIndex = 13;
            this.lblVersion.Text = "Найдена новая версия";
            this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblVersion.Visible = false;
            // 
            // txtInformation
            // 
            this.txtInformation.BackColor = System.Drawing.SystemColors.Control;
            this.txtInformation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtInformation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.txtInformation.Location = new System.Drawing.Point(53, 508);
            this.txtInformation.Multiline = true;
            this.txtInformation.Name = "txtInformation";
            this.txtInformation.ReadOnly = true;
            this.txtInformation.Size = new System.Drawing.Size(680, 66);
            this.txtInformation.TabIndex = 14;
            this.txtInformation.Text = "Программа предназначена только для личного использования. С любыми предложениями " +
    "и замечаниями по работе с программой можете направлять по электронной почте area" +
    ".card22@gmail.com.";
            // 
            // lnkLbInfo
            // 
            this.lnkLbInfo.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lnkLbInfo.AutoSize = true;
            this.lnkLbInfo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lnkLbInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lnkLbInfo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lnkLbInfo.Location = new System.Drawing.Point(232, 474);
            this.lnkLbInfo.Name = "lnkLbInfo";
            this.lnkLbInfo.Size = new System.Drawing.Size(314, 19);
            this.lnkLbInfo.TabIndex = 15;
            this.lnkLbInfo.TabStop = true;
            this.lnkLbInfo.Text = "Посмотреть сведения об изменениях";
            this.lnkLbInfo.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lnkLbInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLbInfo_LinkClicked);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(775, 600);
            this.Controls.Add(this.lnkLbInfo);
            this.Controls.Add(this.txtInformation);
            this.Controls.Add(this.picLoading);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnInstallUpdate);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSettings";
            this.Text = "Настройки";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picLoading)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnInstallUpdate;
        private System.Windows.Forms.PictureBox picLoading;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.TextBox txtInformation;
        private System.Windows.Forms.LinkLabel lnkLbInfo;
    }
}