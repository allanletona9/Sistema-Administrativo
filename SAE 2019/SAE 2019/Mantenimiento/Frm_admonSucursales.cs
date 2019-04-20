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

namespace SAE_2019.Mantenimiento
{
    public partial class Frm_admonSucursales : Form
    {
        Navegador nv = new Navegador();
        public Frm_admonSucursales()
        {
            InitializeComponent();
        }

        private void Frm_admonSucursales_Load(object sender, EventArgs e)
        {
            DataTable table2 = nv.cargarDatos("tbl_surcursal");
            dataGridView1.DataSource = table2;
        }

        private void Btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            new Frm_sucursales(dataGridView1).Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
