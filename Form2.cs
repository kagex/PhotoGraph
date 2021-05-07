using ImageProcessor;
using ImageProcessor.Imaging;
using ImageProcessor.Processors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoGraph
{
    public partial class Form2 : Form
    {
        Bitmap bitmap;
        public Form2()
        {
            InitializeComponent();
        }
        
        private void form_shown(Object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            bitmap = (Bitmap)main.pictureBox1.Image;
        }
        private void brightness_trackBar_Scroll(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            main.pictureBox1.Image = changeBrightness(bitmap, (float)(brightnessBar.Value / 5));
            brightnessValue.Text = (brightnessBar.Value).ToString();
            main.pictureBox1.Refresh();
        }

        private void contrastBar_Scroll(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            main.pictureBox1.Image = changeContrast(bitmap, (int)contrastBar.Value);
            contrastValue.Text = (contrastBar.Value).ToString();
            main.pictureBox1.Refresh();
        }

        private Bitmap changeBrightness(Image image, float brightness) // Изменение яркости
        {
            float b = (float)brightness / 255.0f;
            ColorMatrix cm = new ColorMatrix(new float[][]
                {
                    new float[] {1, 0, 0, 0, 0},
                    new float[] {0, 1, 0, 0, 0},
                    new float[] {0, 0, 1, 0, 0},
                    new float[] {0, 0, 0, 1, 0},
                    new float[] {b, b, b, 1, 1},
                });
            ImageAttributes attributes = new ImageAttributes();
            attributes.SetColorMatrix(cm);

            Point[] points =
            {
                new Point(0, 0),
                new Point(image.Width, 0),
                new Point(0, image.Height),
            };
            Rectangle rect = new Rectangle(0, 0, image.Width, image.Height);

            Bitmap bm = new Bitmap(image.Width, image.Height);
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.DrawImage(image, points, rect, GraphicsUnit.Pixel, attributes);
            }

            return bm;
        }

        private Bitmap changeContrast(Image image, int contrast) // Изменение контраста
        {
            var factory = new ImageFactory(preserveExifData: true);
            factory.Load(bitmap);
            Contrast contrast1 = new Contrast { DynamicParameter = contrast };
            return (Bitmap)contrast1.ProcessImage(factory);
        }

        private Bitmap changeBlur(Image image, int blur) // Изменение размытия 
        {
            if (blur > 0)
            {
                var factory = new ImageFactory(preserveExifData: true);
                factory.Load(bitmap);
                GaussianLayer layer = new GaussianLayer(blur);
                GaussianBlur blur1 = new GaussianBlur { DynamicParameter = layer };
                return (Bitmap)blur1.ProcessImage(factory);
            }
            return (Bitmap)image;
        }

        private Bitmap setSaturation(Image image, float s)
        {
            var sr = (1 - s) * 0.2126f;
            var sg = (1 - s) * 0.7152f;
            var sb = (1 - s) * 0.0722f;

            Bitmap bmp = new Bitmap(image.Width, image.Height);
            using (var gfx = Graphics.FromImage(bmp))
            using (var attr = new ImageAttributes())
            {
                attr.SetColorMatrix(new ColorMatrix
                {
                    Matrix00 = sr + s,
                    Matrix01 = sr,
                    Matrix02 = sr,
                    Matrix10 = sg,
                    Matrix11 = sg + s,
                    Matrix12 = sg,
                    Matrix20 = sb,
                    Matrix21 = sb,
                    Matrix22 = sb + s
                });

                gfx.DrawImage(image,new Rectangle(Point.Empty, image.Size), 0, 0,image.Width,image.Height,GraphicsUnit.Pixel,attr);
                gfx.Dispose();
                return bmp;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            main.pictureBox1.Image = changeBlur(bitmap, Convert.ToInt32(textBox1.Text));
            main.pictureBox1.Refresh();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number))
            {
                e.Handled = true;
            }
        }

        private void colorBar_Scroll(object sender, EventArgs e)
        {
            Form1 main = this.Owner as Form1;
            main.pictureBox1.Image = setSaturation(bitmap, (float)colorBar.Value/100);
            colorValue.Text = (colorBar.Value).ToString();
            main.pictureBox1.Refresh();
        }
    }
}
