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
            Console.WriteLine("ingrese el primer numero");
            int Numero1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el segundo numero");
            int Numero2 = int.Parse(Console.ReadLine());
            int Resultado = 0;
            try
            {
                Resultado = Numero1 / Numero2;
            }
            catch(Exception e)
            {
                Numero2 = 0;
            }
            finally
            {
                if (Numero2==0)
                {
                    Console.WriteLine("Se ha producido un error");
                }
            }
            // Clases Estáticas
            Estatica.Numero = 5;
            int Aleatorio = Estatica.ObtenerNumeroAlAzar();
            Console.ReadLine();
            //Miembros estáticos en clases comunes
            Dato PrimerDato = new Dato();
            PrimerDato.Sumar(3);
            Dato SegundoDato = new Dato();
            SegundoDato.Sumar(11);
            Console.ReadLine();
            // Métodos de Extensión en clases selladas
            Empleado empleado = new Empleado();
            bool ElCuitEsValido = empleado.CuitValido();
            Console.ReadLine();
            // Sobrecarga de Métodos
            VectorDeEnteros primero = new VectorDeEnteros();
            Console.WriteLine("Cargando el primer vector");
            primero.CargaDelVector();
            VectorDeEnteros segundo = new VectorDeEnteros();
            Console.WriteLine("Cargando el segundo vector");
            segundo.CargaDelVector();
            Console.WriteLine("imprimiendo el primer vector");
            primero.ImprimirOperacion();
            Console.WriteLine("imprimiendo el segundo vector");
            segundo.ImprimirOperacion();
            VectorDeEnteros SumaDeVectores = new VectorDeEnteros();
            SumaDeVectores = primero + segundo;
            Console.WriteLine("Vector resultante");
            SumaDeVectores.ImprimirOperacion();
            Console.ReadKey();

        }
}
}

