namespace SistemaKioscoProyecto.Marca
{
    partial class ModificarMarca
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
            this.Btn_ModificarMarca = new System.Windows.Forms.Button();
            this.Tb_Nombre = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.Tb_ID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Btn_ModificarMarca
            // 
            this.Btn_ModificarMarca.Location = new System.Drawing.Point(610, 101);
            this.Btn_ModificarMarca.Name = "Btn_ModificarMarca";
            this.Btn_ModificarMarca.Size = new System.Drawing.Size(75, 23);
            this.Btn_ModificarMarca.TabIndex = 35;
            this.Btn_ModificarMarca.Text = "Modificar";
            this.Btn_ModificarMarca.UseVisualStyleBackColor = true;
            this.Btn_ModificarMarca.Click += new System.EventHandler(this.Btn_ModificarMarca_Click);
            // 
            // Tb_Nombre
            // 
            this.Tb_Nombre.Location = new System.Drawing.Point(168, 61);
            this.Tb_Nombre.Name = "Tb_Nombre";
            this.Tb_Nombre.Size = new System.Drawing.Size(517, 20);
            this.Tb_Nombre.TabIndex = 34;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(115, 64);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(50, 13);
            this.lbl_Nombre.TabIndex = 33;
            this.lbl_Nombre.Text = "Nombre :";
            // 
            // Tb_ID
            // 
            this.Tb_ID.Location = new System.Drawing.Point(168, 35);
            this.Tb_ID.Name = "Tb_ID";
            this.Tb_ID.Size = new System.Drawing.Size(517, 20);
            this.Tb_ID.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(139, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "ID :";
            // 
            // ModificarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 171);
            this.Controls.Add(this.Tb_ID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_ModificarMarca);
            this.Controls.Add(this.Tb_Nombre);
            this.Controls.Add(this.lbl_Nombre);
            this.Name = "ModificarMarca";
            this.Text = "ModificarMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_ModificarMarca;
        private System.Windows.Forms.TextBox Tb_Nombre;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox Tb_ID;
        private System.Windows.Forms.Label label1;
    }
}