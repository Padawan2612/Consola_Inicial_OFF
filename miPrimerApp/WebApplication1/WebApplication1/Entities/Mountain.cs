using System.ComponentModel;

namespace WebApplication1.Entities
{
    public class Mountain
    {
        public int MountainId{ get; set; }
        [DisplayName("Nombre de la montaña")]
        public string Nombre { get; set; }
        [DisplayName("Altitud de la montaña")]
        public int Altitud { get; set; }
    }
}
