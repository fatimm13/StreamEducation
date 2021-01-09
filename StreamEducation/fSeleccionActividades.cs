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
    public partial class fSeleccionActividades : Form
    {

        private List<(int, string)> actividades;

        public fSeleccionActividades()
        {
            InitializeComponent();
        }

        private void fSeleccionActividades_Load(object sender, EventArgs e)
        {
            Recarga();
            RecargaActividades();
        }

        private void Recarga()
        {
            bool usuarioIniciado = GestorGlobal.UsuarioActivo != null;
            bRegistrarse.Visible = !usuarioIniciado;
            bIniciarSesion.Visible = !usuarioIniciado;
            bPerfil.Visible = usuarioIniciado;
            bCerrarSesion.Visible = usuarioIniciado;
            bCrearActividad.Visible = usuarioIniciado && (GestorGlobal.UsuarioActivo.RolAsociacion || GestorGlobal.UsuarioActivo.RolAdmin);
        }

        private void RecargaActividades()
        {
            actividades = Actividad.listaActividades();
            lActividades.Items.Clear();
            foreach ((int, string) a in actividades) lActividades.Items.Add(a.Item2);
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

        private void bCrearActividad_Click(object sender, EventArgs e)
        {
            fCrearActividad ventana = new fCrearActividad();
            ventana.ShowDialog();
            Recarga();
            RecargaActividades();
        }     

        private void lActividades_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lActividades.SelectedIndex >= 0)
            {
                int id = actividades[lActividades.SelectedIndex].Item1;
                GestorGlobal.ActividadActiva = new Actividad(id);
                this.Visible = false;
                fActividad ventana = new fActividad();
                ventana.ShowDialog();
                GestorGlobal.ActividadActiva = null;
                Recarga();
                this.Visible = true;
                RecargaActividades();
            }
        }

    }
}
