using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARBOL3
{
    class Imprimir
    {
        Arbol arbol = new Arbol();

        public void PrimerArbol()
        { // NODO RAIZ " E "
            Nodo raiz = arbol.InsertarNodo("A", null);      
            Nodo BRaiz = arbol.InsertarNodo("B", raiz);
            arbol.InsertarNodo("E", BRaiz);
            Nodo DRaiz = arbol.InsertarNodo("D", BRaiz);
            arbol.InsertarNodo("H", DRaiz);
            arbol.InsertarNodo("I", DRaiz);
            Nodo CRaiz = arbol.InsertarNodo("C", raiz);
            arbol.InsertarNodo("F", CRaiz);
            Nodo GRaiz = arbol.InsertarNodo("G", CRaiz);
            arbol.InsertarNodo("J", GRaiz);
            arbol.InsertarNodo("K", GRaiz);
            Console.WriteLine();
            arbol.Preorden(raiz);
            Console.Write("\n\t ALTURA: {0}\n", arbol.Altura()-1);
            arbol.PreordenLineal(raiz);
            Console.WriteLine();
           //Console.Write("\n\t NIVEL: {0}", arbol.Nivel());

          
        }
    }
}