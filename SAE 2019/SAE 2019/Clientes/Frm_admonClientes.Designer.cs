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
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Lbl_admonClientes = new System.Windows.Forms.Label();
            this.Gpb_clientes = new System.Windows.Forms.GroupBox();
            this.Lbl_nombreClt = new System.Windows.Forms.Label();
            this.Lbl_nitClt = new System.Windows.Forms.Label();
            this.Lbl_dpiClt = new System.Windows.Forms.Label();
            this.Lbl_estClt = new System.Windows.Forms.Label();
            this.Txt_nombreCliente = new System.Windows.Forms.TextBox();
            this.Txt_nitCliente = new System.Windows.Forms.TextBox();
            this.Txt_dpiCliente = new System.Windows.Forms.TextBox();
            this.Txt_estadoCliente = new System.Windows.Forms.TextBox();
            this.Btn_mostrarProductos = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.Gpb_clientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.Lbl_admonClientes);
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Controls.Add(this.Btn_minimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 48);
            this.panel1.TabIndex = 0;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.BackgroundImage")));
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
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Location = new System.Drawing.Point(767, 0);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(48, 48);
            this.Btn_minimizar.TabIndex = 2;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // Lbl_admonClientes
            // 
            this.Lbl_admonClientes.AutoSize = true;
            this.Lbl_admonClientes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_admonClientes.Location = new System.Drawing.Point(74, 16);
            this.Lbl_admonClientes.Name = "Lbl_admonClientes";
            this.Lbl_admonClientes.Size = new System.Drawing.Size(236, 19);
            this.Lbl_admonClientes.TabIndex = 1;
            this.Lbl_admonClientes.Text = "ADMINISTRACIÓN DE CLIENTES";
            // 
            // Gpb_clientes
            // 
            this.Gpb_clientes.Controls.Add(this.Btn_mostrarProductos);
            this.Gpb_clientes.Controls.Add(this.Txt_estadoCliente);
            this.Gpb_clientes.Controls.Add(this.Txt_dpiCliente);
            this.Gpb_clientes.Controls.Add(this.Txt_nitCliente);
            this.Gpb_clientes.Controls.Add(this.Txt_nombreCliente);
            this.Gpb_clientes.Controls.Add(this.Lbl_estClt);
            this.Gpb_clientes.Controls.Add(this.Lbl_dpiClt);
            this.Gpb_clientes.Controls.Add(this.Lbl_nitClt);
            this.Gpb_clientes.Controls.Add(this.Lbl_nombreClt);
            this.Gpb_clientes.Location = new System.Drawing.Point(48, 185);
            this.Gpb_clientes.Name = "Gpb_clientes";
            this.Gpb_clientes.Size = new System.Drawing.Size(828, 368);
            this.Gpb_clientes.TabIndex = 1;
            this.Gpb_clientes.TabStop = false;
            // 
            // Lbl_nombreClt
            // 
            this.Lbl_nombreClt.AutoSize = true;
            this.Lbl_nombreClt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombreClt.Location = new System.Drawing.Point(85, 48);
            this.Lbl_nombreClt.Name = "Lbl_nombreClt";
            this.Lbl_nombreClt.Size = new System.Drawing.Size(139, 16);
            this.Lbl_nombreClt.TabIndex = 0;
            this.Lbl_nombreClt.Text = "Nombre del Cliente:";
            // 
            // Lbl_nitClt
            // 
            this.Lbl_nitClt.AutoSize = true;
            this.Lbl_nitClt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nitClt.Location = new System.Drawing.Point(85, 108);
            this.Lbl_nitClt.Name = "Lbl_nitClt";
            this.Lbl_nitClt.Size = new System.Drawing.Size(105, 16);
            this.Lbl_nitClt.TabIndex = 1;
            this.Lbl_nitClt.Text = "NIT del cliente:";
            // 
            // Lbl_dpiClt
            // 
            this.Lbl_dpiClt.AutoSize = true;
            this.Lbl_dpiClt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_dpiClt.Location = new System.Drawing.Point(85, 168);
            this.Lbl_dpiClt.Name = "Lbl_dpiClt";
            this.Lbl_dpiClt.Size = new System.Drawing.Size(105, 16);
            this.Lbl_dpiClt.TabIndex = 2;
            this.Lbl_dpiClt.Text = "DPI del cliente:";
            // 
            // Lbl_estClt
            // 
            this.Lbl_estClt.AutoSize = true;
            this.Lbl_estClt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estClt.Location = new System.Drawing.Point(88, 222);
            this.Lbl_estClt.Name = "Lbl_estClt";
            this.Lbl_estClt.Size = new System.Drawing.Size(130, 16);
            this.Lbl_estClt.TabIndex = 3;
            this.Lbl_estClt.Text = "Estado del Cliente:";
            // 
            // Txt_nombreCliente
            // 
            this.Txt_nombreCliente.Location = new System.Drawing.Point(335, 38);
            this.Txt_nombreCliente.Multiline = true;
            this.Txt_nombreCliente.Name = "Txt_nombreCliente";
            this.Txt_nombreCliente.Size = new System.Drawing.Size(195, 31);
            this.Txt_nombreCliente.TabIndex = 4;
            // 
            // Txt_nitCliente
            // 
            this.Txt_nitCliente.Location = new System.Drawing.Point(335, 98);
            this.Txt_nitCliente.Multiline = true;
            this.Txt_nitCliente.Name = "Txt_nitCliente";
            this.Txt_nitCliente.Size = new System.Drawing.Size(195, 31);
            this.Txt_nitCliente.TabIndex = 5;
            // 
            // Txt_dpiCliente
            // 
            this.Txt_dpiCliente.Location = new System.Drawing.Point(335, 158);
            this.Txt_dpiCliente.Multiline = true;
            this.Txt_dpiCliente.Name = "Txt_dpiCliente";
            this.Txt_dpiCliente.Size = new System.Drawing.Size(195, 31);
            this.Txt_dpiCliente.TabIndex = 6;
            // 
            // Txt_estadoCliente
            // 
            this.Txt_estadoCliente.Location = new System.Drawing.Point(335, 218);
            this.Txt_estadoCliente.Multiline = true;
            this.Txt_estadoCliente.Name = "Txt_estadoCliente";
            this.Txt_estadoCliente.Size = new System.Drawing.Size(195, 31);
            this.Txt_estadoCliente.TabIndex = 7;
            // 
            // Btn_mostrarProductos
            // 
            this.Btn_mostrarProductos.FlatAppearance.BorderSize = 0;
            this.Btn_mostrarProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_mostrarProductos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_mostrarProductos.Image = ((System.Drawing.Image)(resources.GetObject("Btn_mostrarProductos.Image")));
            this.Btn_mostrarProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_mostrarProductos.Location = new System.Drawing.Point(531, 299);
            this.Btn_mostrarProductos.Name = "Btn_mostrarProductos";
            this.Btn_mostrarProductos.Size = new System.Drawing.Size(277, 48);
            this.Btn_mostrarProductos.TabIndex = 10;
            this.Btn_mostrarProductos.Text = "     Mostrar Clientes";
            this.Btn_mostrarProductos.UseVisualStyleBackColor = true;
            // 
            // Frm_admonClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 653);
            this.Controls.Add(this.Gpb_clientes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_admonClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_admonClientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.Gpb_clientes.ResumeLayout(false);
            this.Gpb_clientes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Label Lbl_admonClientes;
        private System.Windows.Forms.GroupBox Gpb_clientes;
        private System.Windows.Forms.Label Lbl_nombreClt;
        private System.Windows.Forms.Label Lbl_nitClt;
        private System.Windows.Forms.Label Lbl_dpiClt;
        private System.Windows.Forms.Label Lbl_estClt;
        private System.Windows.Forms.TextBox Txt_nombreCliente;
        private System.Windows.Forms.TextBox Txt_nitCliente;
        private System.Windows.Forms.TextBox Txt_dpiCliente;
        private System.Windows.Forms.TextBox Txt_estadoCliente;
        private System.Windows.Forms.Button Btn_mostrarProductos;
    }
}