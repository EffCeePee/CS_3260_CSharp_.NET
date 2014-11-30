// Project Prolog
// Name: Dennis
// CS 3260 Section 001
// Project: Delegates_01
// Date: 3/18/2014 9:54:56 AM
// 
// I declare that the following code was written by me or provided 
// by the instructor for this project. I understand that copying source
// code from any other source constitutes cheating, and that I will receive
// a zero on this project if I am found in violation of this policy.
// ---------------------------------------------------------------------------

using System;
using System.Linq.Expressions;
using System.Collections.ObjectModel;

namespace Delegates_01
{
    //------------ Declaration of a delegrate ------------- 
    delegate string MyDelegate(int ival, double dval);
    class Program
    {
        /// <summary>
        /// Purpose: Entry point to the program and test method for delegates and Lambda Expressions
        /// </summary>
        static void Main()
        {
            Program prog = new Program();
            //------------ Declaration and initialization of a delegrate variable-------------
            MyDelegate mdel1 = new MyDelegate(prog.Method_1);   //old initialization
            MyDelegate mdel2 = prog.Method_1;   //shorter way
            MyDelegate mdel3 = mdel1;   //assignment of one reference to another
            mdel3 += mdel2;     //chaining of delegate references
            mdel3 += mdel3;     //chaining of delegate references
            Console.WriteLine(mdel3(222, 55.55));
            //------------ new chaining initialization -------------
            mdel3 = prog.Method_1;
            mdel3 += prog.Method_2;
            mdel3 += prog.Method_3;
            mdel3 += prog.Method_4;
            Console.WriteLine(mdel3(1, 7.7));
            //------------ unchain assignment -------------
            mdel3 -= prog.Method_1;
            Console.WriteLine(mdel3(1, 3.33));
            //------------ chaining of references -------------
            mdel3 = mdel3 + mdel2 + mdel1;
            //------------ anonymous delegate declaration -------------
            mdel3 += delegate(int a, double b) { Console.WriteLine("Anonymous iv={0:D} dv={1:F2}", a, b); return "Anonymous"; };
            //------------ Declaration of a Lambda Expression -------------
            mdel3 += (c, d) => "Lambda Expression";
            Console.WriteLine(mdel3(5, 3.75));
            //------------ Declaration of a Lambda Expression using an outer variable max -------------
            int max = 100;
            Func<int> fdel = () => max + 5;
            Console.WriteLine("fdel -> {0:D}", fdel());
            //------------ Declaration and initialization of an Expression -------------
            Expression<Func<int,int,bool>> exp = (a,b) => a> b;
            Func<int,int,bool> A = exp.Compile();
            //var B = exp.Parameters;
            System.Collections.ObjectModel.ReadOnlyCollection<ParameterExpression> B = exp.Parameters;
            var C = exp.Body;
            string D = exp.ToString();
            var E = exp.Type;
            Console.Write("\nPress Enter to continue ... ");
            Console.ReadLine();
        }//End Main()

        //---------------- Methods that conform to delegate -------------------
        /// <summary>
        /// Purpose: Methods that satisfy the delegate
        /// </summary>
        /// <param name="iv">int param</param>
        /// <param name="dv">double param</param>
        /// <returns></returns>
        public string Method_1(int iv, double dv)
        {
            Console.WriteLine("Method_1 iv={0:D} dv={1:F2}", iv, dv);
            return "Method_1 "+iv+1;
        }
        public string Method_2(int iv, double dv)
        {
            Console.WriteLine("Method_2 iv={0:D} dv={1:F2}", iv + 1, dv);
            return "Method_2 "+iv+2;
        }
        public string Method_3(int iv, double dv)
        {
            Console.WriteLine("Method_3 iv={0:D} dv={1:F2}", iv + 2, dv);
            return "Method_3 "+iv+3;
        }
        public string Method_4(int iv, double dv)
        {
            Console.WriteLine("Method_4 iv={0:D} dv={1:F2}", iv + 3, dv);
            return "Method_4 "+iv+4;
        }
    }//End class Program
}//End namespace Delegates_01