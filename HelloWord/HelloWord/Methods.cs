using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    public class Methods
    {
        // Void Method
        public void WriteSomething()
        {
            Console.WriteLine("Something...");
        }

        // Void Method with Parameters
        public void WriteSomething1(string message)
        {
            Console.WriteLine(message);
        }

        // Value Return Method
        public string WriteSomething2() {
            return "Method Return";
        }

        // Return Method with parameters
        public int WriteSomething3(int num) { 
            return num;
        }
    }
}
