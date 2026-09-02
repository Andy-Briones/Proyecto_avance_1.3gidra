using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Pila
    {
        public Nodo cima = null;
        public int punt = 0;
        public void apilar2(int valor)
        {
            //1.CREAR NUEVO NODO
            Nodo nuevo = new Nodo();
            nuevo.Dato = valor;

            //2.APILAR NUEVO NODO
            if (cima == null)
            {
                cima = nuevo;
                punt += valor;
            }
            else
            {
                nuevo.sig = cima;
                cima = nuevo;
                punt += valor;
            }
        }
    }
}
