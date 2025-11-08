using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Material
    {
        string tipo;
        int Peso;
        string proveniencia;

        public Material(string tipo, int peso, string proveniencia)
        {
            this.tipo = tipo;
            Peso = peso;
            this.proveniencia = proveniencia;
        }
    }
}
