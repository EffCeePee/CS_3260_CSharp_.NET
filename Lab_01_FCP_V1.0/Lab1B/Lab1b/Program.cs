// Project Prologue
// Franklin Colton Parry
// Course: CS 3260
// File: lab1b.cs
// Date: 1/11/2014

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

// Using Statement
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Namespace Declaration
namespace Lab1b
{
    // Class Delcaration
    class Program
    {
        /// <summary>
        /// Purpose: to write to the console the minimum 
        /// </summary>
        /// <param name="args"> none </param>

        static void Main()
        {
            /// Variable delcarations and calculations of the MIN and MAX Values
            string maxVal = "The maximum value of an ";
            string minVal = "The minimum value of an ";
            string integer = "integer is: ";
            string shortNum = "short number is: ";
            string longNum = "long number is: ";
            string unsignedInt = "unsigned integer is: ";
            string unsignedShort = "unsigned short is: ";
            string unsignedLong = "unsigned long is: ";
            string character = "character is: ";
            string floatingPoint = "floating point number is: ";
            string boolean = "boolean value is: ";
            string decimalNum = "decimal number is: ";

            int iMax = int.MaxValue;
            int iMin = int.MinValue;
            uint uMax = uint.MaxValue;
            uint uMin = uint.MinValue;
            short sMax = short.MaxValue;
            short sMin = short.MinValue;
            ushort usMax = ushort.MaxValue;
            ushort usMin = ushort.MinValue;
            long lMax = long.MaxValue;
            long lMin = long.MinValue;
            ulong ulMax = ulong.MaxValue;
            ulong ulMin = ulong.MinValue;

            int cMax = char.MaxValue;
            cMax = cMax.GetHashCode();
            int cMin = char.MinValue;
            cMin = cMin.GetHashCode();
            
            float fMax = float.MaxValue;
            float fMin = float.MinValue;

            bool bMax = true;
            int boolMax = Convert.ToInt32(bMax);
            bool bMin = false;
            int boolMin = Convert.ToInt32(bMin);
            
            decimal dMax = decimal.MaxValue;
            decimal dMin = decimal.MinValue;

            /// Writeline code to display the variables to the console         
            Console.WriteLine("{0} {1} {2}", maxVal, integer, iMax);
            Console.WriteLine("{0} {1} {2}", minVal, integer, iMin);

            Console.WriteLine("{0} {1} {2}", maxVal, unsignedInt, uMax);
            Console.WriteLine("{0} {1} {2}", minVal, unsignedInt, uMin);

            Console.WriteLine("{0} {1} {2}", maxVal, shortNum, sMax);
            Console.WriteLine("{0} {1} {2}", minVal, shortNum, sMin);

            Console.WriteLine("{0} {1} {2}", maxVal, unsignedShort, usMax);
            Console.WriteLine("{0} {1} {2}", minVal, unsignedShort, usMin);

            Console.WriteLine("{0} {1} {2}", maxVal, longNum, lMax);
            Console.WriteLine("{0} {1} {2}", minVal, longNum, lMin);

            Console.WriteLine("{0} {1} {2}", maxVal, unsignedLong, ulMax);
            Console.WriteLine("{0} {1} {2}", minVal, unsignedLong, ulMin);

            Console.WriteLine("{0} {1} {2}", maxVal, character, cMax);
            Console.WriteLine("{0} {1} {2}", minVal, character, cMin);

            Console.WriteLine("{0} {1} {2}", maxVal, floatingPoint, fMax);
            Console.WriteLine("{0} {1} {2}", minVal, floatingPoint, fMin);

            Console.WriteLine("{0} {1} {2}", maxVal, boolean, boolMax);
            Console.WriteLine("{0} {1} {2}", minVal, boolean, boolMin);

            Console.WriteLine("{0} {1} {2}", maxVal, decimalNum, dMax);
            Console.WriteLine("{0} {1} {2}", minVal, decimalNum, dMin);
        
            Console.ReadLine();

            

        }
    }
}
