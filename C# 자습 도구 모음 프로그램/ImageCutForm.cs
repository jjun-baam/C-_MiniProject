using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace 과제_201730206_김준범
{
    /// <summary>
    /// 메인 폼
    /// </summary>
    public partial class ImageCutForm : Form
    {
        //////////////////////////////////////////////////////////////////////////////////////////////////// Field
        ////////////////////////////////////////////////////////////////////////////////////////// Private

        #region Field

        /// <summary>
        /// 좌상단 포인트
        /// </summary>
        private Point leftTopPoint = new Point(0, 0);

        /// <summary>
        /// 드래그 여부
        /// </summary>
        private bool isDragging = false;

        /// <summary>
        /// 마지막 포인트
        /// </summary>
        private Point lastPoint;

        /// <summary>
        /// 소스 비트맵
        /// </summary>
        private Bitmap sourceBitmap = null;

        /// <summary>
        /// 타겟 비트맵
        /// </summary>
        private Bitmap targetBitmap = null;

        /// <summary>
        /// 이미지 스케일
        /// </summary>
        private float imageScale = 1f;

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Constructor
        ////////////////////////////////////////////////////////////////////////////////////////// Public

        #region 생성자 - MainForm()

        /// <summary>
        /// 생성자
        /// </summary>
        public ImageCutForm()
        {
            InitializeComponent();

            this.openMenuItem.Click        += openMenuItem_Click;
            this.saveAsMenuItem.Click      += saveAsMenuItem_Click;
            this.exitMenuItem.Click        += exitMenuItem_Click;
            this.scale100MenuItem.Click    += scaleMenuItem_Click;
            this.scale75MenuItem.Click     += scaleMenuItem_Click;
            this.scale66MenuItem.Click     += scaleMenuItem_Click;
            this.scale50MenuItem.Click     += scaleMenuItem_Click;
            this.scale25MenuItem.Click     += scaleMenuItem_Click;
            this.scale15MenuItem.Click     += scaleMenuItem_Click;
            this.widthTextBox.TextChanged  += sizeTextBox_TextChanged;
            this.heightTextBox.TextChanged += sizeTextBox_TextChanged;
            this.pictureBox.MouseDown      += pictureBox_MouseDown;
            this.pictureBox.MouseMove      += pictureBox_MouseMove;
            this.pictureBox.MouseUp        += pictureBox_MouseUp;
            this.pictureBox.Paint          += pictureBox_Paint;
        }

        #endregion

        //////////////////////////////////////////////////////////////////////////////////////////////////// Method
        ////////////////////////////////////////////////////////////////////////////////////////// Private
        //////////////////////////////////////////////////////////////////////////////// Event

        #region 열기 메뉴 항목 클릭시 처리하기 - openMenuItem_Click(sender, e)

        /// <summary>
        /// 열기 메뉴 항목 클릭시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void openMenuItem_Click(object sender, EventArgs e)
        {
            if(this.openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    this.sourceBitmap = LoadBitmapUnlocked(this.openFileDialog.FileName);

                    ShowTargetBitmap();

                    this.saveAsMenuItem.Enabled = true;
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        #endregion
        #region 다른 이름으로 저장 메뉴 항목 클릭시 처리하기 - saveAsMenuItem_Click(sender, e)

        /// <summary>
        /// 다른 이름으로 저장 메뉴 항목 클릭시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void saveAsMenuItem_Click(object sender, EventArgs e)
        {
            if(this.saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    Rectangle rectangle = GetSelectionRectangle(false);

                    Bitmap bitmap = new Bitmap(rectangle.Width, rectangle.Height);

                    using(Graphics graphics = Graphics.FromImage(bitmap))
                    {
                        graphics.DrawImage(this.sourceBitmap, 0, 0, rectangle, GraphicsUnit.Pixel);
                    }

                    SaveImage(bitmap, this.saveFileDialog.FileName);
                }
                catch(Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
        }

        #endregion
        #region 종료 메뉴 항목 클릭시 처리하기 - exitMenuItem_Click(sender, e)

        /// <summary>
        /// 종료 메뉴 항목 클릭시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void exitMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        #endregion
        #region 확대/축소 메뉴 항목 클릭시 처리하기 - scaleMenuItem_Click(sender, e)

        /// <summary>
        /// 확대/축소 메뉴 항목 클릭시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void scaleMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem menuItem = sender as ToolStripMenuItem;

            string scaleText = menuItem.Text.Replace("&", "").Replace("%", "");

            this.imageScale = float.Parse(scaleText) / 100f;

            ShowTargetBitmap();

            this.scaleMenuItem.Text = "확대/축소(&S) (" + menuItem.Text.Replace("&", "") + ")";

            foreach(ToolStripMenuItem item in scaleMenuItem.DropDownItems)
            {
                item.Checked = (item == menuItem);
            }
        }

        #endregion
        #region 크기 텍스트 박스 텍스트 변경시 처리하기 - sizeTextBox_TextChanged(sender, e)

        /// <summary>
        /// 크기 텍스트 박스 텍스트 변경시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void sizeTextBox_TextChanged(object sender, EventArgs e)
        {
            this.pictureBox.Refresh();
        }

        #endregion
        #region 픽처 박스 마우스 DOWN 처리하기 - pictureBox_MouseDown(sender, e)

        /// <summary>
        /// 픽처 박스 마우스 DOWN 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            Rectangle rectangle = GetSelectionRectangle(true);

            if(!rectangle.Contains(e.Location))
            {
                return;
            }

            this.lastPoint = e.Location;

            this.isDragging = true;
        }

        #endregion
        #region 픽처 박스 마우스 이동시 처리하기 - pictureBox_MouseMove(sender, e)

        /// <summary>
        /// 픽처 박스 마우스 이동시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if(!this.isDragging)
            {
                return;
            }

            this.leftTopPoint.X += (int)((e.Location.X - this.lastPoint.X) / this.imageScale);
            this.leftTopPoint.Y += (int)((e.Location.Y - this.lastPoint.Y) / this.imageScale);

            this.lastPoint = e.Location;

            this.pictureBox.Refresh();
        }

        #endregion
        #region 픽처 박스 마우스 UP 처리하기 - pictureBox_MouseUp(sender, e)

        /// <summary>
        /// 픽처 박스 마우스 UP 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            this.isDragging = false;
        }

        #endregion
        #region 픽처 박스 페인트시 처리하기 - pictureBox_Paint(sender, e)

        /// <summary>
        /// 픽처 박스 페인트시 처리하기
        /// </summary>
        /// <param name="sender">이벤트 발생자</param>
        /// <param name="e">이벤트 인자</param>
        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                using(Pen pen = new Pen(Color.Red, 2))
                {
                    Rectangle rectangle = GetSelectionRectangle(true);

                    e.Graphics.DrawRectangle(pen, rectangle);

                    pen.Color = Color.Yellow;

                    pen.DashPattern = new float[] { 5, 5 };

                    e.Graphics.DrawRectangle(pen, rectangle);
                }
            }
            catch
            {
            }
        }

        #endregion

        //////////////////////////////////////////////////////////////////////////////// Function

        #region 잠금없이 비트맵 로드하기 - LoadBitmapUnlocked(filePath)

        /// <summary>
        /// 잠금없이 비트맵 로드하기
        /// </summary>
        /// <param name="filePath">파일 경로</param>
        /// <returns>비트맵</returns>
        private Bitmap LoadBitmapUnlocked(string filePath)
        {
            using(Bitmap bitmap = new Bitmap(filePath))
            {
                return new Bitmap(bitmap);
            }
        }

        #endregion
        #region 타겟 비트맵 표시하기 - ShowTargetBitmap()

        /// <summary>
        /// 타겟 비트맵 표시하기
        /// </summary>
        private void ShowTargetBitmap()
        {
            if(this.sourceBitmap == null)
            {
                return;
            }

            int targetWidth  = (int)(this.sourceBitmap.Width  * this.imageScale);
            int targetHeight = (int)(this.sourceBitmap.Height * this.imageScale);

            this.targetBitmap = new Bitmap(targetWidth, targetHeight);

            using(Graphics graphics = Graphics.FromImage(this.targetBitmap))
            {
                Point[] targetPointArray =
                {
                    new Point(0              ,                0),
                    new Point(targetWidth - 1,                0),
                    new Point(0              , targetHeight - 1)
                };

                Rectangle sourceRectangle = new Rectangle
                (
                    0,
                    0,
                    this.sourceBitmap.Width  - 1,
                    this.sourceBitmap.Height - 1
                );

                graphics.DrawImage(this.sourceBitmap, targetPointArray, sourceRectangle, GraphicsUnit.Pixel);
            }

            this.pictureBox.Image = this.targetBitmap;

            this.pictureBox.Visible = true;

            this.pictureBox.Refresh();
        }

        #endregion
        #region 선택 사각형 구하기 - GetSelectionRectangle(scaled)

        /// <summary>
        /// 선택 사각형 구하기
        /// </summary>
        /// <param name="scaled">확대/축소 여부</param>
        /// <returns>선택 사각형</returns>
        private Rectangle GetSelectionRectangle(bool scaled)
        {
            int x;
            int y;
            int width;
            int height;

            if(!int.TryParse(this.widthTextBox.Text, out width))
            {
                return new Rectangle();
            }

            if(!int.TryParse(this.heightTextBox.Text, out height))
            {
                return new Rectangle();
            }

            x = this.leftTopPoint.X;
            y = this.leftTopPoint.Y;

            if(scaled)
            {
                x = (int)(x * this.imageScale);
                y = (int)(y * this.imageScale);

                width  = (int)(width  * this.imageScale);
                height = (int)(height * this.imageScale);
            }

            return new Rectangle(x, y, width, height);
        }

        #endregion
        #region 이미지 저장하기 - SaveImage(image, filePath)

        /// <summary>
        /// 이미지 저장하기
        /// </summary>
        /// <param name="image">이미지</param>
        /// <param name="filePath">파일 경로</param>
        public void SaveImage(Image image, string filePath)
        {
            string extension = Path.GetExtension(filePath);

            switch(extension.ToLower())
            {
                case ".bmp"  : image.Save(filePath, ImageFormat.Bmp ); break;
                case ".exif" : image.Save(filePath, ImageFormat.Exif); break;
                case ".gif"  : image.Save(filePath, ImageFormat.Gif ); break;
                case ".jpg"  :
                case ".jpeg" : image.Save(filePath, ImageFormat.Jpeg); break;
                case ".png"  : image.Save(filePath, ImageFormat.Png ); break;
                case ".tif"  :
                case ".tiff" : image.Save(filePath, ImageFormat.Tiff); break;
                default      : throw new NotSupportedException("Unknown file extension " + extension);
            }
        }

        #endregion
    }
}