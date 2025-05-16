using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Auto
    {
        public Auto()
        {
        }

        public int HP { get; set; }
        public string Color { get; set; }

        public Auto(int hP, string color)
        {
            HP = hP;
            Color = color;
        }

        public virtual void ShowDetails()
        {
            Console.WriteLine("{0}-{1}",HP,Color);
        }

        public void Repare()
        {
            Console.WriteLine("Reparing...");
        }
    }
}
