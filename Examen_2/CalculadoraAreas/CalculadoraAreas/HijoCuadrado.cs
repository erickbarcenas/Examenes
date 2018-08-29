using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAreas
{
    class HijoCuadrado : PadreFigura
    {
        public override Double Area()
        {
            return Base_1 * Base_1;
        }
    }
}
