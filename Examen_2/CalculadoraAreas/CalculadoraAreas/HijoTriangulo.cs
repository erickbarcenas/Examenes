using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAreas
{
    class HijoTriangulo : PadreFigura
    {
        public override Double Area()
        {
            return (Base_1*Altura_1)*0.5;
        }
    }
}
