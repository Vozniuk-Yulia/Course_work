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
    public partial class AddPatientHistoryForm : Form
    {
        public string NamePatient { get; set; }
        public AddPatientHistoryForm()
        {
            InitializeComponent();
        }

        private void AddPatientHistory_Click(object sender, EventArgs e)
        {
           
            using (var dbContext = new DentistryDBContext())
            {
                Patient patient = new Patient();
                var selectedService = dbContext.Services.FirstOrDefault(p => p.Name == txtPatientHistoryService.Text);
                int serviceId = selectedService.Id;
                patient = dbContext.Patients.FirstOrDefault(p => p.User.Name==NamePatient);
                PatientHistory patientHistory = new PatientHistory()
                {
                    DateTime = DateTime.Parse(txtPatientHistoryData.Text),
                    CountOfTeeth=int.Parse(txtPatientHistoryCountTeeth.Text),
                    Service = new Service()
                    { 
                        
                        Name=selectedService.Name,
                        Price=selectedService.Price
                    },
                    Notes=txtPatientHistoryAdditional.Text,
                    PatientID=patient.Id,

                };
                dbContext.PatientHistories.Add(patientHistory);
                patient.patientHistories.Add(patientHistory);
                dbContext.SaveChanges();
            }
            MessageBox.Show("Save");

                
        }

        private void AddPatientHistoryForm_Load(object sender, EventArgs e)
        {
           
        }
       
    }
}
