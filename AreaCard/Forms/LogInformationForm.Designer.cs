
namespace AreaCard.Forms
{
    partial class LogInformationForm
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
            Syncfusion.WinForms.DataGrid.GridDateTimeColumn gridDateTimeColumn1 = new Syncfusion.WinForms.DataGrid.GridDateTimeColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn1 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            Syncfusion.WinForms.DataGrid.GridTextColumn gridTextColumn2 = new Syncfusion.WinForms.DataGrid.GridTextColumn();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogInformationForm));
            this.dtgLog = new Syncfusion.WinForms.DataGrid.SfDataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblCountAllFiles = new System.Windows.Forms.Label();
            this.lblCountReadyFiles = new System.Windows.Forms.Label();
            this.lblCountCards = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLog)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgLog
            // 
            this.dtgLog.AccessibleName = "Table";
            this.dtgLog.AllowGrouping = false;
            this.dtgLog.AllowSorting = false;
            this.dtgLog.AutoSizeColumnsMode = Syncfusion.WinForms.DataGrid.Enums.AutoSizeColumnsMode.LastColumnFill;
            gridDateTimeColumn1.AllowGrouping = false;
            gridDateTimeColumn1.AllowSorting = false;
            gridDateTimeColumn1.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridDateTimeColumn1.Format = "dd-mm-yyyy hh:mm:ss";
            gridDateTimeColumn1.HeaderText = "Дата и время";
            gridDateTimeColumn1.MappingName = "DateTimeRecord";
            gridDateTimeColumn1.MaxDateTime = new System.DateTime(9999, 12, 31, 23, 59, 59, 999);
            gridDateTimeColumn1.Pattern = Syncfusion.WinForms.Input.Enums.DateTimePattern.SortableDateTime;
            gridDateTimeColumn1.Width = 160D;
            gridTextColumn1.AllowGrouping = false;
            gridTextColumn1.AllowSorting = false;
            gridTextColumn1.CellStyle.HorizontalAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            gridTextColumn1.HeaderText = "Тип ошибки";
            gridTextColumn1.MappingName = "TypeRecord";
            gridTextColumn1.Width = 110D;
            gridTextColumn2.AllowGrouping = false;
            gridTextColumn2.AllowSorting = false;
            gridTextColumn2.AllowTextWrapping = true;
            gridTextColumn2.HeaderText = "Описание";
            gridTextColumn2.MappingName = "DescriptionRecord";
            this.dtgLog.Columns.Add(gridDateTimeColumn1);
            this.dtgLog.Columns.Add(gridTextColumn1);
            this.dtgLog.Columns.Add(gridTextColumn2);
            this.dtgLog.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgLog.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dtgLog.Location = new System.Drawing.Point(5, 185);
            this.dtgLog.Name = "dtgLog";
            this.dtgLog.Size = new System.Drawing.Size(790, 310);
            this.dtgLog.Style.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgLog.Style.CellStyle.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.dtgLog.Style.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.dtgLog.Style.HeaderStyle.FilterIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(29)))), ((int)(((byte)(29)))));
            this.dtgLog.Style.HeaderStyle.Font.Bold = true;
            this.dtgLog.Style.HeaderStyle.Font.Facename = "Century Gothic";
            this.dtgLog.Style.HeaderStyle.Font.Size = 11.25F;
            this.dtgLog.Style.HeaderStyle.TextColor = System.Drawing.Color.Gainsboro;
            this.dtgLog.TabIndex = 0;
            this.dtgLog.Text = "sfDataGrid1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 495);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 5);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 5);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(5, 490);
            this.panel3.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(795, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 490);
            this.panel4.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(790, 35);
            this.label1.TabIndex = 2;
            this.label1.Text = "Информация о проделанной работе";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(766, 9);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(21, 21);
            this.btnClose.TabIndex = 4;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(5, 40);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(61, 145);
            this.panel5.TabIndex = 5;
            // 
            // lblCountAllFiles
            // 
            this.lblCountAllFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCountAllFiles.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountAllFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblCountAllFiles.Location = new System.Drawing.Point(66, 40);
            this.lblCountAllFiles.Name = "lblCountAllFiles";
            this.lblCountAllFiles.Size = new System.Drawing.Size(729, 40);
            this.lblCountAllFiles.TabIndex = 6;
            this.lblCountAllFiles.Text = "Общее количество обнаруженных файлов в папке:";
            this.lblCountAllFiles.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblCountReadyFiles
            // 
            this.lblCountReadyFiles.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCountReadyFiles.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountReadyFiles.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblCountReadyFiles.Location = new System.Drawing.Point(66, 80);
            this.lblCountReadyFiles.Name = "lblCountReadyFiles";
            this.lblCountReadyFiles.Size = new System.Drawing.Size(729, 30);
            this.lblCountReadyFiles.TabIndex = 7;
            this.lblCountReadyFiles.Text = "Количество успешно обработанных файлов:";
            this.lblCountReadyFiles.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lblCountCards
            // 
            this.lblCountCards.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCountCards.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblCountCards.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.lblCountCards.Location = new System.Drawing.Point(66, 110);
            this.lblCountCards.Name = "lblCountCards";
            this.lblCountCards.Size = new System.Drawing.Size(729, 30);
            this.lblCountCards.TabIndex = 8;
            this.lblCountCards.Text = "Количество полученных участков:";
            this.lblCountCards.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.label5.Location = new System.Drawing.Point(66, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(729, 35);
            this.label5.TabIndex = 9;
            this.label5.Text = "Проверьте информацию в таблице ниже. Обратите внимание на выделенные строки.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // LogInformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblCountCards);
            this.Controls.Add(this.lblCountReadyFiles);
            this.Controls.Add(this.lblCountAllFiles);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.dtgLog);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LogInformationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LogInformation";
            this.Load += new System.EventHandler(this.LogInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.WinForms.DataGrid.SfDataGrid dtgLog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblCountAllFiles;
        private System.Windows.Forms.Label lblCountReadyFiles;
        private System.Windows.Forms.Label lblCountCards;
        private System.Windows.Forms.Label label5;
    }
}