using Neodent.Context;
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
    public partial class LoginForm : Form
    {
        public bool isPassword;
        DentistryDBContext dbContext;
        public LoginForm()
        {
            InitializeComponent();
            dbContext = new DentistryDBContext();
        }
        public bool RightPassword()
        {
            if(textBox2.Text.Length==8 || textBox2.Text.Any(char.IsUpper) || !textBox2.Text.Contains(" "))
            {
                isPassword=true;
            }
            else
            {
                isPassword=false;
            }
            return isPassword;
        }
       

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Електронна пошта" || textBox1.Text == "")
            {
                label2.Visible = true;

            }
            if (textBox2.Text == "Пароль" || textBox2.Text == "")
            {
                label3.Visible = true;

            }
            //this.Hide();

            if (ValidateChildren(ValidationConstraints.None))
            {
                if(radioButton1.Checked==true)
                {
                    if (dbContext.Users.Where(u => u.Email == textBox1.Text && u.Password==textBox2.Text).Count()>0)
                    {
                        MainForm mainPanel = new MainForm();
                        mainPanel.Show();
                    }
                    else
                    {
                        MessageBox.Show("Неправильна електрона пошта або пароль");
                    }
                   
                }
                else if(radioButton2.Checked==true)
                {
                    if (dbContext.Users.Where(u => u.Email == textBox1.Text && u.Password == textBox2.Text).Count() > 0)
                    {
                        DentistMainForm dentistMainForm = new DentistMainForm();
                        dentistMainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Неправильна електрона пошта або пароль");
                    }
                   
                }
               
            }
           
           
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            label2.Parent = pictureBox1;
            label2.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            label4.Parent = pictureBox1;
            label4.BackColor=Color.Transparent;
            radioButton1.Parent = pictureBox1;
            radioButton1.BackColor = Color.Transparent;
            radioButton2.Parent = pictureBox1;
            radioButton2.BackColor= Color.Transparent;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                return;
            }
            textBox2.PasswordChar = '*';
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if(String.IsNullOrWhiteSpace(textBox1.Text) || textBox1.Text.Contains("Електронна пошта"))
            {
                label2.Visible = true;
            }
            else
            {
                
                    label2.Visible = false;
                
            }
           
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            buttonLog.BackColor=Color.White;
            buttonLog.ForeColor = Color.Black;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            buttonLog.BackColor = Color.Black;
            buttonLog.ForeColor = Color.White;
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(textBox2.Text) || textBox2.Text.Contains("Пароль"))
            {

                if (RightPassword() == true)
                {

                }
                label3.Visible = true;
            }
            else
            {
                label3.Visible = false;
            }
        }
    }
}
