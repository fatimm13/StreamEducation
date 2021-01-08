
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
            this.bEnviar = new System.Windows.Forms.Button();
            this.lMensajes = new System.Windows.Forms.ListBox();
            this.bCerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lNotificaciones = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bEnviar
            // 
            this.bEnviar.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEnviar.Location = new System.Drawing.Point(671, 243);
            this.bEnviar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bEnviar.Name = "bEnviar";
            this.bEnviar.Size = new System.Drawing.Size(280, 44);
            this.bEnviar.TabIndex = 29;
            this.bEnviar.Text = "✉️ Escribir Mensaje";
            this.bEnviar.UseVisualStyleBackColor = true;
            this.bEnviar.Click += new System.EventHandler(this.bEnviar_Click);
            // 
            // lMensajes
            // 
            this.lMensajes.BackColor = System.Drawing.SystemColors.Window;
            this.lMensajes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lMensajes.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMensajes.FormattingEnabled = true;
            this.lMensajes.ItemHeight = 25;
            this.lMensajes.Location = new System.Drawing.Point(55, 308);
            this.lMensajes.Margin = new System.Windows.Forms.Padding(4);
            this.lMensajes.Name = "lMensajes";
            this.lMensajes.Size = new System.Drawing.Size(896, 202);
            this.lMensajes.TabIndex = 44;
            this.lMensajes.SelectedIndexChanged += new System.EventHandler(this.lMensajes_SelectedIndexChanged);
            // 
            // bCerrar
            // 
            this.bCerrar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCerrar.Location = new System.Drawing.Point(834, 536);
            this.bCerrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.bCerrar.Name = "bCerrar";
            this.bCerrar.Size = new System.Drawing.Size(117, 41);
            this.bCerrar.TabIndex = 45;
            this.bCerrar.Text = "Cerrar";
            this.bCerrar.UseVisualStyleBackColor = true;
            this.bCerrar.Click += new System.EventHandler(this.bCerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 29);
            this.label1.TabIndex = 46;
            this.label1.Text = "🔔 Notificaciones";
            // 
            // lNotificaciones
            // 
            this.lNotificaciones.BackColor = System.Drawing.SystemColors.Window;
            this.lNotificaciones.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lNotificaciones.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNotificaciones.FormattingEnabled = true;
            this.lNotificaciones.ItemHeight = 25;
            this.lNotificaciones.Location = new System.Drawing.Point(55, 93);
            this.lNotificaciones.Margin = new System.Windows.Forms.Padding(4);
            this.lNotificaciones.Name = "lNotificaciones";
            this.lNotificaciones.Size = new System.Drawing.Size(896, 102);
            this.lNotificaciones.TabIndex = 47;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(50, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(177, 29);
            this.label2.TabIndex = 48;
            this.label2.Text = "✉️ Mensajes";
            // 
            // fMensajeria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 610);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lNotificaciones);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCerrar);
            this.Controls.Add(this.lMensajes);
            this.Controls.Add(this.bEnviar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "fMensajeria";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mensajeria";
            this.Load += new System.EventHandler(this.fMensajeria_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bEnviar;
        private System.Windows.Forms.ListBox lMensajes;
        private System.Windows.Forms.Button bCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lNotificaciones;
        private System.Windows.Forms.Label label2;
    }
}