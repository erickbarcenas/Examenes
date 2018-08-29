namespace CalculadoraAreas
{
    partial class InterfazUsuarioForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboTipoFigura = new System.Windows.Forms.ComboBox();
            this.txtBase = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBase = new System.Windows.Forms.Label();
            this.labelAltura = new System.Windows.Forms.Label();
            this.labelRadio = new System.Windows.Forms.Label();
            this.txtRadio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelRespuesta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboTipoFigura
            // 
            this.cboTipoFigura.FormattingEnabled = true;
            this.cboTipoFigura.Items.AddRange(new object[] {
            "Cuadrado",
            "Triángulo",
            "Círculo"});
            this.cboTipoFigura.Location = new System.Drawing.Point(201, 78);
            this.cboTipoFigura.Name = "cboTipoFigura";
            this.cboTipoFigura.Size = new System.Drawing.Size(101, 21);
            this.cboTipoFigura.TabIndex = 0;
            this.cboTipoFigura.SelectedIndexChanged += new System.EventHandler(this.RecogeFigura);
            // 
            // txtBase
            // 
            this.txtBase.Location = new System.Drawing.Point(201, 148);
            this.txtBase.Name = "txtBase";
            this.txtBase.Size = new System.Drawing.Size(101, 20);
            this.txtBase.TabIndex = 1;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(213, 347);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(75, 23);
            this.btnEnviar.TabIndex = 2;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.EnviarRespuesta);
            // 
            // txtAltura
            // 
            this.txtAltura.Location = new System.Drawing.Point(202, 216);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 20);
            this.txtAltura.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Figura Geométrica";
            // 
            // labelBase
            // 
            this.labelBase.AutoSize = true;
            this.labelBase.Location = new System.Drawing.Point(81, 151);
            this.labelBase.Name = "labelBase";
            this.labelBase.Size = new System.Drawing.Size(69, 13);
            this.labelBase.TabIndex = 5;
            this.labelBase.Text = "Ingresa Base";
            // 
            // labelAltura
            // 
            this.labelAltura.AutoSize = true;
            this.labelAltura.Location = new System.Drawing.Point(81, 219);
            this.labelAltura.Name = "labelAltura";
            this.labelAltura.Size = new System.Drawing.Size(72, 13);
            this.labelAltura.TabIndex = 6;
            this.labelAltura.Text = "Ingresa Altura";
            // 
            // labelRadio
            // 
            this.labelRadio.AutoSize = true;
            this.labelRadio.Location = new System.Drawing.Point(81, 290);
            this.labelRadio.Name = "labelRadio";
            this.labelRadio.Size = new System.Drawing.Size(73, 13);
            this.labelRadio.TabIndex = 7;
            this.labelRadio.Text = "Ingresa Radio";
            // 
            // txtRadio
            // 
            this.txtRadio.Location = new System.Drawing.Point(201, 287);
            this.txtRadio.Name = "txtRadio";
            this.txtRadio.Size = new System.Drawing.Size(100, 20);
            this.txtRadio.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Calculadora de áreas";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(188, 396);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(135, 72);
            this.richTextBox1.TabIndex = 10;
            this.richTextBox1.Text = "";
            // 
            // labelRespuesta
            // 
            this.labelRespuesta.AutoSize = true;
            this.labelRespuesta.Location = new System.Drawing.Point(81, 429);
            this.labelRespuesta.Name = "labelRespuesta";
            this.labelRespuesta.Size = new System.Drawing.Size(75, 13);
            this.labelRespuesta.TabIndex = 11;
            this.labelRespuesta.Text = "El área [m^2] :";
            // 
            // InterfazUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 504);
            this.Controls.Add(this.labelRespuesta);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtRadio);
            this.Controls.Add(this.labelRadio);
            this.Controls.Add(this.labelAltura);
            this.Controls.Add(this.labelBase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtBase);
            this.Controls.Add(this.cboTipoFigura);
            this.Name = "InterfazUsuarioForm";
            this.Text = "Calculadora de áreas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTipoFigura;
        private System.Windows.Forms.TextBox txtBase;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBase;
        private System.Windows.Forms.Label labelAltura;
        private System.Windows.Forms.Label labelRadio;
        private System.Windows.Forms.TextBox txtRadio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelRespuesta;
    }
}

