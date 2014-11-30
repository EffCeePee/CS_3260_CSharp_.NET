// Project Prologue
// Franklin Colton Parry
// Course: CS 3260
// File: Class1.cs  for employee test data
// Date: 1/11/2014

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.


// using statements
using System;
using employee;


// namespace declaration
namespace Test_Data
{
    // enumaration
    public enum ETYPE{Hourly = 1, Salary, Sales, Contract};
   
    /// <summary>
    /// purpose:  class for test data
    /// </summary>
    class TestData
    {

        /// <summary>
        /// Constants and Variables
        /// </summary>
        const int SIZE = 5;
        int _index = 0;
        public Employee[] empl = new Employee[SIZE];


        // initializing each data type
        public Hourly hrly =  new Hourly(2001, "Hourly","Micky Mouse", 25.66M, 13.25);
        public Salary salry = new Salary(3001, "Salary", "Donald Duck", 40000.00M);
        public Sales sles = new Sales(4001, "Sales", "Princess Ariel", 10000.00M, 1000000.00M, 250000.00M);
        public Contract contrct = new Contract(5001, "Contract", "Walt Disney", 20000.00M );
        public Hourly none = new Hourly();
        

        /// <summary>
        /// populating each test type into an array
        /// </summary>
       public TestData()
        {
            empl[_index] = hrly;
            _index++;
            empl[_index] = salry;
            _index++;
            empl[_index] = sles;
            _index++;
            empl[_index] = contrct;
            _index++;
            empl[_index] = none;
        }    
    
    }
}
