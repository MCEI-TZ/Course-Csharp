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

        // Manejo de TryCatch
        public void UseTryCatch()
        {
            try
            {
                Console.WriteLine("Insert a text for make a exception");
                string num1 = Console.ReadLine();
                int num1c = int.Parse(num1);
                int result = num1c * num1c;
            }
            catch (Exception ex) {
                Console.WriteLine("Very well you make an exception but we control the error with the try catch so you can see the error until this point");
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ToString());
            }
            
        }
    }
}
