using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDB_01
{
    /// <summary>
    /// Purpose: Employee abstract base class
    /// </summary>
    abstract class Employee : object 
    {
        //-------------------------------------- const Variables ---------------------------------
        public const uint EMPNUMBER = 1000;
        /// <summary>
        /// Purpose: Property for Employee ID
        /// </summary>
        //-------------------------------------- Member Properties ---------------------------------
        public uint EmpID { get; set; }
        /// <summary>
        /// Purpose: Property for Employees Full Name
        /// </summary>
        public string EmpName { get; set; }
        /// <summary>
        /// Purpose: Property for Employee Type - See ETYPE
        /// </summary>
        public ETYPE EmpType{ get; set; }
        //-------------------------------------- Constructors ---------------------------------
        /// <summary>
        /// Purpose: Default Constructor
        /// </summary>
        public Employee() : base()
        {
            EmpID = EMPNUMBER-1;
            EmpName = "none";
            EmpType = ETYPE.NONE;
            Console.WriteLine("Employee default Constructor");
        }
        /// <summary>
        /// Purpose: Parameterized Constructor
        /// </summary>
        /// <param name="eid">Employee ID</param>
        /// <param name="ename">Full Name</param>
        public Employee(uint eid, string ename)
        {
            EmpID = eid;
            EmpName = ename;
            EmpType = ETYPE.NONE;
            Console.WriteLine("Employee parameterized Constructor");
        }
        /// <summary>
        /// Purpose: Parameterized Constructor - With all string parameters
        /// </summary>
        /// <param name="eid"></param>
        /// <param name="ename"></param>
        public Employee(string eid, string ename) : base()
        {
            EmpID = uint.Parse(eid);
            EmpName = ename;
            EmpType = ETYPE.NONE;
            Console.WriteLine("Employee parameterized Constructor");
        }
        //-------------------------------------- virtual Member Properties ---------------------------------
        /// <summary>
        /// Purpose: All of the virtual Properties below are to provide Virtual Tables for the derived classes
        /// </summary>
        virtual public double HoursWorked { get; set; }
        virtual public decimal HourlyRate { get; set; }
        virtual public decimal MonthlySalary { get; set; }
        virtual public double ComSales { get; set; }
        virtual public decimal GrossSales { get; set; }
        virtual public decimal ContractSalary { get; set; }
        abstract public decimal CalcPay();
    }//End class Employee
    /// <summary>
    /// Purpose: Derived class for Hourly Employees
    /// </summary>
    sealed class Hourly : Employee
    {
        //-------------------------------------- Member Properties ---------------------------------
        /// <summary>
        /// Purpose: Hours worked Property - Read / Write
        /// </summary>
        public override double HoursWorked { get; set; }
        /// <summary>
        /// Purpose: Hourly Rate in $ Property - Read / Write
        /// </summary>
        public override decimal HourlyRate{ get; set; }
        //-------------------------------------- Constructors ---------------------------------
        /// <summary>
        /// Purpose: Default Constructor
        /// </summary>
        public Hourly () : base()
        {
            HourlyRate = 0.0M;
            HoursWorked = 0.0;
            EmpType = ETYPE.HRLY;
            Console.WriteLine("Hourly default Constructor");
        }
        /// <summary>
        /// Purpose: Parameterized Constructor
        /// </summary>
        /// <param name="eid">Employee ID</param>
        /// <param name="name">Employee Full Name</param>
        /// <param name="hrate">Employee Hourly Rate in $</param>
        /// <param name="hwk">Employee Hoours Worked</param>
        public Hourly(uint eid, string name, decimal hrate, double hwk) : base(eid, name)
        {
            HourlyRate = hrate;
            HoursWorked = hwk;
            EmpType = ETYPE.HRLY;
            Console.WriteLine("Hourly parameterized Constructor");
        }
        /// <summary>
        /// Purpose: Parameterized Constructor - With all string parameters
        /// </summary>
        /// <param name="eid">string Employee ID</param>
        /// <param name="name">string Employee Full Name</param>
        /// <param name="hrate">string Employee Hourly Rate</param>
        /// <param name="hwk">string Employee Hours Worked</param>
        public Hourly(string eid, string name, string hrate, string hwk) : base(eid, name)
        {
            HourlyRate = decimal.Parse(hrate);
            HoursWorked = double.Parse(hwk);
            EmpType = ETYPE.HRLY;
            Console.WriteLine("Hourly parameterized Constructor");
        }
        /// <summary>
        /// Purpose: To calculate the pay for an Hourly Employee
        /// </summary>
        /// <returns></returns>
        public override decimal CalcPay()
        {
            return HourlyRate * (decimal)HoursWorked;
        }
    }//End class Hourly
    /// <summary>
    /// Purpose: Salary Derived class
    /// </summary>
    class Salary : Employee
    {
        //-------------------------------------- Member Properties ---------------------------------
        /// <summary>
        /// Purpose: Property
        /// </summary>
        public override decimal MonthlySalary{ get; set; }
        //-------------------------------------- Constructors ---------------------------------
        /// <summary>
        /// Purpose: Default Constructor
        /// </summary>
        public Salary () : base()
        {
            MonthlySalary = 0.0M;
            EmpType = ETYPE.SAL;
            Console.WriteLine("Salary default Constructor");
        }
        /// <summary>
        /// Purpose: Parameterized Constructor
        /// </summary>
        /// <param name="eid">Employee ID</param>
        /// <param name="name">Employee Full Name</param>
        /// <param name="sal">Employee Salary in $</param>
        public Salary (uint eid, string name, decimal sal) : base(eid,name)
        {
            MonthlySalary = sal;
            EmpType = ETYPE.SAL;
            Console.WriteLine("Salary parameterized Constructor");
        }
        /// <summary>
        /// Purpose: Parameterized Constructor - With all string parameters
        /// </summary>
        /// <param name="eid">string Employee ID</param>
        /// <param name="name">string Employee Full Name</param>
        /// <param name="sal">string Salary in $</param>
        public Salary (string eid, string name, string sal) : base(eid,name)
        {
            MonthlySalary = decimal.Parse(sal);
            EmpType = ETYPE.SAL;
            Console.WriteLine("Salary parameterized Constructor");
        }
        /// <summary>
        /// Purpose: To calculate the pay for an Hourly Employee
        /// </summary>
        /// <returns></returns>
        public override decimal CalcPay()
        {
            return MonthlySalary;
        }
    }//End class Salary
    /// <summary>
    /// Purpose: Sales class
    /// </summary>
    sealed class Sales : Salary
    {
        //-------------------------------------- Member Properties ---------------------------------
        /// <summary>
        /// Purpose: Property Commission on Sales %
        /// </summary>
        public override double ComSales { get; set; }
        /// <summary>
        /// Purpose: Property Gross Sales in $
        /// </summary>
        public override decimal GrossSales { get; set; }
        //-------------------------------------- Constructors ---------------------------------
        /// <summary>
        /// Purpose: Default Constructor
        /// </summary>
        public Sales() : base()
        {
            ComSales = 0.0;
            GrossSales = 0.0M;
            EmpType = ETYPE.SLS;
            Console.WriteLine("Sales default Constructor");
        }
        /// <summary>
        /// Purpose: Parameterized Constructor
        /// </summary>
        /// <param name="eid">Employee ID</param>
        /// <param name="name">Employee Full Name</param>
        /// <param name="sal">Employee Salary</param>
        /// <param name="comsal">Sales Commission on Sales %</param>
        /// <param name="gsal">Sales Gross Sales in $</param>
        public Sales(uint eid, string name, decimal sal, double comsal, decimal gsal) : base(eid,name,sal)
        {
            ComSales = comsal;
            GrossSales = gsal;
            EmpType = ETYPE.SLS;
            Console.WriteLine("Sales parameterized Constructor");
        }
        /// <summary>
        /// Purpose: Parameterized Constructor - With all string parameters
        /// </summary>
        /// <param name="eid">string Employee ID</param>
        /// <param name="name">string Employee Full Name</param>
        /// <param name="sal">string Salary monthly salary in $</param>
        /// <param name="comsal">string Sales commission on gross sales in %</param>
        /// <param name="gsal">string Sales gross sales in $</param>
        public Sales(string eid, string name, string sal, string comsal, string gsal) : base(eid,name,sal)
        {
            ComSales = double.Parse(comsal);
            GrossSales = decimal.Parse(gsal);
            EmpType = ETYPE.SLS;
            Console.WriteLine("Sales parameterized Constructor");
        }
        /// <summary>
        /// Purpose: To calculate the pay for an Hourly Employee
        /// </summary>
        /// <returns></returns>
        public override decimal CalcPay()
        {
            return MonthlySalary + (decimal)ComSales * GrossSales;
        }
    }//End class Sales
    /// <summary>
    /// Purpose: Sales class - Derived / sealed
    /// </summary>
    sealed class Contract : Employee
    {
        //-------------------------------------- Member Properties ---------------------------------
        /// <summary>
        /// Purpose: Property in $
        /// </summary>
        public override decimal ContractSalary { get; set; }
        //-------------------------------------- Constructors ---------------------------------
        /// <summary>
        /// Purpose: Default Constructor
        /// </summary>
        public Contract() : base()
        {
            ContractSalary = 0.0M;
            EmpType = ETYPE.CNCT;
            Console.WriteLine("Contract default Constructor");
        }
        /// <summary>
        /// Purpose: Parameterized Constructor
        /// </summary>
        /// <param name="eid">Employee ID</param>
        /// <param name="name">Employee Full Name</param>
        /// <param name="csal">Contract Salary in $</param>
        public Contract(uint eid, string name, decimal csal) : base(eid,name)
        {
            ContractSalary = csal;
            EmpType = ETYPE.CNCT;
            Console.WriteLine("Contract parameterized Constructor");
        }
        /// <summary>
        /// Purpose: Parameterized Constructor - With all string parameters
        /// </summary>
        /// <param name="eid">string Employee ID</param>
        /// <param name="name">string Employee Full Name</param>
        /// <param name="csal">string Constract Salary in $</param>
        public Contract(string eid, string name, string csal) : base(eid,name)
        {
            ContractSalary = decimal.Parse(csal);
            EmpType = ETYPE.CNCT;
            Console.WriteLine("Contract parameterized Constructor");
        }
        /// <summary>
        /// Purpose: To calculate the pay for an Hourly Employee
        /// </summary>
        /// <returns></returns>
        public override decimal CalcPay()
        {
            return ContractSalary;
        }
    }//End class Contract
}//End namespace EmployeeDB_01
