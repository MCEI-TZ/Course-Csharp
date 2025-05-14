using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    // Class
    public class Humano
    {
        // Void Constructor
        public Humano()
        {
        }

        //Miembro de Variables
        // Encapsulation
        public string Name { get; set; }
        public string Lasname { get; set; }
        public string Old { get; set; }
        public string Gender { get; set; }

        // Constructor with args
        public Humano(string name, string lasname, string old, string gender)
        {
            Name = name;
            Lasname = lasname;
            Old = old;
            Gender = gender;
        }

        // Overloading of a constructor
        public Humano(string name, string lasname)
        {
            Name = name;
            Lasname = lasname;
        }

        public void ShowHuman()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Lasname);
            Console.WriteLine(Old);
            Console.WriteLine(Gender);
        }

    }
}
