using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neodent.Forms
{
    public partial class MainForm : Form
    {
        public string Email { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }
        private void ContainerMainForm(object form)
        {
            if (panel_container.Controls.Count > 0)
            {
                panel_container.Controls.Clear();
            }
            Form fm=form as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            panel_container.Controls.Add(fm);
            panel_container.Tag = fm;
            fm.Show();
        }
        private void ButtonChangeColor(Button btn1, Button btn2, Button btn3, Button btn4)
        {
            btn1.ForeColor = Color.DimGray;
            btn1.Focus();
            btn2.ForeColor = Color.White;
            btn3.ForeColor = Color.White;
            btn4.ForeColor = Color.White;
        }
        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        
        private void button4_Click(object sender, EventArgs e)
        {
            ButtonChangeColor(button4, button1, button2, button3);
            ContainerMainForm(new DashboardForm());
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ButtonChangeColor(button1, button4, button2, button3);
            ContainerMainForm(new DentistsForm());

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonChangeColor(button2, button4, button1, button3);
            ContainerMainForm(new PatientsForm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonChangeColor(button3, button4, button2, button1);
            ContainerMainForm(new ScheduleForm());
        }

       

        private void MainForm_Load(object sender, EventArgs e)
        {
            DashboardForm dashboardForm = new DashboardForm();
            dashboardForm.Email = Email;
            ContainerMainForm(dashboardForm);
        }
    }
}
