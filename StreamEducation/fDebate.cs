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
    public partial class fDebate : Form
    {
        public fDebate()
        {
            InitializeComponent();
        }

        private void fDebate_Load(object sender, EventArgs e)
        {
            labelForo.Text = GestorGlobal.ForoActivo.Nombre;
            labelDebate.Text = GestorGlobal.DebateActivo.Nombre;
            tDescripcion.Text = GestorGlobal.DebateActivo.Descripcion;
            labelCreador.Text = GestorGlobal.DebateActivo.Creador.Nombre;
            labelCurso.Text = GestorGlobal.ForoActivo.Curso.Nombre;
            Recarga();
            foreach (Mensaje m in GestorGlobal.DebateActivo.getMensajes()) lMensajes.Items.Add(m);
        }

        private void Recarga()
        {
            bool usuarioIniciado = GestorGlobal.UsuarioActivo != null;
            bRegistrarse.Visible = !usuarioIniciado;
            bIniciarSesion.Visible = !usuarioIniciado;
            bPerfil.Visible = usuarioIniciado;
            bCerrarSesion.Visible = usuarioIniciado;
            bAddMensaje.Visible = usuarioIniciado;
            bBorrar.Visible = usuarioIniciado && (GestorGlobal.UsuarioActivo.Id == GestorGlobal.CursoActivo.Profesor.Id || GestorGlobal.UsuarioActivo.RolAdmin);
        }

        private void bInicio_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void bPerfil_Click(object sender, EventArgs e)
        {
            fPerfil ventana = new fPerfil();
            ventana.ShowDialog();
            Recarga();
        }

        private void bAddMensaje_Click(object sender, EventArgs e)
        {
            fCrearMensaje ventana = new fCrearMensaje();
            ventana.ShowDialog();
            lMensajes.Items.Clear();
            foreach (Mensaje m in GestorGlobal.DebateActivo.getMensajes()) lMensajes.Items.Add(m);
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            fConfirmacion ventana = new fConfirmacion();
            ventana.ShowDialog();
            if (ventana.Valor)
            {
                GestorGlobal.DebateActivo.Borrar();
                GestorGlobal.DebateActivo = null;
                this.Close();
            }
        }

        private void lMensajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lMensajes.SelectedIndex >= 0)
            {
                fMostrarMensaje ventana = new fMostrarMensaje((Mensaje)lMensajes.SelectedItem);
                ventana.ShowDialog();
                lMensajes.Items.Clear();
                foreach (Mensaje m in GestorGlobal.DebateActivo.getMensajes()) lMensajes.Items.Add(m);
            }
        }

    }
}
