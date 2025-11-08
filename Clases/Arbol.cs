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

        private void Insertar(ref Nodo raiz, Material m)
        {
            if (raiz == null)
            {
                Nodo nuevo = new Nodo();
                nuevo.dato = m;
                raiz = nuevo;
            }
            else
            {
                if (m.CodigoTipo < raiz.dato.CodigoTipo)
                    Insertar(ref raiz.izq, m);
                else if (m.CodigoTipo > raiz.dato.CodigoTipo)
                    Insertar(ref raiz.der, m);
                else
                {
                    if (string.Compare(m.Nombre, raiz.dato.Nombre, true) < 0)
                        Insertar(ref raiz.izq, m);
                    else
                        Insertar(ref raiz.der, m);
                }
            }
        }

        public void Insertar(Material m)
        {
            Insertar(ref raiz_principal, m);
        }

        private void MostrarEnOrden(Nodo raiz)
        {
            if (raiz != null)
            {
                MostrarEnOrden(raiz.izq);
                Console.WriteLine(raiz.dato);
                MostrarEnOrden(raiz.der);
            }
        }

        public void Mostrar()
        {
            MostrarEnOrden(raiz_principal);
        }
    }
}
