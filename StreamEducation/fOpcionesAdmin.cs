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
    public partial class fOpcionesAdmin : Form
    {

        private Usuario usuario;
        public fOpcionesAdmin(Usuario u)
        {
            InitializeComponent();
            usuario = u;
        }

        private void fOpcionesAdmin_Load(object sender, EventArgs e)
        {
            tNombre.Text = usuario.Nombre;
            tEscuela.Text = usuario.Escuela;
            tPais.Text = usuario.Pais;
            tBiografia.Text = usuario.Biografia;
            if (usuario.RolAdmin) { comboRol.SelectedIndex = 3; }
            else if (usuario.RolProfesor) { comboRol.SelectedIndex = 1; }
            else if (usuario.RolAsociacion) { comboRol.SelectedIndex = 2; }
            else { comboRol.SelectedIndex = 0; }
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            fConfirmacion ventana = new fConfirmacion();
            ventana.ShowDialog();
            if (ventana.Valor)
            {
                usuario.Borrar();
                usuario = null;
                this.Close();
            }
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            usuario.Nombre = tNombre.Text;
            usuario.Escuela = tEscuela.Text;
            usuario.Pais = tPais.Text;
            usuario.Biografia = tBiografia.Text;
            usuario.setRol(comboRol.SelectedIndex);
            this.Close();
        }
        
    }
}
