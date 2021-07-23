using System;


namespace InyeccionEjemplo
{
    public class PlatoSecundario : IServir
    {
        public void ServirPlato()
        {
            Console.WriteLine("Le sirve al cliente el plato secundario");
        }
    }
}
