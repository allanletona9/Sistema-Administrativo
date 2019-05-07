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
using System.Data.Odbc;

namespace SAE_2019.Inventario
{
    public partial class Frm_productos : Form
    {
        Navegador nv2 = new Navegador();
        public Frm_productos(DataGridView dgr)
        {
            InitializeComponent();
            nv2.nombreForm(this);
            nv2.dgv_datos(dgr);
            nv2.numeroApp(2005);
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        void llenarComboBox()
        {
            try
            {
                OdbcCommand sql = new OdbcCommand("Select cantidad from tbl_comisiones", conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    cbo_comision.Items.Add(almacena.GetValue(0));
                }
                almacena.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

           

        }

       
        private void Frm_productos_Load(object sender, EventArgs e)
        {


            string scodigoComision = "";
            bool validacionComision = false;

            if (cbo_comision.SelectedItem != null)
            {
                string sComision = cbo_comision.SelectedItem.ToString();

                //consulta el codigo del proveedor obteniendo el texto del combobox con el nombre del proveedor
                try
                {

                    OdbcCommand sql = new OdbcCommand("Select PK_IdComision from tbl_comisiones where cantidad = '" + sComision + "'", conexion.conectar());
                    OdbcDataReader almacena = sql.ExecuteReader();
                    while (almacena.Read() == true)
                    {
                        scodigoComision = almacena.GetString(0);
                    }
                    Txt_Comision.Text = scodigoComision;
                    almacena.Close();
                    conexion.cerrarConexion();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                validacionComision = true;
            }


            nv2.ingresarTabla("tbl_productos");
            llenarComboBox();

            Usuario u = new Usuario();
            string codigoUsuario = Convert.ToString(u.obtenerCodigoUsuario());
            string nombreUsuario = Convert.ToString(u.obtenerUsuario());
            string numeroAplicacion = "1200";
            nv2.obtenerCamposBitacora(codigoUsuario, nombreUsuario, numeroAplicacion);


           
        }

        private void navegador1_Load(object sender, EventArgs e)
        {

        }

        private void Txt_Comision_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbo_comision_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
    }
}
