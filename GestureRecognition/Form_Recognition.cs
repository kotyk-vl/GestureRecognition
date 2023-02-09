using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestureRecognition
{
    public partial class Form_Recognition : Form
    {
        int k = 0;
        public Form_Recognition()
        {
            InitializeComponent();
        }
        private void Form_Recognition_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Value = (int)Data.res;
            circularProgressBar1.Text = Data.label;
        }

        public void btnLoadMod_Click(object sender, EventArgs e)
        {
            try
            {
                Rectangle Rect;
                string Path = Environment.CurrentDirectory;
                Bitmap bitmap = (Bitmap)pictureBox2.Image;
                Rect = new Rectangle(bitmap.Width / 2, 0, bitmap.Width / 2, bitmap.Height / 2);
                Bitmap bitmap1 = bitmap.Clone(Rect, PixelFormat.DontCare);

                bitmap1.Save(Path + "image.png", ImageFormat.Png);
                if (k == 0)
                {
                    textBox1.Text = "Loading model" + Environment.NewLine;
                    textBox1.Text += "Wait for a moment...." + Environment.NewLine;
                    textBox1.Text += "---------------------" + Environment.NewLine;
                    k++;
                }
                new Thread(() =>
                {
                    var watch = System.Diagnostics.Stopwatch.StartNew();
                    textBox1.Text += LoadModel.Meth(Path + "image.png");
                    Data.res = (int)(LoadModel.PredictScore * 100);
                    Data.label = LoadModel.PredictLabel;
                    circularProgressBar1.Value = (int)Data.res;
                    circularProgressBar1.Text = String.Format("{0} %", (int)Data.res);
                    label5.Text = Data.label;
                    float t = (float)watch.ElapsedMilliseconds / 1000;
                    textBox1.Text += $"Time is: {t:f3} s" + Environment.NewLine + Environment.NewLine ;
                }).Start();
            }
            catch
            {
                MessageBox.Show("Select a camera","Warning", MessageBoxButtons.OK);
            }
        }
    }
}
