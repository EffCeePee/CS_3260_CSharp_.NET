using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{

        class TestRegularExpressionValidation
        {
            static void Main()
            {
                string[] numbers = 
        {
            "123-555-0190", 
            "444-234-22450", 
            "690-555-0178", 
            "146-893-232",
            "146-555-0122",
            "4007-555-0111", 
            "407-555-0111", 
            "407-2-5555", 
        };

                string sPattern = "^\\d{3}-\\d{3}-\\d{4}$";

                foreach (string s in numbers)
                {
                   // System.Console.Write("{0,14}", s);

                    if (System.Text.RegularExpressions.Regex.IsMatch(s, sPattern))
                    {
                        System.Console.WriteLine(" - valid");
                    }
                    else
                    {
                        System.Console.WriteLine(" - invalid");
                    }
                }

                // Keep the console window open in debug mode.
                System.Console.WriteLine("Press any key to exit.");
                System.Console.ReadKey();
            }
        }
    
}
