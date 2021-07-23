using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationTest.Entities
{
    public class Conyuge
    {
        public int ConyugeId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        [ForeignKey("Empleado")]
        [DisplayName("Empleado")]

        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
    }
}
