
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/*
 * Group 3 Assignment 6
 * Hospital Bill Calculator
 * Max Herrington
 * Dinesh Ram Condur
 * Monica Devireddy
 * Fatemeh Jalali
 * 
 * Group 3 was tasked with creating a program that would calculate 
 * the user's hospital stay using methods. We were to create a CalcStayCharges
 * method to calculate the stay charge (amount of days *350). A CalcMiscCharges
 * method which adds the medication,lab, rehab, and surgical fees. A CalcTotalCharges
 * method which takes the results of the other two methods and adds them together.
 */

namespace Hospital_Stay
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		//method to reset the user input and total labels
		public void Reset(){

			//reset the 3 labels to their default text
			lblStayCost.Text = "0";
			lblMiscCost.Text = "0";
			lblTotalCost.Text = "0";

			//clear out the user input from the text boxes
			txtDaysStayed.Text = "";
			txtLabFees.Text = "";
			txtRehab.Text = "";
			txtSurgical.Text = "";
			txtMedication.Text = "";
		}
		//method to close the program and advise the user of when their bill is due
		public void Exit(){
			//set due date to one week from current date
			string dueDate = DateTime.Now.AddDays(7).ToString("yyyy/MM/dd");

			//display a message box giving the total payment and payment due date
			MessageBox.Show($"Your payment of {lblTotalCost.Text} is due: {dueDate}. Have a wonderful day");

			//write the invoice to a file
			StreamWriter hospitalBill = new StreamWriter
				(@"C:\Users\m_a_x\Documents\Software_Dev\Assignment6\bill.txt");

			hospitalBill.WriteLine($"Hospital Bill			Due Date: {dueDate}\r\n\r\n" +
				$"Days Stayed			{txtDaysStayed.Text}\r\n" +
				$"Stay Charge			${lblStayCost.Text}\r\n" +
				$"Medication Charge		${txtMedication.Text}\r\n" +
				$"Surgical Fees			${txtSurgical.Text}\r\n"+
				$"Lab Fees			${txtLabFees.Text}\r\n" +
				$"Rehab Fees			${txtRehab.Text}\r\n\r\n" + 
				$"Total due:			{lblTotalCost.Text}\r\n\r\n" +
				$"You really don't want to see what happens if you don't pay up.....");
			hospitalBill.Close();

			//exit the program
			Close();
		}
		//method to calculate the stay charge of $350/night
		public string CalcStayCharges(string days)
		{
			//convert the days stayed string to an int
			int daysStayed = Convert.ToInt16(days);

			//convert the user input string into a double to make the calculation
			double stayCost = Convert.ToDouble(daysStayed) * 350.00;

			//return the calulation converted back to a string to the stay cost label
			return lblStayCost.Text = string.Format("{0:0.00}",stayCost);			
		}
		//method to calculate the total miscellaneous costs
		public string CalcMiscCharges(string meds, string surg, string lab, string rehab){

			//convert each of the misc cost user input strings to double to make the calculation
			double medsCost = Convert.ToDouble(meds);
			double surgCost = Convert.ToDouble(surg);
			double labCost = Convert.ToDouble(lab);
			double rehabCost = Convert.ToDouble(rehab);

			//add all of the new double amounts
			double miscCost =  medsCost + surgCost + labCost + rehabCost;

			//return the sum converted back into a string into the misc cost label
			return lblMiscCost.Text = String.Format("{0:0.00}", miscCost);
		}	
		//method to calculate the total charges
		public string CalcTotalCharges(string miscCost, string stayCost){

			//convert the string values returned from the other two methods and 
			double totalCost = Convert.ToDouble(miscCost) + Convert.ToDouble(stayCost);
			return lblTotalCost.Text = "$" + String.Format("{0:0.00}",totalCost);
		}
		//method to insert default values of 0 for fields with no user input
		public void CheckForValue(){
			if (txtDaysStayed.Text == ""){
				txtDaysStayed.Text = "1";
				MessageBox.Show("You must stay for at least one day");
			}
			if (txtLabFees.Text == ""){
				txtLabFees.Text = "0";
			}
			if (txtMedication.Text == ""){
				txtMedication.Text = "0";
			}
			if (txtRehab.Text == ""){
				txtRehab.Text = "0";
			}
			if (txtSurgical.Text == ""){
				txtSurgical.Text = "0";
			}
		}
		//button to calculate the grand total
		private void btnTotalCalc_Click(object sender, EventArgs e){

			//make sure each box has a value
			CheckForValue();
			try{
				//calculate the stay charges
				CalcStayCharges(txtDaysStayed.Text);

				//calculate the miscellaneous charges
				CalcMiscCharges(txtMedication.Text, txtSurgical.Text, txtLabFees.Text, txtRehab.Text);
			}
			catch (Exception){

				MessageBox.Show("Please enter a whole number in the Days Stayed field, and Decimal Values" +
					" in the Misc Charges fields.");
				Reset();
			}

			//calculate the total charges
			CalcTotalCharges(lblStayCost.Text, lblMiscCost.Text);
		}
		//button to reset the totals to 0 and the user input textboxes to ""
		private void btnReset_Click(object sender, EventArgs e){

			Reset();
		}
		//button to exit the program and show when your bill is due
		private void btnExit_Click(object sender, EventArgs e){

			Exit();
		}
	}
}
