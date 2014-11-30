using System;


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
        private Hourly none = new Hourly();

        // test data variables and array
        const int SIZE = 10;

        private Employee[] _empArray;

        // indexer variables
        private const int MIN_ID = 10;
        private const int MAX_INDEX = 4;
        string invalidNum = "Please give a valid employee number";
        private int i = 0;

        /// <summary>
        /// Purpose: default constructor
        /// </summary>
        private Business_Rules()
        {
            _empArray = new Employee[SIZE];
            _empArray[i] = hrly;
            i++;
            _empArray[i] = salry;
            i++;
            _empArray[i] = sles;
            i++;
            _empArray[i] = contrct;
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
        public Employee this[int index]
        {
            get
            {

                if (index % MIN_ID >= 0 && index < MAX_INDEX)
                    return _empArray[index];
                else
                    throw new Exception(invalidNum);
            }

            set
            {
                index %= MIN_ID;
                if (index % MIN_ID >= 0 && index < MAX_INDEX)
                    value = _empArray[index];
                else
                    throw new Exception(invalidNum);

            }
        }


        public Employee getEmp()
        {
            if (i < _empArray.Length && _empArray[i] != null)
            {
                i++;
                return _empArray[i - 1];
            }
            else
            {
                i = 0;
                return _empArray[i];
            }
        }


        public void addEmpHourly(int i, ETYPE et, string en, decimal hr, double hw)
        {
            int x = i % SIZE;
            _empArray[x] = new Hourly(i, et, en, hr, hw);

        }

        public void addEmpSalary(int i, ETYPE et, string en, decimal ms)
        {
            int x = i % SIZE;
            _empArray[x] = new Salary(i, et, en, ms);

        }

        public void addEmpSales(int i, ETYPE et, string en, decimal cs, decimal gs, decimal ms)
        {
            int x = i % SIZE;
            _empArray[x] = new Sales(i, et, en, cs, gs, ms);

        }

        public void addEmpContract(int i, ETYPE et, string en, decimal cs)
        {
            int x = i % SIZE;
            _empArray[x] = new Contract(i, et, en, cs);

        }

    }// close class
}
