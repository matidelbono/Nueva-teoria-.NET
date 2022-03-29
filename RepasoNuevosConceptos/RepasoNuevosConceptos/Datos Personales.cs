using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoNuevosConceptos
{
    class Datos_Personales
    {
        public DateTime FechadeNacimiento { get; set; }
        public int Edad { get; private set; }
        public Datos_Personales()
        {
        }
        ~Datos_Personales()
        {
            Console.WriteLine("Se destruirà al objeto Datos Personales");
        }


    public void ReemplazarEdad(int nuevaEdad)
        {
            this.Edad = nuevaEdad;
        }
    }
  
