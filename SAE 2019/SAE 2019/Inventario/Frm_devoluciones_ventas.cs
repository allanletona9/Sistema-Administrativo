using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;

namespace SAE_2019.Inventario
{
    public partial class Frm_devoluciones_ventas : Form
    {

        OdbcCommand cmd, cmd2;
        conexion nueva = new conexion();
        public Frm_devoluciones_ventas()
        {
            InitializeComponent();
            txtfechaR.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        void LlenarComboBox()
        {
            try
            {
                OdbcCommand sql = new OdbcCommand("Select  PK_IdFacturaEncabezado from tbl_factura_encabezado", conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    cbx_facturas.Items.Add(almacena.GetValue(0));

                }
                almacena.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        private void Frm_devoluciones_ventas_Load(object sender, EventArgs e)
        {
            LlenarComboBox2();
            LlenarComboBox();
            obtenerNumeroDevolucion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        string scodigofactura = cbx_facturas.Text;

            OdbcDataAdapter dat;
            DataSet ds;

            try
            {

                ds = new DataSet();
                dat = new OdbcDataAdapter("SELECT OCE.PK_IdProducto,T.nombre_producto, OCE.cantidad,OCE.precio,FE.total FROM tbl_factura_encabezado FE INNER JOIN tbl_factura_detalle OCE ON OCE.PK_IdFacturaEncabezado = FE.PK_IdFacturaEncabezado INNER JOIN tbl_productos T ON T.PK_IdProducto = OCE.PK_IdProducto INNER JOIN tbl_clientes C ON C.PK_IdCliente = FE.FK_IdCliente WHERE FE.PK_IdFacturaEncabezado = " + scodigofactura, conexion.conectar());
                dat.Fill(ds);
                dgv_fac.DataSource = ds.Tables[0];
                dgv_fac.Visible = true;
                try
                {
                    OdbcCommand sql = new OdbcCommand("SELECT FE.PK_Serie,FE.FK_IdCliente,C.nombre_cliente,OCE.PK_IdProducto,T.nombre_producto, OCE.cantidad,OCE.precio,FE.total FROM tbl_factura_encabezado FE INNER JOIN tbl_factura_detalle OCE ON OCE.PK_IdFacturaEncabezado = FE.PK_IdFacturaEncabezado INNER JOIN tbl_productos T ON T.PK_IdProducto = OCE.PK_IdProducto INNER JOIN tbl_clientes C ON C.PK_IdCliente = FE.FK_IdCliente WHERE FE.PK_IdFacturaEncabezado = " + scodigofactura, conexion.conectar());
                    OdbcDataReader almacena = sql.ExecuteReader();
                    while (almacena.Read() == true)
                    {
                        lbl_serie.Text = almacena.GetString(0);
                        txt_Idc.Text = almacena.GetString(1);
                        txt_nomCliente.Text = almacena.GetString(2);
                    }
                    almacena.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                


            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        int numerodeOrden = 0;
        void obtenerNumeroDevolucion()
        {

            try
            {
                // string selectQuery = "SELECT idCompra FROM encabezadocompra ORDER by idCompra DESC LIMIT 1";
                string selectQuery = "SELECT PK_IdDevolucion FROM tbl_devoluciones_encabezado_ventas ORDER by PK_IdDevolucion DESC LIMIT 1";

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
                    lbl_dev.Text = numerodeOrden + "";

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

        void LlenarComboBox2()
        {
            try
            {
                OdbcCommand sql = new OdbcCommand("Select  PK_IdEmpleado,nombre_empleado  from tbl_empleados  where Estado_empleado = 1 " , conexion.conectar());
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
        private void btn_agregar_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgv_fac.SelectedRows)
            {
          
                String A,B,C,D,E;
                C=txt_cantidad.Text;
             
                A = this.dgv_fac.CurrentRow.Cells[0].Value.ToString();
                B= this.dgv_fac.CurrentRow.Cells[1].Value.ToString();
               //C = this.dgv_fac.CurrentRow.Cells[2].Value.ToString(); 
                D = this.dgv_fac.CurrentRow.Cells[3].Value.ToString();
                E = this.dgv_fac.CurrentRow.Cells[4].Value.ToString();
                dvg_devolucion.Rows.Add(A, B, C, D, E);
               
                   

               
            }
        }


        private void dataGridView_fac_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

       

           
    }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
         
            string scodigofactura = cbx_facturas.Text;
            string IdDevolucion = lbl_dev.Text;

            string scodigodevolucion = Txt_nodevolucion.Text;
            string sempleado = cbx_emp.Text;
            string sdescripcion = txt_descr.Text;
            string scodigoDevolucion = Txt_nodevolucion.Text;
            string sestado_dev = Txt_estado.Text;
           
            try
            {

                OdbcCommand sql = new OdbcCommand("UPDATE tbl_inventario I, tbl_devoluciones_detalle_ventas FE, tbl_devoluciones_encabezado_ventas D, tbl_factura_detalle F, tbl_factura_encabezado E SET F.cantidad = F.cantidad - FE.cantidad_producto, I.existencia = I.existencia + FE.cantidad_producto, E.total = E.total - (FE.cantidad_producto * F.precio), FE.cantidad_producto = FE.cantidad_producto - FE.cantidad_producto, D.estado_devolucion = 0 WHERE D.PK_IdDevolucion = " + scodigoDevolucion + " AND I.PK_IdSucursal = FE.FK_IdSucursal AND I.PK_IdProducto = FE.FK_IdProducto", conexion.conectar());
               
                //OdbcDataReader almacena = sql.ExecuteReader();
                sql.ExecuteNonQuery();
                MessageBox.Show("Devolucion Gestionada");
                OdbcDataAdapter dat;
                DataSet ds;

                try
                {


                    ds = new DataSet();
                    dat = new OdbcDataAdapter("SELECT OCE.PK_IdProducto,T.nombre_producto, OCE.cantidad,OCE.precio,FE.total FROM tbl_factura_encabezado FE INNER JOIN tbl_factura_detalle OCE ON OCE.PK_IdFacturaEncabezado = FE.PK_IdFacturaEncabezado INNER JOIN tbl_productos T ON T.PK_IdProducto = OCE.PK_IdProducto INNER JOIN tbl_clientes C ON C.PK_IdCliente = FE.FK_IdCliente WHERE FE.PK_IdFacturaEncabezado = " + scodigofactura, conexion.conectar());
                    dat.Fill(ds);
                    dgv_fac.DataSource = ds.Tables[0];
                    dgv_fac.Visible = true;

                }
                catch (OdbcException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DateTime fechaHoy = DateTime.Now;
            string scodigofactura = cbx_facturas.Text;
            string prod_nom;
            string cant_dev;
            // string cargar;

            string scodigodevolucion = Txt_nodevolucion.Text;
            string sempleado = cbx_emp.Text;
            string sdescripcion = txt_descr.Text;
            string scodigoDevolucion = Txt_nodevolucion.Text;
            string sestado_dev = Txt_estado.Text;

            string fecha = fechaHoy.ToString("d");

            try
            {


                cmd = new OdbcCommand("INSERT INTO tbl_devoluciones_encabezado_ventas(PK_IdDevolucion, FK_IdEmpleado,descripcion_devolucion, fecha_solicitud,estado_devolucion) VALUES('" + scodigodevolucion + "', '" + sempleado + "', '" + sdescripcion + "', '" + txtfechaR.Text + "','" + sestado_dev + "')", conexion.conectar());

                cmd.ExecuteNonQuery();
                foreach (DataGridViewRow Fila in dvg_devolucion.Rows)
                {


                    prod_nom = Fila.Cells[0].Value.ToString();
                    cant_dev = Fila.Cells[2].Value.ToString();

                    cmd2 = new OdbcCommand("INSERT INTO tbl_devoluciones_detalle_ventas (FK_IdDevolucion,FK_IdFacturaEncabezado,FK_serie,FK_IdSucursal,FK_IdProducto , cantidad_producto) " +
               "VALUES ('" + scodigodevolucion + "','" + cbx_facturas.Text + "','" + lbl_serie.Text + "','" + lbl_sucur.Text + "','" + prod_nom + "','" + cant_dev + "' )", conexion.conectar());
                    cmd2.ExecuteNonQuery();
                }

                MessageBox.Show("Solicitud Ingresada");

                ////////////////////////////////////////////////////////////////////////////





            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString());

            }

        }

        private void cbx_emp_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id_emp = cbx_emp.Text;
            try
            {
                OdbcCommand sql = new OdbcCommand("SELECT FE.PK_IdEmpleado,FE.nombre_empleado,FE.FK_IdSucursal ,OCE.nombre_sucursal FROM tbl_empleados FE INNER JOIN tbl_surcursal OCE ON OCE.PK_IdSucursal = FE.FK_IdSucursal WHERE FE.PK_IdEmpleado = " + id_emp, conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    txt_nombre.Text = almacena.GetString(1);
                    lbl_sucur.Text = almacena.GetString(2);
                    txt_sucursal.Text=almacena.GetString(3);


                }

                almacena.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());


            }

        }

        private void cbx_facturas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


