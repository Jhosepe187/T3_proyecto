using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Material
    {
        public string Tipo { get; set; }
        public string Nombre { get; set; }
        public int CodigoTipo { get; set; }

        public Material(string tipo, string nombre)
        {
            Tipo = tipo;
            Nombre = nombre;
            CodigoTipo = AsignarCodigo(tipo);
        }

        private int AsignarCodigo(string tipo)
        {
            tipo = tipo.ToLower();
            switch (tipo)
            {
                case "plastico":
                case "plástico":
                    return 1;
                case "vidrio":
                    return 2;
                case "papel":
                    return 3;
                case "metal":
                    return 4;
                default:
                    return 0; 
            }
        }

        public override string ToString()
        {
            return $"{CodigoTipo} - {Tipo} - {Nombre}";
        }
    }
}

