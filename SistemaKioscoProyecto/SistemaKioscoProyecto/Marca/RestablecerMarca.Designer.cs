namespace SistemaKioscoProyecto.Marca
{
    partial class RestablecerMarca
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
            this.Btn_Restablecer = new System.Windows.Forms.Button();
            this.Tb_IDMarca = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_Restablecer
            // 
            this.Btn_Restablecer.Location = new System.Drawing.Point(582, 104);
            this.Btn_Restablecer.Name = "Btn_Restablecer";
            this.Btn_Restablecer.Size = new System.Drawing.Size(75, 23);
            this.Btn_Restablecer.TabIndex = 35;
            this.Btn_Restablecer.Text = "Restablecer";
            this.Btn_Restablecer.UseVisualStyleBackColor = true;
            this.Btn_Restablecer.Click += new System.EventHandler(this.Btn_Restablecer_Click);
            // 
            // Tb_IDMarca
            // 
            this.Tb_IDMarca.Location = new System.Drawing.Point(140, 49);
            this.Tb_IDMarca.Name = "Tb_IDMarca";
            this.Tb_IDMarca.Size = new System.Drawing.Size(517, 20);
            this.Tb_IDMarca.TabIndex = 34;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(104, 52);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(24, 13);
            this.lbl_Nombre.TabIndex = 33;
            this.lbl_Nombre.Text = "ID :";
            // 
            // RestablecerMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 159);
            this.Controls.Add(this.Btn_Restablecer);
            this.Controls.Add(this.Tb_IDMarca);
            this.Controls.Add(this.lbl_Nombre);
            this.Name = "RestablecerMarca";
            this.Text = "RestablecerMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Restablecer;
        private System.Windows.Forms.TextBox Tb_IDMarca;
        private System.Windows.Forms.Label lbl_Nombre;
    }
}