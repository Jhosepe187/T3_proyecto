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
        static void Main(string[] args)
        {
            Cola cola = new Cola();
            Pila pila = new Pila();
            Arbol arbol = new Arbol();

            int opcion;
            do
            {
                Console.Clear();
                Console.WriteLine("SISTEMA DE RECICLAJE");
                Console.WriteLine("1. Registrar material");
                Console.WriteLine("2. Mostrar cola de materiales");
                Console.WriteLine("3. Procesar materiales");
                Console.WriteLine("4. Mostrar materiales clasificados");
                Console.WriteLine("5. Mostrar historial");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                
                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    opcion = 0;
                }

                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        RegistrarMaterial(cola);
                        break;

                    case 2:
                        Console.WriteLine("COLA DE MATERIALES");
                        if (cola.EsVacio())
                            Console.WriteLine("No hay materiales registrados.");
                        else
                            cola.MostrarCola();
                        break;

                    case 3:
                        ProcesarMateriales(cola, arbol, pila);
                        break;

                    case 4:
                        Console.WriteLine("MATERIALES CLASIFICADOS");
                        arbol.Mostrar();
                        break;

                    case 5:
                        Console.WriteLine("HISTORIAL DE MATERIALES PROCESADOS");
                        pila.Mostrar();
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del programa");
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Intente nuevamente.");
                        break;
                }

                if (opcion != 6)
                {
                    Console.WriteLine("\nPresione cualquier tecla para continuar");
                    Console.ReadKey();
                }

            } while (opcion != 6);
        }

        static void RegistrarMaterial(Cola cola)
        {
            Console.WriteLine("REGISTRAR NUEVO MATERIAL");
            Console.WriteLine("Tipos disponibles:");
            Console.WriteLine("1. Plástico");
            Console.WriteLine("2. Vidrio");
            Console.WriteLine("3. Papel");
            Console.WriteLine("4. Metal");

            Console.Write("Ingrese el tipo de material (1-4): ");
            int tipoNum;
            if (!int.TryParse(Console.ReadLine(), out tipoNum) || tipoNum < 1 || tipoNum > 4)
            {
                Console.WriteLine("Tipo inválido. Operación cancelada.");
                return;
            }

            string tipoTexto = "";
            switch (tipoNum)
            {
                case 1:
                    tipoTexto = "Plástico";
                    break;
                case 2:
                    tipoTexto = "Vidrio";
                    break;
                case 3:
                    tipoTexto = "Papel";
                    break;
                case 4:
                    tipoTexto = "Metal";
                    break;
                default:
                    tipoTexto = "Desconocido";
                    break;
            }

            Console.Write("Ingrese el nombre del material: ");
            string nombre = Console.ReadLine();

            Material nuevo = new Material(tipoTexto, nombre);
            cola.Encolar(nuevo);

            Console.WriteLine($"Material '{nombre}' de tipo '{tipoTexto}' registrado correctamente.");
        }


        static void ProcesarMateriales(Cola cola, Arbol arbol, Pila pila)
        {
            Console.WriteLine("PROCESANDO MATERIALES");
            if (cola.EsVacio())
            {
                Console.WriteLine("No hay materiales en la cola para procesar.");
                return;
            }

            while (!cola.EsVacio())
            {
                Material m = cola.Desencolar();
                arbol.Insertar(m);
                pila.Apilar(m);
                Console.WriteLine($"Procesado: {m}");
            }

            Console.WriteLine("\nTodos los materiales han sido clasificados y registrados en el historial.");
        }
    }
}

