
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
using System.Windows.Forms;


namespace employee
{
    public interface IFileAccess 
    {
        void WriteDB();
        void readDB();
        void openDB();
        void closeDB();
        SortedDictionary<uint, Employee> DB { get; set; }

    }//end interface IFileAccess

    

    public class FileIO: Object, IFileAccess
    {
        //member data as required
        //member properties & indexers as required
        //member methods as required
       
        
        private FileStream fileStream;
        private BinaryFormatter binaryFormatter;
        public string _filePath { get; set;}
        public string _fileName { get; set;}

        public SortedDictionary<uint, Employee> DB { get; set; }

               
        // IFileAccess Method Implementations:
        public void openDB()
        {
          
            try
            {
                fileStream = new FileStream(_filePath, FileMode.Open, FileAccess.Read);
                binaryFormatter = new BinaryFormatter();
                DB = (SortedDictionary<uint, Employee>)binaryFormatter.Deserialize(fileStream);
            }
            catch (IOException ioexp)
            {

                MessageBox.Show("Error: Cannot open the file" + ioexp.Message);
                
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error: Cannot open the file" + exp.Message);
            }
            finally
            {
                fileStream.Close();
                MessageBox.Show("The"+_fileName+" is open");              
            }

                 
        }

        public void closeDB()
        {
            try
            {
                fileStream = new FileStream(_filePath, FileMode.Create, FileAccess.Write);
                binaryFormatter = new BinaryFormatter();
                binaryFormatter.Serialize(fileStream, DB);
                
            }
            catch (IOException ioexp)
            {
                MessageBox.Show("Error: Cannot close the file" + ioexp.Message);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error: Cannot close the file" + exp.Message);
            }
            finally
            {
                fileStream.Close();
                MessageBox.Show("The file is closed");
            }
        }


        public void newDB(string fp)
        {
            try
            {
                fileStream = new FileStream(fp, FileMode.CreateNew, FileAccess.ReadWrite);           
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error: no file created" + exp.Message);
            }
            finally
            {
                fileStream.Close();
            }
        }


       public  void WriteDB()
        {
            fileStream.Flush();
        }

        public void readDB()
        {
            DB = (SortedDictionary<uint, Employee>)binaryFormatter.Deserialize(fileStream);
        }
        


            
    }   //end class FileIO
}
