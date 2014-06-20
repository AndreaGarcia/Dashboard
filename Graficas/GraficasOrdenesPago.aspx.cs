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
        var analisis = repositorioGraficas.ObtenerAnalisisOrdenPago(DateTime.Now.AddDays(-30), DateTime.Now);
        Highcharts chart = new Highcharts("chart")
              .InitChart(new Chart { DefaultSeriesType = ChartTypes.Column })
              .SetTitle(new Title { Text = "Gráfica por tipo de Ordenes de pago" })
              .SetXAxis(new XAxis { Type = AxisTypes.Category }) //OBTENER TIPOS DE ORDENES DE PAGO
              .SetYAxis(new[]
                      {
                          new YAxis
                          {
                              Title = new YAxisTitle { Text = "Número de ordenes" },
                              GridLineWidth = 1
                          }
                      })
              .SetSeries(analisis.ToArray());

        ltrChart.Text = chart.ToHtmlString();

        //new[]
        //               {
        //                   new Series
        //                   {
        //                       Name = "Ordenes pago",
        //                       //YAxis = 0,
        //                       Data = new Data(analisis.Select(o=> new Point { X = o.Tipo, Y = o.Cantidad } ).ToArray())
        //                   }
        //        }
    }
}