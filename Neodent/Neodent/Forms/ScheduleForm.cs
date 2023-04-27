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
    public partial class ScheduleForm : Form
    {
        private CustomCalendar _calendar;
        private int _selectedMonth;

        private Color ACTIVE_BUTTON_COLOR = Color.DarkGray;
        private Color NOT_ACTIVE_COLOR = Color.Gray;
        public ScheduleForm()
        {
            InitializeComponent();

            new List<Control> { panel2 }.ForEach(x => x.MouseDown += (s, a) =>
            {
                x.Capture = false; Capture = false;
                Message m = Message.Create(Handle, 0xA1, new IntPtr(2), IntPtr.Zero);
                base.WndProc(ref m);
            });
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            _calendar = new CustomCalendar();
            _calendar.Dock = DockStyle.Fill;
            _calendar.DisplayDays(DateTime.Now);

            panel2.Controls.Add(_calendar);
            yearLabel.Text = DateTime.Now.Year.ToString();
            _selectedMonth = DateTime.Now.Month;
            ChooseActiveButton(_selectedMonth).BackColor = ACTIVE_BUTTON_COLOR;

            new List<Control> { januaryButton,februaryButton,marchButton,aprilButton,mayButton,juneButton,julyButton,
            augustButton,septemberButton,octoberButton,novemberButton,decemberButton}.ForEach((Action<Control>)(x =>
            {
                x.Click += MonthButtonClick;
            }));
        }
        private void MonthButtonClick(object sender, EventArgs e)
        {
            _selectedMonth = (sender as Button).TabIndex;
            RefreshCalendar(int.Parse(yearLabel.Text), _selectedMonth);
        }
        private void RefreshCalendar(int year, int month)
        {
            DateTime date = new DateTime(year, month, 1);
            _calendar.DisplayDays(date);
            SetMonthButtonActive(ChooseActiveButton(month));
        }
        private Button ChooseActiveButton(int index)
        {
            switch (index)
            {
                case 1:
                    return januaryButton;
                case 2:
                    return februaryButton;
                case 3:
                    return marchButton;
                case 4:
                    return aprilButton;
                case 5:
                    return mayButton;
                case 6:
                    return juneButton;
                case 7:
                    return julyButton;
                case 8:
                    return augustButton;
                case 9:
                    return septemberButton;
                case 10:
                    return octoberButton;
                case 11:
                    return novemberButton;
                case 12:
                    return decemberButton;
            }
            return null;
        }
        private void SetMonthButtonActive(Button activeButton)
        {
            foreach (Control item in panelMonth.Controls)
            {
                if (item.GetType() == typeof(Button))
                    item.BackColor = NOT_ACTIVE_COLOR;
            }
            activeButton.BackColor = ACTIVE_BUTTON_COLOR;
        }
      

        private void NextYearButton_Click(object sender, EventArgs e)
        {
            yearLabel.Text = (int.Parse(yearLabel.Text) + 1).ToString();
            RefreshCalendar(int.Parse(yearLabel.Text), _selectedMonth);
        }

        private void previousYear_Click(object sender, EventArgs e)
        {
            yearLabel.Text = (int.Parse(yearLabel.Text) - 1).ToString();
            RefreshCalendar(int.Parse(yearLabel.Text), _selectedMonth);
        }

        private void nextYear_Click(object sender, EventArgs e)
        {

        }
    }
}
