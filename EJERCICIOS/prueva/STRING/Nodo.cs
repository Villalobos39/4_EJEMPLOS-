using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STRING
{
    class Nodo
    {
        internal Nodo Izq { get; set; } //LOS PARAMEROS DE NODO 
        internal Nodo Der { get; set; } // DECLARO LAS PROPIEDADES PARA LOS NODOS 
        public int Dato { get; set; } // ESTA VARIABLES ES PARA LOS ELEMENTOS DEL ARBOL
        public Nodo()
        {
            Dato = 0;
            Izq = null;
            Der = null;
        }

    }
}
