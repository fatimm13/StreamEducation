
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
            this.tNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bAceptar = new System.Windows.Forms.Button();
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bSeleccionarUsuario = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tNombre
            // 
            this.tNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombre.Location = new System.Drawing.Point(129, 69);
            this.tNombre.Margin = new System.Windows.Forms.Padding(2);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(366, 27);
            this.tNombre.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 72);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 18);
            this.label3.TabIndex = 33;
            this.label3.Text = "Título:";
            // 
            // bAceptar
            // 
            this.bAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bAceptar.Location = new System.Drawing.Point(523, 343);
            this.bAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(56, 28);
            this.bAceptar.TabIndex = 31;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            // 
            // tDescripcion
            // 
            this.tDescripcion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDescripcion.Location = new System.Drawing.Point(43, 149);
            this.tDescripcion.Margin = new System.Windows.Forms.Padding(2);
            this.tDescripcion.Multiline = true;
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.Size = new System.Drawing.Size(452, 223);
            this.tDescripcion.TabIndex = 30;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(39, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 18);
            this.label4.TabIndex = 29;
            this.label4.Text = "Mensaje:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 18);
            this.label1.TabIndex = 35;
            this.label1.Text = "Destinatario:";
            // 
            // bSeleccionarUsuario
            // 
            this.bSeleccionarUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.bSeleccionarUsuario.Location = new System.Drawing.Point(439, 29);
            this.bSeleccionarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.bSeleccionarUsuario.Name = "bSeleccionarUsuario";
            this.bSeleccionarUsuario.Size = new System.Drawing.Size(56, 28);
            this.bSeleccionarUsuario.TabIndex = 36;
            this.bSeleccionarUsuario.Text = "...";
            this.bSeleccionarUsuario.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Verdana", 12F);
            this.textBox1.Location = new System.Drawing.Point(160, 30);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(275, 27);
            this.textBox1.TabIndex = 37;
            this.textBox1.Text = "Seleccionar usuario...";
            // 
            // fCrearMensajePrivado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 410);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bSeleccionarUsuario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.tDescripcion);
            this.Controls.Add(this.label4);
            this.Name = "fCrearMensajePrivado";
            this.Text = "fCrearMensajePrivado";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.TextBox tDescripcion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bSeleccionarUsuario;
        private System.Windows.Forms.TextBox textBox1;
    }
}