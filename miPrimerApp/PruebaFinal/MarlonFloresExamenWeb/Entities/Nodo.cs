using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarlonFloresExamenWeb.Entities
{
    public class Nodo
    {
        public double Valor { get; set; }
        public List<Nodo> NodosHijos { get; set; } = new List<Nodo>();
        public static double Navegar(Nodo nodo)

        {

            if (!nodo.NodosHijos.Any())

            {

                return nodo.Valor;

            }

            var valores = new List<double> { nodo.Valor };

            foreach (var item in nodo.NodosHijos)

            {
                valores.Add(Navegar(item));

            }

            return valores.Max();

        }
    }

}
