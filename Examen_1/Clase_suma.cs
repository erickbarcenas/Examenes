using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1
{
    class Clase_suma
    {
        public double Numero_s1 = 0;
        public double Numero_s2 = 0;

        public Clase_suma(double Numero_s1, double Numero_s2)
        {
            this.Numero_s1 = Numero_s1;
            this.Numero_s2 = Numero_s2;
        }

        public double Suma_metodo()
        {
            return Numero_s1 + Numero_s2;
        }


    }
}
