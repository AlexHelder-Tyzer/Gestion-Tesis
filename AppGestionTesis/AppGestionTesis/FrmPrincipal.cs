using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using CapaClases;
using CapaFormularios;

namespace AppGestionTesis
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            AbrirPanel(new FrmInicio());
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wsmg, int wparam, int lparam);

        private void IconCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void IconMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            IconMaximizar.Visible = false;
            IconRestaurar.Visible = true;
        }

        private void IconRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            IconRestaurar.Visible = false;
            IconMaximizar.Visible = true;
        }

        private void IconMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void PanTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }


        private void AbrirPanel(object FormHija)
        {
            if(this.PanContenedor.Controls.Count > 0)
            {
                this.PanContenedor.Controls.RemoveAt(0);
            }

            Form formHija = FormHija as Form;
            formHija.TopLevel = false;
            formHija.Dock = DockStyle.Fill;
            this.PanContenedor.Controls.Add(formHija);
            this.PanContenedor.Tag = formHija;
            formHija.Show();
        }
        private void BtnDocente_Click(object sender, EventArgs e)
        {
            AbrirPanel(new FrmDocente());
        }

        private void BtnTesista_Click(object sender, EventArgs e)
        {
            AbrirPanel(new FrmTesista());
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            AbrirPanel(new FrmInicio());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            AbrirPanel(new FrmInicio());
        }

        private void BtnRequisitos_Click(object sender, EventArgs e)
        {
            AbrirPanel(new FrmRequisitos());
        }

        private void BtnTramite_Click(object sender, EventArgs e)
        {
            AbrirPanel(new FrmTramite());
        }

        private void BtnRequisitosTramite_Click(object sender, EventArgs e)
        {
            AbrirPanel(new FrmRequistosPorTramite());
        }
    }
}
