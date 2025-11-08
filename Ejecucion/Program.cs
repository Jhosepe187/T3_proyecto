using Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejecucion
{
    internal class Program
    {        
        static Cola colaMateriales = new Cola();        
        static Arbol arbolClasificacion = new Arbol();  
        static Pila pilaVistas = new Pila();            

        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de Reciclaje Inteligente");
            MenuPrincipal();
        }

        static void MenuPrincipal()
        {
            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Registrar Material ");
                Console.WriteLine("2. Procesar y Clasificar Material");
                Console.WriteLine("3. Ver Historial de Vistas");
                Console.WriteLine("4. Mostrar Historial de Clasificación");
                Console.WriteLine("5. Salir");
                Console.Write("Opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        RegistrarMaterial();
                        break;
                    case "2":
                        ProcesarMaterial();
                        break;
                    case "3":
                        VerHistorialPila();
                        break;
                    case "4":
                        arbolClasificacion.MostrarHistorialArbol();
                        break;
                    case "5":
                        salir = true;
                        Console.WriteLine("Gracias por usar el Sistema de Reciclaje");
                        break;
                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }
        static void RegistrarMaterial()
        {
            Console.WriteLine("\nRegistro de Nuevo Material");
            Console.Write("Nombre del material (ej: Botella, Papel, etc): ");
            string nombre = Console.ReadLine();

            Console.Write("Tipo de material (ej: Plástico, Papel, Vidrio): ");
            string tipo = Console.ReadLine();

            Console.Write("Peso en gramos: ");
            if (!int.TryParse(Console.ReadLine(), out int peso))
            {
                Console.WriteLine("Peso no válido. Se usará");
                peso = 0;
            }

                  
            int clave = 99;
            string tipoLower = tipo.ToLower();
            if (tipoLower.Contains("papel") || tipoLower.Contains("cartón")) clave = 1;
            else if (tipoLower.Contains("plástico") || tipoLower.Contains("plastico")) clave = 2;
            else if (tipoLower.Contains("vidrio")) clave = 3;
            else if (tipoLower.Contains("metal")) clave = 4;

            Material nuevoMaterial = new Material(nombre, tipo, peso);
            colaMateriales.Encolar(nuevoMaterial, clave);
        }
        static void ProcesarMaterial()
        {
            Console.WriteLine("\nProcesamiento y Clasificación de Material");

            Nodo nodoAClasificar = colaMateriales.Desencolar();

            if (nodoAClasificar != null)
            {
                Material material = nodoAClasificar.datoMaterial;
                int clave = nodoAClasificar.claveClasificacion;
             
                arbolClasificacion.Insertar(material, clave);

                pilaVistas.Apilar(material);
                Console.WriteLine($"Material procesado y clasificado en el Árbol bajo la clave {clave}.");
            }
            else
            {
                Console.WriteLine("La cola de materiales pendientes está vacía. No hay nada que procesar");
            }
        }
        static void VerHistorialPila()
        {
            Console.WriteLine("Historial de Vistas Recientes");
            if (pilaVistas.EsVacio())
            {
                Console.WriteLine("El historial de vistas recientes está vacío");
                return;
            }
            Pila pilaTemporal = new Pila();
            Material materialVisto;
            int contador = 1;

            while (!pilaVistas.EsVacio())
            {
                materialVisto = pilaVistas.Desapilar();
                Console.WriteLine($"(#{contador++}) {materialVisto.ToString()}");
                pilaTemporal.Apilar(materialVisto); 
            }

            while (!pilaTemporal.EsVacio())
            {
                materialVisto = pilaTemporal.Desapilar();
                pilaVistas.Apilar(materialVisto);
            }
        }
    }
}