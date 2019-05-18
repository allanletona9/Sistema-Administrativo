namespace SAE_2019.Bodegas
{
    partial class frm_gestion_bodega
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_gestion_bodega));
            this.Lbl_Existencias = new System.Windows.Forms.Label();
            this.Lbl_idProducto = new System.Windows.Forms.Label();
            this.Lbl_nombreProducto = new System.Windows.Forms.Label();
            this.Lbl_descProducto = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_iconoCliente = new System.Windows.Forms.Button();
            this.Lbl_admonClientes = new System.Windows.Forms.Label();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Txt_existencias = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_Existencias
            // 
            this.Lbl_Existencias.AutoSize = true;
            this.Lbl_Existencias.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Existencias.Location = new System.Drawing.Point(281, 458);
            this.Lbl_Existencias.Name = "Lbl_Existencias";
            this.Lbl_Existencias.Size = new System.Drawing.Size(176, 19);
            this.Lbl_Existencias.TabIndex = 24;
            this.Lbl_Existencias.Text = "Existencias a enviar:";
            // 
            // Lbl_idProducto
            // 
            this.Lbl_idProducto.AutoSize = true;
            this.Lbl_idProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_idProducto.Location = new System.Drawing.Point(37, 44);
            this.Lbl_idProducto.Name = "Lbl_idProducto";
            this.Lbl_idProducto.Size = new System.Drawing.Size(98, 19);
            this.Lbl_idProducto.TabIndex = 22;
            this.Lbl_idProducto.Text = "Empleado:";
            // 
            // Lbl_nombreProducto
            // 
            this.Lbl_nombreProducto.AutoSize = true;
            this.Lbl_nombreProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombreProducto.Location = new System.Drawing.Point(432, 49);
            this.Lbl_nombreProducto.Name = "Lbl_nombreProducto";
            this.Lbl_nombreProducto.Size = new System.Drawing.Size(79, 19);
            this.Lbl_nombreProducto.TabIndex = 14;
            this.Lbl_nombreProducto.Text = "Bodega:";
            // 
            // Lbl_descProducto
            // 
            this.Lbl_descProducto.AutoSize = true;
            this.Lbl_descProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descProducto.Location = new System.Drawing.Point(281, 405);
            this.Lbl_descProducto.Name = "Lbl_descProducto";
            this.Lbl_descProducto.Size = new System.Drawing.Size(87, 19);
            this.Lbl_descProducto.TabIndex = 16;
            this.Lbl_descProducto.Text = "Producto:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(173, 44);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(235, 24);
            this.comboBox1.TabIndex = 26;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(541, 44);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(235, 24);
            this.comboBox2.TabIndex = 27;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.Lbl_nombreProducto);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.Lbl_idProducto);
            this.groupBox1.Location = new System.Drawing.Point(137, 148);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(993, 100);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(797, 28);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 54);
            this.button1.TabIndex = 57;
            this.button1.Text = "Comprobar Autorización";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // comboBox3
            // 
            this.comboBox3.Enabled = false;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(616, 400);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(344, 24);
            this.comboBox3.TabIndex = 28;
            // 
            // comboBox4
            // 
            this.comboBox4.Enabled = false;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(616, 352);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(344, 24);
            this.comboBox4.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(281, 352);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 19);
            this.label1.TabIndex = 29;
            this.label1.Text = "Sucursal:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(111)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.Btn_iconoCliente);
            this.panel1.Controls.Add(this.Lbl_admonClientes);
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Controls.Add(this.Btn_minimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 59);
            this.panel1.TabIndex = 35;
            // 
            // Btn_iconoCliente
            // 
            this.Btn_iconoCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_iconoCliente.BackgroundImage")));
            this.Btn_iconoCliente.Enabled = false;
            this.Btn_iconoCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(74)))));
            this.Btn_iconoCliente.FlatAppearance.BorderSize = 0;
            this.Btn_iconoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_iconoCliente.Location = new System.Drawing.Point(20, 5);
            this.Btn_iconoCliente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_iconoCliente.Name = "Btn_iconoCliente";
            this.Btn_iconoCliente.Size = new System.Drawing.Size(48, 48);
            this.Btn_iconoCliente.TabIndex = 10;
            this.Btn_iconoCliente.UseVisualStyleBackColor = true;
            // 
            // Lbl_admonClientes
            // 
            this.Lbl_admonClientes.AutoSize = true;
            this.Lbl_admonClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_admonClientes.Location = new System.Drawing.Point(99, 20);
            this.Lbl_admonClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_admonClientes.Name = "Lbl_admonClientes";
            this.Lbl_admonClientes.Size = new System.Drawing.Size(276, 23);
            this.Lbl_admonClientes.TabIndex = 1;
            this.Lbl_admonClientes.Text = "1700-GESTIÓN DE BODEGAS";
            this.Lbl_admonClientes.Click += new System.EventHandler(this.Lbl_admonClientes_Click);
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.BackgroundImage")));
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Location = new System.Drawing.Point(1115, 0);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(64, 59);
            this.Btn_cerrar.TabIndex = 1;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.BackgroundImage")));
            this.Btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Location = new System.Drawing.Point(1023, 0);
            this.Btn_minimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(64, 59);
            this.Btn_minimizar.TabIndex = 2;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Image = global::SAE_2019.Properties.Resources.boton_web_de_ayuda2;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.Location = new System.Drawing.Point(1035, 65);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(171, 41);
            this.button3.TabIndex = 54;
            this.button3.Text = "Ayuda";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Txt_existencias
            // 
            this.Txt_existencias.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_existencias.Location = new System.Drawing.Point(616, 437);
            this.Txt_existencias.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_existencias.Multiline = true;
            this.Txt_existencias.Name = "Txt_existencias";
            this.Txt_existencias.Size = new System.Drawing.Size(344, 45);
            this.Txt_existencias.TabIndex = 55;
            this.Txt_existencias.Tag = "1";
            this.Txt_existencias.TextChanged += new System.EventHandler(this.Txt_idProducto_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(653, 514);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(224, 54);
            this.button2.TabIndex = 56;
            this.button2.TabStop = false;
            this.button2.Text = "Enviar Productos       ";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Btn_ingresarProducto_Click);
            // 
            // frm_gestion_bodega
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 804);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Txt_existencias);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Lbl_Existencias);
            this.Controls.Add(this.Lbl_descProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frm_gestion_bodega";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_gestion_bodega";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Lbl_Existencias;
        private System.Windows.Forms.Label Lbl_idProducto;
        private System.Windows.Forms.Label Lbl_nombreProducto;
        private System.Windows.Forms.Label Lbl_descProducto;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_iconoCliente;
        private System.Windows.Forms.Label Lbl_admonClientes;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Txt_existencias;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}