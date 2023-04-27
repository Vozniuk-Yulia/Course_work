namespace Neodent.Forms
{
    partial class PatientsForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PatientsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.removePatient = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addNewPatient = new System.Windows.Forms.Button();
            this.patientsDataGrid1 = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDetail = new System.Windows.Forms.DataGridViewImageColumn();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGrid1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.removePatient);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.addNewPatient);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 53);
            this.panel1.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::Neodent.Properties.Resources.medical_history_icon;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button4.Location = new System.Drawing.Point(907, 11);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(37, 42);
            this.button4.TabIndex = 4;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 28);
            this.label1.TabIndex = 3;
            this.label1.Text = "Клієнти";
            // 
            // removePatient
            // 
            this.removePatient.BackgroundImage = global::Neodent.Properties.Resources.remove_cross_icon;
            this.removePatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removePatient.Location = new System.Drawing.Point(1076, 12);
            this.removePatient.Name = "removePatient";
            this.removePatient.Size = new System.Drawing.Size(41, 41);
            this.removePatient.TabIndex = 2;
            this.removePatient.UseVisualStyleBackColor = true;
            this.removePatient.Click += new System.EventHandler(this.removePatient_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::Neodent.Properties.Resources.sign_document_icon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(1019, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(41, 41);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addNewPatient
            // 
            this.addNewPatient.BackgroundImage = global::Neodent.Properties.Resources.mathematics_sign_plus_round_icon;
            this.addNewPatient.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addNewPatient.Location = new System.Drawing.Point(960, 12);
            this.addNewPatient.Name = "addNewPatient";
            this.addNewPatient.Size = new System.Drawing.Size(41, 41);
            this.addNewPatient.TabIndex = 0;
            this.addNewPatient.UseVisualStyleBackColor = true;
            this.addNewPatient.Click += new System.EventHandler(this.addNewPatient_Click);
            // 
            // patientsDataGrid1
            // 
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.patientsDataGrid1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.patientsDataGrid1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.patientsDataGrid1.BackgroundColor = System.Drawing.Color.White;
            this.patientsDataGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patientsDataGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.patientsDataGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI Semibold", 13.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.patientsDataGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.patientsDataGrid1.ColumnHeadersHeight = 50;
            this.patientsDataGrid1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column4,
            this.buttonDetail});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.patientsDataGrid1.DefaultCellStyle = dataGridViewCellStyle6;
            this.patientsDataGrid1.DoubleBuffered = true;
            this.patientsDataGrid1.EnableHeadersVisualStyles = false;
            this.patientsDataGrid1.GridColor = System.Drawing.SystemColors.Control;
            this.patientsDataGrid1.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.patientsDataGrid1.HeaderForeColor = System.Drawing.Color.White;
            this.patientsDataGrid1.Location = new System.Drawing.Point(33, 27);
            this.patientsDataGrid1.Name = "patientsDataGrid1";
            this.patientsDataGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.patientsDataGrid1.RowHeadersVisible = false;
            this.patientsDataGrid1.RowTemplate.DividerHeight = 3;
            this.patientsDataGrid1.RowTemplate.Height = 30;
            this.patientsDataGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.patientsDataGrid1.Size = new System.Drawing.Size(1084, 523);
            this.patientsDataGrid1.TabIndex = 3;
            this.patientsDataGrid1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.bunifuCustomDataGrid1_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            // 
            // Column2
            // 
            this.Column2.FillWeight = 105.9645F;
            this.Column2.HeaderText = "Ім\'я";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.FillWeight = 105.9645F;
            this.Column1.HeaderText = "Прізвище";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.FillWeight = 105.9645F;
            this.Column3.HeaderText = "Телефон";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.FillWeight = 105.9645F;
            this.Column4.HeaderText = "Дата народження";
            this.Column4.Name = "Column4";
            // 
            // buttonDetail
            // 
            this.buttonDetail.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.buttonDetail.HeaderText = "Деталі";
            this.buttonDetail.Image = ((System.Drawing.Image)(resources.GetObject("buttonDetail.Image")));
            this.buttonDetail.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.buttonDetail.Name = "buttonDetail";
            this.buttonDetail.Width = 71;
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this.patientsDataGrid1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.patientsDataGrid1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 53);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1148, 595);
            this.panel2.TabIndex = 4;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "Деталі";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // PatientsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1148, 648);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PatientsForm";
            this.Text = "PatientsForm";
            this.Load += new System.EventHandler(this.PatientsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientsDataGrid1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button removePatient;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addNewPatient;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid patientsDataGrid1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewImageColumn buttonDetail;
    }
}