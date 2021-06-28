using System.Linq;
using System.Collections.Generic;
namespace ArbolNodosTarea
{
    internal class Contador
    {
        public static int ContadorHojas(Nodo nodo)
        {
            int contar = 0;
            foreach (Nodo nodo1 in nodo.Hijos)
            {
                contar = nodo1.Valor.Length + nodo1.Hijos.Count;

            }
            return contar;
        }

        public static int ContadorNodos(Nodo nodo)
        {
            int contar = nodo.Raiz + nodo.Hijos.Count;
            foreach (Nodo nodo1 in nodo.Hijos)
            {
                contar = nodo1.Hijos.Count;
            }
            return contar;
        }
        public static int ContadorNiveles(Nodo nodo)
        {
            int contar = 0;
            foreach (Nodo nodo1 in nodo.Hijos)
            {
                contar = nodo1.Valor.Length;
            }
            return contar;
        }
    }
}
