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
    public partial class DentistsForm : Form
    {
        public int id;
        public bool clickEdit = false;
        public DentistsForm()
        {
            InitializeComponent();
            
        }



        private void removeDentist_Click(object sender, EventArgs e)
        {
                int selectedId = Convert.ToInt32(dentistDataGrid.CurrentRow.Cells["Id"].Value);
                using (var dbContext = new DentistryDBContext())
                {
                var dentist = dbContext.Dentists.Where(d => d.Id == selectedId).FirstOrDefault();
                    dbContext.Dentists.Remove(dentist);
                    dbContext.SaveChanges();
                }
                MessageBox.Show("Видаленно успішно");
            
        }

        private void DentistsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void editExistDentist_Click(object sender, EventArgs e)
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

        private void dentistDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DetailDentistForm detailDentistForm=new DetailDentistForm();
            
            if (dentistDataGrid.Columns[e.ColumnIndex].Name == "buttonDetail")
            {
                int selectedId = Convert.ToInt32(dentistDataGrid.CurrentRow.Cells["Id"].Value);
                using (var dbContext = new DentistryDBContext())
                {
                    var dentist=dbContext.Dentists.Where(d=>d.Id==selectedId).Select(c => new User()
                    {
                        Id = c.Id,
                        Name=c.User.Name,
                        Surname=c.User.Surname,
                        Middlename=c.User.Middlename,
                        Birthday=c.User.Birthday.Date,
                        Phone=c.User.Phone,
                        Address=c.User.Address,
                        Gender=c.User.Gender,
                        Dentist=c.User.Dentist
                    }).FirstOrDefault();
                    detailDentistForm.DentistName=dentist.Name;
                    detailDentistForm.DentistSurname=dentist.Surname;
                    detailDentistForm.DentistMiddlename=dentist.Middlename;
                    detailDentistForm.DentistBirthday=dentist.Birthday;
                    detailDentistForm.DentistPhone=dentist.Phone;
                    detailDentistForm.DentistAddress=dentist.Address;
                    detailDentistForm.DentistGender=dentist.Gender;
                    detailDentistForm.DentistSpecialization = dentist.Dentist.Specialization;
                    detailDentistForm.DentistExperience = (int)dentist.Dentist.WorkExperience;
                    detailDentistForm.DentistEducation = dentist.Dentist.Education;
                }
                ContainerControl(detailDentistForm);
            }
        }

        private void addNewDentist_Click(object sender, EventArgs e)
        {
            AddDentistForm addDentistForm = new AddDentistForm();
            addDentistForm.Show();
        }

        private void dentistDataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
     
        }
        private void LoadData()
        {
            using (var dbContext = new DentistryDBContext())
            {

                var dentists = dbContext.Dentists
                .Select(c => new User()
                {
                    Id = c.Id,
                    Name = c.User.Name,
                    Surname = c.User.Surname,
                    Middlename = c.User.Middlename,
                    Address = c.User.Address,
                    Phone = c.User.Phone,
                    Gender = c.User.Gender,
                    Dentist = c.User.Dentist,
                })
                .ToList();
                foreach (var dentist in dentists)
                {
                    dentistDataGrid.Rows.Add(new object[]
                    {
                        dentist.Id,
                        dentist.Name,
                        dentist.Surname,
                        dentist.Dentist.Specialization,
                        dentist.Dentist.WorkExperience,
                        dentist.Gender
                    });
                }
            }
        }
    }
}
