namespace SAE_2019.Compras
{
    partial class Frm_ordenCompra
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ordenCompra));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_ordenCompra = new System.Windows.Forms.Label();
            this.Btn_iconoOrdenCompra = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_ingresoProducto = new System.Windows.Forms.Button();
            this.Dvg_orden = new System.Windows.Forms.DataGridView();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadUnitaria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lbl_fechaPedido = new System.Windows.Forms.Label();
            this.Dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.Lbl_cantidad = new System.Windows.Forms.Label();
            this.Lbl_montoTotal = new System.Windows.Forms.Label();
            this.Lbl_cant = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_monto = new System.Windows.Forms.Label();
            this.Btn_agregarOrden = new System.Windows.Forms.Button();
            this.Btn_eliminar = new System.Windows.Forms.Button();
            this.Btn_modificar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_orden)).BeginInit();
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
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 59);
            this.panel1.TabIndex = 0;
            // 
            // Lbl_ordenCompra
            // 
            this.Lbl_ordenCompra.AutoSize = true;
            this.Lbl_ordenCompra.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ordenCompra.Location = new System.Drawing.Point(99, 20);
            this.Lbl_ordenCompra.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_ordenCompra.Name = "Lbl_ordenCompra";
            this.Lbl_ordenCompra.Size = new System.Drawing.Size(203, 23);
            this.Lbl_ordenCompra.TabIndex = 4;
            this.Lbl_ordenCompra.Text = "ORDEN DE COMPRA";
            // 
            // Btn_iconoOrdenCompra
            // 
            this.Btn_iconoOrdenCompra.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_iconoOrdenCompra.BackgroundImage")));
            this.Btn_iconoOrdenCompra.Enabled = false;
            this.Btn_iconoOrdenCompra.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(74)))));
            this.Btn_iconoOrdenCompra.FlatAppearance.BorderSize = 0;
            this.Btn_iconoOrdenCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_iconoOrdenCompra.Location = new System.Drawing.Point(20, 5);
            this.Btn_iconoOrdenCompra.Name = "Btn_iconoOrdenCompra";
            this.Btn_iconoOrdenCompra.Size = new System.Drawing.Size(48, 48);
            this.Btn_iconoOrdenCompra.TabIndex = 13;
            this.Btn_iconoOrdenCompra.UseVisualStyleBackColor = true;
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.BackgroundImage")));
            this.Btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Location = new System.Drawing.Point(986, 0);
            this.Btn_minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(64, 59);
            this.Btn_minimizar.TabIndex = 14;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.BackgroundImage")));
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Location = new System.Drawing.Point(1078, 0);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(64, 59);
            this.Btn_cerrar.TabIndex = 15;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Btn_ingresoProducto
            // 
            this.Btn_ingresoProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.Btn_ingresoProducto.FlatAppearance.BorderSize = 0;
            this.Btn_ingresoProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ingresoProducto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_ingresoProducto.Image = ((System.Drawing.Image)(resources.GetObject("Btn_ingresoProducto.Image")));
            this.Btn_ingresoProducto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_ingresoProducto.Location = new System.Drawing.Point(20, 96);
            this.Btn_ingresoProducto.Name = "Btn_ingresoProducto";
            this.Btn_ingresoProducto.Size = new System.Drawing.Size(241, 51);
            this.Btn_ingresoProducto.TabIndex = 1;
            this.Btn_ingresoProducto.Text = "Ingreso producto";
            this.Btn_ingresoProducto.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_ingresoProducto.UseVisualStyleBackColor = false;
            // 
            // Dvg_orden
            // 
            this.Dvg_orden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dvg_orden.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.descripcion,
            this.proveedor,
            this.cantidadUnitaria,
            this.costo,
            this.existencia});
            this.Dvg_orden.Location = new System.Drawing.Point(20, 249);
            this.Dvg_orden.Name = "Dvg_orden";
            this.Dvg_orden.RowTemplate.Height = 24;
            this.Dvg_orden.Size = new System.Drawing.Size(918, 391);
            this.Dvg_orden.TabIndex = 2;
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
            // proveedor
            // 
            this.proveedor.HeaderText = "Proveedor";
            this.proveedor.Name = "proveedor";
            // 
            // cantidadUnitaria
            // 
            this.cantidadUnitaria.HeaderText = "Cantidad Unitaria";
            this.cantidadUnitaria.Name = "cantidadUnitaria";
            // 
            // costo
            // 
            this.costo.HeaderText = "Costo";
            this.costo.Name = "costo";
            // 
            // existencia
            // 
            this.existencia.HeaderText = "Existencias";
            this.existencia.Name = "existencia";
            // 
            // Lbl_fechaPedido
            // 
            this.Lbl_fechaPedido.AutoSize = true;
            this.Lbl_fechaPedido.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_fechaPedido.Location = new System.Drawing.Point(22, 169);
            this.Lbl_fechaPedido.Name = "Lbl_fechaPedido";
            this.Lbl_fechaPedido.Size = new System.Drawing.Size(128, 21);
            this.Lbl_fechaPedido.TabIndex = 3;
            this.Lbl_fechaPedido.Text = "Fecha pedido";
            // 
            // Dtp_fecha
            // 
            this.Dtp_fecha.Location = new System.Drawing.Point(167, 168);
            this.Dtp_fecha.Name = "Dtp_fecha";
            this.Dtp_fecha.Size = new System.Drawing.Size(200, 22);
            this.Dtp_fecha.TabIndex = 4;
            // 
            // Lbl_cantidad
            // 
            this.Lbl_cantidad.AutoSize = true;
            this.Lbl_cantidad.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cantidad.Location = new System.Drawing.Point(636, 672);
            this.Lbl_cantidad.Name = "Lbl_cantidad";
            this.Lbl_cantidad.Size = new System.Drawing.Size(138, 21);
            this.Lbl_cantidad.TabIndex = 5;
            this.Lbl_cantidad.Text = "Cantidad Total";
            // 
            // Lbl_montoTotal
            // 
            this.Lbl_montoTotal.AutoSize = true;
            this.Lbl_montoTotal.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_montoTotal.Location = new System.Drawing.Point(635, 719);
            this.Lbl_montoTotal.Name = "Lbl_montoTotal";
            this.Lbl_montoTotal.Size = new System.Drawing.Size(112, 21);
            this.Lbl_montoTotal.TabIndex = 6;
            this.Lbl_montoTotal.Text = "Monto Total";
            // 
            // Lbl_cant
            // 
            this.Lbl_cant.AutoSize = true;
            this.Lbl_cant.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_cant.Location = new System.Drawing.Point(805, 673);
            this.Lbl_cant.Name = "Lbl_cant";
            this.Lbl_cant.Size = new System.Drawing.Size(13, 20);
            this.Lbl_cant.TabIndex = 7;
            this.Lbl_cant.Text = ".";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(591, 466);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 20);
            this.label1.TabIndex = 8;
            // 
            // Lbl_monto
            // 
            this.Lbl_monto.AutoSize = true;
            this.Lbl_monto.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_monto.Location = new System.Drawing.Point(805, 719);
            this.Lbl_monto.Name = "Lbl_monto";
            this.Lbl_monto.Size = new System.Drawing.Size(13, 20);
            this.Lbl_monto.TabIndex = 9;
            this.Lbl_monto.Text = ".";
            // 
            // Btn_agregarOrden
            // 
            this.Btn_agregarOrden.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.Btn_agregarOrden.FlatAppearance.BorderSize = 0;
            this.Btn_agregarOrden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_agregarOrden.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_agregarOrden.Image = ((System.Drawing.Image)(resources.GetObject("Btn_agregarOrden.Image")));
            this.Btn_agregarOrden.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_agregarOrden.Location = new System.Drawing.Point(966, 249);
            this.Btn_agregarOrden.Name = "Btn_agregarOrden";
            this.Btn_agregarOrden.Size = new System.Drawing.Size(204, 41);
            this.Btn_agregarOrden.TabIndex = 10;
            this.Btn_agregarOrden.Text = "Agregar orden";
            this.Btn_agregarOrden.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_agregarOrden.UseVisualStyleBackColor = false;
            // 
            // Btn_eliminar
            // 
            this.Btn_eliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.Btn_eliminar.FlatAppearance.BorderSize = 0;
            this.Btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_eliminar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_eliminar.Image")));
            this.Btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_eliminar.Location = new System.Drawing.Point(966, 323);
            this.Btn_eliminar.Name = "Btn_eliminar";
            this.Btn_eliminar.Size = new System.Drawing.Size(204, 41);
            this.Btn_eliminar.TabIndex = 11;
            this.Btn_eliminar.Text = "Eliminar";
            this.Btn_eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_eliminar.UseVisualStyleBackColor = false;
            // 
            // Btn_modificar
            // 
            this.Btn_modificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.Btn_modificar.FlatAppearance.BorderSize = 0;
            this.Btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_modificar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_modificar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_modificar.Image")));
            this.Btn_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_modificar.Location = new System.Drawing.Point(966, 405);
            this.Btn_modificar.Name = "Btn_modificar";
            this.Btn_modificar.Size = new System.Drawing.Size(204, 41);
            this.Btn_modificar.TabIndex = 12;
            this.Btn_modificar.Text = "Eliminar";
            this.Btn_modificar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_modificar.UseVisualStyleBackColor = false;
            // 
            // Frm_ordenCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 953);
            this.Controls.Add(this.Btn_modificar);
            this.Controls.Add(this.Btn_eliminar);
            this.Controls.Add(this.Btn_agregarOrden);
            this.Controls.Add(this.Lbl_monto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_cant);
            this.Controls.Add(this.Lbl_montoTotal);
            this.Controls.Add(this.Lbl_cantidad);
            this.Controls.Add(this.Dtp_fecha);
            this.Controls.Add(this.Lbl_fechaPedido);
            this.Controls.Add(this.Dvg_orden);
            this.Controls.Add(this.Btn_ingresoProducto);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_ordenCompra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_ordenCompra";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dvg_orden)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_ordenCompra;
        private System.Windows.Forms.Button Btn_iconoOrdenCompra;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_ingresoProducto;
        private System.Windows.Forms.DataGridView Dvg_orden;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadUnitaria;
        private System.Windows.Forms.DataGridViewTextBoxColumn costo;
        private System.Windows.Forms.DataGridViewTextBoxColumn existencia;
        private System.Windows.Forms.Label Lbl_fechaPedido;
        private System.Windows.Forms.DateTimePicker Dtp_fecha;
        private System.Windows.Forms.Label Lbl_cantidad;
        private System.Windows.Forms.Label Lbl_montoTotal;
        private System.Windows.Forms.Label Lbl_cant;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_monto;
        private System.Windows.Forms.Button Btn_agregarOrden;
        private System.Windows.Forms.Button Btn_eliminar;
        private System.Windows.Forms.Button Btn_modificar;
    }
}