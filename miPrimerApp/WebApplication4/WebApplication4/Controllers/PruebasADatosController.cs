using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using WebApplication4.Data;
using WebApplication4.Entities;

namespace WebApplication4.Controllers
{
    public class EmpleadoConversion
    {
        public string Nombre { get; set; }
        public string NombreCurso { get; set; }
    }
    public class PruebasADatosController : Controller // PruebasADatos/VerEmpleados
    {
        readonly ApplicationDbContext _context;
        public PruebasADatosController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IEnumerable<Empleado> VerEmpleados()
        {
            var empleados = _context
                .Empleados;
            return empleados.ToList();
        }
        // Ver de empleados solo el campo mencionado en select
        public IEnumerable<string> VerEmpleadosSelect()
        {
            var empleados = _context
                .Empleados
                .Select(z => z.Apellido);
            return empleados.ToList();
        }
        public IEnumerable<EmpleadoConversion> EmpleadosSelectMany()
        {
            IQueryable<Empleado> consultaEmpleados = _context.Empleados;

            IEnumerable<EmpleadoConversion> empleados = consultaEmpleados
                .SelectMany(
                h => h.Cursos, (empleado, curso) =>
                new EmpleadoConversion { Nombre = empleado.Nombre, NombreCurso = curso.Nombre }
                );
            return empleados.ToList();
        }
        public Empleado VerEmpleadosSingle()
        {
            Empleado empleados = _context.Empleados.Single(b => b.EmpleadoId == 1);
            return empleados;
        }
        public IEnumerable<Empleado> VerEmpleadosSkip()
        {
            IQueryable<Empleado> empleados = _context
                .Empleados
                .Skip(2)
                .Take(3);
            return empleados.ToList();
        }
        public IEnumerable<EmpleadoConversion> VerEmpleadosTake()
        {
            IEnumerable<EmpleadoConversion> empleados = _context.Empleados
                .Take(2)
                .Select(
                e => new EmpleadoConversion
                { Nombre = e.Nombre, NombreCurso = e.Nombre }
            );
            return empleados.ToList();
        }
        public IEnumerable<object> VerDatos()
        {
            IQueryable<Empleado> consulta = _context.Empleados;
            var resultado = consulta.Take(3).ToList();
            return resultado;
        }
        public IEnumerable<object> ObtenerEmpleadosCursos()
        {
            //ObjectSet<Contact> contacts = context.Contacts;
            //ObjectSet<SalesOrderHeader> orders = context.SalesOrderHeaders;
            //var query =
            //contacts.SelectMany(
            //    contact => orders.Where(order =>
            //        (contact.ContactID == order.Contact.ContactID)
            //            && order.TotalDue < totalDue)
            //        .Select(order => new
            //        {
            //            ContactID = contact.ContactID,
            //            LastName = contact.LastName,
            //            FirstName = contact.FirstName,
            //            OrderID = order.SalesOrderID,
            //            Total = order.TotalDue
            //        }));

          
            IQueryable<Empleado> consultaEmpleados = _context.Empleados;
            IQueryable<Conyuge> consultaConyuges = _context.Conyuges;

            IEnumerable<object> empleados = consultaEmpleados
                .SelectMany(
                e => consultaConyuges.Where(c => c.ConyugeId == 1 && e.DepartamentoId == 1));
            return empleados.ToList();
        }

        // Ejemplo de clase 
        public object Data()
        {
            var resultado1 = from emp in _context.Empleados
                             where emp.Apellido == "Curipoma"
                             select emp;
            //var resultado1 = _context.Empleados.Where(x => x.Apellido == "Curipoma");
            //return resultado.ToArray();
            return resultado1.ToArray();
        }
        public object Ejemplo1()
        {
            var consulta = from e in _context.Empleados
                           from h in _context.Hijos
                           where e.EmpleadoId == h.EmpleadoId
                           select e;
            return consulta.ToList();

            var consulta0 = from e in _context.Empleados
                            join h in _context.Hijos
                            on e.EmpleadoId equals h.EmpleadoId
                            select new { e.Apellido, NumeroHijos = e.Hijos.Count };

            var consulta1 = from e in _context.Empleados
                            from h in _context.Hijos
                            where e.EmpleadoId == h.EmpleadoId
                            select new { e.Apellido, NumeroHijos = e.Hijos.Count };
            return consulta1.ToArray();

            var consulta2 = _context.Empleados
                .Include(e => e.Hijos)
                .Select(e => new { e.Apellido, NumeroHijos = e.Hijos.Count });

            return consulta2.ToArray();
        }
        public Empleado Crear([Bind("EmpleadoId,Salario,Nombre,Apellido,DepartamentoId")] Empleado empleado)
        {
            _context.Add(empleado);
            _context.SaveChanges();

            // LazyLoad 
            // EagerLoader
            // ExplecityLoad

            _context.Entry(empleado).Collection(e => e.Hijos).Load();
            _context.Entry(empleado).Reference(e => e.Departamento).Load();


            return empleado;
        }
        public void Sample()
        {
            using (var otroContexto = new ApplicationDbContext(null))
            {
                if (otroContexto.Cursos.Any(c => c.NumeroCreditos > 100))
                {
                    // => Aquí pongo mi codigo <=
                }
            }
        }
    }
}