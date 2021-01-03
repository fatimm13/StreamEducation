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
    public partial class fPerfil : Form
    {
        public fPerfil()
        {
            InitializeComponent();
        }

        private void bBorrarCuenta_Click(object sender, EventArgs e)
        {
            fConfirmacion ventana = new fConfirmacion();
            ventana.ShowDialog();
            if (ventana.Valor)
            {
                GestorGlobal.UsuarioActivo.Borrar();
                GestorGlobal.UsuarioActivo = null;
                this.Close();
            }
        }

        private void bActualizar_Click(object sender, EventArgs e)
        {
            fActualizarPerfil ventana = new fActualizarPerfil();
            ventana.ShowDialog();
            Actualiza();
        }

        private void fPerfil_Load(object sender, EventArgs e)
        {
            Actualiza();
            if (GestorGlobal.UsuarioActivo.RolAdmin)
            {
                labelRol.Text = "Administrador";
            }
            else if (GestorGlobal.UsuarioActivo.RolProfesor)
            {
                labelRol.Text = "Profesor";
            }
            else
            {
                labelRol.Text = "Estudiante";
            }
            foreach (Curso c in GestorGlobal.UsuarioActivo.getCursos()) lCursos.Items.Add(c.Nombre);
        }
        private void Actualiza()
        {
            labelNombre.Text = GestorGlobal.UsuarioActivo.Nombre;
            labelEscuela.Text = GestorGlobal.UsuarioActivo.Escuela;
            labelPais.Text = GestorGlobal.UsuarioActivo.Pais;
            tBio.Text = GestorGlobal.UsuarioActivo.Biografia;
        }

        private void bMensajeria_Click(object sender, EventArgs e)
        {
            fMensajeria ventana = new fMensajeria();
            ventana.ShowDialog();
            Actualiza();
        }
    }
}
