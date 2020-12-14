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
            Debate debate = ventana.Valor;
            if (debate != null)
            {
                lForo.Items.Add(debate);
                lCreador.Items.Add(debate.Creador);
                lIntervenciones.Items.Add(debate.intervenciones());
            }
        }

        private void fForo_Load(object sender, EventArgs e)
        {
            labelForo.Text = GestorGlobal.ForoActivo.Nombre;
            tDescripcion.Text = GestorGlobal.ForoActivo.Descripcion;
            labelCreador.Text = GestorGlobal.ForoActivo.Creador.Nombre;
            labelCurso.Text = GestorGlobal.ForoActivo.Curso.Nombre;
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
            bCerrarSesion.Visible = usuarioIniciado;
            bAddDebate.Visible = usuarioIniciado;
            bBorrar.Visible = usuarioIniciado && (GestorGlobal.UsuarioActivo.RolProfesor || GestorGlobal.UsuarioActivo.RolAdmin);
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
                this.Visible = true;
            }
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            fConfirmacion ventana = new fConfirmacion();
            ventana.ShowDialog();
            if (ventana.Valor)
            {
                GestorGlobal.ForoActivo.Borrar();
                GestorGlobal.ForoActivo = null;
                this.Close();
            }
        }
    }
}
