
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
            this.comboRecurso = new System.Windows.Forms.ComboBox();
            this.bAceptar = new System.Windows.Forms.Button();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(28, 118);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 18);
            this.label4.TabIndex = 31;
            this.label4.Text = "Pregunta:";
            // 
            // comboRecurso
            // 
            this.comboRecurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRecurso.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboRecurso.FormattingEnabled = true;
            this.comboRecurso.Items.AddRange(new object[] {
            "🖼️",
            "🎞️",
            "📄",
            "🔗"});
            this.comboRecurso.Location = new System.Drawing.Point(133, 115);
            this.comboRecurso.Margin = new System.Windows.Forms.Padding(2);
            this.comboRecurso.Name = "comboRecurso";
            this.comboRecurso.Size = new System.Drawing.Size(316, 26);
            this.comboRecurso.TabIndex = 30;
            // 
            // bAceptar
            // 
            this.bAceptar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptar.Location = new System.Drawing.Point(477, 323);
            this.bAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(78, 28);
            this.bAceptar.TabIndex = 29;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            // 
            // tNombre
            // 
            this.tNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombre.Location = new System.Drawing.Point(133, 191);
            this.tNombre.Margin = new System.Windows.Forms.Padding(2);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(316, 27);
            this.tNombre.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 194);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 18);
            this.label2.TabIndex = 24;
            this.label2.Text = "Respuesta:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Elija su pregunta de confirmación elegida y su respuesta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // fRecuperarContrasena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 410);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboRecurso);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "fRecuperarContrasena";
            this.ShowIcon = false;
            this.Text = "Recuperar Contrasena";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboRecurso;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}