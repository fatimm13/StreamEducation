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

        private void fPerfil_Load(object sender, EventArgs e)
        {
            Actualiza();
            bOpciones.Visible = GestorGlobal.UsuarioActivo.RolAdmin;
            labelRol.Text = GestorGlobal.UsuarioActivo.getRol();
            foreach (string c in GestorGlobal.UsuarioActivo.getCursos()) lCursos.Items.Add(c);
        }

        private void Actualiza()
        {
            labelNombre.Text = GestorGlobal.UsuarioActivo.Nombre;
            labelEscuela.Text = GestorGlobal.UsuarioActivo.Escuela;
            labelPais.Text = GestorGlobal.UsuarioActivo.Pais;
            tBio.Text = GestorGlobal.UsuarioActivo.Biografia;
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void bMensajeria_Click(object sender, EventArgs e)
        {
            fMensajeria ventana = new fMensajeria();
            ventana.ShowDialog();
        }

        private void bOpciones_Click(object sender, EventArgs e)
        {
            fUsuariosRegistrados ventana = new fUsuariosRegistrados();
            ventana.ShowDialog();
        }
    }
}
