using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    public class Convertions
    {
        public void ConvertionData()
        {
            Console.WriteLine("Double a Int");
            double miDouble = 13.37;
            Console.WriteLine("Mi numero original double");
            Console.WriteLine(miDouble);
            int miInt;

            // Casting
            miInt = (int)miDouble;
            Console.WriteLine("miInt = (int)miDouble;");
            Console.WriteLine("Numero  convertido");
            Console.WriteLine(miInt);

            // -----------------------------------------
            // Conversion Implicita (Conversion dentrol de otra cuando es mayor)
            int num = 123456;
            long numg = num;
            Console.WriteLine(numg);

            // -----------------------------------------
            // Conversion tipo (Entero - texto)
            string miString = miDouble.ToString();
            Console.WriteLine(miString);

            // ----------------------------------------------
            // Parsing
            double.Parse(miString);
            Console.WriteLine(miString);
        }
    }
}
