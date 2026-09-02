using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Nodo
    {
        public object Dato;
        public string Dato2;
        public Persona Per;
        public Nodo sig = null;
        public Nodo izq = null;
        public Nodo der = null;
    }
}
