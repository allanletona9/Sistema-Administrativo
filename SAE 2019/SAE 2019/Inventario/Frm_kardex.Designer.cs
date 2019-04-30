namespace SAE_2019.Inventario
{
    partial class Frm_kardex
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_kardex));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_iconoKardex = new System.Windows.Forms.Button();
            this.Lbl_kardex = new System.Windows.Forms.Label();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.dgv_kardex = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_existencias = new System.Windows.Forms.TextBox();
            this.Btn_buscarOrdenCompra = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_codigoProducto = new System.Windows.Forms.TextBox();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kardex)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.Btn_minimizar);
            this.panel1.Controls.Add(this.Btn_iconoKardex);
            this.panel1.Controls.Add(this.Lbl_kardex);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 48);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.BackgroundImage")));
            this.Btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Location = new System.Drawing.Point(767, 0);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(48, 48);
            this.Btn_minimizar.TabIndex = 13;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click_1);
            // 
            // Btn_iconoKardex
            // 
            this.Btn_iconoKardex.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_iconoKardex.BackgroundImage")));
            this.Btn_iconoKardex.Enabled = false;
            this.Btn_iconoKardex.FlatAppearance.BorderSize = 0;
            this.Btn_iconoKardex.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_iconoKardex.Location = new System.Drawing.Point(20, 0);
            this.Btn_iconoKardex.Name = "Btn_iconoKardex";
            this.Btn_iconoKardex.Size = new System.Drawing.Size(48, 48);
            this.Btn_iconoKardex.TabIndex = 12;
            this.Btn_iconoKardex.UseVisualStyleBackColor = true;
            // 
            // Lbl_kardex
            // 
            this.Lbl_kardex.AutoSize = true;
            this.Lbl_kardex.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_kardex.Location = new System.Drawing.Point(74, 16);
            this.Lbl_kardex.Name = "Lbl_kardex";
            this.Lbl_kardex.Size = new System.Drawing.Size(113, 19);
            this.Lbl_kardex.TabIndex = 11;
            this.Lbl_kardex.Text = "4100-KARDEX";
            // 
            // Btn_salir
            // 
            this.Btn_salir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.Btn_salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_salir.BackgroundImage")));
            this.Btn_salir.FlatAppearance.BorderSize = 0;
            this.Btn_salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_salir.Location = new System.Drawing.Point(836, 0);
            this.Btn_salir.Name = "Btn_salir";
            this.Btn_salir.Size = new System.Drawing.Size(48, 48);
            this.Btn_salir.TabIndex = 2;
            this.Btn_salir.UseVisualStyleBackColor = false;
            this.Btn_salir.Click += new System.EventHandler(this.Btn_salir_Click);
            // 
            // dgv_kardex
            // 
            this.dgv_kardex.AllowUserToAddRows = false;
            this.dgv_kardex.AllowUserToDeleteRows = false;
            this.dgv_kardex.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_kardex.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column1,
            this.Column3,
            this.Column7,
            this.Column8,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgv_kardex.Location = new System.Drawing.Point(39, 228);
            this.dgv_kardex.Name = "dgv_kardex";
            this.dgv_kardex.ReadOnly = true;
            this.dgv_kardex.Size = new System.Drawing.Size(845, 373);
            this.dgv_kardex.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Controls.Add(this.txt_existencias);
            this.groupBox4.Controls.Add(this.Btn_buscarOrdenCompra);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.Txt_codigoProducto);
            this.groupBox4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(137, 93);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(648, 114);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Busqueda de Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(241, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 19);
            this.label1.TabIndex = 21;
            this.label1.Text = "Existencias en sucursal";
            // 
            // txt_existencias
            // 
            this.txt_existencias.Location = new System.Drawing.Point(245, 62);
            this.txt_existencias.Name = "txt_existencias";
            this.txt_existencias.ReadOnly = true;
            this.txt_existencias.Size = new System.Drawing.Size(204, 23);
            this.txt_existencias.TabIndex = 22;
            // 
            // Btn_buscarOrdenCompra
            // 
            this.Btn_buscarOrdenCompra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.Btn_buscarOrdenCompra.FlatAppearance.BorderSize = 0;
            this.Btn_buscarOrdenCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscarOrdenCompra.Image = ((System.Drawing.Image)(resources.GetObject("Btn_buscarOrdenCompra.Image")));
            this.Btn_buscarOrdenCompra.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_buscarOrdenCompra.Location = new System.Drawing.Point(517, 40);
            this.Btn_buscarOrdenCompra.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_buscarOrdenCompra.Name = "Btn_buscarOrdenCompra";
            this.Btn_buscarOrdenCompra.Size = new System.Drawing.Size(104, 50);
            this.Btn_buscarOrdenCompra.TabIndex = 21;
            this.Btn_buscarOrdenCompra.Text = "Buscar";
            this.Btn_buscarOrdenCompra.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_buscarOrdenCompra.UseVisualStyleBackColor = false;
            this.Btn_buscarOrdenCompra.Click += new System.EventHandler(this.Btn_buscarOrdenCompra_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 40);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 19);
            this.label5.TabIndex = 19;
            this.label5.Text = "Codigo de producto";
            // 
            // Txt_codigoProducto
            // 
            this.Txt_codigoProducto.Location = new System.Drawing.Point(16, 62);
            this.Txt_codigoProducto.Name = "Txt_codigoProducto";
            this.Txt_codigoProducto.Size = new System.Drawing.Size(204, 23);
            this.Txt_codigoProducto.TabIndex = 20;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Codigo Producto";
            this.Column2.Name = "Column2";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Producto";
            this.Column1.Name = "Column1";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Bodega";
            this.Column3.Name = "Column3";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "No. Documento";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Descripcion";
            this.Column8.Name = "Column8";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Fecha";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Movimiento";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Cantidad";
            this.Column6.Name = "Column6";
            // 
            // Frm_kardex
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(915, 653);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.dgv_kardex);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_kardex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_kardex";
            this.Load += new System.EventHandler(this.Frm_kardex_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_kardex)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_kardex;
        private System.Windows.Forms.Button Btn_iconoKardex;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.DataGridView dgv_kardex;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_existencias;
        private System.Windows.Forms.Button Btn_buscarOrdenCompra;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_codigoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}