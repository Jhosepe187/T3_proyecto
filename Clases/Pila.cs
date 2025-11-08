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

        public void Apilar(Material m)
        {
            Nodo nuevo = new Nodo();
            nuevo.dato = m;
            nuevo.sig = cima;
            cima = nuevo;
        }

        public Material Desapilar()
        {
            if (cima != null)
            {
                Material m = cima.dato;
                cima = cima.sig;
                return m;
            }
            return null;
        }

        public void Mostrar()
        {
            Nodo aux = cima;
            while (aux != null)
            {
                Console.WriteLine(aux.dato);
                aux = aux.sig;
            }
        }
    }
}

