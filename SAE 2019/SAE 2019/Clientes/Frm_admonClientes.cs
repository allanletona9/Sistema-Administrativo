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


namespace SAE_2019.Clientes
{
    public partial class Frm_admonClientes : Form
    {
        Navegador nv2 = new Navegador();
        public Frm_admonClientes(DataGridView dgr)
        {
            InitializeComponent();
            nv2.nombreForm(this);
            nv2.dgv_datos(dgr);
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Gpb_clientes_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_admonClientes_Load(object sender, EventArgs e)
        {
            nv2.ingresarTabla("tbl_clientes");

            Usuario u = new Usuario();
            string codigoUsuario = Convert.ToString(u.obtenerCodigoUsuario());
            string nombreUsuario = Convert.ToString(u.obtenerUsuario());
            string numeroAplicacion = "1300";
            nv2.obtenerCamposBitacora(codigoUsuario, nombreUsuario, numeroAplicacion);


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
