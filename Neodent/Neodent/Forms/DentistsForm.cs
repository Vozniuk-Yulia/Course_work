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
    public partial class DentistsForm : Form
    {
        public DentistsForm()
        {
            InitializeComponent();
            bunifuCustomDataGrid1.Rows.Add(
               new object[]
               {"Yulia",
                "Voznyuk",
                "Dentist",
                "3",
               "Woman"});
            bunifuCustomDataGrid1.Rows.Add(
               new object[]
               {"Yulia",
                "Voznyuk",
                "Dentist",
                "3",
               "Woman"});
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Hide();
            AddDentistForm addDentistForm = new AddDentistForm();
            addDentistForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //MessageBox messageBox = new MessageBox("","");
        }

        private void DentistsForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddDentistForm addDentistForm = new AddDentistForm();
            addDentistForm.Show();
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
            if (bunifuCustomDataGrid1.Columns[e.ColumnIndex].Name == "buttonDetail")
            {
                ContainerControl(new DetailDentistForm());
            }
        }
    }
}
