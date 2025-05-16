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

            // Inheritence class
            Console.WriteLine("=====================================");
            ImagePost imagePost = new ImagePost("Mario Bros","Hideo Kojima",true,"https://www.google.com");
            Console.WriteLine(imagePost.ToString());
        }
    }
}
