using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notificaction notificaction = new Notificaction("Hi there, what's up","Mexz");
            Console.WriteLine(notificaction.ShowDate());
            notificaction.ShowNotification();
        }
    }
}
