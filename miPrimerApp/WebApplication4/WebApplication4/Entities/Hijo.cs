using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplication4.Entities
{
    public class Hijo
    {
        public int HijoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [ForeignKey("Empleado")]
        public int EmpleadoId { get; set; }
        public Empleado Empleado { get; set; }
    }
}