using System;

namespace VideoJuego
{
    partial class Program
        
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mi videojuego Favorito");
            //Pelicula favorita//
            var videojuegoFavorito = ("Como se llama tu videojuego favorito ?: \n");
            Console.Write(videojuegoFavorito);
            var tituloJuego = ("Mortal Kombat 9");
            //Pais//
            var anioLanzamiento = ("En que año fue lanzado ? : \n");
            Console.Write(anioLanzamiento);
            var anio = ("2011");
            //Genero//
            var TematicaPregunta = ("Que tematica tiene? : \n");
            Console.Write(TematicaPregunta);
            var Tematica = ("Peleas");
            //año de estreno//
            var creadores = ("Quienes lo crearon? : \n");
            Console.Write(creadores);
            var creadoresOriginales = ("Ed Boon y Jhon Tobias");
            //Director//
            var Disenio = ("Quienes lo diseñaron? : \n");
            Console.Write(Disenio);
            var diseniadores = ("Paul Garcia, Jhon Edwars, Dan Forden");
            //productora//
            var programadoresPregunta = ("Quienes lo programaron ? : \n");
            Console.Write(programadoresPregunta);
            var Programacion = ("Alexander Barrentino, Jay Biondo");
            //Musica//
            var escritura = ("Quien o quienes lo escribieron ? : \n");
            Console.Write(escritura);
            var escritores = ("Jhon Vogel, Bryan Chard");
            //Fotografia//
            var Plataformas = ("Para que plataformas se lanzo ? : \n");
            Console.Write(Plataformas);
            var plataformas = ("Xbox, PC , PS3");
            //Guion//
            var desarrolladora = ("Desarrolladora: \n");
            Console.Write(desarrolladora);
            var Desarrolladora_Off = ("NetherRealm Studios");
            //Variables//
            var Videojuego = new VideoGame();
            Videojuego.Nombre = tituloJuego;
            Videojuego.Lanzamiento = anio;
            Videojuego.Tema = Tematica;
            Videojuego.Autores = creadoresOriginales;
            Videojuego.encargoDisenio = diseniadores;
            Videojuego.Programadores = Programacion;
            Videojuego.Escritores = escritores;
            Videojuego.plataformasLanzadas = plataformas;
            Videojuego.Desarrolladora = Desarrolladora_Off;


            ///////////////////////
            //Mensajes de consola//
            Console.WriteLine("*********Datos*********** \n");
            Console.Write("\n Nombre: " + Videojuego.Nombre);
            Console.Write("\n Año en que se lanzo: " + Videojuego.Lanzamiento);
            Console.Write("\n Tematica del juego : " + Videojuego.Tema);
            Console.Write("\n Creadores: " + Videojuego.Autores);
            Console.Write("\n Diseñadores: " + Videojuego.encargoDisenio);
            Console.Write("\n Programadores : " + Videojuego.Programadores);
            Console.Write("\n Escritores: " + Videojuego.Escritores);
            Console.Write("\n Plataformas : " + Videojuego.plataformasLanzadas);
            Console.Write("\n Desarrolladora Oficial : " + Videojuego.Desarrolladora);

            Console.Write("\n Gracias por su atencion, digite una tecla para terminar");
            Console.ReadKey();
        }
    }
}

