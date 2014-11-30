// Project Prologue
// Franklin Colton Parry
// Course: CS 3260
// File: lab1a.cs
// Date: 1/11/2014

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.


/* The steps I took inorder to creat the program were simple.  
1. I chose notepad, as my text editor because I had it and it workd.
2. I created the shell for the program, meaning the namespace, class, and main method, project and method prologues.
3. I wrote the code to write display hello world, and pause the system.
4. I wrote comments to discribe what I had written.
5. I opened the console and tried to compile the project with the csc command.
It failed, so I had to find where the csc command was and call it from its location.
6. Once that started working I complile the program and it failed, I 
had missed a capitlol letter, and some semi-colon;
7. I edited the code, saved and compiled again, this time it worked.
8. I located my .exe file and ran the program. 
9. Success.
 */

// using statements of the libraries
using System;
using System.IO;


//  nameing the namespace
namespace lab01
{

    // class Program
    class Program
    {
	/// Main method function
	/// Purpose: to write "Hello World!" to the console
	/// Parameters: an array of strings
	/// Returns:  Void
        static void Main(string[] args)
        {
            /// write out to the console
            Console.WriteLine ("Hello World!"); 

	    /// pause the system to wait for a carrage return
            Console.ReadLine();  ///system pause
        }
    }
}