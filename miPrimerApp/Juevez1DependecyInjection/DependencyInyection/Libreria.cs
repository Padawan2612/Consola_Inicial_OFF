using Abstraccion;
using System.Collections.Generic;
using System.Linq;

namespace DependencyInyection
{
    internal class Libreria
    {
        public Libreria()
        {
        }
        public Libreria(Impresora impresora)
        {
            Impresora = impresora;
        }
        public string Ruta { get; set; } = "D:\\DOCUMENTOS EDUARDO Y JOEL\\SOFTWARE 3ER SEMESTRE\\Programacion visual\\Juevez1DependecyInjection";
        public List<Libro> Libros { get; set; } = new List<Libro>();
        public Impresora Impresora { get; set; }

        internal string Imprimir(int libroId)
        {
            var libro = Libros.SingleOrDefault(libro => libro.LibroId == libroId);
            if (libro != null)
                return Impresora.Imprimir(libro, Ruta);
            else
                return "No existe el libro";
        }
    }
}