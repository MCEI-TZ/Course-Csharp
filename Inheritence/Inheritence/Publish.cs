using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    public class Publish
    {
        private static int publicacionId;

        //Properties
        protected int ID { get; set; }
        protected string Titulo { get; set; }
        protected string Autor { get; set; }
        protected string IsPublic { get; set; }

        // Void Constructor
        public Publish() { }

        // Return Constructor
        public Publish(int iD, string titulo, string autor, string isPublic)
        {
            ID = iD;
            Titulo = titulo ?? throw new ArgumentNullException(nameof(titulo));
            Autor = autor ?? throw new ArgumentNullException(nameof(autor));
            IsPublic = isPublic ?? throw new ArgumentNullException(nameof(isPublic));
        }

    }
}
