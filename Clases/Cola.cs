using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Cola
    {
        public Nodo frente = null;
        public Nodo final = null;

        public void Encolar(Material p)
        {
            //1. Crear nuevo Nodo
            Nodo nuevo = new Nodo();
            nuevo.dato = p;

            //2. encolar
            if (frente == null)
            {
                frente = nuevo;
                final = nuevo;
            }
            else
            {
                final.sig = nuevo;
                final = nuevo;
            }

        }

        public Material Desencolar()
        {
            if (frente != null)
            {
                Material p = frente.dato;

                frente = frente.sig;

                return p;
            }
            return null;
        }

        public bool EsVacio()
        {
            if (frente == null)
            {
                return true;
            }
            return false;
        }
        public void MostrarCola()
        {
            Nodo aux = frente;
            while (aux != null)
            {
                Console.WriteLine(aux.dato);
                aux = aux.sig;
            }

        }


    }
}
