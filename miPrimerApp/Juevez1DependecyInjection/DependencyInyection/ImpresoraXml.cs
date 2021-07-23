using Abstraccion;
using System.IO;
using System.Text;

namespace DependencyInyection
{
    internal class ImpresoraXml1 : Impresora
    {
        public override string Imprimir(Libro libro, string ruta)
        {
            var archivo = $"{ruta}\\{libro.Titulo.Replace(" ", string.Empty)}.xml";
            FileStream fileStream = File.Create(archivo);
            var contenido = $"<?xml version=\"1.0\" encoding=\"UTF-8\" ?><libro><id>{libro.LibroId}</id><titulo>{libro.Titulo}</titulo><autor>{libro.Autor}</autor></libro>";
            byte[] buffer = Encoding.UTF8.GetBytes(contenido);
            fileStream.Write(buffer);
            fileStream.Flush();
            fileStream.Close();

            return archivo;
        }
    }}