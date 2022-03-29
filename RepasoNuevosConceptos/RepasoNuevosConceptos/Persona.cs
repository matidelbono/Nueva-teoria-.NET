using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoNuevosConceptos
{
    class Persona
    {
        private string nombre { get; set; }
        private string Apellido { get; set; }
        public String NombreApellido
        {
            get
          {
                return $"{nombre},{Apellido}";
            }
            set
            {
                this.nombre = value.Split()[0];
                this.Apellido = value.Split()[1];
            }
}
    }
}
