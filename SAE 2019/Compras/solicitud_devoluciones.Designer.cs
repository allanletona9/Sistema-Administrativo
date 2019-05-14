namespace SAE_2019.Compras
{
    partial class solicitud_devoluciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(solicitud_devoluciones));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_iconoFactura = new System.Windows.Forms.Button();
            this.Lbl_facturas = new System.Windows.Forms.Label();
            this.dgv_devolucion = new System.Windows.Forms.DataGridView();
            this.txt_descr = new System.Windows.Forms.TextBox();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.Txt_nodevolucion = new System.Windows.Forms.TextBox();
            this.Lbl_noOrden = new System.Windows.Forms.Label();
            this.cbx_emp = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_producto = new System.Windows.Forms.ComboBox();
            this.cantidad_dev = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_devolucion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad_dev)).BeginInit();
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
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 48);
            this.panel1.TabIndex = 1;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.BackgroundImage")));
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Location = new System.Drawing.Point(795, 0);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(48, 48);
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
            this.Btn_minimizar.Location = new System.Drawing.Point(726, 0);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(48, 48);
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
            this.Btn_iconoFactura.Location = new System.Drawing.Point(15, 4);
            this.Btn_iconoFactura.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_iconoFactura.Name = "Btn_iconoFactura";
            this.Btn_iconoFactura.Size = new System.Drawing.Size(36, 39);
            this.Btn_iconoFactura.TabIndex = 12;
            this.Btn_iconoFactura.UseVisualStyleBackColor = true;
            // 
            // Lbl_facturas
            // 
            this.Lbl_facturas.AutoSize = true;
            this.Lbl_facturas.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_facturas.Location = new System.Drawing.Point(74, 16);
            this.Lbl_facturas.Name = "Lbl_facturas";
            this.Lbl_facturas.Size = new System.Drawing.Size(126, 19);
            this.Lbl_facturas.TabIndex = 3;
            this.Lbl_facturas.Text = "DEVOLUCIONES";
            // 
            // dgv_devolucion
            // 
            this.dgv_devolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_devolucion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.Column1,
            this.descripcion,
            this.cantidad,
            this.Column3});
            this.dgv_devolucion.Location = new System.Drawing.Point(98, 318);
            this.dgv_devolucion.Margin = new System.Windows.Forms.Padding(2);
            this.dgv_devolucion.Name = "dgv_devolucion";
            this.dgv_devolucion.RowTemplate.Height = 24;
            this.dgv_devolucion.Size = new System.Drawing.Size(640, 171);
            this.dgv_devolucion.TabIndex = 17;
            // 
            // txt_descr
            // 
            this.txt_descr.Location = new System.Drawing.Point(505, 148);
            this.txt_descr.Margin = new System.Windows.Forms.Padding(2);
            this.txt_descr.Name = "txt_descr";
            this.txt_descr.Size = new System.Drawing.Size(191, 20);
            this.txt_descr.TabIndex = 20;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar.Image")));
            this.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_agregar.Location = new System.Drawing.Point(199, 246);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(149, 44);
            this.btn_agregar.TabIndex = 34;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // Txt_nodevolucion
            // 
            this.Txt_nodevolucion.Location = new System.Drawing.Point(180, 105);
            this.Txt_nodevolucion.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_nodevolucion.Name = "Txt_nodevolucion";
            this.Txt_nodevolucion.ReadOnly = true;
            this.Txt_nodevolucion.Size = new System.Drawing.Size(120, 20);
            this.Txt_nodevolucion.TabIndex = 35;
            // 
            // Lbl_noOrden
            // 
            this.Lbl_noOrden.AutoSize = true;
            this.Lbl_noOrden.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_noOrden.Location = new System.Drawing.Point(52, 106);
            this.Lbl_noOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_noOrden.Name = "Lbl_noOrden";
            this.Lbl_noOrden.Size = new System.Drawing.Size(114, 19);
            this.Lbl_noOrden.TabIndex = 36;
            this.Lbl_noOrden.Text = "No. Devolucion";
            // 
            // cbx_emp
            // 
            this.cbx_emp.FormattingEnabled = true;
            this.cbx_emp.Location = new System.Drawing.Point(180, 148);
            this.cbx_emp.Name = "cbx_emp";
            this.cbx_emp.Size = new System.Drawing.Size(191, 21);
            this.cbx_emp.TabIndex = 37;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 19);
            this.label1.TabIndex = 38;
            this.label1.Text = "Empleado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(410, 149);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 40;
            this.label3.Text = "Producto";
            // 
            // cbx_producto
            // 
            this.cbx_producto.FormattingEnabled = true;
            this.cbx_producto.Location = new System.Drawing.Point(180, 206);
            this.cbx_producto.Name = "cbx_producto";
            this.cbx_producto.Size = new System.Drawing.Size(191, 21);
            this.cbx_producto.TabIndex = 41;
            // 
            // cantidad_dev
            // 
            this.cantidad_dev.Location = new System.Drawing.Point(513, 206);
            this.cantidad_dev.Name = "cantidad_dev";
            this.cantidad_dev.Size = new System.Drawing.Size(110, 20);
            this.cantidad_dev.TabIndex = 42;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(427, 204);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 43;
            this.label4.Text = "Cantidad";
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.Btn_guardar.FlatAppearance.BorderSize = 0;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("Btn_guardar.Image")));
            this.Btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_guardar.Location = new System.Drawing.Point(484, 246);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(184, 44);
            this.Btn_guardar.TabIndex = 44;
            this.Btn_guardar.Text = "Solicitar Devolucion";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // codigo
            // 
            this.codigo.HeaderText = "Código";
            this.codigo.Name = "codigo";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Empleado";
            this.Column1.Name = "Column1";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Producto";
            this.cantidad.Name = "cantidad";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.Name = "Column3";
            // 
            // solicitud_devoluciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(863, 513);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cantidad_dev);
            this.Controls.Add(this.cbx_producto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbx_emp);
            this.Controls.Add(this.Lbl_noOrden);
            this.Controls.Add(this.Txt_nodevolucion);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_descr);
            this.Controls.Add(this.dgv_devolucion);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "solicitud_devoluciones";
            this.Text = "solicitud_devoluciones";
            this.Load += new System.EventHandler(this.solicitud_devoluciones_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_devolucion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cantidad_dev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_iconoFactura;
        private System.Windows.Forms.Label Lbl_facturas;
        private System.Windows.Forms.DataGridView dgv_devolucion;
        private System.Windows.Forms.TextBox txt_descr;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.TextBox Txt_nodevolucion;
        private System.Windows.Forms.Label Lbl_noOrden;
        private System.Windows.Forms.ComboBox cbx_emp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbx_producto;
        private System.Windows.Forms.NumericUpDown cantidad_dev;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}