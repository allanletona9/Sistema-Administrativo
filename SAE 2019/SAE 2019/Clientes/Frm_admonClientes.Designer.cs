﻿namespace SAE_2019.Clientes
{
    partial class Frm_admonClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_admonClientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_iconoCliente = new System.Windows.Forms.Button();
            this.Lbl_admonClientes = new System.Windows.Forms.Label();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Txt_estadoCliente = new System.Windows.Forms.TextBox();
            this.Txt_dpiCliente = new System.Windows.Forms.TextBox();
            this.Txt_nitCliente = new System.Windows.Forms.TextBox();
            this.Txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.Lbl_estClt = new System.Windows.Forms.Label();
            this.Lbl_dpiClt = new System.Windows.Forms.Label();
            this.Lbl_nitClt = new System.Windows.Forms.Label();
            this.Lbl_nombreClt = new System.Windows.Forms.Label();
            this.navegador1 = new CapaDiseno.Navegador();
            this.Txt_idCliente = new System.Windows.Forms.TextBox();
            this.Lbl_idCliente = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.Btn_iconoCliente);
            this.panel1.Controls.Add(this.Lbl_admonClientes);
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Controls.Add(this.Btn_minimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 48);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
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
            this.Lbl_admonClientes.Size = new System.Drawing.Size(279, 19);
            this.Lbl_admonClientes.TabIndex = 1;
            this.Lbl_admonClientes.Text = "1300-ADMINISTRACIÓN DE CLIENTES";
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
            // Txt_estadoCliente
            // 
            this.Txt_estadoCliente.Location = new System.Drawing.Point(446, 476);
            this.Txt_estadoCliente.Multiline = true;
            this.Txt_estadoCliente.Name = "Txt_estadoCliente";
            this.Txt_estadoCliente.Size = new System.Drawing.Size(195, 31);
            this.Txt_estadoCliente.TabIndex = 7;
            this.Txt_estadoCliente.Tag = "5";
            // 
            // Txt_dpiCliente
            // 
            this.Txt_dpiCliente.Location = new System.Drawing.Point(446, 416);
            this.Txt_dpiCliente.Multiline = true;
            this.Txt_dpiCliente.Name = "Txt_dpiCliente";
            this.Txt_dpiCliente.Size = new System.Drawing.Size(195, 31);
            this.Txt_dpiCliente.TabIndex = 6;
            this.Txt_dpiCliente.Tag = "4";
            // 
            // Txt_nitCliente
            // 
            this.Txt_nitCliente.Location = new System.Drawing.Point(446, 356);
            this.Txt_nitCliente.Multiline = true;
            this.Txt_nitCliente.Name = "Txt_nitCliente";
            this.Txt_nitCliente.Size = new System.Drawing.Size(195, 31);
            this.Txt_nitCliente.TabIndex = 5;
            this.Txt_nitCliente.Tag = "3";
            // 
            // Txt_nombreCliente
            // 
            this.Txt_nombreCliente.Location = new System.Drawing.Point(446, 296);
            this.Txt_nombreCliente.Multiline = true;
            this.Txt_nombreCliente.Name = "Txt_nombreCliente";
            this.Txt_nombreCliente.Size = new System.Drawing.Size(195, 31);
            this.Txt_nombreCliente.TabIndex = 4;
            this.Txt_nombreCliente.Tag = "2";
            // 
            // Lbl_estClt
            // 
            this.Lbl_estClt.AutoSize = true;
            this.Lbl_estClt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estClt.Location = new System.Drawing.Point(199, 480);
            this.Lbl_estClt.Name = "Lbl_estClt";
            this.Lbl_estClt.Size = new System.Drawing.Size(130, 16);
            this.Lbl_estClt.TabIndex = 3;
            this.Lbl_estClt.Text = "Estado del Cliente:";
            // 
            // Lbl_dpiClt
            // 
            this.Lbl_dpiClt.AutoSize = true;
            this.Lbl_dpiClt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_dpiClt.Location = new System.Drawing.Point(196, 426);
            this.Lbl_dpiClt.Name = "Lbl_dpiClt";
            this.Lbl_dpiClt.Size = new System.Drawing.Size(105, 16);
            this.Lbl_dpiClt.TabIndex = 2;
            this.Lbl_dpiClt.Text = "DPI del cliente:";
            // 
            // Lbl_nitClt
            // 
            this.Lbl_nitClt.AutoSize = true;
            this.Lbl_nitClt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nitClt.Location = new System.Drawing.Point(196, 366);
            this.Lbl_nitClt.Name = "Lbl_nitClt";
            this.Lbl_nitClt.Size = new System.Drawing.Size(105, 16);
            this.Lbl_nitClt.TabIndex = 1;
            this.Lbl_nitClt.Text = "NIT del cliente:";
            // 
            // Lbl_nombreClt
            // 
            this.Lbl_nombreClt.AutoSize = true;
            this.Lbl_nombreClt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombreClt.Location = new System.Drawing.Point(196, 306);
            this.Lbl_nombreClt.Name = "Lbl_nombreClt";
            this.Lbl_nombreClt.Size = new System.Drawing.Size(139, 16);
            this.Lbl_nombreClt.TabIndex = 0;
            this.Lbl_nombreClt.Text = "Nombre del Cliente:";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Location = new System.Drawing.Point(27, 76);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = "CLIENTESS.chm";
            this.navegador1.pubNombreHtml = "CLIENTES.html";
            this.navegador1.Size = new System.Drawing.Size(857, 60);
            this.navegador1.TabIndex = 2;
            // 
            // Txt_idCliente
            // 
            this.Txt_idCliente.Location = new System.Drawing.Point(446, 234);
            this.Txt_idCliente.Multiline = true;
            this.Txt_idCliente.Name = "Txt_idCliente";
            this.Txt_idCliente.Size = new System.Drawing.Size(195, 31);
            this.Txt_idCliente.TabIndex = 9;
            this.Txt_idCliente.Tag = "1";
            // 
            // Lbl_idCliente
            // 
            this.Lbl_idCliente.AutoSize = true;
            this.Lbl_idCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_idCliente.Location = new System.Drawing.Point(196, 244);
            this.Lbl_idCliente.Name = "Lbl_idCliente";
            this.Lbl_idCliente.Size = new System.Drawing.Size(75, 16);
            this.Lbl_idCliente.TabIndex = 8;
            this.Lbl_idCliente.Text = "ID Cliente:";
            // 
            // Frm_admonClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 653);
            this.Controls.Add(this.Txt_idCliente);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.Lbl_idCliente);
            this.Controls.Add(this.Txt_estadoCliente);
            this.Controls.Add(this.Txt_dpiCliente);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Txt_nitCliente);
            this.Controls.Add(this.Lbl_nombreClt);
            this.Controls.Add(this.Txt_nombreCliente);
            this.Controls.Add(this.Lbl_nitClt);
            this.Controls.Add(this.Lbl_estClt);
            this.Controls.Add(this.Lbl_dpiClt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_admonClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_admonClientes";
            this.Load += new System.EventHandler(this.Frm_admonClientes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Label Lbl_admonClientes;
        private System.Windows.Forms.Label Lbl_nombreClt;
        private System.Windows.Forms.Label Lbl_nitClt;
        private System.Windows.Forms.Label Lbl_dpiClt;
        private System.Windows.Forms.Label Lbl_estClt;
        private System.Windows.Forms.TextBox Txt_nombreCliente;
        private System.Windows.Forms.TextBox Txt_nitCliente;
        private System.Windows.Forms.TextBox Txt_dpiCliente;
        private System.Windows.Forms.TextBox Txt_estadoCliente;
        private CapaDiseno.Navegador navegador1;
        private System.Windows.Forms.TextBox Txt_idCliente;
        private System.Windows.Forms.Label Lbl_idCliente;
        private System.Windows.Forms.Button Btn_iconoCliente;
    }
}