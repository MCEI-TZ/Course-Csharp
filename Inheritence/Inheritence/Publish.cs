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
        protected bool IsPublic { get; set; }

        // Void Constructor
        public Publish() { }

        // Return Constructor
        public Publish(string titulo, string autor, bool isPublic)
        {
            ID = GeneratedID();
            Titulo = titulo ?? throw new ArgumentNullException(nameof(titulo));
            Autor = autor ?? throw new ArgumentNullException(nameof(autor));
            IsPublic = isPublic;
        }

        protected int GeneratedID()
        {
            return ++publicacionId;
        }

        public void Edit(string titulo, string autor, bool isPublic)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("Titulo: {0} \nAutor: {1} \nPublico: {2}",Titulo,Autor,IsPublic);
        }

    }
}
