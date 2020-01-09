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

        public Form1()
        {
            InitializeComponent();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            firstNames.Add(firstNameText.Text);
            lastNames.Add(firstNameText.Text);
        }
  
        private void refreshButton_Click(object sender, EventArgs e)
        {
            if (firstNames.Contains(employeeNameTextBox.Text))
            {
                int index = firstNames.FindIndex(x => x == employeeNameTextBox.Text);
                outputText.Text += firstNames[index] + " " + lastNames[index];

            }
        }
    }
}
