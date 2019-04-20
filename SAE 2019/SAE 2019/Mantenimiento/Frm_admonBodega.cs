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

namespace SAE_2019.Mantenimiento
{
    public partial class Frm_admonBodega : Form
    {
        Navegador nv = new Navegador();
        public Frm_admonBodega()
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

        private void Frm_admonBodega_Load(object sender, EventArgs e)
        {
            DataTable table2 = nv.cargarDatos("tbl_bodegas");
            dataGridView1.DataSource = table2;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new Frm_bodegas(dataGridView1).Show();
        }
    }
}
