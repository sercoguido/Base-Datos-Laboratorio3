namespace SistemaKioscoProyecto
{
    partial class InformeMarcas
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
            this.button1 = new System.Windows.Forms.Button();
            this.Tb_IDMarca = new System.Windows.Forms.TextBox();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_Cantidad = new System.Windows.Forms.Label();
            this.Lbl_Promedio = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(588, 88);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 32;
            this.button1.Text = "Ver Informe";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Tb_IDMarca
            // 
            this.Tb_IDMarca.Location = new System.Drawing.Point(146, 40);
            this.Tb_IDMarca.Name = "Tb_IDMarca";
            this.Tb_IDMarca.Size = new System.Drawing.Size(517, 20);
            this.Tb_IDMarca.TabIndex = 31;
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(82, 44);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(57, 13);
            this.lbl_Nombre.TabIndex = 30;
            this.lbl_Nombre.Text = "ID Marca :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label1.Location = new System.Drawing.Point(157, 152);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Cantidad de articulos con esa marca (ACTIVOS) : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label2.Location = new System.Drawing.Point(178, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(294, 17);
            this.label2.TabIndex = 34;
            this.label2.Text = "Precio Promedio de articulos con esa marca :";
            // 
            // Lbl_Cantidad
            // 
            this.Lbl_Cantidad.AutoSize = true;
            this.Lbl_Cantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Lbl_Cantidad.Location = new System.Drawing.Point(484, 149);
            this.Lbl_Cantidad.Name = "Lbl_Cantidad";
            this.Lbl_Cantidad.Size = new System.Drawing.Size(18, 20);
            this.Lbl_Cantidad.TabIndex = 35;
            this.Lbl_Cantidad.Text = "0";
            // 
            // Lbl_Promedio
            // 
            this.Lbl_Promedio.AutoSize = true;
            this.Lbl_Promedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.Lbl_Promedio.Location = new System.Drawing.Point(485, 187);
            this.Lbl_Promedio.Name = "Lbl_Promedio";
            this.Lbl_Promedio.Size = new System.Drawing.Size(18, 20);
            this.Lbl_Promedio.TabIndex = 36;
            this.Lbl_Promedio.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(465, 187);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "$";
            // 
            // InformeMarcas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 292);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lbl_Promedio);
            this.Controls.Add(this.Lbl_Cantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tb_IDMarca);
            this.Controls.Add(this.lbl_Nombre);
            this.Name = "InformeMarcas";
            this.Text = "InformeMarcas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox Tb_IDMarca;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_Cantidad;
        private System.Windows.Forms.Label Lbl_Promedio;
        private System.Windows.Forms.Label label3;
    }
}