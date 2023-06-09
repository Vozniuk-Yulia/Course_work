﻿namespace Neodent.Forms
{
    partial class PatientHistoryForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.removePatientHistory = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.AddPatientHistoryBtn = new System.Windows.Forms.Button();
            this.txtPatientHistoryMiddlename = new System.Windows.Forms.Label();
            this.txtPatientHistorySurname = new System.Windows.Forms.Label();
            this.txtPatientHistoryName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.patientHistoryDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientHistoryDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.removePatientHistory);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.AddPatientHistoryBtn);
            this.panel1.Controls.Add(this.txtPatientHistoryMiddlename);
            this.panel1.Controls.Add(this.txtPatientHistorySurname);
            this.panel1.Controls.Add(this.txtPatientHistoryName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 129);
            this.panel1.TabIndex = 0;
            // 
            // removePatientHistory
            // 
            this.removePatientHistory.BackgroundImage = global::Neodent.Properties.Resources.remove_cross_icon;
            this.removePatientHistory.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removePatientHistory.Location = new System.Drawing.Point(1084, 12);
            this.removePatientHistory.Name = "removePatientHistory";
            this.removePatientHistory.Size = new System.Drawing.Size(41, 41);
            this.removePatientHistory.TabIndex = 5;
            this.removePatientHistory.UseVisualStyleBackColor = true;
            this.removePatientHistory.Click += new System.EventHandler(this.removePatientHistory_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Neodent.Properties.Resources.sign_document_icon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(1017, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 41);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // AddPatientHistoryBtn
            // 
            this.AddPatientHistoryBtn.BackgroundImage = global::Neodent.Properties.Resources.mathematics_sign_plus_round_icon;
            this.AddPatientHistoryBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AddPatientHistoryBtn.Location = new System.Drawing.Point(943, 12);
            this.AddPatientHistoryBtn.Name = "AddPatientHistoryBtn";
            this.AddPatientHistoryBtn.Size = new System.Drawing.Size(43, 41);
            this.AddPatientHistoryBtn.TabIndex = 3;
            this.AddPatientHistoryBtn.UseVisualStyleBackColor = true;
            this.AddPatientHistoryBtn.Click += new System.EventHandler(this.AddPatientHistoryBtn_Click);
            // 
            // txtPatientHistoryMiddlename
            // 
            this.txtPatientHistoryMiddlename.AutoSize = true;
            this.txtPatientHistoryMiddlename.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPatientHistoryMiddlename.Location = new System.Drawing.Point(458, 18);
            this.txtPatientHistoryMiddlename.Name = "txtPatientHistoryMiddlename";
            this.txtPatientHistoryMiddlename.Size = new System.Drawing.Size(128, 25);
            this.txtPatientHistoryMiddlename.TabIndex = 2;
            this.txtPatientHistoryMiddlename.Text = "По-батькові";
            // 
            // txtPatientHistorySurname
            // 
            this.txtPatientHistorySurname.AutoSize = true;
            this.txtPatientHistorySurname.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPatientHistorySurname.Location = new System.Drawing.Point(227, 17);
            this.txtPatientHistorySurname.Name = "txtPatientHistorySurname";
            this.txtPatientHistorySurname.Size = new System.Drawing.Size(103, 25);
            this.txtPatientHistorySurname.TabIndex = 1;
            this.txtPatientHistorySurname.Text = "Прізвище";
            // 
            // txtPatientHistoryName
            // 
            this.txtPatientHistoryName.AutoSize = true;
            this.txtPatientHistoryName.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtPatientHistoryName.Location = new System.Drawing.Point(44, 13);
            this.txtPatientHistoryName.Name = "txtPatientHistoryName";
            this.txtPatientHistoryName.Size = new System.Drawing.Size(54, 30);
            this.txtPatientHistoryName.TabIndex = 0;
            this.txtPatientHistoryName.Text = "Ім\'я";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.patientHistoryDataGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 129);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1148, 466);
            this.panel2.TabIndex = 1;
            // 
            // patientHistoryDataGrid
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.patientHistoryDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.patientHistoryDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patientHistoryDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.patientHistoryDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patientHistoryDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.patientHistoryDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 13.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.patientHistoryDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.patientHistoryDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.patientHistoryDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.patientHistoryDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.patientHistoryDataGrid.DoubleBuffered = true;
            this.patientHistoryDataGrid.EnableHeadersVisualStyles = false;
            this.patientHistoryDataGrid.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.patientHistoryDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.patientHistoryDataGrid.Location = new System.Drawing.Point(49, 27);
            this.patientHistoryDataGrid.Name = "patientHistoryDataGrid";
            this.patientHistoryDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.patientHistoryDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.patientHistoryDataGrid.RowHeadersVisible = false;
            this.patientHistoryDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientHistoryDataGrid.Size = new System.Drawing.Size(1047, 319);
            this.patientHistoryDataGrid.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Дата";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Послуга";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Кількість зубів";
            this.Column3.Name = "Column3";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Додатково";
            this.Column5.Name = "Column5";
            // 
            // PatientHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 595);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientHistoryForm";
            this.Text = "PatientHistoryForm";
            this.Load += new System.EventHandler(this.PatientHistoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.patientHistoryDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label txtPatientHistoryMiddlename;
        private System.Windows.Forms.Label txtPatientHistorySurname;
        private System.Windows.Forms.Label txtPatientHistoryName;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomDataGrid patientHistoryDataGrid;
        private System.Windows.Forms.Button AddPatientHistoryBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button removePatientHistory;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}