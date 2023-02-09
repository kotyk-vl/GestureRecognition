using AForge.Imaging.Filters;
using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace GestureRecognition
{
    public partial class Form1 : Form
    {
        FilterInfoCollection _device;
        VideoCaptureDevice _CaptureDevice;
        Bitmap _colorFilterImage, _bitmapGreyImage, _bitmapBlurImage, _bitmapBinaryImage;
        EuclideanColorFiltering _colorFilter;
        Form_Recognition frm_rec = new Form_Recognition()
        { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
        Form_Advanc frm_video = new Form_Advanc()
        { Dock = DockStyle.Fill, TopLevel = false, TopMost = true, FormBorderStyle = FormBorderStyle.None };
        public Rectangle Rect { get; set; }

        public int WidhtImg { get; set; }
        public int HeightImg { get; set; }
        public int KSize { get; set; }
        public double Sigma { get; set; }
        public int Radius { get; set; } = 60;
        public bool Filter { get; set; }

        public Form1()
        {
            InitializeComponent();
            pnlNav.Height = btnDashbord.Height;
            pnlNav.Top = btnDashbord.Top;
            pnlNav.Left = btnDashbord.Left;

            numUp1.DecimalPlaces = 2;
            numUp1.Increment = 0.1M;
            numUp1.Value = 1.5M;
            numUp2.Value = 2;

            btnAnalytics.ForeColor = btnDashbord.BackColor = Color.FromArgb(194, 194, 194);
            btnAnalytics.BackColor = btnDashbord.ForeColor = Color.FromArgb(51, 51, 51);
            this.pnlFormLoader.Controls.Add(frm_rec);
            this.pnlFormLoader.Controls.Add(frm_video);
            frm_rec.Show();
            CheckForIllegalCrossThreadCalls = false;
        }
        #region Form_Loading
        private void Form1_Load(object sender, EventArgs e)
        {
            SelectCamera();

        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopCamera();
        }

        private void btnRecognition_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashbord.Height;
            pnlNav.Top = btnDashbord.Top;
            pnlNav.Left = btnDashbord.Left;
            btnAnalytics.ForeColor = btnDashbord.BackColor = Color.FromArgb(194, 194, 194);
            btnAnalytics.BackColor = btnDashbord.ForeColor = Color.FromArgb(51, 51, 51);

            this.pnlFormLoader.Controls.Clear();
            this.pnlFormLoader.Controls.Add(frm_rec);
            frm_rec.Show();


        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnalytics.Height;
            pnlNav.Top = btnAnalytics.Top;
            btnDashbord.ForeColor = btnAnalytics.BackColor = Color.FromArgb(194, 194, 194);
            btnDashbord.BackColor = btnAnalytics.ForeColor = Color.FromArgb(51, 51, 51);


            this.pnlFormLoader.Controls.Clear();
            this.pnlFormLoader.Controls.Add(frm_video);
            frm_video.Show();
        }

        #endregion

        #region CameraSettings

        private void SelectCamera()
        {
            try
            {
                _device = new FilterInfoCollection(FilterCategory.VideoInputDevice);
                for (var i = 0; i < _device.Count; i++)
                    select_cam.Items.Add(_device[i].Name);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SelectIndexChange(object sender, EventArgs e)
        {
            try
            {
                StopCamera();
                StartCamera(select_cam.SelectedIndex);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void StartCamera(int deviceindex)
        {
            try
            {
                _CaptureDevice = new VideoCaptureDevice(_device[deviceindex].MonikerString);
                _CaptureDevice.NewFrame += new NewFrameEventHandler(get_Frame);
                _CaptureDevice.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void StopCamera()
        {
            try
            {
                if (_CaptureDevice != null)
                    _CaptureDevice.Stop();
            }
            catch (Exception)
            {
                return;
            }
        }

        private void cbBlur_CheckedChanged(object sender, EventArgs e)
        {
            Filter = cbBlur.Checked ? true : false;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            Radius = trackBar1.Value;
        }

        private void get_Frame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                Bitmap _frame = (Bitmap)eventArgs.Frame.Clone();

                WidhtImg = _frame.Width;
                HeightImg = _frame.Height;
                Rect = new Rectangle(WidhtImg / 2, 0, WidhtImg / 2, HeightImg / 2);
                frm_rec.pictureBox1.Image = ProccessImage((Bitmap)_frame.Clone());
                frm_rec.pictureBox2.Image = (Bitmap)_bitmapBinaryImage.Clone();

                frm_video.pictureBox1.Image = (Bitmap)frm_rec.pictureBox1.Image.Clone();
                frm_video.pictureBox2.Image = (Bitmap)_bitmapGreyImage.Clone();
                frm_video.pictureBox3.Image = _colorFilterImage;
                frm_video.pictureBox4.Image = (Bitmap)_bitmapBinaryImage.Clone();
            }
            catch { throw new Exception("Get frame invalid"); }

        }

        private Bitmap ProccessImage(Bitmap bsourceFrame)
        {
            try
            {
                _colorFilter = new EuclideanColorFiltering
                {
                    CenterColor = new AForge.Imaging.RGB(255, 255, 255),
                    Radius = (short)Radius
                    
                };

                _colorFilterImage = _colorFilter.Apply(bsourceFrame);

                Grayscale _grayscale = new Grayscale(0.25, 0.5, 0.25);
                double cR = _grayscale.RedCoefficient;
                double cG = _grayscale.GreenCoefficient;
                double cB = _grayscale.BlueCoefficient;
       
                _bitmapGreyImage = _grayscale.Apply(_colorFilterImage);

                IterativeThreshold _threshold = new IterativeThreshold(); 
                int thresold = _threshold.ThresholdValue;

                if (Filter == true)
                {
                    Sigma = (double)numUp1.Value;
                    KSize = (int)numUp2.Value;

                    GaussianBlur _blurfilter = new GaussianBlur(Sigma, KSize);
                    _bitmapBlurImage = _blurfilter.Apply(_bitmapGreyImage);
                    _bitmapBinaryImage = _threshold.Apply(_bitmapBlurImage);
                }
                else
                {
                    _bitmapBinaryImage = _threshold.Apply(_bitmapGreyImage);
                }

                using (var bitmap = (Bitmap)_bitmapBinaryImage.Clone())
                {

                    {
                        Graphics graphic = Graphics.FromImage(bsourceFrame);
                        using (Pen pen = new Pen(Brushes.Red, 3))
                        {
                            graphic.DrawRectangle(pen, Rect);
                        }
                        graphic.Dispose();
                    }
                }
                return bsourceFrame;
            }
            catch
            {
                return bsourceFrame;
            }
        }
        #endregion

    }
}
