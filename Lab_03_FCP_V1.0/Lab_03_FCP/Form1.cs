// Project Prologue
// Franklin Colton Parry
// Course: CS 3260
// File: Form1.cs
// Date: 1/27/2014

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

// using statments
using System;
using employee;
using Test_Data;
using System.Windows.Forms;

// Namespace Declaration
namespace Employee_Form
{
    
    /// <summary>
    /// Purpose: To have a form that will implement our form for the employee program
    /// Returns: none
    /// Parameters: None
    /// Description: A form that will take inputs and store them in an employee array
    /// </summary>
    public partial class Form_Employee : Form
    {
        //------------------- Constants--------------------------
        const int SIZE = 10;

        //--------------New Instances----------------------
        Employee emp = new Hourly();
        Employee blank = new Hourly();
        TestData test = new TestData();
        Employee[] userData = new Employee[SIZE];

        //------------------- Variables--------------------------
        string _error = "You're trying to load an empty employee object";
        string _HrsWorked = "Hours Worked:";
        string _HourlyWage = "Hourly Wage:";
        string _MonthlySal = "Monthly Salary:";
        string _GrossSal = "Gross Sales:";
        string _ContractSal = "Contract Salary:";
        string _CommissionSales = "Commission Sales:";
        string _AddError = "No employee was added please fill out all data";
        
        string _lbl1 = "Label 1:";
        string _lbl2 = "Label 2:";
        string _lbl3 = "Lable 3:";

        int _UserIndex = 0;
        int _TestIndex = 0;

        /// <summary>
        /// Purpose: to initialize the main form
        /// </summary>
        public Form_Employee()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Purpose: to load the data into the form
        /// returns: void
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form_Employee_Load(object sender, EventArgs e)
        {
            txt_empName.Text = emp._EmpName;
            txt_empID.Text = Convert.ToString(emp._EmpID);
            dbox_empType.Text = emp._EmpType;
            txt_info1.Text = Convert.ToString(emp._HourlyRate);
            txt_info2.Text = Convert.ToString(emp._HoursWorked);
            txt_info3.Text = Convert.ToString(emp._MonthlySalary);
        }

        /// <summary>
        /// Purpose: to load up the test data into the form when the button is clicked
        /// Returnn: void
        /// Description: each time a new type is called it will load the form with test data
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_TestData_Click(object sender, EventArgs e)
        {
            emp = test.empl[_TestIndex];
            calc_index(_TestIndex);
            formLoad(emp._EmpType);
        }

        /// <summary>
        /// purpose: calculates the location of the test data index
        /// </summary>
        /// <param name="i"></param>
        /// <returns> int of the indexlocation </returns>
        private int calc_index(int i)
        {

            switch(test.empl[i]._EmpType)
            {
                case "Hourly":
                    _TestIndex++;
                    break;
                case "Salary":
                    _TestIndex++;
                    break;
                case "Sales":
                    _TestIndex++;
                    break;
                case "Contract":
                    _TestIndex++;
                    break;
                case "":
                    _TestIndex = 0;
                    break;
                case null:
                    _TestIndex = 0;
                    break;
                default:
                    _TestIndex = 0;
                    break;

            }


            return _TestIndex;
        }

        /// <summary>
        /// Purpose: sets the form with the proper lables and boxes based on type
        /// </summary>
        /// <param name="type"></param>
        public void formLoad(string type)
        {
            switch (type)
            {
                case "Hourly":

                    txt_empName.Text = emp._EmpName;
                    txt_empID.Text = Convert.ToString(emp._EmpID);
                    dbox_empType.Text = emp._EmpType;
                    lbl_info1.Show();
                    lbl_info1.Text = _HrsWorked;
                    txt_info1.Show();
                    txt_info1.Text = Convert.ToString(emp._HoursWorked);
                    lbl_info2.Show();
                    lbl_info2.Text = _HourlyWage;
                    txt_info2.Show();
                    txt_info2.Text = Convert.ToString(emp._HourlyRate);
                    lbl_info3.Hide();
                    txt_info3.Hide();
                    break;

                case "Salary":
                    txt_empName.Text = emp._EmpName;
                    txt_empID.Text = Convert.ToString(emp._EmpID);
                    dbox_empType.Text = emp._EmpType;
                    lbl_info1.Text = _MonthlySal;
                    txt_info1.Text = Convert.ToString(emp._MonthlySalary);
                    lbl_info2.Hide();
                    txt_info2.Hide();
                    lbl_info3.Hide();
                    txt_info3.Hide();
                    break;

                case "Contract":
                    txt_empName.Text = emp._EmpName;
                    txt_empID.Text = Convert.ToString(emp._EmpID);
                    dbox_empType.Text = emp._EmpType;
                    lbl_info1.Text = _ContractSal;
                    txt_info1.Text = Convert.ToString(emp._ContractSalary);
                    lbl_info2.Hide();
                    txt_info2.Hide();
                    lbl_info3.Hide();
                    txt_info3.Hide();
                    break;

                case "Sales":
                    txt_empName.Text = emp._EmpName;
                    txt_empID.Text = Convert.ToString(emp._EmpID);
                    dbox_empType.Text = emp._EmpType;
                    lbl_info1.Show();
                    lbl_info1.Text = _MonthlySal;
                    txt_info1.Show();
                    txt_info1.Text = Convert.ToString(emp._MonthlySalary);
                    txt_info2.Show();
                    lbl_info2.Show();
                    lbl_info2.Text = _CommissionSales;
                    txt_info2.Text = Convert.ToString(emp._ComSales);
                    lbl_info3.Show();
                    txt_info3.Show();
                    lbl_info3.Text = _GrossSal;
                    txt_info3.Text = Convert.ToString(emp._MonthlySalary);
                    break;

                default:

                    MessageBox.Show(_error);

                    break;
            }

        }


        /// <summary>
        /// Purpose: to clear the form when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            clear();
        }

        /// <summary>
        /// Purpose: resets all the values of the form
        /// </summary>
        private void clear()
        {
            emp = blank;

            lbl_info1.Text = _lbl1;
            lbl_info2.Text = _lbl2;
            lbl_info3.Text = _lbl3;
            
            txt_info1.Text = Convert.ToString(0);
            txt_info2.Text = Convert.ToString(0);
            txt_info3.Text = Convert.ToString(0);

            lbl_info1.Show();
            lbl_info2.Show();
            lbl_info3.Show();
            txt_info1.Show();
            txt_info2.Show();
            txt_info3.Show();

        }

        /// <summary>
        /// Purpose: to initialize the helper function when the button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddEmployee_Click(object sender, EventArgs e)
        {

            AddEmployee(dbox_empType.Text);
        }

        /// <summary>
        /// Purpose: helper function to convert form data to an employee and place in an array
        /// </summary>
        /// <param name="etype"></param>
        private void AddEmployee(string etype)
        {
                
                switch (etype)
                {    
                    case "Hourly":

                        userData[_UserIndex] = new Hourly();
                        userData[_UserIndex]._EmpName = txt_empName.Text;
                        userData[_UserIndex]._EmpType = dbox_empType.Text;
                        userData[_UserIndex]._EmpID = Convert.ToInt32(txt_empID.Text);
                        userData[_UserIndex]._HoursWorked = Convert.ToDouble(txt_info1.Text);
                        userData[_UserIndex]._HourlyRate = Convert.ToDecimal(txt_info2.Text);
                        emp = userData[_UserIndex];
        
                        _UserIndex++;
                        MessageBox.Show("An Employee has been added");
                        break;

                    case "Salary":

                        userData[_UserIndex] = new Salary();
                        userData[_UserIndex]._EmpName = txt_empName.Text;
                        userData[_UserIndex]._EmpType = dbox_empType.Text;
                        userData[_UserIndex]._EmpID = Convert.ToInt32(txt_empID.Text);
                        userData[_UserIndex]._MonthlySalary = Convert.ToDecimal(txt_info1.Text);
                        emp = userData[_UserIndex];

                        _UserIndex++;
                        MessageBox.Show("An Employee has been added");
                        break;

                    case "Contract":

                        userData[_UserIndex] = new Contract();
                        userData[_UserIndex]._EmpName = txt_empName.Text;
                        userData[_UserIndex]._EmpType = dbox_empType.Text;
                        userData[_UserIndex]._EmpID = Convert.ToInt32(txt_empID.Text);
                        userData[_UserIndex]._ContractSalary  = Convert.ToDecimal(txt_info1.Text);
                        emp = userData[_UserIndex];

                        _UserIndex++;
                        MessageBox.Show("An Employee has been added");
                        break;

                
                    case "Sales":

                        userData[_UserIndex] = new Sales();
                        userData[_UserIndex]._EmpName = txt_empName.Text;
                        userData[_UserIndex]._EmpType = dbox_empType.Text;
                        userData[_UserIndex]._EmpID = Convert.ToInt32(txt_empID.Text);
                        userData[_UserIndex]._MonthlySalary = Convert.ToDecimal(txt_info1.Text);
                        userData[_UserIndex]._ComSales = Convert.ToDecimal(txt_info2.Text);
                        userData[_UserIndex]._GrossSales = Convert.ToDecimal(txt_info3.Text);
                        emp = userData[_UserIndex];

                        _UserIndex++;
                        MessageBox.Show("An Employee has been added");
                        break;
                    
                    default:

                        MessageBox.Show(_AddError);

                        break;

                }
        }

        /// <summary>
        /// Purpose: to call the helper function to load the right form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbox_empType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            formLoad(dbox_empType.Text);
            
        }
    }
}
