// Project Prologue
// Franklin Colton Parry
// Course: CS 3260
// File: employee_classes.cs
// Date: 1/27/2014

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

// using statement
using System;

// namespace declaration
namespace employee
{
    public enum ETYPE { Hourly = 1, Salary, Sales, Contract, None }

    /// <summary>
    /// Base cllass for our employees to be created
    /// This will include base level variables and virtual functions for inheretance
    /// </summary>
    abstract class Employee : object
    {

        /// <summary>
        /// Variables with automatic getters and setters
        /// </summary>
        public int _EmpID  { get; set; }
        public ETYPE _EmpType { get; set; }
        public string _EmpName { get; set; }

        /// <summary>
        /// default constructor
        /// </summary>
        public Employee() 
        {
            _EmpID = 0000;
            _EmpName = "New Employee";
            _EmpType = ETYPE.None;
        }

        /// <summary>
        /// parameterized constructor
        /// </summary>
        public Employee(int i, ETYPE et, string en)
        {
            _EmpID = i; 
            _EmpType = et;
            _EmpName = en;
        }

        /// <summary>
        /// Virtual Functions for later classes
        /// </summary>
        public virtual decimal _HourlyRate { get; set; }
        public virtual double _HoursWorked { get; set; }
        public virtual decimal _ContractSalary { get; set; }
        public virtual decimal _MonthlySalary { get; set; }
        public virtual decimal _ComSales { get; set; }
        public virtual decimal _GrossSales { get; set; }

        
    }

    /// <summary>
    /// Purpose:  Hourly class that inherits from employee class
    /// </summary>
    sealed class Hourly : Employee
    {
        /// <summary>
        /// override functions for virtual functions
        /// </summary>
        public override decimal _HourlyRate { get; set; }
        public override double _HoursWorked { get; set; }

        /// <summary>
        /// default constructor
        /// </summary>
        public Hourly() : base()
        {
            _HourlyRate = default(decimal);
            _HoursWorked = default(double);
        }


        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="i"></param>
        /// <param name="et"></param>
        /// <param name="en"></param>
        /// <param name="hr"></param>
        /// <param name="hw"></param>
        public Hourly(int i, ETYPE et, string en, decimal hr, double hw)
        {
            _EmpID = i; 
            _EmpType = et;
            _EmpName = en;
            _HourlyRate = hr;
            _HoursWorked = hw;
        }

    }

    /// <summary>
    /// sealed Contract class inheriting from employee
    /// </summary>
    sealed class Contract : Employee
    {
        /// <summary>
        /// override functions for virtual functions
        /// </summary>
        public override decimal _ContractSalary { get; set; }

        /// <summary>
        /// default constructor
        /// </summary>
        public Contract() : base()
        {
            _ContractSalary = default(decimal) ; 
        }


        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="i"></param>
        /// <param name="et"></param>
        /// <param name="en"></param>
        /// <param name="cs"></param>
        public Contract(int i, ETYPE et, string en, decimal cs)
        {
            _EmpID = i; 
            _EmpType = et;
            _EmpName = en;
            _ContractSalary = cs;
        }
    }

    /// <summary>
    /// Purpose:  Salary class that inherits from employee class
    /// </summary>
    class Salary : Employee
    {
                /// <summary>
        /// override functions for virtual functions
        /// </summary>
        public override decimal _MonthlySalary { get; set; }

        /// <summary>
        /// default constructor
        /// </summary>
        public Salary() : base()
        {
            _MonthlySalary = default(decimal);
        }

        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="i"></param>
        /// <param name="et"></param>
        /// <param name="en"></param>
        /// <param name="ms"></param>
        public Salary(int i, ETYPE et, string en, decimal ms)
        {
            _EmpID = i; 
            _EmpType = et;
            _EmpName = en;
            _MonthlySalary = ms;
        }

    }

    /// <summary>
    /// Purpose:  Sales class that inherits from salary class
    /// </summary>
    sealed class Sales : Salary
    {
        /// <summary>
        /// override functions for virtual functions
        /// </summary>
        public override decimal _ComSales { get; set; }
        public override decimal _GrossSales { get; set; }

        /// <summary>
        /// default constructor
        /// </summary>
        public Sales() : base()
        {
            _ComSales = default(decimal);
            _GrossSales = default(decimal);
        }

        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="i"></param>
        /// <param name="et"></param>
        /// <param name="en"></param>
        /// <param name="cs"></param>
        /// <param name="gs"></param>
        /// <param name="ms"></param>
        public Sales(int i, ETYPE et, string en, decimal cs, decimal gs, decimal ms)
        {
            _EmpID = i; 
            _EmpType = et;
            _EmpName = en;
            _ComSales = cs;
            _GrossSales = gs;
            _MonthlySalary = ms;
        }

    }

    sealed class Business_Rules
    {
        // singleton variables
        private static readonly Business_Rules rules = new Business_Rules();

        
        // employee class and inherited class test variables
        private Hourly hrly = new Hourly(10, ETYPE.Hourly, "Micky Mouse", 25.66M, 13.25);
        private Salary salry = new Salary(11, ETYPE.Salary, "Donald Duck", 40000.00M);
        private Sales sles = new Sales(12, ETYPE.Sales, "Princess Ariel", 10000.00M, 1000000.00M, 250000.00M);
        private Contract contrct = new Contract(13, ETYPE.Contract, "Walt Disney", 20000.00M);
        private Hourly none = new Hourly();

        // test data variables and array
        const int SIZE = 10;

        private Employee[] _empArray;

        // indexer variables
        private const int MIN_ID = 10;
        private const int MAX_INDEX = 4;
        string invalidNum = "Please give a valid employee number";
        private int i = 0;

        /// <summary>
        /// Purpose: default constructor
        /// </summary>
        private Business_Rules()
        {
            _empArray = new Employee[SIZE];
            _empArray[i] = hrly;
            i++;
            _empArray[i] = salry;
            i++;
            _empArray[i] = sles;
            i++;
            _empArray[i] = contrct;
        }

        public static Business_Rules Rules
        {
            get { return Business_Rules.rules; }
        } 


        /// <summary>
        /// purpose: indexer implementation
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public Employee this[int index]
        {
            get
            {

                if (index % MIN_ID >= 0 && index < MAX_INDEX)
                    return _empArray[index];
                else
                    throw new Exception(invalidNum);
            }

            set
            {
                index %= MIN_ID;
                if (index % MIN_ID >= 0 && index < MAX_INDEX)
                    value = _empArray[index];
                else
                    throw new Exception(invalidNum);

            }
        }      


        public Employee getEmp()
        
        {
            if (i < _empArray.Length && _empArray[i] != null)
            {
                i++;
                return _empArray[i-1];
            }
            else
            {
                i = 0;
                return _empArray[i];
            }
        }
        

        public void addEmpHourly(int i, ETYPE et, string en, decimal hr, double hw )
        {
           int x = i % SIZE;
            _empArray[x] = new Hourly(i, et, en, hr, hw);

        }
        
        public void addEmpSalary(int i, ETYPE et, string en, decimal ms)
        {
            int x = i % SIZE;
            _empArray[x] = new Salary(i, et, en, ms);

        }

        public void addEmpSales(int i, ETYPE et, string en, decimal cs, decimal gs, decimal ms)
        {
            int x = i % SIZE;
            _empArray[x] = new Sales(i, et, en,cs, gs, ms );

        }

        public void addEmpContract(int i, ETYPE et, string en, decimal cs)
        {
            int x = i % SIZE;
            _empArray[x] = new Contract(i, et, en, cs);

        }
 
    }// close class

}// close namespace
