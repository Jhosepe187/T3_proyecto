using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Material
    {
        public string Nombre { get; set; } 
        public string Tipo { get; set; }  
        public int Peso { get; set; }    


        public Material(string nombre, string tipo, int peso)
        {
            Nombre = nombre;
            Tipo = tipo;
            Peso = peso;

        }


        public override string ToString()
        {
            return $"Nombre: {Nombre}, Tipo: {Tipo}, Peso: {Peso}g, ";
        }
    }
}
