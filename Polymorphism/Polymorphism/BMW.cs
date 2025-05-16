using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class BMW : Auto
    {
        public BMW()
        {
        }

        public string Marca { get; set; }
        public string Modelo { get; set; }

        public BMW(string marca, string modelo, int hP, string color) : base(hP, color)
        {
            Marca = marca;
            Modelo = modelo;
        }

        public override void ShowDetails()
        {
            Console.WriteLine("{0}-{1}-{2}-{3}", HP, Color, Marca, Modelo);
        }

    }
}
