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

        }
    }
}
