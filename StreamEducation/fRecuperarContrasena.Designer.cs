
namespace StreamEducation
{
    partial class fRecuperarContrasena
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
            this.label4 = new System.Windows.Forms.Label();
            this.bAceptar = new System.Windows.Forms.Button();
            this.tRespuesta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboPregunta = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(64, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 25);
            //this.label4.TabIndex = 31;
            this.label4.Text = "Pregunta:";
            // 
            // bAceptar
            // 
            this.bAceptar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptar.Location = new System.Drawing.Point(611, 389);
            this.bAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(112, 42);
            this.bAceptar.TabIndex = 3;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // tRespuesta
            // 
            this.tRespuesta.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tRespuesta.Location = new System.Drawing.Point(224, 276);
            this.tRespuesta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tRespuesta.Name = "tRespuesta";
            this.tRespuesta.Size = new System.Drawing.Size(499, 32);
            this.tRespuesta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 279);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            //this.label2.TabIndex = 24;
            this.label2.Text = "Respuesta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(677, 29);
            //this.label1.TabIndex = 32;
            this.label1.Text = "Elija su pregunta de confirmación y su respuesta:";
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
            this.comboPregunta.Location = new System.Drawing.Point(224, 168);
            this.comboPregunta.Name = "comboPregunta";
            this.comboPregunta.Size = new System.Drawing.Size(499, 33);
            this.comboPregunta.TabIndex = 1;
            // 
            // fRecuperarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 505);
            this.Controls.Add(this.comboPregunta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.tRespuesta);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fRecuperarContrasena";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Recuperar Contrasena";
            this.Load += new System.EventHandler(this.fRecuperarContrasena_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.TextBox tRespuesta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboPregunta;
    }
}