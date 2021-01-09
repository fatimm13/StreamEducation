﻿using System;
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
    public partial class fNoticias : Form
    {

        private List<(int, string)> noticias;

        public fNoticias()
        {
            InitializeComponent();
        }

        private void fNoticias_Load(object sender, EventArgs e)
        {
            Recarga();
            RecargaNoticias();
        }

        private void Recarga()
        {
            bool usuarioIniciado = GestorGlobal.UsuarioActivo != null;
            bRegistrarse.Visible = !usuarioIniciado;
            bIniciarSesion.Visible = !usuarioIniciado;
            bPerfil.Visible = usuarioIniciado;
            bCerrarSesion.Visible = usuarioIniciado;
            bAddNoticia.Visible = usuarioIniciado && GestorGlobal.UsuarioActivo.RolAdmin;
        }

        private void RecargaNoticias()
        {
            noticias = GestorGlobal.ForoActivo.getNoticias();
            lNoticias.Items.Clear();
            foreach ((int, string) n in noticias) lNoticias.Items.Add(n.Item2);
        }

        private void bInicio_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bPerfil_Click(object sender, EventArgs e)
        {
            fPerfil ventana = new fPerfil();
            ventana.ShowDialog();
            Recarga();
        }

        private void bCerrarSesion_Click(object sender, EventArgs e)
        {
            fConfirmacion ventana = new fConfirmacion();
            ventana.ShowDialog();
            if (ventana.Valor)
            {
                GestorGlobal.UsuarioActivo = null;
                Recarga();
            }
        }

        private void bIniciarSesion_Click(object sender, EventArgs e)
        {
            fIniciarSesion ventana = new fIniciarSesion();
            ventana.ShowDialog();
            Recarga();
        }

        private void bRegistrarse_Click(object sender, EventArgs e)
        {
            fCrearCuenta ventana = new fCrearCuenta();
            ventana.ShowDialog();
            Recarga();
        }

        private void bAddDebate_Click(object sender, EventArgs e)
        {
            fCrearNoticia ventana = new fCrearNoticia();
            ventana.ShowDialog();
            RecargaNoticias();
        }

        private void lForo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lNoticias.SelectedIndex >= 0)
            {
                int id = noticias[lNoticias.SelectedIndex].Item1;
                GestorGlobal.DebateActivo = new Debate(id);
                fMostrarNoticia ventana = new fMostrarNoticia();
                this.Visible = false;
                ventana.ShowDialog();
                GestorGlobal.DebateActivo = null;
                Recarga();
                this.Visible = true;
                RecargaNoticias();
            }
        }

    }
}
