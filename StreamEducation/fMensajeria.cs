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
    public partial class fMensajeria : Form
    {
        public fMensajeria()
        {
            InitializeComponent();
        }

        private void bEnviar_Click(object sender, EventArgs e)
        {
            fCrearMensajePrivado ventana = new fCrearMensajePrivado();
            ventana.ShowDialog();
            lMensajes.Items.Clear();
            foreach (MensajePrivado m in GestorGlobal.UsuarioActivo.getMensajePrivado()) lMensajes.Items.Add(m);
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lMensajes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lMensajes.SelectedIndex >= 0)
            {
                fMostrarMensajePrivado ventana = new fMostrarMensajePrivado((MensajePrivado)lMensajes.SelectedItem);
                ventana.ShowDialog();
                lMensajes.Items.Clear();
                foreach (MensajePrivado m in GestorGlobal.UsuarioActivo.getMensajePrivado()) lMensajes.Items.Add(m);
            }
        }

        private void fMensajeria_Load(object sender, EventArgs e)
        {
            lMensajes.Items.Clear();
            foreach (MensajePrivado m in GestorGlobal.UsuarioActivo.getMensajePrivado()) lMensajes.Items.Add(m);
        }
    }
}
