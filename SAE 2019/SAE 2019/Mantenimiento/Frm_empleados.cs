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
using System.Data.Odbc;
using InicioSesion;

namespace SAE_2019.Mantenimiento
{
    public partial class Frm_empleados : Form
    {
        Navegador nv2 = new Navegador();
        OdbcCommand cmd;
        public Frm_empleados(DataGridView dgr)
        {
            InitializeComponent();
            nv2.numeroApp(2001);
            nv2.nombreForm(this);
            nv2.dgv_datos(dgr);
        }

        private void Frm_empleados_Load(object sender, EventArgs e)
        {
            nv2.ingresarTabla("tbl_clientes");
            llenarComboBox();

            Usuario u = new Usuario();
            string codigoUsuario = Convert.ToString(u.obtenerCodigoUsuario());
            string nombreUsuario = Convert.ToString(u.obtenerUsuario());
            string numeroAplicacion = "1400";
            nv2.obtenerCamposBitacora(codigoUsuario, nombreUsuario, numeroAplicacion);

        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void llenarComboBox()
        {
            try
            {
                OdbcCommand sql = new OdbcCommand("Select nombre_sucursal from tbl_surcursal", conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    cbo_idSucursal.Items.Add(almacena.GetValue(0));
                }
                almacena.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
