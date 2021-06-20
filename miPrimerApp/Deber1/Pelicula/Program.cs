using System;

namespace DeberNumero1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mi Pelicula Favorita");
            //Pelicula favorita//
            var peliculaPregunta = ("Cual es tu pelicula Favorita ?: \n");
            Console.Write(peliculaPregunta);
            var tituloPelicula = ("Saw");
            //Pais//
            var paisPregunta = ("Donde se grabó esta pelicula ? : \n");
            Console.Write(paisPregunta);
            var Pais = ("Estados Unidos");
            //Genero//
            var GeneroPregunta = ("A que genero pertenece esta pelicula ? : \n");
            Console.Write(GeneroPregunta);
            var Genero = ("Terror,suspenso,gore");
            //año de estreno//
            var anioPregunta = ("En que año se estreno ? : \n");
            Console.Write(anioPregunta);
            var anioEstreno = ("2004");
            //Director//
            var DirectorPregunta = ("Nombre del director ? : \n");
            Console.Write(DirectorPregunta);
            var NameDirector = ("James Wan");
            //productora//
            var productoraPregunta = ("Nombre de la productora ? : \n");
            Console.Write(productoraPregunta);
            var Productora = ("Lions Gate Entertainment");
            //Musica//
            var MusicaPregunta = ("Quien fue el encargado de la musica ? : \n");
            Console.Write(MusicaPregunta);
            var Musica = ("David A. Armstrong");
            //Fotografia//
            var FotografiaPregunta = ("Personal de Fotografia : \n");
            Console.Write(FotografiaPregunta);
            var Foto = ("David A. Armstrong");
            //Guion//
            var GuionPregunta = ("Personal de Guion: \n");
            Console.Write(GuionPregunta);
            var Guion = ("Leigh Whannell"); 
            //Variables//
            var pelicula = new Pelicula();
            pelicula.Titulo = tituloPelicula;
            pelicula.PaisOrigen = Pais;
            pelicula.generoPelicula = Genero;
            pelicula.Estreno = anioEstreno;
            pelicula.Director = NameDirector;
            pelicula.Produccion = Productora;
            pelicula.personaMusica = Musica;
            pelicula.Fotografia = Foto;
            pelicula.PersonaGuion = Guion;

            ///////////////////////
            //Mensajes de consola//
            Console.WriteLine("*********Datos*********** \n");
            Console.Write("\n Titulo: " +pelicula.Titulo);
            Console.Write("\n Año en el que se estreno: " + pelicula.Estreno);
            Console.Write("\n Nombre del Director : " + pelicula.Director);
            Console.Write("\n Pais de origen: " + pelicula.PaisOrigen);
            Console.Write("\n Genero de la pelicula: " + pelicula.generoPelicula);
            Console.Write("\n Nombre de la productora : " + pelicula.Produccion);
            Console.Write("\n Personal Musical: " + pelicula.personaMusica);
            Console.Write("\n Personal Fotografia : " + pelicula.Fotografia);
            Console.Write("\n Personal Guion : " + pelicula.PersonaGuion);

            Console.Write("\n Gracias por su atencion, digite una tecla para terminar");
            Console.ReadKey();
        }
    }
}
