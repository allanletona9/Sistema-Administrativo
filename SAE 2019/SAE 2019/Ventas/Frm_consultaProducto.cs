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

namespace SAE_2019.Facturacion
{
    public partial class Frm_consultaProducto : Form
    {
        public Frm_consultaProducto()
        {
            InitializeComponent();
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_consultaProducto_Load(object sender, EventArgs e)
        {
            try
            {
                string consultaMostrar = "SELECT * FROM tbl_productos;";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, conexion.conectar());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Dgv_consultaProducto.Refresh();
                    Dgv_consultaProducto.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2),
                        mostrarDatos.GetString(3), mostrarDatos.GetString(4), mostrarDatos.GetString(5), mostrarDatos.GetString(6));
                }

            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_buscarProducto.Text.Trim()) == false)
            {
                Dgv_consultaProducto.Rows.Clear();
                try
                {
                    string consultaMostrar = "SELECT * FROM tbl_productos WHERE nombre_producto LIKE ('%" + Txt_buscarProducto.Text.Trim() + "%');";
                    OdbcCommand comm = new OdbcCommand(consultaMostrar, conexion.conectar());
                    OdbcDataReader mostrarDatos = comm.ExecuteReader();

                    while (mostrarDatos.Read())
                    {
                        Dgv_consultaProducto.Refresh();
                        Dgv_consultaProducto.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2),
                            mostrarDatos.GetString(3), mostrarDatos.GetString(4), mostrarDatos.GetString(5), mostrarDatos.GetString(6));
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine("ERROR:" + err.Message);
                }
            }
        }

        private void Btn_actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Dgv_consultaProducto.Rows.Clear();

                string consultaMostrar = "SELECT * FROM tbl_productos;";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, conexion.conectar());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Dgv_consultaProducto.Refresh();
                    Dgv_consultaProducto.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2),
                        mostrarDatos.GetString(3), mostrarDatos.GetString(4), mostrarDatos.GetString(5), mostrarDatos.GetString(6));
                }

            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {
            if (Dgv_consultaProducto.Rows.Count == 0)
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
