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
    [Serializable]
    public enum ETYPE { Hourly = 1, Salary, Sales, Contract, None }

    /// <summary>
    /// Base cllass for our employees to be created
    /// This will include base level variables and virtual functions for inheretance
    /// </summary>
    [Serializable]
    abstract public class Employee : object
    {

        /// <summary>
        /// Variables with automatic getters and setters
        /// </summary>
        public uint _EmpID  { get; set; }
        public ETYPE _EmpType { get; set; }
        public string _EmpName { get; set; }
        public bool _EmpOvertime { get; set; }
        public bool _EmpBenefits { get; set; }
        public bool _EmpCommission { get; set; }
        public bool _EmpEducationalBenefits { get; set; }

        /// <summary>
        /// default constructor
        /// </summary>
        public Employee() 
        {
            _EmpID = 0000;
            _EmpName = "New Employee";
            _EmpType = ETYPE.None;
            _EmpOvertime = false;
            _EmpBenefits = false;
            _EmpCommission = false;
            _EmpEducationalBenefits = false;
        }

        /// <summary>
        /// parameterized constructor
        /// </summary>
        public Employee(uint i, ETYPE et, string en)
        {
            _EmpID = i; 
            _EmpType = et;
            _EmpName = en;
            _EmpOvertime = false;
            _EmpBenefits = false;
            _EmpCommission = false;
            _EmpEducationalBenefits = false;
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
    [Serializable]
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
            _EmpOvertime = true;
            _EmpBenefits = false;
            _EmpCommission = false;
            _EmpEducationalBenefits = true;
        }


        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="i"></param>
        /// <param name="et"></param>
        /// <param name="en"></param>
        /// <param name="hr"></param>
        /// <param name="hw"></param>
        public Hourly(uint i, ETYPE et, string en, decimal hr, double hw, bool ot, bool ben, bool comm, bool edBen)
        {
            _EmpID = i; 
            _EmpType = et;
            _EmpName = en;
            _HourlyRate = hr;
            _HoursWorked = hw;
            _EmpOvertime = ot;
            _EmpBenefits = ben;
            _EmpCommission = comm;
            _EmpEducationalBenefits = edBen;
        }

    }

    /// <summary>
    /// sealed Contract class inheriting from employee
    /// </summary>
    [Serializable]
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
            _EmpOvertime = false;
            _EmpBenefits = false;
            _EmpCommission = false;
            _EmpEducationalBenefits = false;
        }


        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="i"></param>
        /// <param name="et"></param>
        /// <param name="en"></param>
        /// <param name="cs"></param>
        public Contract(uint i, ETYPE et, string en, decimal cs, bool ot, bool ben, bool comm, bool edBen)
        {
            _EmpID = i; 
            _EmpType = et;
            _EmpName = en;
            _ContractSalary = cs;
            _EmpOvertime = ot;
            _EmpBenefits = ben;
            _EmpCommission = comm;
            _EmpEducationalBenefits = edBen;
        }
    }

    /// <summary>
    /// Purpose:  Salary class that inherits from employee class
    /// </summary>
    [Serializable]
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
            _EmpOvertime = false;
            _EmpBenefits = true;
            _EmpCommission = false;
            _EmpEducationalBenefits = true;
        }

        /// <summary>
        /// parameterized constructor
        /// </summary>
        /// <param name="i"></param>
        /// <param name="et"></param>
        /// <param name="en"></param>
        /// <param name="ms"></param>
        public Salary(uint i, ETYPE et, string en, decimal ms, bool ot, bool ben, bool comm, bool edBen)
        {
            _EmpID = i; 
            _EmpType = et;
            _EmpName = en;
            _MonthlySalary = ms;
            _EmpOvertime = ot;
            _EmpBenefits = ben;
            _EmpCommission = comm;
            _EmpEducationalBenefits = edBen;
        }

    }

    /// <summary>
    /// Purpose:  Sales class that inherits from salary class
    /// </summary>
    [Serializable]
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
            _EmpOvertime = false;
            _EmpBenefits = true;
            _EmpCommission = true;
            _EmpEducationalBenefits = false;
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
        public Sales(uint i, ETYPE et, string en, decimal cs, decimal gs, decimal ms, bool ot, bool ben, bool comm, bool edBen)
        {
            _EmpID = i; 
            _EmpType = et;
            _EmpName = en;
            _ComSales = cs;
            _GrossSales = gs;
            _MonthlySalary = ms;
            _EmpOvertime = ot;
            _EmpBenefits = ben;
            _EmpCommission = comm;
            _EmpEducationalBenefits = edBen;
        }

    }

    

}// close namespace
