// Project Prolog
// Name: Dennis A. Fairclough
// CS3260 Section 001
// Project: EmployeeDB
// Date: 1/21/2014
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeDB_01
{
    public enum ETYPE { SAL=1, HRLY, SLS, CNCT, NONE, BAD }

    /// <summary>
    /// class FrmMain for the Form Displayed
    /// </summary>
    public partial class FrmMain : Form
    {
        //-------------------------------------- const strings ------------------------------
        public const string EMPID = "1000";
        public const string EMPNAME = "Dennis A. Fairclough";
        public const string LABEL0 = "Value 0:";
        public const string LABEL1 = "Value 1:";
        public const string LABEL2 = "Value 2:";
        public const string LABELN = "None:";
        public const string MSG0 = "---------------------- Display --------------------";
        public const string DZERO = "0.0";
        public const string IZERO = "0";
        public const string CRLF = "\r\n";
        public const string SALEMP = "Salary";
        public const string SALESEMP = "Sales";
        public const string CONTCTEMP = "Contract";        
        public const string HRMP = "Hourly";
        public const string FMTI = "{0:D}";
        public const string FMTF = "{0:F2}";
        public const string FMTC = "{0:C}";
        public const string FMTP = "{0:P}";
        public const string FMTS = "{0}";
        public const string SALY = "Salary:";
        public const string HRLYRATE = "Hourly Rate:";
        public const string HRSWORK = "Hours Worked:";
        public const string COMMSALES = "Commission on Sales:";
        public const string GROSSALES = "Gross Sales:";
        public const string MSG_IVT = "Invalid Employee Type!";
        public const string MSG_IT = "Invalid Type";
        public const string EMPTY = "";
        //--------------------------------------- class Level Variables -------------------------
        private int _count;
        private TestData _tdata;
        private Employee _emp;
        private List<Employee> _eList;
        private string _message;
        private bool _start;
        //-------------------------------- GUI Constructor --------------------------------------
        /// <summary>
        /// Purpose: Constructor to intialize the FrmMain and Controls
        /// </summary>
        public FrmMain()
        {
            InitializeComponent();
        }
        //-------------------------------- GUI Event Handlers --------------------------------------
        /// <summary>
        /// Purpose: To create and initialize objects and fields in FrmMain
        /// </summary>
        /// <param name="sender">FrmMain as it loads</param>
        /// <param name="e">EventArgs</param>
        private void FrmMain_Load(object sender, EventArgs e)
        {
            _count = 0;
            TxtEmpID.Text = EMPID;
            TxtName.Text = EMPNAME;
            TxtValue0.Text = DZERO;
            TxtValue1.Text = DZERO;
            TxtValue2.Text = DZERO;
            TxtEmpType.Text = EMPTY + ETYPE.NONE;
            _tdata = new TestData();
            _eList = _tdata.GEmp;
            _emp = null;
            _message = null;
            _start = true;
        }
        /// <summary>
        /// Purpose: To close FrmMain and Exit the application
        /// </summary>
        /// <param name="sender">BtnExit</param>
        /// <param name="e">Event Args</param>
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// Purpose: Clear and reset the FrmMain, initialize controls and _count = 0 for _eList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearGUI();
           
        }
        /// <summary>
        /// Purpose: Display the various Employee Objects in the _tdata Object
        /// </summary>
        /// <param name="sender">BtnTestData</param>
        /// <param name="e">EventArgs</param>
        private void BtnTestData_Click(object sender, EventArgs e)
        {
            DisplayTextEmployee();
        }
        /// <summary>
        /// Purpose: Create an Employee Object and populate it with values in the TextBoxes
        /// </summary>
        /// <param name="sender">BtnAddEmployee</param>
        /// <param name="e">EventArgs Object</param>
        private void BtnAddEmployee_Click(object sender, EventArgs e)
        {
            CreateNewEmployee();
        }
        //-------------------------------- GUI Support Methods --------------------------------------
        /// <summary>
        /// Purpose: To clear GUI Interface
        /// </summary>
        public void ClearGUI()
        {
            _count = 0;
            RBtnSalary.Checked = false;
            RBtnHourly.Checked = false;
            RBtnSales.Checked = false;
            RBtnContract.Checked = false;
            TxtEmpID.Text = EMPID;
            TxtName.Text = EMPNAME;
            TxtEmpType.Text = EMPTY + ETYPE.NONE;
            LblValue0.Text = LABEL0;
            TxtValue0.Text = DZERO;
            LblValue0.Show();
            TxtValue0.Show();
            LblValue1.Text = LABEL1;
            TxtValue1.Text = DZERO;
            LblValue1.Show();
            TxtValue1.Show();
            LblValue2.Text = LABEL2;
            TxtValue2.Text = DZERO;
            LblValue2.Show();
            TxtValue2.Show();
            RTxtDisplay.Clear();
            RTxtDisplay.AppendText(MSG0);
        }
        /// <summary>
        /// Purpose: To Display A Test Data Object
        /// </summary>
        public void DisplayTextEmployee()
        {
            if (_count >= _eList.Count)
            {
                BtnClear_Click(BtnTestData, null);
                return;
            }
            RTxtDisplay.AppendText(CRLF);
            TxtEmpID.Text = "" + _eList[_count].EmpID;
            RTxtDisplay.AppendText(_eList[_count].EmpID + CRLF);
            TxtName.Text = _eList[_count].EmpName;
            RTxtDisplay.AppendText(_eList[_count].EmpName + CRLF);
            TxtEmpType.Text = "" + _eList[_count].EmpType;
            RTxtDisplay.AppendText(_eList[_count].EmpType + CRLF);
            SetGUIState(_eList[_count].EmpType);
        }
        /// <summary>
        /// Purpose: To set and display the GUI Interface to the proper Employee Type
        /// </summary>
        /// <param name="type">ETYPE - Sal, SLS, HRLY, CNCT, NONE, BAD</param>
        public void SetGUIState(ETYPE type)
        {
            switch (type)
            {
                case ETYPE.SAL:
                    RBtnSalary.Checked = true;
                    LblValue0.Text = SALY;
                    TxtValue0.Text = string.Format(FMTC, _eList[_count].MonthlySalary);
                    RTxtDisplay.AppendText(TxtValue0.Text + CRLF);
                    LblValue1.Hide();
                    TxtValue1.Hide();
                    LblValue2.Hide();
                    TxtValue2.Hide();
                    _count++;
                    break;
                case ETYPE.HRLY:
                    RBtnHourly.Checked = true;
                    LblValue0.Text = HRLYRATE;
                    TxtValue0.Text = string.Format(FMTC, _eList[_count].HourlyRate);
                    RTxtDisplay.AppendText(TxtValue0.Text + CRLF);
                    LblValue1.Text = HRSWORK;
                    LblValue1.Show();
                    TxtValue1.Text = string.Format(FMTF, _eList[_count].HoursWorked);
                    RTxtDisplay.AppendText(TxtValue1.Text + CRLF);
                    TxtValue1.Show();
                    LblValue2.Hide();
                    TxtValue2.Hide();
                    _count++;
                    break;
                case ETYPE.SLS:
                    RBtnSales.Checked = true;
                    LblValue0.Text = SALEMP;
                    TxtValue0.Text = string.Format(FMTC, _eList[_count].MonthlySalary);
                    LblValue1.Text = COMMSALES;
                    LblValue1.Show();
                    TxtValue1.Text = string.Format(FMTP, _eList[_count].ComSales);
                    RTxtDisplay.AppendText(TxtValue1.Text + CRLF);
                    TxtValue1.Show();
                    LblValue2.Text = GROSSALES;
                    TxtValue2.Text = string.Format(FMTC, _eList[_count].GrossSales);
                    LblValue2.Show();
                    RTxtDisplay.AppendText(TxtValue2.Text + CRLF);
                    TxtValue2.Show();
                    _count++;
                    break;
                case ETYPE.CNCT:
                    RBtnContract.Checked = true;
                    LblValue0.Text = "Salary:";
                    TxtValue0.Text = string.Format(FMTC, _eList[_count].ContractSalary);
                    RTxtDisplay.AppendText(TxtValue0.Text + CRLF);
                    LblValue1.Hide();
                    TxtValue1.Hide();
                    LblValue2.Hide();
                    TxtValue2.Hide();
                    _count++;
                    break;
                case ETYPE.NONE:
                    RBtnSalary.Checked = false;
                    RBtnHourly.Checked = false;
                    RBtnSales.Checked = false;
                    RBtnContract.Checked = false;
                    TxtEmpID.Text = "" + _eList[_count].EmpID;
                    TxtName.Text = _eList[_count].EmpName;
                    TxtValue0.Text = string.Format(FMTC, _eList[_count].MonthlySalary);
                    LblValue1.Hide();
                    TxtValue1.Hide();
                    LblValue2.Hide();
                    TxtValue2.Hide();
                    _count++;
                    //goto case ETYPE.SAL; 
                    break;
                default:
                    RBtnSalary.Checked = false;
                    RBtnHourly.Checked = false;
                    RBtnSales.Checked = false;
                    RBtnContract.Checked = false;
                    MessageBox.Show(MSG_IVT, MSG_IT, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    TxtEmpID.Clear();
                    TxtName.Clear();
                    TxtEmpType.Text = "" + _eList[_count].EmpType;
                    LblValue0.Text = LABELN;
                    TxtValue0.Clear();
                    LblValue1.Hide();
                    TxtValue1.Hide();
                    LblValue2.Hide();
                    TxtValue2.Hide();
                    _count++;
                    //goto case ETYPE.SAL;
                    break;
            }
        }
        /// <summary>
        /// Purpose: Create a new Employee Object of Salary, Hourly, Sales, Contract add it to List<Employee>_eList</Employee>
        /// </summary>
        public void CreateNewEmployee()
        {
            _emp = null;
            if(RBtnSalary.Checked)
            {
                _emp = new Salary(TxtEmpID.Text, TxtName.Text, TxtValue0.Text);
                DisplayEmployeeObject(_emp);
            }
            else if(RBtnHourly.Checked)
                {
                    _emp = new Hourly(TxtEmpID.Text, TxtName.Text, TxtValue0.Text, TxtValue1.Text);
                    DisplayEmployeeObject(_emp);
                }
                else if(RBtnSales.Checked)
                    {
                        _emp = new Sales(TxtEmpID.Text, TxtName.Text, TxtValue0.Text, TxtValue1.Text, TxtValue2.Text);
                        DisplayEmployeeObject(_emp);
                    }
                    else if(RBtnContract.Checked)
                        {
                            _emp = new Contract(TxtEmpID.Text, TxtName.Text, TxtValue0.Text);
                            DisplayEmployeeObject(_emp);
                        }
            _eList.Add(_emp);
        }
        /// <summary>
        /// Purpose: Displays an employees data values
        /// </summary>
        /// <param name="emp">Employee Object</param>
        private void DisplayEmployeeObject(Employee emp)
        {
            RTxtDisplay.AppendText(CRLF);
            RTxtDisplay.AppendText(emp.EmpID + CRLF);
            RTxtDisplay.AppendText(emp.EmpName + CRLF);
            RTxtDisplay.AppendText(emp.EmpType + CRLF);
            switch(emp.EmpType)
            {
                case ETYPE.SAL:
                    RTxtDisplay.AppendText(emp.MonthlySalary + CRLF);
                    break;
                case ETYPE.HRLY:
                    RTxtDisplay.AppendText(emp.HourlyRate + CRLF);
                    RTxtDisplay.AppendText(emp.HoursWorked + CRLF);
                    break;
                case ETYPE.SLS:
                    RTxtDisplay.AppendText(emp.MonthlySalary + CRLF);
                    RTxtDisplay.AppendText(emp.ComSales + CRLF);
                    RTxtDisplay.AppendText(emp.GrossSales + CRLF);
                    break;
                case ETYPE.CNCT:
                    RTxtDisplay.AppendText(emp.HoursWorked + CRLF);
                    break;
            }
        }

        private void BtnCalcSalary_Click(object sender, EventArgs e)
        {
            if (_start == true)
            {
                _count = 0;
                _start = false;
            }
            _emp = _eList[_count++];
            if (_emp.EmpType == ETYPE.NONE || _emp.EmpType == ETYPE.BAD)
                _count = 0;
            _message = string.Format("{1} Salary - {0:C}", _emp.CalcPay(), _emp.EmpName);
            MessageBox.Show(_message,"Calculate Pay",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }//End class FrmMain
}//End namespace EmployeeDB_01
