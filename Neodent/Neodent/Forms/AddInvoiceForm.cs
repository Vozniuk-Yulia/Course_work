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
    public partial class AddInvoiceForm : UserControl
    {
        public AddInvoiceForm()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListOfMedicineForm listOfMedicineForm = new ListOfMedicineForm();
            listOfMedicineForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ListOfServices listOfServices = new ListOfServices();
            listOfServices.Show();
        }
    }
}
