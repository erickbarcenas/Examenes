using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAreas
{
    class HijoTriangulo : PadreFigura
    {
        public HijoTriangulo()
        {
            mensajeArea = "El área del triángulo en m^2 es";
        }

        public override Double Area()
        {
            return (GetRadio() * GetAltura_1())*0.5;
        }
    }
}
