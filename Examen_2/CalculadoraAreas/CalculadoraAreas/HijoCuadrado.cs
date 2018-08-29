using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;        
using System.Threading.Tasks;

namespace CalculadoraAreas
{
    class HijoCuadrado : PadreFigura
    {
        public HijoCuadrado()
        {
            mensajeArea = "El área del cuadrado en m^2 es";
        }

        public override Double Area()
        {
            return GetRadio() * GetRadio();
        }
    }
}
