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
    public partial class fIniciarSesion : Form
    {
        private Usuario usuario;
    
        public fIniciarSesion(ref Usuario user)
        {
            usuario = user;
            InitializeComponent();
        }

        //TODO: Que haga cosas
        private void bAceptar_Click(object sender, EventArgs e)
        {
            if (tCorreo.Text != "" && tContrasena.Text != "")
            {
                usuario = new Usuario(tCorreo.Text, tContrasena.Text);
                this.Close();
            }
            else
            {
                fError ventana = new fError("Faltan parametros");
                this.Visible = false;
                ventana.ShowDialog();
                this.Visible = true;
            }
            
        }

        private void fIniciarSesion_Load(object sender, EventArgs e)
        {
            
        }
    }
}
