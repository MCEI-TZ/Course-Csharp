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
            string temp = Console.ReadLine();
            int temp1;
            bool success = int.TryParse(temp, out temp1);

            // Example of if
            if (!success)
            {
                Console.WriteLine("Escribe un número");
            }


            // Else if
            if (temp1 == 0) {
                Console.WriteLine("Esta en equilibrio");
            }
            
            else if(temp1 > 30)
            {
                Console.WriteLine("Esta caliente");
            }
            else if(temp1 < 0)
            {
                Console.WriteLine("Esta frio");
            }
        }
    }
}
