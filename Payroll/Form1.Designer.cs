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
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressText = new System.Windows.Forms.TextBox();
            this.createUserButton = new System.Windows.Forms.Button();
            this.fullNameLabel = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
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
            this.createTabControl.Location = new System.Drawing.Point(1, 1);
            this.createTabControl.Margin = new System.Windows.Forms.Padding(2);
            this.createTabControl.Name = "createTabControl";
            this.createTabControl.SelectedIndex = 0;
            this.createTabControl.Size = new System.Drawing.Size(575, 346);
            this.createTabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.addressLabel);
            this.tabPage1.Controls.Add(this.addressText);
            this.tabPage1.Controls.Add(this.createUserButton);
            this.tabPage1.Controls.Add(this.fullNameLabel);
            this.tabPage1.Controls.Add(this.fullNameTextBox);
            this.tabPage1.Controls.Add(this.payrollLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(567, 320);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create New User";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(3, 80);
            this.addressLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(48, 13);
            this.addressLabel.TabIndex = 5;
            this.addressLabel.Text = "Address:";
            // 
            // addressText
            // 
            this.addressText.Location = new System.Drawing.Point(67, 78);
            this.addressText.Margin = new System.Windows.Forms.Padding(2);
            this.addressText.Name = "addressText";
            this.addressText.Size = new System.Drawing.Size(122, 20);
            this.addressText.TabIndex = 4;
            // 
            // createUserButton
            // 
            this.createUserButton.Location = new System.Drawing.Point(391, 294);
            this.createUserButton.Margin = new System.Windows.Forms.Padding(2);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(72, 20);
            this.createUserButton.TabIndex = 3;
            this.createUserButton.Text = "Create User";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.AutoSize = true;
            this.fullNameLabel.Location = new System.Drawing.Point(3, 56);
            this.fullNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(57, 13);
            this.fullNameLabel.TabIndex = 2;
            this.fullNameLabel.Text = "Full Name:";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(67, 54);
            this.fullNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(122, 20);
            this.fullNameTextBox.TabIndex = 1;
            // 
            // payrollLabel
            // 
            this.payrollLabel.AutoSize = true;
            this.payrollLabel.Font = new System.Drawing.Font("Comic Sans MS", 27F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrollLabel.Location = new System.Drawing.Point(216, 2);
            this.payrollLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.payrollLabel.Name = "payrollLabel";
            this.payrollLabel.Size = new System.Drawing.Size(134, 51);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(567, 320);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "List";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // outputText
            // 
            this.outputText.Location = new System.Drawing.Point(3, 76);
            this.outputText.Name = "outputText";
            this.outputText.Size = new System.Drawing.Size(555, 222);
            this.outputText.TabIndex = 6;
            this.outputText.Text = "Please click Refresh";
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Location = new System.Drawing.Point(177, 53);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(189, 20);
            this.employeeNameTextBox.TabIndex = 5;
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(510, 297);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(2);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(54, 21);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // fullNameLabelList
            // 
            this.fullNameLabelList.AutoSize = true;
            this.fullNameLabelList.Location = new System.Drawing.Point(3, 56);
            this.fullNameLabelList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.fullNameLabelList.Name = "fullNameLabelList";
            this.fullNameLabelList.Size = new System.Drawing.Size(169, 13);
            this.fullNameLabelList.TabIndex = 3;
            this.fullNameLabelList.Text = "Please enter employee\'s full name:";
            // 
            // payrollLabelList
            // 
            this.payrollLabelList.AutoSize = true;
            this.payrollLabelList.Font = new System.Drawing.Font("Comic Sans MS", 27F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.payrollLabelList.Location = new System.Drawing.Point(216, 2);
            this.payrollLabelList.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.payrollLabelList.Name = "payrollLabelList";
            this.payrollLabelList.Size = new System.Drawing.Size(134, 51);
            this.payrollLabelList.TabIndex = 1;
            this.payrollLabelList.Text = "Payroll";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 348);
            this.Controls.Add(this.createTabControl);
            this.Margin = new System.Windows.Forms.Padding(2);
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
        private System.Windows.Forms.Label fullNameLabel;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.Label fullNameLabelList;
        private System.Windows.Forms.Label payrollLabelList;
        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressText;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.Label outputText;
    }
}

