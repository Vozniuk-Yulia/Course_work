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
    public partial class EventForm : Form
    {
        private DateTime currentDate;
        private TimeSpan timeSpan;
        public EventForm(DateTime currentDate)
        {
            InitializeComponent();
            this.currentDate = currentDate;
        }

        

        private void EventForm_Load(object sender, EventArgs e)
        {
            
            LoadPatientData();
            LoadDentistData();
            LoadServiceData();
            dateAppoinment.Value = currentDate;
           
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadPatientData()
        {
            using (var dbContext = new DentistryDBContext())
            {
                var patients = dbContext.Patients
                .Select(c => new User()
                {
                    Id = c.Id,
                    Name = c.User.Name,
                    Surname = c.User.Surname
                   
                })
                .ToList();
                foreach (var patient in patients)
                {
                    listOfPatients.Items.Add($"{patient.Surname} {patient.Name}");
                }
            }
        }
        private void LoadDentistData()
        {
            using (var dbContext = new DentistryDBContext())
            {
                var dentists = dbContext.Dentists
                .Select(c => new User()
                {
                    Id = c.Id,
                    Name = c.User.Name,
                    Surname = c.User.Surname
                   
                })
                .ToList();
                foreach (var dentist in dentists)
                {
                    listOfDentists.Items.Add($"{dentist.Surname} {dentist.Name}");
                }
            }
        }
        private void LoadServiceData()
        {
            using (var dbContext = new DentistryDBContext())
            {
                var services = dbContext.Services
                .Select(c => new Service()
                {
                    Id = c.Id,
                    Name=c.Name

                })
                .ToList();
                foreach (var service in services)
                {
                    listOfServices.Items.Add($"{service.Name}");
                }
            }
        }
        private void addEvent_Click(object sender, EventArgs e)
        {
            if(listOfPatients.SelectedIndex !=-1 && listOfDentists.SelectedIndex != -1 && listOfServices.SelectedIndex != -1 && TimeSpan.TryParse(startTimeAppoinment.Text, out timeSpan) && TimeSpan.TryParse(endTimeAppointment.Text, out timeSpan))
            {
                int dentistId, patientId, serviceId;
                string[] selectedDentistNames = listOfDentists.SelectedItem.ToString().Split(' ');
                var selectedPatientNames = listOfPatients.SelectedItem.ToString().Split(' ');
                var selectedServiceName = listOfServices.SelectedItem.ToString();
                DateTime dateTimeAppointment = DateTime.Parse(dateAppoinment.Text);
                TimeSpan startdateTimeAppointment = TimeSpan.Parse(startTimeAppoinment.Text);
                TimeSpan enddateTimeAppointment = TimeSpan.Parse(endTimeAppointment.Text);
                using (var dbContext = new DentistryDBContext())
                {
                    var selectedDentist = dbContext.Dentists.FirstOrDefault(p => p.User.Name == selectedDentistNames[1]);
                    dentistId = selectedDentist.Id;
                    var selectedPatient = dbContext.Patients.FirstOrDefault(p => p.User.Name == selectedPatientNames[1]);
                    patientId = selectedPatient.Id;
                    var selectedService = dbContext.Services.FirstOrDefault(p => p.Name == selectedServiceName);
                    serviceId = selectedService.Id;
                    Appointment appointment = new Appointment()
                    {
                        Date = dateTimeAppointment.Date,
                        StartTime = startdateTimeAppointment,
                        EndTime = enddateTimeAppointment,
                        Dentist = selectedDentist,
                        Patient = selectedPatient,
                        Service = selectedService
                    };
                    dbContext.Appointments.Add(appointment);
                    dbContext.SaveChanges();
                    MessageBox.Show("Додано успішно");
                }
            }
            else
            {
                MessageBox.Show("Введіть коректні дані");
            }
            
          
           
        }
    }
}
