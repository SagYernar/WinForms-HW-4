using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homework_WF_4
{
    public partial class Datamer : Form
    {
        DateTime todayDate;
        DateTime date;
        RadioButton pickedButton;
        TimeSpan timeBetweenTwoPoints;
        int countOfRadioButton;

        public Datamer()
        {
            InitializeComponent();
            dateTextBox.MaxLength = 10;
        }

        private void DateTextBox_Click(object sender, EventArgs e)
        {
            dateTextBox.Text = "";
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            todayDate = DateTime.Today;
            pickedButton = GetPickedRadioButton();

            if (!DateTime.TryParse(dateTextBox.Text, out date) || (todayDate.Day > 31 && todayDate.Day < 0)
                || (todayDate.Month > 12 && todayDate.Month < 0))
            {
                incorrectDateLabel.Text = "Неверная дата!";
                incorrectDateLabel.Visible = true;
                dateTextBox.Text = " (дд.мм.гггг)";
            }

            else
            {
                incorrectDateLabel.Visible = false;

                if (pickedButton == yearsRadioButton)
                {
                    timeBetweenTwoPoints = date - todayDate;
                    result.Text = ((double)timeBetweenTwoPoints.Days / 365).ToString("0.000");
                }
                else if (pickedButton == monthsRadioButton)
                {
                    timeBetweenTwoPoints = date - todayDate;
                    result.Text = ((double)timeBetweenTwoPoints.Days / 30).ToString("0.00");
                }
                else if (pickedButton == daysRadioButton)
                {
                    timeBetweenTwoPoints = date - todayDate;
                    result.Text = timeBetweenTwoPoints.TotalDays.ToString();
                }
                else if (pickedButton == minutesRadioButton)
                {
                    timeBetweenTwoPoints = date - todayDate;
                    result.Text = timeBetweenTwoPoints.TotalMinutes.ToString();
                }
                else if (pickedButton == secondsRadioButton)
                {
                    timeBetweenTwoPoints = date - todayDate;
                    result.Text = timeBetweenTwoPoints.TotalSeconds.ToString();
                }

            }
        }

        private RadioButton GetPickedRadioButton()
        {
            countOfRadioButton = 5;
            for (int i = 0; i < countOfRadioButton; i++)
            {
                if (yearsRadioButton.Checked == true) { return yearsRadioButton; }
                else if(monthsRadioButton.Checked == true) { return monthsRadioButton; }
                else if(daysRadioButton.Checked == true) { return daysRadioButton; }
                else if(minutesRadioButton.Checked == true) { return minutesRadioButton; }
                else if(secondsRadioButton.Checked == true) { return secondsRadioButton; }
            }
            return null;
        }
    }
}
