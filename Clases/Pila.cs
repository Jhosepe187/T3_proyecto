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
        //apilar
        public void apilar(int d)
        {
            //1. Crear nodo
            Nodo nuevo = new Nodo();
            nuevo.dato = d;

            nuevo.sig = cima;
            cima = nuevo;
        }
        //desapilar
        public int desapilar()
        {
            if (cima != null)
            {
                int dato = cima.dato;

                cima = cima.sig;

                return dato;
            }
            else
            {
                
            }

        }


    }
}
