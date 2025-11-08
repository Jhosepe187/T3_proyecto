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
        public void Encolar(Material material, int clave)
        {
            Nodo nuevo = new Nodo();
            nuevo.datoMaterial = material;
            nuevo.claveClasificacion = clave; 

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
            Console.WriteLine($"Material registrado en la cola: {material.Nombre}");
        }
        public Nodo Desencolar()
        {
            if (frente != null)
            {
                Nodo nodoAProcesar = frente;
                frente = frente.sig;
                if (frente == null)
                {
                    final = null; 
                }
                Console.WriteLine($"Material desencolado para procesamiento: {nodoAProcesar.datoMaterial.Nombre}");
                return nodoAProcesar;
            }
            return null; 
        }

        public bool EsVacio()
        {
            return frente == null;
        }
        public void MostrarFrente()
        {
            if (frente != null)
            {
                Console.WriteLine($"Material en el Frente de la Cola (Pendiente): {frente.datoMaterial.ToString()}");
            }
            else
            {
                Console.WriteLine("La cola de materiales pendientes está vacía.");
            }
        }
    }
}
