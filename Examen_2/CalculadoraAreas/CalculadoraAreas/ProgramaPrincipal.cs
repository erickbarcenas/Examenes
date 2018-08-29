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
        string mensajeTipoFigura;

        HijoTriangulo hTriangulo = new HijoTriangulo();
        HijoCuadrado hCuadrado = new HijoCuadrado();
        HijoCirculo hCirculo = new HijoCirculo();

        private void RecogeFigura(object sender, EventArgs e)
        {
            if("Cuadrado" == cboTipoFigura.SelectedItem.ToString())
            {
                txtAltura.Enabled = false;
                txtBase.Enabled = true;
                txtRadio.Enabled = false;
                ActivarCuadrado = true;
                this.labelAltura.Enabled = false;
                this.labelRadio.Enabled = false;



            }
            else if ("Círculo" == cboTipoFigura.SelectedItem.ToString())
            {
                txtAltura.Enabled = false;
                txtBase.Enabled = false;
                txtRadio.Enabled = true;
                ActivarCirculo = true;
                this.labelBase.Enabled = false;
                this.labelAltura.Enabled = false;


            }
            else if("Triángulo" == cboTipoFigura.SelectedItem.ToString())
            {
                txtAltura.Enabled = true;
                txtBase.Enabled = true;
                txtRadio.Enabled = false;
                txtRadio.Enabled = false;
                ActivarTriangulo = true;
                this.labelRadio.Enabled = false;
            }
        }

        private void EnviarRespuesta(object sender, EventArgs e)
        {
            Double AreaFigura;

            if (ActivarCuadrado)
            {

                txtRadio.Enabled = false;
                    hCuadrado.SetBase_1(float.Parse(txtBase.Text));

                    AreaFigura = hCuadrado.Area();
                    mensajeTipoFigura = hCuadrado.MensajeArea;
            }
            else if (ActivarCirculo)
            {
                if (string.IsNullOrEmpty(txtRadio.Text))
                {

                    MessageBox.Show("Debe completar la informacion");

                    return;

                }
                txtRadio.Enabled = true;
                txtAltura.Enabled = false;
                txtBase.Enabled = false;
                

                hCirculo.SetRadio_1(float.Parse(txtRadio.Text));
                AreaFigura = hCirculo.Area();
                mensajeTipoFigura = hCirculo.MensajeArea;
            }
            else //ActivarTriangulo
            {
                if ((string.IsNullOrEmpty(txtBase.Text) || string.IsNullOrEmpty(txtAltura.Text)))
                {

                    MessageBox.Show("Debe completar la informacion");

                    return;

                }
                txtRadio.Enabled = false;
                txtAltura.Enabled = true;
                txtBase.Enabled = true;
                hTriangulo.SetBase_1(float.Parse(txtBase.Text));
                hTriangulo.SetAltura_1(float.Parse(txtAltura.Text));
                AreaFigura = hTriangulo.Area();
                mensajeTipoFigura = hTriangulo.MensajeArea;

            }

            this.richTextBox1.Text = Convert.ToString(AreaFigura);
            this.labelRespuesta.Text = mensajeTipoFigura;
           

        }

        private void RecuperarNumero(object sender, KeyPressEventArgs e)
        {
            //https://stackoverflow.com/questions/463299/how-do-i-make-a-textbox-that-only-accepts-numbers

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
