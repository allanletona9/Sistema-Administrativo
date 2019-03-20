namespace SAE_2019.Compras
{
    partial class Frm_facturasCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_facturasCompras));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_iconoFactura = new System.Windows.Forms.Button();
            this.Lbl_facturas = new System.Windows.Forms.Label();
            this.Lbl_proveedor = new System.Windows.Forms.Label();
            this.Txt_proveedor = new System.Windows.Forms.TextBox();
            this.Lbl_tipoComprobante = new System.Windows.Forms.Label();
            this.Cmb_tipoComprobante = new System.Windows.Forms.ComboBox();
            this.Lbl_noFactura = new System.Windows.Forms.Label();
            this.Txt_noFactura = new System.Windows.Forms.TextBox();
            this.Lbl_fecha = new System.Windows.Forms.Label();
            this.Dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.Lbl_ordenCompra = new System.Windows.Forms.Label();
            this.Lbl_noOrden = new System.Windows.Forms.Label();
            this.Txt_noOrdenCompra = new System.Windows.Forms.TextBox();
            this.Lbl_gastosEnvio = new System.Windows.Forms.Label();
            this.Txt_gastosEnvio = new System.Windows.Forms.TextBox();
            this.Lbl_iva = new System.Windows.Forms.Label();
            this.Txt_fva = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_ingresarProducto = new System.Windows.Forms.Button();
            this.Btn_eliminarProducto = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.Lbl_subTotal = new System.Windows.Forms.Label();
            this.Txt_subTotal = new System.Windows.Forms.TextBox();
            this.Lbl_descuentos = new System.Windows.Forms.Label();
            this.Txt_descuentos = new System.Windows.Forms.TextBox();
            this.Lbl_total = new System.Windows.Forms.Label();
            this.Txt_total = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 59);
            this.panel1.TabIndex = 0;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.BackgroundImage")));
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Location = new System.Drawing.Point(1060, 0);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(64, 59);
            this.Btn_cerrar.TabIndex = 14;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.BackgroundImage")));
            this.Btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Location = new System.Drawing.Point(968, 0);
            this.Btn_minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(64, 59);
            this.Btn_minimizar.TabIndex = 13;
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
            this.Btn_iconoFactura.Location = new System.Drawing.Point(20, 5);
            this.Btn_iconoFactura.Name = "Btn_iconoFactura";
            this.Btn_iconoFactura.Size = new System.Drawing.Size(48, 48);
            this.Btn_iconoFactura.TabIndex = 12;
            this.Btn_iconoFactura.UseVisualStyleBackColor = true;
            // 
            // Lbl_facturas
            // 
            this.Lbl_facturas.AutoSize = true;
            this.Lbl_facturas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_facturas.Location = new System.Drawing.Point(99, 20);
            this.Lbl_facturas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_facturas.Name = "Lbl_facturas";
            this.Lbl_facturas.Size = new System.Drawing.Size(153, 23);
            this.Lbl_facturas.TabIndex = 3;
            this.Lbl_facturas.Text = "FACTURACIÓN";
            // 
            // Lbl_proveedor
            // 
            this.Lbl_proveedor.AutoSize = true;
            this.Lbl_proveedor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_proveedor.Location = new System.Drawing.Point(26, 88);
            this.Lbl_proveedor.Name = "Lbl_proveedor";
            this.Lbl_proveedor.Size = new System.Drawing.Size(97, 21);
            this.Lbl_proveedor.TabIndex = 1;
            this.Lbl_proveedor.Text = "Proveedor";
            // 
            // Txt_proveedor
            // 
            this.Txt_proveedor.Location = new System.Drawing.Point(30, 125);
            this.Txt_proveedor.Name = "Txt_proveedor";
            this.Txt_proveedor.Size = new System.Drawing.Size(163, 22);
            this.Txt_proveedor.TabIndex = 2;
            // 
            // Lbl_tipoComprobante
            // 
            this.Lbl_tipoComprobante.AutoSize = true;
            this.Lbl_tipoComprobante.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_tipoComprobante.Location = new System.Drawing.Point(253, 88);
            this.Lbl_tipoComprobante.Name = "Lbl_tipoComprobante";
            this.Lbl_tipoComprobante.Size = new System.Drawing.Size(197, 21);
            this.Lbl_tipoComprobante.TabIndex = 3;
            this.Lbl_tipoComprobante.Text = "Tipo de Comprobante";
            // 
            // Cmb_tipoComprobante
            // 
            this.Cmb_tipoComprobante.FormattingEnabled = true;
            this.Cmb_tipoComprobante.Location = new System.Drawing.Point(257, 123);
            this.Cmb_tipoComprobante.Name = "Cmb_tipoComprobante";
            this.Cmb_tipoComprobante.Size = new System.Drawing.Size(193, 24);
            this.Cmb_tipoComprobante.TabIndex = 4;
            // 
            // Lbl_noFactura
            // 
            this.Lbl_noFactura.AutoSize = true;
            this.Lbl_noFactura.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_noFactura.Location = new System.Drawing.Point(506, 88);
            this.Lbl_noFactura.Name = "Lbl_noFactura";
            this.Lbl_noFactura.Size = new System.Drawing.Size(109, 21);
            this.Lbl_noFactura.TabIndex = 5;
            this.Lbl_noFactura.Text = "No. Factura";
            // 
            // Txt_noFactura
            // 
            this.Txt_noFactura.Location = new System.Drawing.Point(510, 123);
            this.Txt_noFactura.Name = "Txt_noFactura";
            this.Txt_noFactura.Size = new System.Drawing.Size(105, 22);
            this.Txt_noFactura.TabIndex = 6;
            // 
            // Lbl_fecha
            // 
            this.Lbl_fecha.AutoSize = true;
            this.Lbl_fecha.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fecha.Location = new System.Drawing.Point(666, 88);
            this.Lbl_fecha.Name = "Lbl_fecha";
            this.Lbl_fecha.Size = new System.Drawing.Size(62, 21);
            this.Lbl_fecha.TabIndex = 7;
            this.Lbl_fecha.Text = "Fecha";
            // 
            // Dtp_fecha
            // 
            this.Dtp_fecha.Location = new System.Drawing.Point(670, 125);
            this.Dtp_fecha.Name = "Dtp_fecha";
            this.Dtp_fecha.Size = new System.Drawing.Size(200, 22);
            this.Dtp_fecha.TabIndex = 8;
            // 
            // Lbl_ordenCompra
            // 
            this.Lbl_ordenCompra.AutoSize = true;
            this.Lbl_ordenCompra.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ordenCompra.Location = new System.Drawing.Point(60, 186);
            this.Lbl_ordenCompra.Name = "Lbl_ordenCompra";
            this.Lbl_ordenCompra.Size = new System.Drawing.Size(162, 21);
            this.Lbl_ordenCompra.TabIndex = 9;
            this.Lbl_ordenCompra.Text = "Orden de compra";
            // 
            // Lbl_noOrden
            // 
            this.Lbl_noOrden.AutoSize = true;
            this.Lbl_noOrden.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_noOrden.Location = new System.Drawing.Point(16, 224);
            this.Lbl_noOrden.Name = "Lbl_noOrden";
            this.Lbl_noOrden.Size = new System.Drawing.Size(39, 21);
            this.Lbl_noOrden.TabIndex = 10;
            this.Lbl_noOrden.Text = "No.";
            // 
            // Txt_noOrdenCompra
            // 
            this.Txt_noOrdenCompra.Location = new System.Drawing.Point(64, 223);
            this.Txt_noOrdenCompra.Name = "Txt_noOrdenCompra";
            this.Txt_noOrdenCompra.Size = new System.Drawing.Size(158, 22);
            this.Txt_noOrdenCompra.TabIndex = 11;
            // 
            // Lbl_gastosEnvio
            // 
            this.Lbl_gastosEnvio.AutoSize = true;
            this.Lbl_gastosEnvio.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_gastosEnvio.Location = new System.Drawing.Point(253, 186);
            this.Lbl_gastosEnvio.Name = "Lbl_gastosEnvio";
            this.Lbl_gastosEnvio.Size = new System.Drawing.Size(148, 21);
            this.Lbl_gastosEnvio.TabIndex = 12;
            this.Lbl_gastosEnvio.Text = "Gastos de envio";
            // 
            // Txt_gastosEnvio
            // 
            this.Txt_gastosEnvio.Location = new System.Drawing.Point(257, 223);
            this.Txt_gastosEnvio.Name = "Txt_gastosEnvio";
            this.Txt_gastosEnvio.Size = new System.Drawing.Size(144, 22);
            this.Txt_gastosEnvio.TabIndex = 13;
            // 
            // Lbl_iva
            // 
            this.Lbl_iva.AutoSize = true;
            this.Lbl_iva.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_iva.Location = new System.Drawing.Point(506, 186);
            this.Lbl_iva.Name = "Lbl_iva";
            this.Lbl_iva.Size = new System.Drawing.Size(41, 21);
            this.Lbl_iva.TabIndex = 14;
            this.Lbl_iva.Text = "IVA";
            // 
            // Txt_fva
            // 
            this.Txt_fva.Location = new System.Drawing.Point(510, 223);
            this.Txt_fva.Name = "Txt_fva";
            this.Txt_fva.Size = new System.Drawing.Size(72, 22);
            this.Txt_fva.TabIndex = 15;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion,
            this.cantidad,
            this.precio,
            this.precioTotal});
            this.dataGridView1.Location = new System.Drawing.Point(64, 381);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1060, 210);
            this.dataGridView1.TabIndex = 16;
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // precioTotal
            // 
            this.precioTotal.HeaderText = "Precio Total";
            this.precioTotal.Name = "precioTotal";
            // 
            // Btn_ingresarProducto
            // 
            this.Btn_ingresarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.Btn_ingresarProducto.FlatAppearance.BorderSize = 0;
            this.Btn_ingresarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ingresarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ingresarProducto.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ingresarProducto.Image")));
            this.Btn_ingresarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ingresarProducto.Location = new System.Drawing.Point(914, 72);
            this.Btn_ingresarProducto.Name = "Btn_ingresarProducto";
            this.Btn_ingresarProducto.Size = new System.Drawing.Size(224, 54);
            this.Btn_ingresarProducto.TabIndex = 17;
            this.Btn_ingresarProducto.Text = "Ingresar Producto       ";
            this.Btn_ingresarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ingresarProducto.UseVisualStyleBackColor = false;
            // 
            // Btn_eliminarProducto
            // 
            this.Btn_eliminarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.Btn_eliminarProducto.FlatAppearance.BorderSize = 0;
            this.Btn_eliminarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminarProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminarProducto.Image = ((System.Drawing.Image)(resources.GetObject("Btn_eliminarProducto.Image")));
            this.Btn_eliminarProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_eliminarProducto.Location = new System.Drawing.Point(914, 143);
            this.Btn_eliminarProducto.Name = "Btn_eliminarProducto";
            this.Btn_eliminarProducto.Size = new System.Drawing.Size(224, 54);
            this.Btn_eliminarProducto.TabIndex = 18;
            this.Btn_eliminarProducto.Text = "Eliminar de la lista      ";
            this.Btn_eliminarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_eliminarProducto.UseVisualStyleBackColor = false;
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.Btn_modificar.FlatAppearance.BorderSize = 0;
            this.Btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_modificar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_modificar.Image")));
            this.Btn_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_modificar.Location = new System.Drawing.Point(914, 296);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(188, 54);
            this.Btn_modificar.TabIndex = 19;
            this.Btn_modificar.Text = "Modificar";
            this.Btn_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_modificar.UseVisualStyleBackColor = false;
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.Btn_guardar.FlatAppearance.BorderSize = 0;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_guardar.Location = new System.Drawing.Point(914, 223);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(188, 54);
            this.Btn_guardar.TabIndex = 20;
            this.Btn_guardar.Text = "Guardar";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            // 
            // Lbl_subTotal
            // 
            this.Lbl_subTotal.AutoSize = true;
            this.Lbl_subTotal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_subTotal.Location = new System.Drawing.Point(835, 635);
            this.Lbl_subTotal.Name = "Lbl_subTotal";
            this.Lbl_subTotal.Size = new System.Drawing.Size(81, 21);
            this.Lbl_subTotal.TabIndex = 21;
            this.Lbl_subTotal.Text = "SubTotal";
            // 
            // Txt_subTotal
            // 
            this.Txt_subTotal.Location = new System.Drawing.Point(939, 634);
            this.Txt_subTotal.Name = "Txt_subTotal";
            this.Txt_subTotal.Size = new System.Drawing.Size(163, 22);
            this.Txt_subTotal.TabIndex = 22;
            // 
            // Lbl_descuentos
            // 
            this.Lbl_descuentos.AutoSize = true;
            this.Lbl_descuentos.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_descuentos.Location = new System.Drawing.Point(808, 691);
            this.Lbl_descuentos.Name = "Lbl_descuentos";
            this.Lbl_descuentos.Size = new System.Drawing.Size(108, 21);
            this.Lbl_descuentos.TabIndex = 23;
            this.Lbl_descuentos.Text = "Descuentos";
            // 
            // Txt_descuentos
            // 
            this.Txt_descuentos.Location = new System.Drawing.Point(939, 690);
            this.Txt_descuentos.Name = "Txt_descuentos";
            this.Txt_descuentos.Size = new System.Drawing.Size(163, 22);
            this.Txt_descuentos.TabIndex = 24;
            // 
            // Lbl_total
            // 
            this.Lbl_total.AutoSize = true;
            this.Lbl_total.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_total.Location = new System.Drawing.Point(808, 744);
            this.Lbl_total.Name = "Lbl_total";
            this.Lbl_total.Size = new System.Drawing.Size(108, 21);
            this.Lbl_total.TabIndex = 25;
            this.Lbl_total.Text = "Descuentos";
            // 
            // Txt_total
            // 
            this.Txt_total.Location = new System.Drawing.Point(939, 745);
            this.Txt_total.Name = "Txt_total";
            this.Txt_total.Size = new System.Drawing.Size(163, 22);
            this.Txt_total.TabIndex = 26;
            // 
            // Frm_facturasCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 953);
            this.Controls.Add(this.Txt_total);
            this.Controls.Add(this.Lbl_total);
            this.Controls.Add(this.Txt_descuentos);
            this.Controls.Add(this.Lbl_descuentos);
            this.Controls.Add(this.Txt_subTotal);
            this.Controls.Add(this.Lbl_subTotal);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.Btn_eliminarProducto);
            this.Controls.Add(this.Btn_ingresarProducto);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Txt_fva);
            this.Controls.Add(this.Lbl_iva);
            this.Controls.Add(this.Txt_gastosEnvio);
            this.Controls.Add(this.Lbl_gastosEnvio);
            this.Controls.Add(this.Txt_noOrdenCompra);
            this.Controls.Add(this.Lbl_noOrden);
            this.Controls.Add(this.Lbl_ordenCompra);
            this.Controls.Add(this.Dtp_fecha);
            this.Controls.Add(this.Lbl_fecha);
            this.Controls.Add(this.Txt_noFactura);
            this.Controls.Add(this.Lbl_noFactura);
            this.Controls.Add(this.Cmb_tipoComprobante);
            this.Controls.Add(this.Lbl_tipoComprobante);
            this.Controls.Add(this.Txt_proveedor);
            this.Controls.Add(this.Lbl_proveedor);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_facturasCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_facturasCompras";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.TextBox Txt_proveedor;
        private System.Windows.Forms.Label Lbl_tipoComprobante;
        private System.Windows.Forms.ComboBox Cmb_tipoComprobante;
        private System.Windows.Forms.Label Lbl_noFactura;
        private System.Windows.Forms.TextBox Txt_noFactura;
        private System.Windows.Forms.Label Lbl_fecha;
        private System.Windows.Forms.DateTimePicker Dtp_fecha;
        private System.Windows.Forms.Label Lbl_ordenCompra;
        private System.Windows.Forms.Label Lbl_noOrden;
        private System.Windows.Forms.TextBox Txt_noOrdenCompra;
        private System.Windows.Forms.Label Lbl_gastosEnvio;
        private System.Windows.Forms.TextBox Txt_gastosEnvio;
        private System.Windows.Forms.Label Lbl_iva;
        private System.Windows.Forms.TextBox Txt_fva;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioTotal;
        private System.Windows.Forms.Button Btn_ingresarProducto;
        private System.Windows.Forms.Button Btn_eliminarProducto;
        private System.Windows.Forms.Button Btn_modificar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Label Lbl_subTotal;
        private System.Windows.Forms.TextBox Txt_subTotal;
        private System.Windows.Forms.Label Lbl_descuentos;
        private System.Windows.Forms.TextBox Txt_descuentos;
        private System.Windows.Forms.Label Lbl_total;
        private System.Windows.Forms.TextBox Txt_total;
    }
}