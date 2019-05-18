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
using CapaDiseno;
namespace SAE_2019.Compras

{

    public partial class Frm_Gestion_Devolucion1 : Form
{
    Navegador nv = new Navegador();
    OdbcCommand cmd, cmd2;
    conexion nueva = new conexion();
        
            
     

        public Frm_Gestion_Devolucion1()
        {
            InitializeComponent();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        void LlenarComboBox()
        {
            try
            {
               
                OdbcCommand sql = new OdbcCommand("Select  PK_IdDevolucion from tbl_devoluciones_encabezado where estado_devolucion = 1", conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    cbx_devolucion.Items.Add(almacena.GetValue(0));
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

        private void Gestion_Devolucion_Load(object sender, EventArgs e)
        {
            LlenarComboBox();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            Frm_vista_devoluciones vista_devoluciones = new Frm_vista_devoluciones();
            vista_devoluciones.Show();
        }

        private void cbx_devolucion_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            string scodigoProducto = cbx_devolucion.Text;
            string IdDevolucion = cbx_devolucion.SelectedItem.ToString();

            try
            {
                
                OdbcCommand sql = new OdbcCommand("UPDATE tbl_inventario I, tbl_devoluciones_encabezado D, tbl_devoluciones_detalle FE SET I.existencia = I.existencia - FE.cantidad_producto  ,FE.cantidad_producto = FE.cantidad_producto - FE.cantidad_producto ,D.estado_devolucion = 0 WHERE D.PK_IdDevolucion = " + IdDevolucion + " AND FE.FK_IdDevolucion = " + IdDevolucion + " AND I.PK_IdSucursal = FE.FK_IdSucursal AND I.PK_IdProducto = FE.FK_IdProducto", conexion.conectar());
               
                //OdbcDataReader almacena = sql.ExecuteReader();
                sql.ExecuteNonQuery();
                MessageBox.Show("Devolucion Gestionada");
                OdbcDataAdapter dat;
                DataSet ds;

                try
                {

                    ds = new DataSet();
                    dat = new OdbcDataAdapter("SELECT FE.FK_IdDevolucion, FE.FK_IdProducto,OCE.nombre_producto, FE.cantidad_producto,OCE.precio_producto , OCE.descrip_producto FROM tbl_devoluciones_detalle FE INNER JOIN tbl_productos OCE ON OCE.PK_IdProducto = FE.FK_IdProducto WHERE FE.FK_IdDevolucion = " + scodigoProducto, conexion.conectar());
                    dat.Fill(ds);
                    dataGridView_dev.DataSource = ds.Tables[0];
                    dataGridView_dev.Visible = true;
               
                }
                catch (OdbcException ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }

        private void dataGridView_dev_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string scodigoProducto = cbx_devolucion.Text;

         
            OdbcDataAdapter dat;
            DataSet ds;

            try
            {
               
                ds = new DataSet();
                dat = new OdbcDataAdapter("SELECT FE.FK_IdDevolucion,FE.FK_IdSucursal, FE.FK_IdProducto,OCE.nombre_producto, FE.cantidad_producto,OCE.precio_producto , OCE.descrip_producto FROM tbl_devoluciones_detalle FE INNER JOIN tbl_productos OCE ON OCE.PK_IdProducto = FE.FK_IdProducto WHERE FE.FK_IdDevolucion = " + scodigoProducto, conexion.conectar()); 
                dat.Fill(ds);
                dataGridView_dev.DataSource = ds.Tables[0];
                dataGridView_dev.Visible = true;

            }
            catch (OdbcException ex)
            {
                MessageBox.Show(ex.Message);
            }
           


        }
    }
}

