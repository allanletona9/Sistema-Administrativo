namespace SAE_2019.Compras
{
    partial class Frm_pedidoProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_pedidoProductos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_pedidoProductos = new System.Windows.Forms.Label();
            this.Btn_iconopedidoProducto = new System.Windows.Forms.Button();
            this.Lbl_proveedores = new System.Windows.Forms.Label();
            this.Cmb_proveedores = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existenciasBodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_cantidad = new System.Windows.Forms.Label();
            this.Num_cantidad = new System.Windows.Forms.NumericUpDown();
            this.Btn_agregar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_cantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(212)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.Btn_iconopedidoProducto);
            this.panel1.Controls.Add(this.Lbl_pedidoProductos);
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Controls.Add(this.Btn_minimizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(982, 59);
            this.panel1.TabIndex = 0;
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.BackgroundImage")));
            this.Btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Location = new System.Drawing.Point(770, 0);
            this.Btn_minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(64, 59);
            this.Btn_minimizar.TabIndex = 13;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.BackgroundImage")));
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Location = new System.Drawing.Point(862, 0);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(64, 59);
            this.Btn_cerrar.TabIndex = 14;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Lbl_pedidoProductos
            // 
            this.Lbl_pedidoProductos.AutoSize = true;
            this.Lbl_pedidoProductos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_pedidoProductos.Location = new System.Drawing.Point(99, 20);
            this.Lbl_pedidoProductos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_pedidoProductos.Name = "Lbl_pedidoProductos";
            this.Lbl_pedidoProductos.Size = new System.Drawing.Size(236, 23);
            this.Lbl_pedidoProductos.TabIndex = 15;
            this.Lbl_pedidoProductos.Text = "PEDIDO DE PRODUCTOS";
            // 
            // Btn_iconopedidoProducto
            // 
            this.Btn_iconopedidoProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_iconopedidoProducto.BackgroundImage")));
            this.Btn_iconopedidoProducto.Enabled = false;
            this.Btn_iconopedidoProducto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(74)))));
            this.Btn_iconopedidoProducto.FlatAppearance.BorderSize = 0;
            this.Btn_iconopedidoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_iconopedidoProducto.Location = new System.Drawing.Point(20, 5);
            this.Btn_iconopedidoProducto.Name = "Btn_iconopedidoProducto";
            this.Btn_iconopedidoProducto.Size = new System.Drawing.Size(48, 48);
            this.Btn_iconopedidoProducto.TabIndex = 16;
            this.Btn_iconopedidoProducto.UseVisualStyleBackColor = true;
            // 
            // Lbl_proveedores
            // 
            this.Lbl_proveedores.AutoSize = true;
            this.Lbl_proveedores.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_proveedores.Location = new System.Drawing.Point(99, 86);
            this.Lbl_proveedores.Name = "Lbl_proveedores";
            this.Lbl_proveedores.Size = new System.Drawing.Size(97, 21);
            this.Lbl_proveedores.TabIndex = 1;
            this.Lbl_proveedores.Text = "Proveedor";
            // 
            // Cmb_proveedores
            // 
            this.Cmb_proveedores.FormattingEnabled = true;
            this.Cmb_proveedores.Location = new System.Drawing.Point(238, 87);
            this.Cmb_proveedores.Name = "Cmb_proveedores";
            this.Cmb_proveedores.Size = new System.Drawing.Size(266, 24);
            this.Cmb_proveedores.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoProducto,
            this.producto,
            this.proveedor,
            this.precio,
            this.existenciasBodega});
            this.dataGridView1.Location = new System.Drawing.Point(20, 244);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(728, 293);
            this.dataGridView1.TabIndex = 3;
            // 
            // codigoProducto
            // 
            this.codigoProducto.HeaderText = "Cod. Producto";
            this.codigoProducto.Name = "codigoProducto";
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            // 
            // proveedor
            // 
            this.proveedor.HeaderText = "Proveedor";
            this.proveedor.Name = "proveedor";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio U";
            this.precio.Name = "precio";
            // 
            // existenciasBodega
            // 
            this.existenciasBodega.HeaderText = "Existencias en Bodega";
            this.existenciasBodega.Name = "existenciasBodega";
            // 
            // Lbl_cantidad
            // 
            this.Lbl_cantidad.AutoSize = true;
            this.Lbl_cantidad.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cantidad.Location = new System.Drawing.Point(36, 149);
            this.Lbl_cantidad.Name = "Lbl_cantidad";
            this.Lbl_cantidad.Size = new System.Drawing.Size(92, 21);
            this.Lbl_cantidad.TabIndex = 4;
            this.Lbl_cantidad.Text = "Cantidad";
            // 
            // Num_cantidad
            // 
            this.Num_cantidad.Location = new System.Drawing.Point(153, 151);
            this.Num_cantidad.Name = "Num_cantidad";
            this.Num_cantidad.Size = new System.Drawing.Size(120, 22);
            this.Num_cantidad.TabIndex = 5;
            // 
            // Btn_agregar
            // 
            this.Btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.Btn_agregar.FlatAppearance.BorderSize = 0;
            this.Btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_agregar.Image")));
            this.Btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_agregar.Location = new System.Drawing.Point(345, 147);
            this.Btn_agregar.Name = "Btn_agregar";
            this.Btn_agregar.Size = new System.Drawing.Size(223, 62);
            this.Btn_agregar.TabIndex = 6;
            this.Btn_agregar.Text = "Agregar nuevo producto";
            this.Btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_agregar.UseVisualStyleBackColor = false;
            // 
            // Frm_pedidoProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 600);
            this.Controls.Add(this.Btn_agregar);
            this.Controls.Add(this.Num_cantidad);
            this.Controls.Add(this.Lbl_cantidad);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Cmb_proveedores);
            this.Controls.Add(this.Lbl_proveedores);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_pedidoProductos";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_pedidoProductos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Num_cantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label Lbl_pedidoProductos;
        private System.Windows.Forms.Button Btn_iconopedidoProducto;
        private System.Windows.Forms.Label Lbl_proveedores;
        private System.Windows.Forms.ComboBox Cmb_proveedores;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn existenciasBodega;
        private System.Windows.Forms.Label Lbl_cantidad;
        private System.Windows.Forms.NumericUpDown Num_cantidad;
        private System.Windows.Forms.Button Btn_agregar;
    }
}