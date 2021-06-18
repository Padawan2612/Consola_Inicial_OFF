using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido ");            
            //Nombre del usuario//
            Console.Write("Nombres del usuario: ");
            var Nombre = Console.ReadLine();            
            //Edad del usuario//
            Console.WriteLine("Edad del usuario: ");
            var edad = Console.ReadLine();
            int edad1 = int.Parse(edad);
            //Cedula//
            Console.WriteLine("Ingrese su numero de cedula: ");
            var Cedula = Console.ReadLine();
            //Nacionalidad//
            Console.Write("Ingrese su nacionalidad: ");
            var nacionalidad = Console.ReadLine();
            //Peso//
            Console.Write("ingrese su peso: ");
            float peso = float.Parse(Console.ReadLine());
            //Altura//
            Console.Write("ingrese su estatura: ");
            float Estatura = float.Parse(Console.ReadLine());
            //Carrera//
            Console.Write("Ingrese su ocupación o carrera actual: ");
            var carrera = Console.ReadLine();
            //ingresos//
            Console.Write("ingrese sus ingresos mensuales: ");
            float Ingresos = float.Parse(Console.ReadLine());
            //Numero de semestre//
            Console.Write("Ingrese el numero de semestre en el que esta: ");
            var curso = Console.ReadLine();
            int CursoActual = int.Parse(curso);            
            //Variables de la persona//
            var persona = new Persona();
            persona.nombre = Nombre;
            persona.edad = edad1;
            persona.peso = peso;
            persona.Carrera = carrera;
            persona.curso = CursoActual;
            persona.estatura = Estatura;
            persona.cedula = Cedula;
            persona.Nacionalidad = nacionalidad;
            persona.IngresoMensual = Ingresos;            
            
            Console.WriteLine("Usted ingreso los siguientes datos: \n");
            Console.Write("\n Nombre: " + persona.nombre);
            Console.Write("\n Edad: " + persona.edad + " Años");
            Console.Write("\n Cedula: " + persona.cedula);
            Console.Write("\n Nacionalidad: " + persona.Nacionalidad);
            Console.Write("\n Peso: " + persona.peso + " Kg");
            Console.Write("\n Estatura: " + persona.estatura + " cm");
            Console.Write("\n Carrera: " + persona.Carrera + " Instituto Tecnologico Yavirac");
            Console.Write("\n Semestre: " + persona.curso );
            Console.Write("\n Ingreso Mensual : " + persona.IngresoMensual + " $");
            Console.Write("\n Gracias por su atencion, digite una tecla para terminar");
            Console.ReadKey();
        }
    }
}
