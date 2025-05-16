using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Publish publish = new Publish("Harry Potter","Caterina Aster",true);
            Console.WriteLine(publish.ToString());
            
        }
    }
}
