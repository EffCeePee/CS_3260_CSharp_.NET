using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_02
{
    static class Program
    {
        static void Main(string[] args)
        {
            // instanciate an new info
            IClass info = new IClass(); 
            info.Name = Console.ReadLine();  // when incapsulated info.name acts like a variable even though it is a getter or setter method. 
            string stg = info.Name;
            Console.WriteLine(info.Name);
            Console.ReadLine();

        }
    }

    class IClass // instance class, I know this is instance because of no static key word, to be instanciated it needs a new operator
    {
       private // variables in C# need to be private
        const int iv = 100;
        protected static int sv; // protected is the same as private
        readonly int ro = 45;  // doesn't need to be initialized until the constructor calls it, all other variables need to be initialized


        private string name; // use the refactor encapsulate to get it to write the getter and setter for you

        // default constructor
        public
            IClass()
            {
                sv = default(int) ;
                Console.WriteLine("the contructor worked");
            }

            // destructors are by default public
        ~IClass()
        {
            Console.WriteLine("The destructor worked");
        }



        public string Name
        {
            // for non automatic they can have get or set or both when they only have one it is read or write only
            get 
            { 
                return name; 
            }

            set
            {
                if (value == "" || value == null)
                    throw new Exception("Cannot be null, or empty, I need a value");
                else
                    name = value;
            }
        }

        // underlying property, writes the code for you
        // automatic property, must have both getter and setter
        public double DValue { get; set; }
    }

   public static class Data  // when static is used it is considered a Singleton, if you declare it static all members must be static
       // static classes are not instanciated, but created when they are accessed
    {
       private static int sdata;

        public static int Sdata
        {
          get { return Data.sdata; }
          set { Data.sdata = value; }
        }



        // static classes can only have default constructors, no ability to specify by yourself
        // same as the destructor
       

    }


    class stuff  // this is a hybrid class because of static members however there is no difference between the instance class
    {
        public const int ival = 111;  // constants must be declared at initilization, it only exits at the class level, made public because it is default static
        // wanted to be seen by othe rmembers of the class
        private int iv;
        private static int sv;
        
        // static variables do not have a "This" reference


        // constructor   cannot be public paramaterized constructor
        static stuff()
        {

        }

    }

// When one class derives from another class there exists an "Is-a" relationship
// When a class instantiates a new class it has a "has-a" relationship










}

