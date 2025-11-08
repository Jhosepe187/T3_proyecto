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

        private void insertar(ref Nodo raiz, int d)
        {
            if (raiz == null)
            {
                Nodo nuevo = new Nodo();
                nuevo.dato = d;

                raiz = nuevo;
            }
            else
            {
                if (d < raiz.dato)
                {
                    insertar(ref raiz.izq, d);
                }
                else if (d > raiz.dato)
                {

                    insertar(ref raiz.der, d);
                }
                else
                {
                    Console.WriteLine("Dato duplicado");
                }
            }
        }
        public void Insertar(int d)
        {
            insertar(ref raiz_principal, d);
        }

        private void dibujar(Nodo raiz, int nivel)
        {
            if (raiz != null)
            {
                dibujar(raiz.der, nivel + 1);
                for (int i = 0; i < nivel; i++)
                {
                    Console.Write("    ");
                }
                Console.WriteLine(raiz.dato);
                dibujar(raiz.izq, nivel + 1);
            }
        }
        public void Dibujar()
        {
            dibujar(raiz_principal, 0);
        }

        private void buscar(Nodo raiz, int d)
        {
            if (raiz == null)
            {
                Console.WriteLine("No encontrado");
            }
            else
            {
                if (d < raiz.dato)
                {
                    buscar(raiz.izq, d);
                }
                else if (d > raiz.dato)
                {

                    buscar(raiz.der, d);
                }
                else
                {
                    Console.WriteLine("Dato encontrado");
                }
            }
        }

        public void Buscar(int d)
        {
            buscar(raiz_principal, d);
        }
        private void eliminar(ref Nodo raiz, int d)
        {
            if (raiz == null)
            {
                Console.WriteLine("No encontrado");
            }
            else
            {
                if (d < raiz.dato)
                {
                    eliminar(ref raiz.izq, d);
                }
                else if (d > raiz.dato)
                {

                    eliminar(ref raiz.der, d);
                }
                else
                {
                    if (raiz.izq == null && raiz.der == null)
                    {
                        raiz = null;
                    }
                    else if (raiz.izq != null && raiz.der == null)
                    {

                        Nodo temp = BuscarMayor(raiz.izq);

                        int aux = temp.dato;
                        temp.dato = raiz.dato;
                        raiz.dato = aux;

                        eliminar(ref raiz.izq, d);
                    }
                    else
                    {

                        Nodo temp = BuscarMenor(raiz.der);

                        int aux = temp.dato;
                        temp.dato = raiz.dato;
                        raiz.dato = aux;

                        eliminar(ref raiz.der, d);
                    }
                }
            }
        }
        public void Eliminar(int d)
        {
            eliminar(ref raiz_principal, d);
        }

        private Nodo BuscarMayor(Nodo raiz)
        {
            if (raiz.der == null)
            {
                return raiz;
            }
            else
            {
                return BuscarMayor(raiz.der);
            }
        }
        private Nodo BuscarMenor(Nodo raiz)
        {
            if (raiz.izq == null)
            {
                return raiz;
            }
            else
            {
                return BuscarMenor(raiz.izq);
            }
        }

    }
}
