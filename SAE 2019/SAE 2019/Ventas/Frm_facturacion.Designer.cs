namespace SAE_2019.Facturacion
{
    partial class Frm_facturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_facturacion));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_titulo = new System.Windows.Forms.Label();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_codCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Txt_cliente = new System.Windows.Forms.TextBox();
            this.Txt_codProd = new System.Windows.Forms.TextBox();
            this.Txt_descProd = new System.Windows.Forms.TextBox();
            this.Txt_precioProducto = new System.Windows.Forms.TextBox();
            this.Txt_cantidadProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Dgv_factura = new System.Windows.Forms.DataGridView();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_colocar = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_consultaCliente = new System.Windows.Forms.Button();
            this.Btn_consultaProducto = new System.Windows.Forms.Button();
            this.Btn_nuevaFactura = new System.Windows.Forms.Button();
            this.Btn_facturacion = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.Lbl_total = new System.Windows.Forms.Label();
            this.Lbl_usuario = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.Txt_noSerie = new System.Windows.Forms.TextBox();
            this.Txt_fecha = new System.Windows.Forms.TextBox();
            this.Txt_costoProducto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.Rbtn_cotizacion = new System.Windows.Forms.RadioButton();
            this.Rbtn_facturacion = new System.Windows.Forms.RadioButton();
            this.Btn_ayuda = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_factura)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(128)))), ((int)(((byte)(191)))));
            this.panel1.Controls.Add(this.Lbl_titulo);
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Controls.Add(this.Btn_minimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 59);
            this.panel1.TabIndex = 0;
            // 
            // Lbl_titulo
            // 
            this.Lbl_titulo.AutoSize = true;
            this.Lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_titulo.Location = new System.Drawing.Point(30, 20);
            this.Lbl_titulo.Name = "Lbl_titulo";
            this.Lbl_titulo.Size = new System.Drawing.Size(153, 23);
            this.Lbl_titulo.TabIndex = 18;
            this.Lbl_titulo.Text = "FACTURACIÓN";
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
            this.Btn_cerrar.TabIndex = 17;
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
            this.Btn_minimizar.Location = new System.Drawing.Point(949, 0);
            this.Btn_minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(64, 59);
            this.Btn_minimizar.TabIndex = 15;
            this.Btn_minimizar.TabStop = false;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(31, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Le atiende:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(31, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Código cliente:";
            // 
            // Txt_codCliente
            // 
            this.Txt_codCliente.Location = new System.Drawing.Point(191, 133);
            this.Txt_codCliente.Name = "Txt_codCliente";
            this.Txt_codCliente.Size = new System.Drawing.Size(119, 22);
            this.Txt_codCliente.TabIndex = 4;
            this.Txt_codCliente.TextChanged += new System.EventHandler(this.Txt_codCliente_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cliente:";
            // 
            // Txt_cliente
            // 
            this.Txt_cliente.Location = new System.Drawing.Point(142, 176);
            this.Txt_cliente.Name = "Txt_cliente";
            this.Txt_cliente.Size = new System.Drawing.Size(218, 22);
            this.Txt_cliente.TabIndex = 7;
            // 
            // Txt_codProd
            // 
            this.Txt_codProd.Location = new System.Drawing.Point(33, 240);
            this.Txt_codProd.Name = "Txt_codProd";
            this.Txt_codProd.Size = new System.Drawing.Size(145, 22);
            this.Txt_codProd.TabIndex = 8;
            // 
            // Txt_descProd
            // 
            this.Txt_descProd.Location = new System.Drawing.Point(204, 240);
            this.Txt_descProd.Name = "Txt_descProd";
            this.Txt_descProd.Size = new System.Drawing.Size(145, 22);
            this.Txt_descProd.TabIndex = 9;
            // 
            // Txt_precioProducto
            // 
            this.Txt_precioProducto.Location = new System.Drawing.Point(376, 240);
            this.Txt_precioProducto.Name = "Txt_precioProducto";
            this.Txt_precioProducto.Size = new System.Drawing.Size(145, 22);
            this.Txt_precioProducto.TabIndex = 10;
            // 
            // Txt_cantidadProducto
            // 
            this.Txt_cantidadProducto.Location = new System.Drawing.Point(715, 240);
            this.Txt_cantidadProducto.Name = "Txt_cantidadProducto";
            this.Txt_cantidadProducto.Size = new System.Drawing.Size(145, 22);
            this.Txt_cantidadProducto.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 21);
            this.label5.TabIndex = 12;
            this.label5.Text = "Código producto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(221, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 21);
            this.label6.TabIndex = 13;
            this.label6.Text = "Descripción";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(416, 216);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 21);
            this.label7.TabIndex = 14;
            this.label7.Text = "Precio";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(741, 216);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 21);
            this.label8.TabIndex = 15;
            this.label8.Text = "Cantidad";
            // 
            // Dgv_factura
            // 
            this.Dgv_factura.AllowUserToAddRows = false;
            this.Dgv_factura.AllowUserToDeleteRows = false;
            this.Dgv_factura.AllowUserToResizeColumns = false;
            this.Dgv_factura.AllowUserToResizeRows = false;
            this.Dgv_factura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_factura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_factura.ColumnHeadersVisible = false;
            this.Dgv_factura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProducto,
            this.descProducto,
            this.precioProducto,
            this.costoProducto,
            this.cantidadProducto,
            this.importeProducto});
            this.Dgv_factura.Location = new System.Drawing.Point(33, 313);
            this.Dgv_factura.Name = "Dgv_factura";
            this.Dgv_factura.ReadOnly = true;
            this.Dgv_factura.RowHeadersVisible = false;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Dgv_factura.RowsDefaultCellStyle = dataGridViewCellStyle12;
            this.Dgv_factura.RowTemplate.Height = 24;
            this.Dgv_factura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_factura.Size = new System.Drawing.Size(827, 342);
            this.Dgv_factura.TabIndex = 16;
            // 
            // idProducto
            // 
            this.idProducto.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.idProducto.HeaderText = "ID";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            this.idProducto.Width = 125;
            // 
            // descProducto
            // 
            this.descProducto.HeaderText = "Descripción";
            this.descProducto.Name = "descProducto";
            this.descProducto.ReadOnly = true;
            // 
            // precioProducto
            // 
            this.precioProducto.HeaderText = "Precio";
            this.precioProducto.Name = "precioProducto";
            this.precioProducto.ReadOnly = true;
            // 
            // costoProducto
            // 
            this.costoProducto.HeaderText = "Costo";
            this.costoProducto.Name = "costoProducto";
            this.costoProducto.ReadOnly = true;
            // 
            // cantidadProducto
            // 
            this.cantidadProducto.HeaderText = "Cantidad";
            this.cantidadProducto.Name = "cantidadProducto";
            this.cantidadProducto.ReadOnly = true;
            // 
            // importeProducto
            // 
            this.importeProducto.HeaderText = "Importe";
            this.importeProducto.Name = "importeProducto";
            this.importeProducto.ReadOnly = true;
            // 
            // Btn_colocar
            // 
            this.Btn_colocar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(126)))), ((int)(((byte)(204)))));
            this.Btn_colocar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_colocar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_colocar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_colocar.Location = new System.Drawing.Point(883, 271);
            this.Btn_colocar.Name = "Btn_colocar";
            this.Btn_colocar.Size = new System.Drawing.Size(202, 41);
            this.Btn_colocar.TabIndex = 17;
            this.Btn_colocar.Text = "Colocar";
            this.Btn_colocar.UseVisualStyleBackColor = false;
            this.Btn_colocar.Click += new System.EventHandler(this.Btn_colocar_Click);
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(126)))), ((int)(((byte)(204)))));
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_eliminar.Location = new System.Drawing.Point(883, 334);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(202, 41);
            this.Btn_eliminar.TabIndex = 18;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            this.Btn_eliminar.Click += new System.EventHandler(this.Btn_eliminar_Click);
            // 
            // Btn_consultaCliente
            // 
            this.Btn_consultaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(126)))), ((int)(((byte)(204)))));
            this.Btn_consultaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultaCliente.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultaCliente.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_consultaCliente.Location = new System.Drawing.Point(883, 396);
            this.Btn_consultaCliente.Name = "Btn_consultaCliente";
            this.Btn_consultaCliente.Size = new System.Drawing.Size(202, 41);
            this.Btn_consultaCliente.TabIndex = 19;
            this.Btn_consultaCliente.Text = "Clientes";
            this.Btn_consultaCliente.UseVisualStyleBackColor = false;
            this.Btn_consultaCliente.Click += new System.EventHandler(this.Btn_consultaCliente_Click);
            // 
            // Btn_consultaProducto
            // 
            this.Btn_consultaProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(126)))), ((int)(((byte)(204)))));
            this.Btn_consultaProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consultaProducto.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consultaProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_consultaProducto.Location = new System.Drawing.Point(883, 461);
            this.Btn_consultaProducto.Name = "Btn_consultaProducto";
            this.Btn_consultaProducto.Size = new System.Drawing.Size(202, 41);
            this.Btn_consultaProducto.TabIndex = 20;
            this.Btn_consultaProducto.Text = "Productos";
            this.Btn_consultaProducto.UseVisualStyleBackColor = false;
            this.Btn_consultaProducto.Click += new System.EventHandler(this.Btn_consultaProducto_Click);
            // 
            // Btn_nuevaFactura
            // 
            this.Btn_nuevaFactura.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(126)))), ((int)(((byte)(204)))));
            this.Btn_nuevaFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_nuevaFactura.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_nuevaFactura.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_nuevaFactura.Location = new System.Drawing.Point(883, 524);
            this.Btn_nuevaFactura.Name = "Btn_nuevaFactura";
            this.Btn_nuevaFactura.Size = new System.Drawing.Size(202, 41);
            this.Btn_nuevaFactura.TabIndex = 21;
            this.Btn_nuevaFactura.Text = "Nueva factura";
            this.Btn_nuevaFactura.UseVisualStyleBackColor = false;
            this.Btn_nuevaFactura.Click += new System.EventHandler(this.Btn_nuevaFactura_Click);
            // 
            // Btn_facturacion
            // 
            this.Btn_facturacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(126)))), ((int)(((byte)(204)))));
            this.Btn_facturacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_facturacion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_facturacion.Location = new System.Drawing.Point(883, 592);
            this.Btn_facturacion.Name = "Btn_facturacion";
            this.Btn_facturacion.Size = new System.Drawing.Size(202, 41);
            this.Btn_facturacion.TabIndex = 22;
            this.Btn_facturacion.Text = "Facturar";
            this.Btn_facturacion.UseVisualStyleBackColor = false;
            this.Btn_facturacion.Click += new System.EventHandler(this.Btn_facturacion_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(631, 665);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 21);
            this.label9.TabIndex = 23;
            this.label9.Text = "Total: ";
            // 
            // Lbl_total
            // 
            this.Lbl_total.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Lbl_total.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_total.Location = new System.Drawing.Point(715, 658);
            this.Lbl_total.Name = "Lbl_total";
            this.Lbl_total.Size = new System.Drawing.Size(145, 33);
            this.Lbl_total.TabIndex = 24;
            this.Lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Lbl_usuario
            // 
            this.Lbl_usuario.BackColor = System.Drawing.SystemColors.Control;
            this.Lbl_usuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Lbl_usuario.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_usuario.Location = new System.Drawing.Point(151, 87);
            this.Lbl_usuario.Name = "Lbl_usuario";
            this.Lbl_usuario.Size = new System.Drawing.Size(110, 34);
            this.Lbl_usuario.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(692, 65);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 21);
            this.label11.TabIndex = 26;
            this.label11.Text = "No. serie:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(692, 99);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 21);
            this.label12.TabIndex = 27;
            this.label12.Text = "Fecha:";
            // 
            // Txt_noSerie
            // 
            this.Txt_noSerie.Enabled = false;
            this.Txt_noSerie.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_noSerie.Location = new System.Drawing.Point(795, 64);
            this.Txt_noSerie.Name = "Txt_noSerie";
            this.Txt_noSerie.Size = new System.Drawing.Size(119, 28);
            this.Txt_noSerie.TabIndex = 28;
            // 
            // Txt_fecha
            // 
            this.Txt_fecha.Enabled = false;
            this.Txt_fecha.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_fecha.Location = new System.Drawing.Point(795, 99);
            this.Txt_fecha.Name = "Txt_fecha";
            this.Txt_fecha.Size = new System.Drawing.Size(119, 28);
            this.Txt_fecha.TabIndex = 29;
            // 
            // Txt_costoProducto
            // 
            this.Txt_costoProducto.Location = new System.Drawing.Point(547, 240);
            this.Txt_costoProducto.Name = "Txt_costoProducto";
            this.Txt_costoProducto.Size = new System.Drawing.Size(145, 22);
            this.Txt_costoProducto.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(594, 216);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(60, 21);
            this.label13.TabIndex = 31;
            this.label13.Text = "Costo";
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(128)))), ((int)(((byte)(191)))));
            this.label14.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(31, 274);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(162, 39);
            this.label14.TabIndex = 32;
            this.label14.Text = "Código producto";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(128)))), ((int)(((byte)(191)))));
            this.label15.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(187, 274);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(162, 39);
            this.label15.TabIndex = 33;
            this.label15.Text = "Descripción";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(128)))), ((int)(((byte)(191)))));
            this.label16.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(345, 274);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(112, 39);
            this.label16.TabIndex = 34;
            this.label16.Text = "Precio";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(128)))), ((int)(((byte)(191)))));
            this.label17.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(453, 274);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(151, 39);
            this.label17.TabIndex = 35;
            this.label17.Text = "Costo";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(128)))), ((int)(((byte)(191)))));
            this.label18.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(594, 274);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(134, 39);
            this.label18.TabIndex = 36;
            this.label18.Text = "Cantidad";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(128)))), ((int)(((byte)(191)))));
            this.label19.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(715, 274);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(145, 39);
            this.label19.TabIndex = 37;
            this.label19.Text = "Importe";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Rbtn_cotizacion
            // 
            this.Rbtn_cotizacion.AutoSize = true;
            this.Rbtn_cotizacion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_cotizacion.Location = new System.Drawing.Point(959, 139);
            this.Rbtn_cotizacion.Name = "Rbtn_cotizacion";
            this.Rbtn_cotizacion.Size = new System.Drawing.Size(117, 23);
            this.Rbtn_cotizacion.TabIndex = 38;
            this.Rbtn_cotizacion.TabStop = true;
            this.Rbtn_cotizacion.Text = "Cotización";
            this.Rbtn_cotizacion.UseVisualStyleBackColor = true;
            this.Rbtn_cotizacion.CheckedChanged += new System.EventHandler(this.Rbtn_cotizacion_CheckedChanged);
            // 
            // Rbtn_facturacion
            // 
            this.Rbtn_facturacion.AutoSize = true;
            this.Rbtn_facturacion.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rbtn_facturacion.Location = new System.Drawing.Point(959, 174);
            this.Rbtn_facturacion.Name = "Rbtn_facturacion";
            this.Rbtn_facturacion.Size = new System.Drawing.Size(126, 23);
            this.Rbtn_facturacion.TabIndex = 39;
            this.Rbtn_facturacion.TabStop = true;
            this.Rbtn_facturacion.Text = "Facturación";
            this.Rbtn_facturacion.UseVisualStyleBackColor = true;
            this.Rbtn_facturacion.CheckedChanged += new System.EventHandler(this.Rbtn_facturacion_CheckedChanged);
            // 
            // Btn_ayuda
            // 
            this.Btn_ayuda.BackColor = System.Drawing.Color.Gray;
            this.Btn_ayuda.FlatAppearance.BorderSize = 0;
            this.Btn_ayuda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ayuda.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ayuda.Image = global::SAE_2019.Properties.Resources.boton_web_de_ayuda2;
            this.Btn_ayuda.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ayuda.Location = new System.Drawing.Point(954, 64);
            this.Btn_ayuda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_ayuda.Name = "Btn_ayuda";
            this.Btn_ayuda.Size = new System.Drawing.Size(171, 41);
            this.Btn_ayuda.TabIndex = 54;
            this.Btn_ayuda.Text = "Ayuda";
            this.Btn_ayuda.UseVisualStyleBackColor = false;
            // 
            // Frm_facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 700);
            this.Controls.Add(this.Btn_ayuda);
            this.Controls.Add(this.Rbtn_facturacion);
            this.Controls.Add(this.Rbtn_cotizacion);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.Txt_costoProducto);
            this.Controls.Add(this.Txt_fecha);
            this.Controls.Add(this.Txt_noSerie);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.Lbl_usuario);
            this.Controls.Add(this.Lbl_total);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.Btn_facturacion);
            this.Controls.Add(this.Btn_nuevaFactura);
            this.Controls.Add(this.Btn_consultaProducto);
            this.Controls.Add(this.Btn_consultaCliente);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_colocar);
            this.Controls.Add(this.Dgv_factura);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Txt_cantidadProducto);
            this.Controls.Add(this.Txt_precioProducto);
            this.Controls.Add(this.Txt_descProd);
            this.Controls.Add(this.Txt_codProd);
            this.Controls.Add(this.Txt_cliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Txt_codCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_facturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_facturacion";
            this.Load += new System.EventHandler(this.Frm_facturacion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_factura)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_titulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_codCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Txt_cliente;
        private System.Windows.Forms.TextBox Txt_codProd;
        private System.Windows.Forms.TextBox Txt_descProd;
        private System.Windows.Forms.TextBox Txt_precioProducto;
        private System.Windows.Forms.TextBox Txt_cantidadProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView Dgv_factura;
        private System.Windows.Forms.Button Btn_colocar;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_consultaCliente;
        private System.Windows.Forms.Button Btn_consultaProducto;
        private System.Windows.Forms.Button Btn_nuevaFactura;
        private System.Windows.Forms.Button Btn_facturacion;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label Lbl_total;
        private System.Windows.Forms.Label Lbl_usuario;
        private System.Windows.Forms.TextBox Txt_fecha;
        private System.Windows.Forms.TextBox Txt_noSerie;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox Txt_costoProducto;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn descProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn costoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn importeProducto;
        private System.Windows.Forms.RadioButton Rbtn_cotizacion;
        private System.Windows.Forms.RadioButton Rbtn_facturacion;
        private System.Windows.Forms.Button Btn_ayuda;
    }
}