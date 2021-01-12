
namespace StreamEducation
{
    partial class fCrearMensajePrivado
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
            this.tAsunto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bAceptar = new System.Windows.Forms.Button();
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bSeleccionarUsuario = new System.Windows.Forms.Button();
            this.tDestinatario = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tAsunto
            // 
            this.tAsunto.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tAsunto.Location = new System.Drawing.Point(173, 117);
            this.tAsunto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tAsunto.Name = "tAsunto";
            this.tAsunto.Size = new System.Drawing.Size(459, 32);
            this.tAsunto.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 25);
            //this.label2.TabIndex = 33;
            this.label2.Text = "Asunto:";
            // 
            // bAceptar
            // 
            this.bAceptar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptar.Location = new System.Drawing.Point(664, 416);
            this.bAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(108, 39);
            this.bAceptar.TabIndex = 4;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // tDescripcion
            // 
            this.tDescripcion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDescripcion.Location = new System.Drawing.Point(56, 225);
            this.tDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tDescripcion.Multiline = true;
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.Size = new System.Drawing.Size(577, 230);
            this.tDescripcion.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(52, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 25);
            //this.label3.TabIndex = 29;
            this.label3.Text = "Mensaje:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 25);
            //this.label1.TabIndex = 35;
            this.label1.Text = "Destinatario:";
            // 
            // bSeleccionarUsuario
            // 
            this.bSeleccionarUsuario.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSeleccionarUsuario.Location = new System.Drawing.Point(585, 53);
            this.bSeleccionarUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bSeleccionarUsuario.Name = "bSeleccionarUsuario";
            this.bSeleccionarUsuario.Size = new System.Drawing.Size(48, 34);
            this.bSeleccionarUsuario.TabIndex = 1;
            this.bSeleccionarUsuario.Text = "...";
            this.bSeleccionarUsuario.UseVisualStyleBackColor = true;
            this.bSeleccionarUsuario.Click += new System.EventHandler(this.bSeleccionarUsuario_Click);
            // 
            // tDestinatario
            // 
            this.tDestinatario.Font = new System.Drawing.Font("Verdana", 12F);
            this.tDestinatario.Location = new System.Drawing.Point(231, 53);
            this.tDestinatario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tDestinatario.Name = "tDestinatario";
            this.tDestinatario.ReadOnly = true;
            this.tDestinatario.Size = new System.Drawing.Size(353, 32);
            this.tDestinatario.TabIndex = 37;
            this.tDestinatario.Text = "Seleccione usuario...";
            // 
            // fCrearMensajePrivado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 505);
            this.Controls.Add(this.tDestinatario);
            this.Controls.Add(this.bSeleccionarUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tAsunto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.tDescripcion);
            this.Controls.Add(this.label3);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fCrearMensajePrivado";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Escribir Mensaje Privado";
            this.Load += new System.EventHandler(this.fCrearMensajePrivado_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tAsunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.TextBox tDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSeleccionarUsuario;
        private System.Windows.Forms.TextBox tDestinatario;
    }
}