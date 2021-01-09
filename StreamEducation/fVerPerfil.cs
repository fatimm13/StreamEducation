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
    public partial class fVerPerfil : Form
    {

        private Usuario usuario;

        public fVerPerfil(Usuario u)
        {
            InitializeComponent();
            usuario = u;
        }

        private void fVerPerfil_Load(object sender, EventArgs e)
        {
            if (usuario != null)
            {
                labelNombre.Text = usuario.Nombre;
                labelRol.Text = usuario.getRol();
                labelEscuela.Text = usuario.Escuela;
                labelPais.Text = usuario.Pais;
                tBio.Text = usuario.Biografia;
                foreach (string c in usuario.getCursos()) lCursos.Items.Add(c);
            }
            
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
