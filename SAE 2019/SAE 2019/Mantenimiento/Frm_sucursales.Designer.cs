namespace SAE_2019.Mantenimiento
{
    partial class Frm_sucursales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_sucursales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_iconoCliente = new System.Windows.Forms.Button();
            this.Lbl_admonClientes = new System.Windows.Forms.Label();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Txt_IdSucursal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_ubicacionSucursal = new System.Windows.Forms.TextBox();
            this.Lbl_nombreClt = new System.Windows.Forms.Label();
            this.Txt_nombreSucursal = new System.Windows.Forms.TextBox();
            this.Lbl_nitClt = new System.Windows.Forms.Label();
            this.navegador1 = new CapaDiseno.Navegador();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 2;
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
            this.Lbl_admonClientes.Size = new System.Drawing.Size(389, 23);
            this.Lbl_admonClientes.TabIndex = 1;
            this.Lbl_admonClientes.Text = "1600-ADMINISTRACIÓN DE SUCURSALES";
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
            // 
            // Txt_IdSucursal
            // 
            this.Txt_IdSucursal.Location = new System.Drawing.Point(605, 272);
            this.Txt_IdSucursal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_IdSucursal.Multiline = true;
            this.Txt_IdSucursal.Name = "Txt_IdSucursal";
            this.Txt_IdSucursal.Size = new System.Drawing.Size(259, 37);
            this.Txt_IdSucursal.TabIndex = 30;
            this.Txt_IdSucursal.Tag = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(388, 290);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 19);
            this.label2.TabIndex = 29;
            this.label2.Text = "Id Sucursal";
            // 
            // Txt_ubicacionSucursal
            // 
            this.Txt_ubicacionSucursal.Location = new System.Drawing.Point(605, 426);
            this.Txt_ubicacionSucursal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_ubicacionSucursal.Multiline = true;
            this.Txt_ubicacionSucursal.Name = "Txt_ubicacionSucursal";
            this.Txt_ubicacionSucursal.Size = new System.Drawing.Size(259, 37);
            this.Txt_ubicacionSucursal.TabIndex = 28;
            this.Txt_ubicacionSucursal.Tag = "3";
            // 
            // Lbl_nombreClt
            // 
            this.Lbl_nombreClt.AutoSize = true;
            this.Lbl_nombreClt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombreClt.Location = new System.Drawing.Point(312, 367);
            this.Lbl_nombreClt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_nombreClt.Name = "Lbl_nombreClt";
            this.Lbl_nombreClt.Size = new System.Drawing.Size(180, 19);
            this.Lbl_nombreClt.TabIndex = 25;
            this.Lbl_nombreClt.Text = "Nombre del Sucursal";
            // 
            // Txt_nombreSucursal
            // 
            this.Txt_nombreSucursal.Location = new System.Drawing.Point(605, 348);
            this.Txt_nombreSucursal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_nombreSucursal.Multiline = true;
            this.Txt_nombreSucursal.Name = "Txt_nombreSucursal";
            this.Txt_nombreSucursal.Size = new System.Drawing.Size(259, 37);
            this.Txt_nombreSucursal.TabIndex = 27;
            this.Txt_nombreSucursal.Tag = "2";
            // 
            // Lbl_nitClt
            // 
            this.Lbl_nitClt.AutoSize = true;
            this.Lbl_nitClt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nitClt.Location = new System.Drawing.Point(299, 444);
            this.Lbl_nitClt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_nitClt.Name = "Lbl_nitClt";
            this.Lbl_nitClt.Size = new System.Drawing.Size(192, 19);
            this.Lbl_nitClt.TabIndex = 26;
            this.Lbl_nitClt.Text = "Ubicación de Sucursal";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Location = new System.Drawing.Point(36, 108);
            this.navegador1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = "SUCURSALESS.chm";
            this.navegador1.pubNombreHtml = "SUCURSALES.html";
            this.navegador1.Size = new System.Drawing.Size(1143, 74);
            this.navegador1.TabIndex = 31;
            // 
            // Frm_sucursales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 804);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.Txt_IdSucursal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_ubicacionSucursal);
            this.Controls.Add(this.Lbl_nombreClt);
            this.Controls.Add(this.Txt_nombreSucursal);
            this.Controls.Add(this.Lbl_nitClt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_sucursales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_surcursales";
            this.Load += new System.EventHandler(this.Frm_surcursales_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_iconoCliente;
        private System.Windows.Forms.Label Lbl_admonClientes;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.TextBox Txt_IdSucursal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_ubicacionSucursal;
        private System.Windows.Forms.Label Lbl_nombreClt;
        private System.Windows.Forms.TextBox Txt_nombreSucursal;
        private System.Windows.Forms.Label Lbl_nitClt;
        private CapaDiseno.Navegador navegador1;
    }
}