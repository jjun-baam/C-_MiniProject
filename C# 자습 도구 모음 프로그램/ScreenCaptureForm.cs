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

namespace 과제_201730206_김준범
{
    public partial class ScreenCaptureForm : Form
    {
        public ScreenCaptureForm()
        {
            InitializeComponent();
            btnCapture.Click += BtnCapture_Click;
            btnSave.Click += BtnSave_Click;
            btnOtherSave.Click += BtnOtherSave_Click;          
        }

        private void BtnCapture_Click(object sender, EventArgs e)
        {
            screen_capture();
        }

        private void screen_capture()
        {
            Bitmap bitmap = new Bitmap(this.pictureBox.Width, this.pictureBox.Height);
            Graphics graphics = Graphics.FromImage(bitmap);
            graphics.CopyFromScreen(PointToScreen(new Point(this.pictureBox.Location.X, this.pictureBox.Location.Y)), new Point(0, 0), this.pictureBox.Size);
            bitmap.Save("x2.png", ImageFormat.Png);
            pictureBox.ImageLocation = "x2.png";
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            string img_folder = @"C:\Users\kimju\OneDrive\바탕 화면";

            if (!System.IO.Directory.Exists(img_folder))
                System.IO.Directory.CreateDirectory(img_folder);

            pictureBox.Image.Save(img_folder + "\\image.png", ImageFormat.Png);
            pictureBox.Image.Save(img_folder + "\\image.jpg", ImageFormat.Jpeg);
            pictureBox.Image.Save(img_folder + "\\image.bmp", ImageFormat.Bmp);
        }
        private void BtnOtherSave_Click(object sender, EventArgs e)
        {
            string fileName;
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "저장 경로 지정";
            saveFileDialog.OverwritePrompt = true;
            saveFileDialog.Filter = "JPEG File(*.jpg)|*.jpg|Bitmap File(*.bmp)|*.bmp|PNG File(*.png)|*.png";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                fileName = saveFileDialog.FileName;
                pictureBox.Image.Save(fileName);
            }
        }

    }
}
