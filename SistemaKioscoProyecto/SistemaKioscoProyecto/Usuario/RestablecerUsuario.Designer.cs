namespace SistemaKioscoProyecto
{
    partial class RestablecerUsuario
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
            this.Tb_IdUsuario = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tb_IdUsuarioEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tb_IdUsuario
            // 
            this.Tb_IdUsuario.Location = new System.Drawing.Point(135, 58);
            this.Tb_IdUsuario.Name = "Tb_IdUsuario";
            this.Tb_IdUsuario.Size = new System.Drawing.Size(517, 20);
            this.Tb_IdUsuario.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(132, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 13);
            this.label4.TabIndex = 39;
            this.label4.Text = "ID Usuario a Restablecer :";
            // 
            // Tb_IdUsuarioEliminar
            // 
            this.Tb_IdUsuarioEliminar.Location = new System.Drawing.Point(329, 109);
            this.Tb_IdUsuarioEliminar.Name = "Tb_IdUsuarioEliminar";
            this.Tb_IdUsuarioEliminar.Size = new System.Drawing.Size(116, 30);
            this.Tb_IdUsuarioEliminar.TabIndex = 38;
            this.Tb_IdUsuarioEliminar.Text = "Restablecer";
            this.Tb_IdUsuarioEliminar.UseVisualStyleBackColor = true;
            this.Tb_IdUsuarioEliminar.Click += new System.EventHandler(this.Tb_IdArticuloEliminar_Click);
            // 
            // RestablecerUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tb_IdUsuario);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tb_IdUsuarioEliminar);
            this.Name = "RestablecerUsuario";
            this.Text = "RestablecerUsuario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_IdUsuario;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Tb_IdUsuarioEliminar;
    }
}