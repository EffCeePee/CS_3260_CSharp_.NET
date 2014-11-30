using System;

namespace Classes_Methods
{
    /// <summary>
    /// Purpose: static class to provide Main() 
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Purpose: Entry point to program and test method for the program.
        /// </summary>
        static void Main()
        {
            {
                Console.WriteLine("SClass.Test(20) returns {0}", SClass.Test(20));
                IClass instObj_0 = new IClass();
                IClass instObj_1 = new IClass(44, 55.55, 66.66);
                HClass hybridObj_1 = new HClass();
                HClass hybridObj_2 = new HClass("Hello, world!", 75.75);
                instObj_0 = null;
                instObj_1 = null;
            }
            Console.Write("\nPress Enter to continue ... ");
            Console.ReadLine();
        }
    }
    /// <summary>
    /// This an instance only class with only instance member. 
    /// Objects are instantiated with the new operator.
    /// </summary>
    class IClass
    {
        //--------------- Instance Member Data / Fields ----------------------
        private int _idata;
        private HClass hclass = new HClass("Good Guys", 45.55);     //Composit data has-a relationship
        protected double _ddata;
        //--------------- Instance Member Properties -------------------------
        /// <summary>
        /// Regular Property
        /// </summary>
        public int Idata
        {
            get { return _idata; }
            set { _idata = value; }
        }
        /// <summary>
        /// Automatic Property
        /// </summary>
        public double ADdata { get; set; }
        //----------------------- Instance Member Methods ------------------------
        /// <summary>
        /// Default Constructor
        /// </summary>
        public IClass()
        {
            _idata = default(int);
            _ddata = default(double);
            ADdata = default(double);
            Console.WriteLine("IClass Default Constructor");
        }
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="iv">int value MinValue 0 MaxValue</param>
        /// <param name="dv">double value MinValue 0.0 MaxValue</param>
        /// <param name="adv">double value MinValue 0.0 MaxValue</param>
        public IClass(int iv, double dv, double adv)
        {
            _idata = iv;
            _ddata = dv;
            ADdata = adv;
            Console.WriteLine("IClass Parameterized Constructor");
        }
        /// <summary>
        /// Destructor
        /// </summary>
        ~IClass()
        {
            Console.WriteLine("IClass Destructor");
        }
        /// <summary>
        /// Purpose: To determine if data is > 0 or <= 0
        /// </summary>
        /// <param name="data">int value</param>
        /// <returns>bool is true if data > 0 or false if data <= 0</returns>
        public bool Test(int data)
        {
            if (data > 0)
                return true;
            else
                return false;
        }
    }//End IClass
    /// <summary>
    /// SClass is a static class with only static methods
    /// </summary>
    public static class SClass
    {
        //-------------------- static Member Data -------------------
        private static int _sidata;
        //------------------- static Member Properties --------------
        /// <summary>
        /// Regular Property
        /// </summary>
        public static int Sidata
        {
            get { return SClass._sidata; }
            set { SClass._sidata = value; }
        }
        /// <summary>
        /// Automatic Property
        /// </summary>
        public static double Sddata { get; set; }
        //------------------ static Member Methods -------------------
        /*public*/ static SClass()
        {
            _sidata = default(int);
            Sddata = default(double);
            Console.WriteLine("SClass Default Constructor");
        }
        /// <summary>
        /// Parameterized static constructor
        /// </summary>
        /// <param name="iv">int iv parameter</param>
        /// <param name="dv">double dv parameter</param>
        //public static SClass(int iv, double dv)
        //{
        //    _sidata = iv;
        //    Sddata = dv;
        //    Console.WriteLine("SClass Parameterized Constructor");
        //}
        //static ~SClass()
        //{
        //   Console.WriteLine("SClass Destructor");
        //}
        /// <summary>
        /// Purpose: To test if data > 0
        /// </summary>
        /// <param name="data">int in range</param>
        /// <returns>data > 0 as true or data <= 0 as false</returns>
        public static bool Test(int data)
        {
            if (data > 0)
                return true;
            else
                return false;
        }
        /// <summary>
        /// Purpose: To calculate lop * rop
        /// </summary>
        /// <param name="lop">double left operand</param>
        /// <param name="rop">double right operand</param>
        /// <returns>lop * rop</returns>
        public static double Calc(double lop, double rop)
        {
            return lop * rop;
        }
    }//End SClass
    /// <summary>
    /// Hybrid class - Instance class with static members
    /// </summary>
    class HClass
    {
        //--------------------- Hybrid Member Data -------------------
        public const int _iVal = 111;
        private static int _sVal;
        public readonly int _rVal;
        private string _stg;
        private static string _sstg;
        //--------------------- Hybrid Member Properties -------------
        /// <summary>
        /// Regular Instance Property
        /// </summary>
        public string Stg
        {
            get { return _stg; }
            set { _stg = value; }
        }
        /// <summary>
        /// Regular static Property
        /// </summary>
        public static string Sstg
        {
            get { return HClass._sstg; }
            set { HClass._sstg = value; }
        }
        /// <summary>
        /// Automatic Instance Property
        /// </summary>
        public double DData { get; set; }
        /// <summary>
        /// Automatic static Property
        /// </summary>
        public static double SDData{ get; set;}
        //--------------------- Hybrid Member Methods ----------------
        /// <summary>
        /// Default Instance Constructor
        /// </summary>
        public HClass()
        {
            _sVal = 0;
            _rVal = 0;
            _stg = default(string);
            DData = default(double);
            Console.WriteLine("HClass Default Constructor");
        }
        /// <summary>
        /// Parameterized Constructor
        /// </summary>
        /// <param name="sv">string paramater</param>
        /// <param name="dv">double parameter</param>
        public HClass(string sv, double dv)
        {
            _sVal = 333;
            _rVal = 444;
            _stg = sv;
            DData = dv;
            Console.WriteLine("HClass Parameterized Constructor");
        }
        /// <summary>
        /// Destructor
        /// </summary>
        /*public*/ ~HClass()
        {
            Console.WriteLine("HClass Destructor");
        }
        /// <summary>
        /// static Default Constructor
        /// </summary>
        static HClass()
        {
            Console.WriteLine("HClass static Default Constructor");
        }
        /// <summary>
        /// Purpose: To calculate lop / rop
        /// </summary>
        /// <param name="lop">Left Operand</param>
        /// <param name="rop">Riht Operand</param>
        /// <returns>lop / rop</returns>
        public double Calc(double lop, double rop)
        {
            return lop / rop;
        }
        /// <summary>
        /// Purpose: To calculate lop + rop
        /// </summary>
        /// <param name="lop">Left Operand</param>
        /// <param name="rop">Right Operand</param>
        /// <returns>lop + rop</returns>
        public static double SCalc(double lop, double rop)
        {
            return lop + rop;
        }
    }//End HClass
}//End namespace Classes_Methods
