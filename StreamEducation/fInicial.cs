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
            GestorGlobal.CursoActivo = null;
            GestorGlobal.ForoActivo = null;
            GestorGlobal.DebateActivo = null;
            InitializeComponent();
        }

        private void fInicial_Load(object sender, EventArgs e)
        {
            Recarga();
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
            marcarCalendario();
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://drive.google.com/file/d/1WakPIcN9tgiAz7gyVG1FTTK-CngAbkLp/view?usp=sharing");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://www.feyalegria.org/venezuela/donar/");
        }

        private void bCurso_Click(object sender, EventArgs e)
        {
            fSeleccionCurso ventana = new fSeleccionCurso();
            this.Visible = false;
            ventana.ShowDialog();
            Recarga();
            this.Visible = true;
        }

        private void bForo_Click(object sender, EventArgs e)
        {
            GestorGlobal.CursoActivo = new Curso(0);
            GestorGlobal.ForoActivo = new Foro(0);
            fNoticias ventana = new fNoticias();
            this.Visible = false;
            ventana.ShowDialog();
            GestorGlobal.CursoActivo = null;
            GestorGlobal.ForoActivo = null;
            Recarga();
            this.Visible = true;
        }

        private void bActividades_Click(object sender, EventArgs e)
        {
            fSeleccionActividades ventana = new fSeleccionActividades();
            this.Visible = false;
            ventana.ShowDialog();
            Recarga();
            this.Visible = true;
        }

        private void monthCalendar_DateSelected(object sender, DateRangeEventArgs e)
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
