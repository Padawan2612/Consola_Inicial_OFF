using System;

namespace DeberNumero1

{
    partial class Program
    {
        static void Main(string[] args)
            
        {
            Console.WriteLine("Mi anime Favorito");
            //anime favorita//
            var animePregunta = ("Cual es tu anime Favorito ?: \n");
            Console.Write(animePregunta);
            var anime = ("Jojos Bizarre adventure");
            //genero//
            var GeneroAnime = ("Que tipo de genero es? : \n");
            Console.Write(GeneroAnime);
            var AnimeGenero = ("Accion,Aventura,fantansia");
            //oublicacion//
            var Aniopublicacion = ("En que año fue su primera publicacion ? : \n");
            Console.Write(Aniopublicacion);
            var Publicacion = ("1987");
            //Autor//
            var Creador = ("Quien lo creó ? : \n");
            Console.Write(Creador);
            var CreadorOriginal = ("Hirojiko Haraki");
            //Volumenes//
            var Volumenes = ("Cuantos volumenes tiene ? : \n");
            Console.Write(Volumenes);
            var volumenesTotales = ("129 volumenes");
            //productora//
            var estudioPregunta = ("Que estudio adapto el manga? : \n");
            Console.Write(estudioPregunta);
            var Estudio = ("David Productions");
            //estreno TV//
            var fechaEstreno = ("Que fecha se emitio el primer capitulo del anime ? : \n");
            Console.Write(fechaEstreno);
            var Fecha = ("5 Octubre de 2021");
            //capitulos//
            var capitulosPregunta = ("Cuantos capitulos tiene en total la animacion: \n");
            Console.Write(capitulosPregunta);
            var capitulos = ("155 capitulos");
            //proyectos//
            var adaptacion = ("Habra alguna nueva emicion ?: \n");
            Console.Write(adaptacion);
            var Adaptacion = ("Stone Ocean");
            //Variables//
            var Anime = new anime();
            Anime.animeNombre = anime;
            Anime.generoAnime= AnimeGenero;
            Anime.publicacion = Publicacion;
            Anime.creacion = CreadorOriginal;
            Anime.Volumen = volumenesTotales;
            Anime.EstudioAdaptacion = Estudio;
            Anime.EstrenoTV = Fecha;
            Anime.numeroCapitulos = capitulos;
            Anime.nuevasAdaptaciones = Adaptacion;

            ///////////////////////
            //Mensajes de consola//
            Console.WriteLine("*********Datos*********** \n");
            Console.Write("\n Titulo: " + Anime.animeNombre);
            Console.Write("\n Genero: " + Anime.generoAnime);
            Console.Write("\n Año de su primera publicacion : " + Anime.publicacion);
            Console.Write("\n Autor original: " + Anime.creacion);
            Console.Write("\n Volumenes del manga: " + Anime.Volumen);
            Console.Write("\n Estudio : " + Anime.EstudioAdaptacion);
            Console.Write("\n Estreno en TV: " + Anime.EstrenoTV);
            Console.Write("\n Total capitulos : " + Anime.numeroCapitulos);
            Console.Write("\n Nuevas adaptaciones : " + Anime.nuevasAdaptaciones);

            Console.Write("\n Gracias por su atencion, digite una tecla para terminar");
            Console.ReadKey();
        }
    }
}

