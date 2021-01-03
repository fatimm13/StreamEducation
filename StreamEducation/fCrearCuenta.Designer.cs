
namespace StreamEducation
{
    partial class fCrearCuenta
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.bAceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.tContrasena1 = new System.Windows.Forms.TextBox();
            this.tCorreo = new System.Windows.Forms.TextBox();
            this.tContrasena2 = new System.Windows.Forms.TextBox();
            this.comboRol = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboPregunta = new System.Windows.Forms.ComboBox();
            this.tRespuesta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 34);
            this.label1.TabIndex = 1;
            this.label1.Text = "Rellene los siguientes campos:";
            // 
            // bAceptar
            // 
            this.bAceptar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptar.Location = new System.Drawing.Point(602, 493);
            this.bAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(88, 34);
            this.bAceptar.TabIndex = 2;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(72, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Correo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(72, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 5;
            this.label4.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 269);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 25);
            this.label5.TabIndex = 6;
            this.label5.Text = "Repetir contraseña:";
            // 
            // tNombre
            // 
            this.tNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombre.Location = new System.Drawing.Point(343, 106);
            this.tNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(347, 32);
            this.tNombre.TabIndex = 7;
            // 
            // tContrasena1
            // 
            this.tContrasena1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tContrasena1.Location = new System.Drawing.Point(343, 209);
            this.tContrasena1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tContrasena1.Name = "tContrasena1";
            this.tContrasena1.PasswordChar = '*';
            this.tContrasena1.Size = new System.Drawing.Size(347, 32);
            this.tContrasena1.TabIndex = 9;
            // 
            // tCorreo
            // 
            this.tCorreo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCorreo.Location = new System.Drawing.Point(343, 157);
            this.tCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tCorreo.Name = "tCorreo";
            this.tCorreo.Size = new System.Drawing.Size(347, 32);
            this.tCorreo.TabIndex = 8;
            // 
            // tContrasena2
            // 
            this.tContrasena2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tContrasena2.Location = new System.Drawing.Point(343, 266);
            this.tContrasena2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tContrasena2.Name = "tContrasena2";
            this.tContrasena2.PasswordChar = '*';
            this.tContrasena2.Size = new System.Drawing.Size(347, 32);
            this.tContrasena2.TabIndex = 10;
            // 
            // comboRol
            // 
            this.comboRol.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRol.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRol.FormattingEnabled = true;
            this.comboRol.Items.AddRange(new object[] {
            "Estudiante",
            "Profesor",
            "Administrador",
            "Asociacion Externa"});
            this.comboRol.Location = new System.Drawing.Point(343, 323);
            this.comboRol.Name = "comboRol";
            this.comboRol.Size = new System.Drawing.Size(347, 33);
            this.comboRol.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(72, 326);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 25);
            this.label6.TabIndex = 23;
            this.label6.Text = "Rol usuario:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(594, 34);
            this.label7.TabIndex = 25;
            this.label7.Text = "Pregunta y Respuesta de seguridad:";
            // 
            // comboPregunta
            // 
            this.comboPregunta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboPregunta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboPregunta.FormattingEnabled = true;
            this.comboPregunta.Items.AddRange(new object[] {
            "¿Cual es el nombre de tu primera mascota?",
            "¿Cual es el nombre de tu primer profesor?",
            "¿Cuál es tu color favorito?",
            "¿Cuál es tu canción favorita?"});
            this.comboPregunta.Location = new System.Drawing.Point(77, 443);
            this.comboPregunta.Name = "comboPregunta";
            this.comboPregunta.Size = new System.Drawing.Size(613, 33);
            this.comboPregunta.TabIndex = 24;
            // 
            // tRespuesta
            // 
            this.tRespuesta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRespuesta.Location = new System.Drawing.Point(77, 495);
            this.tRespuesta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tRespuesta.Name = "tRespuesta";
            this.tRespuesta.Size = new System.Drawing.Size(502, 32);
            this.tRespuesta.TabIndex = 27;
            // 
            // fCrearCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 582);
            this.Controls.Add(this.tRespuesta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboPregunta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboRol);
            this.Controls.Add(this.tContrasena2);
            this.Controls.Add(this.tCorreo);
            this.Controls.Add(this.tContrasena1);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "fCrearCuenta";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Crear Cuenta";
            this.Load += new System.EventHandler(this.fCrearCuenta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.TextBox tContrasena1;
        private System.Windows.Forms.TextBox tCorreo;
        private System.Windows.Forms.TextBox tContrasena2;
        private System.Windows.Forms.ComboBox comboRol;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboPregunta;
        private System.Windows.Forms.TextBox tRespuesta;
    }
}

