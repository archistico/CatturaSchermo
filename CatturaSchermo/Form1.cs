using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace CatturaSchermo
{

    public partial class frmCattura : Form
    {
        [DllImport("user32.dll")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);
        
        frmCapture frmCapture = new frmCapture();
        public bool acceso = false;

        public frmCattura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            nudContatore.Value = nudContatore.Value + 1;

            if (!Directory.Exists(tbxCartella.Text))
            {
                MessageBox.Show("La cartella di export non esiste", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            var encoder = ImageCodecInfo.GetImageEncoders()
                            .First(c => c.FormatID == ImageFormat.Jpeg.Guid);
            var encParams = new EncoderParameters(1);
            encParams.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, 90L);

            int x = (int)nudSX_X.Value;
            int y = (int)nudSX_Y.Value;
            int w = (int)nudDX_X.Value - (int)nudSX_X.Value;
            int h = (int)nudDX_Y.Value - (int)nudSX_Y.Value;

            Rectangle bounds = new Rectangle(x,y,w,h);

            using (Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height))
            {
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    g.CopyFromScreen(new Point(x, y), Point.Empty, bounds.Size);
                }
                bitmap.Save(tbxCartella.Text+tbxPrefisso.Text+"_" + ((int)nudContatore.Value).ToString("00000") + ".jpg", encoder, encParams);
            }

            // METTERE IL BROWSER APERTO SULLA SCHEDA
            Send();
        }
               
        public void Send()
        {
            System.Diagnostics.Process[] p = System.Diagnostics.Process.GetProcessesByName(tbxProcesso.Text); //search for process notepad

            foreach (var x in p)
            {
                if (x.MainWindowTitle.StartsWith(tbxProcessoTitolo.Text))
                {
                    SetForegroundWindow(x.MainWindowHandle);
                    SendKeys.SendWait(tbxTasto.Text);
                }
            }
        }

        private void btnLista_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process[] p = System.Diagnostics.Process.GetProcesses();

            foreach (var x in p)
            {
                Console.WriteLine($"{x.ProcessName} -> {x.MainWindowTitle}");
            }
        }

        private void btnCoord_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Thread.Sleep(200);
            frmCapture.ShowDialog();
            this.Show();
            nudSX_X.Value = frmCapture.selectX;            
            nudSX_Y.Value = frmCapture.selectY;

            nudDX_X.Value = frmCapture.selectX + frmCapture.selectWidth;
            nudDX_Y.Value = frmCapture.selectY + frmCapture.selectHeight;
        }

        private void btnApri_Click(object sender, EventArgs e)
        {
            if (!Directory.Exists(tbxCartella.Text))
            {
                MessageBox.Show("La cartella di export non esiste", "Attenzione", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Process.Start("explorer.exe", tbxCartella.Text);
        }
    }
}
