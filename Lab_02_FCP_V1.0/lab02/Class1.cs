// Project Prologue
// Franklin Colton Parry
// Course: CS 3260
// File: Class1.cs
// Date: 1/20/2014

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

// using statement
using System;


namespace calculator
{
    /// <summary>
    /// single complex number class
    /// </summary>
    class SingleComplexNumber
    {
        // variable to hold the number
        private string complexNumber;

        /// <summary>
        /// default constructor
        /// </summary>
        public SingleComplexNumber()
        {
            complexNumber = null;
        }

        /// <summary>
        /// Purpse: to set a string of the number
        /// returns: none
        /// </summary>
        /// <param name="r"></param>
        /// <param name="c"></param>
        public void SetComplexNumber(string r, string c)
        {
            /// variable to represent sqrt of -1
            string i = "i"; 
            complexNumber = (r + " + " + c +i);
        }

        /// <summary>
        /// Purpose:  get the complex number
        /// returns: string
        /// </summary>
        /// <returns>string</returns>
        public string getComplexNumber()
        {
            return complexNumber;
        }

    }

    /// <summary>
    /// Complex Caclulator Class
    /// </summary>
    class ComplexAC
    {
       private
           
           /// declare variables
            string opperation;

        /// <summary>
        /// Default Constructor
        /// Purpose: set opperation to Null
        /// </summary>
            public ComplexAC()
            {
                opperation = null;
            }
        /// <summary>
        /// Pupose: set the opperation to addition else it is subtraction
        /// </summary>
        /// <param name="o"></param>
            public void SetOpperation (string o)
            {
                opperation = o;
            }

        /// <summary>
        /// Purpose: to get the opperation for the form
        /// </summary>
        /// <returns>string contating the opperation</returns>
            public string GetOpperation()
            {
                return opperation;
            }

        /// <summary>
        /// Purpose:  to calculate and set the complex number
        /// Returns: an complex number object
        /// </summary>
        /// <param name="oner"></param>
        /// <param name="twor"></param>
        /// <param name="onec"></param>
        /// <param name="twoc"></param>
        /// <param name="n"></param>
        /// <returns></returns>
            public SingleComplexNumber calculate(double oner, double twor, double onec, double twoc, SingleComplexNumber n)
            {
                
                // declare variables to convert numbers to strings
                string lastRealNum = null;
                string lastCompNum = null;

                // variables to hold the nubmers
                double realNum = 0;
                double complexNum = 0;
               

                // logic to determine to add or subtract based on the opperator set

                if(opperation == "add")
                {
                    realNum = oner + twor;
                    complexNum = onec + twoc;
                }
                else
                {
                    realNum = oner - twor;
                    complexNum = onec - twoc;
                }
            
                /// convert the numberst to strings
                lastCompNum = Convert.ToString(complexNum);
                lastRealNum = Convert.ToString(realNum);

                // set the objects complex number
                n.SetComplexNumber(lastRealNum, lastCompNum);

                // return the object
                return n;
            }


    }

}