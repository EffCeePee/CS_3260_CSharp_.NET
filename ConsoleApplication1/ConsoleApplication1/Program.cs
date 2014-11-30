using System;

namespace Exam1Prob1
{
    
    class Program
    {
        static void Main()
        {
            while(true)
            {
                Console.WriteLine("Enter the name of an animal: ");
                
                string rstg = Console.ReadLine();
                string temp;

                switch(rstg)
                {
                    case "Lion":
                    case "lion":
                    case "LION":
                        if ((rstg.ToUpper() == "LION") && (rstg[0] == 'L' && rstg[1] == 'i'))
                            Console.WriteLine("You have a Lion on your trail");
                        else
                            Console.WriteLine("you don't knkow about Lions!");
                        break;

                    case"Tiger":
                    case"tiger":
                    case"TIGER":
                        if((rstg.ToUpper() == "TIGGER") && (rstg[0] == 'T' && rstg[1] == 'i'))
                            Console.WriteLine("You have a Tigger on your trail");
                        else
                            Console.WriteLine("You don't know about Tiggers!");
                        break;

                    case "Bear":
                    case "bear":
                    case "BEAR":
                        if((rstg.ToUpper() == "BEAR") && (rstg[0] == 'B' && rstg[1] == 'e'))
                            Console.WriteLine("You have a Bear on your trail!");
                        else
                            Console.WriteLine("You don't know about Bears!");
                        break;

                    case "Deer":
                    case "deer":
                    case "DEER":
                        if((rstg.ToUpper() == "DEER") && (rstg[0] == 'D' && rstg[1] == 'e'))
                            Console.WriteLine("You have a Deer on your trail!");
                        else
                            Console.WriteLine("You don't know about Deers!");
                        break;

                    case "Dear":
                    case "dear":
                    case "DEAR":
                        if((rstg.ToUpper() == "DEAR") && (rstg[0] == 'D' && rstg[1] == 'e'))
                            Console.WriteLine("You have a woman/man on your trail!");
                        else
                            Console.WriteLine("You don't know about people!");
                        break;

                    case "Buffalo":
                    case "buffalo":
                    case "BUFFALO":
                         if((rstg.ToUpper() == "BUFFALO") && (rstg[0] == 'B' && rstg[1] == 'u'))
                            Console.WriteLine("You have a Lion on your trail!");
                        else
                            Console.WriteLine("You don't know about Buffalos!");
                        break;

                    case "Quit":
                    case "QUIT":
                    case "quit":
                    case "q":
                    case "Q":
                        Console.WriteLine("Goodbye");
                    rstg = "quit";
                        break;

                    default:
                        Console.WriteLine("You don't know anythign about animals!");
                        break;


                }// close switch
                    
                if (rstg == "quit")
                    break;
                else
                    continue;
    
            }// end while

            Console.ReadLine(); 
        }// end main
    }// end program
} // end namespace
