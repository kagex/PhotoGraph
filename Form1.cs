using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoGraph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            openFileDialog1.FileName = "Resources/image-template.jpg";

            ToolStripMenuItem rightRotate = new ToolStripMenuItem("Повернуть изображение на 90 градусов");
            ToolStripMenuItem leftRotate = new ToolStripMenuItem("Повернуть изображение на -90 градусов");

            ToolStripMenuItem flipX = new ToolStripMenuItem("Отразить изображение по горизонтали");
            ToolStripMenuItem flipY = new ToolStripMenuItem("Отразить изображение по вертикали");

            contextMenuStrip1.Items.AddRange(new[] { rightRotate, leftRotate});
            contextMenuStrip1.Items.Add(new ToolStripSeparator());
            contextMenuStrip1.Items.AddRange(new[] { flipX, flipY });

            pictureBox1.ContextMenuStrip = contextMenuStrip1;

            rightRotate.Click += RightRotate_Click;
            leftRotate.Click += LeftRotate_Click;

            flipX.Click += FlipX_Click;
            flipY.Click += FlipY_Click;

            ToolStripMenuItem fileItem = new ToolStripMenuItem("Файл");
            fileItem.DropDownItems.Add("Открыть");
            fileItem.DropDownItems.Add(new ToolStripMenuItem("Сохранить"));

            fileItem.DropDownItemClicked += FileItem_Click;
            menuStrip1.Items.Add(fileItem);

            ToolStripMenuItem filterItem = new ToolStripMenuItem("Фильтр");
            filterItem.DropDownItems.Add("Без фильтра");
            filterItem.DropDownItems.Add("Сепия");
            filterItem.DropDownItems.Add("Зима");
            filterItem.DropDownItems.Add("Ч/Б");
            filterItem.DropDownItems.Add("Негатив");
            filterItem.DropDownItems.Add("Spike");
            filterItem.DropDownItems.Add("Flash");
            filterItem.DropDownItems.Add("Frozen");
            filterItem.DropDownItems.Add("Suji");
            filterItem.DropDownItems.Add("Dramatic");
            filterItem.DropDownItems.Add("Kakao");

            filterItem.DropDownItemClicked += FilterItem_DropDownItemClicked; ;
            menuStrip1.Items.Add(filterItem);

            ToolStripMenuItem corItem = new ToolStripMenuItem("Коррекция");
            corItem.Click += CorItem_Click;
            menuStrip1.Items.Add(corItem);

            ToolStripMenuItem resetItem = new ToolStripMenuItem("Сброс изменений");
            resetItem.Click += ResetItem_Click;
            menuStrip1.Items.Add(resetItem);

            ToolStripMenuItem aboutItem = new ToolStripMenuItem("О программе");
            aboutItem.Click += AboutItem_Click;
            menuStrip1.Items.Add(aboutItem);
        }

        Image image;
        Boolean opened = true;

        void reload()
        {
            if (opened)
            {
                image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = image;
                opened = true;
            } 
        }

        void openImage()
        {
            DialogResult dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                image = Image.FromFile(openFileDialog1.FileName);
                pictureBox1.Image = image;
                opened = true;
            }
        }

        void saveImage()
        {
            if (opened)
            {
                SaveFileDialog sfd = new SaveFileDialog(); 
                sfd.Filter = "Images|*.png;*.bmp;*.jpg";
                ImageFormat format = ImageFormat.Png;
                if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    string ext = Path.GetExtension(sfd.FileName);
                    switch (ext)
                    {
                        case ".jpg":
                            format = ImageFormat.Jpeg;
                            break;
                        case ".png":
                            format = ImageFormat.Png;
                            break;
                        case ".bmp":
                            format = ImageFormat.Bmp;
                            break;
                    }
                    pictureBox1.Image.Save(sfd.FileName, format);
                }
            }
            else { MessageBox.Show("Отсутсвует изображение для сохранения"); }

        }

        void rgb()
        {
            float changeRed = redBar.Value * 0.1f;
            float changeGreen = greenBar.Value * 0.1f;
            float changeBlue = blueBar.Value * 0.1f;

            redValue.Text = Math.Round(changeRed*10).ToString();
            greenValue.Text = Math.Round(changeGreen*10).ToString();
            blueValue.Text = Math.Round(changeBlue*10).ToString();

            reload();

            if (opened)
            {
                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{1+changeRed, 0, 0, 0, 0},
                    new float[]{0, 1+changeGreen, 0, 0, 0},
                    new float[]{0, 0, 1+changeBlue, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);

                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        void sepia()
        {
            if (!opened)
            {
                MessageBox.Show("Отсутствует изображение для работы");
            }
            else
            {
                Image img = pictureBox1.Image;                             
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   

                ImageAttributes ia = new ImageAttributes();                 
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       
                {
                    new float[]{.393f, .349f, .272f, 0, 0},
                    new float[]{.769f, .686f, .534f, 0, 0},
                    new float[]{.189f, .168f, .131f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);           
                Graphics g = Graphics.FromImage(bmpInverted);   
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bmpInverted;

            }
        }

        void winter()
        {
            if (!opened)
            {
                MessageBox.Show("Отсутствует изображение для работы");
            }
            else
            {

                Image img = pictureBox1.Image;                             
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);   

                ImageAttributes ia = new ImageAttributes();                 
                ColorMatrix cmPicture = new ColorMatrix(new float[][]       
                {
                    new float[]{1,0,0,0,0},
                    new float[]{0,1,0,0,0},
                    new float[]{0,0,1,0,0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 1, 0, 1}
                });
                ia.SetColorMatrix(cmPicture); 
                Graphics g = Graphics.FromImage(bmpInverted); 
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                g.Dispose(); 
                pictureBox1.Image = bmpInverted;

            }
        }

        void negative()
        {
            if (!opened)
            {
                MessageBox.Show("Отсутствует изображение для работы");
            }
            else
            {

                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                     new float[]{-1, 0, 0, 0, 0},
                     new float[]{0, -1, 0, 0, 0},
                     new float[]{0, 0, -1, 0, 0},
                     new float[]{0, 0, 0, 1, 0},
                     new float[]{1, 1, 1, 1, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bmpInverted;

            }
        }

        void gray()
        {
            if (!opened)
            {
                MessageBox.Show("Отсутствует изображение для работы");
            }
            else
            {

                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{0.299f, 0.299f, 0.299f, 0, 0},
                    new float[]{0.587f, 0.587f, 0.587f, 0, 0},
                    new float[]{0.114f, 0.114f, 0.114f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 0}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bmpInverted;

            }
        }

        void spike()
        {
            if (!opened)
            {
                MessageBox.Show("Отсутствует изображение для работы");
            }
            else
            {

                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{1+0.3f, 0, 0, 0, 0},
                    new float[]{0, 1+0.7f, 0, 0, 0},
                    new float[]{0, 0, 1+1.3f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        void flash()
        {
            if (!opened)
            {
                MessageBox.Show("Отсутствует изображение для работы");
            }
            else
            {

                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{1+0.9f, 0, 0, 0, 0},
                    new float[]{0, 1+1.5f, 0, 0, 0},
                    new float[]{0, 0, 1+1.3f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        void frozen()
        {
            if (!opened)
            {
                MessageBox.Show("Отсутствует изображение для работы");
            }
            else
            {

                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{1+0.3f, 0, 0, 0, 0},
                    new float[]{0, 1+0f, 0, 0, 0},
                    new float[]{0, 0, 1+5f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        void suji()
        {
            if (!opened)
            {
                MessageBox.Show("Отсутствует изображение для работы");
            }
            else
            {

                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{.393f, .349f+0.5f, .272f, 0, 0},
                    new float[]{.769f+0.3f, .686f, .534f, 0, 0},
                    new float[]{.189f, .168f, .131f+0.5f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        void dramatic()
        {
            if (!opened)
            {
                MessageBox.Show("Отсутствует изображение для работы");
            }
            else
            {

                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{.393f+0.3f, .349f, .272f, 0, 0},
                    new float[]{.769f, .686f+0.2f, .534f, 0, 0},
                    new float[]{.189f, .168f, .131f+0.9f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        void kakao()
        {
            if (!opened)
            {
                MessageBox.Show("Отсутствует изображение для работы");
            }
            else
            {

                Image img = pictureBox1.Image;
                Bitmap bmpInverted = new Bitmap(img.Width, img.Height);

                ImageAttributes ia = new ImageAttributes();
                ColorMatrix cmPicture = new ColorMatrix(new float[][]
                {
                    new float[]{.393f, .349f, .272f+1.3f, 0, 0},
                    new float[]{.769f, .686f+0.5f, .534f, 0, 0},
                    new float[]{.189f+2.3f, .168f, .131f, 0, 0},
                    new float[]{0, 0, 0, 1, 0},
                    new float[]{0, 0, 0, 0, 1}
                });
                ia.SetColorMatrix(cmPicture);
                Graphics g = Graphics.FromImage(bmpInverted);
                g.DrawImage(img, new Rectangle(0, 0, img.Width, img.Height), 0, 0, img.Width, img.Height, GraphicsUnit.Pixel, ia);

                g.Dispose();
                pictureBox1.Image = bmpInverted;
            }
        }

        private void FileItem_Click(object sender, ToolStripItemClickedEventArgs e)
        {
            string action = e.ClickedItem.Text;
            switch (action)
            {
                case "Открыть":
                    openImage();
                    break;
                case "Сохранить":
                    saveImage();
                    break;
            }
        }

        private void FilterItem_DropDownItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            changesReset();
            string action = e.ClickedItem.Text;
            switch (action)
            {
                case "Без фильтра":
                    changesReset();
                    break;
                case "Сепия":
                    sepia();
                    break;
                case "Зима":
                    winter();
                    break;
                case "Ч/Б":
                    gray();
                    break;
                case "Негатив":
                    negative();
                    break;
                case "Spike":
                    spike();
                    break;
                case "Flash":
                    flash();
                    break;
                case "Frozen":
                    frozen();
                    break;
                case "Suji":
                    suji();
                    break;
                case "Dramatic":
                    dramatic();
                    break;
                case "Kakao":
                    kakao();
                    break;
            }
        }

        private void ResetItem_Click(object sender, EventArgs e)
        {
            changesReset();
        }

        private void changesReset()
        {
            reload();
            redBar.Value = 0;
            greenBar.Value = 0;
            blueBar.Value = 0;
            rgb();
        }

        private void AboutItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("СПБГУАП 2021 - Шаталова Дарья и Гловацкий Александр");
        }

        private void bar_Scroll(object sender, EventArgs e)
        {
            rgb();
        }


        private void LeftRotate_Click(object sender, EventArgs e)
        {
            Bitmap bitmap1 = (Bitmap)pictureBox1.Image;
            bitmap1.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox1.Image = bitmap1;
        }

        private void RightRotate_Click(object sender, EventArgs e)
        {
            Bitmap bitmap1 = (Bitmap)pictureBox1.Image;
            bitmap1.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = bitmap1;
        }

        private void FlipY_Click(object sender, EventArgs e)
        {
            Bitmap bitmap1 = (Bitmap)pictureBox1.Image;
            bitmap1.RotateFlip(RotateFlipType.RotateNoneFlipY);
            pictureBox1.Image = bitmap1;
        }

        private void FlipX_Click(object sender, EventArgs e)
        {
            Bitmap bitmap1 = (Bitmap)pictureBox1.Image;
            bitmap1.RotateFlip(RotateFlipType.RotateNoneFlipX);
            pictureBox1.Image = bitmap1;
        }

        private void CorItem_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Owner = this;
            f.ShowDialog();
        }
    }
}
