using SAE_2019.Clientes;
using SAE_2019.Inventario;
using SAE_2019.Proveedores;
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
        String[] tablas = { "tbl_usuario", "tbl_query", "tbl_modulo" };

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

        bool ventanaRegistroProductos = false;
        Frm_productos frmRegistroDeProductos = new Frm_productos();

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           
                Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_productos);
                if (ventanaRegistroProductos == false || frmC == null)
                {
                    if (frmC == null)
                    {
                        frmRegistroDeProductos = new Frm_productos();
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

        bool ventanaRegistroProveedores = false;
        Frm_admonProveedores frmRegistroDeProveedores = new Frm_admonProveedores();

        private void administracionDeProveedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_admonProveedores);
            if (ventanaRegistroProveedores == false || frmC == null)
            {
                if (frmC == null)
                {
                    frmRegistroDeProveedores = new Frm_admonProveedores();
                }
                frmRegistroDeProveedores.Location = new Point(500, 600);

                frmRegistroDeProveedores.MdiParent = this;
                frmRegistroDeProveedores.Show();
                Application.DoEvents();
                ventanaRegistroProveedores = true;
            }
            else
            {
                frmRegistroDeProveedores.WindowState = System.Windows.Forms.FormWindowState.Normal;
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
    }
}
