﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE_2019.Compras
{
    public partial class Frm_mostrarFacturasCompras : Form
    {
        public Frm_mostrarFacturasCompras()
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Frm_mostrarFacturasCompras_Load(object sender, EventArgs e)
        {
            Dgv_mostrarFacturas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        private void Dgv_mostrarFacturas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        bool ventanaRegistroFacturasCompras = false;
        Frm_OrdenCompra facturasCompras = new Frm_OrdenCompra();

        private void Dgv_mostrarFacturas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_OrdenCompra);
            if (ventanaRegistroFacturasCompras == false || frmC == null)
            {
                if (frmC == null)
                {
                    facturasCompras = new Frm_OrdenCompra();
                }

                facturasCompras.Show();
                Application.DoEvents();
                ventanaRegistroFacturasCompras = true;
            }
            else
            {
                facturasCompras.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }

        }
    }
}
