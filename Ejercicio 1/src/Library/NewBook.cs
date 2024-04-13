using System;

namespace Ucu.Poo.Expert
{
    public class NewBook 
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }

        public NewBook(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }

    }
}

/*
No cumple con el principio de SRP ya que la clase Book tiene más de una responsibilidad, esto quiere decir 
que puede cambiar por más de una razón, lo cual contradice este criterio. 
Se podría crear otra clase, la cual tenga la responsabilidad de la ubicación de los libros, quedando solamente 
la responsabilidad de conocer el autor, el nombre, etc, a la clase Book.
La clase tendrá solamente la responsabilidad de conocer los datos de los libros.
La clase NewBook tiene la responsabilidad de conocer el libro.
La clase ShelveBook tiene la responsabilidad de ubicar los libros.
*/