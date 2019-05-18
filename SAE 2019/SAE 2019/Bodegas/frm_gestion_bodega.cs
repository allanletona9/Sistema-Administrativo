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

namespace SAE_2019.Bodegas
{

    public partial class frm_gestion_bodega : Form  
    {
        Navegador nv2 = new Navegador();
        public frm_gestion_bodega(DataGridView dgr)
        {
            InitializeComponent();
            llenarEmpleado();
            llenarBodegas();
            llenarproductos();
            llenarSucursales();
            nv2.nombreForm(this);
            nv2.dgv_datos(dgr);
        }

    

        void llenarBodegas()
        {
            try
            {
                OdbcCommand sql = new OdbcCommand("Select nombre_bodega from tbl_bodegas", conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    comboBox2.Items.Add(almacena.GetValue(0));
                }
                almacena.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        void llenarEmpleado()
        {
            try
            {
                OdbcCommand sql = new OdbcCommand("Select nombre_empleado from tbl_empleados", conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    comboBox1.Items.Add(almacena.GetValue(0));
                }
                almacena.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        void llenarSucursales()
        {
            try
            {
                OdbcCommand sql = new OdbcCommand("Select nombre_sucursal from tbl_surcursal", conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    comboBox4.Items.Add(almacena.GetValue(0));
                }
                almacena.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        void llenarproductos()
        {
            try
            {
                OdbcCommand sql = new OdbcCommand("Select nombre_producto from tbl_productos", conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    comboBox3.Items.Add(almacena.GetValue(0));
                }
                almacena.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }


        int idEmpleado(string name)
        {

            int id = 0;

            try
            {
                OdbcCommand sql = new OdbcCommand("Select PK_IdEmpleado from tbl_empleados where nombre_empleado = '" + name + "'", conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    id = almacena.GetInt32(0);
                }
                almacena.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return id;
        }

        int idBodega(string name)
        {
            int id = 0;

            try
            {
                OdbcCommand sql = new OdbcCommand("Select PK_IdBodegas from tbl_bodegas where nombre_bodega = '"+name+"'", conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    id = almacena.GetInt32(0);
                }
                almacena.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return id;
        }


        int idProducto(string name)
        {
            int id = 0;

            try
            {
                OdbcCommand sql = new OdbcCommand("Select PK_IdProducto from tbl_productos where nombre_producto = '" + name + "'", conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    id = almacena.GetInt32(0);
                }
                almacena.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return id;
        }



        int idSucursal(string name)
        {
            int id = 0;

            try
            {
                OdbcCommand sql = new OdbcCommand("Select PK_IdSucursal from  tbl_surcursal where nombre_sucursal = '" + name + "'", conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    id = almacena.GetInt32(0);
                }
                almacena.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return id;
        }



        bool comprobarAutorizacion()
        {

            int EmpleadoID = idEmpleado(comboBox1.Text.ToString());
            int bodegaID = idBodega(comboBox2.Text.ToString());
            int bodegaIDQ = 0;

            try
            {
                OdbcCommand sql = new OdbcCommand("Select FK_IdBodegas from  tbl_encargado_bodega where FK_IdEmpleado = '"+EmpleadoID+"'", conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                almacena.Read();

                if (almacena.HasRows)
                {

                    bodegaIDQ = almacena.GetInt32(0);

                    if (bodegaIDQ == bodegaID)
                    {
                        return true;
                    }

                }
                almacena.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return false;
        }


        bool EnviarExistencias()
        {

            int productoID = idProducto(comboBox3.Text.ToString());
            int bodegaID = idBodega(comboBox2.Text.ToString());
            int sucursalID = idSucursal(comboBox4.Text.ToString());
            int cantidad = Convert.ToInt32(Txt_existencias.Text);

            try
            {
                OdbcCommand sql = new OdbcCommand("INSERT into tbl_inventario VALUES ('','"+productoID+ "', '" + sucursalID + "', '" + bodegaID + "', '" + cantidad + "' )", conexion.conectar());
                sql.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            return false;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (comprobarAutorizacion())
            {
                MessageBox.Show("autorizado");
                comboBox4.Enabled = true;
                comboBox3.Enabled = true;
                Txt_existencias.Enabled = true;
                button2.Enabled = true;

            }
            else
            {
                MessageBox.Show("No autorizado");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (EnviarExistencias())
            {
                MessageBox.Show("Existencias enviadas a bodega");
            }
        }

        private void Lbl_admonClientes_Click(object sender, EventArgs e)
        {

        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Txt_existencias_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayuda\\" + "ORDEN.chm", "GESTION.html");
        }

        private void Txt_idProducto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_ingresarProducto_Click(object sender, EventArgs e)
        {
            if (EnviarExistencias())
            {
                MessageBox.Show("Existencias enviadas a bodega");
            }
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            if (comprobarAutorizacion())
            {
                MessageBox.Show("autorizado");
                comboBox4.Enabled = true;
                comboBox3.Enabled = true;
                Txt_existencias.Enabled = true;
                button2.Enabled = true;

            }
            else
            {
                MessageBox.Show("No autorizado");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
