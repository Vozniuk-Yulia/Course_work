﻿namespace Neodent.Forms
{
    partial class AddPatientHistoryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPatientHistoryData = new System.Windows.Forms.TextBox();
            this.txtPatientHistoryService = new System.Windows.Forms.TextBox();
            this.txtPatientHistoryCountTeeth = new System.Windows.Forms.TextBox();
            this.txtPatientHistoryAdditional = new System.Windows.Forms.TextBox();
            this.AddPatientHistory = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(25, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Дата";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(216, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Послуга";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(408, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Кількість зубів";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(25, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Додатково";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(23, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(267, 30);
            this.label6.TabIndex = 5;
            this.label6.Text = "Додати історію хвороби";
            // 
            // txtPatientHistoryData
            // 
            this.txtPatientHistoryData.Location = new System.Drawing.Point(28, 87);
            this.txtPatientHistoryData.Multiline = true;
            this.txtPatientHistoryData.Name = "txtPatientHistoryData";
            this.txtPatientHistoryData.Size = new System.Drawing.Size(153, 27);
            this.txtPatientHistoryData.TabIndex = 6;
            // 
            // txtPatientHistoryService
            // 
            this.txtPatientHistoryService.Location = new System.Drawing.Point(219, 89);
            this.txtPatientHistoryService.Multiline = true;
            this.txtPatientHistoryService.Name = "txtPatientHistoryService";
            this.txtPatientHistoryService.Size = new System.Drawing.Size(153, 25);
            this.txtPatientHistoryService.TabIndex = 7;
            // 
            // txtPatientHistoryCountTeeth
            // 
            this.txtPatientHistoryCountTeeth.Location = new System.Drawing.Point(411, 89);
            this.txtPatientHistoryCountTeeth.Multiline = true;
            this.txtPatientHistoryCountTeeth.Name = "txtPatientHistoryCountTeeth";
            this.txtPatientHistoryCountTeeth.Size = new System.Drawing.Size(153, 25);
            this.txtPatientHistoryCountTeeth.TabIndex = 8;
            // 
            // txtPatientHistoryAdditional
            // 
            this.txtPatientHistoryAdditional.Location = new System.Drawing.Point(28, 172);
            this.txtPatientHistoryAdditional.Multiline = true;
            this.txtPatientHistoryAdditional.Name = "txtPatientHistoryAdditional";
            this.txtPatientHistoryAdditional.Size = new System.Drawing.Size(344, 79);
            this.txtPatientHistoryAdditional.TabIndex = 10;
            // 
            // AddPatientHistory
            // 
            this.AddPatientHistory.Location = new System.Drawing.Point(453, 267);
            this.AddPatientHistory.Name = "AddPatientHistory";
            this.AddPatientHistory.Size = new System.Drawing.Size(102, 31);
            this.AddPatientHistory.TabIndex = 11;
            this.AddPatientHistory.Text = "Додати";
            this.AddPatientHistory.UseVisualStyleBackColor = true;
            this.AddPatientHistory.Click += new System.EventHandler(this.AddPatientHistory_Click);
            // 
            // AddPatientHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 347);
            this.Controls.Add(this.AddPatientHistory);
            this.Controls.Add(this.txtPatientHistoryAdditional);
            this.Controls.Add(this.txtPatientHistoryCountTeeth);
            this.Controls.Add(this.txtPatientHistoryService);
            this.Controls.Add(this.txtPatientHistoryData);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AddPatientHistoryForm";
            this.Text = "AddPatientHistoryForm";
            this.Load += new System.EventHandler(this.AddPatientHistoryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPatientHistoryData;
        private System.Windows.Forms.TextBox txtPatientHistoryService;
        private System.Windows.Forms.TextBox txtPatientHistoryCountTeeth;
        private System.Windows.Forms.TextBox txtPatientHistoryAdditional;
        private System.Windows.Forms.Button AddPatientHistory;
    }
}