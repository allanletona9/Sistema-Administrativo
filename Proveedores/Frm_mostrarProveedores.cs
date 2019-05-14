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

namespace SAE_2019.Proveedores
{
    public partial class Frm_mostrarProveedores : Form
    {
        Navegador nv = new Navegador();
        public Frm_mostrarProveedores()
        {
            InitializeComponent();
        }

        //bool ventanaRegistroProveedores = false;
        //Frm_admonProveedores admonProveedores = new Frm_admonProveedores();

        private void Dgv_mostrarProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new Frm_admonProveedores(Dgv_mostrarProveedores).Show();
        }

        private void Frm_mostrarProveedores_Load(object sender, EventArgs e)
        {
            DataTable table2 = nv.cargarDatos("tbl_proveedores");
            Dgv_mostrarProveedores.DataSource = table2;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
