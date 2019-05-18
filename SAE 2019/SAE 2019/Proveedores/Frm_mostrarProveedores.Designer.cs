namespace SAE_2019.Proveedores
{
    partial class Frm_mostrarProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_mostrarProveedores));
            this.Dgv_mostrarProveedores = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Lbl_proveedores = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_mostrarProveedores)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_mostrarProveedores
            // 
            this.Dgv_mostrarProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_mostrarProveedores.Location = new System.Drawing.Point(91, 126);
            this.Dgv_mostrarProveedores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Dgv_mostrarProveedores.Name = "Dgv_mostrarProveedores";
            this.Dgv_mostrarProveedores.RowTemplate.Height = 24;
            this.Dgv_mostrarProveedores.Size = new System.Drawing.Size(904, 405);
            this.Dgv_mostrarProveedores.TabIndex = 0;
            this.Dgv_mostrarProveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_mostrarProveedores_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(111)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.Btn_minimizar);
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Controls.Add(this.Lbl_proveedores);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1088, 60);
            this.panel1.TabIndex = 1;
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.BackgroundImage")));
            this.Btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Location = new System.Drawing.Point(887, 0);
            this.Btn_minimizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_minimizar.Name = "Btn_minimizar";
            this.Btn_minimizar.Size = new System.Drawing.Size(64, 59);
            this.Btn_minimizar.TabIndex = 16;
            this.Btn_minimizar.UseVisualStyleBackColor = true;
            this.Btn_minimizar.Click += new System.EventHandler(this.Btn_minimizar_Click);
            // 
            // Btn_cerrar
            // 
            this.Btn_cerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_cerrar.BackgroundImage")));
            this.Btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_cerrar.FlatAppearance.BorderSize = 0;
            this.Btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_cerrar.Location = new System.Drawing.Point(979, 0);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(64, 59);
            this.Btn_cerrar.TabIndex = 15;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Lbl_proveedores
            // 
            this.Lbl_proveedores.AutoSize = true;
            this.Lbl_proveedores.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_proveedores.Location = new System.Drawing.Point(32, 25);
            this.Lbl_proveedores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Lbl_proveedores.Name = "Lbl_proveedores";
            this.Lbl_proveedores.Size = new System.Drawing.Size(199, 23);
            this.Lbl_proveedores.TabIndex = 12;
            this.Lbl_proveedores.Text = "1100-PROVEEDORES";
            // 
            // Frm_mostrarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1088, 602);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Dgv_mostrarProveedores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Frm_mostrarProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_mostrarProveedores";
            this.Load += new System.EventHandler(this.Frm_mostrarProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_mostrarProveedores)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_mostrarProveedores;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_proveedores;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.Button Btn_minimizar;
    }
}