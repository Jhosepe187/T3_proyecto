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

        public void Encolar(int p)
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

        public int Desencolar()
        {
            if (frente != null)
            {
                int p = frente.dato;

                frente = frente.sig;

                return p;
            }
            return;
        }

        public bool EsVacio()
        {
            if (frente == null)
            {
                return true;
            }
            return false;
        }
        public int MostrarCola()
        {
            if (frente != null)
            {
                return frente.dato;
            }
            return;
        }


    }
}
