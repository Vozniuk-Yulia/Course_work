using Neodent.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Neodent.Forms
{
    public partial class DashboardForm : Form
    {
       
        public DashboardForm()
        {
            InitializeComponent();
        }
        private void LoadChart1()
        {
            Axis XA = chart1.ChartAreas[0].AxisX;
            Axis YA = chart1.ChartAreas[0].AxisY;
            Series S1 = chart1.Series[0];
            List<DateTime> dates = new List<DateTime>();
            DateTime dt = DateTime.Now;
            for (int i = 1; i <= 12; i++)
            {
                dates.Add(new DateTime(dt.Year, i, 1));
            }
            foreach (DateTime d in dates)
            {
                S1.Points.AddXY(d, 5);
            }
            chart1.Legends[0].Docking = Docking.Bottom;
            chart1.Legends[0].Alignment = StringAlignment.Center;

            S1.XValueType = ChartValueType.Date;  
            XA.MajorGrid.Enabled = false;
          
            XA.LabelStyle.Format = "MMM";


            XA.IntervalType = DateTimeIntervalType.Months;  
            XA.Interval = 1;                               


            YA.IsInterlaced = true;
            YA.MajorGrid.Enabled = false;
            YA.InterlacedColor = Color.FromArgb(31, Color.LightSeaGreen);
        }
        //private void LoadChart2()
        //{
        //    Axis XA = chart2.ChartAreas[0].AxisX;
        //    Axis YA = chart2.ChartAreas[0].AxisY;
        //    Series S1 = chart2.Series[0];
        //    List<DateTime> dates = new List<DateTime>();
        //    DateTime dt = DateTime.Now;
        //    for (int i = 1; i < 7; i++)
        //    {
        //        dates.Add(new DateTime(dt.Year, dt.Month, i));
        //    }
        //    foreach (DateTime d in dates)
        //    {
        //        S1.Points.AddXY(d, 5);
        //    }
        //    chart2.Legends[0].Docking = Docking.Bottom;
        //    chart2.Legends[0].Alignment = StringAlignment.Center;

        //    S1.XValueType = ChartValueType.Date;  
        //    XA.MajorGrid.Enabled = false;
        //    XA.LabelStyle.Format = "ddd";


        //    XA.IntervalType = DateTimeIntervalType.Days; 
        //    XA.Interval = 1;
        //    XA.IntervalOffset = 1;


        //    YA.IsInterlaced = true;
        //    YA.MajorGrid.Enabled = false;
        //    YA.InterlacedColor = Color.FromArgb(31, Color.LightSeaGreen);
        //}

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LoadChart1();
            int countOfExperienceMore;
            using (var dbContext=new DentistryDBContext())
            {
                countOfExperienceMore = dbContext.Dentists.Where(u => u.WorkExperience > 5).Count();
                allPatientNum.Text = dbContext.Patients.Count().ToString();
                allDentistNum.Text = dbContext.Dentists.Count().ToString();
                allApoinmentNum.Text = dbContext.Appointments.Count().ToString();
                //bunifuCircleProgressbar1.Value = (countOfExperienceMore/dbContext.Dentists.Count()) * 100;
                countAppoinmentToday.Text = dbContext.Appointments.Where(d => d.Date.Date == DateTime.Today).Count().ToString();
                countNewPatient.Text=dbContext.Patients.Where(d=>d.RegistratedDate.Date == DateTime.Now.Date.AddDays(-30)).Count().ToString();
            }


        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
