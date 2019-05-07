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

namespace SAE_2019.Facturacion
{
    public partial class Frm_facturacion : Form
    {
        DateTime fecha = DateTime.Now;
        string identificador = "";

        public Frm_facturacion()
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

        private void Deshabilitar()
        {
            Txt_codCliente.Enabled = false;
            Txt_cliente.Enabled = false;
            Txt_codProd.Enabled = false;
            Txt_descProd.Enabled = false;
            Txt_precioProducto.Enabled = false;
            Txt_costoProducto.Enabled = false;
            Txt_cantidadProducto.Enabled = false;

            Btn_colocar.Enabled = false;
            Btn_eliminar.Enabled = false;
            Btn_consultaCliente.Enabled = false;
            Btn_consultaProducto.Enabled = false;
            Btn_nuevaFactura.Enabled = false;
            Btn_facturacion.Enabled = false;
        }

        private void Frm_facturacion_Load(object sender, EventArgs e)
        {
            Deshabilitar();
            Rbtn_cotizacion.Focus();
            Usuario usuario = new Usuario();
            string nombreUsuario = Convert.ToString(usuario.obtenerUsuario());
            Lbl_usuario.Text = nombreUsuario;

            Random obj = new Random();
            string posiblesCaracteres = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789";
            int longitud = posiblesCaracteres.Length;
            char letra;
            int longitudNuevaCadena = 10;
            string nuevaCadena = "";
            for(int i = 0; i < longitudNuevaCadena; i++)
            {
                letra = posiblesCaracteres[obj.Next(longitud)];
                nuevaCadena += letra.ToString();
            }

            Txt_noSerie.Text = nuevaCadena;
            Txt_fecha.Text = fecha.ToString("yyyy/MM/dd");
        }

        private void Btn_buscarUsuario_Click(object sender, EventArgs e)
        {

        }

        public static int contadorFila = 0;
        public static double total = 0;

        private void Btn_colocar_Click(object sender, EventArgs e)
        {
            if(Txt_codProd.Text != " " && Txt_descProd.Text != " " && Txt_precioProducto.Text != " " 
                && Txt_costoProducto.Text != " " && Txt_cantidadProducto.Text != " ")
            {



                bool productoExistente = false;
                int posicionFila = 0;

                //si no existe nada en el DGV
                if (contadorFila == 0)
                {
                    Dgv_factura.Rows.Add(Txt_codProd.Text, Txt_descProd.Text, Txt_precioProducto.Text, Txt_costoProducto.Text,
                        Txt_cantidadProducto.Text);

                    double importe = Convert.ToDouble(Dgv_factura.Rows[contadorFila].Cells[2].Value)
                        * Convert.ToDouble(Dgv_factura.Rows[contadorFila].Cells[4].Value);

                    Dgv_factura.Rows[contadorFila].Cells[5].Value = importe;

                    contadorFila++;

                
                }
                else
                {

                    //recorrera todas las filas del Dgv
                    foreach (DataGridViewRow Fila in Dgv_factura.Rows)
                    {
                        //si existe un código idéntico a cualquier del DGV
                        if(Fila.Cells[0].Value.ToString() == Txt_codProd.Text)
                        {
                            productoExistente = true;
                            //posición del IdProducto identico
                            posicionFila = Fila.Index;
                        }
                    }

                    if(productoExistente == true)
                    {
                        Dgv_factura.Rows[posicionFila].Cells[4].Value = (Convert.ToDouble(Txt_cantidadProducto.Text) +
                            Convert.ToDouble(Dgv_factura.Rows[posicionFila].Cells[4].Value)).ToString();
                        
                        double importe = (Convert.ToDouble(Dgv_factura.Rows[posicionFila].Cells[2].Value) -
                        Convert.ToDouble(Dgv_factura.Rows[posicionFila].Cells[3].Value)) * Convert.ToDouble(Dgv_factura.Rows[posicionFila].Cells[4].Value);

                        Dgv_factura.Rows[posicionFila].Cells[5].Value = importe;
                    } 
                    else
                    {
                        Dgv_factura.Rows.Add(Txt_codProd.Text, Txt_descProd.Text, Txt_precioProducto.Text, Txt_costoProducto.Text,
                         Txt_cantidadProducto.Text);

                        double importe = (Convert.ToDouble(Dgv_factura.Rows[contadorFila].Cells[2].Value) -
                            Convert.ToDouble(Dgv_factura.Rows[contadorFila].Cells[3].Value)) * Convert.ToDouble(Dgv_factura.Rows[contadorFila].Cells[4].Value);

                        Dgv_factura.Rows[contadorFila].Cells[5].Value = importe;

                        contadorFila++;

                    }

                }

                total = 0;

                //recorrera todas las filas del Dgv
                foreach (DataGridViewRow Fila in Dgv_factura.Rows)
                {
                    total += Convert.ToDouble(Fila.Cells[5].Value);
                }
                Lbl_total.Text = " " + total.ToString();
            }
        }

        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if(contadorFila > 0)
            {
                //eliminará el valor que tenía la fila seleccionada que se eliminará
                total = total - Convert.ToDouble(Dgv_factura.Rows[Dgv_factura.CurrentRow.Index].Cells[5].Value);
                Lbl_total.Text = " " + total.ToString();

                Dgv_factura.Rows.RemoveAt(Dgv_factura.CurrentRow.Index);
                contadorFila--;
            }
        }

        private void Btn_consultaCliente_Click(object sender, EventArgs e)
        {
            Frm_consultaCliente consultaCliente = new Frm_consultaCliente();
            consultaCliente.ShowDialog();

            if(consultaCliente.DialogResult == DialogResult.OK)
            {
                //guarda el IdCliente seleccionado
                Txt_codCliente.Text = consultaCliente.Dgv_consultaCliente.Rows[consultaCliente.Dgv_consultaCliente.CurrentRow.Index].Cells[0].Value.ToString();
                Txt_cliente.Text = consultaCliente.Dgv_consultaCliente.Rows[consultaCliente.Dgv_consultaCliente.CurrentRow.Index].Cells[1].Value.ToString();

                Txt_codProd.Focus();
            }
        }

        private void Btn_consultaProducto_Click(object sender, EventArgs e)
        {
            Frm_consultaProducto consultaProducto = new Frm_consultaProducto();
            consultaProducto.ShowDialog();

            if(consultaProducto.DialogResult == DialogResult.OK)
            {
                Txt_codProd.Text = consultaProducto.Dgv_consultaProducto.Rows[consultaProducto.Dgv_consultaProducto.CurrentRow.Index].Cells[0].Value.ToString();
                Txt_descProd.Text = consultaProducto.Dgv_consultaProducto.Rows[consultaProducto.Dgv_consultaProducto.CurrentRow.Index].Cells[2].Value.ToString();

                Txt_precioProducto.Focus();
            }
        }

        private void Nuevo()
        {
            Txt_codCliente.Text = "";
            Txt_cliente.Text = "";
            Txt_codProd.Text = "";
            Txt_descProd.Text = "";
            Txt_precioProducto.Text = "";
            Txt_costoProducto.Text = "";
            Txt_cantidadProducto.Text = "";
            Txt_cantidadProducto.Text = "";
            Lbl_total.Text = "0";
            Dgv_factura.Rows.Clear();
            contadorFila = 0;
            total = 0;
        }

        private void Btn_nuevaFactura_Click(object sender, EventArgs e)
        {
            Nuevo();
            Txt_codCliente.Focus(); 
        }

        private void Txt_codCliente_TextChanged(object sender, EventArgs e)
        {

        }

        private void Habilitar() { 
            Txt_precioProducto.Enabled = true;
            Txt_costoProducto.Enabled = true;
            Txt_cantidadProducto.Enabled = true;

            Btn_colocar.Enabled = true;
            Btn_eliminar.Enabled = true;
            Btn_consultaCliente.Enabled = true;
            Btn_consultaProducto.Enabled = true;
            Btn_nuevaFactura.Enabled = true;
            Btn_facturacion.Enabled = true;
        }

        private void Rbtn_cotizacion_CheckedChanged(object sender, EventArgs e)
        {
            Habilitar();
            Btn_nuevaFactura.Text = "Nueva_Cotización";
            Lbl_titulo.Text = "COTIZACIÓN";
            identificador = "Cotizacion";
        }

        private void Rbtn_facturacion_CheckedChanged(object sender, EventArgs e)
        {
            Habilitar();
            Btn_nuevaFactura.Text = "Nueva_Factura";
            Lbl_titulo.Text = "FACTURACIÓN";
            identificador = "Facturacion";
        }

        private void Btn_facturacion_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            string codigoUsuario = Convert.ToString(usuario.obtenerCodigoUsuario());
            string estado = "1";
            string numeroFac = "";

            if (contadorFila != 0)
            {
                try
                {
                    string consulta = "INSERT INTO tbl_factura_encabezado(`PK_serie`,`FK_Usu_Codigo`,`FK_IdCliente`,`fecha_venta`,`total`,`estado`,`Identificador`) VALUES ('" + Txt_noSerie.Text + "' , '" + codigoUsuario + "' , '" + Txt_codCliente.Text + "' , '"+fecha.ToString("yyyy/MM/dd")+"' , "+Lbl_total.Text+" , "+estado+" , '"+identificador+"');";
                    OdbcCommand comm = new OdbcCommand(consulta, conexion.conectar());
                    comm.ExecuteNonQuery();

                    comm = new OdbcCommand("SELECT MAX(PK_IdFacturaEncabezado) FROM tbl_factura_encabezado;", conexion.conectar());
                    OdbcDataReader mostrar = comm.ExecuteReader();

                    while(mostrar.Read())
                    {
                        numeroFac = mostrar.GetString(0);
                    }

                    foreach(DataGridViewRow Fila in Dgv_factura.Rows)
                    {
                        consulta = "INSERT INTO tbl_factura_detalle(`PK_IdFacturaEncabezado`,`PK_IdProducto`,`precio`,`costo`,`cantidad`) VALUES('"+numeroFac+"' , '"+Fila.Cells[0].Value.ToString()+"' , '"+Fila.Cells[2].Value.ToString()+"' , '"+Fila.Cells[3].Value.ToString()+"' , '"+Fila.Cells[4].Value.ToString()+"')";
                        comm = new OdbcCommand(consulta, conexion.conectar());
                        comm.ExecuteNonQuery();
                    }
                }
                catch(Exception err)
                {
                    Console.WriteLine(err.Message);
                }

                Nuevo();
            }
        }

        private void Btn_ayuda_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "C:\\Ayuda\\" + "facturacion1.chm", "facturacion.html");
        }
    }
}
