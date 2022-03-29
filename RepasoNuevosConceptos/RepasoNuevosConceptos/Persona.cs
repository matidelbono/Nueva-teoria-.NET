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
                // Aqui se hace que solo la clase persona pueda setear las propiedades "nombre" y "Apellido"
                this.nombre = value.Split()[0];
                this.Apellido = value.Split()[1];
            }
}
    }
}
