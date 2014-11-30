using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IEnumerableExample
{
    static class Program
    {
        /// <summary>
        /// Purpose: Test of the Test class and IEnumerable interface
        /// </summary>
        static void Main()
        {
            Test test = new Test();
            for (int idx = -1; idx <= test.Capacity; idx++)
            {
                test[idx] = test[idx] + 10;
                Console.WriteLine(test[idx]);
            }
            IEnumerator iterator = test.GetEnumerator();
            if(iterator.MoveNext())
                Console.WriteLine(iterator.Current);
            foreach (int ival in test)
                Console.WriteLine(ival);
            Console.ReadLine();
        }//End Main()
    }//End class Program
    class Test
    {
        const int ASIZE = 10;
        private int[] _iArray;
        private int _Top;
        private int _Capacity;
        /// <summary>
        /// Purpose: Capacity read / write property
        /// </summary>
        public int Capacity
        {
            get { return _Capacity; }
            set { _Capacity = value; }
        }
        /// <summary>
        /// Purpose: Default Constructor to initialize object
        /// </summary>
        public Test()
        {
            _iArray = new int[ASIZE]{100, 99, 88, 77, 66, 55, 44, 33, 22, 11};
            _Top = 0;
            _Capacity = ASIZE;
        }
        /// <summary>
        /// Purpose: Indexer (read/write) for _iArray
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int this[int index]
        {
            get
            {
                if (index >= 0 && index < _Capacity)
                {
                    return _iArray[index];
                }
                else
                {
                    if (index < 0)
                        Console.WriteLine("Underflow Error");
                    if (index >= _Capacity)
                        Console.WriteLine("Overflow Error");
                    return 0;
                }
            }
            set
            {
                if (index >= 0 && index < _Capacity)
                    _iArray[index] = value;
                else
                {
                    if(index<0)
                    Console.WriteLine("Underflow Error");
                    if(index>=_Capacity)
                    Console.WriteLine("Overflow Error");
                }

            }
        }
        /// <summary>
        /// Purpose: Enumerator for Test class non-generic 
        /// </summary>
        /// <returns>valid values from _iArray</returns>
        //public IEnumerator GetEnumerator()
        //{
        //    for (int idx = 0; idx < _iArray.Length; idx++)
        //    {
        //        if (idx % 2 == 0)
        //            yield return _iArray[idx];
        //        if (idx == _Capacity - 2)
        //            yield break;
        //    }
        //}
        /// <summary>
        /// Purpose: Enumerator for Test class generic
        /// </summary>
        /// <returns>valid values from _iArray</returns>
        //public IEnumerator<int> GetEnumerator()
        //{
        //    for(int idx=0; idx<_iArray.Length; idx++)
        //    {
        //        if (idx != 0)
        //            yield return _iArray[idx];
        //        else
        //            yield break;
        //    }
        //}
        /// <summary>
        /// Purpose: Enumerator for Test class - dynamic
        /// </summary>
        /// <returns></returns>
        public IEnumerator<dynamic> GetEnumerator()
        {
            for(int idx=0; idx<_iArray.Length; idx++)
            {
                if (idx != 0)
                    yield return _iArray[idx];
                else
                    yield break;
            }
        }
    }//End class Test
 }//End namespace IEnumerableExample
