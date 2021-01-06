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
            lUsuarios.Items.Clear();
            lExpulsar.Items.Clear();
            foreach (Usuario u in GestorGlobal.CursoActivo.getUsuarios(filtro))
            {
                lUsuarios.Items.Add(u);
                lExpulsar.Items.Add("🚫 Expulsar");
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
                Usuario usuario = (Usuario)lUsuarios.Items[lExpulsar.SelectedIndex];
                fConfirmacion ventana = new fConfirmacion();
                ventana.ShowDialog();
                if (ventana.Valor)
                {
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
                fVerPerfil ventana = new fVerPerfil((Usuario)lUsuarios.SelectedItem);
                ventana.ShowDialog();
            }
        }
    }
}
