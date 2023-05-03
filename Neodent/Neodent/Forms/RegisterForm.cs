using Neodent.Context;
using Neodent.Models;
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
    public partial class RegisterForm : Form
    {
        public bool isPassword;
        public RegisterForm()
        {
            InitializeComponent();
        }
        public bool RightPassword()
        {
            if (txtPassword.Text.Length == 8 || txtPassword.Text.Any(char.IsUpper) || !txtPassword.Text.Contains(" "))
            {
                isPassword = true;
            }
            else
            {
                isPassword = false;
            }
            return isPassword;
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Електронна пошта" || txtEmail.Text == "")
            {
                label2.Visible = true;

            }
            if (txtPassword.Text == "Пароль" || txtPassword.Text == "")
            {
                label3.Visible = true;

            }
 

            if (ValidateChildren(ValidationConstraints.None))
            {
                if (radioButton1.Checked == true && radioButton1.Text == "Адмін")
                {

                    Administrator administrator = new Administrator()
                    {
                        User = new User()
                        {
                            Name = txtName.Text,
                            Surname = txtSurname.Text,
                            Email = txtEmail.Text,
                            Password = txtPassword.Text
                        },
                        
                    };
                    using (var dbContext = new DentistryDBContext())
                    {
                        dbContext.Administrators.Add(administrator);
                        dbContext.SaveChanges();
                    }
                    MessageBox.Show("Зареєстровано успішно");
                    this.Close();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
                else if(radioButton2.Checked == true && radioButton2.Text == "Стоматолог")
                {
                    Dentist dentist = new Dentist()
                    {
                        User = new User()
                        {
                            Name = txtName.Text,
                            Surname = txtSurname.Text,
                            Email = txtEmail.Text,
                            Password = txtPassword.Text
                        },

                    };
                    using (var dbContext = new DentistryDBContext())
                    {
                        dbContext.Dentists.Add(dentist);
                        dbContext.SaveChanges();
                    }
                    MessageBox.Show("Зареєстровано успішно");
                    this.Close();
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                }
            }
           
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text == "")
            {
                return;
            }
            txtPassword.PasswordChar = '*';
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtEmail.Text) || txtEmail.Text.Contains("Електронна пошта"))
            {
                label2.Visible = true;
            }
            else
            {

                label2.Visible = false;

            }
        }

        private void txtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrWhiteSpace(txtPassword.Text) || txtPassword.Text.Contains("Пароль"))
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
