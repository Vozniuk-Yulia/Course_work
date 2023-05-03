using Neodent.Context;
using Neodent.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Neodent.Forms
{
    public partial class AddDentistForm : Form
    {
        public DentistsForm dentistsForm;
        private string gender;
        private int num;
        private DateTime result;
        public AddDentistForm()
        {
            InitializeComponent();
        }

        public string GendreChoice()
        {
            if(maleDentist.Checked)
            {
                gender = "Чоловiк";
            }
            else
            {
                gender = "Жiнка";
            }
            return gender;
        }
        private void Save_Click(object sender, EventArgs e)
        {
            Dentist dentist = new Dentist()
            {
                User = new User()
                {
                    Name = txtDentistName.Text,
                    Surname = txtDentistSurname.Text,
                    Middlename = txtDentistMiddlename.Text,
                    Birthday = DateTime.Parse(txtDentistBirthday.Text),
                    Phone = txtDentistPhone.Text,
                    Address = txtDentistAddress.Text,
                    Gender = GendreChoice(),
                    Email = txtDentistEmail.Text,
                    Password = txtDentistPassword.Text
                },
                Specialization = txtDentistSpecialization.Text,
                WorkExperience = Int32.Parse(txtDentistExperience.Text),
                Education = txtDentistEducation.Text
            };

            if (string.IsNullOrEmpty(txtDentistName.Text) || string.IsNullOrEmpty(txtDentistSurname.Text) || string.IsNullOrEmpty(txtDentistMiddlename.Text) || string.IsNullOrEmpty(txtDentistSpecialization.Text) || string.IsNullOrEmpty(txtDentistPhone.Text) || string.IsNullOrEmpty(txtDentistEducation.Text) || string.IsNullOrEmpty(txtDentistAddress.Text))
            {
                MessageBox.Show("Введіть коректні дані");
            }
            else if(int.TryParse(txtDentistExperience.Text, out num) && DateTime.TryParseExact(txtDentistBirthday.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
            {

                using (var dbContext = new DentistryDBContext())
                {
                    dbContext.Dentists.Add(dentist);
                    dbContext.SaveChanges();
                }
                MessageBox.Show("Додано успішно");
                this.Close();
            }
            
        }

        private void AddDentistForm_Load(object sender, EventArgs e)
        {
           
        }
    }
}
