using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritence
{
    // Inheritence
    public class ImagePost : Publish
    {
        // Properties
        public string UrlImage { get; set; }

        public ImagePost() { }

        public ImagePost(string titulo, string autor, bool isPublic, string urlImage) : base(titulo, autor, isPublic)
        {
            this.Titulo = titulo;
            this.Autor = autor;
            this.IsPublic = isPublic;
            this.UrlImage = urlImage;
        }


        // if you hava another method for print the data of another method that you know that will be override you need to specify with "virtual"
        public override string ToString()
        {
            return String.Format("ID: {0} \nTitulo \nAutor: {2} \nPublica: {3} \nImage : {4}",this.ID,this.Titulo,this.Autor,this.IsPublic,this.UrlImage);
        }
    }
}
