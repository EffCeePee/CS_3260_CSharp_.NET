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
using System.Windows.Forms;
using employee;


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
        Employee blank = new Hourly();
        Employee test = new Hourly();

        Business_Rules frank;

          

        //------------------- Variables--------------------------
        string _error = "You're trying to load an empty employee object";
        string _HrsWorked = "Hours Worked:";
        string _HourlyWage = "Hourly Wage:";
        string _MonthlySal = "Monthly Salary:";
        string _GrossSal = "Gross Sales:";
        string _ContractSal = "Contract Salary:";
        string _CommissionSales = "Commission Sales:";
        string _none = "None";
        string _blank = "";
        string _lbl1 = "Label 1:";
        string _lbl2 = "Label 2:";
        string _lbl3 = "Lable 3:";
        string _success = "Success, an Employee was added";
        string _message = "Blank Message";
        string _nameError = "Please enter a valid name";
        string _empIDError = "Please enter a valid employee ID";
        string _wageError = "Please enter the wage";
        string _hrsWorkedError = "Please enter the number of hours worked";
        string _salaryError = "Please enter a valid salary";
        string _idError = "The employee ID already exists";

        uint i = 9;
        
        
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
            frank = Business_Rules.Rules;
            txt_empName.Text = blank._EmpName;
            txt_empID.Text = Convert.ToString(blank._EmpID);
            dbox_empType.Text = Convert.ToString(blank._EmpType);
            txt_info1.Text = Convert.ToString(blank._HourlyRate);
            txt_info2.Text = Convert.ToString(blank._HoursWorked);
            txt_info3.Text = Convert.ToString(blank._MonthlySalary);
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
           
            i = Business_Rules.Rules.testEmpNums(i);
            test = Business_Rules.Rules.getEmp(i);
            formLoad(test._EmpType); 
        }
    
        /// <summary>
        /// Purpose: sets the form with the proper lables and boxes based on type
        /// </summary>
        /// <param name="type"></param>
        public void formLoad(ETYPE emp)
        {
            switch (emp)
            {
                case ETYPE.Hourly:

                    txt_empName.Text = test._EmpName;
                    txt_empID.Text = Convert.ToString(test._EmpID);
                    dbox_empType.Text = Convert.ToString(test._EmpType);
                    lbl_info1.Show();
                    lbl_info1.Text = _HrsWorked;
                    txt_info1.Show();
                    txt_info1.Text = Convert.ToString(test._HoursWorked);
                    lbl_info2.Show();
                    lbl_info2.Text = _HourlyWage;
                    txt_info2.Show();
                    txt_info2.Text = Convert.ToString(test._HourlyRate);
                    lbl_info3.Hide();
                    txt_info3.Hide();
                    break;

                case ETYPE.Salary:
                    txt_empName.Text = test._EmpName;
                    txt_empID.Text = Convert.ToString(test._EmpID);
                    dbox_empType.Text = Convert.ToString(test._EmpType);
                    lbl_info1.Text = _MonthlySal;
                    txt_info1.Text = Convert.ToString(test._MonthlySalary);
                    lbl_info2.Hide();
                    txt_info2.Hide();
                    lbl_info3.Hide();
                    txt_info3.Hide();
                    break;

                case ETYPE.Contract:
                    txt_empName.Text = test._EmpName;
                    txt_empID.Text = Convert.ToString(test._EmpID);
                    dbox_empType.Text = Convert.ToString(test._EmpType);
                    lbl_info1.Text = _ContractSal;
                    txt_info1.Text = Convert.ToString(test._ContractSalary);
                    lbl_info2.Hide();
                    txt_info2.Hide();
                    lbl_info3.Hide();
                    txt_info3.Hide();
                    break;

                case ETYPE.Sales:
                    txt_empName.Text = test._EmpName;
                    txt_empID.Text = Convert.ToString(test._EmpID);
                    dbox_empType.Text = Convert.ToString(test._EmpType);
                    lbl_info1.Show();
                    lbl_info1.Text = _MonthlySal;
                    txt_info1.Show();
                    txt_info1.Text = Convert.ToString(test._MonthlySalary);
                    txt_info2.Show();
                    lbl_info2.Show();
                    lbl_info2.Text = _CommissionSales;
                    txt_info2.Text = Convert.ToString(test._ComSales);
                    lbl_info3.Show();
                    txt_info3.Show();
                    lbl_info3.Text = _GrossSal;
                    txt_info3.Text = Convert.ToString(test._MonthlySalary);
                    break;

                case ETYPE.None:
                    txt_empName.Text = _blank;
                    txt_empID.Text = _blank;
                    dbox_empType.Text = _none;
                    lbl_info1.Show();
                    lbl_info1.Text = _lbl1;
                    txt_info1.Show();
                    txt_info1.Text = _blank;
                    txt_info2.Show();
                    lbl_info2.Show();
                    lbl_info2.Text = _lbl2;
                    txt_info2.Text = _blank;
                    lbl_info3.Show();
                    txt_info3.Show();
                    lbl_info3.Text = _lbl3;
                    txt_info3.Text = _blank;
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
            test = blank;
            formLoad(ETYPE.None);
        }

        /// <summary>
        /// purpose: to add an employee to the array
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_AddEmployee_Click(object sender, EventArgs e)
        {
            //if (Business_Rules.Rules.isInDic(Convert.ToUInt32(txt_empID.Text)))
            //{
            //    test = Business_Rules.Rules.getEmp(Convert.ToUInt32(txt_empID.Text));
            //    formLoad(test._EmpType);
            //}
            //else
            //{
            //    MessageBox.Show(_empIDError);
            //}


             ETYPE newEmp;
             if (dbox_empType.Text == null | dbox_empType.Text == "")
             {
                 MessageBox.Show(_error);
                 newEmp = ETYPE.None;
                 
             }
             else if (Business_Rules.Rules.isInDic(Convert.ToUInt32(txt_empID.Text)))
             {
                 MessageBox.Show(_idError);
             }
             else
             {
                newEmp = (ETYPE)Enum.Parse(typeof(ETYPE), dbox_empType.Text);
             


            // add employee switch case
                switch (newEmp)
                {
                    case ETYPE.Hourly:


                        if (txt_empName.Text == "")
                        {
                            _message = _nameError;
                        }
                        else if (txt_empID.Text == "")
                        {
                            _message = _empIDError;
                        }
                        else if (txt_info1.Text == "")
                        {
                            _message = _wageError;
                        }
                        else if (txt_info2.Text == "")
                        {
                            _message = _hrsWorkedError;
                        }
                        else
                        {

                            Business_Rules.Rules.addEmpHourly(Convert.ToUInt32(txt_empID.Text), ETYPE.Hourly, txt_empName.Text, Convert.ToDecimal(txt_info2.Text), Convert.ToDouble(txt_info1.Text));
                            _message = _success;

                        }
                        MessageBox.Show(_message);
                        break;

                    case ETYPE.Salary:

                        if (txt_empName.Text == "")
                        {
                            _message = _nameError;
                        }
                        else if (txt_empID.Text == "")
                        {
                            _message = _empIDError;
                        }
                        else if (txt_info1.Text == "")
                        {
                            _message = _salaryError;
                        }


                        Business_Rules.Rules.addEmpSalary(Convert.ToUInt32(txt_empID.Text), ETYPE.Salary, txt_empName.Text, Convert.ToDecimal(txt_info1.Text));
                        _message = _success;
                        MessageBox.Show(_message);

                        break;

                    case ETYPE.Contract:

                        if (txt_empName.Text == "")
                        {
                            _message = _nameError;
                        }
                        else if (txt_empID.Text == "")
                        {
                            _message = _empIDError;
                        }
                        else if (txt_info1.Text == "")
                        {
                            _message = _salaryError;
                        }


                        Business_Rules.Rules.addEmpContract(Convert.ToUInt32(txt_empID.Text), ETYPE.Contract, txt_empName.Text, Convert.ToDecimal(txt_info1.Text));
                        _message = _success;
                        MessageBox.Show(_message);

                        break;

                    case ETYPE.Sales:

                        if (txt_empName.Text == "")
                        {
                            _message = _nameError;
                        }
                        else if (txt_empID.Text == "")
                        {
                            _message = _empIDError;
                        }
                        else if (txt_info1.Text == "")
                        {
                            _message = _salaryError;
                        }
                        else if (txt_info2.Text == "")
                        {
                            _message = _salaryError;
                        }
                        else if (txt_info3.Text == "")
                        {
                            _message = _salaryError;
                        }
                        Business_Rules.Rules.addEmpSales(Convert.ToUInt32(txt_empID.Text), ETYPE.Sales, txt_empName.Text, Convert.ToDecimal(txt_info2.Text), Convert.ToDecimal(txt_info1.Text), Convert.ToDecimal(txt_info3.Text));
                        _message = _success;
                        MessageBox.Show(_message);
                        break;


                    default:

                        MessageBox.Show(_error);

                        break;
                }
            }
        }

        /// <summary>
        /// purpose: to change the form to the right style per employee type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dbox_empType_SelectedIndexChanged(object sender, EventArgs e)
        {

            
            ETYPE type = (ETYPE)Enum.Parse(typeof(ETYPE), dbox_empType.Text);

            formLoad(type);
        }

        /// <summary>
        /// Purpose:  to search the employee dicationary and load the right emp
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _btnSearch_Click(object sender, EventArgs e)
        {
            if (Business_Rules.Rules.isInDic(Convert.ToUInt32(txt_empID.Text)))
            {
                test = Business_Rules.Rules.getEmp(Convert.ToUInt32(txt_empID.Text));
                formLoad(test._EmpType);
            }
            else
            {
                MessageBox.Show(_empIDError);   
            }

        }

    } // end form
} // end namespace 
