
namespace AreaCard.Forms
{
    partial class FormAdditionally
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdditionally));
            this.fbdBrowserFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblStep3 = new System.Windows.Forms.Label();
            this.txtSourceToFolder = new System.Windows.Forms.TextBox();
            this.txtSourceEndFolder = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.MaskedTextBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnShowEndFolder = new System.Windows.Forms.Button();
            this.picResult = new System.Windows.Forms.PictureBox();
            this.btnWork = new System.Windows.Forms.Button();
            this.btnSelectEndFolder = new System.Windows.Forms.Button();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.pnlResult = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).BeginInit();
            this.pnlResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(117, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 18);
            this.label1.TabIndex = 6;
            this.label1.Text = "ШАГ №1. Укажите папку с картотекой.";
            // 
            // lblStep2
            // 
            this.lblStep2.AutoSize = true;
            this.lblStep2.Enabled = false;
            this.lblStep2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStep2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblStep2.Location = new System.Drawing.Point(117, 170);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(277, 18);
            this.lblStep2.TabIndex = 7;
            this.lblStep2.Text = "ШАГ №2. Укажите конечную папку.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label2.Location = new System.Drawing.Point(131, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(513, 23);
            this.label2.TabIndex = 8;
            this.label2.Text = "Сформировать файлы для нового служебного года";
            // 
            // lblStep3
            // 
            this.lblStep3.AutoSize = true;
            this.lblStep3.Enabled = false;
            this.lblStep3.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStep3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblStep3.Location = new System.Drawing.Point(117, 245);
            this.lblStep3.Name = "lblStep3";
            this.lblStep3.Size = new System.Drawing.Size(448, 18);
            this.lblStep3.TabIndex = 9;
            this.lblStep3.Text = "ШАГ №3. Укажите служебный год в формате 2022 или 22:";
            // 
            // txtSourceToFolder
            // 
            this.txtSourceToFolder.BackColor = System.Drawing.SystemColors.Control;
            this.txtSourceToFolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSourceToFolder.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSourceToFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.txtSourceToFolder.Location = new System.Drawing.Point(116, 127);
            this.txtSourceToFolder.Name = "txtSourceToFolder";
            this.txtSourceToFolder.ReadOnly = true;
            this.txtSourceToFolder.Size = new System.Drawing.Size(543, 15);
            this.txtSourceToFolder.TabIndex = 10;
            // 
            // txtSourceEndFolder
            // 
            this.txtSourceEndFolder.BackColor = System.Drawing.SystemColors.Control;
            this.txtSourceEndFolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSourceEndFolder.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSourceEndFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.txtSourceEndFolder.Location = new System.Drawing.Point(116, 202);
            this.txtSourceEndFolder.Name = "txtSourceEndFolder";
            this.txtSourceEndFolder.ReadOnly = true;
            this.txtSourceEndFolder.Size = new System.Drawing.Size(543, 15);
            this.txtSourceEndFolder.TabIndex = 11;
            // 
            // txtYear
            // 
            this.txtYear.Enabled = false;
            this.txtYear.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.txtYear.Location = new System.Drawing.Point(586, 242);
            this.txtYear.Mask = "0000";
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 26);
            this.txtYear.TabIndex = 12;
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYear.ValidatingType = typeof(int);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblResult.Location = new System.Drawing.Point(12, 124);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(326, 18);
            this.lblResult.TabIndex = 16;
            this.lblResult.Text = "Операция завершена успешно";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowEndFolder
            // 
            this.btnShowEndFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnShowEndFolder.FlatAppearance.BorderSize = 0;
            this.btnShowEndFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowEndFolder.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowEndFolder.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnShowEndFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnShowEndFolder.Image")));
            this.btnShowEndFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowEndFolder.Location = new System.Drawing.Point(108, 162);
            this.btnShowEndFolder.Name = "btnShowEndFolder";
            this.btnShowEndFolder.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnShowEndFolder.Size = new System.Drawing.Size(134, 34);
            this.btnShowEndFolder.TabIndex = 17;
            this.btnShowEndFolder.Text = "  Просмотр";
            this.btnShowEndFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnShowEndFolder.UseVisualStyleBackColor = false;
            this.btnShowEndFolder.Click += new System.EventHandler(this.btnShowEndFolder_Click);
            // 
            // picResult
            // 
            this.picResult.Image = global::AreaCard.Properties.Resources.Ok;
            this.picResult.Location = new System.Drawing.Point(135, 25);
            this.picResult.Name = "picResult";
            this.picResult.Size = new System.Drawing.Size(80, 80);
            this.picResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picResult.TabIndex = 14;
            this.picResult.TabStop = false;
            // 
            // btnWork
            // 
            this.btnWork.BackColor = System.Drawing.Color.Gray;
            this.btnWork.Enabled = false;
            this.btnWork.FlatAppearance.BorderSize = 0;
            this.btnWork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWork.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnWork.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnWork.Image = ((System.Drawing.Image)(resources.GetObject("btnWork.Image")));
            this.btnWork.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnWork.Location = new System.Drawing.Point(303, 289);
            this.btnWork.Name = "btnWork";
            this.btnWork.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnWork.Size = new System.Drawing.Size(187, 34);
            this.btnWork.TabIndex = 5;
            this.btnWork.Text = "  Сформировать";
            this.btnWork.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnWork.UseVisualStyleBackColor = false;
            this.btnWork.Click += new System.EventHandler(this.btnWork_Click);
            // 
            // btnSelectEndFolder
            // 
            this.btnSelectEndFolder.BackColor = System.Drawing.Color.Gray;
            this.btnSelectEndFolder.Enabled = false;
            this.btnSelectEndFolder.FlatAppearance.BorderSize = 0;
            this.btnSelectEndFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectEndFolder.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectEndFolder.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSelectEndFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectEndFolder.Image")));
            this.btnSelectEndFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectEndFolder.Location = new System.Drawing.Point(459, 162);
            this.btnSelectEndFolder.Name = "btnSelectEndFolder";
            this.btnSelectEndFolder.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSelectEndFolder.Size = new System.Drawing.Size(134, 34);
            this.btnSelectEndFolder.TabIndex = 5;
            this.btnSelectEndFolder.Text = "  Выбрать";
            this.btnSelectEndFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectEndFolder.UseVisualStyleBackColor = false;
            this.btnSelectEndFolder.Click += new System.EventHandler(this.btnSelectEndFolder_Click);
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.btnSelectFolder.FlatAppearance.BorderSize = 0;
            this.btnSelectFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectFolder.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSelectFolder.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSelectFolder.Image = ((System.Drawing.Image)(resources.GetObject("btnSelectFolder.Image")));
            this.btnSelectFolder.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelectFolder.Location = new System.Drawing.Point(459, 87);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSelectFolder.Size = new System.Drawing.Size(134, 34);
            this.btnSelectFolder.TabIndex = 5;
            this.btnSelectFolder.Text = "  Выбрать";
            this.btnSelectFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectFolder.UseVisualStyleBackColor = false;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // pnlResult
            // 
            this.pnlResult.Controls.Add(this.picResult);
            this.pnlResult.Controls.Add(this.btnShowEndFolder);
            this.pnlResult.Controls.Add(this.lblResult);
            this.pnlResult.Location = new System.Drawing.Point(218, 346);
            this.pnlResult.Name = "pnlResult";
            this.pnlResult.Size = new System.Drawing.Size(347, 225);
            this.pnlResult.TabIndex = 18;
            this.pnlResult.Visible = false;
            // 
            // FormAdditionally
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(775, 600);
            this.Controls.Add(this.pnlResult);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtSourceEndFolder);
            this.Controls.Add(this.txtSourceToFolder);
            this.Controls.Add(this.lblStep3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblStep2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnWork);
            this.Controls.Add(this.btnSelectEndFolder);
            this.Controls.Add(this.btnSelectFolder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormAdditionally";
            this.Text = "Дополнительно";
            ((System.ComponentModel.ISupportInitialize)(this.picResult)).EndInit();
            this.pnlResult.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.FolderBrowserDialog fbdBrowserFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStep2;
        private System.Windows.Forms.Button btnSelectEndFolder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblStep3;
        private System.Windows.Forms.TextBox txtSourceToFolder;
        private System.Windows.Forms.TextBox txtSourceEndFolder;
        private System.Windows.Forms.MaskedTextBox txtYear;
        private System.Windows.Forms.Button btnWork;
        private System.Windows.Forms.PictureBox picResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnShowEndFolder;
        private System.Windows.Forms.Panel pnlResult;
    }
}