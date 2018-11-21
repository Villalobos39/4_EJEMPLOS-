using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class ArbolB
    {
        private Nodo Raiz { get; set; }
        private readonly Nodo Rama;
        private int contar = 0;
        public ArbolB() { Raiz = null; }
        
        public Nodo Crear(int dato , Nodo nodo)
        {
            Nodo temp = null;
            if (nodo==null)
            {
                temp = new Nodo();
                temp.Dato = dato;
                return temp;
            }
            if (dato<nodo.Dato)
            {
                nodo.Izq = Crear(dato, nodo.Izq);
            }
            if (dato>nodo.Dato)
            {
                nodo.Der = Crear(dato, nodo.Der);
            }
            return nodo;
        }

        public void Imprimir(Nodo nodo)
        {
            if (nodo == null) return;
            for (int cont = 0; cont < contar; cont++)
                Console.Write("-");
            Console.WriteLine(nodo.Dato);

            if (nodo.Izq!= null)
            {
                contar++; Console.Write("IZQ "); contar--;
            }
            //if (nodo.Der != null)
            //{
            //    contar++; Console.Write("DER "); contar--;
            //}
        }

        public void Orden(Nodo nodo)
        {
            if (nodo == null) return;
            if(nodo.Izq != null)
            {
                contar++; Orden(nodo.Izq); contar--;
            }
            Console.Write("{0} ", nodo.Dato);
            if(nodo.Der!=null)
            {
                contar++; Orden(nodo.Der); contar--;

            }

           
        }

    }
}
