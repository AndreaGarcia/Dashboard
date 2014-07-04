using DotNet.Highcharts;
using DotNet.Highcharts.Enums;
using DotNet.Highcharts.Helpers;
using DotNet.Highcharts.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Graficos_GraficasOrdenesPago : System.Web.UI.Page
{
    RepositorioGraficas repositorioGraficas;
    public Graficos_GraficasOrdenesPago()
    {
        repositorioGraficas = new RepositorioGraficas();
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        var analisis = repositorioGraficas.ObtenerAnalisisOrdenPago();
        Highcharts chart = new Highcharts("chart")
              .InitChart(new Chart { DefaultSeriesType = ChartTypes.Column, ZoomType = ZoomTypes.X })
              .SetTitle(new Title { Text = "Gráfica por tipo de Ordenes de pago" })
              .SetXAxis(new XAxis {
                  Type = AxisTypes.Datetime,
                  Min = analisis.Item2.ValorMinimo,
                  Max = analisis.Item2.ValorMaximo,
                  StartOnTick=false,
                  EndOnTick=false
              })
              .SetSeries(analisis.Item1.ToArray())
              ;
        ltrChart.InnerHtml = chart.ToHtmlString();

        var analisisPorFideicomiso = repositorioGraficas.ObtenerAnalisisOrdenPagoFideicomiso();
        Highcharts chartFideicomiso = new Highcharts("chartFideicomiso")
             .InitChart(new Chart { DefaultSeriesType = ChartTypes.Column })
             .SetTitle(new Title { Text = "Gráfica por Fideicomiso" })
             .SetXAxis(new XAxis { Type = AxisTypes.Datetime, Min = analisisPorFideicomiso.Item2.ValorMinimo, Max = analisisPorFideicomiso.Item2.ValorMaximo }) //OBTENER TIPOS DE ORDENES DE PAGO
             .SetSeries(analisisPorFideicomiso.Item1.ToArray());

        ltrChart2.InnerHtml = chartFideicomiso.ToHtmlString();

        var analisisPorEmpresa = repositorioGraficas.ObtenerAnalisisOrdenPagoEmpresa();
        Highcharts chartEmpresa = new Highcharts("chartEmpresa")
             .InitChart(new Chart { DefaultSeriesType = ChartTypes.Column })
             .SetTitle(new Title { Text = "Gráfica por Empresa" })
             .SetXAxis(new XAxis { Type = AxisTypes.Datetime, Min = analisisPorEmpresa.Item2.ValorMinimo, Max = analisisPorEmpresa.Item2.ValorMaximo }) //OBTENER TIPOS DE ORDENES DE PAGO
             .SetSeries(analisisPorEmpresa.Item1.ToArray());

        ltrChart3.InnerHtml = chartEmpresa.ToHtmlString();
    }
}