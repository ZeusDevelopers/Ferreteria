using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PVFP;
using System.Globalization;

namespace Ferreteria
{
    public partial class Frm_cotizacion : Form
    {
        DataTable este;
        NumberFormatInfo nfi = new CultureInfo("Es-MX", false).NumberFormat;
        double iva=0, sub=0, tot=0;
        public Frm_cotizacion(DataTable dt,double iva,double sub,double tot)
        {
            este = dt;
            InitializeComponent();
            this.iva = iva;
            this.sub = sub;
            this.tot = tot;
        }

        private void Frm_cotizacion_Load(object sender, EventArgs e)
        {
            
            DataTable tb = new DataTable();
            tb.Columns.Add("Articulo");
            tb.Columns.Add("Cantidad");
            tb.Columns.Add("Precio");
            tb.Columns.Add("Importe");
            foreach (DataRow item in este.Rows)
            {
                tb.Rows.Add(item[2],item[0], item[4], item[5]);
            }
           // tb.Rows.Add("Aceite", "2","$23.00","$45.00");
            ReportDataSource reportDataSource = new ReportDataSource();
            // Must match the DataSource in the RDLC
            reportDataSource.Name = "datasource";
            reportDataSource.Value = tb;

            
            ReportParameterCollection reportParameters = new ReportParameterCollection();
            reportParameters.Add(new ReportParameter("Fecha", DateTime.Now.ToShortDateString()));
            reportParameters.Add(new ReportParameter("Emp", ClsInicioSesion.empleados_id.ToString()));
            reportParameters.Add(new ReportParameter("sub", sub.ToString("C", nfi)));
            reportParameters.Add(new ReportParameter("iva", iva.ToString("C", nfi)));
            reportParameters.Add(new ReportParameter("tot", tot.ToString("C", nfi)));
            reportViewer1.LocalReport.DataSources.Add(reportDataSource);
            ReportDataSource rds = new ReportDataSource();
            rds.Name = "DataSet1";
            rds.Value = tb;
            this.reportViewer1.LocalReport.SetParameters(reportParameters);
            reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
