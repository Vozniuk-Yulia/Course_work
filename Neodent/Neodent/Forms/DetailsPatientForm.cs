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
    public partial class DetailsPatientForm : Form
    {
        public string PatientName { get; set; }
        public string PatientSurname { get; set; }
        public string PatientMiddlename { get; set; }
        public DateTime PatientBirthday { get; set; }
        public string PatientPhone { get; set; }
        public string PatientAddress { get; set; }
        public string PatientGender { get; set; }
        public DateTime PatientDataRegistration { get; set; }
        public string PatientAllergies { get; set; }
        public DetailsPatientForm()
        {
            InitializeComponent();
        }

        private void DetailsPatientForm_Load(object sender, EventArgs e)
        {
            txtDetailPatientName.Text = PatientName;
            txtDetailPatientSurname.Text = PatientSurname;
            txtDetailPatientMiddlename.Text = PatientMiddlename;
            txtDetailPatientBirthday.Text = (PatientBirthday).ToString();
            txtDetailPatientPhone.Text = PatientPhone;
            txtDetailPatientAddress.Text = PatientAddress;
            txtDetailPatientGender.Text = PatientGender;
            txtDetailPatientAllergies.Text = PatientAllergies;
        }
    }
}
