namespace SAE_2019.Mantenimiento
{
    partial class Frm_bodegas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_bodegas));
            this.Txt_IdBodega = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_estadoBodega = new System.Windows.Forms.TextBox();
            this.Txt_ubicacionBodega = new System.Windows.Forms.TextBox();
            this.Lbl_nombreClt = new System.Windows.Forms.Label();
            this.Txt_nombreBodega = new System.Windows.Forms.TextBox();
            this.Lbl_nitClt = new System.Windows.Forms.Label();
            this.Lbl_dpiClt = new System.Windows.Forms.Label();
            this.navegador1 = new CapaDiseno.Navegador();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_iconoCliente = new System.Windows.Forms.Button();
            this.Lbl_admonClientes = new System.Windows.Forms.Label();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_IdBodega
            // 
            this.Txt_IdBodega.Location = new System.Drawing.Point(456, 249);
            this.Txt_IdBodega.Multiline = true;
            this.Txt_IdBodega.Name = "Txt_IdBodega";
            this.Txt_IdBodega.Size = new System.Drawing.Size(195, 31);
            this.Txt_IdBodega.TabIndex = 32;
            this.Txt_IdBodega.Tag = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(270, 264);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 31;
            this.label2.Text = "Id de Bodega";
            // 
            // Txt_estadoBodega
            // 
            this.Txt_estadoBodega.Location = new System.Drawing.Point(456, 413);
            this.Txt_estadoBodega.Multiline = true;
            this.Txt_estadoBodega.Name = "Txt_estadoBodega";
            this.Txt_estadoBodega.Size = new System.Drawing.Size(195, 31);
            this.Txt_estadoBodega.TabIndex = 30;
            this.Txt_estadoBodega.Tag = "4";
            // 
            // Txt_ubicacionBodega
            // 
            this.Txt_ubicacionBodega.Location = new System.Drawing.Point(456, 357);
            this.Txt_ubicacionBodega.Multiline = true;
            this.Txt_ubicacionBodega.Name = "Txt_ubicacionBodega";
            this.Txt_ubicacionBodega.Size = new System.Drawing.Size(195, 31);
            this.Txt_ubicacionBodega.TabIndex = 29;
            this.Txt_ubicacionBodega.Tag = "3";
            // 
            // Lbl_nombreClt
            // 
            this.Lbl_nombreClt.AutoSize = true;
            this.Lbl_nombreClt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombreClt.Location = new System.Drawing.Point(231, 319);
            this.Lbl_nombreClt.Name = "Lbl_nombreClt";
            this.Lbl_nombreClt.Size = new System.Drawing.Size(136, 16);
            this.Lbl_nombreClt.TabIndex = 25;
            this.Lbl_nombreClt.Text = "Nombre de Bodega";
            // 
            // Txt_nombreBodega
            // 
            this.Txt_nombreBodega.Location = new System.Drawing.Point(456, 304);
            this.Txt_nombreBodega.Multiline = true;
            this.Txt_nombreBodega.Name = "Txt_nombreBodega";
            this.Txt_nombreBodega.Size = new System.Drawing.Size(195, 31);
            this.Txt_nombreBodega.TabIndex = 28;
            this.Txt_nombreBodega.Tag = "2";
            // 
            // Lbl_nitClt
            // 
            this.Lbl_nitClt.AutoSize = true;
            this.Lbl_nitClt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nitClt.Location = new System.Drawing.Point(217, 372);
            this.Lbl_nitClt.Name = "Lbl_nitClt";
            this.Lbl_nitClt.Size = new System.Drawing.Size(150, 16);
            this.Lbl_nitClt.TabIndex = 26;
            this.Lbl_nitClt.Text = "Ubicación de Bodega";
            // 
            // Lbl_dpiClt
            // 
            this.Lbl_dpiClt.AutoSize = true;
            this.Lbl_dpiClt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_dpiClt.Location = new System.Drawing.Point(238, 428);
            this.Lbl_dpiClt.Name = "Lbl_dpiClt";
            this.Lbl_dpiClt.Size = new System.Drawing.Size(127, 16);
            this.Lbl_dpiClt.TabIndex = 27;
            this.Lbl_dpiClt.Text = "Estado de Bodega";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Location = new System.Drawing.Point(35, 139);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = null;
            this.navegador1.pubNombreHtml = null;
            this.navegador1.Size = new System.Drawing.Size(857, 60);
            this.navegador1.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.OrangeRed;
            this.panel1.Controls.Add(this.Btn_iconoCliente);
            this.panel1.Controls.Add(this.Lbl_admonClientes);
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Controls.Add(this.Btn_minimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 48);
            this.panel1.TabIndex = 34;
            // 
            // Btn_iconoCliente
            // 
            this.Btn_iconoCliente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_iconoCliente.BackgroundImage")));
            this.Btn_iconoCliente.Enabled = false;
            this.Btn_iconoCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(74)))));
            this.Btn_iconoCliente.FlatAppearance.BorderSize = 0;
            this.Btn_iconoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_iconoCliente.Location = new System.Drawing.Point(15, 4);
            this.Btn_iconoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_iconoCliente.Name = "Btn_iconoCliente";
            this.Btn_iconoCliente.Size = new System.Drawing.Size(36, 39);
            this.Btn_iconoCliente.TabIndex = 10;
            this.Btn_iconoCliente.UseVisualStyleBackColor = true;
            // 
            // Lbl_admonClientes
            // 
            this.Lbl_admonClientes.AutoSize = true;
            this.Lbl_admonClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_admonClientes.Location = new System.Drawing.Point(74, 16);
            this.Lbl_admonClientes.Name = "Lbl_admonClientes";
            this.Lbl_admonClientes.Size = new System.Drawing.Size(287, 19);
            this.Lbl_admonClientes.TabIndex = 1;
            this.Lbl_admonClientes.Text = "1500-ADMINISTRACIÓN DE BODEGAS";
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.BackgroundImage")));
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Location = new System.Drawing.Point(836, 0);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(48, 48);
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
            this.Btn_minimizar.Location = new System.Drawing.Point(767, 0);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(48, 48);
            this.Btn_minimizar.TabIndex = 2;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // Frm_bodegas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 653);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.Txt_IdBodega);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Txt_estadoBodega);
            this.Controls.Add(this.Txt_ubicacionBodega);
            this.Controls.Add(this.Lbl_nombreClt);
            this.Controls.Add(this.Txt_nombreBodega);
            this.Controls.Add(this.Lbl_nitClt);
            this.Controls.Add(this.Lbl_dpiClt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_bodegas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_bodegas";
            this.Load += new System.EventHandler(this.Frm_bodegas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_IdBodega;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_estadoBodega;
        private System.Windows.Forms.TextBox Txt_ubicacionBodega;
        private System.Windows.Forms.Label Lbl_nombreClt;
        private System.Windows.Forms.TextBox Txt_nombreBodega;
        private System.Windows.Forms.Label Lbl_nitClt;
        private System.Windows.Forms.Label Lbl_dpiClt;
        private CapaDiseno.Navegador navegador1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_iconoCliente;
        private System.Windows.Forms.Label Lbl_admonClientes;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_minimizar;
    }
}