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
    public partial class fActividad : Form
    {
        public fActividad()
        {
            InitializeComponent();
        }

        private void fActividad_Load(object sender, EventArgs e)
        {
            if (GestorGlobal.ActividadActiva != null)
            {
                foreach (RecursoActividad r in GestorGlobal.ActividadActiva.getRecursos()) lRecursos.Items.Add(r);
            }
            labelOrganizador.Text = GestorGlobal.ActividadActiva.Organizacion.Nombre;
            labelFecha.Text = GestorGlobal.ActividadActiva.Fecha;
            labelActividad.Text = GestorGlobal.ActividadActiva.Nombre;
            tDescripcion.Text = GestorGlobal.ActividadActiva.Descripcion;
            Recarga();
        }

        private void Recarga()
        {
            bool usuarioIniciado = GestorGlobal.UsuarioActivo != null;
            bRegistrarse.Visible = !usuarioIniciado;
            bIniciarSesion.Visible = !usuarioIniciado;
            bPerfil.Visible = usuarioIniciado;
            bCerrarSesion.Visible = usuarioIniciado;
            bValorar.Visible = usuarioIniciado;
            bool usuarioPoder = usuarioIniciado && (GestorGlobal.UsuarioActivo.Id == GestorGlobal.ActividadActiva.Organizacion.Id || GestorGlobal.UsuarioActivo.RolAdmin);
            bCrearRecurso.Visible = usuarioPoder;
            bBorrar.Visible = usuarioPoder;
            lBorrar.Visible = usuarioPoder;
            lBorrar.Items.Clear();
            if (usuarioPoder)
            {
                foreach (RecursoActividad r in GestorGlobal.ActividadActiva.getRecursos()) lBorrar.Items.Add("🗑️ Borrar");
            }
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

        private void bValorar_Click(object sender, EventArgs e)
        {
            fValoracionActividad ventana = new fValoracionActividad();
            ventana.ShowDialog();
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            fConfirmacion ventana = new fConfirmacion();
            ventana.ShowDialog();
            if (ventana.Valor)
            {
                GestorGlobal.ActividadActiva.Borrar();
                GestorGlobal.ActividadActiva = null;
                this.Close();
            }
        }

        private void bCrearRecurso_Click(object sender, EventArgs e)
        {
            fCrearRecursoActividad ventana = new fCrearRecursoActividad();
            ventana.ShowDialog();
            lRecursos.Items.Clear();
            lBorrar.Items.Clear();
            foreach (RecursoActividad r in GestorGlobal.ActividadActiva.getRecursos())
            {
                lRecursos.Items.Add(r);
                lBorrar.Items.Add("🗑️ Borrar");
            }
        }

        private void lRecursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lRecursos.SelectedIndex >= 0)
            {
                try
                {
                    System.Diagnostics.Process.Start(((RecursoActividad)lRecursos.SelectedItem).Link);
                }
                catch
                {
                    fError ventana = new fError("Recurso no disponible.");
                    ventana.ShowDialog();
                }
            }
        }

        private void lBorrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = lBorrar.SelectedIndex;
            if (index >= 0)
            {
                fConfirmacion ventana = new fConfirmacion();
                ventana.ShowDialog();
                if (ventana.Valor)
                {
                    RecursoActividad recurso = (RecursoActividad)lRecursos.Items[index];
                    recurso.Borrar();
                    lRecursos.Items.Clear();
                    lBorrar.Items.Clear();
                    foreach (RecursoActividad r in GestorGlobal.ActividadActiva.getRecursos())
                    {
                        lRecursos.Items.Add(r);
                        lBorrar.Items.Add("🗑️ Borrar");
                    }
                }
            }
        }

    }
}
