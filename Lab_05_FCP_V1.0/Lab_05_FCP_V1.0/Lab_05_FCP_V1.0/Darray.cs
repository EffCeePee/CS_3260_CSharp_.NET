using System;
using System.Collections;


namespace employee
{
    public class DArray : object, IEnumerable
    {
        //---------------------------------------------- member fields  ------------------------------------------------------------
        private const int ASIZE = 4;
        private int[] _iArray;
        private int _Top;
        public int Top { get { return _Top; } }
        private int _Capacity;
        /// <summary>
        /// Purpose: Readonly property for _Capacity
        /// </summary>
        public int Capacity { get { return _Capacity; } }
        //---------------------------------------------- Member indexers ------------------------------------------------------------
        /// <summary>
        /// Purpose: Indext for _iArray 
        /// </summary>
        /// <param name="index">Array index value</param>
        /// <returns>indexed value of the array</returns>
        public int this[int index]
        {
            get
            {
                if (index < _Top && _Top >= 0 && _Top < _Capacity)
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
                else if (index == _Top || _Top >= _Capacity)
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
}
