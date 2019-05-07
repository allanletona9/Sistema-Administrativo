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

namespace SAE_2019.Compras
{
    public partial class Frm_pagosCompras : Form
    {
        string scodigoOrdenCompra;
        OdbcCommand cmd;
        public Frm_pagosCompras()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_pagosCompras_Load(object sender, EventArgs e)
        {
            llenarTabla();
            llenarComboBox();

            if (cbo_tipo_pago.SelectedItem == null)
            {
                Txt_NoTarjetaCheque.Enabled = false;
                Txt_NombreTarjetaCheque.Enabled = false;
            }



        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        void llenarTabla()
        {
            OdbcDataAdapter dat;
            DataSet ds;

            try
            {
                ds = new DataSet();
              
                dat = new OdbcDataAdapter("SELECT PK_IdComprasEncabezado AS CodigoOrdenCompra, fecha_compra AS FechaCompra, fecha_modificacion AS FechaModificacion, Tracking_compra AS Tracking, " +
                    "(SELECT total FROM TBL_Orden_Compra_Encabezado WHERE  PK_IdComprasEncabezado = tbl_compras.PK_IdComprasEncabezado) AS Total FROM tbl_compras " +
                    "WHERE estado_compra = 1 AND Tracking_compra = 'orden entregada' AND((SELECT total FROM TBL_Orden_Compra_Encabezado WHERE  PK_IdComprasEncabezado = tbl_compras.PK_IdComprasEncabezado) > (SELECT SUM(abono) FROM TBL_Cuentas_Pagar WHERE  PK_IdComprasEncabezado = tbl_compras.PK_IdComprasEncabezado))", conexion.conectar());

                dat.Fill(ds);
                Dvg_compras.DataSource = ds.Tables[0];
            }
            catch (OdbcException er)
            {
                MessageBox.Show(er.Message);
            }
        }

        void llenarComboBox()
        {
            try
            {
                OdbcCommand sql = new OdbcCommand("Select descripcion_pago from tbl_tipo_de_pago", conexion.conectar());
                OdbcDataReader almacena = sql.ExecuteReader();
                while (almacena.Read() == true)
                {
                    cbo_tipo_pago.Items.Add(almacena.GetValue(0));
                }
                almacena.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


        }

        private void Btn_buscarOrdenCompra_Click(object sender, EventArgs e)
        {
            scodigoOrdenCompra = Txt_OrdenCompra.Text;
            string sfecha = DateTime.Now.ToString("yyyy-MM-dd");

            try
            {

                try
                {
                    cmd = new OdbcCommand("INSERT INTO tbl_cuentas_pagar(PK_IdComprasEncabezado,PK_Id_TipoPago,Fecha_pago," +
                        "Abono)" +
                        "VALUES ('" + scodigoOrdenCompra + "','1','"
                        + sfecha + "', '0')", conexion.conectar());

                    cmd.ExecuteNonQuery();

                    OdbcCommand sql = new OdbcCommand("SELECT P.nombre_proveedor, P.nit_proveedor, P.direccion_proveedor," +
                    "P.pais_proveedor FROM tbl_proveedores P " +
                    "INNER JOIN tbl_orden_compra_encabezado OCE ON P.PK_IdProveedores = OCE.PK_IdProveedores " +
                    "where OCE.PK_IdComprasEncabezado = " + scodigoOrdenCompra + "", conexion.conectar());
                    OdbcDataReader almacena = sql.ExecuteReader();

                    while (almacena.Read() == true)
                    {
                        Txt_nombreProveedor.Text = almacena.GetString(0);
                        Txt_nitProveedor.Text = almacena.GetString(1);
                        Txt_direccionProveedor.Text = almacena.GetString(2);
                        Txt_paisProveedor.Text = almacena.GetString(3);

                    }
                    almacena.Close();



                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.ToString());
                    MessageBox.Show("Orden de compra no existente");
                }

                try
                {

                    scodigoOrdenCompra = Txt_OrdenCompra.Text;

                    cmd = new OdbcCommand("SELECT (OCE.total - SUM(CP.abono)) AS Deuda, OCE.total " +
                    "FROM tbl_cuentas_pagar CP INNER JOIN tbl_compras C ON CP.PK_IdComprasEncabezado = C.PK_IdComprasEncabezado " +
                    "INNER JOIN tbl_orden_compra_encabezado OCE ON C.PK_IdComprasEncabezado = OCE.PK_IdComprasEncabezado " +
                    "WHERE  CP.PK_IdComprasEncabezado = " + scodigoOrdenCompra + " ", conexion.conectar());


                    OdbcDataReader almacena = cmd.ExecuteReader();

                    if (almacena.HasRows)
                    {
                        while (almacena.Read() == true)
                        {
                            Lbl_cantidadSaldo.Text = almacena.GetString(0);
                            Lbl_montoTotal.Text = almacena.GetString(1);
                        }

                    }

                    

                    almacena.Close();

                }
                catch (OdbcException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch(Exception ex)
            {

                MessageBox.Show("Orden de compra no existente");
            }
           

        }

        private void Btn_agregarOrden_Click(object sender, EventArgs e)
        {
            string sfecha = DateTime.Now.ToString("yyyy-MM-dd");
            string sfecha_hora = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt");
            string scodigoTipoPago = "";
            string sAbono = Txt_Abono.Text;
            string sNoTarjeta_Cheque = Txt_NoTarjetaCheque.Text;
            string sNombreTarjeta_Cheque = Txt_NombreTarjetaCheque.Text;
            bool validacionTipoPago = false;
            double dAbono;
            double dTotal;

            if (cbo_tipo_pago.SelectedItem != null)
            {
                string snombreTipoPago = cbo_tipo_pago.SelectedItem.ToString();

                //consulta el codigo del tipo de pago obteniendo el texto del combobox con el nombre del tipo de pago
                try
                {

                    OdbcCommand sql = new OdbcCommand("Select PK_Id_TipoPago from tbl_tipo_de_pago where descripcion_pago = '" + snombreTipoPago + "'", conexion.conectar());
                    OdbcDataReader almacena = sql.ExecuteReader();
                    while (almacena.Read() == true)
                    {

                        scodigoTipoPago = almacena.GetString(0);

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
                validacionTipoPago = true;
            }



            if ((Txt_Abono.Text == "" || validacionTipoPago == true))
            {
                MessageBox.Show("Hacen Falta Campos Por Llenar", "INFORMACION", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                
                Boolean ingresoCorrecto = true;
                dAbono = Convert.ToDouble(this.Txt_Abono.Text);
                dTotal = Convert.ToDouble(this.Lbl_cantidadSaldo.Text);
                try
                {
                    if(dAbono > dTotal)
                    {
                        MessageBox.Show("El abono es mayor a la deuda","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cmd = new OdbcCommand("INSERT INTO tbl_cuentas_pagar(PK_IdComprasEncabezado,PK_Id_TipoPago,Fecha_pago," +
                        "Abono)" +
                        "VALUES ('" + scodigoOrdenCompra + "','" + scodigoTipoPago + "','"
                        + sfecha + "', '" + sAbono + "')", conexion.conectar());
     
                        cmd.ExecuteNonQuery();
                        
                        if( scodigoTipoPago == "2" || scodigoTipoPago == "3")
                        {
                            cmd = new OdbcCommand("INSERT INTO tbl_documentacion_pagos(FK_Id_TipoPago,nombre,numero,fecha_hora)" +
                        "VALUES (" + scodigoTipoPago + ",'" + sNombreTarjeta_Cheque + "','"
                         + sNoTarjeta_Cheque + "', '"+sfecha_hora+"')", conexion.conectar());

                            cmd.ExecuteNonQuery();
                        }

                        ingresoCorrecto = true;

                        if (ingresoCorrecto)
                        {
                            MessageBox.Show("Pago realizado exitosamente");
                            Txt_Abono.Text = "";
                            Txt_OrdenCompra.Text = "";
                            Txt_nombreProveedor.Text = "";
                            Txt_nitProveedor.Text = "";
                            Txt_direccionProveedor.Text = "";
                            Txt_paisProveedor.Text = "";
                            cbo_tipo_pago.Text = "";
                            Lbl_cantidadSaldo.Text = "0.0";
                            Lbl_montoTotal.Text = "0.0";
                            Txt_NombreTarjetaCheque.Text= "";
                            Txt_NombreTarjetaCheque.Enabled = false;
                            Txt_NoTarjetaCheque.Text = "";
                            Txt_NoTarjetaCheque.Enabled = false;
                            cmd = new OdbcCommand("DELETE FROM tbl_cuentas_pagar WHERE Abono = '0'", conexion.conectar());

                            cmd.ExecuteNonQuery();

                            llenarTabla();
                        }
                    }
                    
                }
                catch (OdbcException ex)
                {
                    MessageBox.Show(ex.Message);
                    ingresoCorrecto = false;
                }



            }
        }

        private void cbo_tipo_pago_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cbo_tipo_pago.SelectedItem != null)
            {
                string snombreTipoPago = cbo_tipo_pago.SelectedItem.ToString();

                if(snombreTipoPago != "Efectivo")
                {
                    Txt_NombreTarjetaCheque.Enabled = true;
                    Txt_NoTarjetaCheque.Enabled = true;
                }
                else
                {
                    Txt_NombreTarjetaCheque.Enabled = false;
                    Txt_NoTarjetaCheque.Enabled = false;
                }
                
            }
            else
            {
                Txt_NombreTarjetaCheque.Enabled = false;
                Txt_NoTarjetaCheque.Enabled = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayuda\\" + "PAGAR.chm", "CUENTAS.html");
        }

        private void Dvg_compras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
