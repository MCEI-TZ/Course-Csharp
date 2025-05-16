using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    // Implementing the inteface
    public class Notificaction : INotification
    {

        private string message;
        private string date;
        private string notificationBy;

        public Notificaction()
        {
        }

        public Notificaction(string message, string notificationBy)
        {
            this.message = message ?? throw new ArgumentNullException(nameof(message));
            this.date = ShowDate();
            this.notificationBy = notificationBy ?? throw new ArgumentNullException(nameof(notificationBy));
        }

        public string ShowDate()
        {
            return date = DateTime.Now.ToString();
        }

        public void ShowNotification()
        {
            Console.WriteLine("{0} {1} {2}",date,message,notificationBy);
        }
    }
}
