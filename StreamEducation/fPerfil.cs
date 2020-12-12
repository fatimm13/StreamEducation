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
        Usuario usuario;
        public fPerfil(ref Usuario user)
        {
            usuario = user;
            InitializeComponent();
        }

        private void bBorrarCuenta_Click(object sender, EventArgs e)
        {

        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bActualizar_Click(object sender, EventArgs e)
        {
            fActualizarPerfil ventana = new fActualizarPerfil();
            ventana.ShowDialog();
        }

        private void fPerfil_Load(object sender, EventArgs e)
        {
            labelNombre.Text = usuario.Nombre;
            if (usuario.RolAdmin)
            {
                labelRol.Text = "Administrador";
            }
            else if (usuario.RolProfesor)
            {
                labelRol.Text = "Profesor";
            }
            else
            {
                labelRol.Text = "Estudiante";
            }
            if (usuario.Escuela == null) { labelEscuela.Text = "No especificada"; } else { labelEscuela.Text = usuario.Escuela; }
            if (usuario.Pais == null) { labelPais.Text = "No especificado"; } else { labelPais.Text = usuario.Pais; }
            if (usuario.Biografia == null) { tBio.Text = "Biografía no especificada"; } else { tBio.Text = usuario.Biografia; }
        }


    }
}
