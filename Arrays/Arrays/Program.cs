using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Array Simple
            int[] numArray = new int[5];

            numArray[0] = 1;
            numArray[1] = 2;
            numArray[2] = 3;
            numArray[3] = 4;
            numArray[4] = 5;

            // Use of leng for know how many data have the array
            Console.WriteLine(numArray.Length);

            // Array defineted

            int[] numArray2 = { 13, 12, 32, 32, 32, 34, 324, 23 };

            // Another way
            int[] numArray3 = new int[] { 13, 12, 32, 32, 32, 34, 324, 23 };

            // Loop for each
            foreach (var item in numArray3)
            {
                Console.WriteLine(item);
            }

        }
    }
}
