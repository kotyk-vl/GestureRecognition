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
    public partial class Form_Advanc : Form
    {
        public Form_Advanc()
        {
            InitializeComponent();
        }

        private void Form_Advanc_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Value = (int)Data.res;
            circularProgressBar1.Text = Data.label;
        }

        private void btnLoad_Rec_Click(object sender, EventArgs e)
        {
            try
            {
                Rectangle Rect;
                string Path = Environment.CurrentDirectory;
                //String Path = @"C:\Users\Vlad Kotyk\Desktop\";
                Bitmap bitmap = (Bitmap)pictureBox4.Image;
                Rect = new Rectangle(bitmap.Width / 2, 0, bitmap.Width / 2, bitmap.Height / 2);
                Bitmap bitmap1 = bitmap.Clone(Rect, PixelFormat.DontCare);
                bitmap1.Save(Path + "image.png", ImageFormat.Png);

                new Thread(() =>
                {
                    LoadModel.Meth(Path + "image.png");
                    Data.res = (int)(LoadModel.PredictScore * 100);
                    Data.label = LoadModel.PredictLabel;
                    circularProgressBar1.Value = (int)Data.res;
                    circularProgressBar1.Text = String.Format("{0} %", (int)Data.res);
                    label3.Text = Data.label;
                    label4.Text = String.Format($"{LoadModel.PredictScore: ##.# %}");
                }).Start();
            }
            catch
            {
                MessageBox.Show("Select a camera", "Warning", MessageBoxButtons.OK);
            }
        }

    
    }
}
