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
        public PatientHistoryForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            AddPatientHistoryForm addPatientHistoryForm = new AddPatientHistoryForm();
            addPatientHistoryForm.Show();
        }
    }
}
