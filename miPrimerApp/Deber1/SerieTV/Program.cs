using System;

namespace Serie_TV
{
    partial class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mi serie Tv favorita");
            //Pelicula favorita//
            var seriePregunta = ("Como se llama tu serie favorito ?: \n");
            Console.Write(seriePregunta);
            var TituloSerie = ("Malcom in the middle");
            //Pais//
            var anioEstreno = ("En que año fue su estreno ? : \n");
            Console.Write(anioEstreno);
            var anio = ("2000");
            //Genero//
            var protagonistaPregunta = ("su protagonista principal ? : \n");
            Console.Write(protagonistaPregunta);
            var protagonistaPrincipal = ("Frankie Muniz");
            //año de estreno//
            var creadorPregunta = ("Quien lo creo ? : \n");
            Console.Write(creadorPregunta);
            var creadorOriginal = ("Linwood Boomer");
            //Director//
            var duracionPregunta = ("Cuanto dura cada capitulo ? : \n");
            Console.Write(duracionPregunta);
            var duracion = ("21 a 23 minutos");
            //productora//
            var temporadasPregunta = ("Cuantas temporadas tiene : \n");
            Console.Write(temporadasPregunta);
            var temporadas = ("7 temporadas");
            //Musica//
            var episodiosPregunta = ("Cuantos episodios ? : \n");
            Console.Write(episodiosPregunta);
            var episodios = ("151 episodios");
            //Fotografia//
            var productoraPregunta = ("Cual fue su empresa productora? : \n");
            Console.Write(productoraPregunta);
            var productora = ("Fox Television Studios");
            //Guion//
            var fechaSalida = ("Fecha de su ultima emision: \n");
            Console.Write(fechaSalida);
            var ultimaEmision = ("14 de mayo de 2006");
            //Variables//
            var serieTV = new Serie();
            serieTV.nombreSerie = TituloSerie;
            serieTV.Estreno = anio;
            serieTV.nombreProtagonista = protagonistaPrincipal;
            serieTV.creadorOfficial = creadorOriginal;
            serieTV.duracionCapitulo = duracion;
            serieTV.numeroTemporadas = temporadas;
            serieTV.episodiosTotales = episodios;
            serieTV.Productora = productora;
            serieTV.emisionFinal = ultimaEmision;
            ///////////////////////
            //Mensajes de consola//
            Console.WriteLine("*********Datos*********** \n");
            Console.Write("\n Nombre: " + serieTV.nombreSerie);
            Console.Write("\n Año estreno en TV: " + serieTV.Estreno);
            Console.Write("\n Protagonizado por : " + serieTV.nombreProtagonista);
            Console.Write("\n Creador original: " + serieTV.creadorOfficial);
            Console.Write("\n Duracion por capitulo: " + serieTV.duracionCapitulo);
            Console.Write("\n Temporadas : " + serieTV.numeroTemporadas);
            Console.Write("\n Episodios: " + serieTV.episodiosTotales);
            Console.Write("\n Producido por : " + serieTV.Productora);
            Console.Write("\n Emision Final: " + serieTV.emisionFinal);

            Console.Write("\n Gracias por su atencion, digite una tecla para terminar");
            Console.ReadKey();
        }
    }
}
