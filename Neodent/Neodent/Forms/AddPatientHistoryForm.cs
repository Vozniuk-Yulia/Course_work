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
                var patient = dbContext.Patients.FirstOrDefault(p => p.User.Name==NamePatient);
                //patient.patientHistories.Add()
                //    {

                //    }
            }

                
        }
    }
}
