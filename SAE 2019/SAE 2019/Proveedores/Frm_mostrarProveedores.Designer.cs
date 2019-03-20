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
            this.Dgv_mostrarProveedores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_mostrarProveedores)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgv_mostrarProveedores
            // 
            this.Dgv_mostrarProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgv_mostrarProveedores.Location = new System.Drawing.Point(93, 60);
            this.Dgv_mostrarProveedores.Name = "Dgv_mostrarProveedores";
            this.Dgv_mostrarProveedores.RowTemplate.Height = 24;
            this.Dgv_mostrarProveedores.Size = new System.Drawing.Size(904, 405);
            this.Dgv_mostrarProveedores.TabIndex = 0;
            this.Dgv_mostrarProveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_mostrarProveedores_CellDoubleClick);
            // 
            // Frm_mostrarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Dgv_mostrarProveedores);
            this.Name = "Frm_mostrarProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_mostrarProveedores";
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_mostrarProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_mostrarProveedores;
    }
}