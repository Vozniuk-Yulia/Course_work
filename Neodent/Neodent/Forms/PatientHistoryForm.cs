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
            //this.Hide();
            AddPatientHistoryForm addPatientHistoryForm = new AddPatientHistoryForm();
            addPatientHistoryForm.NamePatient=PatientHistoryName;
            addPatientHistoryForm.Show();
        }

        private void PatientHistoryForm_Load(object sender, EventArgs e)
        {
            txtPatientHistoryName.Text = PatientHistoryName;
            txtPatientHistorySurname.Text = PatientHistorySurname;
            txtPatientHistoryMiddlename.Text = PatientHistoryMiddlename;
        }
    }
}
