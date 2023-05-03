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
    public partial class DentistMainForm : Form
    {
        public DentistMainForm()
        {
            InitializeComponent();
        }
        private void ContainerMainForm(object form)
        {
            if (panel_container.Controls.Count > 0)
            {
                panel_container.Controls.Clear();
            }
            Form fm = form as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            panel_container.Controls.Add(fm);
            panel_container.Tag = fm;
            fm.Show();
        }
        private void ButtonChangeColor(Button btn1, Button btn2)
        {
            btn1.ForeColor = Color.DimGray;
            btn1.Focus();
            btn2.ForeColor = Color.White;
            
        }


        private void DentistMainForm_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

       

        private void button2_Click(object sender, EventArgs e)
        {
            ButtonChangeColor(button2, button3);
            ContainerMainForm(new PatientsForm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ButtonChangeColor(button3, button2);
            ContainerMainForm(new ScheduleForm());
        }
    }
}
