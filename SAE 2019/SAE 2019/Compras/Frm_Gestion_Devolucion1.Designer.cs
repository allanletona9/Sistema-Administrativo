namespace SAE_2019.Compras
{
    partial class Frm_Gestion_Devolucion1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Gestion_Devolucion1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_iconoOrdenCompra = new System.Windows.Forms.Button();
            this.Lbl_devol = new System.Windows.Forms.Label();
            this.Lbl_noOrden = new System.Windows.Forms.Label();
            this.dataGridView_dev = new System.Windows.Forms.DataGridView();
            this.Btn_guardar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbx_devolucion = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dev)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(784, 48);
            this.panel1.TabIndex = 1;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.BackgroundImage")));
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Location = new System.Drawing.Point(693, 0);
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
            this.Btn_minimizar.Location = new System.Drawing.Point(639, 0);
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
            this.Lbl_devol.Size = new System.Drawing.Size(261, 19);
            this.Lbl_devol.TabIndex = 4;
            this.Lbl_devol.Text = "5600-GESTION DE DEVOLUCIONES";
            // 
            // Lbl_noOrden
            // 
            this.Lbl_noOrden.AutoSize = true;
            this.Lbl_noOrden.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_noOrden.Location = new System.Drawing.Point(74, 92);
            this.Lbl_noOrden.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Lbl_noOrden.Name = "Lbl_noOrden";
            this.Lbl_noOrden.Size = new System.Drawing.Size(114, 19);
            this.Lbl_noOrden.TabIndex = 38;
            this.Lbl_noOrden.Text = "No. Devolucion";
            // 
            // dataGridView_dev
            // 
            this.dataGridView_dev.AllowUserToAddRows = false;
            this.dataGridView_dev.AllowUserToDeleteRows = false;
            this.dataGridView_dev.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_dev.Location = new System.Drawing.Point(96, 179);
            this.dataGridView_dev.Name = "dataGridView_dev";
            this.dataGridView_dev.ReadOnly = true;
            this.dataGridView_dev.RowHeadersVisible = false;
            this.dataGridView_dev.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dataGridView_dev.Size = new System.Drawing.Size(645, 95);
            this.dataGridView_dev.TabIndex = 59;
            this.dataGridView_dev.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_dev_CellContentClick);
            // 
            // Btn_guardar
            // 
            this.Btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.Btn_guardar.FlatAppearance.BorderSize = 0;
            this.Btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_guardar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_guardar.Image = global::SAE_2019.Properties.Resources.icons8_factura_48;
            this.Btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_guardar.Location = new System.Drawing.Point(292, 290);
            this.Btn_guardar.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_guardar.Name = "Btn_guardar";
            this.Btn_guardar.Size = new System.Drawing.Size(188, 64);
            this.Btn_guardar.TabIndex = 64;
            this.Btn_guardar.Text = "Confirmar Devolucion";
            this.Btn_guardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_guardar.UseVisualStyleBackColor = false;
            this.Btn_guardar.Click += new System.EventHandler(this.Btn_guardar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.btn_agregar.FlatAppearance.BorderSize = 0;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_agregar.Image")));
            this.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_agregar.Location = new System.Drawing.Point(544, 74);
            this.btn_agregar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(186, 47);
            this.btn_agregar.TabIndex = 63;
            this.btn_agregar.Text = "Estado Devoluciones";
            this.btn_agregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar.UseVisualStyleBackColor = false;
            this.btn_agregar.Click += new System.EventHandler(this.btn_agregar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(225)))), ((int)(((byte)(167)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.Location = new System.Drawing.Point(333, 75);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 44);
            this.button1.TabIndex = 52;
            this.button1.Text = "Buscar Devolucion";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbx_devolucion
            // 
            this.cbx_devolucion.FormattingEnabled = true;
            this.cbx_devolucion.Location = new System.Drawing.Point(193, 90);
            this.cbx_devolucion.Name = "cbx_devolucion";
            this.cbx_devolucion.Size = new System.Drawing.Size(121, 21);
            this.cbx_devolucion.TabIndex = 65;
            this.cbx_devolucion.SelectedIndexChanged += new System.EventHandler(this.cbx_devolucion_SelectedIndexChanged);
            // 
            // Frm_Gestion_Devolucion1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 402);
            this.Controls.Add(this.dataGridView_dev);
            this.Controls.Add(this.cbx_devolucion);
            this.Controls.Add(this.Btn_guardar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Lbl_noOrden);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_Gestion_Devolucion1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion_Devolucion";
            this.Load += new System.EventHandler(this.Gestion_Devolucion_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_dev)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_iconoOrdenCompra;
        private System.Windows.Forms.Label Lbl_devol;
        private System.Windows.Forms.Label Lbl_noOrden;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView_dev;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Button Btn_guardar;
        private System.Windows.Forms.ComboBox cbx_devolucion;
    }
}