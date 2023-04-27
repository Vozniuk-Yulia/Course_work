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
    public partial class DetailDentistForm : Form
    {
        public string DentistName { get; set; }
        public string DentistSurname { get; set; }
        public string DentistMiddlename { get; set; }
        public DateTime DentistBirthday { get; set; }
        public string DentistPhone { get; set; }
        public string DentistAddress { get; set; }
        public string DentistGender { get; set; }
        public string DentistSpecialization { get; set; }
        public int DentistExperience { get; set; }
        public string DentistEducation { get; set; }
        public DetailDentistForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void DetailDentistForm_Load(object sender, EventArgs e)
        {
            txtDetailDentistName.Text = DentistName;
            txtDetailDentistSurname.Text = DentistSurname;
            txtDetailDentistMiddlenmae.Text = DentistMiddlename;
            txtDetailDentistBirthday.Text = (DentistBirthday).ToString();
            txtDetailDentistPhone.Text = DentistPhone;
            txtDetailDentistAddress.Text = DentistAddress;
            txtDetailDentistGender.Text = DentistGender;
            txtDetailDentistSpecialization.Text = DentistSpecialization;
            txtDetailDentistExperiemce.Text = (DentistExperience).ToString();
            txtDetailDentistEducation.Text = DentistEducation;
        }
    }
}
