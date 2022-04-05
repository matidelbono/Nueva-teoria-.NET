using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepasoNuevosConceptos
{
    class VectorDeEnteros
    {
        private int[] Vector;
        public VectorDeEnteros()
        {
            Vector = new int[5];
        }
        public void CargaDelVector()
        {
            for (int p = 0; p<=Vector.Length; p++)
			{
                Console.WriteLine("ingrese el componente de la posicion" + p);
                Vector[p] = int.Parse(Console.ReadLine());
			}
			
        }
        public static VectorDeEnteros operator+ (VectorDeEnteros v1, VectorDeEnteros v2)
        {
            VectorDeEnteros SumadeVectores = new VectorDeEnteros();
            for (int p = 0; p <= SumadeVectores.Vector.Length; p++)
            {
                SumadeVectores.Vector[p] = v1.Vector[p] + v2.Vector[p];
            }
            return SumadeVectores;
        }
        public void ImprimirOperacion()
        {
            for (int p = 0; p <= Vector.Length; p++)
            {
                Console.WriteLine(Vector[p] + "");
            }
        }
    }
}