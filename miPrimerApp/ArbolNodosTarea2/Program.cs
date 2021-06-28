using System;

namespace ArbolNodosTarea
{
    partial class Program
    {
        static void Main(string[] args)

        {
            Nodo raiz = new()
            {

                Valor = "/",
                nivel = 0,
                Hijos ={
                    new Nodo{
                        Valor="-",
                        Hijos={
                            new Nodo{
                                Valor="1"
                            },
                            new Nodo{
                                Valor ="8"
                            }
                        }
                    },
                    new Nodo{
                        Valor ="*",
                        Hijos={
                            new Nodo{
                                Valor="0"
                            },
                            new Nodo{
                                Valor="3"
                            }
                        }
                    },
                    new Nodo{
                        Valor="+",
                        Hijos={
                            new Nodo{
                                Valor="1"
                            },
                            new Nodo{
                                Valor="9"
                            }

                        }
                    }



                },
            };

            Contador contarArbol = new();
            Console.WriteLine($"las hojas del arbol son de : {Contador.ContadorHojas(raiz)}");
            Console.WriteLine($"los niveles del arbol son de : {Contador.ContadorNiveles(raiz)}");
            Console.WriteLine($"los nodos totales en el arbol es de : {Contador.ContadorNodos(raiz)}");
        }
    }
}
