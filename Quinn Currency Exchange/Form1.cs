using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.IO;

namespace Quinn_Currency_Exchange
{
    public partial class Form1 : Form
    {
        //set a constant decimal for the rate for using a passport card
        const decimal PASSPORTFEE = .02m;
        //set variables for inputing information into the output file, setting early because working most in multiple methods
        //also setting a counter for the same reason
        int counter = 1;
        decimal globalInput;
        decimal globalOutput;
        decimal globalFloatingOutput;
        string globalCurrency;
        string globalInitialCurrency;
        string globalTransactionType;
        string globalPassportNumber;
        decimal globalFee;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //try, catch for creating a new text file to output data on
            try
            {
                //streamwriter information
                StreamWriter outputFile;
                //I added this line here because the notes on the project file state to add encoding, but Visual Studio 2017 automatically sets the encoding to allow for euros in .txt files. 
                //Encoding encoding = Encoding.GetEncoding("utf-16");
                outputFile = File.CreateText("FXTsn.txt");
                //closes output file
                outputFile.Close();
            }
            catch
            {

            }
        }
        private void checkButton_Click(object sender, EventArgs e)
        {
            //try, catch
            try
            {   //set variables to use in method, like userinput from textbox, rate of conversion, what currencies to convert from and to, total result, amount of money coming from rate of fees, 
                //and if the transaction will have fees, not boolean because of futureproofing if someone wants to add checks for example as payment method
                int userInput;
                decimal rate;
                string firstSelection;
                string secondSelection;
                decimal result;
                decimal passportTotalFee;
                string transactionType;
                //tries to parse input from user textbox if it's a valid integer
                if (int.TryParse(amountTextBox.Text, out userInput))
                {
                    //tests to see if there's a selected item for listbox, not really needed but still good to have
                    if (startingListBox.SelectedIndex != -1)
                    {
                        //sets both variables to whatever currency user selected
                        firstSelection = startingListBox.SelectedItem.ToString();
                        secondSelection = endingListBox.SelectedItem.ToString();
                        //checks to make sure those currencies aren't the same
                        if (firstSelection != secondSelection)
                        {
                            //sets invisible labels to visible and enables the buy button
                            buyButton.Enabled = true;
                            transactionLabel.Visible = true;
                            conversionRateLabel.Visible = true;
                            startingValueLabel.Visible = true;
                            endingValueLabel.Visible = true;
                            //decision tree for currencies
                            switch (firstSelection)
                            {
                                //if original is dollars
                                case "USD":
                                    switch (secondSelection)
                                    {//if wants to convert to euros
                                        case "EUR":
                                            rate = .94m;
                                            conversionRateLabel.Text = "Conversion Rate: 1 USD = 0.94 Euro";
                                            break;
                                        //if wants to convert to pounds
                                        case "GBP":
                                            rate = .79m;
                                            conversionRateLabel.Text = "Conversion Rate: 1 USD = 0.74 GBP";
                                            break;
                                        default:
                                            //set error handle for this statement, not needed but set just in case
                                            MessageBox.Show("Error with calculation of selection.");
                                            rate = 1m;
                                            break;
                                    }
                                    break;
                                //if original is euros
                                case "EUR":
                                    switch (secondSelection)
                                    {
                                        //if wants to convert to dollars
                                        case "USD":
                                            rate = 1.06m;
                                            conversionRateLabel.Text = "Conversion Rate: 1 Euro = 1.06 USD";
                                            break;
                                        //if wants to convert to pounds
                                        case "GBP":
                                            rate = .85m;
                                            conversionRateLabel.Text = "Conversion Rate: 1 Euro = 0.85 GBP";
                                            break;
                                        default:
                                            //set error handle for this statement, again not needed but set just in case
                                            MessageBox.Show("Error with calculation of selection.");
                                            rate = 1m;
                                            break;
                                    }
                                    break;
                                //if original is pounds
                                case "GBP":
                                    switch (secondSelection)
                                    {//if wants to convert to dollars
                                        case "USD":
                                            rate = 1.25m;
                                            conversionRateLabel.Text = "Conversion Rate: 1 GBP = 1.25 USD";
                                            break;
                                        //if wants to convert to euros
                                        case "EUR":
                                            rate = 1.17m;
                                            conversionRateLabel.Text = "Conversion Rate: 1 GBP = 1.17 USD";
                                            break;
                                        default:
                                            //set error handle for this statement, again not needed but set just in case
                                            MessageBox.Show("Error with calculation of selection.");
                                            rate = 1m;
                                            break;
                                    }
                                    break;
                                default:
                                    //set error handle for this statement, again not needed but set just in case
                                    MessageBox.Show("Error with calculation of selection.");
                                    rate = 1m;
                                    break;

                            }
                            //calculates an initial result from the user input and currency exchange rate
                            result = (decimal)userInput * rate;
                            //sets label's text values to show the amount of each value plus how many bought
                            transactionLabel.Text = "Transaction number:" + counter.ToString();
                            startingValueLabel.Text = "Amount in " + firstSelection + ": " + rateSelection(firstSelection, userInput);
                            endingValueLabel.Text = "Amount in " + secondSelection + ": " + rateSelection(secondSelection, result);
                            //checks to see if selected passport card button
                            if (passportRadioButton.Checked == true)
                            {
                                //sets variable to have pre-added result, calcs the fee, final result, sets label text for fees and sets it to visible, sets the kind of transaction it is, sets variable to final result
                                globalFloatingOutput = result;
                                passportTotalFee = result * PASSPORTFEE;
                                result = result + passportTotalFee;
                                passportFeeLabel.Text = "Plus " + rateSelection(secondSelection, passportTotalFee) + " Fee for passport.";
                                passportFeeLabel.Visible = true;
                                transactionType = "Passport";
                                globalFee = passportTotalFee;
                            }
                            else
                            {
                                //if it's not a passport card it's cash
                                passportFeeLabel.Visible = false;
                                transactionType = "Cash";
                            }
                            //sets the rest of the number variables to variables for outputting later
                            globalInitialCurrency = firstSelection;
                            globalInput = userInput;
                            globalOutput = result;
                            globalCurrency = secondSelection;
                            globalTransactionType = transactionType;


                        }
                        else
                        {
                            //error handling on testing the original and converted currency types
                            MessageBox.Show("Please select two different currencies to exchange.");
                        }
                    }
                    else
                    {
                        //error handling on selecting an option on both lists
                        MessageBox.Show("Please select two different currencies to exchange.");
                    }
                }
                else
                {
                    //error handling on integer entered
                    MessageBox.Show("Please input a whole number into the amount textbox");
                }
            }
            catch
            {
                //catch-all try, catch error handling
                MessageBox.Show("Please input a whole number into the amount textbox as well as the currencies you want to convert.");
            }
        }

        private void buyButton_Click(object sender, EventArgs e)
        {
            //sets variables for working on passport number, could set so it only calculates if it's requried but didn't think of it as a problem
            //0-9 integer, its final string value, its incremental amount, also sets random obj
            int passportDecimalValue;
            string passportFullValue;
            passportFullValue = "";
            int increment;
            Random rand = new Random();
            //for loop incrementing smaller to create passport number, sets to string because gets bad exponent otherwise if int or double
            for (increment = 15; increment >= 0; increment--)
            {
                passportDecimalValue = rand.Next(10);
                passportFullValue += passportDecimalValue.ToString();


            }
            //sets created passport value to output file variable for passport number
            globalPassportNumber = passportFullValue;
            //try, catch for writing to file
            try
            {
                //sets output obj, opens file, writes lines to .txt
                StreamWriter outputFile;
                outputFile = File.AppendText("FXTsn.txt");
                //writes transaction number
                outputFile.WriteLine("Transaction number: " + counter.ToString());
                //writes initial value
                outputFile.WriteLine("Initial value: " + rateSelection(globalInitialCurrency, globalInput));
                //conditional if it's a passport so it'll write something different
                if (globalTransactionType == "Passport")
                {
                    //also set different messagebox output for the transaction being complete while things being written, better to have in same loop
                    MessageBox.Show("Transaction complete! Passport number: " + globalPassportNumber.ToString());
                    //value before fees
                    outputFile.WriteLine("Final value before fees: " + rateSelection(globalCurrency, globalFloatingOutput));
                    //values after fees
                    outputFile.WriteLine("Final value after fees: " + rateSelection(globalCurrency, globalOutput));
                    //value of fees
                    outputFile.WriteLine("Fees: " + rateSelection(globalCurrency, globalFee));
                }
                else
                //if it's cash
                {
                    //normal transaction message
                    MessageBox.Show("Transaction complete!");
                    //shows final fees
                    outputFile.WriteLine("Final value: " + rateSelection(globalCurrency, globalOutput));
                }
                //writes number of passport
                outputFile.WriteLine("Passport number: " + globalPassportNumber);
                //close output
                outputFile.Close();
            }
            //error handling if output fails
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //calls method to clear form
            clearBoard();
            //increments the transaction number
            counter++;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            //calls methd to clear form
            clearBoard();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close form
            this.Close();
        }
        private string rateSelection(string selection, decimal value)
        {
            //variable to return string of converted value of number needing currency format
            string returnString;
            //tree for choosing correct format for string output
            switch (selection)
            {
                case "USD":
                    returnString = value.ToString("C", CultureInfo.CreateSpecificCulture("en-US"));
                    break;
                case "EUR":
                    returnString = value.ToString("C", CultureInfo.CreateSpecificCulture("fr-FR"));
                    break;
                case "GBP":
                    returnString = value.ToString("C", CultureInfo.CreateSpecificCulture("en-GB"));
                    break;
                default:
                    //error handling if not provided with valid currency type
                    MessageBox.Show("Error with calculation of selection.");
                    returnString = "ERROR";
                    break;

            }
            //return string for converted amount
            return returnString;
        }
        private void clearBoard()
        {
            //resets form by setting listboxes to index 0 and 1 respectively, clears out texts on labels, disables button, hides labels, sets cash radio button to checked, sets focus to textbox
            startingListBox.SelectedIndex = 0;
            endingListBox.SelectedIndex = 1;
            amountTextBox.Text = "";
            buyButton.Enabled = false;
            transactionLabel.Visible = false;
            conversionRateLabel.Visible = false;
            startingValueLabel.Visible = false;
            endingValueLabel.Visible = false;
            passportFeeLabel.Visible = false;
            transactionLabel.Text = "";
            conversionRateLabel.Text = "";
            startingValueLabel.Text = "";
            endingValueLabel.Text = "";
            passportFeeLabel.Text = "";
            cashRadioButton.Checked = true;
            amountTextBox.Focus();
        }
    }
}
