using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Reportes;
public partial class Reportes_Index : System.Web.UI.Page
{
    private List<string> reportes = new List<string>
    {
        "Reporte orden {0} por tipo",
        "Reporte orden {0} por Fideicomiso",
        "Reporte orden {0} por Empresa"
    };
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void TipoReporte_SelectedIndexChanged(object sender, Telerik.Web.UI.DropDownListEventArgs e)
    {
        TipoOrden.Visible=true;
        var tipoReporte= TipoReporte.SelectedValue;
        
        if(tipoReporte=="1"){
            for(int i = 0; i < reportes.Count ; i++)
            {
                reportes[i] = string.Format(reportes[i], "pago");
            }
        }
        else
        {
            for (int i = 0; i < reportes.Count; i++)
            {
                reportes[i] = string.Format(reportes[i], "entrada");
            }
        }

        TipoOrden.DataSource = reportes;
        TipoOrden.DataBind();
    }   
    protected void GenerarReporte_Click(object sender, EventArgs e)
    {
        var tipoOrden = TipoOrden.SelectedText;
        switch (tipoOrden)
        {
            case "Reporte orden pago por tipo": ReportViewer1.ReportSource = new Reportes.ReporteOrdenTipo();
                break;
            case "Reporte orden pago por Fideicomiso": ReportViewer1.ReportSource = new Reportes.ReporteOrdenPagoFideicomiso();
                break;
            case "Reporte orden pago por Empresa": ReportViewer1.ReportSource = new Reportes.ReporteOrdenPagoEmpresa();
                break;
            case "Reporte orden entrada por tipo": ReportViewer1.ReportSource = new Reportes.ReportesOrdenesEntrada.ReporteEntradaTipo();
                break;
            case "Reporte orden entrada por Fideicomiso": ReportViewer1.ReportSource = new Reportes.ReportesOrdenesEntrada.ReporteOrdenEntradaFideicomiso();
                break;
            case "Reporte orden entrada por Empresa": ReportViewer1.ReportSource = new Reportes.ReportesOrdenesEntrada.ReporteEmpresas();
                break;

        }
        
    }
    protected void TipoOrden_SelectedIndexChanged(object sender, Telerik.Web.UI.DropDownListEventArgs e)
    {
        GenerarReporte.Visible = true;
    }
} 

