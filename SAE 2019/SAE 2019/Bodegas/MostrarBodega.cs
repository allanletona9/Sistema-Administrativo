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
namespace SAE_2019.Bodegas
{
    public partial class MostrarBodega : Form
    {
        Navegador nv = new Navegador();
        public MostrarBodega()
        {
            InitializeComponent();
            
        }
        private void MostrarBodega_Load(object sender, EventArgs e)
        {
            DataTable table2 = nv.cargarDatos("tbl_encargado_bodega");
            dataGridView1.DataSource = table2;
        }
        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          new frm_gestion_bodega(dataGridView1).Show();
        }
        private void Lbl_admonClientes_Click(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new frm_gestion_bodega(dataGridView1).Show();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           new frm_gestion_bodega(dataGridView1).Show();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
