namespace SAE_2019.Ventas
{
    partial class Frm_consultaCompraE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_consultaCompraE));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Dgv_consultaCompra = new System.Windows.Forms.DataGridView();
            this.idCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProveedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_buscarCompra = new System.Windows.Forms.TextBox();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_seleccionar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaCompra)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(128)))), ((int)(((byte)(191)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 59);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 23);
            this.label1.TabIndex = 18;
            this.label1.Text = "CONSULTA DE COMPRAS";
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.BackgroundImage")));
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Location = new System.Drawing.Point(930, 0);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(64, 59);
            this.Btn_cerrar.TabIndex = 16;
            this.Btn_cerrar.TabStop = false;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Dgv_consultaCompra
            // 
            this.Dgv_consultaCompra.AllowUserToAddRows = false;
            this.Dgv_consultaCompra.AllowUserToDeleteRows = false;
            this.Dgv_consultaCompra.AllowUserToResizeColumns = false;
            this.Dgv_consultaCompra.AllowUserToResizeRows = false;
            this.Dgv_consultaCompra.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_consultaCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consultaCompra.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCompra,
            this.idProveedor,
            this.idSucursal,
            this.fechaPedido,
            this.total});
            this.Dgv_consultaCompra.Location = new System.Drawing.Point(41, 140);
            this.Dgv_consultaCompra.Name = "Dgv_consultaCompra";
            this.Dgv_consultaCompra.RowHeadersVisible = false;
            this.Dgv_consultaCompra.RowTemplate.Height = 24;
            this.Dgv_consultaCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_consultaCompra.Size = new System.Drawing.Size(880, 364);
            this.Dgv_consultaCompra.TabIndex = 1;
            // 
            // idCompra
            // 
            this.idCompra.FillWeight = 57.01254F;
            this.idCompra.HeaderText = "Id Compra";
            this.idCompra.Name = "idCompra";
            // 
            // idProveedor
            // 
            this.idProveedor.FillWeight = 81.09981F;
            this.idProveedor.HeaderText = "Id Proveedor";
            this.idProveedor.Name = "idProveedor";
            // 
            // idSucursal
            // 
            this.idSucursal.FillWeight = 102.4405F;
            this.idSucursal.HeaderText = "Id Sucursal";
            this.idSucursal.Name = "idSucursal";
            // 
            // fechaPedido
            // 
            this.fechaPedido.FillWeight = 121.3478F;
            this.fechaPedido.HeaderText = "Fecha del pedido";
            this.fechaPedido.Name = "fechaPedido";
            // 
            // total
            // 
            this.total.FillWeight = 138.0993F;
            this.total.HeaderText = "Total";
            this.total.Name = "total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha de la compra:";
            // 
            // Txt_buscarCompra
            // 
            this.Txt_buscarCompra.Location = new System.Drawing.Point(257, 90);
            this.Txt_buscarCompra.Name = "Txt_buscarCompra";
            this.Txt_buscarCompra.Size = new System.Drawing.Size(563, 22);
            this.Txt_buscarCompra.TabIndex = 4;
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar.Location = new System.Drawing.Point(826, 89);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(95, 35);
            this.Btn_buscar.TabIndex = 7;
            this.Btn_buscar.Text = "BUSCAR";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Btn_seleccionar
            // 
            this.Btn_seleccionar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_seleccionar.Location = new System.Drawing.Point(684, 524);
            this.Btn_seleccionar.Name = "Btn_seleccionar";
            this.Btn_seleccionar.Size = new System.Drawing.Size(237, 45);
            this.Btn_seleccionar.TabIndex = 8;
            this.Btn_seleccionar.Text = "Seleccionar";
            this.Btn_seleccionar.UseVisualStyleBackColor = true;
            this.Btn_seleccionar.Click += new System.EventHandler(this.Btn_seleccionar_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.Location = new System.Drawing.Point(43, 524);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(237, 45);
            this.Btn_actualizar.TabIndex = 9;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // Frm_consultaCompraE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_seleccionar);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Txt_buscarCompra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dgv_consultaCompra);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_consultaCompraE";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_consultaCompraE";
            this.Load += new System.EventHandler(this.Frm_consultaCompraE_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaCompra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProveedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_buscarCompra;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Button Btn_seleccionar;
        private System.Windows.Forms.Button Btn_actualizar;
        public System.Windows.Forms.DataGridView Dgv_consultaCompra;
    }
}