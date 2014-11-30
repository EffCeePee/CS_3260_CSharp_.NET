using System;
using System.Collections.Generic;


namespace employee
{
    sealed class Business_Rules
    {
        // singleton variables
        private static readonly Business_Rules rules = new Business_Rules();


        // employee class and inherited class test variables
        private Hourly hrly = new Hourly(10, ETYPE.Hourly, "Micky Mouse", 25.66M, 13.25);
        private Salary salry = new Salary(11, ETYPE.Salary, "Donald Duck", 40000.00M);
        private Sales sles = new Sales(12, ETYPE.Sales, "Princess Ariel", 10000.00M, 1000000.00M, 250000.00M);
        private Contract contrct = new Contract(13, ETYPE.Contract, "Walt Disney", 20000.00M);
        private Hourly newhrly;
        private Salary newSalry;
        private Sales newsles;
        private Contract newContract;
        private Hourly none = new Hourly();
        uint firstTestEmp = 10;
        uint lastTestEmp = 13;

        SortedDictionary<uint, Employee> empDictionary = new SortedDictionary<uint, Employee>();


        // indexer variables
        private const int MIN_ID = 10;
        private const int MAX_INDEX = 50;
        string invalidNum = "Please give a valid employee number";
        

        /// <summary>
        /// Purpose: default constructor
        /// </summary>
        private Business_Rules()
        {
            empDictionary.Add(hrly._EmpID, hrly);
            empDictionary.Add(salry._EmpID, salry);
            empDictionary.Add(contrct._EmpID, contrct);
            empDictionary.Add(sles._EmpID, sles);
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
        public Employee this[uint index]
        {
            get
            {

                if (index % MIN_ID >= 0 && index < MAX_INDEX)
                    return empDictionary[index];
                else
                    throw new Exception(invalidNum);
            }

            set
            {
                index %= MIN_ID;
                if (index % MIN_ID >= 0 && index < MAX_INDEX)
                    value = empDictionary[index];
                else
                    throw new Exception(invalidNum);

            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public Employee getEmp(uint i)
        {
            if (empDictionary.ContainsKey(i))
            {
                return empDictionary[i];
            }
            else
            {
                throw new Exception(invalidNum);
            }
        }

        /// <summary>
        /// Purpose to add an Hourly Employee
        /// </summary>
        /// <param name="i"></param>
        /// <param name="et"></param>
        /// <param name="en"></param>
        /// <param name="hr"></param>
        /// <param name="hw"></param>
        public void addEmpHourly(uint i, ETYPE et, string en, decimal hr, double hw)
        {
           
            newhrly  = new Hourly(i, et, en, hr, hw);
            empDictionary.Add(newhrly._EmpID, newhrly);
        }

        /// <summary>
        /// Purpose to add an Salary Employee
        /// </summary>
        /// <param name="i"></param>
        /// <param name="et"></param>
        /// <param name="en"></param>
        /// <param name="ms"></param>
        public void addEmpSalary(uint i, ETYPE et, string en, decimal ms)
        {
            newSalry = new Salary(i, et, en, ms);
            empDictionary.Add(newSalry._EmpID, newSalry);
        }

        /// <summary>
        /// Pupose to add a Sales Employee
        /// </summary>
        /// <param name="i"></param>
        /// <param name="et"></param>
        /// <param name="en"></param>
        /// <param name="cs"></param>
        /// <param name="gs"></param>
        /// <param name="ms"></param>
        public void addEmpSales(uint i, ETYPE et, string en, decimal cs, decimal gs, decimal ms)
        {
            newsles = new Sales(i, et, en, cs, gs, ms);
            empDictionary.Add(newsles._EmpID, newsles);

        }

        /// <summary>
        /// Purpose: to add a contract employee
        /// </summary>
        /// <param name="i"></param>
        /// <param name="et"></param>
        /// <param name="en"></param>
        /// <param name="cs"></param>
        public void addEmpContract(uint i, ETYPE et, string en, decimal cs)
        {
            
            newContract = new Contract(i, et, en, cs);
            empDictionary.Add(newContract._EmpID, newContract);
        }


        /// <summary>
        /// to test the sorted dictionary for a key
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public bool isInDic(uint i)
        {
            if(empDictionary.ContainsKey(i))
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        /// <summary>
        /// purpose: to reset the emp nums test 
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public uint testEmpNums(uint i)
        {
            if (i == lastTestEmp)
            {
                i = firstTestEmp;
                return i;
            }
            else
            {
                i++;
                return i;
            }
        }

    }// close class
}
