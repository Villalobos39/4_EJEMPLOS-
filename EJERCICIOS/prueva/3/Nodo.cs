using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Nodo
    {
      
        internal Nodo Izq { get; set; }
        internal Nodo Der { get; set; }
        public int Dato { get; set; } 
        public Nodo ()
        {
            Dato = 0;
            Izq = null;
            Der = null;
        }
        
    }
}
