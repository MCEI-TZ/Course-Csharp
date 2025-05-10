using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world!!!!");
            // ---Types of Data in C#---

            // sbyte
            sbyte num = 10;
            Console.WriteLine("\t\nSbyte");
            Console.WriteLine("Valor minimo: " + sbyte.MinValue);
            Console.WriteLine("Valor maximo: " + sbyte.MaxValue);

            // short
            short num2 = 10;
            Console.WriteLine("\t\nshort");
            Console.WriteLine("Valor minimo: " + short.MinValue);
            Console.WriteLine("Valor maximo: " + short.MaxValue);

            // Integer
            int num3 = 13;
            Console.WriteLine("\t\nInteger");
            Console.WriteLine("Valor minimo: " + int.MinValue);
            Console.WriteLine("Valor maximo: " + int.MaxValue);

            // Long
            long numlong = 14;
            Console.WriteLine("\t\nLong");
            Console.WriteLine("Valor minimo: " + long.MinValue);
            Console.WriteLine("Valor maximo: " + long.MaxValue);

            // Float
            float num4 = 10f;
            Console.WriteLine("\t\nFloat");
            Console.WriteLine("Valor minimo: " + float.MinValue);
            Console.WriteLine("Valor maximo: " + float.MaxValue);

            // Double
            double num5 = 10.0;
            Console.WriteLine("\t\nDouble");
            Console.WriteLine("Valor minimo: " + double.MinValue);
            Console.WriteLine("Valor maximo: " + double.MaxValue);

            // Decimail
            decimal num6 = 0;
            Console.WriteLine("\t\nDecimal");
            Console.WriteLine("Valor minimo: " + decimal.MinValue);
            Console.WriteLine("Valor maximo: " + decimal.MaxValue);

            // ----------------------------------------------------

            // String
            Console.WriteLine("\t\nString");
            string message = "Como estas";

            // Some methods
            // Upper Case
            string upperMessage = message.ToUpper();
            // Lower Case
            string lowerMessage = message.ToLower();
            string withoutsplit = "Cadena; de; texto";
            // Replace Method
            withoutsplit = withoutsplit.Replace(";", "");
            Console.WriteLine(message);
            Console.WriteLine(upperMessage);
            Console.WriteLine(lowerMessage);
            Console.WriteLine(withoutsplit);
        }
    }
}
