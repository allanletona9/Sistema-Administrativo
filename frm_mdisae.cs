using SAE_2019.Clientes;
using SAE_2019.Inventario;
using SAE_2019.Proveedores;
using SAE_2019.Compras;
using SAE_2019.Mantenimiento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ConsultasInteligentes;
using security;
using InicioSesion;

namespace SAE_2019
{
    public partial class frm_mdisae : Form
    {
        String[] tablas = { "tbl_usuario", "tbl_query", "tbl_modulo", "tbl_productos" };

        public frm_mdisae()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //this.panel1.Size = this.Size;
            InicioSesionForm inicioSes = new InicioSesionForm();
            inicioSes.FormClosed += new FormClosedEventHandler(form2_FormClosed);
            inicioSes.ShowDialog();
            inicioSes.TopMost = true;
            inicioSes.Activate();
        }

        void form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Do whatever you want here
            Usuario u = new Usuario();
            //label9.Text = u.obtenerUsuario();

        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {



        }

        private void administracionDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_mostrarclientes);
            if (ventanaRegistroClientes == false || frmC == null)
            {
                if (frmC == null)
                {
                    frmRegistroDeClientes = new frm_mostrarclientes();
                }
                frmRegistroDeClientes.Location = new Point(500, 600);

                frmRegistroDeClientes.MdiParent = this;
                frmRegistroDeClientes.Show();
                Application.DoEvents();
                ventanaRegistroClientes = true;
            }
            else
            {
                frmRegistroDeClientes.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }



        private void administracionDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_mostrarProveedores);
            if (ventanaRegistroMostrarProveedores == false || frmC == null)
            {
                if (frmC == null)
                {
                    mostrarProveedores = new Frm_mostrarProveedores();
                }

                mostrarProveedores.MdiParent = this;
                mostrarProveedores.Show();
                Application.DoEvents();
                ventanaRegistroMostrarProveedores = true;
            }
            else
            {
                mostrarProveedores.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_menu consulta = new frm_menu("20", tablas);
            consulta.Show();
        }

        private void soporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_security seguridad = new Frm_security();
            seguridad.Show();

        }

        bool ventanaRegistroKardex = false;
        Frm_kardex frmRegistroDeKardex = new Frm_kardex();

        private void kardexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_kardex);
            if (ventanaRegistroKardex == false || frmC == null)
            {
                if (frmC == null)
                {
                    frmRegistroDeKardex = new Frm_kardex();
                }
                frmRegistroDeKardex.Location = new Point(500, 600);

                frmRegistroDeKardex.MdiParent = this;
                frmRegistroDeKardex.Show();
                Application.DoEvents();
                ventanaRegistroKardex = true;
            }
            else
            {
                frmRegistroDeKardex.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaRegistroAlmacenes = false;
        Frm_almacenes frmRegistroDeAlmacenes = new Frm_almacenes();

        private void almacenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_almacenes);
            if (ventanaRegistroAlmacenes == false || frmC == null)
            {
                if (frmC == null)
                {
                    frmRegistroDeAlmacenes = new Frm_almacenes();
                }
                frmRegistroDeAlmacenes.Location = new Point(500, 600);

                frmRegistroDeAlmacenes.MdiParent = this;
                frmRegistroDeAlmacenes.Show();
                Application.DoEvents();
                ventanaRegistroAlmacenes = true;
            }
            else
            {
                frmRegistroDeAlmacenes.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaRegistroMostrarFacturas = false;
        Frm_GestionOrdenCompra mostrarFacturas = new Frm_GestionOrdenCompra();

        private void recepcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_GestionOrdenCompra);
            if (ventanaRegistroMostrarFacturas == false || frmC == null)
            {
                if (frmC == null)
                {
                    mostrarFacturas = new Frm_GestionOrdenCompra();
                }

                mostrarFacturas.MdiParent = this;
                mostrarFacturas.Show();
                Application.DoEvents();
                ventanaRegistroMostrarFacturas = true;
            }
            else
            {
                mostrarFacturas.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaRegistroPedidoProductos = false;
        Frm_pedidoProductos pedidoProductos = new Frm_pedidoProductos();

        private void ordenesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_pedidoProductos);
            if (ventanaRegistroPedidoProductos == false || frmC == null)
            {
                if (frmC == null)
                {
                    pedidoProductos = new Frm_pedidoProductos();
                }

                pedidoProductos.MdiParent = this;
                pedidoProductos.Show();
                Application.DoEvents();
                ventanaRegistroPedidoProductos = true;
            }
            else
            {
                pedidoProductos.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaRegistroOrdenCompra = false;
        Frm_OrdenCompra ordenCompra = new Frm_OrdenCompra();

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_OrdenCompra);
            if (ventanaRegistroOrdenCompra == false || frmC == null)
            {
                if (frmC == null)
                {
                    ordenCompra = new Frm_OrdenCompra();
                }

                ordenCompra.MdiParent = this;
                ordenCompra.Show();
                Application.DoEvents();
                ventanaRegistroOrdenCompra = true;
            }
            else
            {
                ordenCompra.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaCuentasPagar = false;
        Frm_pagosCompras cuentasPagar = new Frm_pagosCompras();

        private void cuentasPorPagarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_pagosCompras);
            if (ventanaCuentasPagar == false || frmC == null)
            {
                if (frmC == null)
                {
                    cuentasPagar = new Frm_pagosCompras();
                }

                cuentasPagar.MdiParent = this;
                cuentasPagar.Show();
                Application.DoEvents();
                ventanaCuentasPagar = true;
            }
            else
            {
                cuentasPagar.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        bool ventanaRegistroMostrarProveedores = false;
        Frm_mostrarProveedores mostrarProveedores = new Frm_mostrarProveedores();

        private void proveedoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_mostrarProveedores);
            if (ventanaRegistroMostrarProveedores == false || frmC == null)
            {
                if (frmC == null)
                {
                    mostrarProveedores = new Frm_mostrarProveedores();
                }

                mostrarProveedores.MdiParent = this;
                mostrarProveedores.Show();
                Application.DoEvents();
                ventanaRegistroMostrarProveedores = true;
            }
            else
            {
                mostrarProveedores.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaRegistroProductos = false;
        Frm_admonProductos frmRegistroDeProductos = new Frm_admonProductos();

        private void productosToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_productos);
            if (ventanaRegistroProductos == false || frmC == null)
            {
                if (frmC == null)
                {
                    frmRegistroDeProductos = new Frm_admonProductos();
                }
                frmRegistroDeProductos.Location = new Point(500, 600);

                frmRegistroDeProductos.MdiParent = this;
                frmRegistroDeProductos.Show();
                Application.DoEvents();
                ventanaRegistroProductos = true;
            }
            else
            {
                frmRegistroDeProductos.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaRegistroClientes = false;
        frm_mostrarclientes frmRegistroDeClientes = new frm_mostrarclientes();

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is frm_mostrarclientes);
            if (ventanaRegistroClientes == false || frmC == null)
            {
                if (frmC == null)
                {
                    frmRegistroDeClientes = new frm_mostrarclientes();
                }
                frmRegistroDeClientes.Location = new Point(500, 600);

                frmRegistroDeClientes.MdiParent = this;
                frmRegistroDeClientes.Show();
                Application.DoEvents();
                ventanaRegistroClientes = true;
            }
            else
            {
                frmRegistroDeClientes.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaRegistroEmpleados = false;
        Frm_admonEmpleados frmRegistroEmpleados = new Frm_admonEmpleados();

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_admonEmpleados);
            if (ventanaRegistroEmpleados == false || frmC == null)
            {
                if (frmC == null)
                {
                    frmRegistroEmpleados = new Frm_admonEmpleados();
                }

                frmRegistroEmpleados.MdiParent = this;
                frmRegistroEmpleados.Show();
                Application.DoEvents();
                ventanaRegistroEmpleados = true;
            }
            else
            {
                frmRegistroEmpleados.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaRegistroBodegas = false;
        Frm_admonBodega frmRegistroBodegas = new Frm_admonBodega();

        private void bodegaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_admonBodega);
            if (ventanaRegistroBodegas == false || frmC == null)
            {
                if (frmC == null)
                {
                    frmRegistroBodegas = new Frm_admonBodega();
                }

                frmRegistroBodegas.MdiParent = this;
                frmRegistroBodegas.Show();
                Application.DoEvents();
                ventanaRegistroBodegas = true;
            }
            else
            {
                frmRegistroBodegas.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        bool ventanaRegistroSucursales = false;
        Frm_admonSucursales frmRegistroSucursales = new Frm_admonSucursales();

        private void sucursalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_admonSucursales);
            if (ventanaRegistroSucursales == false || frmC == null)
            {
                if (frmC == null)
                {
                    frmRegistroSucursales = new Frm_admonSucursales();
                }

                frmRegistroSucursales.MdiParent = this;
                frmRegistroSucursales.Show();
                Application.DoEvents();
                ventanaRegistroSucursales = true;
            }
            else
            {
                frmRegistroSucursales.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
      
        private void devolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }
      
        private void estadoDevolucionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

        }
        bool Vista_devoluciones = false;
        Frm_vista_devoluciones frmvista_dev = new Frm_vista_devoluciones();
        private void estadoDevolucionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_vista_devoluciones);
            if (Vista_devoluciones == false || frmC == null)
            {
                if (frmC == null)
                {
                    frmvista_dev = new Frm_vista_devoluciones();
                }

                frmvista_dev.MdiParent = this;
                frmvista_dev.Show();
                Application.DoEvents();
                Vista_devoluciones = true;
            }
            else
            {
                frmsolicitudev.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
        bool ventanasolicitud = false;
        Frm_solicitud_devoluciones frmsolicitudev = new Frm_solicitud_devoluciones();
        private void devolucionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_solicitud_devoluciones);
            if (ventanasolicitud == false || frmC == null)
            {
                if (frmC == null)
                {
                    frmsolicitudev = new Frm_solicitud_devoluciones();
                }

                frmsolicitudev.MdiParent = this;
                frmsolicitudev.Show();
                Application.DoEvents();
                ventanasolicitud = true;
            }
            else
            {
                frmsolicitudev.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cambioDePreciosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pagoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
