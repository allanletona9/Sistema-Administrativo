namespace SAE_2019.Inventario
{
    partial class Frm_productos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_productos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_iconoProducto = new System.Windows.Forms.Button();
            this.Lbl_productos = new System.Windows.Forms.Label();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_nombreProducto = new System.Windows.Forms.Label();
            this.Txt_nombreProducto = new System.Windows.Forms.TextBox();
            this.Lbl_descProducto = new System.Windows.Forms.Label();
            this.Txt_descProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_precioProducto = new System.Windows.Forms.TextBox();
            this.Lbl_estadoProducto = new System.Windows.Forms.Label();
            this.Txt_estadoProducto = new System.Windows.Forms.TextBox();
            this.Lbl_idProducto = new System.Windows.Forms.Label();
            this.Txt_idProducto = new System.Windows.Forms.TextBox();
            this.navegador1 = new CapaDiseno.Navegador();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.Btn_iconoProducto);
            this.panel1.Controls.Add(this.Lbl_productos);
            this.panel1.Controls.Add(this.Btn_minimizar);
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 59);
            this.panel1.TabIndex = 0;
            // 
            // Btn_iconoProducto
            // 
            this.Btn_iconoProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_iconoProducto.BackgroundImage")));
            this.Btn_iconoProducto.Enabled = false;
            this.Btn_iconoProducto.FlatAppearance.BorderSize = 0;
            this.Btn_iconoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_iconoProducto.Location = new System.Drawing.Point(20, 5);
            this.Btn_iconoProducto.Name = "Btn_iconoProducto";
            this.Btn_iconoProducto.Size = new System.Drawing.Size(48, 48);
            this.Btn_iconoProducto.TabIndex = 9;
            this.Btn_iconoProducto.UseVisualStyleBackColor = true;
            // 
            // Lbl_productos
            // 
            this.Lbl_productos.AutoSize = true;
            this.Lbl_productos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_productos.Location = new System.Drawing.Point(99, 20);
            this.Lbl_productos.Name = "Lbl_productos";
            this.Lbl_productos.Size = new System.Drawing.Size(101, 19);
            this.Lbl_productos.TabIndex = 10;
            this.Lbl_productos.Text = "PRODUCTOS";
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.BackgroundImage")));
            this.Btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Location = new System.Drawing.Point(1061, 0);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(48, 48);
            this.Btn_minimizar.TabIndex = 1;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.BackgroundImage")));
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Location = new System.Drawing.Point(1115, 0);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(48, 48);
            this.Btn_cerrar.TabIndex = 1;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Lbl_nombreProducto
            // 
            this.Lbl_nombreProducto.AutoSize = true;
            this.Lbl_nombreProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombreProducto.Location = new System.Drawing.Point(261, 377);
            this.Lbl_nombreProducto.Name = "Lbl_nombreProducto";
            this.Lbl_nombreProducto.Size = new System.Drawing.Size(158, 17);
            this.Lbl_nombreProducto.TabIndex = 1;
            this.Lbl_nombreProducto.Text = "Nombre del producto:";
            // 
            // Txt_nombreProducto
            // 
            this.Txt_nombreProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_nombreProducto.Location = new System.Drawing.Point(595, 364);
            this.Txt_nombreProducto.Multiline = true;
            this.Txt_nombreProducto.Name = "Txt_nombreProducto";
            this.Txt_nombreProducto.Size = new System.Drawing.Size(259, 37);
            this.Txt_nombreProducto.TabIndex = 2;
            this.Txt_nombreProducto.Tag = "2";
            // 
            // Lbl_descProducto
            // 
            this.Lbl_descProducto.AutoSize = true;
            this.Lbl_descProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descProducto.Location = new System.Drawing.Point(261, 450);
            this.Lbl_descProducto.Name = "Lbl_descProducto";
            this.Lbl_descProducto.Size = new System.Drawing.Size(183, 17);
            this.Lbl_descProducto.TabIndex = 3;
            this.Lbl_descProducto.Text = "Descripción del Producto:";
            // 
            // Txt_descProducto
            // 
            this.Txt_descProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_descProducto.Location = new System.Drawing.Point(595, 438);
            this.Txt_descProducto.Multiline = true;
            this.Txt_descProducto.Name = "Txt_descProducto";
            this.Txt_descProducto.Size = new System.Drawing.Size(259, 37);
            this.Txt_descProducto.TabIndex = 4;
            this.Txt_descProducto.Tag = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(261, 524);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Precio:";
            // 
            // Txt_precioProducto
            // 
            this.Txt_precioProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_precioProducto.Location = new System.Drawing.Point(595, 512);
            this.Txt_precioProducto.Multiline = true;
            this.Txt_precioProducto.Name = "Txt_precioProducto";
            this.Txt_precioProducto.Size = new System.Drawing.Size(259, 37);
            this.Txt_precioProducto.TabIndex = 6;
            this.Txt_precioProducto.Tag = "4";
            // 
            // Lbl_estadoProducto
            // 
            this.Lbl_estadoProducto.AutoSize = true;
            this.Lbl_estadoProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estadoProducto.Location = new System.Drawing.Point(265, 638);
            this.Lbl_estadoProducto.Name = "Lbl_estadoProducto";
            this.Lbl_estadoProducto.Size = new System.Drawing.Size(56, 17);
            this.Lbl_estadoProducto.TabIndex = 7;
            this.Lbl_estadoProducto.Text = "Estado:";
            // 
            // Txt_estadoProducto
            // 
            this.Txt_estadoProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_estadoProducto.Location = new System.Drawing.Point(595, 633);
            this.Txt_estadoProducto.Multiline = true;
            this.Txt_estadoProducto.Name = "Txt_estadoProducto";
            this.Txt_estadoProducto.Size = new System.Drawing.Size(259, 37);
            this.Txt_estadoProducto.TabIndex = 8;
            this.Txt_estadoProducto.Tag = "6";
            // 
            // Lbl_idProducto
            // 
            this.Lbl_idProducto.AutoSize = true;
            this.Lbl_idProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_idProducto.Location = new System.Drawing.Point(261, 300);
            this.Lbl_idProducto.Name = "Lbl_idProducto";
            this.Lbl_idProducto.Size = new System.Drawing.Size(17, 17);
            this.Lbl_idProducto.TabIndex = 9;
            this.Lbl_idProducto.Text = "c";
            // 
            // Txt_idProducto
            // 
            this.Txt_idProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_idProducto.Location = new System.Drawing.Point(595, 288);
            this.Txt_idProducto.Multiline = true;
            this.Txt_idProducto.Name = "Txt_idProducto";
            this.Txt_idProducto.Size = new System.Drawing.Size(259, 37);
            this.Txt_idProducto.TabIndex = 10;
            this.Txt_idProducto.Tag = "1";
            this.Txt_idProducto.Text = "c";
            this.Txt_idProducto.TextChanged += new System.EventHandler(this.Txt_idProducto_TextChanged);
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navegador1.Location = new System.Drawing.Point(76, 113);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(995, 65);
            this.navegador1.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(595, 574);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(259, 37);
            this.textBox1.TabIndex = 13;
            this.textBox1.Tag = "5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(261, 577);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Existencias";
            // 
            // Frm_productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 749);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.Txt_idProducto);
            this.Controls.Add(this.Lbl_idProducto);
            this.Controls.Add(this.Txt_descProducto);
            this.Controls.Add(this.Txt_estadoProducto);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Lbl_nombreProducto);
            this.Controls.Add(this.Txt_nombreProducto);
            this.Controls.Add(this.Lbl_estadoProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_descProducto);
            this.Controls.Add(this.Txt_precioProducto);
            this.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_productos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_productos";
            this.Load += new System.EventHandler(this.Frm_productos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Label Lbl_nombreProducto;
        private System.Windows.Forms.TextBox Txt_nombreProducto;
        private System.Windows.Forms.Label Lbl_descProducto;
        private System.Windows.Forms.TextBox Txt_descProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_precioProducto;
        private System.Windows.Forms.Label Lbl_estadoProducto;
        private System.Windows.Forms.TextBox Txt_estadoProducto;
        private System.Windows.Forms.Button Btn_iconoProducto;
        private System.Windows.Forms.Label Lbl_productos;
        private System.Windows.Forms.Label Lbl_idProducto;
        private System.Windows.Forms.TextBox Txt_idProducto;
        private CapaDiseno.Navegador navegador1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
    }
}