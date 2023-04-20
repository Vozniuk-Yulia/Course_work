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
            bunifuCustomDataGrid1.Rows.Add(
                new object[]
                {"Voznyuk",
                "Yulia",
                "0681925839",
                "20.10.2004"});

        }
        private void button1_Click(object sender, EventArgs e)
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
            if(bunifuCustomDataGrid1.Columns[e.ColumnIndex].Name== "buttonDetail")
            {
                ContainerControl(new DetailsPatientForm());
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
            List<Patient> patients = new List<Patient>();
            for(int i = 0; i < 10; i++)
            {
                patients.Add(new Patient
                    { 
                    Name= "Yulia",
                    Surname= "Voznyuk",
                    Phone= "0681925839",
                    Birthday=DateTime.Now

                });
            }
           

        }
    }
}
