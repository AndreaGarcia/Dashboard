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
    public IEnumerable<Series> ObtenerAnalisisOrdenPago()
    {
        var ordenes = (from t in context.OrdenesPagoTipo
                       join o in context.OrdenesPago on t.IdTipoOrden equals o.Tipo into ordenesTipo
                       from ot in ordenesTipo.DefaultIfEmpty()
                       group ot by t);

        List<Series> series = new List<Series>();
        foreach (var orden in ordenes)
        {
            series.Add(new Series
            {
                Name = orden.Key.Tipo,
                Data = new DotNet.Highcharts.Helpers.Data(new Point[] { new Point { Y = orden.Key.OrdenesPago.Count() } })
            });
        }

        return series;
    }
    public IEnumerable<Series> ObtenerAnalisisOrdenPagoFideicomiso()
    {
        var ordenes = (from f in context.Fideicomisos
                       join o in context.OrdenesPago on f.IdFideicomiso equals o.Fideicomiso into ordenesF
                       from of in ordenesF.DefaultIfEmpty()
                       group of by f);

        List<Series> series = new List<Series>();
        foreach (var orden in ordenes)
        {
            series.Add(new Series
            {
                Name = orden.Key.Fideicomiso,
                Data = new DotNet.Highcharts.Helpers.Data(new Point[] { new Point { Y = orden.Key.OrdenesPago.Count() } })
            });
        }

        return series;
    }
    public IEnumerable<Series> ObtenerAnalisisOrdenPagoEmpresa()
    {
        var ordenes = (from e in context.Empresas
                       join o in context.OrdenesPago on e.idEmpresa equals o.Empresa into ordenesE
                       from oe in ordenesE.DefaultIfEmpty()
                       group oe by e);

        List<Series> series = new List<Series>();
        foreach (var orden in ordenes)
        {
            series.Add(new Series
            {
                Name = orden.Key.Nombre,
                Data = new DotNet.Highcharts.Helpers.Data(new Point[] { new Point { Y = orden.Key.OrdenesPago.Count() } })
            });
        }

        return series;
    }
}