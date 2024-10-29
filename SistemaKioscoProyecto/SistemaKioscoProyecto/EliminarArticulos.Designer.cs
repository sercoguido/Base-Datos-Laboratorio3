namespace SistemaKioscoProyecto
{
    partial class EliminarArticulos
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
            this.Tb_IdArticulo.Location = new System.Drawing.Point(124, 60);
            this.Tb_IdArticulo.Name = "Tb_IdArticulo";
            this.Tb_IdArticulo.Size = new System.Drawing.Size(517, 20);
            this.Tb_IdArticulo.TabIndex = 34;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(121, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 33;
            this.label4.Text = "ID Articulo a Eliminar :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Tb_IdArticuloEliminar
            // 
            this.Tb_IdArticuloEliminar.Location = new System.Drawing.Point(318, 111);
            this.Tb_IdArticuloEliminar.Name = "Tb_IdArticuloEliminar";
            this.Tb_IdArticuloEliminar.Size = new System.Drawing.Size(116, 30);
            this.Tb_IdArticuloEliminar.TabIndex = 32;
            this.Tb_IdArticuloEliminar.Text = "Eliminar";
            this.Tb_IdArticuloEliminar.UseVisualStyleBackColor = true;
            this.Tb_IdArticuloEliminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // EliminarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 267);
            this.Controls.Add(this.Tb_IdArticulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Tb_IdArticuloEliminar);
            this.Name = "EliminarArticulos";
            this.Text = "EliminarArticulos";
            this.Load += new System.EventHandler(this.EliminarArticulos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Tb_IdArticulo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Tb_IdArticuloEliminar;
    }
}