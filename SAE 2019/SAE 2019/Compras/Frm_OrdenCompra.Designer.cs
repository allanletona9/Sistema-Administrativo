namespace SAE_2019.Compras
{
    partial class Frm_OrdenCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_OrdenCompra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_iconoFactura = new System.Windows.Forms.Button();
            this.Lbl_facturas = new System.Windows.Forms.Label();
            this.Lbl_proveedor = new System.Windows.Forms.Label();
            this.Lbl_ordenCompra = new System.Windows.Forms.Label();
            this.Lbl_noOrden = new System.Windows.Forms.Label();
            this.Txt_noOrdenCompra = new System.Windows.Forms.TextBox();
            this.Lbl_gastosEnvio = new System.Windows.Forms.Label();
            this.Txt_codigoProducto = new System.Windows.Forms.TextBox();
            this.dgv_ordenCompra = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_ingresarProducto = new System.Windows.Forms.Button();
            this.Btn_eliminarProducto = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Cbo_proveedor = new System.Windows.Forms.ComboBox();
            this.Txt_nombreProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtDescripcionProducto = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_total = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordenCompra)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(212)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Controls.Add(this.Btn_minimizar);
            this.panel1.Controls.Add(this.Btn_iconoFactura);
            this.panel1.Controls.Add(this.Lbl_facturas);
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
            this.Btn_cerrar.Location = new System.Drawing.Point(795, 0);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(48, 48);
            this.Btn_cerrar.TabIndex = 14;
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
            this.Btn_minimizar.Location = new System.Drawing.Point(726, 0);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(48, 48);
            this.Btn_minimizar.TabIndex = 13;
            this.Btn_minimizar.TabStop = false;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // Btn_iconoFactura
            // 
            this.Btn_iconoFactura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_iconoFactura.BackgroundImage")));
            this.Btn_iconoFactura.Enabled = false;
            this.Btn_iconoFactura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(74)))));
            this.Btn_iconoFactura.FlatAppearance.BorderSize = 0;
            this.Btn_iconoFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_iconoFactura.Location = new System.Drawing.Point(15, 4);
            this.Btn_iconoFactura.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_iconoFactura.Name = "Btn_iconoFactura";
            this.Btn_iconoFactura.Size = new System.Drawing.Size(36, 39);
            this.Btn_iconoFactura.TabIndex = 12;
            this.Btn_iconoFactura.UseVisualStyleBackColor = true;
            // 
            // Lbl_facturas
            // 
            this.Lbl_facturas.AutoSize = true;
            this.Lbl_facturas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_facturas.Location = new System.Drawing.Point(74, 16);
            this.Lbl_facturas.Name = "Lbl_facturas";
            this.Lbl_facturas.Size = new System.Drawing.Size(158, 19);
            this.Lbl_facturas.TabIndex = 3;
            this.Lbl_facturas.Text = "ORDEN DE COMPRA";
            // 
            // Lbl_proveedor
            // 
            this.Lbl_proveedor.AutoSize = true;
            this.Lbl_proveedor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_proveedor.Location = new System.Drawing.Point(12, 21);
            this.Lbl_proveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_proveedor.Name = "Lbl_proveedor";
            this.Lbl_proveedor.Size = new System.Drawing.Size(79, 19);
            this.Lbl_proveedor.TabIndex = 1;
            this.Lbl_proveedor.Text = "Proveedor";
            // 
            // Lbl_ordenCompra
            // 
            this.Lbl_ordenCompra.AutoSize = true;
            this.Lbl_ordenCompra.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ordenCompra.Location = new System.Drawing.Point(201, 20);
            this.Lbl_ordenCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_ordenCompra.Name = "Lbl_ordenCompra";
            this.Lbl_ordenCompra.Size = new System.Drawing.Size(135, 19);
            this.Lbl_ordenCompra.TabIndex = 9;
            this.Lbl_ordenCompra.Text = "Orden de compra";
            // 
            // Lbl_noOrden
            // 
            this.Lbl_noOrden.AutoSize = true;
            this.Lbl_noOrden.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_noOrden.Location = new System.Drawing.Point(180, 51);
            this.Lbl_noOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_noOrden.Name = "Lbl_noOrden";
            this.Lbl_noOrden.Size = new System.Drawing.Size(32, 19);
            this.Lbl_noOrden.TabIndex = 10;
            this.Lbl_noOrden.Text = "No.";
            // 
            // Txt_noOrdenCompra
            // 
            this.Txt_noOrdenCompra.Location = new System.Drawing.Point(216, 50);
            this.Txt_noOrdenCompra.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_noOrdenCompra.Name = "Txt_noOrdenCompra";
            this.Txt_noOrdenCompra.ReadOnly = true;
            this.Txt_noOrdenCompra.Size = new System.Drawing.Size(120, 20);
            this.Txt_noOrdenCompra.TabIndex = 11;
            this.Txt_noOrdenCompra.TabStop = false;
            // 
            // Lbl_gastosEnvio
            // 
            this.Lbl_gastosEnvio.AutoSize = true;
            this.Lbl_gastosEnvio.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_gastosEnvio.Location = new System.Drawing.Point(20, 28);
            this.Lbl_gastosEnvio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_gastosEnvio.Name = "Lbl_gastosEnvio";
            this.Lbl_gastosEnvio.Size = new System.Drawing.Size(150, 19);
            this.Lbl_gastosEnvio.TabIndex = 12;
            this.Lbl_gastosEnvio.Text = "Codigo de Producto";
            this.Lbl_gastosEnvio.Click += new System.EventHandler(this.Lbl_gastosEnvio_Click);
            // 
            // Txt_codigoProducto
            // 
            this.Txt_codigoProducto.Location = new System.Drawing.Point(23, 58);
            this.Txt_codigoProducto.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_codigoProducto.Name = "Txt_codigoProducto";
            this.Txt_codigoProducto.Size = new System.Drawing.Size(147, 20);
            this.Txt_codigoProducto.TabIndex = 2;
            this.Txt_codigoProducto.TextChanged += new System.EventHandler(this.Txt_codigoProducto_TextChanged);
            // 
            // dgv_ordenCompra
            // 
            this.dgv_ordenCompra.AllowUserToAddRows = false;
            this.dgv_ordenCompra.AllowUserToDeleteRows = false;
            this.dgv_ordenCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ordenCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.Column1,
            this.descripcion,
            this.Column2,
            this.cantidad});
            this.dgv_ordenCompra.Location = new System.Drawing.Point(85, 411);
            this.dgv_ordenCompra.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_ordenCompra.Name = "dgv_ordenCompra";
            this.dgv_ordenCompra.RowTemplate.Height = 24;
            this.dgv_ordenCompra.Size = new System.Drawing.Size(549, 225);
            this.dgv_ordenCompra.TabIndex = 5;
            this.dgv_ordenCompra.TabStop = false;
            this.dgv_ordenCompra.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ordenCompra_CellClick);
            this.dgv_ordenCompra.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ordenCompra_CellContentClick);
            this.dgv_ordenCompra.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_ordenCompra_CellEndEdit);
            this.dgv_ordenCompra.CellParsing += new System.Windows.Forms.DataGridViewCellParsingEventHandler(this.dgv_ordenCompra_CellParsing);
            this.dgv_ordenCompra.CellStateChanged += new System.Windows.Forms.DataGridViewCellStateChangedEventHandler(this.dgv_ordenCompra_CellStateChanged);
            this.dgv_ordenCompra.Enter += new System.EventHandler(this.dgv_ordenCompra_Enter);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre ";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Precio";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // Btn_ingresarProducto
            // 
            this.Btn_ingresarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.Btn_ingresarProducto.FlatAppearance.BorderSize = 0;
            this.Btn_ingresarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ingresarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ingresarProducto.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ingresarProducto.Image")));
            this.Btn_ingresarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ingresarProducto.Location = new System.Drawing.Point(640, 507);
            this.Btn_ingresarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ingresarProducto.Name = "Btn_ingresarProducto";
            this.Btn_ingresarProducto.Size = new System.Drawing.Size(168, 44);
            this.Btn_ingresarProducto.TabIndex = 17;
            this.Btn_ingresarProducto.TabStop = false;
            this.Btn_ingresarProducto.Text = "Ingresar Producto       ";
            this.Btn_ingresarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ingresarProducto.UseVisualStyleBackColor = false;
            this.Btn_ingresarProducto.Click += new System.EventHandler(this.Btn_ingresarProducto_Click);
            // 
            // Btn_eliminarProducto
            // 
            this.Btn_eliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.Btn_eliminarProducto.FlatAppearance.BorderSize = 0;
            this.Btn_eliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminarProducto.Image = ((System.Drawing.Image)(resources.GetObject("Btn_eliminarProducto.Image")));
            this.Btn_eliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_eliminarProducto.Location = new System.Drawing.Point(639, 459);
            this.Btn_eliminarProducto.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_eliminarProducto.Name = "Btn_eliminarProducto";
            this.Btn_eliminarProducto.Size = new System.Drawing.Size(168, 44);
            this.Btn_eliminarProducto.TabIndex = 18;
            this.Btn_eliminarProducto.TabStop = false;
            this.Btn_eliminarProducto.Text = "Eliminar de la lista      ";
            this.Btn_eliminarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_eliminarProducto.UseVisualStyleBackColor = false;
            this.Btn_eliminarProducto.Click += new System.EventHandler(this.Btn_eliminarProducto_Click);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.Btn_guardar.FlatAppearance.BorderSize = 0;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_guardar.Location = new System.Drawing.Point(639, 411);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(168, 44);
            this.Btn_guardar.TabIndex = 20;
            this.Btn_guardar.TabStop = false;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // Cbo_proveedor
            // 
            this.Cbo_proveedor.FormattingEnabled = true;
            this.Cbo_proveedor.Location = new System.Drawing.Point(16, 50);
            this.Cbo_proveedor.Margin = new System.Windows.Forms.Padding(2);
            this.Cbo_proveedor.Name = "Cbo_proveedor";
            this.Cbo_proveedor.Size = new System.Drawing.Size(146, 21);
            this.Cbo_proveedor.TabIndex = 1;
            this.Cbo_proveedor.TabStop = false;
            this.Cbo_proveedor.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Txt_nombreProducto
            // 
            this.Txt_nombreProducto.Location = new System.Drawing.Point(191, 58);
            this.Txt_nombreProducto.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_nombreProducto.Name = "Txt_nombreProducto";
            this.Txt_nombreProducto.ReadOnly = true;
            this.Txt_nombreProducto.Size = new System.Drawing.Size(145, 20);
            this.Txt_nombreProducto.TabIndex = 29;
            this.Txt_nombreProducto.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(188, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Nombre Producto";
            // 
            // TxtDescripcionProducto
            // 
            this.TxtDescripcionProducto.Location = new System.Drawing.Point(353, 58);
            this.TxtDescripcionProducto.Margin = new System.Windows.Forms.Padding(2);
            this.TxtDescripcionProducto.Name = "TxtDescripcionProducto";
            this.TxtDescripcionProducto.ReadOnly = true;
            this.TxtDescripcionProducto.Size = new System.Drawing.Size(178, 20);
            this.TxtDescripcionProducto.TabIndex = 31;
            this.TxtDescripcionProducto.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(350, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 19);
            this.label2.TabIndex = 30;
            this.label2.Text = "Descripcion de producto";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(639, 256);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 44);
            this.button1.TabIndex = 3;
            this.button1.Text = "Buscar Producto       ";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Cbo_proveedor);
            this.groupBox1.Controls.Add(this.Lbl_proveedor);
            this.groupBox1.Controls.Add(this.Lbl_ordenCompra);
            this.groupBox1.Controls.Add(this.Lbl_noOrden);
            this.groupBox1.Controls.Add(this.Txt_noOrdenCompra);
            this.groupBox1.Location = new System.Drawing.Point(85, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(346, 88);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Encabezado Orden de Compra";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lbl_gastosEnvio);
            this.groupBox2.Controls.Add(this.Txt_codigoProducto);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.TxtDescripcionProducto);
            this.groupBox2.Controls.Add(this.Txt_nombreProducto);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(85, 250);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(549, 112);
            this.groupBox2.TabIndex = 34;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Busqueda de productos";
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar.Image")));
            this.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_agregar.Location = new System.Drawing.Point(639, 304);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(168, 44);
            this.btn_agregar.TabIndex = 4;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(379, 658);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 19);
            this.label3.TabIndex = 35;
            this.label3.Text = "Total de orden:";
            // 
            // Txt_total
            // 
            this.Txt_total.Location = new System.Drawing.Point(506, 659);
            this.Txt_total.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_total.Name = "Txt_total";
            this.Txt_total.ReadOnly = true;
            this.Txt_total.Size = new System.Drawing.Size(128, 20);
            this.Txt_total.TabIndex = 36;
            this.Txt_total.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::SAE_2019.Properties.Resources.boton_web_de_ayuda2;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(747, 63);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 33);
            this.button2.TabIndex = 53;
            this.button2.Text = "Ayuda";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_OrdenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 774);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Txt_total);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_eliminarProducto);
            this.Controls.Add(this.Btn_ingresarProducto);
            this.Controls.Add(this.dgv_ordenCompra);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_OrdenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_facturasCompras";
            this.Load += new System.EventHandler(this.Frm_facturasCompras_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ordenCompra)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_facturas;
        private System.Windows.Forms.Button Btn_iconoFactura;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_proveedor;
        private System.Windows.Forms.Label Lbl_ordenCompra;
        private System.Windows.Forms.Label Lbl_noOrden;
        private System.Windows.Forms.TextBox Txt_noOrdenCompra;
        private System.Windows.Forms.Label Lbl_gastosEnvio;
        private System.Windows.Forms.TextBox Txt_codigoProducto;
        private System.Windows.Forms.DataGridView dgv_ordenCompra;
        private System.Windows.Forms.Button Btn_ingresarProducto;
        private System.Windows.Forms.Button Btn_eliminarProducto;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.ComboBox Cbo_proveedor;
        private System.Windows.Forms.TextBox Txt_nombreProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtDescripcionProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_total;
        private System.Windows.Forms.Button button2;
    }
}