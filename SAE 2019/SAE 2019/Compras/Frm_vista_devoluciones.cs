using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;

namespace SAE_2019.Compras
{
    public partial class Frm_vista_devoluciones : Form
    {
        Navegador nv = new Navegador();
        public Frm_vista_devoluciones()
        {
            InitializeComponent();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Lbl_ordenCompra_Click(object sender, EventArgs e)
        {

        }

        private void Dvg_orden_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Frm_vista_devoluciones_Load(object sender, EventArgs e)
        {
            DataTable table2 = nv.cargarDatos("tbl_devoluciones_encabezado");
            dataGridView_dev.DataSource = table2;
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView_dev_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

                   
        }

        private void dataGridView_dev_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Frm_Gestion_Devolucion1 gestion_devoluciones = new Frm_Gestion_Devolucion1();
            gestion_devoluciones.Show();
        }
    }
}
