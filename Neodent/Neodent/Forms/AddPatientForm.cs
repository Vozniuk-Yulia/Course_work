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
    public partial class AddPatientForm : Form
    {
        private string gender;
        private int num;
        private DateTime result;
        public AddPatientForm()
        {
            InitializeComponent();
        }
        public string GendreChoice()
        {
            if (malePatient.Checked)
            {
                gender = "Чоловiк";
            }
            else
            {
                gender = "Жiнка";
            }
            return gender;
        }
        private void AddPatientForm_Load(object sender, EventArgs e)
        {
            
        }

        private void Save_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient()
            {
                User = new User()
                {
                    Name = txtPatientName.Text,
                    Surname = txtPatientSurname.Text,
                    Middlename = txtPatientMiddlename.Text,
                    Birthday = DateTime.Parse(txtPatientBirthday.Text),
                    Phone = txtPatientPhone.Text,
                    Address = txtPatientAddress.Text,
                    Gender = GendreChoice(),
                },
                RegistratedDate= DateTime.Parse(txtPatientRegisterData.Text),
                Allergies=txtPatientAllergies.Text,
                LastVisit= DateTime.Parse(txtPatientLastVisit.Text),
                BloodType=txtPatientBloodType.Text
               
            };
            if (string.IsNullOrEmpty(txtPatientName.Text) || string.IsNullOrEmpty(txtPatientSurname.Text) || string.IsNullOrEmpty(txtPatientMiddlename.Text) || string.IsNullOrEmpty(txtPatientAllergies.Text) || string.IsNullOrEmpty(txtPatientPhone.Text) || string.IsNullOrEmpty(txtPatientAddress.Text))
            {
                MessageBox.Show("Введіть коректні дані");
            }
            else if (int.TryParse(txtPatientBloodType.Text, out num) && DateTime.TryParseExact(txtPatientBirthday.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out result) && DateTime.TryParseExact(txtPatientRegisterData.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out result) && DateTime.TryParseExact(txtPatientLastVisit.Text, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out result))
            {
                using (var dbContext = new DentistryDBContext())
                {
                    dbContext.Patients.Add(patient);
                    dbContext.SaveChanges();
                }
                MessageBox.Show("Додано успішно");
                this.Close();

            }

        }
    }
}
