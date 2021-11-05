//Tom Bielawski
//10-4-2020
//FSCJ COP2360C Code Test 1 Professor Gherig
//Hurricane Preparedness Calculator

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HurricanePrepCalc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Clear Button event handler
        private void clearButton_Click(object sender, EventArgs e)
        {
            //Clear the results label and the input text box
            resultsLabel.Text = " ";
            numberOfPeopleTextBox.Clear();
            //Return the focus to the input text box
            numberOfPeopleTextBox.Focus();
        }

        //Exit button event handler
        private void exitButton_Click(object sender, EventArgs e)
        {
            //Close the application
            Close();
        }

        //Calculate button event handler
        private void calcButton_Click(object sender, EventArgs e)
        {
            //Declare the constants
            const decimal NUM_DAYS = 3m;
            const decimal WATER_COST = .80m;

            //Declare the variables
            decimal numberOfPeople = 0m;
            decimal totalWaterCost = 0m;
            //decimal totalWaterUsed = 0m;
            decimal totalGallonsUsed = 0m;

            //Convert input to decimal
            numberOfPeople = decimal.Parse(numberOfPeopleTextBox.Text);

            //Calculate total water usage
            totalGallonsUsed = numberOfPeople * NUM_DAYS;

            //Calculate total water cost
            totalWaterCost = totalGallonsUsed * WATER_COST;

            //Display output with ToString() and format options
            resultsLabel.Text = "Your total cost of water over " + NUM_DAYS + " days is " + totalWaterCost.ToString("c") + "." +
                "\nYour total water used over " + NUM_DAYS + " days is " + totalGallonsUsed.ToString("n0") + " gallons.";


        }
    }
}
