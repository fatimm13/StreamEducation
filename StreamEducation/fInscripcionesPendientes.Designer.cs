
namespace StreamEducation
{
    partial class fInscripcionesPendientes
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
            this.lAceptar = new System.Windows.Forms.ListBox();
            this.bBuscar = new System.Windows.Forms.Button();
            this.tForo = new System.Windows.Forms.TextBox();
            this.lUsuarios = new System.Windows.Forms.ListBox();
            this.lRechazar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lAceptar
            // 
            this.lAceptar.BackColor = System.Drawing.SystemColors.Control;
            this.lAceptar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lAceptar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lAceptar.FormattingEnabled = true;
            this.lAceptar.ItemHeight = 17;
            this.lAceptar.Location = new System.Drawing.Point(606, 80);
            this.lAceptar.Name = "lAceptar";
            this.lAceptar.Size = new System.Drawing.Size(60, 340);
            this.lAceptar.TabIndex = 55;
            // 
            // bBuscar
            // 
            this.bBuscar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscar.Location = new System.Drawing.Point(672, 32);
            this.bBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(70, 28);
            this.bBuscar.TabIndex = 54;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            // 
            // tForo
            // 
            this.tForo.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tForo.Location = new System.Drawing.Point(23, 32);
            this.tForo.Margin = new System.Windows.Forms.Padding(2);
            this.tForo.Name = "tForo";
            this.tForo.Size = new System.Drawing.Size(630, 27);
            this.tForo.TabIndex = 53;
            // 
            // lUsuarios
            // 
            this.lUsuarios.BackColor = System.Drawing.SystemColors.Control;
            this.lUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lUsuarios.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lUsuarios.FormattingEnabled = true;
            this.lUsuarios.ItemHeight = 17;
            this.lUsuarios.Location = new System.Drawing.Point(23, 80);
            this.lUsuarios.Name = "lUsuarios";
            this.lUsuarios.Size = new System.Drawing.Size(577, 340);
            this.lUsuarios.TabIndex = 52;
            // 
            // lRechazar
            // 
            this.lRechazar.BackColor = System.Drawing.SystemColors.Control;
            this.lRechazar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lRechazar.Font = new System.Drawing.Font("Verdana", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lRechazar.FormattingEnabled = true;
            this.lRechazar.ItemHeight = 17;
            this.lRechazar.Location = new System.Drawing.Point(672, 80);
            this.lRechazar.Name = "lRechazar";
            this.lRechazar.Size = new System.Drawing.Size(60, 340);
            this.lRechazar.TabIndex = 56;
            // 
            // fInscripcionesPendientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 453);
            this.Controls.Add(this.lRechazar);
            this.Controls.Add(this.lAceptar);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.tForo);
            this.Controls.Add(this.lUsuarios);
            this.MaximizeBox = false;
            this.Name = "fInscripcionesPendientes";
            this.ShowIcon = false;
            this.Text = "Inscripciones Pendientes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lAceptar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.TextBox tForo;
        private System.Windows.Forms.ListBox lUsuarios;
        private System.Windows.Forms.ListBox lRechazar;
    }
}