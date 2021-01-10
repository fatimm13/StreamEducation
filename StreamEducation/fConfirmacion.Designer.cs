
namespace StreamEducation
{
    partial class fConfirmacion
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
            this.bAceptar = new System.Windows.Forms.Button();
            this.bRechazar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 25);
            //this.label1.TabIndex = 5;
            this.label1.Text = "Confirme su acción:";
            // 
            // bAceptar
            // 
            this.bAceptar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAceptar.Location = new System.Drawing.Point(81, 82);
            this.bAceptar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bAceptar.Name = "bAceptar";
            this.bAceptar.Size = new System.Drawing.Size(150, 43);
            this.bAceptar.TabIndex = 1;
            this.bAceptar.Text = "Aceptar ✔️";
            this.bAceptar.UseVisualStyleBackColor = true;
            this.bAceptar.Click += new System.EventHandler(this.bAceptar_Click);
            // 
            // bRechazar
            // 
            this.bRechazar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bRechazar.Location = new System.Drawing.Point(274, 82);
            this.bRechazar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bRechazar.Name = "bRechazar";
            this.bRechazar.Size = new System.Drawing.Size(151, 43);
            this.bRechazar.TabIndex = 2;
            this.bRechazar.Text = "Rechazar ❌";
            this.bRechazar.UseVisualStyleBackColor = true;
            this.bRechazar.Click += new System.EventHandler(this.bRechazar_Click);
            // 
            // fConfirmacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 162);
            this.Controls.Add(this.bRechazar);
            this.Controls.Add(this.bAceptar);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "fConfirmacion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Confirmar";
            this.Load += new System.EventHandler(this.fConfirmacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAceptar;
        private System.Windows.Forms.Button bRechazar;
    }
}