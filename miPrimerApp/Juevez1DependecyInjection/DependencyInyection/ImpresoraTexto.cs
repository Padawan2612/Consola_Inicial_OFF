using Abstraccion;
using System.IO;
using System.Text;

namespace DependencyInyection
{
    internal class ImpresoraTexto : Impresora
    {
        public override string Imprimir(Libro libro, string ruta)
        {
            var archivo = $"{ruta}\\{libro.Titulo.Replace(" ", string.Empty)}.txt";
            FileStream fileStream = File.Create(archivo);
            var contenido = $"{libro.LibroId}\nTitulo: {libro.Titulo}\nAutor: {libro.Autor}";
            byte[] buffer = Encoding.UTF8.GetBytes(contenido);
            fileStream.Write(buffer);
            fileStream.Flush();
            fileStream.Close();

            return archivo;
        }
    }
}