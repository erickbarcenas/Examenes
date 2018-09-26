using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Examen3_TDP_FI
{
    public partial class Form1 : Form
    {
        //Instancia de la clase Leer
        Leer l = new Leer();
        //Alamcena la ruta del archivo .txt
        public string ARCHIVO = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Abre el openFileDialog y captura la ruta del bloc de notas'
        public void cargarArchivo()
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarArchivo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                Stream myStream = null;
                string document_path = "";

                openFileDialog1.InitialDirectory = "";
                openFileDialog1.Title = "Elije Archivo...";
                openFileDialog1.Filter = "txt file|*.txt";
                openFileDialog1.FilterIndex = 2;
                openFileDialog1.RestoreDirectory = true;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    document_path = openFileDialog1.FileName;

                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            ReadFile(document_path);
                        }
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Archivo sin separar por comas", "Intenta abrir el archivo correcto", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
           
        }
        public void ReadFile(string path)
            {
            try
            {
                this.openFileDialog1.ShowDialog();

                if (!string.IsNullOrEmpty(this.openFileDialog1.FileName))
                {
                    
                    path = this.openFileDialog1.FileName;
                    l.lecturaArchivo(dataGridView1, ',', path);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }

}


