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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idInventario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idSucursal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idBodega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.existencias = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_salir = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInventario,
            this.idProducto,
            this.idSucursal,
            this.idBodega,
            this.existencias});
            this.dataGridView1.Location = new System.Drawing.Point(78, 132);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(737, 430);
            this.dataGridView1.TabIndex = 1;
            // 
            // idInventario
            // 
            this.idInventario.HeaderText = "ID INVENTARIO";
            this.idInventario.Name = "idInventario";
            this.idInventario.Width = 103;
            // 
            // idProducto
            // 
            this.idProducto.HeaderText = "ID DEL PRODUCTO";
            this.idProducto.Name = "idProducto";
            this.idProducto.Width = 120;
            // 
            // idSucursal
            // 
            this.idSucursal.HeaderText = "ID DE LA SUCURSAL";
            this.idSucursal.Name = "idSucursal";
            this.idSucursal.Width = 126;
            // 
            // idBodega
            // 
            this.idBodega.HeaderText = "ID DE BODEGA";
            this.idBodega.Name = "idBodega";
            // 
            // existencias
            // 
            this.existencias.HeaderText = "existencias";
            this.existencias.Name = "existencias";
            this.existencias.Width = 84;
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
            // Frm_kardex
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(915, 653);
            this.Controls.Add(this.Btn_salir);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_kardex";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_kardex";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_kardex;
        private System.Windows.Forms.Button Btn_iconoKardex;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInventario;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn idSucursal;
        private System.Windows.Forms.DataGridViewTextBoxColumn idBodega;
        private System.Windows.Forms.DataGridViewTextBoxColumn existencias;
        private System.Windows.Forms.Button Btn_salir;
        private System.Windows.Forms.Button Btn_minimizar;
    }
}