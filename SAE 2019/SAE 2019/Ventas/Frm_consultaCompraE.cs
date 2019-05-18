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
using InicioSesion;

namespace SAE_2019.Ventas
{
    public partial class Frm_consultaCompraE : Form
    {
        Usuario user = new Usuario();
        string codUsuario = "";
        string consultaMostrar = "";

        public Frm_consultaCompraE()
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

        private void Frm_consultaCompraE_Load(object sender, EventArgs e)
        {
            codUsuario = Convert.ToString(user.obtenerCodigoUsuario());

            try
            {
                consultaMostrar = "SELECT OC.PK_IdComprasEncabezado, OC.FK_IdProveedores, OC.FK_IdSucursal, OC.fecha_pedido, OC.total FROM tbL_orden_compra_encabezado OC INNER JOIN tbl_compras C ON OC.PK_IdComprasEncabezado = C.PK_IdComprasEncabezado INNER JOIN tbl_surcursal S ON OC.FK_IdSucursal = S.PK_IdSucursal INNER JOIN tbl_empleados E ON S.PK_IdSucursal = E.FK_IdSucursal INNER JOIN tbl_usuario U ON E.PK_IdEmpleado = U.FK_IdEmpleado WHERE U.PK_Usu_Codigo = " +codUsuario+ " AND C.Tracking_compra = 'orden entregada';";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, conexion.conectar());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while(mostrarDatos.Read())
                {
                    Dgv_consultaCompra.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2),
                        mostrarDatos.GetString(3), mostrarDatos.GetString(4));
                }
            }
            catch(Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            codUsuario = Convert.ToString(user.obtenerCodigoUsuario());

            try
            {
                Dgv_consultaCompra.Rows.Clear();

                consultaMostrar = "SELECT OC.PK_IdComprasEncabezado, OC.FK_IdProveedores, OC.FK_IdSucursal, OC.fecha_pedido, OC.total FROM tbL_orden_compra_encabezado OC INNER JOIN tbl_compras C ON OC.PK_IdComprasEncabezado = C.PK_IdComprasEncabezado INNER JOIN tbl_surcursal S ON OC.FK_IdSucursal = S.PK_IdSucursal INNER JOIN tbl_empleados E ON S.PK_IdSucursal = E.FK_IdSucursal INNER JOIN tbl_usuario U ON E.PK_IdEmpleado = U.FK_IdEmpleado WHERE U.PK_Usu_Codigo = " + codUsuario + " AND C.Tracking_compra = 'orden entregada'";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, conexion.conectar());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Dgv_consultaCompra.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2),
                        mostrarDatos.GetString(3), mostrarDatos.GetString(4));
                }
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            codUsuario = Convert.ToString(user.obtenerCodigoUsuario());

            if(string.IsNullOrEmpty(Txt_buscarCompra.Text.Trim()) == false)
            {
                Dgv_consultaCompra.Rows.Clear();

                try
                {
                    consultaMostrar = "SELECT OC.PK_IdComprasEncabezado, OC.FK_IdProveedores, OC.FK_IdSucursal, OC.fecha_pedido, OC.total FROM tbL_orden_compra_encabezado OC INNER JOIN tbl_compras C ON OC.PK_IdComprasEncabezado = C.PK_IdComprasEncabezado INNER JOIN tbl_surcursal S ON OC.FK_IdSucursal = S.PK_IdSucursal INNER JOIN tbl_empleados E ON S.PK_IdSucursal = E.FK_IdSucursal INNER JOIN tbl_usuario U ON E.PK_IdEmpleado = U.FK_IdEmpleado WHERE U.PK_Usu_Codigo = " + codUsuario + " AND C.Tracking_compra = 'orden entregada' AND fecha_pedido LIKE ('%" + Txt_buscarCompra.Text.Trim() + "%');";
                    OdbcCommand comm = new OdbcCommand(consultaMostrar, conexion.conectar());
                    OdbcDataReader mostrarDatos = comm.ExecuteReader();

                    while(mostrarDatos.Read())
                    {
                        Dgv_consultaCompra.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2),
                            mostrarDatos.GetString(3), mostrarDatos.GetString(4));
                    }
                }
                catch(Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaCompra.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}
