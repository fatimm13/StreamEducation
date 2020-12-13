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
        public fSeleccionCurso()
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
            Curso curso = ventana.Valor;
            if (curso != null)
            {
                lCursos.Items.Add(curso);
                lPublico.Items.Add("✔️");
            }
        }

        private void fSeleccionCurso_Load(object sender, EventArgs e)
        {
            Recarga();
            foreach (Curso c in Curso.listaCursos())
            {
                lCursos.Items.Add(c);
                if (c.Publico) { lPublico.Items.Add("✔️"); }
                else { lPublico.Items.Add("❌"); }
            }
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

        private void lCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            GestorGlobal.CursoActivo = (Curso)lCursos.SelectedItem;
            this.Visible = false;
            fCurso ventana = new fCurso();
            ventana.ShowDialog();
            Recarga();
            this.Visible = true;
        }

    }
}
