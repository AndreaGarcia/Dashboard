using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Reportes;
using System.Threading.Tasks;
public partial class Reportes_Index : System.Web.UI.Page
{
    private RepositorioReportes repositorioReportes;
    private readonly ServicioEstadoCuenta servicio;
    public Reportes_Index()
    {
        repositorioReportes = new RepositorioReportes();
        servicio = new ServicioEstadoCuenta();
    }

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
        } else if (tipoReporte == "2")
        {
            for (int i = 0; i < reportes.Count; i++)
            {
                reportes[i] = string.Format(reportes[i], "entrada");
            }
        }else if(tipoReporte == "3")
            {
                GenerarReporte.Visible = true;
                TipoOrden.Visible = false;

                RadDropDownFideicomisos.DataTextField = "Fideicomiso";
                RadDropDownFideicomisos.DataValueField = "IdFideicomiso";
                RadDropDownFideicomisos.DataSource = repositorioReportes.ObtenerFideicomisos().ToList();
                RadDropDownFideicomisos.DataBind();
                RadDropDownFideicomisos.Visible = true;

                lblInicio.Visible = true;
                lblFin.Visible = true;
                fechaInicial.Visible = true;
                fechaFinal.Visible = true;

                ReportViewer1.Visible = false;
            }

        TipoOrden.DataSource = reportes;
        TipoOrden.DataBind();
    }   
    protected void GenerarReporte_Click(object sender, EventArgs e)
    {
        var tipoOrden = TipoOrden.SelectedText;
        //switch (tipoOrden)
        //{
        //    case "Reporte orden pago por tipo": ReportViewer1.ReportSource = new Reportes.ReporteOrdenTipo();
        //        break;
        //    case "Reporte orden pago por Fideicomiso": ReportViewer1.ReportSource = new Reportes.ReporteOrdenPagoFideicomiso();
        //        break;
        //    case "Reporte orden pago por Empresa": ReportViewer1.ReportSource = new Reportes.ReporteOrdenPagoEmpresa();
        //        break;
        //    case "Reporte orden entrada por tipo": ReportViewer1.ReportSource = new Reportes.ReportesOrdenesEntrada.ReporteEntradaTipo();
        //        break;
        //    case "Reporte orden entrada por Fideicomiso": ReportViewer1.ReportSource = new Reportes.ReportesOrdenesEntrada.ReporteOrdenEntradaFideicomiso();
        //        break;
        //    case "Reporte orden entrada por Empresa": ReportViewer1.ReportSource = new Reportes.ReportesOrdenesEntrada.ReporteEmpresas();
        //        break;

        //}

        PonerEstadoCuenta();
        
    }
    protected void TipoOrden_SelectedIndexChanged(object sender, Telerik.Web.UI.DropDownListEventArgs e)
    {
        GenerarReporte.Visible = true;
    }
    private void PonerEstadoCuenta()
    {
        DateTime fechaIni = fechaInicial.SelectedDate.Value,
                fechaFin = fechaFinal.SelectedDate.Value;
        var idFideicomiso = int.Parse(RadDropDownFideicomisos.SelectedValue);
        var dsEstadoCuenta = servicio.ObtenerEstadoCuenta(fechaIni, fechaFin, idFideicomiso);
        decimal totalEntrada = 0.0m, totalSalida = 0.0m, totalResiduo = 0.0m;

        foreach(var estadoCuenta in dsEstadoCuenta){
            totalEntrada += estadoCuenta.ImporteEntrada.HasValue ? estadoCuenta.ImporteEntrada.Value : 0.0m;
            totalSalida += estadoCuenta.ImporteSalida.HasValue ? estadoCuenta.ImporteSalida.Value : 0.0m;
        }

        totalResiduo = totalEntrada - totalSalida;
        lblTotalEntrada.Text = totalEntrada.ToString("C2");
        lblTotalSalida.Text = totalSalida.ToString("C2");
        lblResiduo.Text = totalResiduo.ToString("C2");


        rgEstadoCuenta.DataSource = dsEstadoCuenta;
        rgEstadoCuenta.DataBind();
        rgEstadoCuenta.Visible = true;
        lblFooter.Visible = true;

        
    }


} 

