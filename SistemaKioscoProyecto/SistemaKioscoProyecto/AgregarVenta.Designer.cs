namespace SistemaKioscoProyecto
{
    partial class AgregarVenta
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
            this.label1 = new System.Windows.Forms.Label();
            this.Tb_Articulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Tb_Cantidad = new System.Windows.Forms.TextBox();
            this.dgvItemsVentas = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsVentas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Articulo";
            // 
            // Tb_Articulo
            // 
            this.Tb_Articulo.Location = new System.Drawing.Point(212, 29);
            this.Tb_Articulo.Name = "Tb_Articulo";
            this.Tb_Articulo.Size = new System.Drawing.Size(388, 20);
            this.Tb_Articulo.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cantidad";
            // 
            // Tb_Cantidad
            // 
            this.Tb_Cantidad.Location = new System.Drawing.Point(212, 68);
            this.Tb_Cantidad.Name = "Tb_Cantidad";
            this.Tb_Cantidad.Size = new System.Drawing.Size(388, 20);
            this.Tb_Cantidad.TabIndex = 4;
            // 
            // dgvItemsVentas
            // 
            this.dgvItemsVentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemsVentas.Location = new System.Drawing.Point(12, 175);
            this.dgvItemsVentas.Name = "dgvItemsVentas";
            this.dgvItemsVentas.Size = new System.Drawing.Size(776, 232);
            this.dgvItemsVentas.TabIndex = 5;
            this.dgvItemsVentas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Venta Actual:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.PaleGreen;
            this.button1.Location = new System.Drawing.Point(359, 108);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // AgregarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvItemsVentas);
            this.Controls.Add(this.Tb_Cantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Tb_Articulo);
            this.Controls.Add(this.label1);
            this.Name = "AgregarVenta";
            this.Text = "AgregarVenta";
            this.Load += new System.EventHandler(this.AgregarVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemsVentas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Tb_Articulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Tb_Cantidad;
        private System.Windows.Forms.DataGridView dgvItemsVentas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}