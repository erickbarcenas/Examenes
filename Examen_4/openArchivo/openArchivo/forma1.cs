public partial class Form1 : Form
    {
        //Instancia de la clase Leer
        Leer l = new Leer();
        //Alamcena la ruta del archivo .txt
        public string ARCHIVO ="";

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
            try
            {
                this.openFileDialog1.ShowDialog();

                if (!string.IsNullOrEmpty(this.openFileDialog1.FileName))
                {
                    ARCHIVO = this.openFileDialog1.FileName;
                    l.lecturaArchivo(dataGridView1, ',', ARCHIVO);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: "+ex.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cargarArchivo();
        }
    }
