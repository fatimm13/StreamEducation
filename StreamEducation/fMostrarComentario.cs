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
    public partial class fMostrarComentario : Form
    {

        Mensaje mensaje;

        public fMostrarComentario(Mensaje m)
        {
            InitializeComponent();
            mensaje = m;
        }

        private void fMostrarComentario_Load(object sender, EventArgs e)
        {
            Usuario usuario = GestorGlobal.UsuarioActivo;
            labelNoticia.Text = mensaje.Debate.Nombre;
            labelNombre.Text = mensaje.Nombre;
            labelCreador.Text = mensaje.Creador.Nombre;
            labelFecha.Text = mensaje.Fecha;
            tMensaje.Text = mensaje.Descripcion;
            bBorrar.Visible = usuario != null && (mensaje.Creador.Id == usuario.Id || usuario.RolProfesor || usuario.RolAdmin);
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            fConfirmacion ventana = new fConfirmacion();
            ventana.ShowDialog();
            if (ventana.Valor)
            {
                mensaje.Borrar();
                mensaje = null;
                this.Close();
            }
        }
    }
}
