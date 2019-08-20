using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Emgu;
using Emgu.CV;
using Emgu.CV.Structure;

namespace PictureBox
{
   
    public partial class Form1 : Form
    {
        Image<Bgr, byte> _InputColor;
        Image<Gray, byte> _InputGray;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCargarImagen_Click(object sender, EventArgs e)
        {
            string rutaImagen = "C:\\Users\\alumno\\source\\repos\\TratamientoImagenPictureBox\\PictureBox\\imagen\\sora.jpg";
          
                _InputColor = new Image<Bgr, byte>(rutaImagen);

            if(_InputColor == null)
            {
                MessageBox.Show("No se cargo la imagen");
                return;
            }
                imageBox1.Image = _InputColor;
            //desactivar las opciones del menu
            imageBox1.FunctionalMode = Emgu.CV.UI.ImageBox.FunctionalModeOption.Minimum;
        }

        private void BtnConvertirGris_Click(object sender, EventArgs e)
        {
            _InputGray = _InputColor.Convert<Gray,byte>();
            imageBox2.Image = _InputGray;
        }

        private void btnHistogramaColor_Click(object sender, EventArgs e)
        {
            //inicializar variable para determinar rango de color
            //parametros: cantidad colores que tiene una imagen y crear el rango que se va a muestrear
            DenseHistogram histogramaColor = new DenseHistogram(256, new RangeF(0,255));

            //convertir imagen de color a grises por que es mas facil hacer los calculos

            histogramaColor.Calculate(new Image<Gray, byte>[]{ _InputColor[0]},false,null);

            Mat m = new Mat();

            histogramaColor.CopyTo(m);

            histogramBox1.AddHistogram("Histograma del color azul", Color.Blue,m, 256,new float[] { 0,256 });
            histogramBox1.Refresh();

        }

        private void btnHistogramaColorRojo_Click(object sender, EventArgs e)
        {
            //inicializar variable para determinar rango de color
            //parametros: cantidad colores que tiene una imagen y crear el rango que se va a muestrear
            DenseHistogram histogramaColor = new DenseHistogram(256, new RangeF(0, 255));

            //convertir imagen de color a grises por que es mas facil hacer los calculos

            histogramaColor.Calculate(new Image<Gray, byte>[] { _InputColor[0] }, false, null);

            Mat m = new Mat();

            histogramaColor.CopyTo(m);

            histogramBox2.AddHistogram("Histograma del color rojo", Color.Red, m, 256, new float[] { 0, 256 });
            histogramBox2.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //inicializar variable para determinar rango de color
            //parametros: cantidad colores que tiene una imagen y crear el rango que se va a muestrear
            DenseHistogram histogramaColor = new DenseHistogram(256, new RangeF(0, 255));

            //convertir imagen de color a grises por que es mas facil hacer los calculos

            histogramaColor.Calculate(new Image<Gray, byte>[] { _InputColor[0] }, false, null);

            Mat m = new Mat();

            histogramaColor.CopyTo(m);

            histogramBox3.AddHistogram("Histograma del color verde", Color.Green, m, 256, new float[] { 0, 256 });
            histogramBox3.Refresh();
        }
    }
}
