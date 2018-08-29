using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAreas
{
    abstract class PadreFigura
    {
        public Double ACuadrado;
        public Double ACirculo;
        public Double ATriangulo;

        protected const float PI = 3.1416f;

        protected Double base_1 = 0;
        protected Double altura_1 = 0;
        protected Double radio_1 = 0;

        //public bool isInitialized;

        public double Base_1 { get => base_1; set => base_1 = value; }
        public double Altura_1 { get => altura_1; set => altura_1 = value; }
        public double Radio_1 { get => radio_1; set => radio_1 = value; }

        /*    PadreFigura()
            {
                isInitialized = true;
            }*/


        //protected float PI = 3.1416f;


        /*
         //Cuadrado
        PadreFigura(Double Base)
        {
            this.Base = Base;
        }

         //Circulo
         PadreFigura(Double Radio, float PI)
         {
             this.Radio = Radio;
         }

         //Triangulo
         PadreFigura(Double Base, Double Altura)
         {
             this.Base = Base;
             this.Altura = Altura;
         }

     */

        public abstract Double Area();


        //protected abstract Double AreaCirculo();

        //protected abstract Double AreaTriangulo();


    }
}
