using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escribe la temperatura de tu págis");
            int temp = Convert.ToInt32(Console.ReadLine());

            if (temp == 0) {
                Console.WriteLine("Esta en equilibrio");
            }
            Console.WriteLine("Nice");
            // Example of if
        }
    }
}
