
namespace StreamEducation
{
    partial class fCrearCurso
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
            this.bAceptar = new System.Windows.Forms.Button();
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.cbPublico = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // bAceptar
            // 
            this.bAceptar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptar.Location = new System.Drawing.Point(660, 414);
            this.bAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(117, 34);
            this.bAceptar.TabIndex = 5;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // tDescripcion
            // 
            this.tDescripcion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDescripcion.Location = new System.Drawing.Point(48, 240);
            this.tDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tDescripcion.Multiline = true;
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.Size = new System.Drawing.Size(591, 207);
            this.tDescripcion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 25);
            //this.label3.TabIndex = 14;
            this.label3.Text = "Descripción:";
            // 
            // tNombre
            // 
            this.tNombre.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tNombre.Location = new System.Drawing.Point(163, 60);
            this.tNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(476, 32);
            this.tNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 25);
            //this.label1.TabIndex = 12;
            this.label1.Text = "Nombre:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(163, 126);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(475, 32);
            this.dateTimePicker.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            //this.label2.TabIndex = 25;
            this.label2.Text = "Inicio:";
            // 
            // cbPublico
            // 
            this.cbPublico.AutoSize = true;
            this.cbPublico.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPublico.Location = new System.Drawing.Point(400, 202);
            this.cbPublico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPublico.Name = "cbPublico";
            this.cbPublico.Size = new System.Drawing.Size(221, 29);
            this.cbPublico.TabIndex = 3;
            this.cbPublico.Text = "El curso es público";
            this.cbPublico.UseVisualStyleBackColor = true;
            // 
            // fCrearCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 507);
            this.Controls.Add(this.cbPublico);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.tDescripcion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "fCrearCurso";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Crear Curso";
            this.Load += new System.EventHandler(this.fCrearCurso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.TextBox tDescripcion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbPublico;
    }
}