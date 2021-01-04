
namespace StreamEducation
{
    partial class fMensajeria
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
            this.bEnviar = new System.Windows.Forms.Button();
            this.lMensajes = new System.Windows.Forms.ListBox();
            this.bCerrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(327, 34);
            this.label4.TabIndex = 31;
            this.label4.Text = "Bandeja de Entrada";
            // 
            // bEnviar
            // 
            this.bEnviar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnviar.Location = new System.Drawing.Point(671, 45);
            this.bEnviar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(280, 44);
            this.bEnviar.TabIndex = 29;
            this.bEnviar.Text = "✉️ Enviar Mensaje";
            this.bEnviar.UseVisualStyleBackColor = true;
            // 
            // lMensajes
            // 
            this.lMensajes.BackColor = System.Drawing.SystemColors.Window;
            this.lMensajes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lMensajes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMensajes.FormattingEnabled = true;
            this.lMensajes.ItemHeight = 25;
            this.lMensajes.Location = new System.Drawing.Point(55, 107);
            this.lMensajes.Margin = new System.Windows.Forms.Padding(4);
            this.lMensajes.Name = "lMensajes";
            this.lMensajes.Size = new System.Drawing.Size(896, 352);
            this.lMensajes.TabIndex = 44;
            // 
            // bCerrar
            // 
            this.bCerrar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCerrar.Location = new System.Drawing.Point(834, 486);
            this.bCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(117, 41);
            this.bCerrar.TabIndex = 45;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            // 
            // fMensajeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 558);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.lMensajes);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bEnviar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fMensajeria";
            this.ShowIcon = false;
            this.Text = "Mensajeria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bEnviar;
        private System.Windows.Forms.ListBox lMensajes;
        private System.Windows.Forms.Button bCerrar;
    }
}