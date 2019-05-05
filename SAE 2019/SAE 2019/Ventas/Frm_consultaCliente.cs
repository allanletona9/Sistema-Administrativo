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
    public partial class Frm_consultaCliente : Form
    {
        public Frm_consultaCliente()
        {
            InitializeComponent();
        }

        private void Frm_consultaCliente_Load(object sender, EventArgs e)
        {
            try
            {
                string consultaMostrar = "SELECT * FROM tbl_clientes;";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, conexion.conectar());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Dgv_consultaCliente.Refresh();
                    Dgv_consultaCliente.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2),
                        mostrarDatos.GetString(3), mostrarDatos.GetString(4));
                }

            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_seleccionar_Click(object sender, EventArgs e)
        {

            if (Dgv_consultaCliente.Rows.Count == 0)
            {
                return;
            }
            else
            {
                DialogResult = DialogResult.OK;
                Close();
            }

        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_buscarCliente.Text.Trim()) == false)
            {
                Dgv_consultaCliente.Rows.Clear();
                try
                {
                    string consultaMostrar = "SELECT * FROM tbl_clientes WHERE nombre_cliente LIKE ('%" + Txt_buscarCliente.Text.Trim() + "%');";
                    OdbcCommand comm = new OdbcCommand(consultaMostrar, conexion.conectar());
                    OdbcDataReader mostrarDatos = comm.ExecuteReader();

                    while (mostrarDatos.Read())
                    {
                        Dgv_consultaCliente.Refresh();
                        Dgv_consultaCliente.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2),
                            mostrarDatos.GetString(3), mostrarDatos.GetString(4));
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
                Dgv_consultaCliente.Rows.Clear();

                string consultaMostrar = "SELECT * FROM tbl_clientes;";
                OdbcCommand comm = new OdbcCommand(consultaMostrar, conexion.conectar());
                OdbcDataReader mostrarDatos = comm.ExecuteReader();

                while (mostrarDatos.Read())
                {
                    Dgv_consultaCliente.Refresh();
                    Dgv_consultaCliente.Rows.Add(mostrarDatos.GetString(0), mostrarDatos.GetString(1), mostrarDatos.GetString(2),
                        mostrarDatos.GetString(3), mostrarDatos.GetString(4));
                }

            }
            catch (Exception err)
            {
                Console.Write(err.Message);
            }
        }
    }
}
