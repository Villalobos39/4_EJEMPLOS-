using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRING
{
    class ArbolB
    {
        private Nodo Raiz { get; set; }
        private int contar = 0;
        public ArbolB() { Raiz = null; }

        // AQUI LOS EVALUAMOS 
        public Nodo Crear(int dato, Nodo nodo)
        { // SI EL DATO ES MAOR QUE LA RAIZ ENTONCES SE IRA A LA DERECHA O IZQUIERDA 
            Nodo temp = null;
            if (nodo == null)
            {
                temp = new Nodo();
                temp.Dato = dato;
                return temp;
            }
            // SI ES A LA IZQUIERDA ES MENOR 
            if (dato < nodo.Dato)
            {
                nodo.Izq = Crear(dato, nodo.Izq);
            }
            if (dato > nodo.Dato)
            { // SI ES MAYOR VA A LA DERECHA 
                nodo.Der = Crear(dato, nodo.Der);
            } 
            return nodo;
        }

        public void Imprimir(Nodo nodo)
        { // PARA IMPRIMIR EL ARBOL  // RETONAMOS LA RAIZ 
            if (nodo == null) return; // CON UN FOR CADA QUE SE MANDE  
            for (int cont = 0; cont < contar; cont++) Console.Write("-");
            // A LLAMAR EL METODO IMPRIMIR EL -- SE ACOMULA 
            Console.WriteLine(nodo.Dato);
            if (nodo.Izq != null)
            { // CUANDO EL NODO IZQUIERDO EXISTE SE IMPRIME  HACE UN METOD RECURSIVO 
                contar++; Console.Write("IZQ "); Imprimir(nodo.Izq); contar--;
            } // CON TODO LOS DATOS DE LA IZQUIERDA 
            if (nodo.Der != null)
            { // PARA IDENTIFICARLOS COLOQUE UNA DECRIBCION DE IZQ Y DER 
                contar++; Console.Write("DER "); Imprimir(nodo.Der); contar--;
            }
        }

        public void Orden(Nodo nodo)
        { // IMPRIME LOS NUMEROS EN ORDEN INICIO RAIZ 
            if (nodo == null) return;
            if (nodo.Izq != null)
            {
                contar++; Orden(nodo.Izq); contar--;
            } // LOS ACOMODAN DE MENOR A MAYOR 1,2,3...       
            Console.Write(" {0} ||", nodo.Dato);
            if (nodo.Der != null)
            {
                contar++; Orden(nodo.Der); contar--;
            }
        }

        public void PreOrden(Nodo nodo)
        {
            if (nodo == null) return;
            if (nodo.Izq != null)
            { // EN ESTE CADO LA RAIZ SE IMPRMIRA AL FINAL 
                contar++; Orden(nodo.Izq); contar--;
            }
            if (nodo.Der != null)
            { // SE VAN RECORRIENDO TODOS LOS NODOS DE LA IZQUIERDA Y LUEGO LA DERECHA 
                contar++; Orden(nodo.Der); contar--;
            } // Y POR ULTIMO LA RAIZ 
            Console.Write(" {0} ||" , nodo.Dato);
        }
    }
}
