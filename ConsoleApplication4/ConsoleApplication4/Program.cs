using System;
using System.Text.RegularExpressions;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Data temp = new Data(5.5);
            //Data rdata = temp - 3.3;
            
            //Console.WriteLine(rdata);

            //Console.WriteLine("String=" + "".Equals(string.Empty));

            //string s = "applespeachesandpears";
            //s = s.Substring(0, s.LastIndexOf('p'));
            //s = s.Remove(0, s.IndexOf('p'));

            //Console.WriteLine(s);

            //string[] s = Regex.Split("dennisafairclough", "[aiou]");

            //foreach (string match in s)
            //{
            //    Console.WriteLine(" '{0}' ", s);
            //}

            //Regex regex = new Regex(@"^[a-kA-K][a-zA-Z 0-9\$\.]*$");
            //Match match = regex.Match("Kindness is now rewarded with $123.44");
            //Console.WriteLine("" + match.Success + " " + match.Value + " " + match.Index + " " + match.Length);

            //Console.WriteLine("a".CompareTo("b"));

            //Console.Write(Regex.Replace("abcwdge\nfx", "[a-f]", "A"));

            //Match rmatch = Regex.Match("When the hey?", "[a-h][a-h]*");
            //Console.WriteLine(rmatch.Value);


            
            string stri;
            Console.WriteLine("Please enter a string");
            stri = Console.ReadLine();


            stri.extMethod();
          
            Console.ReadLine();
            
           
        }
    }
}
    public static class Data
    {
        

            //    public static Data operator -(Data lhs, double rhs)
            //    {

            //        return new Data(rhs - lhs._dvalue);
            //    }

            //    public override string ToString()
            //    {
            //        return "result: " + _dvalue;
            //    }

                

            public static string extMethod(this string str)
            {
                string pattern = "^[F|S][aeiou]{1}[A-Za-z]+a{2,}?|^[F|S][aeiou]{1}[A-Za-z]+A{2,}?";
                string validString = "Is a match";
                string invalidString = "Is not a match";

                if (Regex.IsMatch(str, pattern))
                {
                    Console.WriteLine(validString);
                    Console.WriteLine(str);
                }
                else
                {
                    Console.WriteLine(invalidString);
                }
                Console.WriteLine();
                return str;
            }

    }

    






