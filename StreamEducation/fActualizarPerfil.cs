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
    public partial class fActualizarPerfil : Form
    {
        public fActualizarPerfil()
        {
            InitializeComponent();
            tNombre.Text = GestorGlobal.UsuarioActivo.Nombre;
            tEscuela.Text = GestorGlobal.UsuarioActivo.Escuela;
            tPais.Text = GestorGlobal.UsuarioActivo.Pais;
            tBiografia.Text = GestorGlobal.UsuarioActivo.Biografia;
        }

        private void fActualizarPerfil_Load(object sender, EventArgs e)
        {

        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            GestorGlobal.UsuarioActivo.Nombre = tNombre.Text;
            GestorGlobal.UsuarioActivo.Escuela = tEscuela.Text;
            GestorGlobal.UsuarioActivo.Pais = tPais.Text;
            GestorGlobal.UsuarioActivo.Biografia = tBiografia.Text;
            this.Close();
        }
        
    }
}
