using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SAE_2019.Compras;
using CrystalDecisions.CrystalReports.Engine;
using SAE_2019.Inventario;

namespace SAE_2019.Ventas
{
    public partial class consulta_factura : Form
    {
        string codFactura = "";
        public consulta_factura(string codFac)
        {
            InitializeComponent();
            this.codFactura = codFactura;

        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            codFactura = txt_cod_factura.Text;
            Frm_reportes abrir = new Frm_reportes(codFactura);
            abrir.ShowDialog();

        }

        private void consulta_factura_Load(object sender, EventArgs e)
        {
            
        }
    }
}
