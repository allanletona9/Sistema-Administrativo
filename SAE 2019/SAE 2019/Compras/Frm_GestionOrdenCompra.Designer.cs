namespace SAE_2019.Compras
{
    partial class Frm_GestionOrdenCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GestionOrdenCompra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_iconoOrdenCompra = new System.Windows.Forms.Button();
            this.Lbl_ordenCompra = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Dgv_mostrarFacturas = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_tracking = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_fechaActualizacion = new System.Windows.Forms.TextBox();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_fechaCreacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Lbl_codigoOrden = new System.Windows.Forms.Label();
            this.Txt_codigoCompra = new System.Windows.Forms.TextBox();
            this.Btn_buscarCompra = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_proveedor = new System.Windows.Forms.TextBox();
            this.Lbl_proveedor = new System.Windows.Forms.Label();
            this.Cbo_tracking = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_mostrarFacturas)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(212)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Controls.Add(this.Btn_minimizar);
            this.panel1.Controls.Add(this.Btn_iconoOrdenCompra);
            this.panel1.Controls.Add(this.Lbl_ordenCompra);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(886, 48);
            this.panel1.TabIndex = 0;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.BackgroundImage")));
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Location = new System.Drawing.Point(808, 0);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(48, 48);
            this.Btn_cerrar.TabIndex = 15;
            this.Btn_cerrar.TabStop = false;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.BackgroundImage")));
            this.Btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Location = new System.Drawing.Point(740, 0);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(48, 48);
            this.Btn_minimizar.TabIndex = 14;
            this.Btn_minimizar.TabStop = false;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // Btn_iconoOrdenCompra
            // 
            this.Btn_iconoOrdenCompra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_iconoOrdenCompra.BackgroundImage")));
            this.Btn_iconoOrdenCompra.Enabled = false;
            this.Btn_iconoOrdenCompra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(74)))));
            this.Btn_iconoOrdenCompra.FlatAppearance.BorderSize = 0;
            this.Btn_iconoOrdenCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_iconoOrdenCompra.Location = new System.Drawing.Point(15, 4);
            this.Btn_iconoOrdenCompra.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_iconoOrdenCompra.Name = "Btn_iconoOrdenCompra";
            this.Btn_iconoOrdenCompra.Size = new System.Drawing.Size(36, 39);
            this.Btn_iconoOrdenCompra.TabIndex = 13;
            this.Btn_iconoOrdenCompra.UseVisualStyleBackColor = true;
            // 
            // Lbl_ordenCompra
            // 
            this.Lbl_ordenCompra.AutoSize = true;
            this.Lbl_ordenCompra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ordenCompra.Location = new System.Drawing.Point(74, 16);
            this.Lbl_ordenCompra.Name = "Lbl_ordenCompra";
            this.Lbl_ordenCompra.Size = new System.Drawing.Size(227, 19);
            this.Lbl_ordenCompra.TabIndex = 4;
            this.Lbl_ordenCompra.Text = "GESTION ORDEN DE COMPRA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(363, 293);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 17);
            this.label1.TabIndex = 8;
            // 
            // Dgv_mostrarFacturas
            // 
            this.Dgv_mostrarFacturas.AllowUserToAddRows = false;
            this.Dgv_mostrarFacturas.AllowUserToDeleteRows = false;
            this.Dgv_mostrarFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_mostrarFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.cod_factura,
            this.tipo_factura,
            this.cod_proveedor});
            this.Dgv_mostrarFacturas.Location = new System.Drawing.Point(14, 84);
            this.Dgv_mostrarFacturas.Margin = new System.Windows.Forms.Padding(2);
            this.Dgv_mostrarFacturas.Name = "Dgv_mostrarFacturas";
            this.Dgv_mostrarFacturas.ReadOnly = true;
            this.Dgv_mostrarFacturas.RowTemplate.Height = 24;
            this.Dgv_mostrarFacturas.Size = new System.Drawing.Size(681, 263);
            this.Dgv_mostrarFacturas.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_tracking);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Txt_fechaActualizacion);
            this.groupBox1.Controls.Add(this.Btn_actualizar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Txt_fechaCreacion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Lbl_codigoOrden);
            this.groupBox1.Controls.Add(this.Txt_codigoCompra);
            this.groupBox1.Controls.Add(this.Btn_buscarCompra);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txt_proveedor);
            this.groupBox1.Controls.Add(this.Lbl_proveedor);
            this.groupBox1.Controls.Add(this.Cbo_tracking);
            this.groupBox1.Location = new System.Drawing.Point(78, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(742, 254);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Gestion de Orden";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Txt_tracking
            // 
            this.Txt_tracking.Location = new System.Drawing.Point(13, 212);
            this.Txt_tracking.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_tracking.Name = "Txt_tracking";
            this.Txt_tracking.ReadOnly = true;
            this.Txt_tracking.Size = new System.Drawing.Size(146, 20);
            this.Txt_tracking.TabIndex = 38;
            this.Txt_tracking.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 19);
            this.label5.TabIndex = 37;
            this.label5.Text = "Tracking";
            // 
            // Txt_fechaActualizacion
            // 
            this.Txt_fechaActualizacion.Location = new System.Drawing.Point(186, 212);
            this.Txt_fechaActualizacion.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_fechaActualizacion.Name = "Txt_fechaActualizacion";
            this.Txt_fechaActualizacion.ReadOnly = true;
            this.Txt_fechaActualizacion.Size = new System.Drawing.Size(167, 20);
            this.Txt_fechaActualizacion.TabIndex = 36;
            this.Txt_fechaActualizacion.TabStop = false;
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.Btn_actualizar.FlatAppearance.BorderSize = 0;
            this.Btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_actualizar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_actualizar.Image")));
            this.Btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_actualizar.Location = new System.Drawing.Point(441, 122);
            this.Btn_actualizar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(233, 44);
            this.Btn_actualizar.TabIndex = 21;
            this.Btn_actualizar.TabStop = false;
            this.Btn_actualizar.Text = "Actualizar Compra";
            this.Btn_actualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_actualizar.UseVisualStyleBackColor = false;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(182, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 19);
            this.label4.TabIndex = 35;
            this.label4.Text = "Ultima Actualizacion";
            // 
            // Txt_fechaCreacion
            // 
            this.Txt_fechaCreacion.Location = new System.Drawing.Point(185, 135);
            this.Txt_fechaCreacion.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_fechaCreacion.Name = "Txt_fechaCreacion";
            this.Txt_fechaCreacion.ReadOnly = true;
            this.Txt_fechaCreacion.Size = new System.Drawing.Size(168, 20);
            this.Txt_fechaCreacion.TabIndex = 34;
            this.Txt_fechaCreacion.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Fecha de Creacion";
            // 
            // Lbl_codigoOrden
            // 
            this.Lbl_codigoOrden.AutoSize = true;
            this.Lbl_codigoOrden.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_codigoOrden.Location = new System.Drawing.Point(10, 31);
            this.Lbl_codigoOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_codigoOrden.Name = "Lbl_codigoOrden";
            this.Lbl_codigoOrden.Size = new System.Drawing.Size(144, 19);
            this.Lbl_codigoOrden.TabIndex = 32;
            this.Lbl_codigoOrden.Text = "Codigo de Compra";
            // 
            // Txt_codigoCompra
            // 
            this.Txt_codigoCompra.Location = new System.Drawing.Point(13, 61);
            this.Txt_codigoCompra.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_codigoCompra.Name = "Txt_codigoCompra";
            this.Txt_codigoCompra.Size = new System.Drawing.Size(147, 20);
            this.Txt_codigoCompra.TabIndex = 30;
            this.Txt_codigoCompra.TextChanged += new System.EventHandler(this.Txt_codigoCompra_TextChanged);
            // 
            // Btn_buscarCompra
            // 
            this.Btn_buscarCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.Btn_buscarCompra.FlatAppearance.BorderSize = 0;
            this.Btn_buscarCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscarCompra.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscarCompra.Image = ((System.Drawing.Image)(resources.GetObject("Btn_buscarCompra.Image")));
            this.Btn_buscarCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_buscarCompra.Location = new System.Drawing.Point(185, 37);
            this.Btn_buscarCompra.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_buscarCompra.Name = "Btn_buscarCompra";
            this.Btn_buscarCompra.Size = new System.Drawing.Size(168, 44);
            this.Btn_buscarCompra.TabIndex = 31;
            this.Btn_buscarCompra.Text = "Buscar Compra";
            this.Btn_buscarCompra.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_buscarCompra.UseVisualStyleBackColor = false;
            this.Btn_buscarCompra.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(437, 29);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 19);
            this.label3.TabIndex = 29;
            this.label3.Text = "Cambio de Tracking";
            // 
            // Txt_proveedor
            // 
            this.Txt_proveedor.Location = new System.Drawing.Point(14, 135);
            this.Txt_proveedor.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_proveedor.Name = "Txt_proveedor";
            this.Txt_proveedor.ReadOnly = true;
            this.Txt_proveedor.Size = new System.Drawing.Size(147, 20);
            this.Txt_proveedor.TabIndex = 28;
            this.Txt_proveedor.TabStop = false;
            // 
            // Lbl_proveedor
            // 
            this.Lbl_proveedor.AutoSize = true;
            this.Lbl_proveedor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_proveedor.Location = new System.Drawing.Point(10, 105);
            this.Lbl_proveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_proveedor.Name = "Lbl_proveedor";
            this.Lbl_proveedor.Size = new System.Drawing.Size(79, 19);
            this.Lbl_proveedor.TabIndex = 24;
            this.Lbl_proveedor.Text = "Proveedor";
            // 
            // Cbo_tracking
            // 
            this.Cbo_tracking.FormattingEnabled = true;
            this.Cbo_tracking.Location = new System.Drawing.Point(441, 61);
            this.Cbo_tracking.Name = "Cbo_tracking";
            this.Cbo_tracking.Size = new System.Drawing.Size(233, 21);
            this.Cbo_tracking.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(527, 36);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 44);
            this.button1.TabIndex = 32;
            this.button1.Text = "Actualizar Tabla";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 48);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(241, 19);
            this.label6.TabIndex = 33;
            this.label6.Text = "Compras registradas en el sistema";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Codigo de Compra";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // cod_factura
            // 
            this.cod_factura.HeaderText = "Fecha de creacion";
            this.cod_factura.Name = "cod_factura";
            this.cod_factura.ReadOnly = true;
            // 
            // tipo_factura
            // 
            this.tipo_factura.HeaderText = "Fecha de ultima actualizacion";
            this.tipo_factura.Name = "tipo_factura";
            this.tipo_factura.ReadOnly = true;
            this.tipo_factura.Width = 110;
            // 
            // cod_proveedor
            // 
            this.cod_proveedor.HeaderText = "Tracking";
            this.cod_proveedor.Name = "cod_proveedor";
            this.cod_proveedor.ReadOnly = true;
            this.cod_proveedor.Width = 320;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.Dgv_mostrarFacturas);
            this.groupBox2.Location = new System.Drawing.Point(78, 370);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(742, 365);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Todas las compras";
            // 
            // Frm_GestionOrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 774);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_GestionOrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ordenCompra";
            this.Load += new System.EventHandler(this.Frm_GestionOrdenCompra_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_mostrarFacturas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_ordenCompra;
        private System.Windows.Forms.Button Btn_iconoOrdenCompra;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView Dgv_mostrarFacturas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_proveedor;
        private System.Windows.Forms.Label Lbl_proveedor;
        private System.Windows.Forms.TextBox Txt_fechaActualizacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_fechaCreacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_codigoOrden;
        private System.Windows.Forms.TextBox Txt_codigoCompra;
        private System.Windows.Forms.Button Btn_buscarCompra;
        private System.Windows.Forms.TextBox Txt_tracking;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_actualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Cbo_tracking;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_proveedor;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}