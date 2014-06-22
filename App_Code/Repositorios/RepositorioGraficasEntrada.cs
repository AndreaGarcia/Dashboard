using DotNet.Highcharts.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de RepositorioGraficasEntrada
/// </summary>
public class RepositorioGraficasEntrada
{
    private readonly SICMST2Entities context;
	public RepositorioGraficasEntrada()
	{
		context = new SICMST2Entities();
	}
    public IEnumerable<Series> ObtenerAnalisisOrdenEntrada()
    {
        var ordenes = (from t in context.OrdenesEntradaTipo
                       join o in context.OrdenesEntrada on t.IdTipoOrden equals o.Tipo into ordenesEntradaTipo
                       from ot in ordenesEntradaTipo.DefaultIfEmpty()
                       group ot by t);

        List<Series> series = new List<Series>();
        foreach (var orden in ordenes)
        {
            series.Add(new Series
            {
                Name = orden.Key.Tipo,
                Data = new DotNet.Highcharts.Helpers.Data(new Point[] { new Point { Y = orden.Key.OrdenesEntrada.Count() } })
            });
        }

        return series;
    }
    public IEnumerable<Series> ObtenerAnalisisOrdenEntradaFideicomiso()
    {
        var ordenes = (from f in context.Fideicomisos
                       join o in context.OrdenesEntrada on f.IdFideicomiso equals o.Fideicomiso into ordenesF
                       from of in ordenesF.DefaultIfEmpty()
                       group of by f);

        List<Series> series = new List<Series>();
        foreach (var orden in ordenes)
        {
            series.Add(new Series
            {
                Name = orden.Key.Fideicomiso,
                Data = new DotNet.Highcharts.Helpers.Data(new Point[] { new Point { Y = orden.Key.OrdenesEntrada.Count() } })
            });
        }
        return series;
    }
    public IEnumerable<Series> ObtenerAnalisisOrdenEntradaEmpresa()
    {
        var ordenes = (from e in context.Empresas
                       join o in context.OrdenesEntrada on e.idEmpresa equals o.Empresa into ordenesE
                       from oe in ordenesE.DefaultIfEmpty()
                       group oe by e);

        List<Series> series = new List<Series>();
        foreach (var orden in ordenes)
        {
            series.Add(new Series
            {
                Name = orden.Key.Nombre,
                Data = new DotNet.Highcharts.Helpers.Data(new Point[] { new Point { Y = orden.Key.OrdenesEntrada.Count() } })
            });
        }
        return series;
    }
}