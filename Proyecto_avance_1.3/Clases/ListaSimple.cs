using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class ListaSimple
    {
        public Nodo primero = null;
        public void insertar(Persona valor)
        {
            if (Unico_Valor(valor))
            {
                return;
            }
            Nodo nuevo = new Nodo();
            nuevo.Per = valor;
            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                Nodo temp = primero;

                while (temp.sig != null)
                {
                    temp = temp.sig;
                }
                temp.sig = nuevo;
            }
        }
        public bool Unico_Valor(Persona busq)
        {
            Nodo temp = primero;
            while (temp != null)
            {
                if (busq == temp.Per)
                {
                    return true;
                }
                temp = temp.sig;
            }
            return false;
        }
    }
}
