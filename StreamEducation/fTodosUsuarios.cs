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
    public partial class fTodosUsuarios : Form
    {

        private List<(int, string, string)> usuarios;

        public fTodosUsuarios()
        {
            InitializeComponent();
        }

        private void fTodosUsuarios_Load(object sender, EventArgs e)
        {
            usuarios = Usuario.getUsuarios("");
            Recarga();
        }

        private void Recarga()
        {
            lUsuarios.Items.Clear();
            foreach ((int, string, string) u in usuarios)
            {
                lUsuarios.Items.Add("Usuario: " + u.Item2 + "  (" + u.Item3 + ")");
            }
        }

        private void lUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lUsuarios.SelectedIndex >= 0)
            {
                int id = usuarios[lUsuarios.SelectedIndex].Item1;
                fOpcionesAdmin ventana = new fOpcionesAdmin(new Usuario(id));
                ventana.ShowDialog();
                Recarga();
            }
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            usuarios = Usuario.getUsuarios(tUsuario.Text);
            Recarga();
        }

        private void labelX_Click(object sender, EventArgs e)
        {
            tUsuario.Text = "";
            usuarios = Usuario.getUsuarios("");
            Recarga();
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
