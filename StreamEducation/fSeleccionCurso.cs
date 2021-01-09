using MySql.Data.MySqlClient;
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
    public partial class fSeleccionCurso : Form
    {

        private List<(int, string, int)> cursos;

        public fSeleccionCurso()
        {
            InitializeComponent();
        }

        private void fSeleccionCurso_Load(object sender, EventArgs e)
        {
            Recarga();
            RecargaCursos();
        }

        private void Recarga()
        {
            bool usuarioIniciado = GestorGlobal.UsuarioActivo != null;
            bRegistrarse.Visible = !usuarioIniciado;
            bIniciarSesion.Visible = !usuarioIniciado;
            bPerfil.Visible = usuarioIniciado;
            bCerrarSesion.Visible = usuarioIniciado;
            bCrearCurso.Visible = usuarioIniciado && (GestorGlobal.UsuarioActivo.RolProfesor || GestorGlobal.UsuarioActivo.RolAdmin);
        }

        private void RecargaCursos()
        {
            cursos = Curso.listaCursos();
            lCursos.Items.Clear();
            lPublico.Items.Clear();
            foreach ((int, string, int) c in cursos)
            {
                lCursos.Items.Add(c.Item2);
                if (c.Item3 == 1) { lPublico.Items.Add("✔️"); }
                else { lPublico.Items.Add("❌"); }
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

        private void bCrearCurso_Click(object sender, EventArgs e)
        {
            fCrearCurso ventana = new fCrearCurso();
            ventana.ShowDialog();
            RecargaCursos();
        }

        private void lCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lCursos.SelectedIndex >= 0)
            {
                int id = cursos[lCursos.SelectedIndex].Item1;
                Curso curso = new Curso(id);
                bool usuarioPoder = GestorGlobal.UsuarioActivo != null && (GestorGlobal.UsuarioActivo.Id == curso.Profesor.Id || GestorGlobal.UsuarioActivo.RolAdmin);
                
                if (curso.Publico || usuarioPoder)
                {
                    entrarEnCurso(curso);
                }
                else if (GestorGlobal.UsuarioActivo != null)
                {
                    if (GestorGlobal.UsuarioActivo.estaInscrito(curso.Id))
                    {
                        entrarEnCurso(curso);
                    }
                    else
                    {
                        fInscripcion ventana = new fInscripcion(curso.Id);
                        ventana.ShowDialog();
                    }
                }
                else
                {
                    fError error = new fError("Debes estar registrado para acceder.");
                    error.ShowDialog();
                }
            }
        }

        private void entrarEnCurso(Curso curso)
        {
            GestorGlobal.CursoActivo = curso;
            this.Visible = false;
            fCurso ventana = new fCurso();
            ventana.ShowDialog();
            GestorGlobal.CursoActivo = null;
            Recarga();
            RecargaCursos();
            this.Visible = true;
        }

    }
}
