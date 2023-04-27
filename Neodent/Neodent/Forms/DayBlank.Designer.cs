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
            this.activeAppoinment = new System.Windows.Forms.Panel();
            this.passiveAppoinment = new System.Windows.Forms.Panel();
            this.AddApoinment = new System.Windows.Forms.Button();
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
            // activeAppoinment
            // 
            this.activeAppoinment.Dock = System.Windows.Forms.DockStyle.Right;
            this.activeAppoinment.Location = new System.Drawing.Point(139, 0);
            this.activeAppoinment.Name = "activeAppoinment";
            this.activeAppoinment.Size = new System.Drawing.Size(31, 100);
            this.activeAppoinment.TabIndex = 1;
            // 
            // passiveAppoinment
            // 
            this.passiveAppoinment.Dock = System.Windows.Forms.DockStyle.Right;
            this.passiveAppoinment.Location = new System.Drawing.Point(110, 0);
            this.passiveAppoinment.Name = "passiveAppoinment";
            this.passiveAppoinment.Size = new System.Drawing.Size(29, 100);
            this.passiveAppoinment.TabIndex = 2;
            // 
            // AddApoinment
            // 
            this.AddApoinment.Location = new System.Drawing.Point(22, 61);
            this.AddApoinment.Name = "AddApoinment";
            this.AddApoinment.Size = new System.Drawing.Size(41, 28);
            this.AddApoinment.TabIndex = 3;
            this.AddApoinment.Text = "Add";
            this.AddApoinment.UseVisualStyleBackColor = true;
            this.AddApoinment.Click += new System.EventHandler(this.AddApoinment_Click);
            // 
            // DayBlank
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.AddApoinment);
            this.Controls.Add(this.passiveAppoinment);
            this.Controls.Add(this.activeAppoinment);
            this.Controls.Add(this.dayNumber);
            this.Name = "DayBlank";
            this.Size = new System.Drawing.Size(170, 100);
            this.Load += new System.EventHandler(this.DayBlank_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dayNumber;
        private System.Windows.Forms.Panel activeAppoinment;
        private System.Windows.Forms.Panel passiveAppoinment;
        private System.Windows.Forms.Button AddApoinment;
    }
}
