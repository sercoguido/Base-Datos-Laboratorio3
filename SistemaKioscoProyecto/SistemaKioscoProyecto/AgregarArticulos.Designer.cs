namespace SistemaKioscoProyecto
{
    partial class AgregarArticulos
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
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.Tb_Nombre = new System.Windows.Forms.TextBox();
            this.Tb_Descripcion = new System.Windows.Forms.TextBox();
            this.lbl_Descripcion = new System.Windows.Forms.Label();
            this.Tb_Precio = new System.Windows.Forms.TextBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.Tb_Stock = new System.Windows.Forms.TextBox();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.Tb_Proveedor = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_Marca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_Categoria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(107, 39);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(50, 13);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "Nombre :";
            this.lbl_Nombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // Tb_Nombre
            // 
            this.Tb_Nombre.Location = new System.Drawing.Point(160, 36);
            this.Tb_Nombre.Name = "Tb_Nombre";
            this.Tb_Nombre.Size = new System.Drawing.Size(517, 20);
            this.Tb_Nombre.TabIndex = 1;
            // 
            // Tb_Descripcion
            // 
            this.Tb_Descripcion.Location = new System.Drawing.Point(160, 62);
            this.Tb_Descripcion.Name = "Tb_Descripcion";
            this.Tb_Descripcion.Size = new System.Drawing.Size(517, 20);
            this.Tb_Descripcion.TabIndex = 3;
            this.Tb_Descripcion.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbl_Descripcion
            // 
            this.lbl_Descripcion.AutoSize = true;
            this.lbl_Descripcion.Location = new System.Drawing.Point(88, 65);
            this.lbl_Descripcion.Name = "lbl_Descripcion";
            this.lbl_Descripcion.Size = new System.Drawing.Size(69, 13);
            this.lbl_Descripcion.TabIndex = 2;
            this.lbl_Descripcion.Text = "Descripcion :";
            this.lbl_Descripcion.Click += new System.EventHandler(this.label2_Click);
            // 
            // Tb_Precio
            // 
            this.Tb_Precio.Location = new System.Drawing.Point(160, 114);
            this.Tb_Precio.Name = "Tb_Precio";
            this.Tb_Precio.Size = new System.Drawing.Size(517, 20);
            this.Tb_Precio.TabIndex = 7;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Location = new System.Drawing.Point(106, 117);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(52, 13);
            this.lbl_Precio.TabIndex = 6;
            this.lbl_Precio.Text = "Precio : $";
            // 
            // Tb_Stock
            // 
            this.Tb_Stock.Location = new System.Drawing.Point(160, 88);
            this.Tb_Stock.Name = "Tb_Stock";
            this.Tb_Stock.Size = new System.Drawing.Size(517, 20);
            this.Tb_Stock.TabIndex = 5;
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.Location = new System.Drawing.Point(119, 91);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(38, 13);
            this.lbl_Stock.TabIndex = 4;
            this.lbl_Stock.Text = "Stock:";
            // 
            // Tb_Proveedor
            // 
            this.Tb_Proveedor.Location = new System.Drawing.Point(160, 192);
            this.Tb_Proveedor.Name = "Tb_Proveedor";
            this.Tb_Proveedor.Size = new System.Drawing.Size(517, 20);
            this.Tb_Proveedor.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Proveedor :";
            // 
            // Tb_Marca
            // 
            this.Tb_Marca.Location = new System.Drawing.Point(160, 166);
            this.Tb_Marca.Name = "Tb_Marca";
            this.Tb_Marca.Size = new System.Drawing.Size(517, 20);
            this.Tb_Marca.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 169);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Marca :";
            // 
            // Tb_Categoria
            // 
            this.Tb_Categoria.Location = new System.Drawing.Point(160, 140);
            this.Tb_Categoria.Name = "Tb_Categoria";
            this.Tb_Categoria.Size = new System.Drawing.Size(517, 20);
            this.Tb_Categoria.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(96, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Categoria  :";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(602, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AgregarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 305);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Tb_Proveedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Tb_Marca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb_Categoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Tb_Precio);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.Tb_Stock);
            this.Controls.Add(this.lbl_Stock);
            this.Controls.Add(this.Tb_Descripcion);
            this.Controls.Add(this.lbl_Descripcion);
            this.Controls.Add(this.Tb_Nombre);
            this.Controls.Add(this.lbl_Nombre);
            this.Name = "AgregarArticulos";
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Articulos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.TextBox Tb_Nombre;
        private System.Windows.Forms.TextBox Tb_Descripcion;
        private System.Windows.Forms.Label lbl_Descripcion;
        private System.Windows.Forms.TextBox Tb_Precio;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.TextBox Tb_Stock;
        private System.Windows.Forms.Label lbl_Stock;
        private System.Windows.Forms.TextBox Tb_Proveedor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_Marca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_Categoria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}