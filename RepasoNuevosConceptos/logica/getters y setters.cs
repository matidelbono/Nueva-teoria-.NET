using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logica
{
    public class Class1
    {
        public DateTime FechaNacimiento { get; set; }
        public int Edad { get {
                return DateTime.Today.AddTicks(-FechaNacimiento.Ticks).Year - 1;
        }
}
    }
}
