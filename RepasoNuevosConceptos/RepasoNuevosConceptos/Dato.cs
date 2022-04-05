using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoNuevosConceptos
{
   public class Dato
    {
        public static int Sumador { get; set; }
        public int Sumar(int NumeroASumar)
        {
            Sumador = Sumador + NumeroASumar;
            return Sumador;
        }
    }
}
