
namespace StreamEducation
{
    partial class fIniciarSesion
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
            this.tContrasena = new System.Windows.Forms.TextBox();
            this.tCorreo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tContrasena
            // 
            this.tContrasena.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tContrasena.Location = new System.Drawing.Point(253, 285);
            this.tContrasena.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tContrasena.Name = "tContrasena";
            this.tContrasena.PasswordChar = '*';
            this.tContrasena.Size = new System.Drawing.Size(441, 32);
            this.tContrasena.TabIndex = 14;
            // 
            // tCorreo
            // 
            this.tCorreo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tCorreo.Location = new System.Drawing.Point(253, 169);
            this.tCorreo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tCorreo.Name = "tCorreo";
            this.tCorreo.Size = new System.Drawing.Size(441, 32);
            this.tCorreo.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(69, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(136, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Contraseña:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(69, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Correo:";
            // 
            // bAceptar
            // 
            this.bAceptar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptar.Location = new System.Drawing.Point(606, 411);
            this.bAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(88, 34);
            this.bAceptar.TabIndex = 10;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(507, 34);
            this.label1.TabIndex = 9;
            this.label1.Text = "Rellene los siguientes campos:";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(339, 411);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(222, 34);
            this.button1.TabIndex = 15;
            this.button1.Text = "Recuperar contraseña";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // fIniciarSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 505);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tContrasena);
            this.Controls.Add(this.tCorreo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "fIniciarSesion";
            this.ShowIcon = false;
            this.Text = "Iniciar Sesion";
            this.Load += new System.EventHandler(this.fIniciarSesion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tContrasena;
        private System.Windows.Forms.TextBox tCorreo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}