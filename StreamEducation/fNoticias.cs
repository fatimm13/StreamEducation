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
    public partial class fNoticias : Form
    {
        public fNoticias()
        {
            InitializeComponent();
        }

        private void bInicio_Click(object sender, EventArgs e)
        {
            GestorGlobal.ForoActivo = null;
            this.Close();
        }

        private void bPerfil_Click(object sender, EventArgs e)
        {
            fPerfil ventana = new fPerfil();
            ventana.ShowDialog();
            Recarga();
        }

        private void bCerrarSesion_Click(object sender, EventArgs e)
        {
            fConfirmacion ventana = new fConfirmacion();
            ventana.ShowDialog();
            if (ventana.Valor)
            {
                GestorGlobal.UsuarioActivo = null;
                Recarga();
            }
        }

        private void bIniciarSesion_Click(object sender, EventArgs e)
        {
            fIniciarSesion ventana = new fIniciarSesion();
            ventana.ShowDialog();
            Recarga();
        }

        private void bRegistrarse_Click(object sender, EventArgs e)
        {
            fCrearCuenta ventana = new fCrearCuenta();
            ventana.ShowDialog();
            Recarga();
        }

        private void bAddDebate_Click(object sender, EventArgs e)
        {
            fCrearDebate ventana = new fCrearDebate();
            ventana.ShowDialog();
            lNoticias.Items.Clear();
            foreach (Debate d in GestorGlobal.ForoActivo.getDebates()) { lNoticias.Items.Add(d); }
        }

        private void fNoticias_Load(object sender, EventArgs e)
        {
            Recarga();
            foreach (Debate d in GestorGlobal.ForoActivo.getDebates()) { lNoticias.Items.Add(d); }
        }
        private void Recarga()
        {
            bool usuarioIniciado = GestorGlobal.UsuarioActivo != null;
            bRegistrarse.Visible = !usuarioIniciado;
            bIniciarSesion.Visible = !usuarioIniciado;
            bPerfil.Visible = usuarioIniciado;
            bCerrarSesion.Visible = usuarioIniciado;
            bAddNoticia.Visible = usuarioIniciado;
        }

        private void lForo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lNoticias.SelectedIndex >= 0)
            {
                GestorGlobal.DebateActivo = (Debate)lNoticias.SelectedItem;
                fDebate ventana = new fDebate();
                this.Visible = false;
                ventana.ShowDialog();
                Recarga();
                this.Visible = true;
                lNoticias.Items.Clear();
                foreach (Debate d in GestorGlobal.ForoActivo.getDebates()) { lNoticias.Items.Add(d); }
            }
        }
    }
}
