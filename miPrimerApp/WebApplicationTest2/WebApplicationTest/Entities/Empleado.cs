﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebApplicationTest.Entities
{
    public class Empleado
    {
        public int EmpleadoId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        [NotMapped]
        public string NombreCompleto { get { return $"{Nombre} {Apellido}"; } }
        public float Salario { get; set; }
        public DateTime Nacimiento { get; set; }
        [NotMapped]
        public double Edad { get { return DateTime.Now.Subtract(Nacimiento).TotalDays / 365; } }
        public Departamento Departamento { get; set; }
        public Conyuge Conyuge { get; set; }
        
        public List<Hijo> Hijos { get; set; }
    }
}
