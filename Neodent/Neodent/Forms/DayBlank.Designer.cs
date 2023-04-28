namespace Neodent.Forms
{
    partial class DayBlank
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dayNumber = new System.Windows.Forms.Label();
            this.AddApoinment = new System.Windows.Forms.Button();
            this.CountOfDayAppointment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dayNumber
            // 
            this.dayNumber.BackColor = System.Drawing.Color.Transparent;
            this.dayNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayNumber.Location = new System.Drawing.Point(0, 0);
            this.dayNumber.Name = "dayNumber";
            this.dayNumber.Size = new System.Drawing.Size(64, 60);
            this.dayNumber.TabIndex = 0;
            this.dayNumber.Text = "01";
            this.dayNumber.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddApoinment
            // 
            this.AddApoinment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddApoinment.Location = new System.Drawing.Point(6, 63);
            this.AddApoinment.Name = "AddApoinment";
            this.AddApoinment.Size = new System.Drawing.Size(41, 28);
            this.AddApoinment.TabIndex = 3;
            this.AddApoinment.Text = "Add";
            this.AddApoinment.UseVisualStyleBackColor = true;
            this.AddApoinment.Visible = false;
            this.AddApoinment.Click += new System.EventHandler(this.AddApoinment_Click);
            // 
            // CountOfDayAppointment
            // 
            this.CountOfDayAppointment.AutoSize = true;
            this.CountOfDayAppointment.Location = new System.Drawing.Point(118, 71);
            this.CountOfDayAppointment.Name = "CountOfDayAppointment";
            this.CountOfDayAppointment.Size = new System.Drawing.Size(35, 13);
            this.CountOfDayAppointment.TabIndex = 4;
            this.CountOfDayAppointment.Text = "label1";
            // 
            // DayBlank
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.CountOfDayAppointment);
            this.Controls.Add(this.AddApoinment);
            this.Controls.Add(this.dayNumber);
            this.Name = "DayBlank";
            this.Size = new System.Drawing.Size(170, 100);
            this.Load += new System.EventHandler(this.DayBlank_Load);
            this.Enter += new System.EventHandler(this.DayBlank_Enter);
            this.MouseEnter += new System.EventHandler(this.DayBlank_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.DayBlank_MouseLeave);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dayNumber;
        private System.Windows.Forms.Button AddApoinment;
        private System.Windows.Forms.Label CountOfDayAppointment;
    }
}
