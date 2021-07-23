using System;

namespace InyeccionEjemplo
{
    public class Sopa: IServir
        
    {
        public string Acompaniante { get; set; }
        public Sopa(string acompaniante)
        {
            this.Acompaniante = acompaniante;
        }
        public void ServirPlato()
        {
            Console.WriteLine("Sirve la sopa con " + Acompaniante);
        }
    }
}
