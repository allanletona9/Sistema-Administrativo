namespace SAE_2019.Mantenimiento
{
    partial class Frm_empleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_empleados));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_iconoCliente = new System.Windows.Forms.Button();
            this.Lbl_admonClientes = new System.Windows.Forms.Label();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Txt_direccionEmpleado = new System.Windows.Forms.TextBox();
            this.Lbl_idCliente = new System.Windows.Forms.Label();
            this.Txt_estadoEmpleado = new System.Windows.Forms.TextBox();
            this.Txt_dpiEmpleado = new System.Windows.Forms.TextBox();
            this.Txt_nitEmpleado = new System.Windows.Forms.TextBox();
            this.Lbl_nombreClt = new System.Windows.Forms.Label();
            this.Txt_nombreEmpleado = new System.Windows.Forms.TextBox();
            this.Lbl_nitClt = new System.Windows.Forms.Label();
            this.Lbl_estClt = new System.Windows.Forms.Label();
            this.Lbl_dpiClt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_idSucursal = new System.Windows.Forms.TextBox();
            this.navegador1 = new CapaDiseno.Navegador();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_IdEmpleado = new System.Windows.Forms.TextBox();
            this.cbo_idSucursal = new System.Windows.Forms.ComboBox();
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
            this.panel1.TabIndex = 1;
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
            this.Lbl_admonClientes.Size = new System.Drawing.Size(385, 23);
            this.Lbl_admonClientes.TabIndex = 1;
            this.Lbl_admonClientes.Text = "1400-ADMINISTRACIÓN DE EMPLEADOS";
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
            // Txt_direccionEmpleado
            // 
            this.Txt_direccionEmpleado.Location = new System.Drawing.Point(633, 480);
            this.Txt_direccionEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_direccionEmpleado.Multiline = true;
            this.Txt_direccionEmpleado.Name = "Txt_direccionEmpleado";
            this.Txt_direccionEmpleado.Size = new System.Drawing.Size(259, 37);
            this.Txt_direccionEmpleado.TabIndex = 19;
            this.Txt_direccionEmpleado.Tag = "5";
            // 
            // Lbl_idCliente
            // 
            this.Lbl_idCliente.AutoSize = true;
            this.Lbl_idCliente.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_idCliente.Location = new System.Drawing.Point(285, 498);
            this.Lbl_idCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_idCliente.Name = "Lbl_idCliente";
            this.Lbl_idCliente.Size = new System.Drawing.Size(210, 19);
            this.Lbl_idCliente.TabIndex = 18;
            this.Lbl_idCliente.Text = "Dirección del empleado";
            // 
            // Txt_estadoEmpleado
            // 
            this.Txt_estadoEmpleado.Location = new System.Drawing.Point(633, 603);
            this.Txt_estadoEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_estadoEmpleado.Multiline = true;
            this.Txt_estadoEmpleado.Name = "Txt_estadoEmpleado";
            this.Txt_estadoEmpleado.Size = new System.Drawing.Size(259, 37);
            this.Txt_estadoEmpleado.TabIndex = 17;
            this.Txt_estadoEmpleado.Tag = "7";
            // 
            // Txt_dpiEmpleado
            // 
            this.Txt_dpiEmpleado.Location = new System.Drawing.Point(633, 417);
            this.Txt_dpiEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_dpiEmpleado.Multiline = true;
            this.Txt_dpiEmpleado.Name = "Txt_dpiEmpleado";
            this.Txt_dpiEmpleado.Size = new System.Drawing.Size(259, 37);
            this.Txt_dpiEmpleado.TabIndex = 16;
            this.Txt_dpiEmpleado.Tag = "4";
            // 
            // Txt_nitEmpleado
            // 
            this.Txt_nitEmpleado.Location = new System.Drawing.Point(633, 352);
            this.Txt_nitEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_nitEmpleado.Multiline = true;
            this.Txt_nitEmpleado.Name = "Txt_nitEmpleado";
            this.Txt_nitEmpleado.Size = new System.Drawing.Size(259, 37);
            this.Txt_nitEmpleado.TabIndex = 15;
            this.Txt_nitEmpleado.Tag = "3";
            // 
            // Lbl_nombreClt
            // 
            this.Lbl_nombreClt.AutoSize = true;
            this.Lbl_nombreClt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombreClt.Location = new System.Drawing.Point(300, 305);
            this.Lbl_nombreClt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_nombreClt.Name = "Lbl_nombreClt";
            this.Lbl_nombreClt.Size = new System.Drawing.Size(196, 19);
            this.Lbl_nombreClt.TabIndex = 10;
            this.Lbl_nombreClt.Text = "Nombre del Empleado";
            // 
            // Txt_nombreEmpleado
            // 
            this.Txt_nombreEmpleado.Location = new System.Drawing.Point(633, 287);
            this.Txt_nombreEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_nombreEmpleado.Multiline = true;
            this.Txt_nombreEmpleado.Name = "Txt_nombreEmpleado";
            this.Txt_nombreEmpleado.Size = new System.Drawing.Size(259, 37);
            this.Txt_nombreEmpleado.TabIndex = 14;
            this.Txt_nombreEmpleado.Tag = "2";
            // 
            // Lbl_nitClt
            // 
            this.Lbl_nitClt.AutoSize = true;
            this.Lbl_nitClt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nitClt.Location = new System.Drawing.Point(343, 370);
            this.Lbl_nitClt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_nitClt.Name = "Lbl_nitClt";
            this.Lbl_nitClt.Size = new System.Drawing.Size(154, 19);
            this.Lbl_nitClt.TabIndex = 11;
            this.Lbl_nitClt.Text = "NIT del Empleado";
            // 
            // Lbl_estClt
            // 
            this.Lbl_estClt.AutoSize = true;
            this.Lbl_estClt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_estClt.Location = new System.Drawing.Point(312, 622);
            this.Lbl_estClt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_estClt.Name = "Lbl_estClt";
            this.Lbl_estClt.Size = new System.Drawing.Size(183, 19);
            this.Lbl_estClt.TabIndex = 13;
            this.Lbl_estClt.Text = "Estado del Empleado";
            // 
            // Lbl_dpiClt
            // 
            this.Lbl_dpiClt.AutoSize = true;
            this.Lbl_dpiClt.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_dpiClt.Location = new System.Drawing.Point(343, 436);
            this.Lbl_dpiClt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_dpiClt.Name = "Lbl_dpiClt";
            this.Lbl_dpiClt.Size = new System.Drawing.Size(156, 19);
            this.Lbl_dpiClt.TabIndex = 12;
            this.Lbl_dpiClt.Text = "DPI del Empleado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(372, 560);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 19);
            this.label1.TabIndex = 20;
            this.label1.Text = "Id de Sucursal";
            // 
            // Txt_idSucursal
            // 
            this.Txt_idSucursal.Location = new System.Drawing.Point(633, 554);
            this.Txt_idSucursal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_idSucursal.Multiline = true;
            this.Txt_idSucursal.Name = "Txt_idSucursal";
            this.Txt_idSucursal.Size = new System.Drawing.Size(259, 37);
            this.Txt_idSucursal.TabIndex = 21;
            this.Txt_idSucursal.Tag = "6";
            // 
            // navegador1
            // 
            this.navegador1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.navegador1.DataGr = null;
            this.navegador1.Location = new System.Drawing.Point(36, 111);
            this.navegador1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.navegador1.Name = "navegador1";
            this.navegador1.Procedimiento = null;
            this.navegador1.pubNombrechm = "EMPLEADOSS.chm";
            this.navegador1.pubNombreHtml = "EMPLEADOS.html";
            this.navegador1.Size = new System.Drawing.Size(1143, 74);
            this.navegador1.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 255);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Id Empleado";
            // 
            // Txt_IdEmpleado
            // 
            this.Txt_IdEmpleado.Location = new System.Drawing.Point(633, 236);
            this.Txt_IdEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Txt_IdEmpleado.Multiline = true;
            this.Txt_IdEmpleado.Name = "Txt_IdEmpleado";
            this.Txt_IdEmpleado.Size = new System.Drawing.Size(259, 37);
            this.Txt_IdEmpleado.TabIndex = 24;
            this.Txt_IdEmpleado.Tag = "1";
            // 
            // cbo_idSucursal
            // 
            this.cbo_idSucursal.Enabled = false;
            this.cbo_idSucursal.FormattingEnabled = true;
            this.cbo_idSucursal.Location = new System.Drawing.Point(960, 778);
            this.cbo_idSucursal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_idSucursal.Name = "cbo_idSucursal";
            this.cbo_idSucursal.Size = new System.Drawing.Size(259, 24);
            this.cbo_idSucursal.TabIndex = 25;
            // 
            // Frm_empleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 804);
            this.Controls.Add(this.cbo_idSucursal);
            this.Controls.Add(this.Txt_IdEmpleado);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.navegador1);
            this.Controls.Add(this.Txt_idSucursal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_direccionEmpleado);
            this.Controls.Add(this.Lbl_idCliente);
            this.Controls.Add(this.Txt_estadoEmpleado);
            this.Controls.Add(this.Txt_dpiEmpleado);
            this.Controls.Add(this.Txt_nitEmpleado);
            this.Controls.Add(this.Lbl_nombreClt);
            this.Controls.Add(this.Txt_nombreEmpleado);
            this.Controls.Add(this.Lbl_nitClt);
            this.Controls.Add(this.Lbl_estClt);
            this.Controls.Add(this.Lbl_dpiClt);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Frm_empleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_empleados";
            this.Load += new System.EventHandler(this.Frm_empleados_Load);
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
        private System.Windows.Forms.TextBox Txt_direccionEmpleado;
        private System.Windows.Forms.Label Lbl_idCliente;
        private System.Windows.Forms.TextBox Txt_estadoEmpleado;
        private System.Windows.Forms.TextBox Txt_dpiEmpleado;
        private System.Windows.Forms.TextBox Txt_nitEmpleado;
        private System.Windows.Forms.Label Lbl_nombreClt;
        private System.Windows.Forms.TextBox Txt_nombreEmpleado;
        private System.Windows.Forms.Label Lbl_nitClt;
        private System.Windows.Forms.Label Lbl_estClt;
        private System.Windows.Forms.Label Lbl_dpiClt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_idSucursal;
        private CapaDiseno.Navegador navegador1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_IdEmpleado;
        private System.Windows.Forms.ComboBox cbo_idSucursal;
    }
}