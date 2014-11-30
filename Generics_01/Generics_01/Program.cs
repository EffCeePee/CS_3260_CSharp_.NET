using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics_01
{
    class Program
    {
        static void Main()
        {
            TestCapacity();

            Console.ReadLine();
        }

        private static void TestCapacity()
        {
            int capacity = -1;
            List<int> numbers = new List<int>();
            while (true)
            {
                if (numbers.Capacity != capacity)
                {
                    capacity = numbers.Capacity;
                    Console.WriteLine(numbers.Capacity);

                }
                numbers.Add(10);
            }
        }
    }
}
