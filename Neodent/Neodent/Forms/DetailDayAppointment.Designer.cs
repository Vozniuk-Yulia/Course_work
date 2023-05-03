namespace Neodent.Forms
{
    partial class DetailDayAppointment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.choosenDateTime = new System.Windows.Forms.DateTimePicker();
            this.detailAppointmentGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StartTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EndTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ServiceName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DentistName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.detailAppointmentGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // choosenDateTime
            // 
            this.choosenDateTime.Location = new System.Drawing.Point(286, 12);
            this.choosenDateTime.Name = "choosenDateTime";
            this.choosenDateTime.Size = new System.Drawing.Size(188, 20);
            this.choosenDateTime.TabIndex = 0;
            // 
            // detailAppointmentGridView
            // 
            this.detailAppointmentGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detailAppointmentGridView.BackgroundColor = System.Drawing.Color.White;
            this.detailAppointmentGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailAppointmentGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.detailAppointmentGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 13.25F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.DarkSlateGray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detailAppointmentGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.detailAppointmentGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailAppointmentGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.StartTime,
            this.EndTime,
            this.ServiceName,
            this.PatientName,
            this.DentistName});
            this.detailAppointmentGridView.Location = new System.Drawing.Point(12, 64);
            this.detailAppointmentGridView.Name = "detailAppointmentGridView";
            this.detailAppointmentGridView.Size = new System.Drawing.Size(704, 203);
            this.detailAppointmentGridView.TabIndex = 1;

            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // StartTime
            // 
            this.StartTime.HeaderText = "Початок";
            this.StartTime.Name = "StartTime";
            // 
            // EndTime
            // 
            this.EndTime.HeaderText = "Кінець";
            this.EndTime.Name = "EndTime";
            // 
            // ServiceName
            // 
            this.ServiceName.HeaderText = "Послуга";
            this.ServiceName.Name = "ServiceName";
            // 
            // PatientName
            // 
            this.PatientName.HeaderText = "Пацієнт";
            this.PatientName.Name = "PatientName";
            // 
            // DentistName
            // 
            this.DentistName.HeaderText = "Стоматолог";
            this.DentistName.Name = "DentistName";
            // 
            // DetailDayAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 379);
            this.Controls.Add(this.detailAppointmentGridView);
            this.Controls.Add(this.choosenDateTime);
            this.Name = "DetailDayAppointment";
            this.Text = "DetailDayAppointment";
            this.Load += new System.EventHandler(this.DetailDayAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.detailAppointmentGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker choosenDateTime;
        private System.Windows.Forms.DataGridView detailAppointmentGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn StartTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn EndTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn ServiceName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DentistName;
    }
}