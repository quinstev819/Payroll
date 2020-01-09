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
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.LatNameText = new System.Windows.Forms.TextBox();
            this.createUserButton = new System.Windows.Forms.Button();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameText = new System.Windows.Forms.TextBox();
            this.payrollLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.outputText = new System.Windows.Forms.Label();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.refreshButton = new System.Windows.Forms.Button();
            this.fullNameLabelList = new System.Windows.Forms.Label();
            this.payrollLabelList = new System.Windows.Forms.Label();
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
            this.createTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lastNameLabel);
            this.tabPage1.Controls.Add(this.LatNameText);
            this.tabPage1.Controls.Add(this.createUserButton);
            this.tabPage1.Controls.Add(this.firstNameLabel);
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
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(6, 154);
            this.lastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(121, 25);
            this.lastNameLabel.TabIndex = 5;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // LatNameText
            // 
            this.LatNameText.Location = new System.Drawing.Point(134, 150);
            this.LatNameText.Margin = new System.Windows.Forms.Padding(4);
            this.LatNameText.Name = "LatNameText";
            this.LatNameText.Size = new System.Drawing.Size(240, 31);
            this.LatNameText.TabIndex = 4;
            // 
            // createUserButton
            // 
            this.createUserButton.Location = new System.Drawing.Point(782, 565);
            this.createUserButton.Margin = new System.Windows.Forms.Padding(4);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(144, 38);
            this.createUserButton.TabIndex = 3;
            this.createUserButton.Text = "Create User";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(6, 108);
            this.firstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(122, 25);
            this.firstNameLabel.TabIndex = 2;
            this.firstNameLabel.Text = "First Name:";
            // 
            // firstNameText
            // 
            this.firstNameText.ForeColor = System.Drawing.SystemColors.ActiveBorder;
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
            this.outputText.TabIndex = 6;
            this.outputText.Text = "Please click Refresh";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(354, 102);
            this.employeeNameTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(374, 31);
            this.employeeNameTextBox.TabIndex = 5;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(1020, 571);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(108, 40);
            this.refreshButton.TabIndex = 4;
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
            this.fullNameLabelList.Size = new System.Drawing.Size(346, 25);
            this.fullNameLabelList.TabIndex = 3;
            this.fullNameLabelList.Text = "Please enter employee\'s full name:";
            // 
            // payrollLabelList
            // 
            this.payrollLabelList.AutoSize = true;
            this.payrollLabelList.Font = new System.Drawing.Font("Comic Sans MS", 27F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrollLabelList.Location = new System.Drawing.Point(432, 4);
            this.payrollLabelList.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.payrollLabelList.Name = "payrollLabelList";
            this.payrollLabelList.Size = new System.Drawing.Size(266, 101);
            this.payrollLabelList.TabIndex = 1;
            this.payrollLabelList.Text = "Payroll";
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
        private System.Windows.Forms.TextBox LatNameText;
    }
}

