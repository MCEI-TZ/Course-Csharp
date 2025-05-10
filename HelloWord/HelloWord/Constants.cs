using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWord
{
    public class Constants
    {
        const double pi = 3.1416;
        public void ShowConstants()
        {
            // Una constante no puede ser modificada
            //pi = 324;
            Console.WriteLine(pi);
        }
    }
}
