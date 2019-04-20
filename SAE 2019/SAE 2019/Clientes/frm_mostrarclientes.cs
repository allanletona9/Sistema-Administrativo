﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDiseno;

namespace SAE_2019.Clientes
{
    public partial class frm_mostrarclientes : Form
    {
        Navegador nv = new Navegador();
        public frm_mostrarclientes()
        {
            InitializeComponent();
          nv.numeroApp(8);
        }

        private void frm_mostrarclientes_Load(object sender, EventArgs e)
        {
            DataTable table2 = nv.cargarDatos("tbl_clientes");
            dataGridView1.DataSource = table2;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new Frm_admonClientes(dataGridView1).Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
