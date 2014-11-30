
// Project Prologue
// Franklin Colton Parry
// Course: CS 3260
// File: employee_classes.cs
// Date: 2/24/2014

// I declare that the following source code was written by me, or provided
// by the instructor for this project. I understand that copying
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in violation of
// this policy.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;



namespace employee
{
    public interface IFileAccess 
    {
        void writeDB();
        void readDB();
        void openDB();
        void closeDB();

        int i = 0;
        SortedDictionary<uint, Employee> DB { get; set; }

    }//end interface IFileAccess

    

    public class FileIO : IFileAccess
    {
        //member data as required
        //member properties & indexers as required
        //member methods as required
       
        
        private FileStream fileStream;
        private BinaryFormatter binaryFormatter;

        public SortedDictionary<uint, Employee> DB { get; set; }

        public FileIO()
        {
            
            fileStream = new FileStream(@"C:\Users\F\Desktop\BinaryFormat.bn", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            binaryFormatter = new BinaryFormatter();

            
        }

        

        void IFileAccess.openDB()
        {
            
                 
        }

         void IFileAccess.closeDB()
        {
            fileStream.Close();
        }

        void IFileAccess.writeDB()
        {

        }

        void IFileAccess.readDB()
        {

        }
        

            //try
            //{
            //}
            //catch (IOException ioexp)
            //{
            //    Console.WriteLine("IOException - {0}", ioexp.Message);

            //}
            //catch(Exception exp)
            //{
            //    Console.WriteLine("Exception - {0}", exp.Message);

            //}
            //finally
            //{
            //    fileStream.Close();
            //    Console.WriteLine("End Binary Formatter");

            
    }   //end class FileIO
}
