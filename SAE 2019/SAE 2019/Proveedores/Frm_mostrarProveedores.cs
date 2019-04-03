using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAE_2019.Proveedores
{
    public partial class Frm_mostrarProveedores : Form
    {
        public Frm_mostrarProveedores()
        {
            InitializeComponent();
        }

        bool ventanaRegistroProveedores = false;
        Frm_admonProveedores admonProveedores = new Frm_admonProveedores();

        private void Dgv_mostrarProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Form frmC = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is Frm_admonProveedores);
            if (ventanaRegistroProveedores == false || frmC == null)
            {
                if (frmC == null)
                {
                    admonProveedores = new Frm_admonProveedores();
                }

                admonProveedores.Show();
                Application.DoEvents();
                ventanaRegistroProveedores = true;
            }
            else
            {
                admonProveedores.WindowState = System.Windows.Forms.FormWindowState.Normal;
            }
        }
    }
}
