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
    public partial class fInscripcionesPendientes : Form
    {
        public fInscripcionesPendientes()
        {
            InitializeComponent();
            foreach(Usuario u in GestorGlobal.CursoActivo.getPeticiones())
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
                Usuario us = (Usuario)lUsuarios.Items[lAceptar.SelectedIndex];
                us.aceptarInscripcion(GestorGlobal.CursoActivo.Id);
                lUsuarios.Items.Clear();
                lAceptar.Items.Clear();
                lRechazar.Items.Clear();
                foreach (Usuario u in GestorGlobal.CursoActivo.getPeticiones())
                {
                    lUsuarios.Items.Add(u);
                    lAceptar.Items.Add("✔️");
                    lRechazar.Items.Add("❌");
                }
            }
        }

        private void lRechazar_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lRechazar.SelectedIndex >= 0)
            {
                Usuario us = (Usuario)lUsuarios.Items[lRechazar.SelectedIndex];
                us.rechazarInscripcion(GestorGlobal.CursoActivo.Id);
                lUsuarios.Items.Clear();
                lAceptar.Items.Clear();
                lRechazar.Items.Clear();
                foreach (Usuario u in GestorGlobal.CursoActivo.getPeticiones())
                {
                    lUsuarios.Items.Add(u);
                    lAceptar.Items.Add("✔️");
                    lRechazar.Items.Add("❌");
                }
            }
        }
    }
}
