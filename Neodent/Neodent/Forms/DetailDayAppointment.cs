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
    public partial class DetailDayAppointment : Form
    {
        private DateTime currentDate;

        public DetailDayAppointment(DateTime currentDate)
        {
            InitializeComponent();
            this.currentDate = currentDate;
        }

        private void DetailDayAppointment_Load(object sender, EventArgs e)
        {
            choosenDateTime.Text = currentDate.ToString();
            using (var dbContext = new DentistryDBContext())
            {

                var appointments = dbContext.Appointments.Where(d=>d.Date==DateTime.Parse(choosenDateTime.Text))
                .Select(c => new Appointment()
                {
                    Id = c.Id,
                    StartTime = c.StartTime,
                    EndTime = c.EndTime,
                    Service=c.Service,
                    Patient=c.Patient,
                    Dentist=c.Dentist
                })
                .ToList();
               
                foreach (var appointment in appointments)
                {
                    var patient = dbContext.Users.Where(d =>d.Patient.Id == appointment.Patient.Id).FirstOrDefault();
                    var dentist=dbContext.Users.Where(d => d.Dentist.Id == appointment.Dentist.Id).FirstOrDefault();
                    detailAppointmentGridView.Rows.Add(new object[]
                    {
                        appointment.Id,
                        appointment.StartTime,
                        appointment.EndTime,
                        appointment.Service.Name,
                        patient.Surname,
                        dentist.Surname
                    
                    });
                }
            }
        }

        
    }
}
