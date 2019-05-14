using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE_2019.Compras
{
    public partial class Frm_facturasCompras : Form
    {
        public Frm_facturasCompras()
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

        private void Frm_facturasCompras_Load(object sender, EventArgs e)
        {
            llenarComboBox();
            obtenerNumeroOrdenCompra();
        }

        void llenarComboBox()
        {
            try
            {
                OdbcCommand sql = new OdbcCommand("Select nombre_proveedor from tbl_proveedores where Estado_proveedor = 1",conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    Cbo_proveedor.Items.Add(almacena.GetValue(0));
                }
                almacena.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }
        int numerodeOrden = 0;
        void obtenerNumeroOrdenCompra()
        {

            try
            {
                // string selectQuery = "SELECT idCompra FROM encabezadocompra ORDER by idCompra DESC LIMIT 1";
                string selectQuery = "SELECT PK_IdComprasEncabezado FROM tbl_orden_compra_encabezado ORDER by PK_IdComprasEncabezado DESC LIMIT 1";

                //  Conexion nuevo = new Conexion();
                OdbcCommand sql = new OdbcCommand(String.Format(selectQuery), conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                bool validacion = false;
                while (almacena.Read() == true)
                {
                    validacion = true;

                    int dato = almacena.GetInt32(0);
                    numerodeOrden = dato + 1;
                    Txt_noOrdenCompra.Text = numerodeOrden + "";

                }
                almacena.Close();
                if (validacion == false)
                {
                    Txt_noOrdenCompra.Text = 1 + "";
                }




            }
            catch (Exception)
            {

            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string scodigoProducto = Txt_codigoProducto.Text;
            try
            {
                OdbcCommand sql = new OdbcCommand("Select nombre_producto, descrip_producto from tbl_productos where PK_IdProducto = "+scodigoProducto + " and Estado_producto = 1", conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    Txt_nombreProducto.Text = almacena.GetString(0);
                    TxtDescripcionProducto.Text = almacena.GetString(1);
                }
                almacena.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string scodigoProducto = Txt_codigoProducto.Text;
            try
            {
                OdbcCommand sql = new OdbcCommand("Select nombre_producto, descrip_producto from tbl_productos where PK_IdProducto = " + scodigoProducto + " and Estado_producto = 1", conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    DataGridViewRow filas = new DataGridViewRow();
                    filas.CreateCells(dgv_ordenCompra);
                    filas.Cells[0].Value = scodigoProducto;
                    filas.Cells[1].Value = almacena.GetString(0);
                    filas.Cells[2].Value = almacena.GetString(1);
                    dgv_ordenCompra.Rows.Add(filas);
                }
                almacena.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            MessageBox.Show(fecha);
            string scodigoProveedor="";
            bool validacionProveedor = false;
            //validacion de combobox vacio
            if (Cbo_proveedor.SelectedItem != null)
            {
                string snombreProveedor = Cbo_proveedor.SelectedItem.ToString();
                //consulta el codigo del proveedor obteniendo el texto del combobox con el nombre del proveedor
                try
                {
                    OdbcCommand sql = new OdbcCommand("Select PK_IdProveedores from tbl_proveedores where nombre_proveedor = '" + snombreProveedor + "' and Estado_proveedor = 1", conexion.conectar());
                    OdbcDataReader almacena = sql.ExecuteReader();
                    while (almacena.Read() == true)
                    {
                      
                     scodigoProveedor = almacena.GetString(0);
                    
                    }
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
                validacionProveedor = true;
            }

            if (validacionProveedor == false)
            {
                try
                {
                    string scodigoOrdenCompra = Txt_noOrdenCompra.Text;

                    OdbcCommand sql = new OdbcCommand("INSERT INTO tbl_orden_compra_encabezado (PK_IdComprasEncabezado, PK_IdProveedores, fecha_pedido)" +
                    " VALUES( "+ scodigoOrdenCompra+", "+ scodigoProveedor+", '" +fecha+"' )", conexion.conectar());
                    sql.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                try
                {
                    //en esta parte no se puede probar porque falta el autoincrementable en la BD
                    foreach (DataGridViewRow row in dgv_ordenCompra.Rows)
                    {

                        try
                        {
                            string scodigoOrdenCompra = Txt_noOrdenCompra.Text;

                            Convert.ToString(row.Cells[8].Value);
                            OdbcCommand sql = new OdbcCommand("INSERT INTO tbl_orden_compra_encabezado (PK_IdComprasEncabezado, PK_IdProducto, Cantidad)" +
                 " VALUES( " + scodigoOrdenCompra + ", " + Convert.ToString(row.Cells[0].Value) + ", " + Convert.ToString(row.Cells[3].Value) + " )", conexion.conectar());
                            sql.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }




            }
        }

        private void Btn_modificar_Click(object sender, EventArgs e)
        {
          
        }

        private void Btn_ingresarProducto_Click(object sender, EventArgs e)
        {

        }
    }
}
