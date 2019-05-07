namespace SAE_2019.Ventas
{
    partial class Frm_cuentas_cobrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_cuentas_cobrar));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Txt_NombreTarjetaCheque = new System.Windows.Forms.TextBox();
            this.Txt_NoTarjetaCheque = new System.Windows.Forms.TextBox();
            this.Lbl_NombreTarjetaCheque = new System.Windows.Forms.Label();
            this.Lbl_NoTarjetaCheque = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_NoFactura = new System.Windows.Forms.TextBox();
            this.Btn_buscarOrdenCompra = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_montototal = new System.Windows.Forms.TextBox();
            this.txt_saldo = new System.Windows.Forms.TextBox();
            this.Lbl_Total = new System.Windows.Forms.Label();
            this.Lbl_Saldo = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Lbl_TipoPago = new System.Windows.Forms.Label();
            this.cbo_tipo_pago = new System.Windows.Forms.ComboBox();
            this.Txt_Abono = new System.Windows.Forms.TextBox();
            this.Btn_cobrar = new System.Windows.Forms.Button();
            this.Lbl_Abono = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txt_dpi = new System.Windows.Forms.TextBox();
            this.Txt_Nit = new System.Windows.Forms.TextBox();
            this.Txt_NombreCliente = new System.Windows.Forms.TextBox();
            this.Lbl_PaisProveedor = new System.Windows.Forms.Label();
            this.Lbl_DireccionProveedor = new System.Windows.Forms.Label();
            this.Lbl_nombreProveedor = new System.Windows.Forms.Label();
            this.Dvg_compras = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_compras)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(128)))), ((int)(((byte)(191)))));
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1356, 48);
            this.panel1.TabIndex = 0;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.BackgroundImage")));
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Location = new System.Drawing.Point(1306, 3);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(48, 48);
            this.Btn_cerrar.TabIndex = 62;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Gray;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::SAE_2019.Properties.Resources.boton_web_de_ayuda2;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(1212, 77);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 35);
            this.button2.TabIndex = 61;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Txt_NombreTarjetaCheque);
            this.groupBox5.Controls.Add(this.Txt_NoTarjetaCheque);
            this.groupBox5.Controls.Add(this.Lbl_NombreTarjetaCheque);
            this.groupBox5.Controls.Add(this.Lbl_NoTarjetaCheque);
            this.groupBox5.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(75, 266);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(539, 186);
            this.groupBox5.TabIndex = 60;
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
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.Txt_NoFactura);
            this.groupBox4.Controls.Add(this.Btn_buscarOrdenCompra);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(403, 68);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(577, 100);
            this.groupBox4.TabIndex = 59;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Busqueda de Factura";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 38);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Numero de Factura";
            // 
            // Txt_NoFactura
            // 
            this.Txt_NoFactura.Location = new System.Drawing.Point(201, 39);
            this.Txt_NoFactura.Name = "Txt_NoFactura";
            this.Txt_NoFactura.Size = new System.Drawing.Size(204, 23);
            this.Txt_NoFactura.TabIndex = 20;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_montototal);
            this.groupBox3.Controls.Add(this.txt_saldo);
            this.groupBox3.Controls.Add(this.Lbl_Total);
            this.groupBox3.Controls.Add(this.Lbl_Saldo);
            this.groupBox3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(354, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(264, 160);
            this.groupBox3.TabIndex = 58;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Totales";
            // 
            // txt_montototal
            // 
            this.txt_montototal.Enabled = false;
            this.txt_montototal.Location = new System.Drawing.Point(121, 89);
            this.txt_montototal.Name = "txt_montototal";
            this.txt_montototal.Size = new System.Drawing.Size(125, 23);
            this.txt_montototal.TabIndex = 19;
            // 
            // txt_saldo
            // 
            this.txt_saldo.Enabled = false;
            this.txt_saldo.Location = new System.Drawing.Point(121, 52);
            this.txt_saldo.Name = "txt_saldo";
            this.txt_saldo.Size = new System.Drawing.Size(125, 23);
            this.txt_saldo.TabIndex = 18;
            // 
            // Lbl_Total
            // 
            this.Lbl_Total.AutoSize = true;
            this.Lbl_Total.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Total.Location = new System.Drawing.Point(5, 93);
            this.Lbl_Total.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Total.Name = "Lbl_Total";
            this.Lbl_Total.Size = new System.Drawing.Size(90, 19);
            this.Lbl_Total.TabIndex = 17;
            this.Lbl_Total.Text = "Monto Total";
            // 
            // Lbl_Saldo
            // 
            this.Lbl_Saldo.AutoSize = true;
            this.Lbl_Saldo.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Saldo.Location = new System.Drawing.Point(5, 56);
            this.Lbl_Saldo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Saldo.Name = "Lbl_Saldo";
            this.Lbl_Saldo.Size = new System.Drawing.Size(48, 19);
            this.Lbl_Saldo.TabIndex = 15;
            this.Lbl_Saldo.Text = "Saldo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lbl_TipoPago);
            this.groupBox2.Controls.Add(this.cbo_tipo_pago);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.Txt_Abono);
            this.groupBox2.Controls.Add(this.Btn_cobrar);
            this.groupBox2.Controls.Add(this.Lbl_Abono);
            this.groupBox2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(653, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 487);
            this.groupBox2.TabIndex = 57;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pago";
            // 
            // Lbl_TipoPago
            // 
            this.Lbl_TipoPago.AutoSize = true;
            this.Lbl_TipoPago.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_TipoPago.Location = new System.Drawing.Point(43, 40);
            this.Lbl_TipoPago.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_TipoPago.Name = "Lbl_TipoPago";
            this.Lbl_TipoPago.Size = new System.Drawing.Size(99, 19);
            this.Lbl_TipoPago.TabIndex = 23;
            this.Lbl_TipoPago.Text = "Tipo de Pago";
            // 
            // cbo_tipo_pago
            // 
            this.cbo_tipo_pago.FormattingEnabled = true;
            this.cbo_tipo_pago.Location = new System.Drawing.Point(176, 39);
            this.cbo_tipo_pago.Name = "cbo_tipo_pago";
            this.cbo_tipo_pago.Size = new System.Drawing.Size(121, 25);
            this.cbo_tipo_pago.TabIndex = 24;
            this.cbo_tipo_pago.SelectedIndexChanged += new System.EventHandler(this.cbo_tipo_pago_SelectedIndexChanged);
            // 
            // Txt_Abono
            // 
            this.Txt_Abono.Location = new System.Drawing.Point(176, 127);
            this.Txt_Abono.Name = "Txt_Abono";
            this.Txt_Abono.Size = new System.Drawing.Size(121, 23);
            this.Txt_Abono.TabIndex = 14;
            // 
            // Btn_cobrar
            // 
            this.Btn_cobrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.Btn_cobrar.FlatAppearance.BorderSize = 0;
            this.Btn_cobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cobrar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_cobrar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_cobrar.Image")));
            this.Btn_cobrar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_cobrar.Location = new System.Drawing.Point(115, 187);
            this.Btn_cobrar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_cobrar.Name = "Btn_cobrar";
            this.Btn_cobrar.Size = new System.Drawing.Size(173, 33);
            this.Btn_cobrar.TabIndex = 11;
            this.Btn_cobrar.Text = "Realizar Cobro";
            this.Btn_cobrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_cobrar.UseVisualStyleBackColor = false;
            this.Btn_cobrar.Click += new System.EventHandler(this.Btn_cobrar_Click);
            // 
            // Lbl_Abono
            // 
            this.Lbl_Abono.AutoSize = true;
            this.Lbl_Abono.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Abono.Location = new System.Drawing.Point(71, 128);
            this.Lbl_Abono.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_Abono.Name = "Lbl_Abono";
            this.Lbl_Abono.Size = new System.Drawing.Size(55, 19);
            this.Lbl_Abono.TabIndex = 13;
            this.Lbl_Abono.Text = "Abono";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txt_dpi);
            this.groupBox1.Controls.Add(this.Txt_Nit);
            this.groupBox1.Controls.Add(this.Txt_NombreCliente);
            this.groupBox1.Controls.Add(this.Lbl_PaisProveedor);
            this.groupBox1.Controls.Add(this.Lbl_DireccionProveedor);
            this.groupBox1.Controls.Add(this.Lbl_nombreProveedor);
            this.groupBox1.Font = new System.Drawing.Font("Century Gothic", 10.2F);
            this.groupBox1.Location = new System.Drawing.Point(95, 191);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(531, 194);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente";
            // 
            // Txt_dpi
            // 
            this.Txt_dpi.Enabled = false;
            this.Txt_dpi.Location = new System.Drawing.Point(130, 149);
            this.Txt_dpi.Name = "Txt_dpi";
            this.Txt_dpi.Size = new System.Drawing.Size(231, 24);
            this.Txt_dpi.TabIndex = 21;
            // 
            // Txt_Nit
            // 
            this.Txt_Nit.Enabled = false;
            this.Txt_Nit.Location = new System.Drawing.Point(130, 98);
            this.Txt_Nit.Name = "Txt_Nit";
            this.Txt_Nit.Size = new System.Drawing.Size(326, 24);
            this.Txt_Nit.TabIndex = 20;
            // 
            // Txt_NombreCliente
            // 
            this.Txt_NombreCliente.Enabled = false;
            this.Txt_NombreCliente.Location = new System.Drawing.Point(130, 47);
            this.Txt_NombreCliente.Name = "Txt_NombreCliente";
            this.Txt_NombreCliente.Size = new System.Drawing.Size(326, 24);
            this.Txt_NombreCliente.TabIndex = 18;
            // 
            // Lbl_PaisProveedor
            // 
            this.Lbl_PaisProveedor.AutoSize = true;
            this.Lbl_PaisProveedor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PaisProveedor.Location = new System.Drawing.Point(52, 154);
            this.Lbl_PaisProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_PaisProveedor.Name = "Lbl_PaisProveedor";
            this.Lbl_PaisProveedor.Size = new System.Drawing.Size(30, 19);
            this.Lbl_PaisProveedor.TabIndex = 17;
            this.Lbl_PaisProveedor.Text = "DPI";
            // 
            // Lbl_DireccionProveedor
            // 
            this.Lbl_DireccionProveedor.AutoSize = true;
            this.Lbl_DireccionProveedor.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DireccionProveedor.Location = new System.Drawing.Point(55, 101);
            this.Lbl_DireccionProveedor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_DireccionProveedor.Name = "Lbl_DireccionProveedor";
            this.Lbl_DireccionProveedor.Size = new System.Drawing.Size(27, 19);
            this.Lbl_DireccionProveedor.TabIndex = 16;
            this.Lbl_DireccionProveedor.Text = "NIT";
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
            // Dvg_compras
            // 
            this.Dvg_compras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dvg_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvg_compras.Enabled = false;
            this.Dvg_compras.Location = new System.Drawing.Point(141, 406);
            this.Dvg_compras.Name = "Dvg_compras";
            this.Dvg_compras.Size = new System.Drawing.Size(485, 319);
            this.Dvg_compras.TabIndex = 54;
            this.Dvg_compras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dvg_compras_CellContentClick);
            // 
            // Frm_cuentas_cobrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 744);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Dvg_compras);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_cuentas_cobrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_cuentas_cobrar";
            this.Load += new System.EventHandler(this.Frm_cuentas_cobrar_Load);
            this.panel1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_compras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox Txt_NombreTarjetaCheque;
        private System.Windows.Forms.TextBox Txt_NoTarjetaCheque;
        private System.Windows.Forms.Label Lbl_NombreTarjetaCheque;
        private System.Windows.Forms.Label Lbl_NoTarjetaCheque;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_NoFactura;
        private System.Windows.Forms.Button Btn_buscarOrdenCompra;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label Lbl_Total;
        private System.Windows.Forms.Label Lbl_Saldo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label Lbl_TipoPago;
        private System.Windows.Forms.TextBox Txt_Abono;
        private System.Windows.Forms.Button Btn_cobrar;
        private System.Windows.Forms.ComboBox cbo_tipo_pago;
        private System.Windows.Forms.Label Lbl_Abono;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_dpi;
        private System.Windows.Forms.TextBox Txt_Nit;
        private System.Windows.Forms.TextBox Txt_NombreCliente;
        private System.Windows.Forms.Label Lbl_PaisProveedor;
        private System.Windows.Forms.Label Lbl_DireccionProveedor;
        private System.Windows.Forms.Label Lbl_nombreProveedor;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.TextBox txt_montototal;
        private System.Windows.Forms.TextBox txt_saldo;
        public System.Windows.Forms.DataGridView Dvg_compras;
    }
}