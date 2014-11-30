using System;
using System.Collections;

namespace DArray
{
    /// <summary>
    /// Purpose: class to contain Main()
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Purpose: To test the DArray class
        /// </summary>
        static void Main()
        {
            //---------------------------------------------- Declare a DArray ------------------------------------------------------------
            DArray myDynamicArray = new DArray();
            //---------------------------------------------- Fill myDynamicArray with values ------------------------------------------------------------
            Console.WriteLine("_Top {0} Value {2} _Capacity {1}",myDynamicArray.Top, myDynamicArray.Capacity, myDynamicArray[0]);
            myDynamicArray[0] = 111;
            Console.WriteLine("_Top {0} Value {2}  _Capacity {1}",myDynamicArray.Top, myDynamicArray.Capacity, myDynamicArray[0]);
            myDynamicArray[1] = 222;
            Console.WriteLine("_Top {0} Value {2}  _Capacity {1}",myDynamicArray.Top, myDynamicArray.Capacity, myDynamicArray[1]);
            myDynamicArray[2] = 333;
            Console.WriteLine("_Top {0} Value {2}  _Capacity {1}",myDynamicArray.Top, myDynamicArray.Capacity, myDynamicArray[2]);
            myDynamicArray[3] = 444;
            Console.WriteLine("_Top {0} Value {2}  _Capacity {1}",myDynamicArray.Top, myDynamicArray.Capacity, myDynamicArray[3]);
            myDynamicArray[0] = 555;
            Console.WriteLine("_Top {0} Value {2}  _Capacity {1}",myDynamicArray.Top, myDynamicArray.Capacity, myDynamicArray[0]);
            myDynamicArray[7] = 777;
            Console.WriteLine("_Top {0} Value {2}  _Capacity {1}",myDynamicArray.Top, myDynamicArray.Capacity, myDynamicArray[7]);
                myDynamicArray[4] = 666;
            Console.WriteLine("_Top {0} Value {2}  _Capacity {1}",myDynamicArray.Top, myDynamicArray.Capacity, myDynamicArray[4]);
            //---------------------------------------------- Copy Values from DArray ------------------------------------------------------------
            int iValue = myDynamicArray[3];
            iValue = myDynamicArray[2];
            iValue = myDynamicArray[1];        
            iValue = myDynamicArray[0];
            iValue = myDynamicArray[7];
            //---------------------------------------------- Output DArray values in foreach loop / Test IEnumerable ------------------------------------------------------------
            foreach (int iVal in myDynamicArray)
            {
                Console.WriteLine("Using foreach -> " + iVal);
            }
            Console.ReadLine();
        }//End Main( )
    }//End static class Program
    /// <summary>
    /// Purpose: Dynamic Array class with initial size of 4
    /// </summary>
    public class DArray : object, IEnumerable 
    {
        //---------------------------------------------- member fields  ------------------------------------------------------------
        private const int ASIZE = 4;
        private int[] _iArray;
        private int _Top;
        public int Top{get { return _Top; }}
        private int _Capacity;
        /// <summary>
        /// Purpose: Readonly property for _Capacity
        /// </summary>
        public int Capacity{ get { return _Capacity; } }
        //---------------------------------------------- Member indexers ------------------------------------------------------------
        /// <summary>
        /// Purpose: Indext for _iArray 
        /// </summary>
        /// <param name="index">Array index value</param>
        /// <returns>indexed value of the array</returns>
        public int  this[int index]
        {
            get
            {
                if (index < _Top && _Top >= 0 &&  _Top <_Capacity)
                    return _iArray[index];
                else
                {
                    Console.WriteLine("Get -> Index out of bounds");
                    return default(int);
                }
            }
            set
            {
                if (index < _Top && _Top >= 0 && _Top < _Capacity)
                {
                    _iArray[index] = value;
                }
                else if (index == _Top && _Top < _Capacity)
                         _iArray[_Top++] = value;
                     else   if(index == _Top || _Top >= _Capacity)
                            {
                                Resize();
                                _iArray[_Top++] = value;
                                return;
                            }
                            else  
                               Console.WriteLine("Set -> Index out of bounds");
            }
        }
        //---------------------------------------------- Member Methods ------------------------------------------------------------
        /// <summary>
        /// Purpose: Default Constructor to initialize the fields
        /// </summary>
        public DArray()         //default Constructor
        {
            _iArray = new int[ASIZE];
            _Top = 0;
            _Capacity = ASIZE;
        }
        /// <summary>
        /// Purpose: Doubles the capacity of the array
        /// </summary>
        private void Resize()
        {
            int[] temp = new int[_Capacity * 2];
            _iArray.CopyTo(temp, 0);
            _Capacity *= 2;
            _iArray = temp;
            temp = null;
        }
        /// <summary>
        /// Purpose: Gets the Enumerator for IEnumerable interface
        /// </summary>
        /// <returns>IEnumerator interface</returns>
        public IEnumerator GetEnumerator()
        {
            IEnumerator myEnum = new MyEnumerator(_iArray);
            return myEnum;
        }
    }//End class DArray
    /// <summary>
    /// Purpose: Enumerator object with IEnumerator interface
    /// </summary>
    class MyEnumerator : object, IEnumerator            //Inner class
    {
        //---------------------------------------------- Member Fields ------------------------------------------------------------
        private int[] myArray;
        private object _Current;
        private int _Top = -1;
        //---------------------------------------------- Member Methods ------------------------------------------------------------
        /// <summary>
        /// Purpose: Parameterized Constructor
        /// </summary>
        /// <param name="eArray">Array reference from DArray object</param>
        public MyEnumerator(int[] eArray)
        {
            myArray = eArray;
            _Current = 0;
        }
        /// <summary>
        /// Purpose: Gets reference to the next element
        /// </summary>
        /// <returns></returns>
        public bool MoveNext()
        {
            if (_Top >= -1 && _Top < myArray.Length - 1)
            {
                _Top++;
                _Current = myArray[_Top];
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Purpose: Property for current element 
        /// </summary>
        public object Current
        {
            get { return _Current; }
        }
        /// <summary>
        /// Purpose: Reset the Enumerator
        /// </summary>
        public void Reset()
        {
            _Top = -1;
            _Current = null;
        }
    }//End class MyEnumerator
}//End namespace DArray
