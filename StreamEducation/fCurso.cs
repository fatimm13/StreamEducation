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
        public fCurso()
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

        private void fCurso_Load(object sender, EventArgs e)
        {
            Curso curso = GestorGlobal.CursoActivo;
            if (curso!=null)
            {
                foreach (Recurso r in curso.getRecursos()) lRecursos.Items.Add(r);
                foreach (Foro f in curso.getForos()) lForos.Items.Add(f);
            }
            Recarga();
        }
        private void Recarga()
        {
            bool usuarioIniciado = GestorGlobal.UsuarioActivo != null;
            bRegistrarse.Visible = !usuarioIniciado;
            bIniciarSesion.Visible = !usuarioIniciado;
            bPerfil.Visible = usuarioIniciado;
            labelCurso.Text = GestorGlobal.CursoActivo.Nombre;
            tDescripcion.Text = GestorGlobal.CursoActivo.Descripcion;
        }

        private void lRecursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lRecursos.SelectedIndex>=0)   System.Diagnostics.Process.Start(((Recurso)lRecursos.SelectedItem).Link);
        }

        private void bCrearCurso_Click(object sender, EventArgs e)
        {

        }

        private void lForos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lForos.SelectedIndex >= 0)
            {
                GestorGlobal.ForoActivo = (Foro) lForos.SelectedItem;
                fForo ventana = new fForo();
                this.Visible = false;
                ventana.ShowDialog();
                Recarga();
            }
        }
    }
}
