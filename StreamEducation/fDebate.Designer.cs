﻿
namespace StreamEducation
{
    partial class fDebate
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bAddMensaje = new System.Windows.Forms.Button();
            this.labelForo = new System.Windows.Forms.Label();
            this.labelRecurso = new System.Windows.Forms.Label();
            this.lMensajes = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bInicio = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bCerrarSesion = new System.Windows.Forms.Button();
            this.bPerfil = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bRegistrarse = new System.Windows.Forms.Button();
            this.bIniciarSesion = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelDebate = new System.Windows.Forms.Label();
            this.labelCurso = new System.Windows.Forms.Label();
            this.labelCreador = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAddMensaje
            // 
            this.bAddMensaje.Location = new System.Drawing.Point(1256, 197);
            this.bAddMensaje.Margin = new System.Windows.Forms.Padding(4);
            this.bAddMensaje.Name = "bAddMensaje";
            this.bAddMensaje.Size = new System.Drawing.Size(115, 28);
            this.bAddMensaje.TabIndex = 48;
            this.bAddMensaje.Text = "Comentar";
            this.bAddMensaje.UseVisualStyleBackColor = true;
            this.bAddMensaje.Click += new System.EventHandler(this.bAddMensaje_Click);
            // 
            // labelForo
            // 
            this.labelForo.AutoSize = true;
            this.labelForo.BackColor = System.Drawing.SystemColors.Control;
            this.labelForo.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForo.Location = new System.Drawing.Point(532, 134);
            this.labelForo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelForo.Name = "labelForo";
            this.labelForo.Size = new System.Drawing.Size(229, 41);
            this.labelForo.TabIndex = 45;
            this.labelForo.Text = "NombreForo";
            // 
            // labelRecurso
            // 
            this.labelRecurso.AutoSize = true;
            this.labelRecurso.BackColor = System.Drawing.SystemColors.Control;
            this.labelRecurso.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecurso.Location = new System.Drawing.Point(431, 134);
            this.labelRecurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecurso.Name = "labelRecurso";
            this.labelRecurso.Size = new System.Drawing.Size(109, 41);
            this.labelRecurso.TabIndex = 44;
            this.labelRecurso.Text = "Foro:";
            // 
            // lMensajes
            // 
            this.lMensajes.BackColor = System.Drawing.SystemColors.Control;
            this.lMensajes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lMensajes.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMensajes.FormattingEnabled = true;
            this.lMensajes.ItemHeight = 20;
            this.lMensajes.Location = new System.Drawing.Point(439, 280);
            this.lMensajes.Margin = new System.Windows.Forms.Padding(4);
            this.lMensajes.Name = "lMensajes";
            this.lMensajes.Size = new System.Drawing.Size(932, 520);
            this.lMensajes.TabIndex = 43;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.Location = new System.Drawing.Point(1379, 85);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(289, 737);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calendario";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(16, 31);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelCurso);
            this.groupBox1.Controls.Add(this.labelCreador);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tDescripcion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.bInicio);
            this.groupBox1.Location = new System.Drawing.Point(17, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(365, 737);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            // 
            // bInicio
            // 
            this.bInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInicio.Location = new System.Drawing.Point(69, 34);
            this.bInicio.Margin = new System.Windows.Forms.Padding(4);
            this.bInicio.Name = "bInicio";
            this.bInicio.Size = new System.Drawing.Size(191, 69);
            this.bInicio.TabIndex = 0;
            this.bInicio.Text = "Volver ↩️";
            this.bInicio.UseVisualStyleBackColor = true;
            this.bInicio.Click += new System.EventHandler(this.bInicio_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bCerrarSesion);
            this.panel1.Controls.Add(this.bPerfil);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.bRegistrarse);
            this.panel1.Controls.Add(this.bIniciarSesion);
            this.panel1.Location = new System.Drawing.Point(17, 14);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1650, 68);
            this.panel1.TabIndex = 41;
            // 
            // bCerrarSesion
            // 
            this.bCerrarSesion.Location = new System.Drawing.Point(1452, 16);
            this.bCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.bCerrarSesion.Name = "bCerrarSesion";
            this.bCerrarSesion.Size = new System.Drawing.Size(104, 38);
            this.bCerrarSesion.TabIndex = 6;
            this.bCerrarSesion.Text = "Cerrar Sesion";
            this.bCerrarSesion.UseVisualStyleBackColor = true;
            this.bCerrarSesion.Click += new System.EventHandler(this.bCerrarSesion_Click);
            // 
            // bPerfil
            // 
            this.bPerfil.Location = new System.Drawing.Point(1580, 14);
            this.bPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.bPerfil.Name = "bPerfil";
            this.bPerfil.Size = new System.Drawing.Size(52, 42);
            this.bPerfil.TabIndex = 5;
            this.bPerfil.Text = "Perfil";
            this.bPerfil.UseVisualStyleBackColor = true;
            this.bPerfil.Click += new System.EventHandler(this.bPerfil_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(364, 42);
            this.label5.TabIndex = 4;
            this.label5.Text = "🌍 Stream Education";
            // 
            // bRegistrarse
            // 
            this.bRegistrarse.Location = new System.Drawing.Point(1532, 16);
            this.bRegistrarse.Margin = new System.Windows.Forms.Padding(4);
            this.bRegistrarse.Name = "bRegistrarse";
            this.bRegistrarse.Size = new System.Drawing.Size(100, 38);
            this.bRegistrarse.TabIndex = 1;
            this.bRegistrarse.Text = "Registrarse";
            this.bRegistrarse.UseVisualStyleBackColor = true;
            this.bRegistrarse.Click += new System.EventHandler(this.bRegistrarse_Click);
            // 
            // bIniciarSesion
            // 
            this.bIniciarSesion.Location = new System.Drawing.Point(1402, 16);
            this.bIniciarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.bIniciarSesion.Name = "bIniciarSesion";
            this.bIniciarSesion.Size = new System.Drawing.Size(104, 38);
            this.bIniciarSesion.TabIndex = 0;
            this.bIniciarSesion.Text = "Iniciar Sesion";
            this.bIniciarSesion.UseVisualStyleBackColor = true;
            this.bIniciarSesion.Click += new System.EventHandler(this.bIniciarSesion_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(432, 214);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 36);
            this.label6.TabIndex = 49;
            this.label6.Text = "Debate: ";
            // 
            // labelDebate
            // 
            this.labelDebate.AutoSize = true;
            this.labelDebate.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDebate.Location = new System.Drawing.Point(565, 214);
            this.labelDebate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDebate.Name = "labelDebate";
            this.labelDebate.Size = new System.Drawing.Size(242, 36);
            this.labelDebate.TabIndex = 50;
            this.labelDebate.Text = "NombreDebate";
            // 
            // labelCurso
            // 
            this.labelCurso.AutoSize = true;
            this.labelCurso.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurso.Location = new System.Drawing.Point(25, 296);
            this.labelCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurso.Name = "labelCurso";
            this.labelCurso.Size = new System.Drawing.Size(126, 20);
            this.labelCurso.TabIndex = 15;
            this.labelCurso.Text = "NombreCurso";
            // 
            // labelCreador
            // 
            this.labelCreador.AutoSize = true;
            this.labelCreador.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreador.Location = new System.Drawing.Point(25, 179);
            this.labelCreador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCreador.Name = "labelCreador";
            this.labelCreador.Size = new System.Drawing.Size(144, 20);
            this.labelCreador.TabIndex = 14;
            this.labelCreador.Text = "NombreCreador";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(8, 260);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 25);
            this.label7.TabIndex = 13;
            this.label7.Text = "Curso:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Creador:";
            // 
            // tDescripcion
            // 
            this.tDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tDescripcion.Enabled = false;
            this.tDescripcion.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDescripcion.Location = new System.Drawing.Point(12, 407);
            this.tDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.tDescripcion.Multiline = true;
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.ReadOnly = true;
            this.tDescripcion.Size = new System.Drawing.Size(345, 322);
            this.tDescripcion.TabIndex = 11;
            this.tDescripcion.Text = "No hay descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 368);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Descripción:";
            // 
            // fDebate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.labelDebate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bAddMensaje);
            this.Controls.Add(this.labelForo);
            this.Controls.Add(this.labelRecurso);
            this.Controls.Add(this.lMensajes);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fDebate";
            this.ShowIcon = false;
            this.Text = "Debate";
            this.Load += new System.EventHandler(this.fDebate_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAddMensaje;
        private System.Windows.Forms.Label labelForo;
        private System.Windows.Forms.Label labelRecurso;
        private System.Windows.Forms.ListBox lMensajes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button bInicio;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bPerfil;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bRegistrarse;
        private System.Windows.Forms.Button bIniciarSesion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelDebate;
        private System.Windows.Forms.Button bCerrarSesion;
        private System.Windows.Forms.Label labelCurso;
        private System.Windows.Forms.Label labelCreador;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tDescripcion;
        private System.Windows.Forms.Label label2;
    }
}