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
            this.countOfDayAppointment = new System.Windows.Forms.Label();
            this.panelCount = new System.Windows.Forms.Panel();
            this.panelCount.SuspendLayout();
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
            this.AddApoinment.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddApoinment.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.AddApoinment.Location = new System.Drawing.Point(6, 50);
            this.AddApoinment.Name = "AddApoinment";
            this.AddApoinment.Size = new System.Drawing.Size(41, 41);
            this.AddApoinment.TabIndex = 3;
            this.AddApoinment.Text = "+";
            this.AddApoinment.UseVisualStyleBackColor = true;
            this.AddApoinment.Visible = false;
            this.AddApoinment.Click += new System.EventHandler(this.AddApoinment_Click);
            // 
            // countOfDayAppointment
            // 
            this.countOfDayAppointment.BackColor = System.Drawing.Color.Transparent;
            this.countOfDayAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countOfDayAppointment.ForeColor = System.Drawing.SystemColors.Highlight;
            this.countOfDayAppointment.Location = new System.Drawing.Point(4, 6);
            this.countOfDayAppointment.Name = "countOfDayAppointment";
            this.countOfDayAppointment.Size = new System.Drawing.Size(39, 24);
            this.countOfDayAppointment.TabIndex = 5;
            this.countOfDayAppointment.Text = "01\r\n";
            this.countOfDayAppointment.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelCount
            // 
            this.panelCount.BackColor = System.Drawing.Color.Transparent;
            this.panelCount.Controls.Add(this.countOfDayAppointment);
            this.panelCount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelCount.Location = new System.Drawing.Point(127, 58);
            this.panelCount.Name = "panelCount";
            this.panelCount.Size = new System.Drawing.Size(43, 33);
            this.panelCount.TabIndex = 6;
            // 
            // DayBlank
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.panelCount);
            this.Controls.Add(this.AddApoinment);
            this.Controls.Add(this.dayNumber);
            this.Name = "DayBlank";
            this.Size = new System.Drawing.Size(170, 100);
            this.Load += new System.EventHandler(this.DayBlank_Load);
            this.Enter += new System.EventHandler(this.DayBlank_Enter);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DayBlank_MouseClick);
            this.MouseEnter += new System.EventHandler(this.DayBlank_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.DayBlank_MouseLeave);
            this.panelCount.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dayNumber;
        private System.Windows.Forms.Button AddApoinment;
        private System.Windows.Forms.Label countOfDayAppointment;
        private System.Windows.Forms.Panel panelCount;
    }
}
