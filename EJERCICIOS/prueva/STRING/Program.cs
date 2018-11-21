using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading.Tasks;

namespace STRING
{
    class Program
    {
        static void Main(string[] args)
        {
            ArbolB arbol = new ArbolB();

            Nodo raiz = arbol.Crear(6, null);                           
            // AL INSERTAR LOS NODOS SE EVALUAN       
            arbol.Crear(3, raiz); arbol.Crear(9, raiz);         
            arbol.Crear(2, raiz);  arbol.Crear(1, raiz);
            arbol.Crear(4, raiz);  arbol.Crear(5, raiz);
            arbol.Crear(7, raiz); arbol.Crear(8, raiz);
            arbol.Crear(10, raiz); arbol.Crear(11, raiz);
            Console.WriteLine("\n EJERCICIO 3 ARBOL BINARIO\n");
            arbol.Imprimir(raiz); // IMPRIME EL ARBOL 
            Console.Write("\n D || E || B || H || I || A || F || J || C || G  || K  ||\n");
            arbol.Orden(raiz); // EMPRIME LOS NUMEROS EN ORDEN  DE ESTREMO A EXTREMOS
            Console.WriteLine();
            Console.Write("\n D || E || B || H || I || F || J || C || G  || K  || A ||\n");
            arbol.PreOrden(raiz); // COMIENZA POR LOS NODOS IZQ Y DER Y AL FINAL LA RAIZ 
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
