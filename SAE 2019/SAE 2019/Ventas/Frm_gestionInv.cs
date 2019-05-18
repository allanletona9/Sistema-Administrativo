using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InicioSesion;
using System.Data.Odbc;
using System.Collections;

namespace SAE_2019.Ventas
{
    public partial class Frm_gestionInv : Form
    {
        Usuario user = new Usuario();
        string codUsuario = "";

        public Frm_gestionInv()
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

        private void Btn_consulta_Click(object sender, EventArgs e)
        {
            Frm_consultaCompraE consultaCompra = new Frm_consultaCompraE();
            consultaCompra.ShowDialog();

            if(consultaCompra.DialogResult == DialogResult.OK)
            {
                Txt_idCompra.Text = consultaCompra.Dgv_consultaCompra.Rows[consultaCompra.Dgv_consultaCompra.CurrentRow.Index].Cells[0].Value.ToString();
                Txt_fechaPedido.Text = consultaCompra.Dgv_consultaCompra.Rows[consultaCompra.Dgv_consultaCompra.CurrentRow.Index].Cells[3].Value.ToString();
                Lbl_idSucursal.Text = consultaCompra.Dgv_consultaCompra.Rows[consultaCompra.Dgv_consultaCompra.CurrentRow.Index].Cells[2].Value.ToString();
                Btn_agregarDetalle.Focus();
            }
        }

        private void Btn_agregarDetalle_Click(object sender, EventArgs e)
        {
            string consultaMostrar = "";
            codUsuario = Convert.ToString(user.obtenerCodigoUsuario());
            string idCompra = Txt_idCompra.Text;
            if (string.IsNullOrEmpty(Txt_idCompra.Text) || string.IsNullOrEmpty(Txt_fechaPedido.Text))
            {
                MessageBox.Show("Algunos campos aún no han sido llenados");
            }
            else
            {
               try
                {
                    consultaMostrar = "SELECT ODC.PK_IdComprasEncabezado, ODC.PK_IdProducto, ODC.PK_Linea_detalle, ODC.precio, ODC.cantidad FROM tbl_orden_compra_detalle ODC INNER JOIN tbl_orden_compra_encabezado OC ON ODC.PK_IdComprasEncabezado = OC.PK_IdComprasEncabezado INNER JOIN tbl_compras C ON OC.PK_IdComprasEncabezado = C.PK_IdComprasEncabezado INNER JOIN tbl_surcursal S ON OC.FK_IdSucursal = S.PK_IdSucursal INNER JOIN tbl_empleados E ON S.PK_IdSucursal = E.FK_IdSucursal INNER JOIN tbl_usuario U ON E.PK_IdEmpleado = U.FK_IdEmpleado WHERE U.PK_Usu_Codigo = "+codUsuario+" AND C.Tracking_compra = 'orden entregada' AND OC.PK_IdComprasEncabezado = '"+idCompra+"' ";
                    OdbcCommand comm = new OdbcCommand(consultaMostrar, conexion.conectar());
                    OdbcDataReader mostrarDatos = comm.ExecuteReader();

                    Dgv_compraDetalle.Rows.Clear();

                    while(mostrarDatos.Read())
                    {
                        Dgv_compraDetalle.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2),
                            mostrarDatos.GetString(3), mostrarDatos.GetString(4));
                    }
                } 
                catch(Exception err)
                {
                    Console.WriteLine(err.Message);
                }
            }
        }

        private void Btn_limpiar_Click(object sender, EventArgs e)
        {
            Txt_idCompra.Text = "";
            Txt_fechaPedido.Text = "";
            Lbl_idSucursal.Text = "";
            Dgv_compraDetalle.Rows.Clear();
        }

        private void Frm_gestionInv_Load(object sender, EventArgs e)
        {
            Txt_idCompra.Enabled = false;
            Txt_fechaPedido.Enabled = false;
        }

        private void Btn_agregarInv_Click(object sender, EventArgs e)
        {
            bool codIdentico = false;
            string consultaInv = "";
            ArrayList codProducto = new ArrayList();
            ArrayList codSucursal = new ArrayList();
            string consultaCodSucursal = "";
            string dgvCodProducto = "";
            string idCompra = Txt_idCompra.Text;
            codUsuario = Convert.ToString(user.obtenerCodigoUsuario());
            string consultaCompra = "";
            //SE SACA EL ID DE SUCURSAL POR LA COMPRA ENCABEZADO
            //EL ID DE PRODUCTO SE SACA DE LA COMPRA DETALLE
            //SI ESOS DATOS SON IGUALES A LA CONSULTA QUE MUESTRA LOS DATOS DE LA TABLA INV SE HACE UN UPDATE 
            //SINO SON IGUALES SE HACE UN INSERT

            try
            {
                consultaCodSucursal = Lbl_idSucursal.Text;
                string codigoProducto = "";
                string consultaMostrar = "SELECT PK_IdProducto, PK_IdSucursal FROM tbl_inventario;";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, conexion.conectar());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    codProducto.Add(mostrarDatos.GetString(0));
                    codSucursal.Add(mostrarDatos.GetString(1));
                }



                foreach (DataGridViewRow Fila in Dgv_compraDetalle.Rows)
                {
                    dgvCodProducto = Fila.Cells[1].Value.ToString();

                    for (int contadorConsulta = 0; contadorConsulta < codProducto.Count && contadorConsulta < codSucursal.Count; contadorConsulta++)
                    {
                        
                        if (codProducto[contadorConsulta].ToString() == dgvCodProducto && codSucursal[contadorConsulta].ToString() == consultaCodSucursal)
                        {
                            codIdentico = true;
                            codigoProducto = codProducto[contadorConsulta].ToString();
                        }
                    }

                    if (codIdentico == true)
                    {
                        Console.WriteLine("Relacion encontrada " + "Producto a utilizar: " + codigoProducto);
                        Console.WriteLine("Cod prod: " + dgvCodProducto);
                        consultaInv = "UPDATE tbl_inventario I INNER JOIN tbl_orden_compra_detalle OCD ON I.PK_IdProducto = OCD.PK_IdProducto" +
                            " INNER JOIN tbl_orden_compra_encabezado OC ON OCD.PK_IdComprasEncabezado = OC.PK_IdComprasEncabezado" +
                            " INNER JOIN tbl_compras C ON OC.PK_IdComprasEncabezado = C.PK_IdComprasEncabezado" +
                            " INNER JOIN tbl_surcursal S ON I.PK_IdSucursal = S.PK_IdSucursal" +
                            " INNER JOIN tbl_surcursal ON OC.FK_IdSucursal = S.PK_IdSucursal" +
                            " INNER JOIN tbl_empleados E ON S.PK_IdSucursal = E.FK_IdSucursal" +
                            " INNER JOIN tbl_usuario U ON E.PK_IdEmpleado = U.FK_IdEmpleado" +
                            " SET I.existencia = I.existencia + OCD.cantidad" +
                            " WHERE OCD.PK_IdProducto = " + Fila.Cells[1].Value.ToString() + "" +
                            " AND U.PK_Usu_Codigo = " + codUsuario + "" +
                            " AND OCD.PK_IdComprasEncabezado = " + idCompra;
                        OdbcCommand comm2 = new OdbcCommand(consultaInv, conexion.conectar());
                        comm2.ExecuteNonQuery();
                    }
                    else
                    {
                        Console.WriteLine("Cod prod: " + dgvCodProducto);
                        consultaInv = "INSERT INTO tbl_inventario (PK_IdProducto,PK_IdSucursal,PK_IdBodegas,existencia) VALUES (" + Fila.Cells[1].Value.ToString() + ", " + consultaCodSucursal + ", " + consultaCodSucursal + ", " + Fila.Cells[4].Value.ToString() + ")";
                        OdbcCommand comm3 = new OdbcCommand(consultaInv, conexion.conectar());
                        comm3.ExecuteNonQuery();
                    }

                    codIdentico = false;
                }

                consultaCompra = "UPDATE tbl_compras C " +
                    "INNER JOIN tbl_orden_compra_encabezado OC ON C.PK_IdComprasEncabezado = OC.PK_IdComprasEncabezado " +
                    "SET C.Tracking_compra = 'orden finalizada' " +
                    "WHERE OC.PK_IdComprasEncabezado = "+idCompra+";";
                OdbcCommand comm4 = new OdbcCommand(consultaCompra, conexion.conectar());
                comm4.ExecuteNonQuery();

                MessageBox.Show("Productos ingresados al inventario");
                Txt_idCompra.Text = "";
                Txt_fechaPedido.Text = "";
                Lbl_idSucursal.Text = "";
                Dgv_compraDetalle.Rows.Clear();
            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }

        }
    }
}
