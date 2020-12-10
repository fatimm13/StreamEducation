
namespace StreamEducation
{
    partial class fCrearForo
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
            this.label1 = new System.Windows.Forms.Label();
            this.tForo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tDescripcion = new System.Windows.Forms.TextBox();
            this.bAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Foro:";
            // 
            // tForo
            // 
            this.tForo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tForo.Location = new System.Drawing.Point(140, 57);
            this.tForo.Name = "tForo";
            this.tForo.Size = new System.Drawing.Size(512, 32);
            this.tForo.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Descripción:";
            // 
            // tDescripcion
            // 
            this.tDescripcion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tDescripcion.Location = new System.Drawing.Point(51, 188);
            this.tDescripcion.Multiline = true;
            this.tDescripcion.Name = "tDescripcion";
            this.tDescripcion.Size = new System.Drawing.Size(601, 256);
            this.tDescripcion.TabIndex = 10;
            // 
            // bAceptar
            // 
            this.bAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.bAceptar.Location = new System.Drawing.Point(690, 409);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(75, 35);
            this.bAceptar.TabIndex = 11;
            this.bAceptar.Text = "Aceptar";
            this.bAceptar.UseVisualStyleBackColor = true;
            // 
            // fCrearForo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 504);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.tDescripcion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tForo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "fCrearForo";
            this.ShowIcon = false;
            this.Text = "Crear Foro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tForo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tDescripcion;
        private System.Windows.Forms.Button bAceptar;
    }
}