using System.Collections.Generic;
namespace ArbolNodosTarea
{
    class Nodo
    {
        public List<Nodo> Nodos { get; set; } = new List<Nodo>();
        public string Valor { get; set; }
        public List<Nodo> Hijos { get; set; } = new List<Nodo>();
        public int nivel;

        public int Raiz = 1;
    }
}

