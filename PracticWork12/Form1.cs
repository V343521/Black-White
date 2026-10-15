using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
namespace PracticWork12
{
    public partial class Form1 : Form
    {
        private Point PreviousPoint, point;
        private Bitmap bmp;
        private Bitmap originalBmp;
        private Pen blackPen;
        private Graphics g;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            blackPen = new Pen(Color.Black, 4);
            label1.Text = "Порог: " + trackBar1.Value;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Image files (*.BMP, *.JPG, *.GIF, *.PNG)|*.bmp;*.jpg;*.gif;*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(dialog.FileName);

                originalBmp = new Bitmap(image);
                bmp = new Bitmap(originalBmp);

                pictureBox1.Image = null;
                pictureBox1.Invalidate();
                pictureBox1.Update();

                pictureBox1.Image = bmp;

                g = Graphics.FromImage(bmp);
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            PreviousPoint.X = e.X;
            PreviousPoint.Y = e.Y;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                point.X = e.X;
                point.Y = e.Y;
                g.DrawLine(blackPen, PreviousPoint, point);
                PreviousPoint.X = point.X;
                PreviousPoint.Y = point.Y;
                pictureBox1.Invalidate();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (bmp == null) return;
            SaveFileDialog savedialog = new SaveFileDialog();
            savedialog.Title = "Сохранить картинку как...";
            savedialog.OverwritePrompt = true;
            savedialog.CheckPathExists = true;
            savedialog.Filter = "Bitmap File(*.bmp)|*.bmp|GIF File(*.gif)|*.gif|JPEG File(*.jpg)|*.jpg|PNG File(*.png)|*.png";
            if (savedialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = savedialog.FileName;
                string strFileName = fileName.Remove(0, fileName.Length - 3);
                switch (strFileName)
                {
                    case "bmp":
                        bmp.Save(fileName, ImageFormat.Bmp);
                        break;
                    case "jpg":
                        bmp.Save(fileName, ImageFormat.Jpeg);
                        break;
                    case "gif":
                        bmp.Save(fileName, ImageFormat.Gif);
                        break;
                    case "png":
                        bmp.Save(fileName, ImageFormat.Png);
                        break;
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (originalBmp == null) return;
            int threshold = trackBar1.Value;
            bmp = new Bitmap(originalBmp);
            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    Color pixel = bmp.GetPixel(i, j);

                    int gray = (int)(0.299 * pixel.R + 0.587 * pixel.G + 0.114 * pixel.B);

                    if (gray > threshold)
                    {
                        bmp.SetPixel(i, j, Color.White);
                    }
                    else
                    {
                        bmp.SetPixel(i, j, Color.Black);
                    }
                }
            }
            g = Graphics.FromImage(bmp);
            pictureBox1.Image = bmp;
            pictureBox1.Invalidate();
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = "Порог: " + trackBar1.Value;
        }
    }
}