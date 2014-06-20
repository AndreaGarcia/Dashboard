using DotNet.Highcharts.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de RepositorioGraficas
/// </summary>
public class RepositorioGraficas
{
    private readonly SICMST2Entities context;
	public RepositorioGraficas()
	{
        context = new SICMST2Entities();
	}

    public IEnumerable<Series> ObtenerAnalisisOrdenPago(DateTime inicio, DateTime fin)
    {
        var ordenes = (from t in context.OrdenesPagoTipo
                join o in context.OrdenesPago on t.IdTipoOrden equals o.Tipo into ordenesTipo
                from ot in ordenesTipo.DefaultIfEmpty()
                where ot.FechaRegistro > inicio && ot.FechaRegistro < fin
                group ot by t);

        List<Series> series = new List<Series>();
        foreach (var orden in ordenes)
        {
            series.Add(new Series
            {
                   Name = orden.Key.Tipo,
                   Data = new DotNet.Highcharts.Helpers.Data(new Point[] { new Point { Y = orden.Count() } })
            });
        }

        return series;

    }
}