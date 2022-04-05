using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoNuevosConceptos
{
    public static class Estatica
    {
        public static int ObtenerNumeroAlAzar()
        {
            return NumeroAleatorio = new Random().Next();

        }
        private static int NumeroAleatorio;
        public static int Numero
        {
            get { return NumeroAleatorio; }
            set { NumeroAleatorio = value; }
        }
    }
}
