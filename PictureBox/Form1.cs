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
    }
}
