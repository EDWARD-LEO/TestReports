using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Agregar...
using DESIGNER.Reports;
using CrystalDecisions.CrystalReports.Engine;
using BOL;

namespace DESIGNER
{
    public partial class DashboardReport : Form
    {
        Pedido pedido = new Pedido();
        VisorReporte formulario;
        SaveFileDialog saveFileDialog;

        public DashboardReport()
        {
            InitializeComponent();
        }

        private void btnReporte1_Click(object sender, EventArgs e)
        {
            lanzarReporte(new reporteEmpleados());
        }

        private void btnReporte2_Click(object sender, EventArgs e)
        {
            exportarPDF(new reporteEmpleados(), "Empleados");
        }

        private void btnReporte3_Click(object sender, EventArgs e)
        {
            lanzarReporte(new reporteProductos());
        }

        private void btnReporte4_Click(object sender, EventArgs e)
        {
            exportarPDF(new reporteProductos(), "Productos");
        }

        private void lanzarReporte(ReportClass reporteVisualizar)
        {
            formulario = new VisorReporte();
            formulario.visorRpt.ReportSource = reporteVisualizar;
            formulario.visorRpt.Refresh();
            formulario.Show();
        }

        private void exportarPDF(ReportClass reporteVisualizar, string titulo)
        {
            saveFileDialog = new SaveFileDialog();

            saveFileDialog.Title = "Exportando datos como PDF";
            saveFileDialog.Filter = "*.PDF|*.pdf";
            saveFileDialog.FileName = "Reporte de " + titulo;

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {    
                reporteVisualizar.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, saveFileDialog.FileName);
            }
        }

        private void btnReporte5_Click(object sender, EventArgs e)
        {
            //En esta versión se requiere pasar el año
            reportePedidos reporte = new reportePedidos();
            reporte.SetDataSource(pedido.listarAnio(txtAnio.Text));

            lanzarReporte(reporte);
        }
    }
}
