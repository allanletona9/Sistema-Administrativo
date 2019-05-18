namespace SAE_2019.Inventario
{
    partial class Frm_devoluciones_ventas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_devoluciones_ventas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_iconoOrdenCompra = new System.Windows.Forms.Button();
            this.Lbl_devol = new System.Windows.Forms.Label();
            this.dgv_fac = new System.Windows.Forms.DataGridView();
            this.cbx_facturas = new System.Windows.Forms.ComboBox();
            this.Lbl_noOrden = new System.Windows.Forms.Label();
            this.dvg_devolucion = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_serie = new System.Windows.Forms.Label();
            this.txt_Idc = new System.Windows.Forms.TextBox();
            this.txt_nomCliente = new System.Windows.Forms.TextBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.lbl_cantidad = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbx_emp = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Txt_nodevolucion = new System.Windows.Forms.TextBox();
            this.txt_descr = new System.Windows.Forms.TextBox();
            this.Txt_estado = new System.Windows.Forms.TextBox();
            this.txtfechaR = new System.Windows.Forms.TextBox();
            this.txt_id = new System.Windows.Forms.TextBox();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.lbl_dev = new System.Windows.Forms.Label();
            this.lbl_sucursal = new System.Windows.Forms.Label();
            this.txt_sucursal = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_nomemp = new System.Windows.Forms.Label();
            this.lbl_sucur = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fac)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_devolucion)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(212)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Controls.Add(this.Btn_minimizar);
            this.panel1.Controls.Add(this.Btn_iconoOrdenCompra);
            this.panel1.Controls.Add(this.Lbl_devol);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1117, 48);
            this.panel1.TabIndex = 2;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.BackgroundImage")));
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Location = new System.Drawing.Point(1031, -1);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(48, 48);
            this.Btn_cerrar.TabIndex = 15;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.BackgroundImage")));
            this.Btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Location = new System.Drawing.Point(977, 0);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(48, 48);
            this.Btn_minimizar.TabIndex = 14;
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
            // Lbl_devol
            // 
            this.Lbl_devol.AutoSize = true;
            this.Lbl_devol.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_devol.Location = new System.Drawing.Point(74, 16);
            this.Lbl_devol.Name = "Lbl_devol";
            this.Lbl_devol.Size = new System.Drawing.Size(323, 19);
            this.Lbl_devol.TabIndex = 4;
            this.Lbl_devol.Text = "2400-GESTION DE DEVOLUCIONES VENTAS";
            // 
            // dgv_fac
            // 
            this.dgv_fac.AllowUserToAddRows = false;
            this.dgv_fac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_fac.Location = new System.Drawing.Point(8, 347);
            this.dgv_fac.Name = "dgv_fac";
            this.dgv_fac.ReadOnly = true;
            this.dgv_fac.RowHeadersVisible = false;
            this.dgv_fac.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_fac.Size = new System.Drawing.Size(504, 173);
            this.dgv_fac.TabIndex = 68;
            this.dgv_fac.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_fac_CellContentClick);
            // 
            // cbx_facturas
            // 
            this.cbx_facturas.FormattingEnabled = true;
            this.cbx_facturas.Location = new System.Drawing.Point(146, 223);
            this.cbx_facturas.Name = "cbx_facturas";
            this.cbx_facturas.Size = new System.Drawing.Size(121, 21);
            this.cbx_facturas.TabIndex = 70;
            this.cbx_facturas.SelectedIndexChanged += new System.EventHandler(this.cbx_facturas_SelectedIndexChanged);
            // 
            // Lbl_noOrden
            // 
            this.Lbl_noOrden.AutoSize = true;
            this.Lbl_noOrden.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_noOrden.Location = new System.Drawing.Point(27, 225);
            this.Lbl_noOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_noOrden.Name = "Lbl_noOrden";
            this.Lbl_noOrden.Size = new System.Drawing.Size(90, 19);
            this.Lbl_noOrden.TabIndex = 66;
            this.Lbl_noOrden.Text = "No. Factura";
            // 
            // dvg_devolucion
            // 
            this.dvg_devolucion.AllowUserToAddRows = false;
            this.dvg_devolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_devolucion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dvg_devolucion.Location = new System.Drawing.Point(601, 347);
            this.dvg_devolucion.Name = "dvg_devolucion";
            this.dvg_devolucion.RowHeadersVisible = false;
            this.dvg_devolucion.Size = new System.Drawing.Size(504, 173);
            this.dvg_devolucion.TabIndex = 71;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID Producto";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Nombre Producto";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Total";
            this.Column5.Name = "Column5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 289);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 74;
            this.label1.Text = "ID Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(311, 287);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 19);
            this.label2.TabIndex = 75;
            this.label2.Text = "Nombre Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(739, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 76;
            this.label3.Text = "No. Serie";
            // 
            // lbl_serie
            // 
            this.lbl_serie.AutoSize = true;
            this.lbl_serie.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_serie.ForeColor = System.Drawing.Color.Red;
            this.lbl_serie.Location = new System.Drawing.Point(825, 76);
            this.lbl_serie.Name = "lbl_serie";
            this.lbl_serie.Size = new System.Drawing.Size(0, 29);
            this.lbl_serie.TabIndex = 77;
            // 
            // txt_Idc
            // 
            this.txt_Idc.Location = new System.Drawing.Point(112, 288);
            this.txt_Idc.Name = "txt_Idc";
            this.txt_Idc.Size = new System.Drawing.Size(156, 20);
            this.txt_Idc.TabIndex = 78;
            // 
            // txt_nomCliente
            // 
            this.txt_nomCliente.Location = new System.Drawing.Point(471, 286);
            this.txt_nomCliente.Name = "txt_nomCliente";
            this.txt_nomCliente.Size = new System.Drawing.Size(223, 20);
            this.txt_nomCliente.TabIndex = 79;
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Location = new System.Drawing.Point(527, 374);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(63, 20);
            this.txt_cantidad.TabIndex = 80;
            // 
            // lbl_cantidad
            // 
            this.lbl_cantidad.AutoSize = true;
            this.lbl_cantidad.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantidad.Location = new System.Drawing.Point(519, 347);
            this.lbl_cantidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_cantidad.Name = "lbl_cantidad";
            this.lbl_cantidad.Size = new System.Drawing.Size(77, 19);
            this.lbl_cantidad.TabIndex = 81;
            this.lbl_cantidad.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(482, 84);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 19);
            this.label5.TabIndex = 90;
            this.label5.Text = "Fecha";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(731, 220);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 19);
            this.label4.TabIndex = 87;
            this.label4.Text = "Descripcion";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(53, 155);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 19);
            this.label6.TabIndex = 86;
            this.label6.Text = "Empleado";
            // 
            // cbx_emp
            // 
            this.cbx_emp.FormattingEnabled = true;
            this.cbx_emp.Location = new System.Drawing.Point(148, 153);
            this.cbx_emp.Name = "cbx_emp";
            this.cbx_emp.Size = new System.Drawing.Size(142, 21);
            this.cbx_emp.TabIndex = 85;
            this.cbx_emp.SelectedIndexChanged += new System.EventHandler(this.cbx_emp_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 108);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 19);
            this.label7.TabIndex = 84;
            this.label7.Text = "No. Devolucion";
            // 
            // Txt_nodevolucion
            // 
            this.Txt_nodevolucion.Location = new System.Drawing.Point(148, 108);
            this.Txt_nodevolucion.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_nodevolucion.Name = "Txt_nodevolucion";
            this.Txt_nodevolucion.ReadOnly = true;
            this.Txt_nodevolucion.Size = new System.Drawing.Size(120, 20);
            this.Txt_nodevolucion.TabIndex = 83;
            // 
            // txt_descr
            // 
            this.txt_descr.Location = new System.Drawing.Point(725, 266);
            this.txt_descr.Margin = new System.Windows.Forms.Padding(2);
            this.txt_descr.Multiline = true;
            this.txt_descr.Name = "txt_descr";
            this.txt_descr.Size = new System.Drawing.Size(300, 54);
            this.txt_descr.TabIndex = 82;
            // 
            // Txt_estado
            // 
            this.Txt_estado.Location = new System.Drawing.Point(46, 110);
            this.Txt_estado.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_estado.Name = "Txt_estado";
            this.Txt_estado.Size = new System.Drawing.Size(25, 20);
            this.Txt_estado.TabIndex = 88;
            this.Txt_estado.Text = "1";
            this.Txt_estado.Visible = false;
            // 
            // txtfechaR
            // 
            this.txtfechaR.Location = new System.Drawing.Point(472, 107);
            this.txtfechaR.Name = "txtfechaR";
            this.txtfechaR.Size = new System.Drawing.Size(160, 20);
            this.txtfechaR.TabIndex = 91;
            // 
            // txt_id
            // 
            this.txt_id.Location = new System.Drawing.Point(180, 153);
            this.txt_id.Name = "txt_id";
            this.txt_id.Size = new System.Drawing.Size(54, 20);
            this.txt_id.TabIndex = 92;
            this.txt_id.TextChanged += new System.EventHandler(this.txt_id_TextChanged);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.Btn_guardar.FlatAppearance.BorderSize = 0;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.Image = global::SAE_2019.Properties.Resources.icons8_factura_48;
            this.Btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_guardar.Location = new System.Drawing.Point(592, 546);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(185, 56);
            this.Btn_guardar.TabIndex = 72;
            this.Btn_guardar.Text = "Confirmar Devolucion";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // lbl_dev
            // 
            this.lbl_dev.AutoSize = true;
            this.lbl_dev.Font = new System.Drawing.Font("Modern No. 20", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dev.ForeColor = System.Drawing.Color.Red;
            this.lbl_dev.Location = new System.Drawing.Point(428, 223);
            this.lbl_dev.Name = "lbl_dev";
            this.lbl_dev.Size = new System.Drawing.Size(0, 14);
            this.lbl_dev.TabIndex = 94;
            // 
            // lbl_sucursal
            // 
            this.lbl_sucursal.AutoSize = true;
            this.lbl_sucursal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sucursal.Location = new System.Drawing.Point(691, 152);
            this.lbl_sucursal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_sucursal.Name = "lbl_sucursal";
            this.lbl_sucursal.Size = new System.Drawing.Size(65, 19);
            this.lbl_sucursal.TabIndex = 96;
            this.lbl_sucursal.Text = "Sucursal";
            // 
            // txt_sucursal
            // 
            this.txt_sucursal.Location = new System.Drawing.Point(764, 153);
            this.txt_sucursal.Name = "txt_sucursal";
            this.txt_sucursal.Size = new System.Drawing.Size(170, 20);
            this.txt_sucursal.TabIndex = 97;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(461, 154);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(171, 20);
            this.txt_nombre.TabIndex = 98;
            // 
            // lbl_nomemp
            // 
            this.lbl_nomemp.AutoSize = true;
            this.lbl_nomemp.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nomemp.Location = new System.Drawing.Point(374, 152);
            this.lbl_nomemp.Name = "lbl_nomemp";
            this.lbl_nomemp.Size = new System.Drawing.Size(68, 20);
            this.lbl_nomemp.TabIndex = 99;
            this.lbl_nomemp.Text = "Nombre";
            // 
            // lbl_sucur
            // 
            this.lbl_sucur.AutoSize = true;
            this.lbl_sucur.Location = new System.Drawing.Point(772, 156);
            this.lbl_sucur.Name = "lbl_sucur";
            this.lbl_sucur.Size = new System.Drawing.Size(35, 13);
            this.lbl_sucur.TabIndex = 100;
            this.lbl_sucur.Text = "label8";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(297, 210);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 44);
            this.button1.TabIndex = 67;
            this.button1.Text = "Buscar Factura";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Image = global::SAE_2019.Properties.Resources.icons8_editar_archivo_48;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.Location = new System.Drawing.Point(316, 546);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(185, 56);
            this.button2.TabIndex = 93;
            this.button2.Text = "Solicitar Devolucion";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar.Image")));
            this.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_agregar.Location = new System.Drawing.Point(517, 399);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(73, 121);
            this.btn_agregar.TabIndex = 73;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // Frm_devoluciones_ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 613);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbl_nomemp);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.txt_sucursal);
            this.Controls.Add(this.lbl_sucursal);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtfechaR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbx_emp);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_nodevolucion);
            this.Controls.Add(this.txt_descr);
            this.Controls.Add(this.Txt_estado);
            this.Controls.Add(this.lbl_cantidad);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.txt_nomCliente);
            this.Controls.Add(this.txt_Idc);
            this.Controls.Add(this.lbl_serie);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.dvg_devolucion);
            this.Controls.Add(this.dgv_fac);
            this.Controls.Add(this.cbx_facturas);
            this.Controls.Add(this.Lbl_noOrden);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt_id);
            this.Controls.Add(this.lbl_sucur);
            this.Controls.Add(this.lbl_dev);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_devoluciones_ventas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_devoluciones_ventas";
            this.Load += new System.EventHandler(this.Frm_devoluciones_ventas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_fac)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_devolucion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_iconoOrdenCompra;
        private System.Windows.Forms.Label Lbl_devol;
        private System.Windows.Forms.ComboBox cbx_facturas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Lbl_noOrden;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_serie;
        private System.Windows.Forms.TextBox txt_Idc;
        private System.Windows.Forms.TextBox txt_nomCliente;
        public System.Windows.Forms.DataGridView dgv_fac;
        public System.Windows.Forms.DataGridView dvg_devolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label lbl_cantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbx_emp;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Txt_nodevolucion;
        private System.Windows.Forms.TextBox txt_descr;
        private System.Windows.Forms.TextBox Txt_estado;
        private System.Windows.Forms.TextBox txtfechaR;
        private System.Windows.Forms.TextBox txt_id;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbl_dev;
        private System.Windows.Forms.Label lbl_sucursal;
        private System.Windows.Forms.TextBox txt_sucursal;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_nomemp;
        private System.Windows.Forms.Label lbl_sucur;
    }
}