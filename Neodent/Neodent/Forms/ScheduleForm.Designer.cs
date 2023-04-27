namespace Neodent.Forms
{
    partial class ScheduleForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelYear = new System.Windows.Forms.Panel();
            this.yearLabel = new System.Windows.Forms.Label();
            this.nextYear = new System.Windows.Forms.Button();
            this.previousYear = new System.Windows.Forms.Button();
            this.panelMonth = new System.Windows.Forms.Panel();
            this.decemberButton = new System.Windows.Forms.Button();
            this.novemberButton = new System.Windows.Forms.Button();
            this.octoberButton = new System.Windows.Forms.Button();
            this.septemberButton = new System.Windows.Forms.Button();
            this.augustButton = new System.Windows.Forms.Button();
            this.julyButton = new System.Windows.Forms.Button();
            this.juneButton = new System.Windows.Forms.Button();
            this.mayButton = new System.Windows.Forms.Button();
            this.aprilButton = new System.Windows.Forms.Button();
            this.marchButton = new System.Windows.Forms.Button();
            this.februaryButton = new System.Windows.Forms.Button();
            this.januaryButton = new System.Windows.Forms.Button();
            this.panelYear.SuspendLayout();
            this.panelMonth.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(900, 648);
            this.panel2.TabIndex = 1;
            // 
            // panelYear
            // 
            this.panelYear.Controls.Add(this.yearLabel);
            this.panelYear.Controls.Add(this.nextYear);
            this.panelYear.Controls.Add(this.previousYear);
            this.panelYear.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelYear.Location = new System.Drawing.Point(900, 0);
            this.panelYear.Name = "panelYear";
            this.panelYear.Size = new System.Drawing.Size(248, 52);
            this.panelYear.TabIndex = 2;
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(109, 20);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(35, 13);
            this.yearLabel.TabIndex = 2;
            this.yearLabel.Text = "label1";
            // 
            // nextYear
            // 
            this.nextYear.Location = new System.Drawing.Point(201, 9);
            this.nextYear.Name = "nextYear";
            this.nextYear.Size = new System.Drawing.Size(35, 35);
            this.nextYear.TabIndex = 1;
            this.nextYear.Text = ">";
            this.nextYear.UseVisualStyleBackColor = true;
            this.nextYear.Click += new System.EventHandler(this.nextYear_Click);
            // 
            // previousYear
            // 
            this.previousYear.Location = new System.Drawing.Point(15, 9);
            this.previousYear.Name = "previousYear";
            this.previousYear.Size = new System.Drawing.Size(35, 35);
            this.previousYear.TabIndex = 0;
            this.previousYear.Text = "<";
            this.previousYear.UseVisualStyleBackColor = true;
            this.previousYear.Click += new System.EventHandler(this.previousYear_Click);
            // 
            // panelMonth
            // 
            this.panelMonth.Controls.Add(this.decemberButton);
            this.panelMonth.Controls.Add(this.novemberButton);
            this.panelMonth.Controls.Add(this.octoberButton);
            this.panelMonth.Controls.Add(this.septemberButton);
            this.panelMonth.Controls.Add(this.augustButton);
            this.panelMonth.Controls.Add(this.julyButton);
            this.panelMonth.Controls.Add(this.juneButton);
            this.panelMonth.Controls.Add(this.mayButton);
            this.panelMonth.Controls.Add(this.aprilButton);
            this.panelMonth.Controls.Add(this.marchButton);
            this.panelMonth.Controls.Add(this.februaryButton);
            this.panelMonth.Controls.Add(this.januaryButton);
            this.panelMonth.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelMonth.Location = new System.Drawing.Point(900, 52);
            this.panelMonth.Name = "panelMonth";
            this.panelMonth.Size = new System.Drawing.Size(248, 596);
            this.panelMonth.TabIndex = 3;
            // 
            // decemberButton
            // 
            this.decemberButton.Location = new System.Drawing.Point(53, 512);
            this.decemberButton.Name = "decemberButton";
            this.decemberButton.Size = new System.Drawing.Size(140, 40);
            this.decemberButton.TabIndex = 12;
            this.decemberButton.Text = "Грудень";
            this.decemberButton.UseVisualStyleBackColor = true;
            // 
            // novemberButton
            // 
            this.novemberButton.Location = new System.Drawing.Point(53, 466);
            this.novemberButton.Name = "novemberButton";
            this.novemberButton.Size = new System.Drawing.Size(140, 40);
            this.novemberButton.TabIndex = 11;
            this.novemberButton.Text = "Листопад";
            this.novemberButton.UseVisualStyleBackColor = true;
            // 
            // octoberButton
            // 
            this.octoberButton.Location = new System.Drawing.Point(53, 420);
            this.octoberButton.Name = "octoberButton";
            this.octoberButton.Size = new System.Drawing.Size(140, 40);
            this.octoberButton.TabIndex = 10;
            this.octoberButton.Text = "Жовтень";
            this.octoberButton.UseVisualStyleBackColor = true;
            // 
            // septemberButton
            // 
            this.septemberButton.Location = new System.Drawing.Point(53, 374);
            this.septemberButton.Name = "septemberButton";
            this.septemberButton.Size = new System.Drawing.Size(140, 40);
            this.septemberButton.TabIndex = 9;
            this.septemberButton.Text = "Вересень";
            this.septemberButton.UseVisualStyleBackColor = true;
            // 
            // augustButton
            // 
            this.augustButton.Location = new System.Drawing.Point(53, 328);
            this.augustButton.Name = "augustButton";
            this.augustButton.Size = new System.Drawing.Size(140, 40);
            this.augustButton.TabIndex = 8;
            this.augustButton.Text = "Серпень";
            this.augustButton.UseVisualStyleBackColor = true;
            // 
            // julyButton
            // 
            this.julyButton.Location = new System.Drawing.Point(53, 282);
            this.julyButton.Name = "julyButton";
            this.julyButton.Size = new System.Drawing.Size(140, 40);
            this.julyButton.TabIndex = 7;
            this.julyButton.Text = "Липень";
            this.julyButton.UseVisualStyleBackColor = true;
            // 
            // juneButton
            // 
            this.juneButton.Location = new System.Drawing.Point(53, 236);
            this.juneButton.Name = "juneButton";
            this.juneButton.Size = new System.Drawing.Size(140, 40);
            this.juneButton.TabIndex = 6;
            this.juneButton.Text = "Червень";
            this.juneButton.UseVisualStyleBackColor = true;
            // 
            // mayButton
            // 
            this.mayButton.Location = new System.Drawing.Point(53, 190);
            this.mayButton.Name = "mayButton";
            this.mayButton.Size = new System.Drawing.Size(140, 40);
            this.mayButton.TabIndex = 5;
            this.mayButton.Text = "Травень";
            this.mayButton.UseVisualStyleBackColor = true;
            // 
            // aprilButton
            // 
            this.aprilButton.Location = new System.Drawing.Point(53, 144);
            this.aprilButton.Name = "aprilButton";
            this.aprilButton.Size = new System.Drawing.Size(140, 40);
            this.aprilButton.TabIndex = 4;
            this.aprilButton.Text = "Квітень";
            this.aprilButton.UseVisualStyleBackColor = true;
            // 
            // marchButton
            // 
            this.marchButton.Location = new System.Drawing.Point(53, 98);
            this.marchButton.Name = "marchButton";
            this.marchButton.Size = new System.Drawing.Size(140, 40);
            this.marchButton.TabIndex = 3;
            this.marchButton.Text = "Березень";
            this.marchButton.UseVisualStyleBackColor = true;
            // 
            // februaryButton
            // 
            this.februaryButton.Location = new System.Drawing.Point(53, 52);
            this.februaryButton.Name = "februaryButton";
            this.februaryButton.Size = new System.Drawing.Size(140, 40);
            this.februaryButton.TabIndex = 2;
            this.februaryButton.Text = "Лютий";
            this.februaryButton.UseVisualStyleBackColor = true;
            // 
            // januaryButton
            // 
            this.januaryButton.Location = new System.Drawing.Point(53, 6);
            this.januaryButton.Name = "januaryButton";
            this.januaryButton.Size = new System.Drawing.Size(140, 40);
            this.januaryButton.TabIndex = 1;
            this.januaryButton.Text = "Січень";
            this.januaryButton.UseVisualStyleBackColor = true;
            // 
            // ScheduleForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1148, 648);
            this.Controls.Add(this.panelMonth);
            this.Controls.Add(this.panelYear);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ScheduleForm";
            this.Text = "ScheduleForm";
            this.Load += new System.EventHandler(this.ScheduleForm_Load);
            this.panelYear.ResumeLayout(false);
            this.panelYear.PerformLayout();
            this.panelMonth.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelYear;
        private System.Windows.Forms.Panel panelMonth;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Button nextYear;
        private System.Windows.Forms.Button previousYear;
        private System.Windows.Forms.Button decemberButton;
        private System.Windows.Forms.Button novemberButton;
        private System.Windows.Forms.Button octoberButton;
        private System.Windows.Forms.Button septemberButton;
        private System.Windows.Forms.Button augustButton;
        private System.Windows.Forms.Button julyButton;
        private System.Windows.Forms.Button juneButton;
        private System.Windows.Forms.Button mayButton;
        private System.Windows.Forms.Button aprilButton;
        private System.Windows.Forms.Button marchButton;
        private System.Windows.Forms.Button februaryButton;
        private System.Windows.Forms.Button januaryButton;
    }
}