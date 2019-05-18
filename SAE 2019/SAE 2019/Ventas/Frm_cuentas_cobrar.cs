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

namespace SAE_2019.Ventas
{
    public partial class Frm_cuentas_cobrar : Form
    {
        string scodigoFactura;
        OdbcCommand cmd;
        public Frm_cuentas_cobrar()
        {
           
            InitializeComponent();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void llenarTabla()
        {
            OdbcDataAdapter dat;
            DataSet ds;

            try
            {
                ds = new DataSet();

                dat = new OdbcDataAdapter("SELECT PK_IdFacturaEncabezado AS CodigoFactura, fecha_venta AS FechaVenta,total AS Total FROM tbl_factura_encabezado WHERE estado = 1 AND identificador = 'facturacion' AND (Total > (SELECT SUM(abono) FROM tbl_cuentas_cobrar WHERE tbl_cuentas_cobrar.FK_IdFacturaEncabezado = tbl_factura_encabezado.PK_IdFacturaEncabezado))", conexion.conectar());

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
            scodigoFactura = Txt_NoFactura.Text;
            string sfecha = DateTime.Now.ToString("yyyy-MM-dd");
            try
           {

                try
                {
                    cmd = new OdbcCommand("INSERT INTO tbl_cuentas_cobrar(FK_IdFacturaEncabezado,FK_Id_TipoPago,Fecha_pago," +
                        "Abono)" +
                        "VALUES ('" + scodigoFactura + "','1','"
                        + sfecha + "', '0')", conexion.conectar());

                    cmd.ExecuteNonQuery();

                    OdbcCommand sql = new OdbcCommand("SELECT C.nombre_cliente, C.nit_cliente, C.dpi_cliente FROM tbl_clientes C INNER JOIN tbl_factura_encabezado FE ON C.PK_IdCliente = FE.FK_IdCliente where FE.PK_IdFacturaEncabezado =" + scodigoFactura + "", conexion.conectar());
                    OdbcDataReader almacena = sql.ExecuteReader();

                    while (almacena.Read() == true)
                    {
                        Txt_NombreCliente.Text = almacena.GetString(0);
                        Txt_Nit.Text = almacena.GetString(1);
                        Txt_dpi.Text = almacena.GetString(2);

                    }
                    almacena.Close();

                }
                catch (Exception ex)
                {
                    // MessageBox.Show(ex.ToString());
                    MessageBox.Show("Numero de Factura No Existente");
                }

              try
                {

                    scodigoFactura = Txt_NoFactura.Text;


                    cmd = new OdbcCommand("SELECT (FE.total - SUM(CC.abono)) AS Deuda, FE.total FROM tbl_cuentas_cobrar CC INNER JOIN tbl_factura_encabezado FE ON CC.FK_IdFacturaEncabezado = FE.PK_IdFacturaEncabezado WHERE  CC.FK_IdFacturaEncabezado = "+scodigoFactura+"", conexion.conectar());


                    OdbcDataReader almacena = cmd.ExecuteReader();

                    if (almacena.HasRows)
                    {
                        while (almacena.Read() == true)
                        {
                            txt_saldo.Text = almacena.GetString(0);
                            txt_montototal.Text = almacena.GetString(1);
                        }

                    }
                    almacena.Close();

                }
                catch (OdbcException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception ex)
           {

               MessageBox.Show("Numero de Factura No Existente");
           }

        }

        private void Frm_cuentas_cobrar_Load(object sender, EventArgs e)
        {
            llenarTabla();
            llenarComboBox();
            if (cbo_tipo_pago.SelectedItem == null)
            {
                Txt_NoTarjetaCheque.Enabled = false;
                Txt_NombreTarjetaCheque.Enabled = false;
            }
        }

        private void cbo_tipo_pago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbo_tipo_pago.SelectedItem != null)
            {
                string snombreTipoPago = cbo_tipo_pago.SelectedItem.ToString();

                if (snombreTipoPago != "Efectivo")
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

        private void Dvg_compras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Btn_cobrar_Click(object sender, EventArgs e)
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

                //consulta el codigo del proveedor obteniendo el texto del combobox con el nombre del proveedor
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
                dTotal = Convert.ToDouble(this.txt_montototal.Text);
                try
                {
                    if (dAbono > dTotal)
                    {
                        MessageBox.Show("El abono es mayor a la deuda", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        cmd = new OdbcCommand("INSERT INTO tbl_cuentas_cobrar(FK_IdFacturaEncabezado,FK_Id_TipoPago,Fecha_pago," +
                        "Abono)" +
                        "VALUES ('" + scodigoFactura + "','" + scodigoTipoPago + "','"
                        + sfecha + "', '" + sAbono + "')", conexion.conectar());

                        cmd.ExecuteNonQuery();

                        if (scodigoTipoPago == "2" || scodigoTipoPago == "3")
                        {
                            cmd = new OdbcCommand("INSERT INTO tbl_documentacion_pagos(FK_Id_TipoPago,nombre,numero,fecha_hora)" +
                        "VALUES (" + scodigoTipoPago + ",'" + sNombreTarjeta_Cheque + "','"
                         + sNoTarjeta_Cheque + "', '" + sfecha_hora + "')", conexion.conectar());

                            cmd.ExecuteNonQuery();
                        }

                        ingresoCorrecto = true;

                        if (ingresoCorrecto)
                        {
                            MessageBox.Show("Pago realizado exitosamente");
                            Txt_Abono.Text = "";
                            Txt_NoFactura.Text = "";
                            Txt_NombreCliente.Text = "";
                            Txt_Nit.Text = "";
                            Txt_dpi.Text = "";
                            cbo_tipo_pago.Text = "";
                            txt_saldo.Text = "0.0";
                            txt_montototal.Text = "0.0";
                            Txt_NombreTarjetaCheque.Text = "";
                            Txt_NombreTarjetaCheque.Enabled = false;
                            Txt_NoTarjetaCheque.Text = "";
                            Txt_NoTarjetaCheque.Enabled = false;
                            cmd = new OdbcCommand("DELETE FROM tbl_cuentas_cobrar WHERE Abono = '0'", conexion.conectar());

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
    }
}
