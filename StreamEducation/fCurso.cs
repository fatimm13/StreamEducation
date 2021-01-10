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
    public partial class fCurso : Form
    {

        private List<(int, string, string)> recursos;
        private List<(int, string)> foros;

        public fCurso()
        {
            InitializeComponent();
        }

        private void fCurso_Load(object sender, EventArgs e)
        {
            labelProfesor.Text = GestorGlobal.CursoActivo.Profesor.Nombre;
            labelFecha.Text = GestorGlobal.CursoActivo.Fecha;
            labelCurso.Text = GestorGlobal.CursoActivo.Nombre;
            tDescripcion.Text = GestorGlobal.CursoActivo.Descripcion;
            RecargaRecursos();
            Recarga();
            RecargaForos();
        }

        private void Recarga()
        {
            bool usuarioIniciado = GestorGlobal.UsuarioActivo != null;
            if (!GestorGlobal.CursoActivo.Publico && !usuarioIniciado) { this.Close(); }
            bRegistrarse.Visible = !usuarioIniciado;
            bIniciarSesion.Visible = !usuarioIniciado;
            bPerfil.Visible = usuarioIniciado;
            bCerrarSesion.Visible = usuarioIniciado;
            bValorar.Visible = usuarioIniciado;
            bool usuarioPoder = usuarioIniciado && (GestorGlobal.UsuarioActivo.Id == GestorGlobal.CursoActivo.Profesor.Id || GestorGlobal.UsuarioActivo.RolAdmin);
            bCrearForo.Visible = usuarioPoder;
            bCrearRecurso.Visible = usuarioPoder;
            bBorrar.Visible = usuarioPoder;
            lBorrar.Visible = usuarioPoder;
            bCrearTest.Visible = usuarioPoder;
            bCrearClase.Visible = usuarioPoder;
            labelInscritos.Visible = !GestorGlobal.CursoActivo.Publico && usuarioPoder;
            labelPeticion.Visible = !GestorGlobal.CursoActivo.Publico && usuarioPoder;
            bInscritos.Visible = !GestorGlobal.CursoActivo.Publico && usuarioPoder;
            bPeticiones.Visible = !GestorGlobal.CursoActivo.Publico && usuarioPoder;
            if (usuarioPoder)
            {
                lBorrar.Items.Clear();
                foreach ((int, string, string) r in recursos) lBorrar.Items.Add("🗑️ Borrar");
            }
            marcarCalendario();
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
        private void RecargaRecursos()
        {
            recursos = GestorGlobal.CursoActivo.getRecursos();
            lRecursos.Items.Clear();
            foreach ((int, string, string) r in recursos) lRecursos.Items.Add(r.Item2);
        }

        private void RecargaRecursosYBorrar()
        {
            recursos = GestorGlobal.CursoActivo.getRecursos();
            lRecursos.Items.Clear();
            lBorrar.Items.Clear();
            foreach ((int, string, string) r in recursos)
            {
                lRecursos.Items.Add(r.Item2);
                lBorrar.Items.Add("🗑️ Borrar");
            }
        }

        private void RecargaForos()
        {
            foros = GestorGlobal.CursoActivo.getForos();
            lForos.Items.Clear();
            foreach ((int, string) f in foros) lForos.Items.Add(f.Item2);
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
            fValoracion ventana = new fValoracion();
            ventana.ShowDialog();
        }

        private void bInscritos_Click(object sender, EventArgs e)
        {
            fUsuariosInscritos ventana = new fUsuariosInscritos();
            ventana.ShowDialog();
        }

        private void bPeticiones_Click(object sender, EventArgs e)
        {
            fUsuariosPendientes ventana = new fUsuariosPendientes();
            ventana.ShowDialog();
        }

        private void bCrearTest_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.google.com/forms/u/0/");
        }

        private void bCrearClase_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://meet.google.com/?hs=197&pli=1&authuser=0");
        }

        private void bCrearForo_Click(object sender, EventArgs e)
        {
            fCrearForo ventana = new fCrearForo();
            ventana.ShowDialog();
            RecargaForos();
        }

        private void bCrearRecurso_Click(object sender, EventArgs e)
        {
            fCrearRecurso ventana = new fCrearRecurso();
            ventana.ShowDialog();
            RecargaRecursosYBorrar();
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            fConfirmacion ventana = new fConfirmacion();
            ventana.ShowDialog();
            if (ventana.Valor)
            {
                GestorGlobal.CursoActivo.Borrar();
                GestorGlobal.CursoActivo = null;
                this.Close();
            }
        }

        private void lForos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lForos.SelectedIndex >= 0)
            {
                int id = foros[lForos.SelectedIndex].Item1;
                GestorGlobal.ForoActivo = new Foro(id);
                fForo ventana = new fForo();
                this.Visible = false;
                ventana.ShowDialog();
                this.Visible = true;
                GestorGlobal.ForoActivo = null;
                RecargaForos();
                Recarga();
            }
        }

        private void lRecursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lRecursos.SelectedIndex >= 0)
            {
                try
                {
                    string link = recursos[lRecursos.SelectedIndex].Item3;
                    System.Diagnostics.Process.Start(link);
                }
                catch
                {
                    fError ventana = new fError("El recurso no se encuentra disponible.");
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
                    int id = recursos[lBorrar.SelectedIndex].Item1;
                    Recurso recurso = new Recurso(id);
                    recurso.Borrar();
                    recurso = null;
                    RecargaRecursosYBorrar();
                }
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
