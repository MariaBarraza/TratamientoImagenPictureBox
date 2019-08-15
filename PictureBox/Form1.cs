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

        public Form1()
        {
            InitializeComponent();
        }

        private void BtnCargarImagen_Click(object sender, EventArgs e)
        {
            string rutaImagen = "C:\\Users\\alumno\\source\\repos\\PictureBox\\PictureBox\\imagen\\sora.jpg";
            _InputColor = new Image<Bgr, byte>(rutaImagen);

            if(_InputColor == null)
            {
                MessageBox.Show("No se cargo la imagen");
                return;
            }

            imageBox1.Image = _InputColor;
        }
    }
}
