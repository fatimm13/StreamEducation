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
    public partial class fCurso : Form
    {
        
        public fCurso()
        {
            InitializeComponent();
        }
        private void bInicio_Click(object sender, EventArgs e)
        {
            GestorGlobal.CursoActivo = null;
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

        private void fCurso_Load(object sender, EventArgs e)
        {
            if (GestorGlobal.CursoActivo != null)
            {
                foreach (Recurso r in GestorGlobal.CursoActivo.getRecursos()) lRecursos.Items.Add(r);
                foreach (Foro f in GestorGlobal.CursoActivo.getForos()) lForos.Items.Add(f);
            }
            labelProfesor.Text = GestorGlobal.CursoActivo.Profesor.Nombre;
            labelCurso.Text = GestorGlobal.CursoActivo.Nombre;
            tDescripcion.Text = GestorGlobal.CursoActivo.Descripcion;
            Recarga();
        }
        private void Recarga()
        {
            bool usuarioIniciado = GestorGlobal.UsuarioActivo != null;
            bRegistrarse.Visible = !usuarioIniciado;
            bIniciarSesion.Visible = !usuarioIniciado;
            bPerfil.Visible = usuarioIniciado;
            bCerrarSesion.Visible = usuarioIniciado;
            bCrearForo.Visible = usuarioIniciado && (GestorGlobal.UsuarioActivo.Id == GestorGlobal.CursoActivo.Profesor.Id || GestorGlobal.UsuarioActivo.RolAdmin);
            bCrearRecurso.Visible = usuarioIniciado && (GestorGlobal.UsuarioActivo.Id == GestorGlobal.CursoActivo.Profesor.Id || GestorGlobal.UsuarioActivo.RolAdmin);
            bBorrar.Visible = usuarioIniciado && (GestorGlobal.UsuarioActivo.RolProfesor || GestorGlobal.UsuarioActivo.RolAdmin);
        }

        private void lRecursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lRecursos.SelectedIndex>=0)   System.Diagnostics.Process.Start(((Recurso)lRecursos.SelectedItem).Link);
        }

        private void lForos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lForos.SelectedIndex >= 0)
            {
                GestorGlobal.ForoActivo = (Foro) lForos.SelectedItem;
                fForo ventana = new fForo();
                this.Visible = false;
                ventana.ShowDialog();
                this.Visible = true;
                Recarga();
                lForos.Items.Clear();
                foreach (Foro f in GestorGlobal.CursoActivo.getForos()) lForos.Items.Add(f);
            }
        }

        private void bCrearForo_Click(object sender, EventArgs e)
        {
            fCrearForo ventana = new fCrearForo();
            ventana.ShowDialog();
            lForos.Items.Clear();
            foreach (Foro f in GestorGlobal.CursoActivo.getForos()) lForos.Items.Add(f);
        }

        private void bCrearRecurso_Click(object sender, EventArgs e)
        {

        }

        private void bBorrar_Click(object sender, EventArgs e)
        {
            fConfirmacion ventana = new fConfirmacion();
            ventana.ShowDialog();
            if (ventana.Valor)
            {
                GestorGlobal.CursoActivo.Borrar();
                GestorGlobal.CursoActivo = null;
                this.Close();
            }
        }
    }
}
