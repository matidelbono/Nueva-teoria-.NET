using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoNuevosConceptos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejemplo Valores null
            Nullable<int> EnteroNulable = null;
            Nullable<double> PuedeQueValgaNull = 9.5;
            // Propiedades y metodos
            //Propiedades
            EnteroNulable = null;
            int ValorPorDefault = EnteroNulable.GetValueOrDefault();
            int ValorNoPorDefault = EnteroNulable.GetValueOrDefault(10);
            EnteroNulable = 100;
            int ValorReal = EnteroNulable.GetValueOrDefault();
            //Metodos:
            //Obtener valor
            EnteroNulable = 5;
            int ObtenerValor = EnteroNulable.Value;
            // Comprobar si tiene valor
            if (EnteroNulable.HasValue)
            {
                Console.WriteLine("tiene valor");
            }
            else
            {
                Console.WriteLine("no tiene valor");
            }
            // Ejemplo para getters y setters
            Persona persona = new Persona();
            persona.NombreApellido = "Matias Delbono";
            Console.WriteLine(persona.NombreApellido);
            Console.ReadLine();
            Datos_Personales datos = new Datos_Personales();
            datos.ReemplazarEdad(10);
            // Excepciones
            Console.WriteLine("ingresar un numero positivo");
            string ingreso = Console.ReadLine();

            try
            {
                  NumeroPositivo = int.Parse(ingreso);
            }
            catch(Exception e)
            {
                NumeroPositivo = -1;
            }
    }
}
