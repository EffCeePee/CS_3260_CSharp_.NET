using System;
using System.IO;
namespace ConsoleApplication2
{



    class Program
    {

       public static void Main()
       {
           string path = "C:\\Users\\F\\Desktop\\file.txt";
        try
       {
          string fileContents = File.ReadAllText(path);
          Console.WriteLine(fileContents);
          
       }
        catch(IOException ioexp)
       {
           Console.WriteLine("IOException - {0}", ioexp.Message);

       }
        catch(Exception exp)
       {
           Console.WriteLine("Exception - {0}", exp.Message);

       }
        finally
       {
           
           Console.WriteLine("The try-catch block has completed");
       }


        Console.ReadLine();
    }

  }
}

