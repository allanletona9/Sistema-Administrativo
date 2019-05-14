namespace SAE_2019.Inventario
{
    partial class Frm_almacenes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_almacenes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Lbl_almacenes = new System.Windows.Forms.Label();
            this.Btn_iconoAlmacenes = new System.Windows.Forms.Button();
            this.Btn_minimizar = new System.Windows.Forms.Button();
            this.Btn_cerrar = new System.Windows.Forms.Button();
            this.Dtv_almacenes = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtv_almacenes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.Btn_cerrar);
            this.panel1.Controls.Add(this.Btn_minimizar);
            this.panel1.Controls.Add(this.Btn_iconoAlmacenes);
            this.panel1.Controls.Add(this.Lbl_almacenes);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1220, 59);
            this.panel1.TabIndex = 0;
            // 
            // Lbl_almacenes
            // 
            this.Lbl_almacenes.AutoSize = true;
            this.Lbl_almacenes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_almacenes.Location = new System.Drawing.Point(99, 20);
            this.Lbl_almacenes.Name = "Lbl_almacenes";
            this.Lbl_almacenes.Size = new System.Drawing.Size(128, 23);
            this.Lbl_almacenes.TabIndex = 11;
            this.Lbl_almacenes.Text = "ALMACENES";
            // 
            // Btn_iconoAlmacenes
            // 
            this.Btn_iconoAlmacenes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_iconoAlmacenes.BackgroundImage")));
            this.Btn_iconoAlmacenes.Enabled = false;
            this.Btn_iconoAlmacenes.FlatAppearance.BorderSize = 0;
            this.Btn_iconoAlmacenes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_iconoAlmacenes.Location = new System.Drawing.Point(20, 5);
            this.Btn_iconoAlmacenes.Name = "Btn_iconoAlmacenes";
            this.Btn_iconoAlmacenes.Size = new System.Drawing.Size(48, 48);
            this.Btn_iconoAlmacenes.TabIndex = 13;
            this.Btn_iconoAlmacenes.UseVisualStyleBackColor = true;
            // 
            // Btn_minimizar
            // 
            this.Btn_minimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Btn_minimizar.BackgroundImage")));
            this.Btn_minimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Btn_minimizar.FlatAppearance.BorderSize = 0;
            this.Btn_minimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_minimizar.Location = new System.Drawing.Point(1023, 0);
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
            this.Btn_cerrar.Location = new System.Drawing.Point(1115, 0);
            this.Btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.Btn_cerrar.Name = "Btn_cerrar";
            this.Btn_cerrar.Size = new System.Drawing.Size(64, 59);
            this.Btn_cerrar.TabIndex = 15;
            this.Btn_cerrar.UseVisualStyleBackColor = true;
            this.Btn_cerrar.Click += new System.EventHandler(this.Btn_cerrar_Click);
            // 
            // Dtv_almacenes
            // 
            this.Dtv_almacenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dtv_almacenes.Location = new System.Drawing.Point(103, 188);
            this.Dtv_almacenes.Name = "Dtv_almacenes";
            this.Dtv_almacenes.RowTemplate.Height = 24;
            this.Dtv_almacenes.Size = new System.Drawing.Size(984, 465);
            this.Dtv_almacenes.TabIndex = 1;
            // 
            // Frm_almacenes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1220, 804);
            this.Controls.Add(this.Dtv_almacenes);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_almacenes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_almacenes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dtv_almacenes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Lbl_almacenes;
        private System.Windows.Forms.Button Btn_iconoAlmacenes;
        private System.Windows.Forms.Button Btn_minimizar;
        private System.Windows.Forms.Button Btn_cerrar;
        private System.Windows.Forms.DataGridView Dtv_almacenes;
    }
}