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
            this.Dgv_mostrarProveedores.Location = new System.Drawing.Point(70, 49);
            this.Dgv_mostrarProveedores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Dgv_mostrarProveedores.Name = "Dgv_mostrarProveedores";
            this.Dgv_mostrarProveedores.RowTemplate.Height = 24;
            this.Dgv_mostrarProveedores.Size = new System.Drawing.Size(678, 329);
            this.Dgv_mostrarProveedores.TabIndex = 0;
            this.Dgv_mostrarProveedores.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_mostrarProveedores_CellDoubleClick);
            // 
            // Frm_mostrarProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Dgv_mostrarProveedores);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_mostrarProveedores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_mostrarProveedores";
            this.Load += new System.EventHandler(this.Frm_mostrarProveedores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_mostrarProveedores)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_mostrarProveedores;
    }
}