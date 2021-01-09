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
    public partial class fMostrarNoticia : Form
    {

        private List<(int, string)> mensajes;

        public fMostrarNoticia()
        {
            InitializeComponent();
        }

        private void fMostrarNoticia_Load(object sender, EventArgs e)
        {
            labelNoticia.Text = GestorGlobal.DebateActivo.Nombre;
            tDescripcion.Text = GestorGlobal.DebateActivo.Descripcion;
            Recarga();
            RecargaMensajes();
        }
        private void marcarCalendario()
        {
            monthCalendar1.RemoveAllBoldedDates();
            GestorGlobal.rellenarCalendario();
            foreach (DateTime d in GestorGlobal.getCalendario().Keys)
            {
                monthCalendar1.AddBoldedDate(d);
            }
            monthCalendar1.UpdateBoldedDates();
        }
        private void Recarga()
        {
            bool usuarioIniciado = GestorGlobal.UsuarioActivo != null;
            bRegistrarse.Visible = !usuarioIniciado;
            bIniciarSesion.Visible = !usuarioIniciado;
            bPerfil.Visible = usuarioIniciado;
            bCerrarSesion.Visible = usuarioIniciado;
            bAddMensaje.Visible = usuarioIniciado;
            bBorrar.Visible = usuarioIniciado && GestorGlobal.UsuarioActivo.RolAdmin;
            marcarCalendario();
        }

        private void RecargaMensajes()
        {
            mensajes = GestorGlobal.DebateActivo.getMensajes();
            lMensajes.Items.Clear();
            foreach ((int, string) m in mensajes) lMensajes.Items.Add(m.Item2);
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
            RecargaMensajes();
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
                int id = mensajes[lMensajes.SelectedIndex].Item1;
                fMostrarComentario ventana = new fMostrarComentario(new Mensaje(id));
                ventana.ShowDialog();
                RecargaMensajes();
            }
        }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            List<String> value;
            DateTime date = monthCalendar1.SelectionRange.Start;
            if (GestorGlobal.getCalendario().TryGetValue(date, out value))
            {
                fEventos ev = new fEventos(date, value);
                ev.ShowDialog();
            }
        }
    }
}
