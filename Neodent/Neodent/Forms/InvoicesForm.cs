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
    public partial class InvoicesForm : Form
    {
        public InvoicesForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            AddInvoiceForm addInvoiceForm = new AddInvoiceForm();
            panel2.Controls.Add(addInvoiceForm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            AddInvoiceForm addInvoiceForm = new AddInvoiceForm();
            panel2.Controls.Add(addInvoiceForm);
        }
    }
}
