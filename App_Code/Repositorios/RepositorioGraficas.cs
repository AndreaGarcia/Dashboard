using DotNet.Highcharts.Options;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de RepositorioGraficas
/// </summary>
public class RepositorioGraficas
{
    private readonly SICMST2Entities context;
    private DateTime min;
    private DateTime max;
	public RepositorioGraficas()
	{
        context = new SICMST2Entities();
	}

    private double ObtenerMilisegundos(DateTime fecha)
    {
        string formatoFecha = fecha.ToShortDateString();

        DateTime fechaFormateada = DateTime.ParseExact(formatoFecha, "dd/MM/yyyy", CultureInfo.InvariantCulture);
        return DotNet.Highcharts.Helpers.Tools.GetTotalMilliseconds(fechaFormateada);
    }
    private void AgregarMes(int meses, ref DateTime fecha)
    {
        fecha = fecha.AddMonths(meses);
    }
    private void ObtenerRangos(DateTime fecha)
    {
        if (min >= fecha || min == DateTime.MinValue)
            min = fecha;

        if (max <= fecha)
            max = fecha;
    }
    public Tuple<IEnumerable<Series>, Rangos> ObtenerAnalisisOrdenPago()
    {
        var ordenes = (from t in context.OrdenesPagoTipo
                       join o in context.OrdenesPago on t.IdTipoOrden equals o.Tipo into ordenesTipo
                       from ot in ordenesTipo.DefaultIfEmpty()
                       group ot by t);

        List<Series> series = new List<Series>();
        var rangos = new Rangos();
        foreach (var orden in ordenes)
        {
            series.Add(new Series
            {
                Name = orden.Key.Tipo,
                Data = new DotNet.Highcharts.Helpers.Data
                    (
                    new Point[] 
                    { 
                        new Point 
                        { 
                            Y = orden.Key.OrdenesPago.Count(), 
                            X = orden.Key.OrdenesPago.Count() > 0 ? DotNet.Highcharts.Helpers.Tools.GetTotalMilliseconds(orden.First().FechaFin) : 0 
                        } 
                    })
            });
            if (orden.Key.OrdenesPago.Count() > 0)
                ObtenerRangos(orden.OrderBy(x => x.FechaFin).First().FechaFin);
        }

        AgregarMes(1,  ref max);
        AgregarMes(-1, ref min);
        rangos.ValorMaximo = ObtenerMilisegundos(max);
        rangos.ValorMinimo = ObtenerMilisegundos(min);
        return new Tuple<IEnumerable<Series>, Rangos>(series, rangos);
    }
    public Tuple<IEnumerable<Series>, Rangos> ObtenerAnalisisOrdenPagoFideicomiso()
    {
        var ordenes = (from f in context.Fideicomisos
                       join o in context.OrdenesPago on f.IdFideicomiso equals o.Fideicomiso into ordenesF
                       from of in ordenesF.DefaultIfEmpty()
                       group of by f);

        List<Series> series = new List<Series>();
        var rangos = new Rangos();
        foreach (var orden in ordenes)
        {
            series.Add(new Series
            {
                Name = orden.Key.Fideicomiso,
                Data = new DotNet.Highcharts.Helpers.Data
                    (
                    new Point[] 
                    { 
                        new Point 
                        { 
                            Y = orden.Key.OrdenesPago.Count(), 
                            X = orden.Key.OrdenesPago.Count() > 0 ? DotNet.Highcharts.Helpers.Tools.GetTotalMilliseconds(orden.First().FechaFin) : 0 
                        } 
                    })
            });
            if (orden.Key.OrdenesPago.Count() > 0)
                ObtenerRangos(orden.OrderBy(x => x.FechaFin).First().FechaFin);
        }

        AgregarMes(1, ref max);
        AgregarMes(-1, ref min);
        rangos.ValorMaximo = ObtenerMilisegundos(max);
        rangos.ValorMinimo = ObtenerMilisegundos(min);
        return new Tuple<IEnumerable<Series>, Rangos>(series, rangos);
    }
    public Tuple<IEnumerable<Series>, Rangos> ObtenerAnalisisOrdenPagoEmpresa()
    {
        var ordenes = (from e in context.Empresas
                       join o in context.OrdenesPago on e.idEmpresa equals o.Empresa into ordenesE
                       from oe in ordenesE.DefaultIfEmpty()
                       group oe by e);

        List<Series> series = new List<Series>();
        var rangos = new Rangos();
        foreach (var orden in ordenes)
        {
            series.Add(new Series
            {
                Name = orden.Key.Nombre,
                Data = new DotNet.Highcharts.Helpers.Data
                    (
                    new Point[] 
                    { 
                        new Point 
                        { 
                            Y = orden.Key.OrdenesPago.Count(), 
                            X = orden.Key.OrdenesPago.Count() > 0 ? DotNet.Highcharts.Helpers.Tools.GetTotalMilliseconds(orden.First().FechaFin) : 0 
                        } 
                    })
            });

            if(orden.Key.OrdenesPago.Count() > 0)
                ObtenerRangos(orden.OrderBy(x => x.FechaFin).First().FechaFin);
        }

        AgregarMes(1, ref max);
        AgregarMes(-1, ref min);
        rangos.ValorMaximo = ObtenerMilisegundos(max);
        rangos.ValorMinimo = ObtenerMilisegundos(min);
        return new Tuple<IEnumerable<Series>, Rangos>(series, rangos);
    }
}