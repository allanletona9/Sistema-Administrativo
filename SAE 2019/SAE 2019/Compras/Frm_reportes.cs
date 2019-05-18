using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CapaDiseno;
using SAE_2019.Inventario;
using SAE_2019.Ventas;

namespace SAE_2019.Compras
{ 
    public partial class Frm_reportes : Form
    {
        public static String codigo, codigo2;
        string codFactura = "";
        Navegador nv = new Navegador();
        public Frm_reportes(string codFactura)
        {
            InitializeComponent();
            this.codFactura = codFactura;
        }

       
        private void Frm_reportes_Load(object sender, EventArgs e)
        {

           RFacturacion reporte = new RFacturacion();
            reporte.SetParameterValue("codigo",codFactura);
            crystalReportViewer1.ReportSource = reporte;
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
