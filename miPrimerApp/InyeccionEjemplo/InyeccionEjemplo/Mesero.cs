namespace InyeccionEjemplo
{
    class Mesero
    {
        IServir Sirve;
        public Mesero(IServir _comida)
        {
            this.Sirve = _comida;
        }
        public void ServirPlato()
        {
            this.Sirve.ServirPlato();
        }

    }
}
