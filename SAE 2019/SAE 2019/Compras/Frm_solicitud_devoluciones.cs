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
    public partial class Frm_solicitud_devoluciones : Form
    {
       
        OdbcCommand cmd, cmd2;
        conexion nueva = new conexion();
        public Frm_solicitud_devoluciones()
        {
            InitializeComponent();
            txtfechaR.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

           
        }
        void LlenarComboBox()
        {
            try
            {
                OdbcCommand sql = new OdbcCommand("Select  PK_IdEmpleado from tbl_empleados where Estado_empleado = 1", conexion.conectar());
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
                OdbcCommand sql = new OdbcCommand("Select PK_IdProducto from tbl_productos where Estado_producto = 1", conexion.conectar());
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
                string selectQuery = "SELECT PK_IdDevolucion FROM tbl_devoluciones_encabezado ORDER by PK_IdDevolucion DESC LIMIT 1";

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
        private void Frm_solicitud_devoluciones_Load(object sender, EventArgs e)
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
            if (sempleado != "") 
    {
                if (sdescripcion != "")
                {
                  if (cantidadd != "0")
                    {

                        try
                        {

                            DataGridViewRow filas = new DataGridViewRow();
                            filas.CreateCells(dataGridView_dev);
                            filas.Cells[0].Value = scodigodevolucion;
                            filas.Cells[1].Value = sempleado;
                            filas.Cells[2].Value = sdescripcion;
                            filas.Cells[3].Value = sproducto;
                            filas.Cells[4].Value = cantidadd;
                            dataGridView_dev.Rows.Add(filas);

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ingrese todos los campos");

                    }

                }
                else
                {
                    MessageBox.Show("Ingrese todos los campos");

                }


            }
            else
            {
                MessageBox.Show("Ingrese todos los campos");

            }
           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string scodigoProducto = cbx_producto.Text;
            try
            {
                OdbcCommand sql = new OdbcCommand("Select nombre_producto from tbl_productos where PK_IdProducto = " + scodigoProducto + " and Estado_producto = 1", conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    text_prod.Text = almacena.GetString(0);
                }
                almacena.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Help.ShowHelp(this, "C:\\Ayuda\\" + "Devoluciones.chm", "COMPRAS.html");
        }

        private void Lbl_facturas_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Lbl_noOrden_Click(object sender, EventArgs e)
        {

        }

        private void Txt_nodevolucion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

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
                    txt_nom_emp.Text = almacena.GetString(1);
                    lbl_sucur.Text = almacena.GetString(2);
                    txt_sucursal.Text = almacena.GetString(3);


                }

                almacena.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());


            }
        }

        private void dataGridView_dev_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {

            DateTime fechaHoy = DateTime.Now;
            string cod_dev;

           string emp;
            string descr_dev;
            string prod_nom;
            string cant_dev;
           // string cargar;
            string combo_prod = cbx_producto.Text.ToString();
            string prod = cbx_producto.Text.ToString();
            string scodigodevolucion = Txt_nodevolucion.Text;
            string sempleado = cbx_emp.Text;
            string sdescripcion = txt_descr.Text;
            string sproducto = cbx_producto.Text;
            string cantidadd = cantidad_dev.Text;
            string scodigoDevolucion = Txt_nodevolucion.Text;
            string sestado_dev = Txt_estado.Text;
            string sucursal = txt_sucursal.Text;

            string fecha = fechaHoy.ToString("d");
            
                
            try
            {


                cmd = new OdbcCommand("INSERT INTO tbl_devoluciones_encabezado(PK_IdDevolucion, FK_IdEmpleado,descripcion_devolucion, fecha_solicitud,estado_devolucion) VALUES('" + scodigodevolucion + "', '" + sempleado + "', '" + sdescripcion + "', '" + txtfechaR.Text + "','" + sestado_dev + "')", conexion.conectar());

                cmd.ExecuteNonQuery();
                foreach (DataGridViewRow Fila in dataGridView_dev.Rows)
                {

                    cod_dev = Fila.Cells[0].Value.ToString();
                    emp = Fila.Cells[1].Value.ToString();
                    descr_dev = Fila.Cells[2].Value.ToString();
                    prod_nom = Fila.Cells[3].Value.ToString();
                    cant_dev = Fila.Cells[4].Value.ToString();

                    cmd2 = new OdbcCommand("INSERT INTO tbl_devoluciones_detalle (FK_IdDevolucion, FK_IdProducto, cantidad_producto,FK_IdSucursal ) " +
               "VALUES ('" + scodigodevolucion + "','" + prod_nom + "','" + cant_dev + "','" + lbl_sucur.Text + "' )", conexion.conectar());
                    cmd2.ExecuteNonQuery();


                }

                MessageBox.Show("Solicitud Ingresada");
              

              

            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.ToString());

            }






        }




        }
}
    