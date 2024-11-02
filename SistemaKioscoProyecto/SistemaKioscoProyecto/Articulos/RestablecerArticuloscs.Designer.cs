namespace SistemaKioscoProyecto
{
    partial class RestablecerArticuloscs
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
            this.Tb_IdArticulo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Tb_IdArticuloEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Tb_IdArticulo
            // 
            this.Tb_IdArticulo.Location = new System.Drawing.Point(129, 55);
            this.Tb_IdArticulo.Name = "Tb_IdArticulo";
            this.Tb_IdArticulo.Size = new System.Drawing.Size(517, 20);
            this.Tb_IdArticulo.TabIndex = 37;
            this.Tb_IdArticulo.TextChanged += new System.EventHandler(this.Tb_IdArticulo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(126, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 13);
            this.label4.TabIndex = 36;
            this.label4.Text = "ID Articulo a Restablecer :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Tb_IdArticuloEliminar
            // 
            this.Tb_IdArticuloEliminar.Location = new System.Drawing.Point(323, 106);
            this.Tb_IdArticuloEliminar.Name = "Tb_IdArticuloEliminar";
            this.Tb_IdArticuloEliminar.Size = new System.Drawing.Size(116, 30);
            this.Tb_IdArticuloEliminar.TabIndex = 35;
            this.Tb_IdArticuloEliminar.Text = "Restablecer";
            this.Tb_IdArticuloEliminar.UseVisualStyleBackColor = true;
            this.Tb_IdArticuloEliminar.Click += new System.EventHandler(this.Tb_IdArticuloEliminar_Click);
            // 
            // RestablecerArticuloscs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tb_IdArticulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tb_IdArticuloEliminar);
            this.Name = "RestablecerArticuloscs";
            this.Text = "RestablecerArticuloscs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_IdArticulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Tb_IdArticuloEliminar;
    }
}