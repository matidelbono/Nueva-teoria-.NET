using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoNuevosConceptos
{
    public sealed class Empleado
    {
        public string CUIT{ get; set; }
    }
    public static class ExtensionesDeEmpleados
        {
            public static bool CuitValido(this Empleado empleado)
            {
                return empleado.CUIT.Length == 11;

            }
        }
    }

