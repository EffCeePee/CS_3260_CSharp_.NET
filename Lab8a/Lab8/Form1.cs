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
    [Serializable]
    public partial class Form_Employee : Form
    {
        //------------------- Constants--------------------------
        const int SIZE = 10;

        //--------------New Instances----------------------
        Employee blank = new Hourly();
        Employee test = new Hourly();
        Employee _Hourly = new Hourly();
        Employee _Salary = new Salary();
        Employee _Sales = new Sales();
        Employee _Contract = new Contract();
        
        Business_Rules busRule;

          

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
        string _empIDError = "Please enter a valid employee ID";
        string _OpenAFile = "Please open or create a new employee file";
        //string _idError = "The employee ID already exists";
               

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
            MessageBox.Show(_OpenAFile);
            busRule = Business_Rules.Rules;
            busRule.openFile();
            txt_empFName.Text = blank._FirstName;
            txt_empLName.Text = blank._LastName;
            txt_empID.Text = Convert.ToString(blank._EmpID);
            dbox_empType.Text = Convert.ToString(blank._EmpType);
            txt_info1.Text = Convert.ToString(blank._HourlyRate);
            txt_info2.Text = Convert.ToString(blank._HoursWorked);
            txt_info3.Text = Convert.ToString(blank._MonthlySalary);
            busRule.startup();
            
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

                    txt_empFName.Text = test._FirstName;
                    txt_empLName.Text = test._LastName;
                    txt_empID.Text = Convert.ToString(test._EmpID);
                    dbox_empType.Text = Convert.ToString(ETYPE.Hourly);
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
                    _chBoxBenefits.Checked = test._EmpBenefits;
                    _chBoxCommission.Checked = test._EmpCommission;
                    _chBoxOvertime.Checked = test._EmpOvertime;
                    _chBoxEDUBenefits.Checked = test._EmpBenefits;
                    break;

                case ETYPE.Salary:
                    txt_empFName.Text = test._FirstName;
                    txt_empLName.Text = test._LastName;
                    txt_empID.Text = Convert.ToString(test._EmpID);
                    dbox_empType.Text = Convert.ToString(ETYPE.Salary);
                    lbl_info1.Text = _MonthlySal;
                    txt_info1.Text = Convert.ToString(test._MonthlySalary);
                    lbl_info2.Hide();
                    txt_info2.Hide();
                    lbl_info3.Hide();
                    txt_info3.Hide();
                    _chBoxBenefits.Checked = test._EmpBenefits;
                    _chBoxCommission.Checked = test._EmpCommission;
                    _chBoxOvertime.Checked = test._EmpOvertime;
                    _chBoxEDUBenefits.Checked = test._EmpBenefits;                 
                    break;

                case ETYPE.Contract:
                    txt_empFName.Text = test._FirstName;
                    txt_empLName.Text = test._LastName;
                    txt_empID.Text = Convert.ToString(test._EmpID);
                    dbox_empType.Text = Convert.ToString(ETYPE.Contract);
                    lbl_info1.Text = _ContractSal;
                    txt_info1.Text = Convert.ToString(test._ContractSalary);
                    lbl_info2.Hide();
                    txt_info2.Hide();
                    lbl_info3.Hide();
                    txt_info3.Hide();
                    _chBoxBenefits.Checked = test._EmpBenefits;
                    _chBoxCommission.Checked = test._EmpCommission;
                    _chBoxOvertime.Checked = test._EmpOvertime;
                    _chBoxEDUBenefits.Checked = test._EmpBenefits;
                    break;

                case ETYPE.Sales:
                    txt_empFName.Text = test._FirstName;
                    txt_empLName.Text = test._LastName;
                    txt_empID.Text = Convert.ToString(test._EmpID);
                    dbox_empType.Text = Convert.ToString(ETYPE.Sales);
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
                    _chBoxBenefits.Checked = test._EmpBenefits;
                    _chBoxCommission.Checked = test._EmpCommission;
                    _chBoxOvertime.Checked = test._EmpOvertime;
                    _chBoxEDUBenefits.Checked = test._EmpBenefits;

                    break;

                case ETYPE.None:
                    txt_empFName.Text = test._FirstName;
                    txt_empLName.Text = test._LastName;
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
                    _chBoxBenefits.Checked = false;
                    _chBoxCommission.Checked = false;
                    _chBoxOvertime.Checked = false;
                    _chBoxEDUBenefits.Checked = false;
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


             ETYPE newEmp;
             if (dbox_empType.Text == null | dbox_empType.Text == "")
             {
                 MessageBox.Show(_error);
                 newEmp = ETYPE.None;
             }

             if(busRule.isInDic(Convert.ToUInt32(txt_empID.Text)))
             {
                 MessageBox.Show(_empIDError);
             }
             else
             {
                newEmp = (ETYPE)Enum.Parse(typeof(ETYPE), dbox_empType.Text);
             


            // add employee switch case
                switch (newEmp)
                {
                    case ETYPE.Hourly:

                        Business_Rules.Rules.addEmpHourly(Convert.ToUInt32(txt_empID.Text), ETYPE.Hourly, txt_empFName.Text, txt_empLName.Text, Convert.ToDecimal(txt_info2.Text), Convert.ToDouble(txt_info1.Text), true, false, false, true);
                            _message = _success;
                        
                        MessageBox.Show(_message);
                        break;

                    case ETYPE.Salary:


                        Business_Rules.Rules.addEmpSalary(Convert.ToUInt32(txt_empID.Text), ETYPE.Salary, txt_empFName.Text,  txt_empLName.Text, Convert.ToDecimal(txt_info1.Text), false, true, false, true);
                        _message = _success;
                        MessageBox.Show(_message);

                        break;

                    case ETYPE.Contract:


                        Business_Rules.Rules.addEmpContract(Convert.ToUInt32(txt_empID.Text), ETYPE.Contract, txt_empFName.Text, txt_empLName.Text, Convert.ToDecimal(txt_info1.Text), false, false, false, false);
                        _message = _success;
                        MessageBox.Show(_message);

                        break;

                    case ETYPE.Sales:

                        Business_Rules.Rules.addEmpSales(Convert.ToUInt32(txt_empID.Text), ETYPE.Sales, txt_empFName.Text, txt_empLName.Text, Convert.ToDecimal(txt_info2.Text), Convert.ToDecimal(txt_info1.Text), Convert.ToDecimal(txt_info3.Text), false, true, true, true);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void _BtnSave_Click(object sender, EventArgs e)
        {
            busRule.endProgram();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            busRule.openFile();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            busRule.newFile();
        }

        private void tab_employee_Click(object sender, EventArgs e)
        {

        }



    } // end form
} // end namespace 
