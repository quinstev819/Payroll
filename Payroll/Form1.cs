using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// Payroll Code
/// Mr. Theodoropoulos
/// Quinlan Stevenson & Ben Praseuth
/// ICS 3U
/// </summary>

namespace Payroll
{
    public partial class Form1 : Form
    {
        List<string> firstNames = new List<string>();
        List<string> lastNames = new List<string>();
        List<string> address = new List<string>();
        List<string> email = new List<string>();
        List<string> phone = new List<string>();
        List<string> position = new List<string>();
        List<string> hourlyPay = new List<string>();
        List<string> totalHours = new List<string>();


        //creating arrays for the inputs.

        public Form1()
        {
            InitializeComponent();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            firstNames.Add(firstNameText.Text);
            lastNames.Add(lastNameText.Text);
            address.Add(addressText.Text);
            email.Add(emailText.Text);
            phone.Add(phoneText.Text);
            position.Add(positionText.Text);
            hourlyPay.Add(hourlyPayText.Text);
            totalHours.Add(totalHoursText.Text);
        }
  
        private void refreshButton_Click(object sender, EventArgs e)
        {
            if (firstNames.Contains(employeeNameTextBox.Text))
            {
                int index = firstNames.FindIndex(x => x == employeeNameTextBox.Text);
                double employeeInsurance = Convert.ToDouble(hourlyPay[index]) * 0.18;
                double tax = Convert.ToDouble(hourlyPay[index]) * 0.13;
                double totalDeductions = employeeInsurance + tax;
                double grossPay = Convert.ToDouble(hourlyPay[index]) * Convert.ToDouble(totalHours[index]);
                double netPay = grossPay - totalDeductions;
                outputText.Text = firstNames[index]
                    + " "
                    + lastNames[index]
                    + "\n"
                    + address[index]
                    + "\n"
                    + email[index]
                    + "\n"
                    + phone[index]
                    + "\n\n"
                    + position[index]
                    + "\nGross Pay: $"
                    + grossPay
                    + "\n"
                    + "EI: $"
                    + employeeInsurance
                    + "\nTax: $"
                    + tax
                    + "\nTotal Deductions: $"
                    + totalDeductions
                    + "\nNet Pay: $"
                    + netPay;
            }
        }

        private void createTabControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            
          
        }

        private void createTabControl_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            if (createTabControl.SelectedIndex == 0)
            {
                createTabControl.SelectedIndex = 1;

            }
        }
    }
}
