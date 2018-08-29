using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAreas
{
    class HijoCirculo:PadreFigura
    {
        public HijoCirculo()
        {
            mensajeArea = "El área del círculo en m^2 es";
        }
        public override Double Area()
        {
            return (Math.Pow(GetRadio_1(),2))*(3.1416);
        }

    }
}
