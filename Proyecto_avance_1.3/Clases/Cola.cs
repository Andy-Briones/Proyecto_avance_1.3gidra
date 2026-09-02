using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cola
    {
        public Nodo frente = null;
        public Nodo cola = null;
        public void Encolar(object Valor)
        {
            Nodo nuevo = new Nodo();
            nuevo.Dato = Valor;
            if (frente == null)
            {
                frente = nuevo;
                cola = nuevo;
            }
            else
            {
                cola.sig = nuevo;
                cola = nuevo;
            }
        }
        public object Descolar()
        {
            object valor = frente.Dato;
            frente = frente.sig;
            return valor;
        }
    }
}
