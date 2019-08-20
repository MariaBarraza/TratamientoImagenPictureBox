namespace PictureBox
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.btnCargarImagen = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.btnConvertirGris = new System.Windows.Forms.Button();
            this.imageBox2 = new Emgu.CV.UI.ImageBox();
            this.btnHistogramaColor = new System.Windows.Forms.Button();
            this.histogramBox1 = new Emgu.CV.UI.HistogramBox();
            this.histogramBox2 = new Emgu.CV.UI.HistogramBox();
            this.histogramBox3 = new Emgu.CV.UI.HistogramBox();
            this.btnHistogramaColorRojo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargarImagen
            // 
            this.btnCargarImagen.Location = new System.Drawing.Point(12, 12);
            this.btnCargarImagen.Name = "btnCargarImagen";
            this.btnCargarImagen.Size = new System.Drawing.Size(126, 48);
            this.btnCargarImagen.TabIndex = 0;
            this.btnCargarImagen.Text = "Cargar Imagen";
            this.btnCargarImagen.UseVisualStyleBackColor = true;
            this.btnCargarImagen.Click += new System.EventHandler(this.BtnCargarImagen_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.Location = new System.Drawing.Point(12, 66);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(377, 372);
            this.imageBox1.TabIndex = 2;
            this.imageBox1.TabStop = false;
            // 
            // btnConvertirGris
            // 
            this.btnConvertirGris.Location = new System.Drawing.Point(144, 13);
            this.btnConvertirGris.Name = "btnConvertirGris";
            this.btnConvertirGris.Size = new System.Drawing.Size(128, 47);
            this.btnConvertirGris.TabIndex = 3;
            this.btnConvertirGris.Text = "Convertir a gris";
            this.btnConvertirGris.UseVisualStyleBackColor = true;
            this.btnConvertirGris.Click += new System.EventHandler(this.BtnConvertirGris_Click);
            // 
            // imageBox2
            // 
            this.imageBox2.Location = new System.Drawing.Point(408, 65);
            this.imageBox2.Name = "imageBox2";
            this.imageBox2.Size = new System.Drawing.Size(365, 372);
            this.imageBox2.TabIndex = 4;
            this.imageBox2.TabStop = false;
            // 
            // btnHistogramaColor
            // 
            this.btnHistogramaColor.Location = new System.Drawing.Point(278, 12);
            this.btnHistogramaColor.Name = "btnHistogramaColor";
            this.btnHistogramaColor.Size = new System.Drawing.Size(151, 47);
            this.btnHistogramaColor.TabIndex = 5;
            this.btnHistogramaColor.Text = "Histograma de color azul";
            this.btnHistogramaColor.UseVisualStyleBackColor = true;
            this.btnHistogramaColor.Click += new System.EventHandler(this.btnHistogramaColor_Click);
            // 
            // histogramBox1
            // 
            this.histogramBox1.Location = new System.Drawing.Point(779, 26);
            this.histogramBox1.Name = "histogramBox1";
            this.histogramBox1.Size = new System.Drawing.Size(640, 130);
            this.histogramBox1.TabIndex = 6;
            // 
            // histogramBox2
            // 
            this.histogramBox2.Location = new System.Drawing.Point(779, 174);
            this.histogramBox2.Name = "histogramBox2";
            this.histogramBox2.Size = new System.Drawing.Size(640, 126);
            this.histogramBox2.TabIndex = 7;
            // 
            // histogramBox3
            // 
            this.histogramBox3.Location = new System.Drawing.Point(779, 306);
            this.histogramBox3.Name = "histogramBox3";
            this.histogramBox3.Size = new System.Drawing.Size(640, 121);
            this.histogramBox3.TabIndex = 8;
            // 
            // btnHistogramaColorRojo
            // 
            this.btnHistogramaColorRojo.Location = new System.Drawing.Point(444, 13);
            this.btnHistogramaColorRojo.Name = "btnHistogramaColorRojo";
            this.btnHistogramaColorRojo.Size = new System.Drawing.Size(151, 47);
            this.btnHistogramaColorRojo.TabIndex = 9;
            this.btnHistogramaColorRojo.Text = "Histograma de color rojo";
            this.btnHistogramaColorRojo.UseVisualStyleBackColor = true;
            this.btnHistogramaColorRojo.Click += new System.EventHandler(this.btnHistogramaColorRojo_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(610, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(151, 47);
            this.button1.TabIndex = 10;
            this.button1.Text = "Histograma de color verde";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1446, 449);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnHistogramaColorRojo);
            this.Controls.Add(this.histogramBox3);
            this.Controls.Add(this.histogramBox2);
            this.Controls.Add(this.histogramBox1);
            this.Controls.Add(this.btnHistogramaColor);
            this.Controls.Add(this.imageBox2);
            this.Controls.Add(this.btnConvertirGris);
            this.Controls.Add(this.imageBox1);
            this.Controls.Add(this.btnCargarImagen);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCargarImagen;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.Button btnConvertirGris;
        private Emgu.CV.UI.ImageBox imageBox2;
        private System.Windows.Forms.Button btnHistogramaColor;
        private Emgu.CV.UI.HistogramBox histogramBox1;
        private Emgu.CV.UI.HistogramBox histogramBox2;
        private Emgu.CV.UI.HistogramBox histogramBox3;
        private System.Windows.Forms.Button btnHistogramaColorRojo;
        private System.Windows.Forms.Button button1;
    }
}

