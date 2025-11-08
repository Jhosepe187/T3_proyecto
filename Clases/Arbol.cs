using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Arbol
    {
        public Nodo raiz_principal = null;

        private void InsertarRecursivo(ref Nodo raiz, Material material, int clave)
        {
            if (raiz == null)
            {
                Nodo nuevo = new Nodo();
                nuevo.datoMaterial = material;
                nuevo.claveClasificacion = clave;
                raiz = nuevo;
            }
            else
            {
                if (clave < raiz.claveClasificacion)
                {
                    InsertarRecursivo(ref raiz.izq, material, clave);
                }
                else if (clave > raiz.claveClasificacion)
                {
                    InsertarRecursivo(ref raiz.der, material, clave);
                }
                else
                {
                    Console.WriteLine($"Clave de clasificación duplicada: {clave}. Material '{material.Nombre}' no insertado.");
                }
            }
        }

        public void Insertar(Material material, int clave)
        {
            InsertarRecursivo(ref raiz_principal, material, clave);
            Console.WriteLine($"Material clasificado en el Árbol con clave {clave}: {material.Nombre}");
        }

        public void MostrarInorden(Nodo raiz)
        {
            if (raiz != null)
            {
                MostrarInorden(raiz.izq);
                Console.WriteLine($"- Clave: {raiz.claveClasificacion}, {raiz.datoMaterial.ToString()}");
                MostrarInorden(raiz.der);
            }
        }
        public void MostrarHistorialArbol()
        {
            if (raiz_principal == null)
            {
                Console.WriteLine("El Árbol de clasificación está vacío.");
            }
            else
            {
                Console.WriteLine("\nHistorial de Materiales Clasificados (Ordenado por Clave):");
                MostrarInorden(raiz_principal);
            }
        }
    }
}
