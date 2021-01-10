using MySql.Data.MySqlClient;
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
    public partial class fUsuariosPendientes : Form
    {

        private List<(int, string)> usuarios;

        public fUsuariosPendientes()
        {
            InitializeComponent();
        }

        private void fInscripcionesPendientes_Load(object sender, EventArgs e)
        {
            Recarga("");
        }

        private void Recarga(string filtro)
        {
            usuarios = GestorGlobal.CursoActivo.getPeticiones(filtro);
            lUsuarios.Items.Clear();
            lAceptar.Items.Clear();
            lRechazar.Items.Clear();
            foreach ((int, string) u in usuarios)
            {
                lUsuarios.Items.Add(u.Item2);
                lAceptar.Items.Add("✔️");
                lRechazar.Items.Add("❌");
            }
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

        private void lAceptar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lAceptar.SelectedIndex >= 0)
            {
                int id = usuarios[lAceptar.SelectedIndex].Item1;
                fConfirmacion ventana = new fConfirmacion();
                ventana.ShowDialog();
                if (ventana.Valor)
                {
                    Usuario usuario = new Usuario(id);
                    usuario.aceptarInscripcion(GestorGlobal.CursoActivo.Id);
                    Recarga(tUsuario.Text);
                }
            }
        }

        private void lRechazar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lRechazar.SelectedIndex >= 0)
            {
                int id = usuarios[lRechazar.SelectedIndex].Item1;
                fConfirmacion ventana = new fConfirmacion();
                ventana.ShowDialog();
                if (ventana.Valor)
                {
                    Usuario usuario = new Usuario(id);
                    usuario.rechazarInscripcion(GestorGlobal.CursoActivo.Id);
                    Recarga(tUsuario.Text);
                }
            }
        }

        private void tUsuario_TextChanged(object sender, EventArgs e)
        {
            Recarga(tUsuario.Text);
        }

        private void bVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void labelX_Click(object sender, EventArgs e)
        {
            tUsuario.Text = "";
            Recarga("");
        }
    }
}
