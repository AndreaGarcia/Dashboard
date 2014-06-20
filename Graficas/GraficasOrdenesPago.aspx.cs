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
     
    }
    protected void Page_Load(object sender, EventArgs e)
    {
        Highcharts chart = new Highcharts("chart")
              .InitChart(new Chart { DefaultSeriesType = ChartTypes.Line })
              .SetTitle(new Title { Text = "Combiner History" })
              .SetXAxis(new XAxis { Type = AxisTypes.Datetime })
              .SetYAxis(new[]
                      {
                          new YAxis
                          {
                              Title = new YAxisTitle { Text = "Current" },
                              GridLineWidth = 1
                          }
                      })
              .SetSeries(new[]
                       {
                           new Series
                           {
                               Name = "Current",
                               //YAxis = 0,
                               Data = new Data(history.Select(x => new Point { X = GetTotalMilliseconds(x.recordTime), Y = x.current}).ToArray())
                           }
         });
    }
}