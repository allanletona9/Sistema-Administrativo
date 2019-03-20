namespace SAE_2019.Compras
{
    partial class Frm_mostrarFacturasCompras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_mostrarFacturasCompras));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_mostrarFacturas = new System.Windows.Forms.Label();
            this.Btn_iconomostrarFactura = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Dgv_mostrarFacturas = new System.Windows.Forms.DataGridView();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_factura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cod_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre_proveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_mostrarFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(212)))), ((int)(((byte)(126)))));
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Controls.Add(this.Btn_minimizar);
            this.panel1.Controls.Add(this.Btn_iconomostrarFactura);
            this.panel1.Controls.Add(this.Lbl_mostrarFacturas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1082, 59);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Lbl_mostrarFacturas
            // 
            this.Lbl_mostrarFacturas.AutoSize = true;
            this.Lbl_mostrarFacturas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_mostrarFacturas.Location = new System.Drawing.Point(99, 20);
            this.Lbl_mostrarFacturas.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_mostrarFacturas.Name = "Lbl_mostrarFacturas";
            this.Lbl_mostrarFacturas.Size = new System.Drawing.Size(193, 23);
            this.Lbl_mostrarFacturas.TabIndex = 2;
            this.Lbl_mostrarFacturas.Text = "LISTA DE FACTURAS";
            // 
            // Btn_iconomostrarFactura
            // 
            this.Btn_iconomostrarFactura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_iconomostrarFactura.BackgroundImage")));
            this.Btn_iconomostrarFactura.Enabled = false;
            this.Btn_iconomostrarFactura.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(88)))), ((int)(((byte)(74)))));
            this.Btn_iconomostrarFactura.FlatAppearance.BorderSize = 0;
            this.Btn_iconomostrarFactura.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_iconomostrarFactura.Location = new System.Drawing.Point(20, 5);
            this.Btn_iconomostrarFactura.Name = "Btn_iconomostrarFactura";
            this.Btn_iconomostrarFactura.Size = new System.Drawing.Size(48, 48);
            this.Btn_iconomostrarFactura.TabIndex = 11;
            this.Btn_iconomostrarFactura.UseVisualStyleBackColor = true;
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.BackgroundImage")));
            this.Btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Location = new System.Drawing.Point(884, 0);
            this.Btn_minimizar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(64, 59);
            this.Btn_minimizar.TabIndex = 12;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.BackgroundImage")));
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Location = new System.Drawing.Point(976, 0);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(64, 59);
            this.Btn_cerrar.TabIndex = 13;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Dgv_mostrarFacturas
            // 
            this.Dgv_mostrarFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_mostrarFacturas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.fecha,
            this.cod_factura,
            this.tipo_factura,
            this.cod_proveedor,
            this.nombre_proveedor});
            this.Dgv_mostrarFacturas.Location = new System.Drawing.Point(52, 119);
            this.Dgv_mostrarFacturas.Name = "Dgv_mostrarFacturas";
            this.Dgv_mostrarFacturas.RowTemplate.Height = 24;
            this.Dgv_mostrarFacturas.Size = new System.Drawing.Size(988, 493);
            this.Dgv_mostrarFacturas.TabIndex = 1;
            this.Dgv_mostrarFacturas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_mostrarFacturas_CellContentClick);
            this.Dgv_mostrarFacturas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_mostrarFacturas_CellDoubleClick);
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha";
            this.fecha.Name = "fecha";
            // 
            // cod_factura
            // 
            this.cod_factura.HeaderText = "Código de Factura";
            this.cod_factura.Name = "cod_factura";
            // 
            // tipo_factura
            // 
            this.tipo_factura.HeaderText = "Tipo de Factura";
            this.tipo_factura.Name = "tipo_factura";
            // 
            // cod_proveedor
            // 
            this.cod_proveedor.HeaderText = "Código de proveedor";
            this.cod_proveedor.Name = "cod_proveedor";
            // 
            // nombre_proveedor
            // 
            this.nombre_proveedor.HeaderText = "Proveedor";
            this.nombre_proveedor.Name = "nombre_proveedor";
            // 
            // Frm_mostrarFacturasCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1082, 653);
            this.Controls.Add(this.Dgv_mostrarFacturas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_mostrarFacturasCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_mostrarFacturasCompras";
            this.Load += new System.EventHandler(this.Frm_mostrarFacturasCompras_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_mostrarFacturas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_mostrarFacturas;
        private System.Windows.Forms.Button Btn_iconomostrarFactura;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.DataGridView Dgv_mostrarFacturas;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn cod_proveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_proveedor;
    }
}