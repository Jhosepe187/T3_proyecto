using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Nodo
    {
        public Material datoMaterial; 
        public int claveClasificacion; 

        public Nodo izq = null;
        public Nodo der = null;

        public Nodo sig = null;
    }
}
