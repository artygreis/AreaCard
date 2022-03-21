
namespace AreaCard.Forms
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn1 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn2 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn3 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblStep2 = new System.Windows.Forms.Label();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.btnLoadData = new System.Windows.Forms.Button();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.dtpDateLast = new Syncfusion.WinForms.Input.SfDateTimeEdit();
            this.rdbLastDate = new System.Windows.Forms.RadioButton();
            this.rdbBack = new System.Windows.Forms.RadioButton();
            this.rdbOnHands = new System.Windows.Forms.RadioButton();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.fbdBrowserFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.dtgCardInfo = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.chbUseDefaultSource = new System.Windows.Forms.CheckBox();
            this.txtSourceToFolder = new System.Windows.Forms.TextBox();
            this.grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCardInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(77, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "ШАГ №1. Укажите папку с картотекой.";
            // 
            // lblStep2
            // 
            this.lblStep2.AutoSize = true;
            this.lblStep2.Enabled = false;
            this.lblStep2.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblStep2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblStep2.Location = new System.Drawing.Point(77, 131);
            this.lblStep2.Name = "lblStep2";
            this.lblStep2.Size = new System.Drawing.Size(222, 18);
            this.lblStep2.TabIndex = 2;
            this.lblStep2.Text = "ШАГ №2. Загрузите данные.";
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
            this.btnSelectFolder.Location = new System.Drawing.Point(419, 31);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnSelectFolder.Size = new System.Drawing.Size(134, 34);
            this.btnSelectFolder.TabIndex = 4;
            this.btnSelectFolder.Text = "  Выбрать";
            this.btnSelectFolder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSelectFolder.UseVisualStyleBackColor = false;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // btnLoadData
            // 
            this.btnLoadData.BackColor = System.Drawing.Color.Gray;
            this.btnLoadData.Enabled = false;
            this.btnLoadData.FlatAppearance.BorderSize = 0;
            this.btnLoadData.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadData.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoadData.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLoadData.Image = ((System.Drawing.Image)(resources.GetObject("btnLoadData.Image")));
            this.btnLoadData.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoadData.Location = new System.Drawing.Point(419, 123);
            this.btnLoadData.Name = "btnLoadData";
            this.btnLoadData.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.btnLoadData.Size = new System.Drawing.Size(134, 34);
            this.btnLoadData.TabIndex = 4;
            this.btnLoadData.Text = "  Загрузить";
            this.btnLoadData.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoadData.UseVisualStyleBackColor = false;
            this.btnLoadData.Click += new System.EventHandler(this.btnLoadData_Click);
            // 
            // grpFilter
            // 
            this.grpFilter.BackColor = System.Drawing.Color.Gainsboro;
            this.grpFilter.Controls.Add(this.dtpDateLast);
            this.grpFilter.Controls.Add(this.rdbLastDate);
            this.grpFilter.Controls.Add(this.rdbBack);
            this.grpFilter.Controls.Add(this.rdbOnHands);
            this.grpFilter.Controls.Add(this.rdbAll);
            this.grpFilter.Enabled = false;
            this.grpFilter.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.grpFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.grpFilter.Location = new System.Drawing.Point(72, 171);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(625, 93);
            this.grpFilter.TabIndex = 5;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "ШАГ №3. Воспользуйтесь фильтром.";
            // 
            // dtpDateLast
            // 
            this.dtpDateLast.Enabled = false;
            this.dtpDateLast.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtpDateLast.Location = new System.Drawing.Point(500, 54);
            this.dtpDateLast.Name = "dtpDateLast";
            this.dtpDateLast.Size = new System.Drawing.Size(118, 31);
            this.dtpDateLast.Style.BackColor = System.Drawing.Color.White;
            this.dtpDateLast.Style.ForeColor = System.Drawing.Color.Black;
            this.dtpDateLast.TabIndex = 7;
            this.dtpDateLast.Value = new System.DateTime(2022, 3, 11, 0, 0, 0, 0);
            this.dtpDateLast.ValueChanged += new Syncfusion.WinForms.Input.Events.DateTimeValueChangedEventHandler(this.dtpDateLast_ValueChanged);
            // 
            // rdbLastDate
            // 
            this.rdbLastDate.AutoSize = true;
            this.rdbLastDate.Location = new System.Drawing.Point(209, 58);
            this.rdbLastDate.Name = "rdbLastDate";
            this.rdbLastDate.Size = new System.Drawing.Size(244, 22);
            this.rdbLastDate.TabIndex = 1;
            this.rdbLastDate.Text = "Дата последней обработки";
            this.rdbLastDate.UseVisualStyleBackColor = true;
            this.rdbLastDate.CheckedChanged += new System.EventHandler(this.SelectFilter);
            // 
            // rdbBack
            // 
            this.rdbBack.AutoSize = true;
            this.rdbBack.Location = new System.Drawing.Point(13, 58);
            this.rdbBack.Name = "rdbBack";
            this.rdbBack.Size = new System.Drawing.Size(144, 22);
            this.rdbBack.TabIndex = 1;
            this.rdbBack.Text = "Просроченные";
            this.rdbBack.UseVisualStyleBackColor = true;
            this.rdbBack.CheckedChanged += new System.EventHandler(this.SelectFilter);
            // 
            // rdbOnHands
            // 
            this.rdbOnHands.AutoSize = true;
            this.rdbOnHands.Location = new System.Drawing.Point(209, 30);
            this.rdbOnHands.Name = "rdbOnHands";
            this.rdbOnHands.Size = new System.Drawing.Size(95, 22);
            this.rdbOnHands.TabIndex = 0;
            this.rdbOnHands.Text = "На руках";
            this.rdbOnHands.UseVisualStyleBackColor = true;
            this.rdbOnHands.CheckedChanged += new System.EventHandler(this.SelectFilter);
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Location = new System.Drawing.Point(13, 30);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(55, 22);
            this.rdbAll.TabIndex = 0;
            this.rdbAll.Text = "Все";
            this.rdbAll.UseVisualStyleBackColor = true;
            this.rdbAll.CheckedChanged += new System.EventHandler(this.SelectFilter);
            // 
            // dtgCardInfo
            // 
            this.dtgCardInfo.AccessibleName = "Table";
            this.dtgCardInfo.AllowSorting = false;
            this.dtgCardInfo.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.LastColumnFill;
            this.dtgCardInfo.BackColor = System.Drawing.Color.DarkGray;
            gridTextColumn1.AllowHeaderTextWrapping = true;
            gridTextColumn1.AllowSorting = false;
            gridTextColumn1.HeaderText = "Номер участка";
            gridTextColumn1.MappingName = "Number";
            gridTextColumn1.Width = 90D;
            gridDateTimeColumn1.AllowHeaderTextWrapping = true;
            gridDateTimeColumn1.AllowSorting = false;
            gridDateTimeColumn1.HeaderText = "Дата последней обработки";
            gridDateTimeColumn1.MappingName = "LastDate";
            gridDateTimeColumn1.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn1.Width = 120D;
            gridTextColumn2.AllowHeaderTextWrapping = true;
            gridTextColumn2.AllowSorting = false;
            gridTextColumn2.HeaderText = "Имя";
            gridTextColumn2.MappingName = "Name";
            gridTextColumn2.Width = 120D;
            gridDateTimeColumn2.AllowHeaderTextWrapping = true;
            gridDateTimeColumn2.AllowSorting = false;
            gridDateTimeColumn2.HeaderText = "Дата выдачи";
            gridDateTimeColumn2.MappingName = "Out";
            gridDateTimeColumn2.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn2.Width = 140D;
            gridDateTimeColumn3.AllowHeaderTextWrapping = true;
            gridDateTimeColumn3.AllowSorting = false;
            gridDateTimeColumn3.HeaderText = "Дата сдачи";
            gridDateTimeColumn3.MappingName = "In";
            gridDateTimeColumn3.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            this.dtgCardInfo.Columns.Add(gridTextColumn1);
            this.dtgCardInfo.Columns.Add(gridDateTimeColumn1);
            this.dtgCardInfo.Columns.Add(gridTextColumn2);
            this.dtgCardInfo.Columns.Add(gridDateTimeColumn2);
            this.dtgCardInfo.Columns.Add(gridDateTimeColumn3);
            this.dtgCardInfo.Enabled = false;
            this.dtgCardInfo.HeaderRowHeight = 62;
            this.dtgCardInfo.Location = new System.Drawing.Point(72, 270);
            this.dtgCardInfo.Name = "dtgCardInfo";
            this.dtgCardInfo.Size = new System.Drawing.Size(625, 309);
            this.dtgCardInfo.Style.Border3DStyle = System.Windows.Forms.Border3DStyle.Flat;
            this.dtgCardInfo.Style.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.dtgCardInfo.Style.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dtgCardInfo.Style.CellStyle.BackColor = System.Drawing.Color.Empty;
            this.dtgCardInfo.Style.CellStyle.Font.Bold = true;
            this.dtgCardInfo.Style.CellStyle.Font.Facename = "Century Gothic";
            this.dtgCardInfo.Style.CellStyle.Font.Size = 10F;
            this.dtgCardInfo.Style.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.dtgCardInfo.Style.CellStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.dtgCardInfo.Style.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.dtgCardInfo.Style.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dtgCardInfo.Style.HeaderStyle.Font.Bold = true;
            this.dtgCardInfo.Style.HeaderStyle.Font.Facename = "Century Gothic";
            this.dtgCardInfo.Style.HeaderStyle.Font.Size = 11.25F;
            this.dtgCardInfo.Style.HeaderStyle.TextColor = System.Drawing.Color.Gainsboro;
            this.dtgCardInfo.TabIndex = 6;
            this.dtgCardInfo.Text = "sfDataGrid1";
            // 
            // chbUseDefaultSource
            // 
            this.chbUseDefaultSource.AutoSize = true;
            this.chbUseDefaultSource.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbUseDefaultSource.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.chbUseDefaultSource.Location = new System.Drawing.Point(117, 63);
            this.chbUseDefaultSource.Name = "chbUseDefaultSource";
            this.chbUseDefaultSource.Size = new System.Drawing.Size(241, 20);
            this.chbUseDefaultSource.TabIndex = 7;
            this.chbUseDefaultSource.Text = "Использовать путь к картотеке:";
            this.chbUseDefaultSource.UseVisualStyleBackColor = true;
            this.chbUseDefaultSource.CheckedChanged += new System.EventHandler(this.chbUseDefaultSource_CheckedChanged);
            // 
            // txtSourceToFolder
            // 
            this.txtSourceToFolder.BackColor = System.Drawing.SystemColors.Control;
            this.txtSourceToFolder.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSourceToFolder.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtSourceToFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.txtSourceToFolder.Location = new System.Drawing.Point(117, 89);
            this.txtSourceToFolder.Name = "txtSourceToFolder";
            this.txtSourceToFolder.ReadOnly = true;
            this.txtSourceToFolder.Size = new System.Drawing.Size(543, 15);
            this.txtSourceToFolder.TabIndex = 8;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(775, 600);
            this.Controls.Add(this.txtSourceToFolder);
            this.Controls.Add(this.chbUseDefaultSource);
            this.Controls.Add(this.dtgCardInfo);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.btnLoadData);
            this.Controls.Add(this.btnSelectFolder);
            this.Controls.Add(this.lblStep2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormHome";
            this.Text = "Главная";
            this.Load += new System.EventHandler(this.FormHome_Load);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCardInfo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblStep2;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Button btnLoadData;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.RadioButton rdbBack;
        private System.Windows.Forms.RadioButton rdbLastDate;
        private System.Windows.Forms.RadioButton rdbOnHands;
        private Syncfusion.WinForms.Input.SfDateTimeEdit dtpDateLast;
        private System.Windows.Forms.FolderBrowserDialog fbdBrowserFolder;
        private Syncfusion.WinForms.DataGrid.SfDataGrid dtgCardInfo;
        private System.Windows.Forms.CheckBox chbUseDefaultSource;
        private System.Windows.Forms.TextBox txtSourceToFolder;
    }
}