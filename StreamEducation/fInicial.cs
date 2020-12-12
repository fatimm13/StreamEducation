using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StreamEducation
{
    public partial class fInicial : Form
    {
        public fInicial()
        {
            GestorGlobal.UsuarioActivo = null;
            InitializeComponent();
        }

        private void bCurso_Click(object sender, EventArgs e)
        {
            fSeleccionCurso ventana= new fSeleccionCurso();
            this.Visible = false;
            ventana.ShowDialog();
            Recarga();
            this.Visible = true;
        }

        //TODO: Crear el foro inicial
        private void bForo_Click(object sender, EventArgs e)
        {
            fForo ventana = new fForo();
            this.Visible = false;
            ventana.ShowDialog();
            Recarga();
            this.Visible = true;
        }

        private void bActividades_Click(object sender, EventArgs e)
        {
            fRecurso ventana = new fRecurso();
            this.Visible = false;
            ventana.ShowDialog();
            Recarga();
            this.Visible = true;
        }

        private void bRegistrarse_Click(object sender, EventArgs e)
        {
            fCrearCuenta ventana = new fCrearCuenta();
            ventana.ShowDialog();
            Recarga();
        }

        private void bIniciarSesion_Click(object sender, EventArgs e)
        {
            fIniciarSesion ventana = new fIniciarSesion();
            ventana.ShowDialog();
            Recarga();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            this.linkLabel1.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("https://informatica.cv.uma.es/pluginfile.php/397985/mod_resource/content/1/Informa%CC%81tica%20ApS19.pdf");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Specify that the link was visited.
            this.linkLabel1.LinkVisited = true;

            // Navigate to a URL.
            System.Diagnostics.Process.Start("http://www.uma.es");
        }
        private void bPerfil_Click(object sender, EventArgs e)
        {
            fPerfil ventana = new fPerfil();
            ventana.ShowDialog();
            Recarga();
        }
        private void fInicial_Load(object sender, EventArgs e)
        {
            Recarga();
        }

        private void Recarga()
        {
            bool usuarioIniciado = GestorGlobal.UsuarioActivo != null;
            bRegistrarse.Visible = !usuarioIniciado;
            bIniciarSesion.Visible = !usuarioIniciado;
            bPerfil.Visible = usuarioIniciado;
        }

        
    }
}
