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
            lUsuarios.Items.Clear();
            lAceptar.Items.Clear();
            lRechazar.Items.Clear();
            foreach (Usuario u in GestorGlobal.CursoActivo.getPeticiones(filtro))
            {
                lUsuarios.Items.Add(u);
                lAceptar.Items.Add("✔️");
                lRechazar.Items.Add("❌");
            }
        }

        private void lUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lAceptar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lAceptar.SelectedIndex >= 0)
            {
                Usuario usuario = (Usuario)lUsuarios.Items[lAceptar.SelectedIndex];
                fConfirmacion ventana = new fConfirmacion();
                ventana.ShowDialog();
                if (ventana.Valor)
                {
                    usuario.aceptarInscripcion(GestorGlobal.CursoActivo.Id);
                    Recarga(tUsuario.Text);
                }
            }
        }

        private void lRechazar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lRechazar.SelectedIndex >= 0)
            {
                Usuario usuario = (Usuario)lUsuarios.Items[lRechazar.SelectedIndex];
                fConfirmacion ventana = new fConfirmacion();
                ventana.ShowDialog();
                if (ventana.Valor)
                {
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
