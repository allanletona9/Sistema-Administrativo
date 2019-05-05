namespace SAE_2019.Facturacion
{
    partial class Frm_consultaCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_consultaCliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Tbl_buscarCliente = new System.Windows.Forms.Label();
            this.Txt_buscarCliente = new System.Windows.Forms.TextBox();
            this.Dgv_consultaCliente = new System.Windows.Forms.DataGridView();
            this.idCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nitCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dpiCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Btn_seleccionar = new System.Windows.Forms.Button();
            this.Btn_buscar = new System.Windows.Forms.Button();
            this.Btn_actualizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(128)))), ((int)(((byte)(191)))));
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 59);
            this.panel1.TabIndex = 0;
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.BackgroundImage")));
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Location = new System.Drawing.Point(923, 0);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(64, 59);
            this.Btn_cerrar.TabIndex = 16;
            this.Btn_cerrar.TabStop = false;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(233, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONSULTA DE CLIENTES";
            // 
            // Tbl_buscarCliente
            // 
            this.Tbl_buscarCliente.AutoSize = true;
            this.Tbl_buscarCliente.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tbl_buscarCliente.Location = new System.Drawing.Point(12, 87);
            this.Tbl_buscarCliente.Name = "Tbl_buscarCliente";
            this.Tbl_buscarCliente.Size = new System.Drawing.Size(174, 21);
            this.Tbl_buscarCliente.TabIndex = 1;
            this.Tbl_buscarCliente.Text = "Nombre del cliente:";
            // 
            // Txt_buscarCliente
            // 
            this.Txt_buscarCliente.Location = new System.Drawing.Point(201, 87);
            this.Txt_buscarCliente.Name = "Txt_buscarCliente";
            this.Txt_buscarCliente.Size = new System.Drawing.Size(619, 22);
            this.Txt_buscarCliente.TabIndex = 2;
            // 
            // Dgv_consultaCliente
            // 
            this.Dgv_consultaCliente.AllowUserToAddRows = false;
            this.Dgv_consultaCliente.AllowUserToDeleteRows = false;
            this.Dgv_consultaCliente.AllowUserToResizeColumns = false;
            this.Dgv_consultaCliente.AllowUserToResizeRows = false;
            this.Dgv_consultaCliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Dgv_consultaCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_consultaCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCliente,
            this.nombreCliente,
            this.nitCliente,
            this.dpiCliente,
            this.estadoCliente});
            this.Dgv_consultaCliente.Location = new System.Drawing.Point(41, 140);
            this.Dgv_consultaCliente.Name = "Dgv_consultaCliente";
            this.Dgv_consultaCliente.RowTemplate.Height = 24;
            this.Dgv_consultaCliente.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Dgv_consultaCliente.Size = new System.Drawing.Size(880, 364);
            this.Dgv_consultaCliente.TabIndex = 3;
            // 
            // idCliente
            // 
            this.idCliente.HeaderText = "Id cliente";
            this.idCliente.Name = "idCliente";
            // 
            // nombreCliente
            // 
            this.nombreCliente.HeaderText = "Nombre";
            this.nombreCliente.Name = "nombreCliente";
            // 
            // nitCliente
            // 
            this.nitCliente.HeaderText = "NIT";
            this.nitCliente.Name = "nitCliente";
            // 
            // dpiCliente
            // 
            this.dpiCliente.HeaderText = "DPI";
            this.dpiCliente.Name = "dpiCliente";
            // 
            // estadoCliente
            // 
            this.estadoCliente.HeaderText = "Estado";
            this.estadoCliente.Name = "estadoCliente";
            // 
            // Btn_seleccionar
            // 
            this.Btn_seleccionar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_seleccionar.Location = new System.Drawing.Point(684, 525);
            this.Btn_seleccionar.Name = "Btn_seleccionar";
            this.Btn_seleccionar.Size = new System.Drawing.Size(237, 45);
            this.Btn_seleccionar.TabIndex = 4;
            this.Btn_seleccionar.Text = "Seleccionar";
            this.Btn_seleccionar.UseVisualStyleBackColor = true;
            this.Btn_seleccionar.Click += new System.EventHandler(this.Btn_seleccionar_Click);
            // 
            // Btn_buscar
            // 
            this.Btn_buscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_buscar.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_buscar.Location = new System.Drawing.Point(826, 82);
            this.Btn_buscar.Name = "Btn_buscar";
            this.Btn_buscar.Size = new System.Drawing.Size(95, 35);
            this.Btn_buscar.TabIndex = 5;
            this.Btn_buscar.Text = "BUSCAR";
            this.Btn_buscar.UseVisualStyleBackColor = true;
            this.Btn_buscar.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // Btn_actualizar
            // 
            this.Btn_actualizar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_actualizar.Location = new System.Drawing.Point(42, 525);
            this.Btn_actualizar.Name = "Btn_actualizar";
            this.Btn_actualizar.Size = new System.Drawing.Size(237, 45);
            this.Btn_actualizar.TabIndex = 6;
            this.Btn_actualizar.Text = "Actualizar";
            this.Btn_actualizar.UseVisualStyleBackColor = true;
            this.Btn_actualizar.Click += new System.EventHandler(this.Btn_actualizar_Click);
            // 
            // Frm_consultaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.Btn_actualizar);
            this.Controls.Add(this.Btn_buscar);
            this.Controls.Add(this.Btn_seleccionar);
            this.Controls.Add(this.Dgv_consultaCliente);
            this.Controls.Add(this.Txt_buscarCliente);
            this.Controls.Add(this.Tbl_buscarCliente);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_consultaCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_consulta";
            this.Load += new System.EventHandler(this.Frm_consultaCliente_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_consultaCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Tbl_buscarCliente;
        private System.Windows.Forms.TextBox Txt_buscarCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn nitCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn dpiCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoCliente;
        private System.Windows.Forms.Button Btn_seleccionar;
        private System.Windows.Forms.Button Btn_buscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_actualizar;
        public System.Windows.Forms.DataGridView Dgv_consultaCliente;
    }
}