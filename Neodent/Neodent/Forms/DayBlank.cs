﻿using Neodent.Context;
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
    public partial class DayBlank : UserControl
    {
        private DateTime _currentDate;
        private Color _backColor;
        private int countOfAppointment;
        public DayBlank()
        {
            InitializeComponent();
        }
        public void Refresh(Color backColor, int day, DateTime date, Color foreColor)
        {
            BackColor = _backColor = backColor;
            dayNumber.Text = day.ToString();
            _currentDate = date;
            if (_currentDate.ToShortDateString() == DateTime.Now.ToShortDateString())
                BackColor = Color.Black;

            dayNumber.ForeColor = foreColor;
            using (var dbContext = new DentistryDBContext())
            {
                countOfAppointment =dbContext.Appointments.Where(a=>a.Date==_currentDate).Count();
            }

                
        }

        private void DayBlank_Load(object sender, EventArgs e)
        {
            CountOfDayAppointment.Text=countOfAppointment.ToString();
        }

        private void AddApoinment_Click(object sender, EventArgs e)
        {
            EventForm eventForm = new EventForm(_currentDate);
            eventForm.Show();
        }

        private void DayBlank_MouseLeave(object sender, EventArgs e)
        {
            if(!ClientRectangle.Contains(PointToClient(MousePosition)))
            {
                AddApoinment.Visible = false;
            }
        }

        private void DayBlank_Enter(object sender, EventArgs e)
        {
            AddApoinment.Visible = true;
        }

        private void DayBlank_MouseEnter(object sender, EventArgs e)
        {
            AddApoinment.Visible = true;
        }
    }
}
