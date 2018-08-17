using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_1
{
    class Clase_Division
    {
        public double Numero_d1 = 0;
        public double Numero_d2 = 0;

        public Clase_Division(double Numero_d1, double Numero_d2)
        {
            this.Numero_d1 = Numero_d1;
            this.Numero_d2 = Numero_d2;
        }

        public double Division_metodo()
        {
            return Numero_d1 / Numero_d2;
        }
    }
}
