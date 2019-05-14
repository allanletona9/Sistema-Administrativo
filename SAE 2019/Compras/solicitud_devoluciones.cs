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
    public partial class solicitud_devoluciones : Form
    {
        public solicitud_devoluciones()
        {
            InitializeComponent();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

           
        }
        void LlenarComboBox()
        {
            try
            {
                OdbcCommand sql = new OdbcCommand("Select nombre_empleado from tbl_empleados where Estado_empleado = 1", conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    cbx_emp.Items.Add(almacena.GetValue(0));
                }
                almacena.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        void LlenarComboBox2()
        {
            try
            {
                OdbcCommand sql = new OdbcCommand("Select nombre_producto from tbl_productos where Estado_producto = 1", conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    cbx_producto.Items.Add(almacena.GetValue(0));
                }
                almacena.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        int numerodeOrden = 0;
        void obtenerNumeroDevolucion()
        {

            try
            {
                // string selectQuery = "SELECT idCompra FROM encabezadocompra ORDER by idCompra DESC LIMIT 1";
                string selectQuery = "SELECT PK_IdDevolucion FROM devoluciones_encabezado ORDER by PK_IdDevolucion DESC LIMIT 1";

                //  Conexion nuevo = new Conexion();
                OdbcCommand sql = new OdbcCommand(String.Format(selectQuery), conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                bool validacion = false;
                while (almacena.Read() == true)
                {
                    validacion = true;

                    int dato = almacena.GetInt32(0);
                    numerodeOrden = dato + 1;
                    Txt_nodevolucion.Text = numerodeOrden + "";

                }
                almacena.Close();
                if (validacion == false)
                {
                    Txt_nodevolucion.Text = 1 + "";
                }

            }
            catch (Exception)
            {

            }
        }
        private void solicitud_devoluciones_Load(object sender, EventArgs e)
        {
            LlenarComboBox();
            LlenarComboBox2();
            obtenerNumeroDevolucion();
        }
        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            string scodigodevolucion = Txt_nodevolucion.Text;
            string sempleado = cbx_emp.Text;
            string sdescripcion = txt_descr.Text;
            string sproducto = cbx_producto.Text;
            string cantidadd = cantidad_dev.Text;
            try
            {
                
                    DataGridViewRow filas = new DataGridViewRow();
                    filas.CreateCells(dgv_devolucion);
                    filas.Cells[0].Value = scodigodevolucion;
                    filas.Cells[1].Value = sempleado;
                    filas.Cells[2].Value = sdescripcion;
                    filas.Cells[3].Value = sproducto;
                    filas.Cells[4].Value = cantidadd;
                    dgv_devolucion.Rows.Add(filas);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {

          /**  string fecha = DateTime.Now.ToString("yyyy-MM-dd");
            MessageBox.Show(fecha);
            string scodigoProveedor = "";
                try
                {
                string scodigodevolucion = Txt_nodevolucion.Text;
                string sempleado = cbx_emp.Text;
                string sdescripcion = txt_descr.Text;
                string sproducto = cbx_producto.Text;
                string cantidadd = cantidad_dev.Text;

                OdbcCommand sql = new OdbcCommand("INSERT INTO tbl_orden_compra_encabezado (PK_IdComprasEncabezado, PK_IdProveedores, fecha_pedido)" +
                    " VALUES( " + scodigoOrdenCompra + ", " + scodigoProveedor + ", '" + fecha + "' )", conexion.conectar());
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
                }**/



            
        
    }
}
    }