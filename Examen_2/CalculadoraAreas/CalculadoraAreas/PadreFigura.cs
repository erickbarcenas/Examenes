using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraAreas
{
    abstract class PadreFigura
    {
        protected Double base_1;
        protected Double altura_1;
        protected Double radio_1;
        protected string nombre_1;
        protected string mensajeArea;

        public PadreFigura()
        {
            mensajeArea = "El area en m^2 es";

    }



        public string Nombre_1 { get => nombre_1; set => nombre_1 = value; }
        public string MensajeArea { get => mensajeArea; set => mensajeArea = value; }

        //public bool isInitialized;
        public void SetBase_1(Double base_1)
        {
            this.base_1 = base_1;
        }

        public Double GetRadio()
        {
            return base_1;
        }

        public void SetAltura_1(Double altura_1)
        {
            this.altura_1 = altura_1;
        }

        public Double GetAltura_1()
        {
            return altura_1;
        }

        public void SetRadio_1(Double radio_1)
        {
            this.radio_1 = radio_1;
        }

        public Double GetRadio_1()
        {
            return radio_1;
        }

        public abstract Double Area();



    }
}
