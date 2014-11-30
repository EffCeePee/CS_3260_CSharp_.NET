// Project Prologue
// Franklin Colton Parry
// Course: CS 3260
// File: Form1.cs
// Date: 1/20/2014

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.


// using statments
using System;
using calculator;
using System.Windows.Forms;

// namespace 
namespace lab02
{
    /// <summary>
    /// Class calulator
    /// purpose: to calculate complex numbers
    /// Parameters: none
    /// </summary>
    public partial class form_calculator : Form
    {
        /// <summary>
        ///  declare objects to use in the class
        /// </summary>
        ComplexAC calculation = new ComplexAC();
        SingleComplexNumber number = new SingleComplexNumber();

        /// <summary>
        /// initialze the form
        /// default parameters
        /// </summary>
        public form_calculator()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Purpose: Menu strip to exit the program
        /// Parameters:  Default
        /// Returns: None
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Purpse: information about the program
        /// Parameters:  Default
        /// Returns: None
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string name = "Franklin Colton Parry";
            string project = "Complex Calculator";
            string course = "CS 3260";
            MessageBox.Show(project +"\n"+ name + "\n" + course);
        }


        /// <summary>
        /// Pupose: Set the operation of addition and subtraction
        /// Parameters:  Default
        /// Returns: None
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_addition_Click(object sender, EventArgs e)
        {
            string plus = "+";
            string add = "add";
            txt_operator.Clear();
            calculation.SetOpperation(add);
            txt_operator.AppendText(plus);
            
          
        }
        /// <summary>
        /// Pupose: Set the operation of addition and subtraction
        /// Parameters:  Default
        /// Returns: None
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_subtraction_Click(object sender, EventArgs e)
        {
            string minus = "-";
            calculation.SetOpperation(minus);
            txt_operator.Clear();
            txt_operator.AppendText(minus);
            
        }
        /// <summary>
        /// Purpose:  to calculate the numbers of the user
        /// Parameters: default
        /// Returns: void
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_calculate_Click(object sender, EventArgs e)
        {

            /// declare variables
            double realOne = 0;
            double realTwo = 0;
            double complexOne = 0;
            double complexTwo = 0;

            
            string plusOrMinus = calculation.GetOpperation();
            string opperationError = "Please select to add or subtract";
            string numError = "Please enter in a valid number";
            
            string opperand1r = txt_opperand1r.Text;
            string opperand2r = txt_opperand2r.Text;
            string opperand1c = txt_opperand1c.Text;
            string opperand2c = txt_opperand2c.Text;


            /// testing the inputs for numbers
            bool isNum1r = double.TryParse(opperand1r, out realOne);
            bool isNum2r = double.TryParse(opperand2r, out realTwo);
            bool isNum1c = double.TryParse(opperand1c, out complexOne);
            bool isNum2c = double.TryParse(opperand2c, out complexTwo);

            /// validation of numbers if not show a box to fix the error
            if (!isNum1r || !isNum2r || !isNum1c || !isNum2c)
            {
                MessageBox.Show(numError);
            }
            else if (plusOrMinus == null)
            {
                MessageBox.Show(opperationError);
            }
            else
            {
                /// Purpose: use calculation object to calculate the numbers
                /// Parameters:  4 doubles, one number object
                /// returns the number object
                calculation.calculate(realOne, realTwo, complexOne, complexTwo, number);
                txt_result.Clear();

                /// displays the number in the text box
                txt_result.AppendText(number.getComplexNumber());
            }
        }

    }
}
