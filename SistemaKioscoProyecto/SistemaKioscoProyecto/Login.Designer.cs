namespace SistemaKioscoProyecto
{
    partial class Login
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TbEmail = new System.Windows.Forms.TextBox();
            this.TbContra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ErrMail = new System.Windows.Forms.Label();
            this.ErrContra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(542, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(217, 186);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(324, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(264, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 46);
            this.button1.TabIndex = 2;
            this.button1.Text = "Ingresar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TbEmail
            // 
            this.TbEmail.Location = new System.Drawing.Point(205, 44);
            this.TbEmail.Name = "TbEmail";
            this.TbEmail.Size = new System.Drawing.Size(274, 20);
            this.TbEmail.TabIndex = 3;
            // 
            // TbContra
            // 
            this.TbContra.Location = new System.Drawing.Point(205, 114);
            this.TbContra.Name = "TbContra";
            this.TbContra.Size = new System.Drawing.Size(274, 20);
            this.TbContra.TabIndex = 5;
            this.TbContra.UseSystemPasswordChar = true;
            this.TbContra.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(309, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ErrMail
            // 
            this.ErrMail.AutoSize = true;
            this.ErrMail.Location = new System.Drawing.Point(206, 72);
            this.ErrMail.Name = "ErrMail";
            this.ErrMail.Size = new System.Drawing.Size(0, 13);
            this.ErrMail.TabIndex = 7;
            this.ErrMail.Click += new System.EventHandler(this.label4_Click);
            // 
            // ErrContra
            // 
            this.ErrContra.AutoSize = true;
            this.ErrContra.Location = new System.Drawing.Point(207, 144);
            this.ErrContra.Name = "ErrContra";
            this.ErrContra.Size = new System.Drawing.Size(0, 13);
            this.ErrContra.TabIndex = 8;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 246);
            this.Controls.Add(this.ErrContra);
            this.Controls.Add(this.ErrMail);
            this.Controls.Add(this.TbContra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TbEmail);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Login";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TbEmail;
        private System.Windows.Forms.TextBox TbContra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ErrMail;
        private System.Windows.Forms.Label ErrContra;
    }
}

