
namespace StreamEducation
{
    partial class fCurso
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.bPeticiones = new System.Windows.Forms.Button();
            this.bInscritos = new System.Windows.Forms.Button();
            this.labelPeticion = new System.Windows.Forms.Label();
            this.labelInscritos = new System.Windows.Forms.Label();
            this.lRecursos = new System.Windows.Forms.ListBox();
            this.labelCurso = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lForos = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelFecha = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.bValorar = new System.Windows.Forms.Button();
            this.labelProfesor = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bInicio = new System.Windows.Forms.Button();
            this.labelRecurso = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bCerrarSesion = new System.Windows.Forms.Button();
            this.bPerfil = new System.Windows.Forms.Button();
            this.bRegistrarse = new System.Windows.Forms.Button();
            this.bIniciarSesion = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bCrearForo = new System.Windows.Forms.Button();
            this.bCrearRecurso = new System.Windows.Forms.Button();
            this.bBorrar = new System.Windows.Forms.Button();
            this.lBorrar = new System.Windows.Forms.ListBox();
            this.bCrearTest = new System.Windows.Forms.Button();
            this.bCrearClase = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(16, 31);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(12, 11, 12, 11);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // bPeticiones
            // 
            this.bPeticiones.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPeticiones.Location = new System.Drawing.Point(1191, 761);
            this.bPeticiones.Margin = new System.Windows.Forms.Padding(4);
            this.bPeticiones.Name = "bPeticiones";
            this.bPeticiones.Size = new System.Drawing.Size(180, 38);
            this.bPeticiones.TabIndex = 35;
            this.bPeticiones.Text = "🧑";
            this.bPeticiones.UseVisualStyleBackColor = true;
            this.bPeticiones.Click += new System.EventHandler(this.bPeticiones_Click);
            // 
            // bInscritos
            // 
            this.bInscritos.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInscritos.Location = new System.Drawing.Point(1191, 702);
            this.bInscritos.Margin = new System.Windows.Forms.Padding(4);
            this.bInscritos.Name = "bInscritos";
            this.bInscritos.Size = new System.Drawing.Size(180, 41);
            this.bInscritos.TabIndex = 34;
            this.bInscritos.Text = "📖";
            this.bInscritos.UseVisualStyleBackColor = true;
            this.bInscritos.Click += new System.EventHandler(this.bInscritos_Click);
            // 
            // labelPeticion
            // 
            this.labelPeticion.AutoSize = true;
            this.labelPeticion.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPeticion.Location = new System.Drawing.Point(433, 763);
            this.labelPeticion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPeticion.Name = "labelPeticion";
            this.labelPeticion.Size = new System.Drawing.Size(360, 29);
            this.labelPeticion.TabIndex = 33;
            this.labelPeticion.Text = "Peticiones de Inscripción:";
            // 
            // labelInscritos
            // 
            this.labelInscritos.AutoSize = true;
            this.labelInscritos.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInscritos.Location = new System.Drawing.Point(433, 705);
            this.labelInscritos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInscritos.Name = "labelInscritos";
            this.labelInscritos.Size = new System.Drawing.Size(266, 29);
            this.labelInscritos.TabIndex = 32;
            this.labelInscritos.Text = "Alumnos Inscritos:";
            // 
            // lRecursos
            // 
            this.lRecursos.BackColor = System.Drawing.SystemColors.Control;
            this.lRecursos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lRecursos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRecursos.FormattingEnabled = true;
            this.lRecursos.ItemHeight = 25;
            this.lRecursos.Location = new System.Drawing.Point(439, 425);
            this.lRecursos.Margin = new System.Windows.Forms.Padding(4);
            this.lRecursos.Name = "lRecursos";
            this.lRecursos.Size = new System.Drawing.Size(731, 225);
            this.lRecursos.TabIndex = 31;
            this.lRecursos.SelectedIndexChanged += new System.EventHandler(this.lRecursos_SelectedIndexChanged);
            // 
            // labelCurso
            // 
            this.labelCurso.AutoSize = true;
            this.labelCurso.BackColor = System.Drawing.SystemColors.Control;
            this.labelCurso.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCurso.Location = new System.Drawing.Point(583, 124);
            this.labelCurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurso.Name = "labelCurso";
            this.labelCurso.Size = new System.Drawing.Size(253, 41);
            this.labelCurso.TabIndex = 36;
            this.labelCurso.Text = "NombreCurso";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(433, 377);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 29);
            this.label3.TabIndex = 30;
            this.label3.Text = "Recursos:";
            // 
            // lForos
            // 
            this.lForos.BackColor = System.Drawing.SystemColors.Control;
            this.lForos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lForos.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lForos.FormattingEnabled = true;
            this.lForos.ItemHeight = 25;
            this.lForos.Location = new System.Drawing.Point(439, 260);
            this.lForos.Margin = new System.Windows.Forms.Padding(4);
            this.lForos.Name = "lForos";
            this.lForos.Size = new System.Drawing.Size(932, 75);
            this.lForos.TabIndex = 29;
            this.lForos.SelectedIndexChanged += new System.EventHandler(this.lForos_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(433, 213);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 29);
            this.label2.TabIndex = 28;
            this.label2.Text = "Foros:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelFecha);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.bValorar);
            this.groupBox1.Controls.Add(this.labelProfesor);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tDescripcion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bInicio);
            this.groupBox1.Location = new System.Drawing.Point(17, 87);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(365, 737);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.Location = new System.Drawing.Point(19, 396);
            this.labelFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(170, 25);
            this.labelFecha.TabIndex = 64;
            this.labelFecha.Text = "FechaComienzo";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(7, 351);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(236, 29);
            this.label8.TabIndex = 63;
            this.label8.Text = "Fecha comienzo:";
            // 
            // bValorar
            // 
            this.bValorar.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bValorar.Location = new System.Drawing.Point(13, 172);
            this.bValorar.Margin = new System.Windows.Forms.Padding(4);
            this.bValorar.Name = "bValorar";
            this.bValorar.Size = new System.Drawing.Size(323, 37);
            this.bValorar.TabIndex = 61;
            this.bValorar.Text = "⭐ Valorar Curso";
            this.bValorar.UseVisualStyleBackColor = true;
            this.bValorar.Click += new System.EventHandler(this.bValorar_Click);
            // 
            // labelProfesor
            // 
            this.labelProfesor.AutoSize = true;
            this.labelProfesor.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProfesor.Location = new System.Drawing.Point(19, 294);
            this.labelProfesor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelProfesor.Name = "labelProfesor";
            this.labelProfesor.Size = new System.Drawing.Size(174, 25);
            this.labelProfesor.TabIndex = 7;
            this.labelProfesor.Text = "NombreProfesor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(7, 254);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 29);
            this.label7.TabIndex = 6;
            this.label7.Text = "Profesor:";
            // 
            // tDescripcion
            // 
            this.tDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tDescripcion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDescripcion.Location = new System.Drawing.Point(12, 497);
            this.tDescripcion.Margin = new System.Windows.Forms.Padding(4);
            this.tDescripcion.Multiline = true;
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.ReadOnly = true;
            this.tDescripcion.Size = new System.Drawing.Size(345, 228);
            this.tDescripcion.TabIndex = 5;
            this.tDescripcion.Text = "InsertarDescripcion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 454);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Descripción:";
            // 
            // bInicio
            // 
            this.bInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bInicio.Location = new System.Drawing.Point(76, 55);
            this.bInicio.Margin = new System.Windows.Forms.Padding(4);
            this.bInicio.Name = "bInicio";
            this.bInicio.Size = new System.Drawing.Size(191, 69);
            this.bInicio.TabIndex = 0;
            this.bInicio.Text = "Volver ↩️";
            this.bInicio.UseVisualStyleBackColor = true;
            this.bInicio.Click += new System.EventHandler(this.bInicio_Click);
            // 
            // labelRecurso
            // 
            this.labelRecurso.AutoSize = true;
            this.labelRecurso.BackColor = System.Drawing.SystemColors.Control;
            this.labelRecurso.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRecurso.Location = new System.Drawing.Point(411, 124);
            this.labelRecurso.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelRecurso.Name = "labelRecurso";
            this.labelRecurso.Size = new System.Drawing.Size(141, 41);
            this.labelRecurso.TabIndex = 27;
            this.labelRecurso.Text = "Curso:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.bCerrarSesion);
            this.panel1.Controls.Add(this.bPerfil);
            this.panel1.Controls.Add(this.bRegistrarse);
            this.panel1.Controls.Add(this.bIniciarSesion);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Location = new System.Drawing.Point(17, 15);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1650, 68);
            this.panel1.TabIndex = 26;
            // 
            // bCerrarSesion
            // 
            this.bCerrarSesion.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCerrarSesion.Location = new System.Drawing.Point(1299, 10);
            this.bCerrarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.bCerrarSesion.Name = "bCerrarSesion";
            this.bCerrarSesion.Size = new System.Drawing.Size(181, 47);
            this.bCerrarSesion.TabIndex = 42;
            this.bCerrarSesion.Text = "Cerrar Sesion";
            this.bCerrarSesion.UseVisualStyleBackColor = true;
            this.bCerrarSesion.Click += new System.EventHandler(this.bCerrarSesion_Click);
            // 
            // bPerfil
            // 
            this.bPerfil.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bPerfil.Location = new System.Drawing.Point(1507, 11);
            this.bPerfil.Margin = new System.Windows.Forms.Padding(4);
            this.bPerfil.Name = "bPerfil";
            this.bPerfil.Size = new System.Drawing.Size(125, 46);
            this.bPerfil.TabIndex = 41;
            this.bPerfil.Text = "Perfil";
            this.bPerfil.UseVisualStyleBackColor = true;
            this.bPerfil.Click += new System.EventHandler(this.bPerfil_Click);
            // 
            // bRegistrarse
            // 
            this.bRegistrarse.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRegistrarse.Location = new System.Drawing.Point(1468, 10);
            this.bRegistrarse.Margin = new System.Windows.Forms.Padding(4);
            this.bRegistrarse.Name = "bRegistrarse";
            this.bRegistrarse.Size = new System.Drawing.Size(165, 47);
            this.bRegistrarse.TabIndex = 40;
            this.bRegistrarse.Text = "Registrarse";
            this.bRegistrarse.UseVisualStyleBackColor = true;
            this.bRegistrarse.Click += new System.EventHandler(this.bRegistrarse_Click);
            // 
            // bIniciarSesion
            // 
            this.bIniciarSesion.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bIniciarSesion.Location = new System.Drawing.Point(1264, 10);
            this.bIniciarSesion.Margin = new System.Windows.Forms.Padding(4);
            this.bIniciarSesion.Name = "bIniciarSesion";
            this.bIniciarSesion.Size = new System.Drawing.Size(187, 46);
            this.bIniciarSesion.TabIndex = 39;
            this.bIniciarSesion.Text = "Iniciar Sesion";
            this.bIniciarSesion.UseVisualStyleBackColor = true;
            this.bIniciarSesion.Click += new System.EventHandler(this.bIniciarSesion_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 11);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(364, 42);
            this.label5.TabIndex = 2;
            this.label5.Text = "🌍 Stream Education";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.monthCalendar1);
            this.groupBox2.Location = new System.Drawing.Point(1379, 86);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(289, 737);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Calendario";
            // 
            // bCrearForo
            // 
            this.bCrearForo.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCrearForo.Location = new System.Drawing.Point(1188, 209);
            this.bCrearForo.Margin = new System.Windows.Forms.Padding(4);
            this.bCrearForo.Name = "bCrearForo";
            this.bCrearForo.Size = new System.Drawing.Size(180, 39);
            this.bCrearForo.TabIndex = 39;
            this.bCrearForo.Text = "Crear Foro";
            this.bCrearForo.UseVisualStyleBackColor = true;
            this.bCrearForo.Click += new System.EventHandler(this.bCrearForo_Click);
            // 
            // bCrearRecurso
            // 
            this.bCrearRecurso.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCrearRecurso.Location = new System.Drawing.Point(1189, 373);
            this.bCrearRecurso.Margin = new System.Windows.Forms.Padding(4);
            this.bCrearRecurso.Name = "bCrearRecurso";
            this.bCrearRecurso.Size = new System.Drawing.Size(179, 39);
            this.bCrearRecurso.TabIndex = 40;
            this.bCrearRecurso.Text = "Crear Recurso";
            this.bCrearRecurso.UseVisualStyleBackColor = true;
            this.bCrearRecurso.Click += new System.EventHandler(this.bCrearRecurso_Click);
            // 
            // bBorrar
            // 
            this.bBorrar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBorrar.Location = new System.Drawing.Point(1191, 130);
            this.bBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.bBorrar.Name = "bBorrar";
            this.bBorrar.Size = new System.Drawing.Size(177, 39);
            this.bBorrar.TabIndex = 42;
            this.bBorrar.Text = "Borrar Curso";
            this.bBorrar.UseVisualStyleBackColor = true;
            this.bBorrar.Click += new System.EventHandler(this.bBorrar_Click);
            // 
            // lBorrar
            // 
            this.lBorrar.BackColor = System.Drawing.SystemColors.Control;
            this.lBorrar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lBorrar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBorrar.FormattingEnabled = true;
            this.lBorrar.ItemHeight = 25;
            this.lBorrar.Location = new System.Drawing.Point(1191, 425);
            this.lBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.lBorrar.Name = "lBorrar";
            this.lBorrar.Size = new System.Drawing.Size(177, 225);
            this.lBorrar.TabIndex = 43;
            this.lBorrar.SelectedIndexChanged += new System.EventHandler(this.lBorrar_SelectedIndexChanged);
            // 
            // bCrearTest
            // 
            this.bCrearTest.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCrearTest.Location = new System.Drawing.Point(970, 373);
            this.bCrearTest.Margin = new System.Windows.Forms.Padding(4);
            this.bCrearTest.Name = "bCrearTest";
            this.bCrearTest.Size = new System.Drawing.Size(179, 39);
            this.bCrearTest.TabIndex = 44;
            this.bCrearTest.Text = "Crear Test";
            this.bCrearTest.UseVisualStyleBackColor = true;
            this.bCrearTest.Click += new System.EventHandler(this.bCrearTest_Click);
            // 
            // bCrearClase
            // 
            this.bCrearClase.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCrearClase.Location = new System.Drawing.Point(752, 373);
            this.bCrearClase.Margin = new System.Windows.Forms.Padding(4);
            this.bCrearClase.Name = "bCrearClase";
            this.bCrearClase.Size = new System.Drawing.Size(179, 39);
            this.bCrearClase.TabIndex = 45;
            this.bCrearClase.Text = "Crear Clase";
            this.bCrearClase.UseVisualStyleBackColor = true;
            this.bCrearClase.Click += new System.EventHandler(this.bCrearClase_Click);
            // 
            // fCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.bCrearClase);
            this.Controls.Add(this.bCrearTest);
            this.Controls.Add(this.lBorrar);
            this.Controls.Add(this.bBorrar);
            this.Controls.Add(this.bCrearRecurso);
            this.Controls.Add(this.bCrearForo);
            this.Controls.Add(this.bPeticiones);
            this.Controls.Add(this.bInscritos);
            this.Controls.Add(this.labelPeticion);
            this.Controls.Add(this.labelInscritos);
            this.Controls.Add(this.lRecursos);
            this.Controls.Add(this.labelCurso);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lForos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelRecurso);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "fCurso";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Curso";
            this.Load += new System.EventHandler(this.fCurso_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button bPeticiones;
        private System.Windows.Forms.Button bInscritos;
        private System.Windows.Forms.Label labelPeticion;
        private System.Windows.Forms.Label labelInscritos;
        private System.Windows.Forms.ListBox lRecursos;
        private System.Windows.Forms.Label labelCurso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lForos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bInicio;
        private System.Windows.Forms.Label labelRecurso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bCrearForo;
        private System.Windows.Forms.Button bCrearRecurso;
        private System.Windows.Forms.Label labelProfesor;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button bBorrar;
        private System.Windows.Forms.ListBox lBorrar;
        private System.Windows.Forms.Button bCerrarSesion;
        private System.Windows.Forms.Button bPerfil;
        private System.Windows.Forms.Button bRegistrarse;
        private System.Windows.Forms.Button bIniciarSesion;
        private System.Windows.Forms.Button bValorar;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bCrearTest;
        private System.Windows.Forms.Button bCrearClase;
    }
}