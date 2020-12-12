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

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bActualizar_Click(object sender, EventArgs e)
        {
            fActualizarPerfil ventana = new fActualizarPerfil();
            ventana.ShowDialog();
            Recarga();
        }

        private void fPerfil_Load(object sender, EventArgs e)
        {
            Recarga();
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
        private void Recarga()
        {
            Usuario usuario = GestorGlobal.UsuarioActivo;
            labelNombre.Text = usuario.Nombre;
            labelEscuela.Text = usuario.Escuela;
            labelPais.Text = usuario.Pais;
            tBio.Text = usuario.Biografia;
        }
    }
}
