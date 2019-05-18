namespace SAE_2019.Ventas
{
    partial class Frm_gestionInv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_gestionInv));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_consulta = new System.Windows.Forms.Button();
            this.Dgv_compraDetalle = new System.Windows.Forms.DataGridView();
            this.idCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lineaDetalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_idCompra = new System.Windows.Forms.TextBox();
            this.Txt_fechaPedido = new System.Windows.Forms.TextBox();
            this.Btn_agregarDetalle = new System.Windows.Forms.Button();
            this.Btn_limpiar = new System.Windows.Forms.Button();
            this.Btn_agregarInv = new System.Windows.Forms.Button();
            this.Lbl_idSucursal = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_compraDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(128)))), ((int)(((byte)(191)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Btn_minimizar);
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 59);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 23);
            this.label1.TabIndex = 19;
            this.label1.Text = "GESTIÓN DE INVENTARIO";
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.BackgroundImage")));
            this.Btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Location = new System.Drawing.Point(900, 0);
            this.Btn_minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(64, 59);
            this.Btn_minimizar.TabIndex = 17;
            this.Btn_minimizar.TabStop = false;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.BackgroundImage")));
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Location = new System.Drawing.Point(1000, 0);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(64, 59);
            this.Btn_cerrar.TabIndex = 16;
            this.Btn_cerrar.TabStop = false;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Btn_consulta
            // 
            this.Btn_consulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_consulta.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_consulta.Location = new System.Drawing.Point(742, 198);
            this.Btn_consulta.Name = "Btn_consulta";
            this.Btn_consulta.Size = new System.Drawing.Size(222, 66);
            this.Btn_consulta.TabIndex = 1;
            this.Btn_consulta.Text = "Consultar compras";
            this.Btn_consulta.UseVisualStyleBackColor = true;
            this.Btn_consulta.Click += new System.EventHandler(this.Btn_consulta_Click);
            // 
            // Dgv_compraDetalle
            // 
            this.Dgv_compraDetalle.AllowUserToAddRows = false;
            this.Dgv_compraDetalle.AllowUserToDeleteRows = false;
            this.Dgv_compraDetalle.AllowUserToResizeColumns = false;
            this.Dgv_compraDetalle.AllowUserToResizeRows = false;
            this.Dgv_compraDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_compraDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_compraDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCompra,
            this.idProducto,
            this.lineaDetalle,
            this.precio,
            this.cantidad});
            this.Dgv_compraDetalle.Location = new System.Drawing.Point(47, 235);
            this.Dgv_compraDetalle.Name = "Dgv_compraDetalle";
            this.Dgv_compraDetalle.RowHeadersVisible = false;
            this.Dgv_compraDetalle.RowTemplate.Height = 24;
            this.Dgv_compraDetalle.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_compraDetalle.Size = new System.Drawing.Size(657, 326);
            this.Dgv_compraDetalle.TabIndex = 2;
            // 
            // idCompra
            // 
            this.idCompra.HeaderText = "ID compra";
            this.idCompra.Name = "idCompra";
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "ID producto";
            this.idProducto.Name = "idProducto";
            // 
            // lineaDetalle
            // 
            this.lineaDetalle.HeaderText = "Línea";
            this.lineaDetalle.Name = "lineaDetalle";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Id de compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(51, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha de pedido:";
            // 
            // Txt_idCompra
            // 
            this.Txt_idCompra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_idCompra.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_idCompra.Location = new System.Drawing.Point(236, 117);
            this.Txt_idCompra.Name = "Txt_idCompra";
            this.Txt_idCompra.Size = new System.Drawing.Size(173, 21);
            this.Txt_idCompra.TabIndex = 5;
            this.Txt_idCompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Txt_fechaPedido
            // 
            this.Txt_fechaPedido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Txt_fechaPedido.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_fechaPedido.Location = new System.Drawing.Point(236, 168);
            this.Txt_fechaPedido.Name = "Txt_fechaPedido";
            this.Txt_fechaPedido.Size = new System.Drawing.Size(173, 21);
            this.Txt_fechaPedido.TabIndex = 6;
            this.Txt_fechaPedido.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_agregarDetalle
            // 
            this.Btn_agregarDetalle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregarDetalle.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_agregarDetalle.Location = new System.Drawing.Point(742, 298);
            this.Btn_agregarDetalle.Name = "Btn_agregarDetalle";
            this.Btn_agregarDetalle.Size = new System.Drawing.Size(222, 66);
            this.Btn_agregarDetalle.TabIndex = 7;
            this.Btn_agregarDetalle.Text = "Agregar detalle de compra";
            this.Btn_agregarDetalle.UseVisualStyleBackColor = true;
            this.Btn_agregarDetalle.Click += new System.EventHandler(this.Btn_agregarDetalle_Click);
            // 
            // Btn_limpiar
            // 
            this.Btn_limpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_limpiar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_limpiar.Location = new System.Drawing.Point(742, 394);
            this.Btn_limpiar.Name = "Btn_limpiar";
            this.Btn_limpiar.Size = new System.Drawing.Size(222, 66);
            this.Btn_limpiar.TabIndex = 8;
            this.Btn_limpiar.Text = "Nuevo";
            this.Btn_limpiar.UseVisualStyleBackColor = true;
            this.Btn_limpiar.Click += new System.EventHandler(this.Btn_limpiar_Click);
            // 
            // Btn_agregarInv
            // 
            this.Btn_agregarInv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregarInv.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_agregarInv.Location = new System.Drawing.Point(742, 498);
            this.Btn_agregarInv.Name = "Btn_agregarInv";
            this.Btn_agregarInv.Size = new System.Drawing.Size(222, 66);
            this.Btn_agregarInv.TabIndex = 9;
            this.Btn_agregarInv.Text = "Añadir al inventario";
            this.Btn_agregarInv.UseVisualStyleBackColor = true;
            this.Btn_agregarInv.Click += new System.EventHandler(this.Btn_agregarInv_Click);
            // 
            // Lbl_idSucursal
            // 
            this.Lbl_idSucursal.AutoSize = true;
            this.Lbl_idSucursal.Location = new System.Drawing.Point(443, 122);
            this.Lbl_idSucursal.Name = "Lbl_idSucursal";
            this.Lbl_idSucursal.Size = new System.Drawing.Size(46, 17);
            this.Lbl_idSucursal.TabIndex = 10;
            this.Lbl_idSucursal.Text = "label4";
            this.Lbl_idSucursal.Visible = false;
            // 
            // Frm_gestionInv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.Lbl_idSucursal);
            this.Controls.Add(this.Btn_agregarInv);
            this.Controls.Add(this.Btn_limpiar);
            this.Controls.Add(this.Btn_agregarDetalle);
            this.Controls.Add(this.Txt_fechaPedido);
            this.Controls.Add(this.Txt_idCompra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dgv_compraDetalle);
            this.Controls.Add(this.Btn_consulta);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_gestionInv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_gestionInv";
            this.Load += new System.EventHandler(this.Frm_gestionInv_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_compraDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_consulta;
        private System.Windows.Forms.DataGridView Dgv_compraDetalle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_idCompra;
        private System.Windows.Forms.TextBox Txt_fechaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn lineaDetalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.Button Btn_agregarDetalle;
        private System.Windows.Forms.Button Btn_limpiar;
        private System.Windows.Forms.Button Btn_agregarInv;
        private System.Windows.Forms.Label Lbl_idSucursal;
    }
}