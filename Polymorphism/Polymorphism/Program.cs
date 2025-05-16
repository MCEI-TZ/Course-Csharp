using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Auto> autos = new List<Auto>()
            {
                new Auto(1,"Black"),
                new Auto(2,"White"),
                new Auto(3,"Black"),
                new Auto(4,"Black")
            };

            Auto autos2 = new BMW("Califo","Mamas",1,"black");
            autos2.ShowDetails();

            List<Auto> autos3 = new List<Auto>()
            {
                new BMW("sd","fa",1,"fsa")
            };

            for (int i = 0; i < autos3.Count; i++)
            {
                autos3 [i].ShowDetails();
            }

        }
    }
}
