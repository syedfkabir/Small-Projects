using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1_WageCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // create arrays for all stored data
        string[] employeeNames = new string[100];
        double[] hourlyWage = new double[100];
        double[] hoursWorked = new double[100];
        double[] grossIncome = new double[100];
        double[] lessFWT = new double[100];
        double[] netIncome = new double[100];

        /// <summary>  
        /// This function triggers when the calculate button is clicked.
        /// It reads the textbox fields, makes sure they are valid data entries.
        /// Then it updates the labels, while storing all the textbox variables in arrays.
        /// Finally it updates the combo box
        /// </summary>  
        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                // read info from text boxes 
                string eName = tbEmployeeName.Text;
                double hWage = Convert.ToDouble(tbHourlyWage.Text);
                double hWorked = Convert.ToDouble(tbHoursWorked.Text);


                // perform calculations, store values in variables with salient names
                double gEarnings = 0;
                gEarnings = hWage * hWorked;
                if (hWorked > 40)
                {
                    double overtime = (hWorked - 40) * (.5 * hWage);
                    gEarnings += overtime;
                }
                gEarnings = Math.Round(gEarnings, 2);

                double taxes = 0;
                taxes = gEarnings * .15;
                taxes = Math.Round(taxes, 2);

                double nEarnings = 0;
                nEarnings = gEarnings - taxes;
                nEarnings = Math.Round(nEarnings, 2);

                // update labels 

                lblGrossEarnings.Text = "$"+gEarnings.ToString();
                lblLessFWT.Text = "$"+taxes.ToString();
                lblNetEarnings.Text = "$"+nEarnings.ToString();

                // store all variables in arrays 
                // perform a check to locate the first empty index

                for (int i = 0; i < employeeNames.Length; i++)
                {

                    if (hourlyWage[i] == 0)
                    {
                        employeeNames[i] = eName;
                        hourlyWage[i] = hWage;
                        hoursWorked[i] = hWorked;
                        grossIncome[i] = gEarnings;
                        lessFWT[i] = taxes;
                        netIncome[i] = nEarnings;
                        break;
                    }
                }

                // update combo box
                cmbEmployees.Items.Add(eName);
            }
            catch (Exception ex)
            {
                // make sure all the info read is valid, exxception handling 
                string error = ex.ToString();
                MessageBox.Show(Assignment1_WageCalculator.Properties.Resources.user_msg_error_in_textbox, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>  
        ///  This function is triggered when the Display button is clicked
        ///  first clear anything that might be in the list box
        ///  then identify which index we need 
        ///  display all arrays at said index in list box
        /// </summary>  
        private void BtnDisplay_Click(object sender, EventArgs e)
        {

            lbEmployeeInformation.Items.Clear();

            string itemToDisplay = cmbEmployees.SelectedItem.ToString();
            int index = Array.IndexOf(employeeNames, itemToDisplay);

            lbEmployeeInformation.Items.Add("Employee Name: " + employeeNames[index]);
            lbEmployeeInformation.Items.Add("Hours Worked: " + hoursWorked[index]);
            lbEmployeeInformation.Items.Add("Hourly Wage: $" + hourlyWage[index]);
            lbEmployeeInformation.Items.Add("Gross Income: $" + grossIncome[index]);
            lbEmployeeInformation.Items.Add("Less FWT: $" + lessFWT[index]);
            lbEmployeeInformation.Items.Add("Net Income: $" + netIncome[index]);

        }

        /// <summary>  
        ///  This function is triggered when the clear button is clicked
        ///  it clears all fields, except data stored in combo box
        /// </summary>  
        private void BtnClear_Click(object sender, EventArgs e)
        {
            // clear text boxes 
            tbEmployeeName.Clear();
            tbHourlyWage.Clear();
            tbHoursWorked.Clear();

            // clear labels 
            lblGrossEarnings.Text = "";
            lblLessFWT.Text = "";
            lblNetEarnings.Text = "";

        }

        /// <summary>  
        ///  Both of these functions are triggered when pressing the close button
        ///  they have prompts, and take resources from the resx file
        /// </summary>  
        private void BtnClose1_Click(object sender, EventArgs e)
        {

            var dlgResult = MessageBox.Show(Assignment1_WageCalculator.Properties.Resources.user_msg_closing_program, "Exiting Program", MessageBoxButtons.YesNo);
            if (dlgResult == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close(); // close the connection setup form
            }
        }
        private void BtnClose2_Click(object sender, EventArgs e)
        {

            var dlgResult = MessageBox.Show(Assignment1_WageCalculator.Properties.Resources.user_msg_closing_program, "Exiting Program", MessageBoxButtons.YesNo);
            if (dlgResult == System.Windows.Forms.DialogResult.Yes)
            {
                this.Close(); // close the connection setup form
            }
        }


        /// <summary>  
        ///  This function loads when the form loads, 
        ///  It adds dummy data to the combo box
        /// </summary>  
        private void Form1_Load(object sender, EventArgs e)
        {
            
            // dummy data
            employeeNames[0] = "Timmothy Choi";
            hourlyWage[0] = 18.25;
            hoursWorked[0] = 37;
            grossIncome[0] = 675.25;
            lessFWT[0] = 101.28;
            netIncome[0] = 573.97;
            cmbEmployees.Items.Add("Timmothy Choi");

            employeeNames[1] = "Scottie Pippen";
            hourlyWage[1] = 21.25;
            hoursWorked[1] = 44;
            grossIncome[1] = 1000.25;
            lessFWT[1] = 150.28;
            netIncome[1] = 879.97;
            cmbEmployees.Items.Add("Scottie Pippen");
        }




        /// <summary>  
        ///  These methods could not be deleted  
        /// </summary>  
        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void TpDisplay_Click(object sender, EventArgs e)
        {

        }

        private void CmbEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LblLessFWT_Click(object sender, EventArgs e)
        {

        }

    }
}
