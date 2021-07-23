namespace InyeccionEjemplo
{
    class Program
    {
        static void Main(string[] args)
        {
            IServir almuerzo = new Sopa("Chifles");
            Mesero empleado = new Mesero(almuerzo);
            empleado.ServirPlato();
            
        }
    }
}
