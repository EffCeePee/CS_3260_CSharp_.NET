using System;

namespace Indexer_01
{
    static class Program
    {
        static void Main()
        {
            Data data = new Data();
            data[1000] = 5.5;
            double dval = data[1000];
            Console.WriteLine("Array[0] = {0:F2}", data[1000]);
            Console.Write("\nPress Enter to continue ... ");
            Console.ReadLine();
        }
    }
    class Data
    {
        private readonly int ASIZE;
        private const int MIN_ID = 1000;        //Minumum Employee ID
        private const int MAX_INDEX = 4;
        private double[] _dArray;
        public double this[int index]           //Indexing into the array with an Employee ID
        {
            get 
            { 
                if(index - MIN_ID >= 0 && index - MIN_ID < MAX_INDEX)
                   return _dArray[index - MIN_ID]; 
                else
                    throw new Exception("Invalid Employee Number");
            }
            set 
            {
                if (index - MIN_ID >= 0 && index - MIN_ID < MAX_INDEX)
                    _dArray[index-MIN_ID] = value;
                else
                    throw new Exception("Invalid Employee Number");
            }
        }
        public Data()
        {
            ASIZE = 4;
            _dArray = new double[ASIZE];
        }

    }
}
