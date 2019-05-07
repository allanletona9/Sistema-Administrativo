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
    public partial class Frm_OrdenCompra : Form
    {
        public Frm_OrdenCompra()
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
        int numeroFila = 0;

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
            bool validacionConsulta=false;
            string scodigoProducto = Txt_codigoProducto.Text;
            try
            {
                if (string.IsNullOrEmpty(Txt_codigoProducto.Text))
                {
                    MessageBox.Show("Debe ingresar un codigo para la consulta");
                }
                else
                {
                    OdbcCommand sql = new OdbcCommand("Select nombre_producto, descrip_producto from tbl_productos where PK_IdProducto = " + scodigoProducto + " and Estado_producto = 1", conexion.conectar());
                    OdbcDataReader almacena = sql.ExecuteReader();
                    while (almacena.Read() == true)
                    {
                        validacionConsulta = true;
                        Txt_nombreProducto.Text = almacena.GetString(0);
                        TxtDescripcionProducto.Text = almacena.GetString(1);
                    }
                    if (validacionConsulta == false)
                    {
                        MessageBox.Show("El codigo de producto no existe");
                        Txt_nombreProducto.Clear();
                        TxtDescripcionProducto.Clear();
                        Txt_codigoProducto.Clear();
                        Txt_codigoProducto.Focus();
                    }
                    almacena.Close();
                }
                
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
                if (buscarProductoRepetido(scodigoProducto))
                {
                    MessageBox.Show("El codigo ya ha sido registrado");
                    Txt_nombreProducto.Clear();
                    TxtDescripcionProducto.Clear();
                    Txt_codigoProducto.Clear();
                }
                else
                {
                    if (string.IsNullOrEmpty(Txt_codigoProducto.Text))
                    {
                        MessageBox.Show("Debe consultar el producto para ingresarlo a la orden de compra");

                    }
                    else
                    {

                        OdbcCommand sql = new OdbcCommand("Select nombre_producto, descrip_producto, precio_producto from tbl_productos where PK_IdProducto = " + scodigoProducto + " and Estado_producto = 1", conexion.conectar());
                        OdbcDataReader almacena = sql.ExecuteReader();
                        while (almacena.Read() == true)
                        {
                        

                            DataGridViewRow filas = new DataGridViewRow();
                            filas.CreateCells(dgv_ordenCompra);

                            filas.Cells[0].Value = scodigoProducto;
                            filas.Cells[1].Value = almacena.GetString(0);
                            filas.Cells[2].Value = almacena.GetString(1);
                            filas.Cells[3].Value = almacena.GetString(2);

                            dgv_ordenCompra.Rows.Add(filas);
                        }
                        Txt_nombreProducto.Clear();
                        TxtDescripcionProducto.Clear();
                        Txt_codigoProducto.Clear();
                        almacena.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            Txt_codigoProducto.Focus();
        }
        bool buscarProductoRepetido(string codigo)
        {
            bool encontrado = false;

            foreach (DataGridViewRow row in dgv_ordenCompra.Rows)
            {
                try
                {
                   // string scodigoOrdenCompra = Txt_noOrdenCompra.Text;
                     string validar = Convert.ToString(row.Cells[0].Value);
                    if (row.Cells[0].Value != null)
                    {
                       if (validar == codigo)
                        {
                            encontrado = true;
                            
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            }
            return encontrado;
        }

        bool validacionColumnaCantidad()
        {
            bool encontrado = false;

            foreach (DataGridViewRow row in dgv_ordenCompra.Rows)
            {
                try
                {
                    // string scodigoOrdenCompra = Txt_noOrdenCompra.Text;
                    string validar = Convert.ToString(row.Cells[4].Value);
                    if (row.Cells[0].Value != null)
                    {
                        if (row.Cells[4].Value == null)
                        {
                            encontrado = true;
                            row.Cells[4].Style.BackColor = Color.OrangeRed;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());

                }
            }
            return encontrado;
        }




        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");
          //  MessageBox.Show(fecha);
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
                MessageBox.Show("Debe seleccionar un proveedor para el registro de la orden de compra");
                Cbo_proveedor.Focus();
            }

            if (validacionProveedor == false)
            {

                //validar en el grid que no hayan cantidades vacias
                if (validacionColumnaCantidad())
                {
                    MessageBox.Show("Debe ingresar una cantidad de productos para la cotizacion");
                }
                else
                {
                    //valida que hayan datos en el grid para poder guardarlos en la bd
                    if (dgv_ordenCompra.Rows.Count > 0)
                    {

                        try
                        {
                            string scodigoOrdenCompra = Txt_noOrdenCompra.Text;
                            string stotalOrdenCompra = Txt_total.Text;

                            OdbcCommand sql = new OdbcCommand("INSERT INTO tbl_orden_compra_encabezado (PK_IdComprasEncabezado, PK_IdProveedores, fecha_pedido, total)" +
                            " VALUES( " + scodigoOrdenCompra + ", " + scodigoProveedor + ", '" + fecha + "' , " + stotalOrdenCompra + " )", conexion.conectar());
                            sql.ExecuteNonQuery();
                            conexion.cerrarConexion();
                            try
                            {
                                
                                sql = new OdbcCommand("INSERT INTO tbl_compras (PK_IdComprasEncabezado, fecha_compra, fecha_modificacion, Tracking_compra, estado_compra)" +
                                " VALUES( " + scodigoOrdenCompra + ", '" + fecha + "', '" + fecha + "' , 'En espera de respuesta por el proveedor', '1')", conexion.conectar());
                                sql.ExecuteNonQuery();

                                conexion.cerrarConexion();




                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.ToString());
                            }




                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }

                        try
                        {
                            foreach (DataGridViewRow row in dgv_ordenCompra.Rows)
                            {
                                try
                                {
                                    string scodigoOrdenCompra = Txt_noOrdenCompra.Text;
                                    if (row.Cells[0].Value != null)
                                    {

                                        OdbcCommand sql = new OdbcCommand("INSERT INTO tbl_orden_compra_detalle (PK_IdComprasEncabezado, PK_IdProducto, Precio, Cantidad)" +
                             " VALUES ( " + scodigoOrdenCompra + ", " + Convert.ToString(row.Cells[0].Value) + ", " + Convert.ToString(row.Cells[3].Value) + ", " + Convert.ToString(row.Cells[4].Value) + " )", conexion.conectar());
                                        sql.ExecuteNonQuery();
                                        conexion.cerrarConexion();

                                       
                                    }
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show(ex.ToString());

                                }
                            }
                            MessageBox.Show("Orden de compra con el codigo: "+Txt_noOrdenCompra.Text+" almacenada exitosamente!");

                            limpiarForm();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se puede generar una orden de compra sin productos en listados");
                    }
                }
            }
        }

        void limpiarForm()
        {
            Cbo_proveedor.Items.Clear();
            Cbo_proveedor.Text = "";
            TxtDescripcionProducto.Clear();
            Txt_codigoProducto.Clear();
            Txt_nombreProducto.Clear();
            Txt_total.Clear();
            dgv_ordenCompra.Rows.Clear();
            llenarComboBox();
            obtenerNumeroOrdenCompra();
        }
        private void Btn_modificar_Click(object sender, EventArgs e)
        {
         
        }
        private void dgv_ordenCompra_CellParsing(object sender, DataGridViewCellParsingEventArgs e)
        {
            numeroFila = Convert.ToInt32(e.RowIndex);
            if (e.Value != null)
            {
                dgv_ordenCompra.Rows[numeroFila].Cells[4].Style.BackColor = Color.White;
            }
        }

        private void Btn_eliminarProducto_Click(object sender, EventArgs e)
        {
            if (dgv_ordenCompra.Rows.Count > 0)
            {
                dgv_ordenCompra.Rows.Remove(dgv_ordenCompra.Rows[numeroFila]);
                MessageBox.Show("Producto eliminado");
                actualizarTotal();
            }
            else
            {
                MessageBox.Show("La tabla de productos para la orden de compra se encuentra vacia");
            }
            if(dgv_ordenCompra.Rows.Count == 0)
            {
                Txt_total.Clear();
            }
        }

        private void dgv_ordenCompra_Enter(object sender, EventArgs e)
        {

        }

        private void dgv_ordenCompra_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            numeroFila = Convert.ToInt32(e.RowIndex);
            int numero;
            //para verificar la conversion del numero recien ingresado por el usuario y validar su integridad 
            try
            {
                numero = Convert.ToInt32(dgv_ordenCompra.Rows[numeroFila].Cells[4].Value);
                if (numero <= 0)
                {
                    MessageBox.Show("La cantidad ingresada debe ser un numero entero positivo mayor a 0");
                    dgv_ordenCompra.Rows[numeroFila].Cells[4].Value = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("La cantidad ingresada no es un numero entero");
                dgv_ordenCompra.Rows[numeroFila].Cells[4].Value = null;
            }
            actualizarTotal();
        }

        private void actualizarTotal()
        {
            double total = 0;

            foreach (DataGridViewRow row in dgv_ordenCompra.Rows)
            {
                try
                {
                    // string scodigoOrdenCompra = Txt_noOrdenCompra.Text;
                    string validar = Convert.ToString(row.Cells[4].Value);
                    if (row.Cells[0].Value != null)
                    {
                        if (row.Cells[4].Value != null)
                        {
                            double precio = Convert.ToDouble(row.Cells[3].Value);
                            double cantidad = Convert.ToDouble(row.Cells[4].Value);
                            total = (precio * cantidad) + total;
                        }
                    }
                    Txt_total.Text = total + "";
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        private void dgv_ordenCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            numeroFila = Convert.ToInt32(e.RowIndex);
        }

        private void dgv_ordenCompra_CellStateChanged(object sender, DataGridViewCellStateChangedEventArgs e)
        {
            numeroFila = Convert.ToInt32(e.Cell.RowIndex);
        }

        private void dgv_ordenCompra_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Txt_codigoProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Lbl_gastosEnvio_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayuda\\" + "ORDEN.chm", "GESTION.html");
        }
    }
}
