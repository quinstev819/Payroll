namespace Payroll
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.createTabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.hourlyPayLabel = new System.Windows.Forms.Label();
            this.hourlyPayText = new System.Windows.Forms.TextBox();
            this.positionLabel = new System.Windows.Forms.Label();
            this.positionText = new System.Windows.Forms.TextBox();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.phoneText = new System.Windows.Forms.TextBox();
            this.lastNameText = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.createUserButton = new System.Windows.Forms.Button();
            this.emailText = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressText = new System.Windows.Forms.TextBox();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.payrollLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.outputText = new System.Windows.Forms.Label();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.fullNameLabelList = new System.Windows.Forms.Label();
            this.payrollLabelList = new System.Windows.Forms.Label();
            this.totalHoursLabel = new System.Windows.Forms.Label();
            this.totalHoursText = new System.Windows.Forms.TextBox();
            this.createTabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // createTabControl
            // 
            this.createTabControl.Controls.Add(this.tabPage1);
            this.createTabControl.Controls.Add(this.tabPage2);
            this.createTabControl.Location = new System.Drawing.Point(2, 2);
            this.createTabControl.Margin = new System.Windows.Forms.Padding(4);
            this.createTabControl.Name = "createTabControl";
            this.createTabControl.SelectedIndex = 0;
            this.createTabControl.Size = new System.Drawing.Size(1150, 665);
            this.createTabControl.TabIndex = 10;
            this.createTabControl.Tag = "create";
            this.createTabControl.KeyDown += new System.Windows.Forms.KeyEventHandler(this.createTabControl_KeyDown);
            this.createTabControl.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.createTabControl_KeyPress);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.totalHoursLabel);
            this.tabPage1.Controls.Add(this.totalHoursText);
            this.tabPage1.Controls.Add(this.hourlyPayLabel);
            this.tabPage1.Controls.Add(this.hourlyPayText);
            this.tabPage1.Controls.Add(this.positionLabel);
            this.tabPage1.Controls.Add(this.positionText);
            this.tabPage1.Controls.Add(this.phoneLabel);
            this.tabPage1.Controls.Add(this.lastNameLabel);
            this.tabPage1.Controls.Add(this.phoneText);
            this.tabPage1.Controls.Add(this.lastNameText);
            this.tabPage1.Controls.Add(this.emailLabel);
            this.tabPage1.Controls.Add(this.createUserButton);
            this.tabPage1.Controls.Add(this.emailText);
            this.tabPage1.Controls.Add(this.firstNameLabel);
            this.tabPage1.Controls.Add(this.addressLabel);
            this.tabPage1.Controls.Add(this.addressText);
            this.tabPage1.Controls.Add(this.firstNameText);
            this.tabPage1.Controls.Add(this.payrollLabel);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1134, 618);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create New User";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // hourlyPayLabel
            // 
            this.hourlyPayLabel.AutoSize = true;
            this.hourlyPayLabel.Location = new System.Drawing.Point(6, 387);
            this.hourlyPayLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.hourlyPayLabel.Name = "hourlyPayLabel";
            this.hourlyPayLabel.Size = new System.Drawing.Size(123, 25);
            this.hourlyPayLabel.TabIndex = 0;
            this.hourlyPayLabel.Text = "Hourly Pay:";
            // 
            // hourlyPayText
            // 
            this.hourlyPayText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.hourlyPayText.Location = new System.Drawing.Point(134, 383);
            this.hourlyPayText.Margin = new System.Windows.Forms.Padding(4);
            this.hourlyPayText.Name = "hourlyPayText";
            this.hourlyPayText.Size = new System.Drawing.Size(240, 31);
            this.hourlyPayText.TabIndex = 7;
            // 
            // positionLabel
            // 
            this.positionLabel.AutoSize = true;
            this.positionLabel.Location = new System.Drawing.Point(8, 337);
            this.positionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.positionLabel.Name = "positionLabel";
            this.positionLabel.Size = new System.Drawing.Size(95, 25);
            this.positionLabel.TabIndex = 0;
            this.positionLabel.Text = "Position:";
            // 
            // positionText
            // 
            this.positionText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.positionText.Location = new System.Drawing.Point(134, 334);
            this.positionText.Margin = new System.Windows.Forms.Padding(4);
            this.positionText.Name = "positionText";
            this.positionText.Size = new System.Drawing.Size(240, 31);
            this.positionText.TabIndex = 6;
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(8, 289);
            this.phoneLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(80, 25);
            this.phoneLabel.TabIndex = 0;
            this.phoneLabel.Text = "Phone:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(6, 154);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(121, 25);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // phoneText
            // 
            this.phoneText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.phoneText.Location = new System.Drawing.Point(134, 286);
            this.phoneText.Margin = new System.Windows.Forms.Padding(4);
            this.phoneText.Name = "phoneText";
            this.phoneText.Size = new System.Drawing.Size(240, 31);
            this.phoneText.TabIndex = 5;
            // 
            // lastNameText
            // 
            this.lastNameText.Location = new System.Drawing.Point(134, 150);
            this.lastNameText.Margin = new System.Windows.Forms.Padding(4);
            this.lastNameText.Name = "lastNameText";
            this.lastNameText.Size = new System.Drawing.Size(240, 31);
            this.lastNameText.TabIndex = 2;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(6, 245);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(71, 25);
            this.emailLabel.TabIndex = 0;
            this.emailLabel.Text = "Email:";
            // 
            // createUserButton
            // 
            this.createUserButton.Location = new System.Drawing.Point(782, 565);
            this.createUserButton.Margin = new System.Windows.Forms.Padding(4);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(144, 38);
            this.createUserButton.TabIndex = 9;
            this.createUserButton.Text = "Create User";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // emailText
            // 
            this.emailText.Location = new System.Drawing.Point(134, 241);
            this.emailText.Margin = new System.Windows.Forms.Padding(4);
            this.emailText.Name = "emailText";
            this.emailText.Size = new System.Drawing.Size(240, 31);
            this.emailText.TabIndex = 4;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 108);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(122, 25);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(6, 199);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(97, 25);
            this.addressLabel.TabIndex = 0;
            this.addressLabel.Text = "Address:";
            // 
            // addressText
            // 
            this.addressText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.addressText.Location = new System.Drawing.Point(134, 195);
            this.addressText.Margin = new System.Windows.Forms.Padding(4);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(240, 31);
            this.addressText.TabIndex = 3;
            // 
            // firstNameText
            // 
            this.firstNameText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.firstNameText.Location = new System.Drawing.Point(134, 104);
            this.firstNameText.Margin = new System.Windows.Forms.Padding(4);
            this.firstNameText.Name = "firstNameText";
            this.firstNameText.Size = new System.Drawing.Size(240, 31);
            this.firstNameText.TabIndex = 1;
            // 
            // payrollLabel
            // 
            this.payrollLabel.AutoSize = true;
            this.payrollLabel.Font = new System.Drawing.Font("Comic Sans MS", 27F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrollLabel.Location = new System.Drawing.Point(432, 4);
            this.payrollLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.payrollLabel.Name = "payrollLabel";
            this.payrollLabel.Size = new System.Drawing.Size(266, 101);
            this.payrollLabel.TabIndex = 0;
            this.payrollLabel.Text = "Payroll";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.outputText);
            this.tabPage2.Controls.Add(this.employeeNameTextBox);
            this.tabPage2.Controls.Add(this.refreshButton);
            this.tabPage2.Controls.Add(this.fullNameLabelList);
            this.tabPage2.Controls.Add(this.payrollLabelList);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1134, 618);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(6, 146);
            this.outputText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(1110, 427);
            this.outputText.TabIndex = 0;
            this.outputText.Text = "Please click Refresh";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(369, 105);
            this.employeeNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(374, 31);
            this.employeeNameTextBox.TabIndex = 1;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(1020, 571);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(108, 40);
            this.refreshButton.TabIndex = 2;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // fullNameLabelList
            // 
            this.fullNameLabelList.AutoSize = true;
            this.fullNameLabelList.Location = new System.Drawing.Point(6, 108);
            this.fullNameLabelList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fullNameLabelList.Name = "fullNameLabelList";
            this.fullNameLabelList.Size = new System.Drawing.Size(353, 25);
            this.fullNameLabelList.TabIndex = 0;
            this.fullNameLabelList.Text = "Please enter employee\'s first name:";
            // 
            // payrollLabelList
            // 
            this.payrollLabelList.AutoSize = true;
            this.payrollLabelList.Font = new System.Drawing.Font("Comic Sans MS", 27F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrollLabelList.Location = new System.Drawing.Point(432, 4);
            this.payrollLabelList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.payrollLabelList.Name = "payrollLabelList";
            this.payrollLabelList.Size = new System.Drawing.Size(266, 101);
            this.payrollLabelList.TabIndex = 0;
            this.payrollLabelList.Text = "Payroll";
            // 
            // totalHoursLabel
            // 
            this.totalHoursLabel.AutoSize = true;
            this.totalHoursLabel.Location = new System.Drawing.Point(6, 435);
            this.totalHoursLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.totalHoursLabel.Name = "totalHoursLabel";
            this.totalHoursLabel.Size = new System.Drawing.Size(126, 25);
            this.totalHoursLabel.TabIndex = 0;
            this.totalHoursLabel.Text = "Total hours:";
            // 
            // totalHoursText
            // 
            this.totalHoursText.ForeColor = System.Drawing.SystemColors.WindowText;
            this.totalHoursText.Location = new System.Drawing.Point(134, 431);
            this.totalHoursText.Margin = new System.Windows.Forms.Padding(4);
            this.totalHoursText.Name = "totalHoursText";
            this.totalHoursText.Size = new System.Drawing.Size(240, 31);
            this.totalHoursText.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1156, 669);
            this.Controls.Add(this.createTabControl);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.createTabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl createTabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label payrollLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameText;
        private System.Windows.Forms.Label fullNameLabelList;
        private System.Windows.Forms.Label payrollLabelList;
        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.Label outputText;
        private System.Windows.Forms.TextBox lastNameText;
        private System.Windows.Forms.Label positionLabel;
        private System.Windows.Forms.TextBox positionText;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox phoneText;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox emailText;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.Label hourlyPayLabel;
        private System.Windows.Forms.TextBox hourlyPayText;
        private System.Windows.Forms.Label totalHoursLabel;
        private System.Windows.Forms.TextBox totalHoursText;
    }
}

