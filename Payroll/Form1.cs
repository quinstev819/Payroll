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
            if ((firstNameText.Text == "") || (hourlyPayText.Text == "") || (totalHoursText.Text == ""))
            {
                firstNameText.ForeColor = Color.Red;
                firstNameText.Text = "Field Required";
                hourlyPayText.ForeColor = Color.Red;
                hourlyPayText.Text = "Field Required";
                totalHoursText.ForeColor = Color.Red;
                totalHoursText.Text = "Field Required";
                return;
            }
            else
            {
                firstNames.Add(firstNameText.Text);
                if (lastNameText.Text == "")
                {
                    lastNames.Add("Last name unavailable");
                }
                else
                {
                    lastNames.Add(lastNameText.Text);
                }
                if (addressText.Text == "")
                {
                    address.Add("Address unavailable");
                }
                else
                {
                    address.Add(addressText.Text);
                }
                if (emailText.Text == "")
                {
                    email.Add("Email unavailable");
                }
                else
                {
                    email.Add(emailText.Text);
                }
                if (phoneText.Text == "")
                {
                    phone.Add("Phone number unavailable");
                }
                else
                {
                    phone.Add(phoneText.Text);
                }
                if (positionText.Text == "")
                {
                    position.Add("Position unavailable");
                }
                else
                {
                    position.Add(positionText.Text);
                }
                hourlyPay.Add(hourlyPayText.Text);
                totalHours.Add(totalHoursText.Text);

                firstNameText.Text = "";
                lastNameText.Text = "";
                addressText.Text = "";
                emailText.Text = "";
                phoneText.Text = "";
                positionText.Text = "";
                hourlyPayText.Text = "";
                totalHoursText.Text = "";
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            if (firstNames.Contains(employeeNameTextBox.Text))
            {
                int index = firstNames.FindIndex(x => x == employeeNameTextBox.Text);
                double grossPay = Convert.ToDouble(hourlyPay[index]) * Convert.ToDouble(totalHours[index]);
                double employeeInsurance = grossPay * 0.18;
                double personalPay = grossPay * 0.0075;
                double vacationPay = grossPay * 0.04;
                double cppPay = grossPay * 0.0525;
                double totalDeductions = employeeInsurance + personalPay + vacationPay + cppPay;
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
                    + "\nGross Pay: "
                    + grossPay.ToString("C")
                    + "\n"
                    + "EI: "
                    + employeeInsurance.ToString("C")
                    + "\nVacation Pay: "
                    + vacationPay.ToString("C")
                    + "\nPersonal Pay: "
                    + personalPay.ToString("C")
                    + "\nCPP: "
                    + cppPay.ToString("C")
                    + "\nTotal Deductions: "
                    + totalDeductions.ToString("C")
                    + "\nNet Pay: "
                    + netPay.ToString("C");
            }
        }
        private void refreshButtonEdit_Click(object sender, EventArgs e)
        {
            if (firstNames.Contains(employeeTextBoxEdit.Text))
            {
                int index = firstNames.FindIndex(x => x == employeeTextBoxEdit.Text);
                firstNameTextEdit.Text = Convert.ToString(firstNames[index]);
                lastNameTextEdit.Text = Convert.ToString(lastNames[index]);
                addressTextEdit.Text = Convert.ToString(address[index]);
                emailTextEdit.Text = Convert.ToString(email[index]);
                phoneTextEdit.Text = Convert.ToString(phone[index]);
                positionTextEdit.Text = Convert.ToString(position[index]);
                hourlyPayTextEdit.Text = Convert.ToString(hourlyPay[index]);
                totalHoursTextEdit.Text = Convert.ToString(totalHours[index]);
            }
        }
        private void saveButtonEdit_Click(object sender, EventArgs e)
        {
            if (firstNames.Contains(employeeTextBoxEdit.Text))
            {
                int index = firstNames.FindIndex(x => x == employeeTextBoxEdit.Text);
                if ((firstNameTextEdit.Text == "") || (hourlyPayTextEdit.Text == "") || (totalHoursTextEdit.Text == ""))
                {
                    firstNameTextEdit.ForeColor = Color.Red;
                    firstNameTextEdit.Text = "Field Required";
                    hourlyPayTextEdit.ForeColor = Color.Red;
                    hourlyPayTextEdit.Text = "Field Required";
                    totalHoursTextEdit.ForeColor = Color.Red;
                    totalHoursTextEdit.Text = "Field Required";
                    return;
                }
                else
                {
                    firstNames[index] = firstNameTextEdit.Text;
                    if (lastNameTextEdit.Text == "")
                    {
                        lastNames[index] = "Last name unavailable";
                    }
                    else
                    {
                        lastNames[index] = lastNameTextEdit.Text;
                    }
                    if (addressTextEdit.Text == "")
                    {
                        address[index] = "Address unavailable";
                    }
                    else
                    {
                        address[index] = addressTextEdit.Text;
                    }
                    if (emailTextEdit.Text == "")
                    {
                        email[index] = "Email unavailable";
                    }
                    else
                    {
                        email[index] = emailTextEdit.Text;
                    }
                    if (phoneTextEdit.Text == "")
                    {
                        phone[index] = "Phone number unavailable";
                    }
                    else
                    {
                        phone[index] = phoneTextEdit.Text;
                    }
                    if (positionTextEdit.Text == "")
                    {
                        position[index] = "Position unavailable";
                    }
                    else
                    {
                        position[index] = positionTextEdit.Text;
                    }
                    hourlyPay[index] = hourlyPayTextEdit.Text;
                    totalHours[index] = totalHoursTextEdit.Text;

                    firstNameTextEdit.Text = "";
                    lastNameTextEdit.Text = "";
                    addressTextEdit.Text = "";
                    emailTextEdit.Text = "";
                    phoneTextEdit.Text = "";
                    positionTextEdit.Text = "";
                    hourlyPayTextEdit.Text = "";
                    totalHoursTextEdit.Text = "";
                }
            }
        }
    }
}