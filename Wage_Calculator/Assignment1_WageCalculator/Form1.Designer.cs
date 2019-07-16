namespace Assignment1_WageCalculator
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tpCalculate = new System.Windows.Forms.TabPage();
            this.btnClose1 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblNetEarnings = new System.Windows.Forms.Label();
            this.lblLessFWT = new System.Windows.Forms.Label();
            this.lblGrossEarnings = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbHoursWorked = new System.Windows.Forms.TextBox();
            this.tbHourlyWage = new System.Windows.Forms.TextBox();
            this.tbEmployeeName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tpDisplay = new System.Windows.Forms.TabPage();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.btnClose2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbEmployees = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbEmployeeInformation = new System.Windows.Forms.ListBox();
            this.tabControl1.SuspendLayout();
            this.tpCalculate.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpDisplay.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tpCalculate);
            this.tabControl1.Controls.Add(this.tpDisplay);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(392, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tpCalculate
            // 
            this.tpCalculate.Controls.Add(this.btnClose1);
            this.tpCalculate.Controls.Add(this.btnClear);
            this.tpCalculate.Controls.Add(this.btnCalculate);
            this.tpCalculate.Controls.Add(this.groupBox2);
            this.tpCalculate.Controls.Add(this.groupBox1);
            this.tpCalculate.Location = new System.Drawing.Point(4, 22);
            this.tpCalculate.Name = "tpCalculate";
            this.tpCalculate.Padding = new System.Windows.Forms.Padding(3);
            this.tpCalculate.Size = new System.Drawing.Size(384, 400);
            this.tpCalculate.TabIndex = 0;
            this.tpCalculate.Text = "Calculate";
            this.tpCalculate.UseVisualStyleBackColor = true;
            this.tpCalculate.Click += new System.EventHandler(this.TabPage1_Click);
            // 
            // btnClose1
            // 
            this.btnClose1.Location = new System.Drawing.Point(206, 357);
            this.btnClose1.Name = "btnClose1";
            this.btnClose1.Size = new System.Drawing.Size(68, 37);
            this.btnClose1.TabIndex = 1;
            this.btnClose1.Text = "Close";
            this.btnClose1.UseVisualStyleBackColor = true;
            this.btnClose1.Click += new System.EventHandler(this.BtnClose1_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(119, 357);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(68, 37);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(119, 158);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(155, 28);
            this.btnCalculate.TabIndex = 2;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblNetEarnings);
            this.groupBox2.Controls.Add(this.lblLessFWT);
            this.groupBox2.Controls.Add(this.lblGrossEarnings);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(25, 192);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(327, 159);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calculated wage";
            this.groupBox2.Enter += new System.EventHandler(this.GroupBox2_Enter);
            // 
            // lblNetEarnings
            // 
            this.lblNetEarnings.AutoSize = true;
            this.lblNetEarnings.Location = new System.Drawing.Point(102, 111);
            this.lblNetEarnings.Name = "lblNetEarnings";
            this.lblNetEarnings.Size = new System.Drawing.Size(0, 13);
            this.lblNetEarnings.TabIndex = 5;
            // 
            // lblLessFWT
            // 
            this.lblLessFWT.AutoSize = true;
            this.lblLessFWT.Location = new System.Drawing.Point(102, 76);
            this.lblLessFWT.Name = "lblLessFWT";
            this.lblLessFWT.Size = new System.Drawing.Size(0, 13);
            this.lblLessFWT.TabIndex = 4;
            this.lblLessFWT.Click += new System.EventHandler(this.LblLessFWT_Click);
            // 
            // lblGrossEarnings
            // 
            this.lblGrossEarnings.AutoSize = true;
            this.lblGrossEarnings.Location = new System.Drawing.Point(102, 41);
            this.lblGrossEarnings.Name = "lblGrossEarnings";
            this.lblGrossEarnings.Size = new System.Drawing.Size(0, 13);
            this.lblGrossEarnings.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Net Earnings:";
            this.label6.Click += new System.EventHandler(this.Label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Less FWT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Gross Earnings:";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbHoursWorked);
            this.groupBox1.Controls.Add(this.tbHourlyWage);
            this.groupBox1.Controls.Add(this.tbEmployeeName);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(25, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 135);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Please input the employee information: ";
            // 
            // tbHoursWorked
            // 
            this.tbHoursWorked.Location = new System.Drawing.Point(105, 92);
            this.tbHoursWorked.Name = "tbHoursWorked";
            this.tbHoursWorked.Size = new System.Drawing.Size(194, 20);
            this.tbHoursWorked.TabIndex = 5;
            // 
            // tbHourlyWage
            // 
            this.tbHourlyWage.Location = new System.Drawing.Point(105, 62);
            this.tbHourlyWage.Name = "tbHourlyWage";
            this.tbHourlyWage.Size = new System.Drawing.Size(194, 20);
            this.tbHourlyWage.TabIndex = 4;
            // 
            // tbEmployeeName
            // 
            this.tbEmployeeName.Location = new System.Drawing.Point(105, 32);
            this.tbEmployeeName.Name = "tbEmployeeName";
            this.tbEmployeeName.Size = new System.Drawing.Size(194, 20);
            this.tbEmployeeName.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hours Worked:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hourly Wage:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee name:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // tpDisplay
            // 
            this.tpDisplay.Controls.Add(this.btnDisplay);
            this.tpDisplay.Controls.Add(this.btnClose2);
            this.tpDisplay.Controls.Add(this.label7);
            this.tpDisplay.Controls.Add(this.cmbEmployees);
            this.tpDisplay.Controls.Add(this.groupBox3);
            this.tpDisplay.Location = new System.Drawing.Point(4, 22);
            this.tpDisplay.Name = "tpDisplay";
            this.tpDisplay.Padding = new System.Windows.Forms.Padding(3);
            this.tpDisplay.Size = new System.Drawing.Size(384, 400);
            this.tpDisplay.TabIndex = 1;
            this.tpDisplay.Text = "Display";
            this.tpDisplay.UseVisualStyleBackColor = true;
            this.tpDisplay.Click += new System.EventHandler(this.TpDisplay_Click);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(237, 49);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(91, 21);
            this.btnDisplay.TabIndex = 4;
            this.btnDisplay.Text = "Display";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.BtnDisplay_Click);
            // 
            // btnClose2
            // 
            this.btnClose2.Location = new System.Drawing.Point(101, 343);
            this.btnClose2.Name = "btnClose2";
            this.btnClose2.Size = new System.Drawing.Size(159, 33);
            this.btnClose2.TabIndex = 3;
            this.btnClose2.Text = "Close";
            this.btnClose2.UseVisualStyleBackColor = true;
            this.btnClose2.Click += new System.EventHandler(this.BtnClose2_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(269, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Choose from the list of Employees to display their wages";
            // 
            // cmbEmployees
            // 
            this.cmbEmployees.FormattingEnabled = true;
            this.cmbEmployees.Location = new System.Drawing.Point(62, 49);
            this.cmbEmployees.Name = "cmbEmployees";
            this.cmbEmployees.Size = new System.Drawing.Size(169, 21);
            this.cmbEmployees.TabIndex = 1;
            this.cmbEmployees.Text = "Employee Names";
            this.cmbEmployees.SelectedIndexChanged += new System.EventHandler(this.CmbEmployees_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbEmployeeInformation);
            this.groupBox3.Location = new System.Drawing.Point(33, 76);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(311, 247);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Employee\'s Information";
            // 
            // lbEmployeeInformation
            // 
            this.lbEmployeeInformation.FormattingEnabled = true;
            this.lbEmployeeInformation.Location = new System.Drawing.Point(29, 32);
            this.lbEmployeeInformation.Name = "lbEmployeeInformation";
            this.lbEmployeeInformation.Size = new System.Drawing.Size(254, 173);
            this.lbEmployeeInformation.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Wage Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tpCalculate.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpDisplay.ResumeLayout(false);
            this.tpDisplay.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tpCalculate;
        private System.Windows.Forms.TabPage tpDisplay;
        private System.Windows.Forms.Button btnClose1;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbHoursWorked;
        private System.Windows.Forms.TextBox tbHourlyWage;
        private System.Windows.Forms.TextBox tbEmployeeName;
        private System.Windows.Forms.Label lblNetEarnings;
        private System.Windows.Forms.Label lblLessFWT;
        private System.Windows.Forms.Label lblGrossEarnings;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbEmployees;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnClose2;
        private System.Windows.Forms.Button btnDisplay;
        private System.Windows.Forms.ListBox lbEmployeeInformation;
    }
}

