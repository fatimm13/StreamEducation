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
    public partial class fUsuariosInscritos : Form
    {

        private List<(int, string)> usuarios;

        public fUsuariosInscritos()
        {
            InitializeComponent();
        }

        private void fUsuariosInscritos_Load(object sender, EventArgs e)
        {
            Recarga("");
        }

        private void Recarga(string filtro)
        {
            usuarios = GestorGlobal.CursoActivo.getUsuarios(filtro);
            lUsuarios.Items.Clear();
            lExpulsar.Items.Clear();
            foreach ((int, string) u in usuarios)
            {
                lUsuarios.Items.Add(u.Item2);
                lExpulsar.Items.Add("🚫");
            }
        }

        private void labelX_Click(object sender, EventArgs e)
        {
            tUsuario.Text = "";
            Recarga("");
        }

        private void tUsuario_TextChanged(object sender, EventArgs e)
        {
            Recarga(tUsuario.Text);
        }

        private void lExpulsar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lExpulsar.SelectedIndex >= 0)
            {
                int id = usuarios[lExpulsar.SelectedIndex].Item1;
                fConfirmacion ventana = new fConfirmacion();
                ventana.ShowDialog();
                if (ventana.Valor)
                {
                    Usuario usuario = new Usuario(id);
                    usuario.expulsar(GestorGlobal.CursoActivo.Id);
                    Recarga(tUsuario.Text);
                }
            }
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lUsuarios.SelectedIndex >= 0)
            {
                int id = usuarios[lUsuarios.SelectedIndex].Item1;
                fVerPerfil ventana = new fVerPerfil(new Usuario(id));
                ventana.ShowDialog();
            }
        }
    }
}
