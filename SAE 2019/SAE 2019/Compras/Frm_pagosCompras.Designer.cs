namespace SAE_2019.Compras
{
    partial class Frm_pagosCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_pagosCompras));
            this.Dvg_compras = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_cuentasPagar = new System.Windows.Forms.Label();
            this.Btn_agregarOrden = new System.Windows.Forms.Button();
            this.Lbl_Abono = new System.Windows.Forms.Label();
            this.Txt_Abono = new System.Windows.Forms.TextBox();
            this.Lbl_Saldo = new System.Windows.Forms.Label();
            this.Lbl_cantidadSaldo = new System.Windows.Forms.Label();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.Lbl_montoTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_OrdenCompra = new System.Windows.Forms.TextBox();
            this.Btn_buscarOrdenCompra = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_paisProveedor = new System.Windows.Forms.TextBox();
            this.Txt_direccionProveedor = new System.Windows.Forms.TextBox();
            this.Txt_nitProveedor = new System.Windows.Forms.TextBox();
            this.Txt_nombreProveedor = new System.Windows.Forms.TextBox();
            this.Lbl_PaisProveedor = new System.Windows.Forms.Label();
            this.Lbl_DireccionProveedor = new System.Windows.Forms.Label();
            this.Lbl_nitProveedor = new System.Windows.Forms.Label();
            this.Lbl_nombreProveedor = new System.Windows.Forms.Label();
            this.Lbl_TipoPago = new System.Windows.Forms.Label();
            this.cbo_tipo_pago = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Txt_NombreTarjetaCheque = new System.Windows.Forms.TextBox();
            this.Txt_NoTarjetaCheque = new System.Windows.Forms.TextBox();
            this.Lbl_NombreTarjetaCheque = new System.Windows.Forms.Label();
            this.Lbl_NoTarjetaCheque = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_compras)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dvg_compras
            // 
            this.Dvg_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvg_compras.Location = new System.Drawing.Point(51, 402);
            this.Dvg_compras.Name = "Dvg_compras";
            this.Dvg_compras.Size = new System.Drawing.Size(531, 256);
            this.Dvg_compras.TabIndex = 1;
            this.Dvg_compras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dvg_compras_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(212)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.Btn_minimizar);
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Controls.Add(this.Lbl_cuentasPagar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1181, 48);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.BackgroundImage")));
            this.Btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Location = new System.Drawing.Point(1067, 0);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(48, 48);
            this.Btn_minimizar.TabIndex = 18;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.BackgroundImage")));
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Location = new System.Drawing.Point(1121, 0);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(48, 48);
            this.Btn_cerrar.TabIndex = 17;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Lbl_cuentasPagar
            // 
            this.Lbl_cuentasPagar.AutoSize = true;
            this.Lbl_cuentasPagar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cuentasPagar.Location = new System.Drawing.Point(74, 16);
            this.Lbl_cuentasPagar.Name = "Lbl_cuentasPagar";
            this.Lbl_cuentasPagar.Size = new System.Drawing.Size(107, 19);
            this.Lbl_cuentasPagar.TabIndex = 6;
            this.Lbl_cuentasPagar.Text = "5500-PAGOS";
            // 
            // Btn_agregarOrden
            // 
            this.Btn_agregarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.Btn_agregarOrden.FlatAppearance.BorderSize = 0;
            this.Btn_agregarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregarOrden.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_agregarOrden.Image = ((System.Drawing.Image)(resources.GetObject("Btn_agregarOrden.Image")));
            this.Btn_agregarOrden.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_agregarOrden.Location = new System.Drawing.Point(67, 148);
            this.Btn_agregarOrden.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_agregarOrden.Name = "Btn_agregarOrden";
            this.Btn_agregarOrden.Size = new System.Drawing.Size(153, 33);
            this.Btn_agregarOrden.TabIndex = 11;
            this.Btn_agregarOrden.Text = "Abonar";
            this.Btn_agregarOrden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_agregarOrden.UseVisualStyleBackColor = false;
            this.Btn_agregarOrden.Click += new System.EventHandler(this.Btn_agregarOrden_Click);
            // 
            // Lbl_Abono
            // 
            this.Lbl_Abono.AutoSize = true;
            this.Lbl_Abono.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Abono.Location = new System.Drawing.Point(49, 92);
            this.Lbl_Abono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Abono.Name = "Lbl_Abono";
            this.Lbl_Abono.Size = new System.Drawing.Size(55, 19);
            this.Lbl_Abono.TabIndex = 13;
            this.Lbl_Abono.Text = "Abono";
            // 
            // Txt_Abono
            // 
            this.Txt_Abono.Location = new System.Drawing.Point(148, 93);
            this.Txt_Abono.Name = "Txt_Abono";
            this.Txt_Abono.Size = new System.Drawing.Size(121, 23);
            this.Txt_Abono.TabIndex = 14;
            // 
            // Lbl_Saldo
            // 
            this.Lbl_Saldo.AutoSize = true;
            this.Lbl_Saldo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Saldo.Location = new System.Drawing.Point(71, 41);
            this.Lbl_Saldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Saldo.Name = "Lbl_Saldo";
            this.Lbl_Saldo.Size = new System.Drawing.Size(48, 19);
            this.Lbl_Saldo.TabIndex = 15;
            this.Lbl_Saldo.Text = "Saldo";
            // 
            // Lbl_cantidadSaldo
            // 
            this.Lbl_cantidadSaldo.AutoSize = true;
            this.Lbl_cantidadSaldo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cantidadSaldo.Location = new System.Drawing.Point(187, 41);
            this.Lbl_cantidadSaldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_cantidadSaldo.Name = "Lbl_cantidadSaldo";
            this.Lbl_cantidadSaldo.Size = new System.Drawing.Size(29, 19);
            this.Lbl_cantidadSaldo.TabIndex = 16;
            this.Lbl_cantidadSaldo.Text = "0.0";
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Total.Location = new System.Drawing.Point(29, 90);
            this.Lbl_Total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(90, 19);
            this.Lbl_Total.TabIndex = 17;
            this.Lbl_Total.Text = "Monto Total";
            // 
            // Lbl_montoTotal
            // 
            this.Lbl_montoTotal.AutoSize = true;
            this.Lbl_montoTotal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_montoTotal.Location = new System.Drawing.Point(187, 90);
            this.Lbl_montoTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_montoTotal.Name = "Lbl_montoTotal";
            this.Lbl_montoTotal.Size = new System.Drawing.Size(29, 19);
            this.Lbl_montoTotal.TabIndex = 18;
            this.Lbl_montoTotal.Text = "0.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Codigo Orden Compra";
            // 
            // Txt_OrdenCompra
            // 
            this.Txt_OrdenCompra.Location = new System.Drawing.Point(201, 39);
            this.Txt_OrdenCompra.Name = "Txt_OrdenCompra";
            this.Txt_OrdenCompra.Size = new System.Drawing.Size(204, 23);
            this.Txt_OrdenCompra.TabIndex = 20;
            // 
            // Btn_buscarOrdenCompra
            // 
            this.Btn_buscarOrdenCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.Btn_buscarOrdenCompra.FlatAppearance.BorderSize = 0;
            this.Btn_buscarOrdenCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscarOrdenCompra.Image = ((System.Drawing.Image)(resources.GetObject("Btn_buscarOrdenCompra.Image")));
            this.Btn_buscarOrdenCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_buscarOrdenCompra.Location = new System.Drawing.Point(441, 23);
            this.Btn_buscarOrdenCompra.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_buscarOrdenCompra.Name = "Btn_buscarOrdenCompra";
            this.Btn_buscarOrdenCompra.Size = new System.Drawing.Size(104, 50);
            this.Btn_buscarOrdenCompra.TabIndex = 21;
            this.Btn_buscarOrdenCompra.Text = "Buscar";
            this.Btn_buscarOrdenCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_buscarOrdenCompra.UseVisualStyleBackColor = false;
            this.Btn_buscarOrdenCompra.Click += new System.EventHandler(this.Btn_buscarOrdenCompra_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_paisProveedor);
            this.groupBox1.Controls.Add(this.Txt_direccionProveedor);
            this.groupBox1.Controls.Add(this.Txt_nitProveedor);
            this.groupBox1.Controls.Add(this.Txt_nombreProveedor);
            this.groupBox1.Controls.Add(this.Lbl_PaisProveedor);
            this.groupBox1.Controls.Add(this.Lbl_DireccionProveedor);
            this.groupBox1.Controls.Add(this.Lbl_nitProveedor);
            this.groupBox1.Controls.Add(this.Lbl_nombreProveedor);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(51, 176);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 194);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Proveedor";
            // 
            // Txt_paisProveedor
            // 
            this.Txt_paisProveedor.Enabled = false;
            this.Txt_paisProveedor.Location = new System.Drawing.Point(107, 151);
            this.Txt_paisProveedor.Name = "Txt_paisProveedor";
            this.Txt_paisProveedor.Size = new System.Drawing.Size(121, 24);
            this.Txt_paisProveedor.TabIndex = 21;
            // 
            // Txt_direccionProveedor
            // 
            this.Txt_direccionProveedor.Enabled = false;
            this.Txt_direccionProveedor.Location = new System.Drawing.Point(107, 98);
            this.Txt_direccionProveedor.Name = "Txt_direccionProveedor";
            this.Txt_direccionProveedor.Size = new System.Drawing.Size(231, 24);
            this.Txt_direccionProveedor.TabIndex = 20;
            // 
            // Txt_nitProveedor
            // 
            this.Txt_nitProveedor.Enabled = false;
            this.Txt_nitProveedor.Location = new System.Drawing.Point(403, 47);
            this.Txt_nitProveedor.Name = "Txt_nitProveedor";
            this.Txt_nitProveedor.Size = new System.Drawing.Size(121, 24);
            this.Txt_nitProveedor.TabIndex = 19;
            // 
            // Txt_nombreProveedor
            // 
            this.Txt_nombreProveedor.Enabled = false;
            this.Txt_nombreProveedor.Location = new System.Drawing.Point(107, 47);
            this.Txt_nombreProveedor.Name = "Txt_nombreProveedor";
            this.Txt_nombreProveedor.Size = new System.Drawing.Size(231, 24);
            this.Txt_nombreProveedor.TabIndex = 18;
            // 
            // Lbl_PaisProveedor
            // 
            this.Lbl_PaisProveedor.AutoSize = true;
            this.Lbl_PaisProveedor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PaisProveedor.Location = new System.Drawing.Point(52, 154);
            this.Lbl_PaisProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PaisProveedor.Name = "Lbl_PaisProveedor";
            this.Lbl_PaisProveedor.Size = new System.Drawing.Size(35, 19);
            this.Lbl_PaisProveedor.TabIndex = 17;
            this.Lbl_PaisProveedor.Text = "Pais";
            // 
            // Lbl_DireccionProveedor
            // 
            this.Lbl_DireccionProveedor.AutoSize = true;
            this.Lbl_DireccionProveedor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DireccionProveedor.Location = new System.Drawing.Point(32, 101);
            this.Lbl_DireccionProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_DireccionProveedor.Name = "Lbl_DireccionProveedor";
            this.Lbl_DireccionProveedor.Size = new System.Drawing.Size(74, 19);
            this.Lbl_DireccionProveedor.TabIndex = 16;
            this.Lbl_DireccionProveedor.Text = "Direccion";
            // 
            // Lbl_nitProveedor
            // 
            this.Lbl_nitProveedor.AutoSize = true;
            this.Lbl_nitProveedor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nitProveedor.Location = new System.Drawing.Point(358, 50);
            this.Lbl_nitProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_nitProveedor.Name = "Lbl_nitProveedor";
            this.Lbl_nitProveedor.Size = new System.Drawing.Size(27, 19);
            this.Lbl_nitProveedor.TabIndex = 15;
            this.Lbl_nitProveedor.Text = "Nit";
            // 
            // Lbl_nombreProveedor
            // 
            this.Lbl_nombreProveedor.AutoSize = true;
            this.Lbl_nombreProveedor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_nombreProveedor.Location = new System.Drawing.Point(32, 50);
            this.Lbl_nombreProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_nombreProveedor.Name = "Lbl_nombreProveedor";
            this.Lbl_nombreProveedor.Size = new System.Drawing.Size(64, 19);
            this.Lbl_nombreProveedor.TabIndex = 14;
            this.Lbl_nombreProveedor.Text = "Nombre";
            // 
            // Lbl_TipoPago
            // 
            this.Lbl_TipoPago.AutoSize = true;
            this.Lbl_TipoPago.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TipoPago.Location = new System.Drawing.Point(5, 31);
            this.Lbl_TipoPago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_TipoPago.Name = "Lbl_TipoPago";
            this.Lbl_TipoPago.Size = new System.Drawing.Size(99, 19);
            this.Lbl_TipoPago.TabIndex = 23;
            this.Lbl_TipoPago.Text = "Tipo de Pago";
            // 
            // cbo_tipo_pago
            // 
            this.cbo_tipo_pago.FormattingEnabled = true;
            this.cbo_tipo_pago.Location = new System.Drawing.Point(148, 32);
            this.cbo_tipo_pago.Name = "cbo_tipo_pago";
            this.cbo_tipo_pago.Size = new System.Drawing.Size(121, 25);
            this.cbo_tipo_pago.TabIndex = 24;
            this.cbo_tipo_pago.SelectedIndexChanged += new System.EventHandler(this.cbo_tipo_pago_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lbl_TipoPago);
            this.groupBox2.Controls.Add(this.cbo_tipo_pago);
            this.groupBox2.Controls.Add(this.Txt_Abono);
            this.groupBox2.Controls.Add(this.Lbl_Abono);
            this.groupBox2.Controls.Add(this.Btn_agregarOrden);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(611, 176);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(288, 194);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pago";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Lbl_Total);
            this.groupBox3.Controls.Add(this.Lbl_Saldo);
            this.groupBox3.Controls.Add(this.Lbl_cantidadSaldo);
            this.groupBox3.Controls.Add(this.Lbl_montoTotal);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(905, 191);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 160);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totales";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.Txt_OrdenCompra);
            this.groupBox4.Controls.Add(this.Btn_buscarOrdenCompra);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(282, 54);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(577, 100);
            this.groupBox4.TabIndex = 27;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Busqueda de Orden de Compra";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Txt_NombreTarjetaCheque);
            this.groupBox5.Controls.Add(this.Txt_NoTarjetaCheque);
            this.groupBox5.Controls.Add(this.Lbl_NombreTarjetaCheque);
            this.groupBox5.Controls.Add(this.Lbl_NoTarjetaCheque);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(626, 402);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(533, 186);
            this.groupBox5.TabIndex = 28;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Datos de Pago";
            // 
            // Txt_NombreTarjetaCheque
            // 
            this.Txt_NombreTarjetaCheque.Location = new System.Drawing.Point(216, 103);
            this.Txt_NombreTarjetaCheque.Name = "Txt_NombreTarjetaCheque";
            this.Txt_NombreTarjetaCheque.Size = new System.Drawing.Size(300, 23);
            this.Txt_NombreTarjetaCheque.TabIndex = 27;
            // 
            // Txt_NoTarjetaCheque
            // 
            this.Txt_NoTarjetaCheque.Location = new System.Drawing.Point(216, 57);
            this.Txt_NoTarjetaCheque.Name = "Txt_NoTarjetaCheque";
            this.Txt_NoTarjetaCheque.Size = new System.Drawing.Size(300, 23);
            this.Txt_NoTarjetaCheque.TabIndex = 26;
            // 
            // Lbl_NombreTarjetaCheque
            // 
            this.Lbl_NombreTarjetaCheque.AutoSize = true;
            this.Lbl_NombreTarjetaCheque.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NombreTarjetaCheque.Location = new System.Drawing.Point(24, 107);
            this.Lbl_NombreTarjetaCheque.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_NombreTarjetaCheque.Name = "Lbl_NombreTarjetaCheque";
            this.Lbl_NombreTarjetaCheque.Size = new System.Drawing.Size(177, 19);
            this.Lbl_NombreTarjetaCheque.TabIndex = 25;
            this.Lbl_NombreTarjetaCheque.Text = "Nombre Tarjeta/Cheque";
            // 
            // Lbl_NoTarjetaCheque
            // 
            this.Lbl_NoTarjetaCheque.AutoSize = true;
            this.Lbl_NoTarjetaCheque.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_NoTarjetaCheque.Location = new System.Drawing.Point(24, 58);
            this.Lbl_NoTarjetaCheque.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_NoTarjetaCheque.Name = "Lbl_NoTarjetaCheque";
            this.Lbl_NoTarjetaCheque.Size = new System.Drawing.Size(176, 19);
            this.Lbl_NoTarjetaCheque.TabIndex = 24;
            this.Lbl_NoTarjetaCheque.Text = "Numero Tarjeta/Cheque";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::SAE_2019.Properties.Resources.boton_web_de_ayuda2;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(1052, 54);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 35);
            this.button2.TabIndex = 53;
            this.button2.Text = "Ayuda";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Frm_pagosCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 698);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dvg_compras);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_pagosCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_pagosCompras";
            this.Load += new System.EventHandler(this.Frm_pagosCompras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_compras)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView Dvg_compras;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_cuentasPagar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_agregarOrden;
        private System.Windows.Forms.Label Lbl_Abono;
        private System.Windows.Forms.TextBox Txt_Abono;
        private System.Windows.Forms.Label Lbl_Saldo;
        private System.Windows.Forms.Label Lbl_cantidadSaldo;
        private System.Windows.Forms.Label Lbl_Total;
        private System.Windows.Forms.Label Lbl_montoTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_OrdenCompra;
        private System.Windows.Forms.Button Btn_buscarOrdenCompra;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lbl_TipoPago;
        private System.Windows.Forms.ComboBox cbo_tipo_pago;
        private System.Windows.Forms.TextBox Txt_paisProveedor;
        private System.Windows.Forms.TextBox Txt_direccionProveedor;
        private System.Windows.Forms.TextBox Txt_nitProveedor;
        private System.Windows.Forms.TextBox Txt_nombreProveedor;
        private System.Windows.Forms.Label Lbl_PaisProveedor;
        private System.Windows.Forms.Label Lbl_DireccionProveedor;
        private System.Windows.Forms.Label Lbl_nitProveedor;
        private System.Windows.Forms.Label Lbl_nombreProveedor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox Txt_NombreTarjetaCheque;
        private System.Windows.Forms.TextBox Txt_NoTarjetaCheque;
        private System.Windows.Forms.Label Lbl_NombreTarjetaCheque;
        private System.Windows.Forms.Label Lbl_NoTarjetaCheque;
        private System.Windows.Forms.Button button2;
    }
}