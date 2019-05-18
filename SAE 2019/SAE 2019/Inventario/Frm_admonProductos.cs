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
using InicioSesion;

namespace SAE_2019.Inventario
{
    public partial class Frm_admonProductos : Form
    {
        Navegador nv = new Navegador();
        public Frm_admonProductos()
        {
            InitializeComponent();
        }

        private void Frm_admonProductos_Load(object sender, EventArgs e)
        {
            DataTable table2 = nv.cargarDatos("tbl_producto");
            dataGridView1.DataSource = table2;

            Usuario u = new Usuario();
            string codigoUsuario = Convert.ToString(u.obtenerCodigoUsuario());
            string nombreUsuario = Convert.ToString(u.obtenerUsuario());
            string numeroAplicacion = "1200";
            nv.obtenerCamposBitacora(codigoUsuario, nombreUsuario, numeroAplicacion);

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new Frm_productos(dataGridView1).Show();
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
