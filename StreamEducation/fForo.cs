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
    public partial class fForo : Form
    {
        public fForo()
        {
            InitializeComponent();
        }

        private void fForo_Load(object sender, EventArgs e)
        {
            labelForo.Text = GestorGlobal.ForoActivo.Nombre;
            tDescripcion.Text = GestorGlobal.ForoActivo.Descripcion;
            labelCreador.Text = GestorGlobal.ForoActivo.Creador.Nombre;
            labelCurso.Text = GestorGlobal.ForoActivo.Curso.Nombre;
            Recarga();
            foreach (Debate d in GestorGlobal.ForoActivo.getDebates())
            {
                lDebate.Items.Add(d);
                lCreador.Items.Add(d.Creador);
                lIntervenciones.Items.Add(d.intervenciones());
            }
        }

        private void Recarga()
        {
            bool usuarioIniciado = GestorGlobal.UsuarioActivo != null;
            bRegistrarse.Visible = !usuarioIniciado;
            bIniciarSesion.Visible = !usuarioIniciado;
            bPerfil.Visible = usuarioIniciado;
            bCerrarSesion.Visible = usuarioIniciado;
            bAddDebate.Visible = usuarioIniciado;
            bBorrar.Visible = usuarioIniciado && (GestorGlobal.UsuarioActivo.Id == GestorGlobal.ForoActivo.Creador.Id || GestorGlobal.UsuarioActivo.RolAdmin);
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

        private void bBorrar_Click(object sender, EventArgs e)
        {
            fConfirmacion ventana = new fConfirmacion();
            ventana.ShowDialog();
            if (ventana.Valor)
            {
                GestorGlobal.ForoActivo.Borrar();
                GestorGlobal.ForoActivo = null;
                this.Close();
            }
        }

        private void bAddDebate_Click(object sender, EventArgs e)
        {
            fCrearDebate ventana = new fCrearDebate();
            ventana.ShowDialog();
            lDebate.Items.Clear();
            lCreador.Items.Clear();
            lIntervenciones.Items.Clear();
            foreach (Debate d in GestorGlobal.ForoActivo.getDebates())
            {
                lDebate.Items.Add(d);
                lCreador.Items.Add(d.Creador);
                lIntervenciones.Items.Add(d.intervenciones());
            }
        }

        private void lForo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lDebate.SelectedIndex >= 0)
            {
                GestorGlobal.DebateActivo = (Debate) lDebate.SelectedItem;
                fDebate ventana = new fDebate();
                this.Visible = false;
                ventana.ShowDialog();
                GestorGlobal.DebateActivo = null;
                Recarga();
                this.Visible = true;
                lDebate.Items.Clear();
                lCreador.Items.Clear();
                lIntervenciones.Items.Clear();
                foreach (Debate d in GestorGlobal.ForoActivo.getDebates())
                {
                    lDebate.Items.Add(d);
                    lCreador.Items.Add(d.Creador);
                    lIntervenciones.Items.Add(d.intervenciones());
                }
            }
        }
        
    }
}
