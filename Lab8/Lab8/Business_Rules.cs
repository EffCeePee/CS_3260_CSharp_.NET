using System;
using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;


namespace employee
{
    [Serializable]
    class Business_Rules
    {
        // singleton variables
        private static readonly Business_Rules rules = new Business_Rules();


        // employee class and inherited class test variables
        private Hourly newhrly;
        private Salary newSalry;
        private Sales newsles;
        private Contract newContract;
        private Hourly none = new Hourly();
        uint firstTestEmp = 10;
        uint lastTestEmp = 13;
        public FileIO FO = new FileIO();
        SortedDictionary<uint, Employee> empDictionary = new SortedDictionary<uint, Employee>();
        string _FilePath = @"C:\";
        OpenFileDialog _OFD = new OpenFileDialog();
        SaveFileDialog _SFD = new SaveFileDialog();



 

        // indexer variables
        private const int MIN_ID = 10;
        private const int MAX_INDEX = 50;
        string invalidNum = "Please give a valid employee number";
        

        /// <summary>
        /// Purpose: default constructor
        /// </summary>
        private Business_Rules()
        {
            empDictionary = FO.DB;
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
            if (empDictionary != null && empDictionary.ContainsKey(i))
            {
                return empDictionary[i];
            }
            else
            {
                throw new Exception(invalidNum);
            }
        }

/// <summary>
        ///        Purpose to add an Hourly Employee
/// </summary>
/// <param name="i"></param>
/// <param name="et"></param>
/// <param name="en"></param>
/// <param name="hr"></param>
/// <param name="hw"></param>
        public void addEmpHourly(uint i, ETYPE et, string en, decimal hr, double hw, bool ot, bool ben, bool comm, bool edBen)
        {
            if (empDictionary == null)
            {
                empDictionary = new SortedDictionary<uint, Employee>();
                newhrly = new Hourly(i, et, en, hr, hw, ot, ben, comm, edBen);
                empDictionary.Add(newhrly._EmpID, newhrly);
 
            } 
            else
            {
                newhrly = new Hourly(i, et, en, hr, hw, ot, ben, comm, edBen);
                empDictionary.Add(newhrly._EmpID, newhrly);
            }
        }

        /// <summary>
        /// Purpose to add an Salary Employee
        /// </summary>
        /// <param name="i"></param>
        /// <param name="et"></param>
        /// <param name="en"></param>
        /// <param name="ms"></param>
        public void addEmpSalary(uint i, ETYPE et, string en, decimal ms, bool ot, bool ben, bool comm, bool edBen)
        {
            if (empDictionary == null)
            {
                empDictionary = new SortedDictionary<uint, Employee>();
                newSalry = new Salary(i, et, en, ms, ot, ben, comm, edBen);
                empDictionary.Add(newSalry._EmpID, newSalry);
            }else
            {
                newSalry = new Salary(i, et, en, ms, ot, ben, comm, edBen);
                empDictionary.Add(newSalry._EmpID, newSalry);
            }
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
        public void addEmpSales(uint i, ETYPE et, string en, decimal cs, decimal gs, decimal ms, bool ot, bool ben, bool comm, bool edBen)
        {
            if (empDictionary == null)
            {
                empDictionary = new SortedDictionary<uint, Employee>();
                newsles = new Sales(i, et, en, cs, gs, ms, ot, ben, comm, edBen);
                empDictionary.Add(newsles._EmpID, newsles);
            }
            else
            {
                newsles = new Sales(i, et, en, cs, gs, ms, ot, ben, comm, edBen);
                empDictionary.Add(newsles._EmpID, newsles);
            }

        }

        /// <summary>
        /// Purpose: to add a contract employee
        /// </summary>
        /// <param name="i"></param>
        /// <param name="et"></param>
        /// <param name="en"></param>
        /// <param name="cs"></param>
        public void addEmpContract(uint i, ETYPE et, string en, decimal cs, bool ot, bool ben, bool comm, bool edBen)
        {
            if (empDictionary == null)
            {
                empDictionary = new SortedDictionary<uint, Employee>();
                newContract = new Contract(i, et, en, cs, ot, ben, comm, edBen);
                empDictionary.Add(newContract._EmpID, newContract);
            }
            else
            {
                newContract = new Contract(i, et, en, cs, ot, ben, comm, edBen);
                empDictionary.Add(newContract._EmpID, newContract);
            }
            
        }


        /// <summary>
        /// to test the sorted dictionary for a key
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public bool isInDic(uint i)
        {
           
            if(empDictionary != null && empDictionary.ContainsKey(i))
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

        public void startup()
        {
            
            //FO.openDB();
            empDictionary = FO.DB;
        }

       public void endProgram()
        {
            FO.DB = empDictionary;
            FO.closeDB();
        }

       public void openFile()
       {
           _OFD.InitialDirectory = _FilePath;
           _OFD.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

           if (_OFD.ShowDialog() == DialogResult.OK)
           {
               FO._filePath = _OFD.FileName;
               _FilePath = FO._filePath;
               FO._fileName = _OFD.SafeFileName;   
               FO.openDB();
               empDictionary = FO.DB;
           }
       }
 

        public void newFile()
       {
           _SFD.InitialDirectory = _FilePath;
           _SFD.Filter = "All files (*.*)|*.*";

           if (_SFD.ShowDialog() == DialogResult.OK)
           {
               FO._filePath = _SFD.FileName;
               _FilePath = FO._filePath;
               FO._fileName = _OFD.SafeFileName;
               FO.newDB(_FilePath);
           }
       }




    }// close class

}
