using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace CatturaSchermo
{
    public partial class frmCapture : Form
    {
        public int selectX;
        public int selectY;
        public int selectWidth;
        public int selectHeight;

        public Pen selectPen;
        public Bitmap ScreenShot;
        bool start = false;

        public frmCapture()
        {
            InitializeComponent();

            this.BackColor = Color.Black;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.Manual;
            this.Top = 0;
            this.Left = 0;
        }

        private void frmCapture_Load(object sender, EventArgs e)
        {
            this.Hide();
            Bitmap printScreen = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics graphics = Graphics.FromImage(printScreen as Image);

            graphics.CopyFromScreen(0, 0, 0, 0, printScreen.Size);

            using (MemoryStream s = new MemoryStream())
            {
                printScreen.Save(s, ImageFormat.Bmp);
                picCapture.Size = new System.Drawing.Size(this.Width, this.Height);
                picCapture.Image = Image.FromStream(s);
            }

            this.Show();
            Cursor = Cursors.Cross;
        }

        private void picCapture_MouseDown(object sender, MouseEventArgs e)
        {
            if(!start)
            {
                if(e.Button == MouseButtons.Left)
                {
                    selectX = e.X;
                    selectY = e.Y;
                    selectPen = new Pen(Color.Red, 2);
                    selectPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                }

                picCapture.Refresh();
                start = true;
            }
        }

        private void picCapture_MouseMove(object sender, MouseEventArgs e)
        {
            if (picCapture.Image == null)
            {
                return;
            }

            if (start)
            {
                picCapture.Refresh();

                selectWidth = e.X - selectX;
                selectHeight = e.Y - selectY;

                picCapture.CreateGraphics().SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                picCapture.CreateGraphics().DrawRectangle(selectPen, selectX, selectY, selectWidth, selectHeight);
            }
        }

        private void picCapture_MouseUp(object sender, MouseEventArgs e)
        {
            if (picCapture.Image == null)
            {
                return;
            }

            if (e.Button == MouseButtons.Left)
            {
                picCapture.Refresh();

                selectWidth = e.X - selectX;
                selectHeight = e.Y -selectY;

                picCapture.CreateGraphics().DrawRectangle(selectPen, selectX, selectY, selectWidth, selectHeight);
            }

            start = false;
            Cursor = Cursors.Arrow;
            DialogResult = DialogResult.OK;
        }
    }
}
