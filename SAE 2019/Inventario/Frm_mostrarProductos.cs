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

namespace SAE_2019.Inventario
{
    public partial class Frm_mostrarProductos : Form
    {
        Navegador nv = new Navegador();
        public Frm_mostrarProductos()
        {
            InitializeComponent();
        }
        private void Frm_mostrarProductos_Load(object sender, EventArgs e)
        {
            DataTable table2 = nv.cargarDatos("tbl_productos");
            dataGridView1.DataSource = table2;
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new Frm_productos(dataGridView1).Show();
        }
    }
}
