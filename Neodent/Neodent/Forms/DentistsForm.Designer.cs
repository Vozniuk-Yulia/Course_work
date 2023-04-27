namespace Neodent.Forms
{
    partial class DentistsForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DentistsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.removeDentist = new System.Windows.Forms.Button();
            this.editExistDentist = new System.Windows.Forms.Button();
            this.addNewDentist = new System.Windows.Forms.Button();
            this.dentistDataGrid = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDetail = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dentistDataGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.removeDentist);
            this.panel1.Controls.Add(this.editExistDentist);
            this.panel1.Controls.Add(this.addNewDentist);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1148, 55);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Стоматологи";
            // 
            // removeDentist
            // 
            this.removeDentist.BackgroundImage = global::Neodent.Properties.Resources.remove_cross_icon;
            this.removeDentist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.removeDentist.Location = new System.Drawing.Point(1076, 12);
            this.removeDentist.Name = "removeDentist";
            this.removeDentist.Size = new System.Drawing.Size(41, 41);
            this.removeDentist.TabIndex = 8;
            this.removeDentist.UseVisualStyleBackColor = true;
            this.removeDentist.Click += new System.EventHandler(this.removeDentist_Click);
            // 
            // editExistDentist
            // 
            this.editExistDentist.BackgroundImage = global::Neodent.Properties.Resources.sign_document_icon;
            this.editExistDentist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.editExistDentist.Location = new System.Drawing.Point(1019, 12);
            this.editExistDentist.Name = "editExistDentist";
            this.editExistDentist.Size = new System.Drawing.Size(41, 41);
            this.editExistDentist.TabIndex = 7;
            this.editExistDentist.UseVisualStyleBackColor = true;
            this.editExistDentist.Click += new System.EventHandler(this.editExistDentist_Click);
            // 
            // addNewDentist
            // 
            this.addNewDentist.BackgroundImage = global::Neodent.Properties.Resources.mathematics_sign_plus_round_icon;
            this.addNewDentist.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.addNewDentist.Location = new System.Drawing.Point(960, 12);
            this.addNewDentist.Name = "addNewDentist";
            this.addNewDentist.Size = new System.Drawing.Size(41, 41);
            this.addNewDentist.TabIndex = 6;
            this.addNewDentist.UseVisualStyleBackColor = true;
            this.addNewDentist.Click += new System.EventHandler(this.addNewDentist_Click);
            // 
            // dentistDataGrid
            // 
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            this.dentistDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dentistDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dentistDataGrid.BackgroundColor = System.Drawing.Color.White;
            this.dentistDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dentistDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dentistDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 13.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dentistDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dentistDataGrid.ColumnHeadersHeight = 50;
            this.dentistDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Column1,
            this.Column2,
            this.Column5,
            this.Column6,
            this.Column3,
            this.buttonDetail});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(226)))), ((int)(((byte)(244)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dentistDataGrid.DefaultCellStyle = dataGridViewCellStyle7;
            this.dentistDataGrid.DoubleBuffered = true;
            this.dentistDataGrid.EnableHeadersVisualStyles = false;
            this.dentistDataGrid.HeaderBgColor = System.Drawing.Color.DarkSlateGray;
            this.dentistDataGrid.HeaderForeColor = System.Drawing.Color.White;
            this.dentistDataGrid.Location = new System.Drawing.Point(33, 27);
            this.dentistDataGrid.Name = "dentistDataGrid";
            this.dentistDataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dentistDataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dentistDataGrid.RowHeadersVisible = false;
            this.dentistDataGrid.RowTemplate.DividerHeight = 3;
            this.dentistDataGrid.RowTemplate.Height = 30;
            this.dentistDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dentistDataGrid.Size = new System.Drawing.Size(1084, 497);
            this.dentistDataGrid.TabIndex = 1;
            this.dentistDataGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dentistDataGrid_CellContentClick);
            this.dentistDataGrid.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dentistDataGrid_CellDoubleClick);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 7;
            this.bunifuElipse1.TargetControl = this.dentistDataGrid;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dentistDataGrid);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1148, 593);
            this.panel2.TabIndex = 2;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "Деталі";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // Id
            // 
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Ім\'я";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Прізвище";
            this.Column2.Name = "Column2";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Спеціалізація";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Стаж роботи ";
            this.Column6.Name = "Column6";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Стать";
            this.Column3.Name = "Column3";
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
            // DentistsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1148, 648);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DentistsForm";
            this.Text = "DentistsForm";
            this.Load += new System.EventHandler(this.DentistsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dentistDataGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button addNewDentist;
        private System.Windows.Forms.Button editExistDentist;
        private System.Windows.Forms.Button removeDentist;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dentistDataGrid;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewImageColumn buttonDetail;
    }
}