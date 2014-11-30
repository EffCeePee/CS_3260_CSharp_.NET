using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDB_01
{
    /// <summary>
    /// Purpose: Test Data class
    /// </summary>
    class TestData
    {
        //---------------------------------------- const Variables ---------------------------------
        public const uint _eid0 = 1000;
        public const uint _eid1 = 1010;
        public const uint _eid2 = 1021;
        public const uint _eid3 = 1032;
        public const decimal _sal0 = 12000.50M;
        public const decimal _sal1 = 12.75M;
        public const decimal _sal2 = 1500.50M;
        public const decimal _sal3 = 15000.50M;
        public const decimal _gsales0 = 250000.00M;
        public const double _hrs0 = 45.55;
        public const double _pct0 = 0.025;
        //------------------------------------- class Level Variables ---------------------------------
        private List<Employee> employeeData;
        //------------------------------------- Member Properties ---------------------------------
        /// <summary>
        /// Purpose: Property to get the employeeData Object
        /// </summary>
        public List<Employee> GEmp { get { return employeeData; } }
        /// <summary>
        /// Purpose: Default Constructor to load employeeData Object with Employee Objects
        /// </summary>
        //------------------------------------- TestData Constructor -------------------------------
        public TestData ()
        {
            employeeData = new List<Employee>();
            employeeData.Add(new Salary(_eid0, "Snow White", _sal0));
            employeeData.Add(new Hourly(_eid1, "Doc Dwarf", _sal1, _hrs0));
            employeeData.Add(new Sales(_eid2, "Happy Dwarf", _sal2, _pct0, _gsales0));
            employeeData.Add(new Contract(_eid3, "Sleepy Dwarf", _sal3));
            Employee emp = new Salary();
            emp.EmpType = ETYPE.NONE;
            employeeData.Add(emp);
            emp = new Salary();
            emp.EmpType = ETYPE.BAD;
            employeeData.Add(emp);
        }
    }//End class TestData
}//End namespace EmployeeDB_01
