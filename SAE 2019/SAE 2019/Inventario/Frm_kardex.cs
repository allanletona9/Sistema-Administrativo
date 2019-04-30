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
using InicioSesion;

namespace SAE_2019.Inventario
{
    public partial class Frm_kardex : Form
    {
        public Frm_kardex()
        {
            InitializeComponent();
        }
        string codigousuario=null;
        string codigoSucursal = null;

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_minimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_kardex_Load(object sender, EventArgs e)
        {
            Usuario u = new Usuario();
           codigousuario = Convert.ToString(u.obtenerCodigoUsuario());
            sucursalEmpleado();

        }

        private void Btn_buscarOrdenCompra_Click(object sender, EventArgs e)
        {
            dgv_kardex.Rows.Clear();
            // MessageBox.Show("El usuario es:" + codigousuario);
            ConsultaInventario();

            consultaCompras();

            consultaVentas();

            consultaDevoluciones();
        }



        //para obtener el codigo de sucursal del empleado
        private void sucursalEmpleado()
        {

            try
            {
                string selectQuery = "select e.FK_IdSucursal from tbl_usuario u inner join tbl_empleados e on u.FK_IdEmpleado = e.PK_IdEmpleado where u.PK_Usu_Codigo = " + codigousuario;

                OdbcCommand sql = new OdbcCommand(String.Format(selectQuery), conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    codigoSucursal = almacena.GetString(0);

                }
                almacena.Close();


            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");
            }

        }


        //este metodo realiza consutlas unicamente para el inventario 
        //al que esta registrado el empleado segun la sucursal en la que trabaja
        //puede tener varios inventario porque puede tener varias bodegas

        string nombreBodega = null;

        private void ConsultaInventario()
        {

            bool validacionProducto = false;
            try
            {
                string codigoProducto = Txt_codigoProducto.Text;
                string selectQuery = "SELECT I.existencia, B.nombre_bodega FROM tbl_inventario I INNER JOIN tbl_bodegas B ON I.PK_IdBodegas = B.PK_IdBodegas WHERE PK_IdProducto = "+ codigoProducto +" AND I.PK_IdSucursal = "+ codigoSucursal;

                OdbcCommand sql = new OdbcCommand(String.Format(selectQuery), conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    validacionProducto = true;

                    txt_existencias.Text = almacena.GetString(0);
                    nombreBodega = almacena.GetString(1);
                }
                almacena.Close();

                if(validacionProducto == false)
                {
                    MessageBox.Show("El producto no existe en el inventario de la sucursal ");
                    Txt_codigoProducto.Clear();
                    Txt_codigoProducto.Focus();
                }
            }
            catch (Exception)
            {

            }
        }

        //busca en el encabezado de compras por el id de la sucursal y luego busca todos los productos en todas las compras
        //***************falta terminar*********************
        private void consultaCompras()
        {

            try
            {
                string codigoProducto = Txt_codigoProducto.Text;
                string selectQuery = "SELECT C.PK_IdProducto, C.nombre_producto, A.PK_IdComprasEncabezado, A.fecha_pedido, B.Cantidad FROM tbl_orden_compra_encabezado A INNER JOIN tbl_orden_compra_detalle B ON A.PK_IdComprasEncabezado = B.PK_IdComprasEncabezado INNER JOIN tbl_productos C ON B.PK_IdProducto = C.PK_IdProducto INNER JOIN tbl_compras CO ON CO.PK_IdComprasEncabezado = A.PK_IdComprasEncabezado WHERE B.PK_IdProducto = " + codigoProducto + " AND A.FK_IdSucursal = "+codigoSucursal+ " AND CO.Tracking_compra = 'Orden entregada'";

                OdbcCommand sql = new OdbcCommand(String.Format(selectQuery), conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    DataGridViewRow filas = new DataGridViewRow();
                    filas.CreateCells(dgv_kardex);

                    filas.Cells[0].Value = almacena.GetString(0);
                    filas.Cells[1].Value = almacena.GetString(1);
                    filas.Cells[2].Value = nombreBodega;
                    filas.Cells[3].Value = almacena.GetString(2);
                    filas.Cells[4].Value = "Compra";
                    filas.Cells[5].Value = almacena.GetString(3);
                    filas.Cells[6].Value = "INGRESO";
                    filas.Cells[7].Value = almacena.GetString(4);

                    dgv_kardex.Rows.Add(filas);
                }
                almacena.Close();

            }
            catch (Exception)
            {

            }

        }

        private void consultaVentas()
        {
            try
            {
                string codigoProducto = Txt_codigoProducto.Text;
                string selectQuery = "SELECT C.PK_IdProducto, C.nombre_producto, A.PK_IdFacturaEncabezado, A.fecha_venta, B.cantidad FROM tbl_factura_encabezado A INNER JOIN tbl_factura_detalle B ON A.PK_IdFacturaEncabezado = B.PK_IdFacturaEncabezado INNER JOIN tbl_productos C ON B.PK_IdProducto = C.PK_IdProducto INNER JOIN tbl_usuario D ON D.PK_Usu_Codigo = A.FK_Usu_Codigo INNER JOIN tbl_empleados E ON D.FK_IdEmpleado = E.PK_IdEmpleado WHERE B.PK_IdProducto = " + codigoProducto + " AND E.FK_IdSucursal = " + codigoSucursal+ " AND A.Identificador = 'factura'";

                OdbcCommand sql = new OdbcCommand(String.Format(selectQuery), conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    DataGridViewRow filas = new DataGridViewRow();
                    filas.CreateCells(dgv_kardex);

                    filas.Cells[0].Value = almacena.GetString(0);
                    filas.Cells[1].Value = almacena.GetString(1);
                    filas.Cells[2].Value = nombreBodega;
                    filas.Cells[3].Value = almacena.GetString(2);
                    filas.Cells[4].Value = "Venta";
                    filas.Cells[5].Value = almacena.GetString(3);
                    filas.Cells[6].Value = "EGRESO";
                    filas.Cells[7].Value = almacena.GetString(4);

                    dgv_kardex.Rows.Add(filas);
                }
                almacena.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e + "");

            }
        }

        private void consultaDevoluciones()
        {
            try
            {
                string codigoProducto = Txt_codigoProducto.Text;
                string selectQuery = "SELECT B.FK_IdProducto, D.nombre_producto, A.PK_IdDevolucion, A.fecha_solicitud, B.cantidad_producto FROM tbl_devoluciones_encabezado A INNER JOIN tbl_devoluciones_detalle B ON A.PK_IdDevolucion = B.FK_IdDevolucion INNER JOIN tbl_empleados C ON A.FK_IdEmpleado = C.PK_IdEmpleado INNER JOIN tbl_productos D ON B.FK_IdProducto = D.PK_IdProducto WHERE B.FK_IdProducto = " + codigoProducto + " AND C.FK_IdSucursal = " + codigoSucursal;

                OdbcCommand sql = new OdbcCommand(String.Format(selectQuery), conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    DataGridViewRow filas = new DataGridViewRow();
                    filas.CreateCells(dgv_kardex);

                    filas.Cells[0].Value = almacena.GetString(0);
                    filas.Cells[1].Value = almacena.GetString(1);
                    filas.Cells[2].Value = nombreBodega;
                    filas.Cells[3].Value = almacena.GetString(2);
                    filas.Cells[4].Value = "Devolucion a proveedor";
                    filas.Cells[5].Value = almacena.GetString(3);
                    filas.Cells[6].Value = "EGRESO";
                    filas.Cells[7].Value = almacena.GetString(4);

                    dgv_kardex.Rows.Add(filas);
                }
                almacena.Close();

            }
            catch (Exception)
            {

            }
        }

    }
}
