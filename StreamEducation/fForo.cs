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

        private List<(int, string, string, string)> debates;

        public fForo()
        {
            InitializeComponent();
        }

        private void fForo_Load(object sender, EventArgs e)
        {
            labelForo.Text = GestorGlobal.ForoActivo.Nombre;
            tDescripcion.Text = GestorGlobal.ForoActivo.Descripcion;
            labelCreador.Text = GestorGlobal.ForoActivo.Creador.Nombre;
            labelCurso.Text = GestorGlobal.ForoActivo.Curso.Nombre;
            Recarga();
            RecargaDebates();
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
            if (!GestorGlobal.CursoActivo.Publico && !usuarioIniciado) { this.Close(); }
            bRegistrarse.Visible = !usuarioIniciado;
            bIniciarSesion.Visible = !usuarioIniciado;
            bPerfil.Visible = usuarioIniciado;
            bCerrarSesion.Visible = usuarioIniciado;
            bAddDebate.Visible = usuarioIniciado;
            bBorrar.Visible = usuarioIniciado && (GestorGlobal.UsuarioActivo.Id == GestorGlobal.ForoActivo.Creador.Id || GestorGlobal.UsuarioActivo.RolAdmin);
            marcarCalendario();
        }

        private void RecargaDebates()
        {
            debates = GestorGlobal.ForoActivo.getDebates();
            lDebate.Items.Clear();
            lCreador.Items.Clear();
            lIntervenciones.Items.Clear();
            foreach ((int, string, string, string)d in debates)
            {
                lDebate.Items.Add(d.Item2);
                lCreador.Items.Add(d.Item3);
                lIntervenciones.Items.Add(d.Item4);
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

        private void bAddDebate_Click(object sender, EventArgs e)
        {
            fCrearDebate ventana = new fCrearDebate();
            ventana.ShowDialog();
            RecargaDebates();
        }

        private void lDebate_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lDebate.SelectedIndex >= 0)
            {
                int id = debates[lDebate.SelectedIndex].Item1;
                EntrarDebate(id);
            }
        }

        private void lCreador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lCreador.SelectedIndex >= 0)
            {
                int id = debates[lCreador.SelectedIndex].Item1;
                EntrarDebate(id);
            }
        }

        private void lIntervenciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lIntervenciones.SelectedIndex >= 0)
            {
                int id = debates[lIntervenciones.SelectedIndex].Item1;
                EntrarDebate(id);
            }
        }

        private void EntrarDebate(int id)
        {
            GestorGlobal.DebateActivo = new Debate(id);
            fDebate ventana = new fDebate();
            this.Visible = false;
            ventana.ShowDialog();
            GestorGlobal.DebateActivo = null;
            Recarga();
            this.Visible = true;
            RecargaDebates();
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
