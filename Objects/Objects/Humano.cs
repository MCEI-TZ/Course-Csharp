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
        public string name { get; set; }
        public string lasname { get; set; }
        public string old {  get; set; }
        public string gender { get; set; }

        // Constructor with args
        public Humano(string name, string lasname, string old, string gender)
        {
            this.name = name;
            this.lasname = lasname;
            this.old = old;
            this.gender = gender;
        }

        // Overloading of a constructor
        public Humano(string name, string lasname)
        {
            this.name = name;
            this.lasname = lasname;
        }
        
        public void ShowHuman()
        {
            Console.WriteLine(this.name );
            Console.WriteLine(this.lasname);
            Console.WriteLine(this.old);
            Console.WriteLine(this.gender);
        }

    }
}
