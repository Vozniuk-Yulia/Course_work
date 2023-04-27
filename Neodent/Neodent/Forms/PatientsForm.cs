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
    public partial class PatientsForm : Form
    {
        public PatientsForm()
        {
            InitializeComponent();
            patientsDataGrid1.Rows.Add(
                new object[]
                {"Voznyuk",
                "Yulia",
                "0681925839",
                "20.10.2004"});

        }
        private void addNewPatient_Click(object sender, EventArgs e)
        {
            //this.Hide();
            AddPatientForm addPatientForm = new AddPatientForm();
            addPatientForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Hide();
            AddPatientForm addPatientForm = new AddPatientForm();
            addPatientForm.Show();
        }

        private void ContainerControl(Form form)
        {
            if (panel2.Controls.Count > 0)
            {
                panel2.Controls.Clear();
            }
            Form fm = form as Form;
            fm.TopLevel = false;
            fm.Dock = DockStyle.Fill;
            panel2.Controls.Add(fm);
            panel2.Tag = fm;
            fm.Show();
        }
        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DetailsPatientForm detailPatientForm = new DetailsPatientForm();

            if (patientsDataGrid1.Columns[e.ColumnIndex].Name == "buttonDetail")
            {
                int selectedId = Convert.ToInt32(patientsDataGrid1.CurrentRow.Cells["Id"].Value);
                using (var dbContext = new DentistryDBContext())
                {
                    var patient = dbContext.Patients.Where(d => d.Id == selectedId).Select(c => new User()
                    {
                        Id = c.Id,
                        Name = c.User.Name,
                        Surname = c.User.Surname,
                        Middlename = c.User.Middlename,
                        Birthday = c.User.Birthday.Date,
                        Phone = c.User.Phone,
                        Address = c.User.Address,
                        Gender = c.User.Gender,
                        Patient = c.User.Patient
                    }).FirstOrDefault();
                    detailPatientForm.PatientName = patient.Name;
                    detailPatientForm.PatientSurname = patient.Surname;
                    detailPatientForm.PatientMiddlename = patient.Middlename;
                    detailPatientForm.PatientBirthday = patient.Birthday.Date;
                    detailPatientForm.PatientPhone = patient.Phone;
                    detailPatientForm.PatientAddress = patient.Address;
                    detailPatientForm.PatientGender = patient.Gender;
                    detailPatientForm.PatientDataRegistration = patient.Patient.RegistratedDate;
                    detailPatientForm.PatientAllergies = patient.Patient.Allergies;
                }
                ContainerControl(detailPatientForm);
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            panel2.Controls.Clear();
            PatientHistoryForm patientHistoryForm = new PatientHistoryForm();
            ContainerControl(patientHistoryForm);

        }

        private void PatientsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        private void LoadData()
        {
            using (var dbContext = new DentistryDBContext())
            {

                var patients = dbContext.Patients
                .Select(c => new User()
                {
                    Id = c.Id,
                    Name = c.User.Name,
                    Surname = c.User.Surname,
                    Middlename = c.User.Middlename,
                    Address = c.User.Address,
                    Phone = c.User.Phone,
                    Gender = c.User.Gender,
                    Dentist = c.User.Dentist,
                    Birthday = c.User.Birthday,
                })
                .ToList();
                foreach (var patient in patients)
                {
                    patientsDataGrid1.Rows.Add(new object[]
                    {
                        patient.Id,
                        patient.Name,
                        patient.Surname,
                        patient.Phone,
                        patient.Birthday
                    });
                }
            }
        }

        private void removePatient_Click(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(patientsDataGrid1.CurrentRow.Cells["Id"].Value);
            using (var dbContext = new DentistryDBContext())
            {
                var patient = dbContext.Patients.Where(d => d.Id == selectedId).FirstOrDefault();
                dbContext.Patients.Remove(patient);
                dbContext.SaveChanges();
            }
            MessageBox.Show("Видаленно успішно");
        }
    }
}
