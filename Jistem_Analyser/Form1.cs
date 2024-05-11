using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Windows.Forms;

namespace Jistem_Analyser
{
    public partial class JystemAnalytics : Form
    {
        public JystemAnalytics()
        {
            InitializeComponent();
            AtualizarNomeSistema();
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25)); // deixa a borda arredondada
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
        }

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRec, int nRightRect, int nBottomRect, int nWidthE11ipse, int nHeightE11ipse);

        private void AtualizarNomeSistema()
        {
            string nomeSistema = Environment.UserName;
            lbNomeSistema.Text = nomeSistema;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr one, int two, int three, int four);

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, 0x112, 0xf012, 0);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(232, 17, 35); // Altera a cor de fundo quando o mouse entra
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.FromArgb(22, 22, 22); // Restaura a cor de fundo quando o mouse sai
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnDashboard.Height;
            pnlNav.Top = btnDashboard.Top;
            pnlNav.Left = btnDashboard.Left;
            btnDashboard.BackColor = Color.FromArgb(26, 26, 26);
        }

        private void btnPlacaMae_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnPlacaMae.Height;
            pnlNav.Top = btnPlacaMae.Top;
            btnPlacaMae.BackColor = Color.FromArgb(26, 26, 26);
        }

        private void btnMemoria_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnMemoria.Height;
            pnlNav.Top = btnMemoria.Top;
            btnMemoria.BackColor = Color.FromArgb(26, 26, 26);
        }

        private void btnVideo_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnVideo.Height;
            pnlNav.Top = btnVideo.Top;
            btnVideo.BackColor = Color.FromArgb(26, 26, 26);
        }

        private void btnDashboard_Leave(object sender, EventArgs e)
        {
            btnDashboard.BackColor = Color.FromArgb(22, 22, 22);
        }

        private void btnPlacaMae_Leave(object sender, EventArgs e)
        {
            btnPlacaMae.BackColor = Color.FromArgb(22, 22, 22);
        }

        private void btnMemoria_Leave(object sender, EventArgs e)
        {
            btnMemoria.BackColor = Color.FromArgb(22, 22, 22);
        }

        private void btnVideo_Leave(object sender, EventArgs e)
        {
            btnVideo.BackColor = Color.FromArgb(22, 22, 22);
        }

        private void pnlHeader_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
