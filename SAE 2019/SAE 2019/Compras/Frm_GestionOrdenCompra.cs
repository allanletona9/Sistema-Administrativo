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
    public partial class Frm_GestionOrdenCompra : Form
    {
        public Frm_GestionOrdenCompra()
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

        private void button1_Click(object sender, EventArgs e)
        {
            bool validacionConsulta = false;
            string scodigoOrden = Txt_codigoCompra.Text;
            try
            {
                if (string.IsNullOrEmpty(Txt_codigoCompra.Text))
                {
                    MessageBox.Show("Debe ingresar un codigo para la consulta");
                }
                else
                {
                    OdbcCommand sql = new OdbcCommand("SELECT " +
                        "C.PK_IdComprasEncabezado, C.fecha_compra, C.fecha_modificacion, C.Tracking_compra, P.nombre_proveedor " +
                        "FROM tbl_compras C INNER JOIN tbl_orden_compra_encabezado OCE " +
                        "ON C.PK_IdComprasEncabezado = OCE.PK_IdComprasEncabezado " +
                        "INNER JOIN tbl_proveedores P ON OCE.PK_IdProveedores = P.PK_IdProveedores  " +
                        "WHERE C.estado_compra= '1' AND C.PK_IdComprasEncabezado = " + scodigoOrden + " ", conexion.conectar());
                    OdbcDataReader almacena = sql.ExecuteReader();
                    while (almacena.Read() == true)
                    {
                        validacionConsulta = true;
                        Txt_fechaCreacion.Text = almacena.GetString(1);
                        Txt_fechaActualizacion.Text = almacena.GetString(2);
                        Txt_proveedor.Text = almacena.GetString(3);
                        Txt_tracking.Text = almacena.GetString(4);

                    }
                    if (validacionConsulta == false)
                    {
                        MessageBox.Show("El codigo de orden no existe");
                        Txt_fechaCreacion.Clear();

                        Txt_fechaActualizacion.Clear();
                        Txt_proveedor.Clear();
                        Txt_tracking.Clear();
                        Txt_codigoCompra.Focus();
                    }
                    almacena.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void Frm_GestionOrdenCompra_Load(object sender, EventArgs e)
        {
            Cbo_tracking.Items.Add("orden recivida por el proveedor");
            Cbo_tracking.Items.Add("orden lista en bodega del proveedor");
            Cbo_tracking.Items.Add("orden en transporte");
            Cbo_tracking.Items.Add("orden entregada");
            llenarGridCompras();
        }

        void llenarGridCompras()
        {
            try
            {
                
                    OdbcCommand sql = new OdbcCommand("SELECT " +
                        "C.PK_IdComprasEncabezado, C.fecha_compra, C.fecha_modificacion, C.Tracking_compra, P.nombre_proveedor " +
                        "FROM tbl_compras C INNER JOIN tbl_orden_compra_encabezado OCE " +
                        "ON C.PK_IdComprasEncabezado = OCE.PK_IdComprasEncabezado " +
                        "INNER JOIN tbl_proveedores P ON OCE.PK_IdProveedores = P.PK_IdProveedores  " +
                        "WHERE C.estado_compra= '1' ", conexion.conectar());
                    OdbcDataReader almacena = sql.ExecuteReader();
                    while (almacena.Read() == true)
                    {
                    DataGridViewRow filas = new DataGridViewRow();
                    filas.CreateCells(Dgv_mostrarFacturas);

                    filas.Cells[0].Value = almacena.GetString(0);
                    filas.Cells[1].Value = almacena.GetString(1);
                    filas.Cells[2].Value = almacena.GetString(2);
                    filas.Cells[3].Value = almacena.GetString(3);

                    Dgv_mostrarFacturas.Rows.Add(filas);
        

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


            if (string.IsNullOrEmpty(Txt_codigoCompra.Text))
            {
                MessageBox.Show("Debe consultar una compra para poder modificarla");
                Txt_codigoCompra.Focus();

            }
            else
            {

                if (Cbo_tracking.SelectedItem != null)
                {
                    string tracking = Cbo_tracking.SelectedItem.ToString();
                    string orden = Txt_codigoCompra.Text;
                    string fecha = DateTime.Now.ToString("yyyy-MM-dd");
                    // MessageBox.Show(tracking);



                    try
                    {

                        OdbcCommand sql = new OdbcCommand("update tbl_compras set Tracking_compra = '" + tracking + "' , fecha_modificacion = '" + fecha + "' where PK_IdComprasEncabezado = " + orden, conexion.conectar());
                        sql.ExecuteNonQuery();

                        conexion.cerrarConexion();

                        
                        limpiarFroma();
                        llenarGridCompras();
                        MessageBox.Show("Compra actulizada correctamente");

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }


                }
                else
                {

                    MessageBox.Show("Debe seleccionar un tracking para la compra");
                    Cbo_tracking.Focus();
                }
            }
           
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Txt_codigoCompra_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            limpiarFroma();
            llenarGridCompras();

        }


        void limpiarFroma()
        {
            Dgv_mostrarFacturas.Rows.Clear();
            Txt_codigoCompra.Clear();
            Txt_fechaActualizacion.Clear();
            Txt_fechaCreacion.Clear();
            Txt_proveedor.Clear();
            Txt_tracking.Clear();
            Cbo_tracking.SelectedItem = null;
            Cbo_tracking.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayuda\\" + "GESTIONN.chm", "GESTION2.html");
        }
    }
}
