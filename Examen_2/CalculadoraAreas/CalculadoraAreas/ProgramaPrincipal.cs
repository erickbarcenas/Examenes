using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculadoraAreas
{
    public partial class InterfazUsuarioForm : Form
    {
        public InterfazUsuarioForm()
        {
            InitializeComponent();
        }

        Boolean ActivarCuadrado = false;
        Boolean ActivarCirculo = false;
        Boolean ActivarTriangulo = false;

        HijoTriangulo hTriangulo = new HijoTriangulo();
        HijoCuadrado hCuadrado = new HijoCuadrado();
        HijoCirculo hCirculo = new HijoCirculo();

        private void RecogeFigura(object sender, EventArgs e)
        {
            if("Cuadrado" == cboTipoFigura.SelectedItem.ToString())
            {
                hCuadrado.Base_1 = Convert.ToDouble(txtBase.Text);


                ActivarCuadrado = true;

            }
            else if ("Círculo" == cboTipoFigura.SelectedItem.ToString())
            {
                hCuadrado.Base_1 = Convert.ToDouble(txtRadio.Text);
                ActivarCirculo = true;
            }
            else if("Triángulo" == cboTipoFigura.SelectedItem.ToString())
            {
                hCuadrado.Base_1 = Convert.ToDouble(txtBase.Text);
                hCuadrado.Altura_1 = Convert.ToDouble(txtAltura.Text);
                ActivarTriangulo = true;
            }
        }

        private void EnviarRespuesta(object sender, EventArgs e)
        {
            Double AreaFigura;

            if (ActivarCuadrado)
            {
                AreaFigura = hCuadrado.Area();
            }
            else if (ActivarCirculo)
            {
                // AreaFigura = Convert.ToString(hCirculo.);
                AreaFigura = hCirculo.Area();
            }
            else //ActivarTriangulo
            {
                // AreaFigura = Convert.ToString(hCirculo.);
                AreaFigura = hTriangulo.Area();
            }

            this.richTextBox1.Text = Convert.ToString(AreaFigura);

        }
    }
}
