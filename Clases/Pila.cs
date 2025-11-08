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
        public void Apilar(Material material)
        {
            Nodo nuevo = new Nodo();
            nuevo.datoMaterial = material;

            nuevo.sig = cima;
            cima = nuevo;
        }
        public Material Desapilar()
        {
            if (cima != null)
            {
                Material dato = cima.datoMaterial;
                cima = cima.sig;
                return dato;
            }
            return null; 
        }

        public bool EsVacio()
        {
            return cima == null;
        }
    }
}