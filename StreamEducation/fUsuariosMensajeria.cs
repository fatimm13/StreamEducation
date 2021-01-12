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
    public partial class fUsuariosMensajeria : Form
    {

        private List<(int, string, string)> usuarios;
        Usuario destinatario;

        public Usuario Valor { get { return destinatario; } }

        public fUsuariosMensajeria()
        {
            InitializeComponent();
            destinatario = null;
        }

        private void fUsuariosMensajeria_Load(object sender, EventArgs e)
        {
            usuarios = Usuario.getUsuarios("", false);
            Recarga();
        }

        private void Recarga()
        {
            lUsuarios.Items.Clear();
            foreach ((int, string, string) u in usuarios)
            {
                lUsuarios.Items.Add("📧  " + u.Item2 + "  (" + u.Item3 + ")");
            }
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelX_Click(object sender, EventArgs e)
        {
            tUsuario.Text = "";
            usuarios = Usuario.getUsuarios("", false);
            Recarga();
        }

        private void tUsuario_TextChanged(object sender, EventArgs e)
        {
            usuarios = Usuario.getUsuarios(tUsuario.Text, false);
            Recarga();
        }

        private void lUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lUsuarios.SelectedIndex >= 0)
            {
                destinatario = new Usuario(usuarios[lUsuarios.SelectedIndex].Item1);
                this.Close();
            }
        }
    }
}
