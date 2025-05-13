using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calling the class Human
            // Void Constructor call
            Humano humano = new Humano();
            humano.name = "test";
            humano.lasname = "test";
            humano.gender = "Male";
            humano.old = "13";
            humano.ShowHuman();
        }
    }
}
