using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageEditorCSharp
{
    public partial class ZMain : Form
    {
        Bitmap newBitmap;
        Image file;
        Boolean opened = false;
        int blurAmount = 1;
        float contrast = 0;
        float gamma = 1;


        private Bitmap originalBitmap = null;
        private Bitmap previewBitmap = null;
        private Bitmap resultBitmap = null;

        public ZMain()
        {
            InitializeComponent();
            this.BackgroundImage = Properties.Resources.lambo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dr = openFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                file = Image.FromFile(openFileDialog1.FileName);
                newBitmap = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = file;
                picture1.Image = file;
                opened = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = saveFileDialog1.ShowDialog();
            if (dr == DialogResult.OK)
            {
                if (opened)
                {
                    if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "bmp")
                    {
                        file.Save(saveFileDialog1.FileName, ImageFormat.Bmp);
                    }
                    if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "jpg")
                    {
                        file.Save(saveFileDialog1.FileName, ImageFormat.Jpeg);
                    }
                    if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "png")
                    {
                        file.Save(saveFileDialog1.FileName, ImageFormat.Png);
                    }
                    if (saveFileDialog1.FileName.Substring(saveFileDialog1.FileName.Length - 3).ToLower() == "gif")
                    {
                        file.Save(saveFileDialog1.FileName, ImageFormat.Gif);
                    }
                    /*        else
                            {
                                MessageBox.Show("You need to open an image first!");
                            }
                     */
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        //grayscale
        private void button3_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < newBitmap.Width; x++)
            {
                for (int y = 0; y < newBitmap.Height; y++)
                {

                    Color originalColor = newBitmap.GetPixel(x, y);

                    int greyScale = (int)((originalColor.R * .3) + (originalColor.G * .59) + (originalColor.B * .11));

                    Color newColor = Color.FromArgb(greyScale, greyScale, greyScale);

                    newBitmap.SetPixel(x, y, newColor);
                }
            }
            pictureBox1.Image = newBitmap;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            for (int x = blurAmount; x <= newBitmap.Width - blurAmount; x++)
            {
                for (int y = blurAmount; y <= newBitmap.Height - blurAmount; y++)
                {
                    try
                    {
                        Color prevX = newBitmap.GetPixel(x - blurAmount, y);
                        Color nextX = newBitmap.GetPixel(x + blurAmount, y);
                        Color prevY = newBitmap.GetPixel(x, y - blurAmount);
                        Color nextY = newBitmap.GetPixel(x, y + blurAmount);

                        int avgR = (int)((prevX.R + nextX.R + prevY.R + nextY.R) / 4);
                        int avgG = (int)((prevX.G + nextX.G + prevY.G + nextY.G) / 4);
                        int avgB = (int)((prevX.B + nextX.B + prevY.B + nextY.B) / 4);

                        newBitmap.SetPixel(x, y, Color.FromArgb(avgR, avgG, avgB));
                    }
                    catch (Exception) { }
                }
            }

            pictureBox1.Image = newBitmap;
        }
        //blur
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label2.Text = trackBar1.Value.ToString();
            blurAmount = int.Parse(trackBar1.Value.ToString());
        }
        //brightness track
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            label3.Text = trackBar2.Value.ToString();

            pictureBox1.Image = AdjustBrightness(newBitmap, trackBar2.Value);

        }

        /*brightness code*/
        public static Bitmap AdjustBrightness(Bitmap Image, int Value)
        {
            Bitmap TempBitmap = Image;
            float FinalValue = (float)Value / 255.0f;
            Bitmap NewBitmap = new Bitmap(TempBitmap.Width, TempBitmap.Height);
            Graphics NewGraphics = Graphics.FromImage(NewBitmap);
            float[][] FloatColorMatrix ={
                      new float[] {1, 0, 0, 0, 0},
                      new float[] {0, 1, 0, 0, 0},
                      new float[] {0, 0, 1, 0, 0},
                      new float[] {0, 0, 0, 1, 0},
                      new float[] {FinalValue, FinalValue, FinalValue, 1, 1}
                 };

            ColorMatrix NewColorMatrix = new ColorMatrix(FloatColorMatrix);
            ImageAttributes Attributes = new ImageAttributes();
            Attributes.SetColorMatrix(NewColorMatrix);
            NewGraphics.DrawImage(TempBitmap, new Rectangle(0, 0, TempBitmap.Width, TempBitmap.Height), 0, 0, TempBitmap.Width, TempBitmap.Height, GraphicsUnit.Pixel, Attributes);
            Attributes.Dispose();
            NewGraphics.Dispose();
            return NewBitmap;
        }
        //invert
        private void button6_Click(object sender, EventArgs e)
        {
            for (int x = 0; x < newBitmap.Width; x++)
            {
                for (int y = 0; y < newBitmap.Height; y++)
                {
                    Color pixel = newBitmap.GetPixel(x, y);

                    int red = pixel.R;
                    int green = pixel.G;
                    int blue = pixel.B;
                    newBitmap.SetPixel(x, y, Color.FromArgb(255 - red, 255 - green, 255 - blue));
                }
            }
            pictureBox1.Image = newBitmap;
        }
        //Contrast
        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            label4.Text = trackBar3.Value.ToString();

            contrast = 0.04f * trackBar3.Value;

            Bitmap bm = new Bitmap(newBitmap.Width, newBitmap.Height);

            Graphics g = Graphics.FromImage(bm);

            ImageAttributes ia = new ImageAttributes();

            ColorMatrix cm = new ColorMatrix(new float[][]{ new float[] {contrast,0f,0f,0f,0f},
                new float[] {0f,contrast,0f,0f,0f},
                new float[] {0f,0f,contrast,0f,0f},
                new float[] {0f,0f,0f,0f,0f},
                new float[] {0.001f,0.001f,0.001f,0f,1f}});

            ia.SetColorMatrix(cm);
            g.DrawImage(newBitmap, new Rectangle(0, 0, newBitmap.Width, newBitmap.Height), 0, 0, newBitmap.Width, newBitmap.Height, GraphicsUnit.Pixel, ia);

            g.Dispose();
            ia.Dispose();
            pictureBox1.Image = bm;
        }

        private void trackBar4_Scroll(object sender, EventArgs e)
        {
            label5.Text = trackBar4.Value.ToString();

            gamma = 0.04f * trackBar4.Value;

            Bitmap bm = new Bitmap(newBitmap.Width, newBitmap.Height);

            Graphics g = Graphics.FromImage(bm);
            ImageAttributes ia = new ImageAttributes();

            ia.SetGamma(gamma);

            g.DrawImage(newBitmap, new Rectangle(0, 0, newBitmap.Width, newBitmap.Height), 0, 0, newBitmap.Width, newBitmap.Height, GraphicsUnit.Pixel, ia);

            g.Dispose();
            ia.Dispose();
            pictureBox1.Image = bm;
        }
        //rotate Right
        private void button9_Click(object sender, EventArgs e)
        {

            Image img = pictureBox1.Image;
            img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureBox1.Image = img;
        }
        //Rotate Left
        private void button10_Click(object sender, EventArgs e)
        {
            Image img = pictureBox1.Image;
            img.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureBox1.Image = img;
        }
        //Sepia
        private void button11_Click(object sender, EventArgs e)
        {
            float[][] sepiaValues = {
            new float[]{.393f, .349f, .272f, 0, 0},
            new float[]{.769f, .686f, .534f, 0, 0},
            new float[]{.189f, .168f, .131f, 0, 0},
            new float[]{0, 0, 0, 1, 0},
            new float[]{0, 0, 0, 0, 1}};
            System.Drawing.Imaging.ColorMatrix sepiaMatrix = new System.Drawing.Imaging.ColorMatrix(sepiaValues);
            System.Drawing.Imaging.ImageAttributes IA = new System.Drawing.Imaging.ImageAttributes();
            IA.SetColorMatrix(sepiaMatrix);
            Bitmap sepiaEffect = (Bitmap)pictureBox1.Image.Clone();
            using (Graphics G = Graphics.FromImage(sepiaEffect))
            {
                G.DrawImage(pictureBox1.Image, new Rectangle(0, 0, sepiaEffect.Width, sepiaEffect.Height), 0, 0, sepiaEffect.Width, sepiaEffect.Height, GraphicsUnit.Pixel, IA);
            }
            pictureBox1.Image = sepiaEffect;
        }


        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        //zrgb
        private void FilterRGB(bool preview)
        {
            if (preview == null)
            {
                return;
            }

            if (preview == true)
            {
                pictureBox1.Image = newBitmap.ColorTint(trackB.Value / 100.0f, trackG.Value / 100.0f, trackR.Value / 100.0f);
            }
            else
            {
                resultBitmap = originalBitmap.ColorTint(trackB.Value / 100.0f, trackG.Value / 100.0f, trackR.Value / 100.0f);
            }
        }
        //redtrackbar
        private void trackR_Scroll(object sender, EventArgs e)
        {
            labR.Text = trackR.Value.ToString();
            FilterRGB(true);
        }
        //greentrackbar
        private void trackG_Scroll(object sender, EventArgs e)
        {
            labG.Text = trackG.Value.ToString();
            FilterRGB(true);
        }
        //blue trackbar
        private void trackB_Scroll(object sender, EventArgs e)
        {
            labB.Text = trackB.Value.ToString();
            FilterRGB(true);
        }
        //rgb Check box
        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox4.Checked)
            {
                StreamReader streamReader = new StreamReader(openFileDialog1.FileName);
                originalBitmap = (Bitmap)Bitmap.FromStream(streamReader.BaseStream);
                streamReader.Close();

                previewBitmap = originalBitmap.RGBCanvas(newBitmap.Width);
                pictureBox1.Image = previewBitmap;
                FilterRGB(true);
                }

        }

    }//end
}
