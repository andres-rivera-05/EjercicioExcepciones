using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioExcepciones
{
    internal class Operaciones
    {
        public double Suma(double N1, double N2) { 
            return N1 + N2; 
        }

        public double Resta(double N1, double N2)
        {
            return N1 - N2;
        }

        public double Multipicacion(double N1, double N2)
        {
            return N1 * N2;
        }

        public double Divicion(double N1, double N2)
        {

            if (N2 == 0) {
                throw new DivideByZeroException();
            }
            return N1 / N2;
        }
    }
}
