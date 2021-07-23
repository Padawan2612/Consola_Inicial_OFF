using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarlonFloresExamenWeb.Entities
{
    public class Estudiante
    {
        public int EstudianteId { get; set; }

        public string Nombre { get; set; }

        public Pareja Pareja { get; set; }
    }
}
