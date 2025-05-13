using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Loop for
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            // Loop do while
            Console.WriteLine("=================================");
            int num = 5;
            do
            {
                num++;
                Console.WriteLine(num);
            }
            while (num <5);

            Console.WriteLine("=================================");

            // Loop While

            bool exit = true;

            while (exit) {
                Console.WriteLine("Es verdadero");
                exit = false;
            }

            // Break and Continue
            Console.WriteLine("=================================");

            for (int i = 0; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                if (i== 9)
                {
                    break;
                }
                Console.WriteLine(i);
            }

        }
    }
}
