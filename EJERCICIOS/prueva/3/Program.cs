using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolB arbol = new ArbolB();
            Nodo raiz = arbol.Crear(7, null);
            arbol.Crear(1, raiz);
            arbol.Crear(2, raiz);
            arbol.Crear(3, raiz); arbol.Crear(4, raiz);
            arbol.Crear(5, raiz); arbol.Crear(6, raiz);
            arbol.Crear(7, raiz); arbol.Crear(8, raiz);
            arbol.Crear(9, raiz); arbol.Crear(10, raiz);

            arbol.Imprimir(raiz);
            arbol.Orden(raiz);
            Console.ReadKey();
            
        }
    }
}
