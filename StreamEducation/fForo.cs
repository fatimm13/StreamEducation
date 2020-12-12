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
    public partial class fForo : Form
    {
        public fForo()
        {
            InitializeComponent();
        }

        private void bInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bPerfil_Click(object sender, EventArgs e)
        {
            fPerfil ventana = new fPerfil();
            ventana.ShowDialog();
            Recarga();
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
            Recarga();
        }

        private void fForo_Load(object sender, EventArgs e)
        {
            Recarga();
            foreach (Debate d in GestorGlobal.ForoActivo.getDebates())
            {
                lForo.Items.Add(d);
                lCreador.Items.Add(d.Creador);
                lIntervenciones.Items.Add(d.intervenciones());
            }
        }
        private void Recarga()
        {
            bool usuarioIniciado = GestorGlobal.UsuarioActivo != null;
            bRegistrarse.Visible = !usuarioIniciado;
            bIniciarSesion.Visible = !usuarioIniciado;
            bPerfil.Visible = usuarioIniciado;
            labelForo.Text = GestorGlobal.ForoActivo.Nombre;
            tDescripcion.Text = GestorGlobal.ForoActivo.Descripcion;
        }

        private void lForo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lForo.SelectedIndex >= 0)
            {
                GestorGlobal.DebateActivo = (Debate) lForo.SelectedItem;
                fDebate ventana = new fDebate();
                this.Visible = false;
                ventana.ShowDialog();
                Recarga();
            }
        }
        
    }
}
