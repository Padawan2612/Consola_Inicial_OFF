using System.Collections.Generic;

namespace WebApplication4.Entities
{
    public class Curso
    {
        public int CursoId { get; set; }
        public string Nombre { get; set; }
        public int NumeroCreditos { get; set; }
        public List<Empleado> Empleados { get; set; }
        public Institucion Institucion { get; set; }
    }
}