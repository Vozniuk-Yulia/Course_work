namespace Neodent.Forms
{
    partial class AddPatientForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.txtPatientSurname = new System.Windows.Forms.TextBox();
            this.txtPatientMiddlename = new System.Windows.Forms.TextBox();
            this.txtPatientRegisterData = new System.Windows.Forms.TextBox();
            this.txtPatientBirthday = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPatientLastVisit = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPatientAllergies = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtPatientPhone = new System.Windows.Forms.TextBox();
            this.txtPatientBloodType = new System.Windows.Forms.TextBox();
            this.txtPatientAddress = new System.Windows.Forms.TextBox();
            this.malePatient = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Новий пацієнт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(26, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ім\'я";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(26, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "По-батькові";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(387, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Адреса";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(26, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Прізвище";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(26, 196);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Дата народження";
            // 
            // txtPatientName
            // 
            this.txtPatientName.Location = new System.Drawing.Point(168, 67);
            this.txtPatientName.Multiline = true;
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(202, 26);
            this.txtPatientName.TabIndex = 6;
            // 
            // txtPatientSurname
            // 
            this.txtPatientSurname.Location = new System.Drawing.Point(168, 109);
            this.txtPatientSurname.Multiline = true;
            this.txtPatientSurname.Name = "txtPatientSurname";
            this.txtPatientSurname.Size = new System.Drawing.Size(202, 26);
            this.txtPatientSurname.TabIndex = 7;
            // 
            // txtPatientMiddlename
            // 
            this.txtPatientMiddlename.Location = new System.Drawing.Point(168, 151);
            this.txtPatientMiddlename.Multiline = true;
            this.txtPatientMiddlename.Name = "txtPatientMiddlename";
            this.txtPatientMiddlename.Size = new System.Drawing.Size(202, 26);
            this.txtPatientMiddlename.TabIndex = 8;
            // 
            // txtPatientRegisterData
            // 
            this.txtPatientRegisterData.Location = new System.Drawing.Point(168, 235);
            this.txtPatientRegisterData.Multiline = true;
            this.txtPatientRegisterData.Name = "txtPatientRegisterData";
            this.txtPatientRegisterData.Size = new System.Drawing.Size(202, 26);
            this.txtPatientRegisterData.TabIndex = 9;
            // 
            // txtPatientBirthday
            // 
            this.txtPatientBirthday.Location = new System.Drawing.Point(168, 193);
            this.txtPatientBirthday.Multiline = true;
            this.txtPatientBirthday.Name = "txtPatientBirthday";
            this.txtPatientBirthday.Size = new System.Drawing.Size(202, 26);
            this.txtPatientBirthday.TabIndex = 10;
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Black;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Font = new System.Drawing.Font("Tempus Sans ITC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save.ForeColor = System.Drawing.Color.White;
            this.Save.Location = new System.Drawing.Point(577, 370);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(111, 33);
            this.Save.TabIndex = 11;
            this.Save.Text = "Зберегти";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(387, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 17);
            this.label7.TabIndex = 12;
            this.label7.Text = "Останій візит";
            // 
            // txtPatientLastVisit
            // 
            this.txtPatientLastVisit.Location = new System.Drawing.Point(486, 69);
            this.txtPatientLastVisit.Multiline = true;
            this.txtPatientLastVisit.Name = "txtPatientLastVisit";
            this.txtPatientLastVisit.Size = new System.Drawing.Size(202, 26);
            this.txtPatientLastVisit.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(26, 280);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Алергії";
            // 
            // txtPatientAllergies
            // 
            this.txtPatientAllergies.Location = new System.Drawing.Point(168, 277);
            this.txtPatientAllergies.Multiline = true;
            this.txtPatientAllergies.Name = "txtPatientAllergies";
            this.txtPatientAllergies.Size = new System.Drawing.Size(202, 78);
            this.txtPatientAllergies.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(387, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 17);
            this.label10.TabIndex = 19;
            this.label10.Text = "Телефон";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(26, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Дата реєстрації";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(387, 156);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 17);
            this.label12.TabIndex = 21;
            this.label12.Text = "Група крові";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(387, 240);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(42, 17);
            this.label13.TabIndex = 22;
            this.label13.Text = "Стать";
            // 
            // txtPatientPhone
            // 
            this.txtPatientPhone.Location = new System.Drawing.Point(486, 111);
            this.txtPatientPhone.Multiline = true;
            this.txtPatientPhone.Name = "txtPatientPhone";
            this.txtPatientPhone.Size = new System.Drawing.Size(202, 26);
            this.txtPatientPhone.TabIndex = 23;
            // 
            // txtPatientBloodType
            // 
            this.txtPatientBloodType.Location = new System.Drawing.Point(486, 153);
            this.txtPatientBloodType.Multiline = true;
            this.txtPatientBloodType.Name = "txtPatientBloodType";
            this.txtPatientBloodType.Size = new System.Drawing.Size(202, 26);
            this.txtPatientBloodType.TabIndex = 24;
            // 
            // txtPatientAddress
            // 
            this.txtPatientAddress.Location = new System.Drawing.Point(486, 195);
            this.txtPatientAddress.Multiline = true;
            this.txtPatientAddress.Name = "txtPatientAddress";
            this.txtPatientAddress.Size = new System.Drawing.Size(202, 26);
            this.txtPatientAddress.TabIndex = 25;
            // 
            // malePatient
            // 
            this.malePatient.AutoSize = true;
            this.malePatient.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.malePatient.Location = new System.Drawing.Point(486, 238);
            this.malePatient.Name = "malePatient";
            this.malePatient.Size = new System.Drawing.Size(65, 17);
            this.malePatient.TabIndex = 28;
            this.malePatient.TabStop = true;
            this.malePatient.Text = "Чоловік";
            this.malePatient.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.radioButton2.Location = new System.Drawing.Point(632, 238);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(56, 17);
            this.radioButton2.TabIndex = 29;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Жінка";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // AddPatientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(700, 411);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.malePatient);
            this.Controls.Add(this.txtPatientAddress);
            this.Controls.Add(this.txtPatientBloodType);
            this.Controls.Add(this.txtPatientPhone);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPatientAllergies);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPatientLastVisit);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.txtPatientBirthday);
            this.Controls.Add(this.txtPatientRegisterData);
            this.Controls.Add(this.txtPatientMiddlename);
            this.Controls.Add(this.txtPatientSurname);
            this.Controls.Add(this.txtPatientName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Name = "AddPatientForm";
            this.Text = "AddPatientForm";
            this.Load += new System.EventHandler(this.AddPatientForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.TextBox txtPatientSurname;
        private System.Windows.Forms.TextBox txtPatientMiddlename;
        private System.Windows.Forms.TextBox txtPatientRegisterData;
        private System.Windows.Forms.TextBox txtPatientBirthday;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPatientLastVisit;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPatientAllergies;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtPatientPhone;
        private System.Windows.Forms.TextBox txtPatientBloodType;
        private System.Windows.Forms.TextBox txtPatientAddress;
        private System.Windows.Forms.RadioButton malePatient;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}