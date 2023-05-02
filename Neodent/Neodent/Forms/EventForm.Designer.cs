namespace Neodent.Forms
{
    partial class EventForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.addEvent = new System.Windows.Forms.Button();
            this.listOfPatients = new System.Windows.Forms.ComboBox();
            this.listOfDentists = new System.Windows.Forms.ComboBox();
            this.listOfServices = new System.Windows.Forms.ComboBox();
            this.dateAppoinment = new System.Windows.Forms.DateTimePicker();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startTimeAppoinment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.endTimeAppointment = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(123, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 30);
            this.label1.TabIndex = 2;
            this.label1.Text = "Додати запис";
            // 
            // addEvent
            // 
            this.addEvent.Location = new System.Drawing.Point(263, 339);
            this.addEvent.Name = "addEvent";
            this.addEvent.Size = new System.Drawing.Size(89, 32);
            this.addEvent.TabIndex = 4;
            this.addEvent.Text = "Додати";
            this.addEvent.UseVisualStyleBackColor = true;
            this.addEvent.Click += new System.EventHandler(this.addEvent_Click);
            // 
            // listOfPatients
            // 
            this.listOfPatients.FormattingEnabled = true;
            this.listOfPatients.Location = new System.Drawing.Point(37, 73);
            this.listOfPatients.Name = "listOfPatients";
            this.listOfPatients.Size = new System.Drawing.Size(315, 21);
            this.listOfPatients.TabIndex = 5;
            this.listOfPatients.Text = "Вибрати клієнта";
            // 
            // listOfDentists
            // 
            this.listOfDentists.FormattingEnabled = true;
            this.listOfDentists.Location = new System.Drawing.Point(37, 120);
            this.listOfDentists.Name = "listOfDentists";
            this.listOfDentists.Size = new System.Drawing.Size(315, 21);
            this.listOfDentists.TabIndex = 6;
            this.listOfDentists.Text = "Вибрати лікаря";
            // 
            // listOfServices
            // 
            this.listOfServices.FormattingEnabled = true;
            this.listOfServices.Location = new System.Drawing.Point(37, 165);
            this.listOfServices.Name = "listOfServices";
            this.listOfServices.Size = new System.Drawing.Size(315, 21);
            this.listOfServices.TabIndex = 7;
            this.listOfServices.Text = "Вибрати послугу";
            // 
            // dateAppoinment
            // 
            this.dateAppoinment.Location = new System.Drawing.Point(37, 242);
            this.dateAppoinment.Name = "dateAppoinment";
            this.dateAppoinment.Size = new System.Drawing.Size(83, 20);
            this.dateAppoinment.TabIndex = 8;
            this.dateAppoinment.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Години початок";
            // 
            // startTimeAppoinment
            // 
            this.startTimeAppoinment.Location = new System.Drawing.Point(191, 237);
            this.startTimeAppoinment.Multiline = true;
            this.startTimeAppoinment.Name = "startTimeAppoinment";
            this.startTimeAppoinment.Size = new System.Drawing.Size(158, 25);
            this.startTimeAppoinment.TabIndex = 11;
            this.startTimeAppoinment.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Години кінець";
            // 
            // endTimeAppointment
            // 
            this.endTimeAppointment.Location = new System.Drawing.Point(118, 288);
            this.endTimeAppointment.Multiline = true;
            this.endTimeAppointment.Name = "endTimeAppointment";
            this.endTimeAppointment.Size = new System.Drawing.Size(158, 25);
            this.endTimeAppointment.TabIndex = 13;
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 395);
            this.Controls.Add(this.endTimeAppointment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.startTimeAppoinment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateAppoinment);
            this.Controls.Add(this.listOfServices);
            this.Controls.Add(this.listOfDentists);
            this.Controls.Add(this.listOfPatients);
            this.Controls.Add(this.addEvent);
            this.Controls.Add(this.label1);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addEvent;
        private System.Windows.Forms.ComboBox listOfPatients;
        private System.Windows.Forms.ComboBox listOfDentists;
        private System.Windows.Forms.ComboBox listOfServices;
        private System.Windows.Forms.DateTimePicker dateAppoinment;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox startTimeAppoinment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox endTimeAppointment;
    }
}