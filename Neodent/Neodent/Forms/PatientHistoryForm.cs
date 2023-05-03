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
    public partial class PatientHistoryForm : Form
    {
        public string PatientHistoryName { get; set; }
        public string PatientHistorySurname { get; set; }
        public string PatientHistoryMiddlename { get; set; }
        public PatientHistoryForm()
        {
            InitializeComponent();
        }

        private void AddPatientHistoryBtn_Click(object sender, EventArgs e)
        {
            AddPatientHistoryForm addPatientHistoryForm = new AddPatientHistoryForm();
            addPatientHistoryForm.NamePatient=PatientHistoryName;
            addPatientHistoryForm.Show();
        }

        private void PatientHistoryForm_Load(object sender, EventArgs e)
        {
            txtPatientHistoryName.Text = PatientHistoryName;
            txtPatientHistorySurname.Text = PatientHistorySurname;
            txtPatientHistoryMiddlename.Text = PatientHistoryMiddlename;
            LoadData();
        }
        private void LoadData()
        {
            using (var dbContext = new DentistryDBContext())
            {
                var patient = dbContext.Patients.FirstOrDefault(p => p.User.Name == PatientHistoryName);
                int patientId = patient.Id;
                var histories = dbContext.PatientHistories.Where(h=>h.PatientID==patientId)
                .Select(c => new PatientHistory()
                {
                    Id = c.Id,
                    DateTime=c.DateTime,
                    Service=c.Service,
                    CountOfTeeth=c.CountOfTeeth,
                    Notes=c.Notes
                })
                .ToList();
                foreach (var history in histories)
                {
                    patientHistoryDataGrid.Rows.Add(new object[]
                    {
                        history.DateTime,
                        history.Service.Name,
                        history.CountOfTeeth,
                        history.Notes,
                    });
                }
            }
        }

        private void removePatientHistory_Click(object sender, EventArgs e)
        {
            int selectedId = Convert.ToInt32(patientHistoryDataGrid.CurrentRow.Cells["Id"].Value);
            using (var dbContext = new DentistryDBContext())
            {
                var patientHistory = dbContext.PatientHistories.Where(d => d.Id == selectedId).FirstOrDefault();
                dbContext.PatientHistories.Remove(patientHistory);
                dbContext.SaveChanges();
            }
            MessageBox.Show("Видаленно успішно");
        }
    }
}
