using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

/// <summary>
/// Descripción breve de ServicioEstadoCuenta
/// </summary>
public class ServicioEstadoCuenta
{
    private readonly RepositorioEstadoDeCuenta repositorioEstadoCuenta;
	public ServicioEstadoCuenta()
	{
        repositorioEstadoCuenta = new RepositorioEstadoDeCuenta();
	}

    public List<EstadoCuenta> ObtenerEstadoCuenta(DateTime inicio, DateTime fin, int idFideicomiso)
    {
        if(inicio == null || fin == null || idFideicomiso <= 0) 
            throw new ArgumentNullException("Los valores proporcionados no pueden ser nulos", "inicio, fin o fideicomiso");

        if (inicio > fin)
            throw new ArgumentOutOfRangeException("El valor de inicio no debe ser mayor al de fin");

        string query = string.Format(@"select R.Orden AS Orden, R.Tipo AS Tipo, R.Fecha AS Fecha, R.Fideicomiso AS Fideicomiso, R.Empresa AS Empresa, R.Concepto AS Concepto, R.ImporteEntrada AS ImporteEntrada,R.ImporteSalida AS ImporteSalida FROM 
                        (
                        SELECT 'Entrada' AS Tipo, oe.IdOrdenEntrada AS Orden, oe.fechaorden AS Fecha, f.IdFideicomiso AS Fideicomiso, e.Nombre AS Empresa, d.concepto AS Concepto, SUM(d.importe) AS ImporteEntrada, 0 AS ImporteSalida
                        FROM OrdenesEntrada oe JOIN
                        OrdenesEntradaDetalle d on oe.idordenentrada = d.orden JOIN
                        fideicomisos f on oe.fideicomiso = f.IdFideicomiso JOIN 
                        Empresas e on oe.empresa = e.IdEmpresa
                        GROUP BY oe.IdOrdenEntrada, oe.fechaorden,  f.IdFideicomiso, e.Nombre, d.concepto
                        UNION ALL
                        SELECT 'Pago' AS Tipo, op.IdOrdenPago AS Orden, op.fechaorden AS Fecha, f.IdFideicomiso AS Fideicomiso, e.Nombre AS Empresa, d.concepto AS Concepto, 0 AS ImporteEntrada, SUM(d.Importe) AS ImporteSalida
                        FROM OrdenesPago op JOIN
                        OrdenesPagoDetalle d on op.idordenpago = d.orden JOIN
                        fideicomisos f on op.fideicomiso = f.IdFideicomiso JOIN 
                        Empresas e on op.empresa = e.IdEmpresa
                        GROUP BY op.IdOrdenPago, op.fechaorden,  f.IdFideicomiso, e.Nombre, d.concepto
                        ) AS R
                        WHERE R.Fideicomiso = " + idFideicomiso + " AND R.Fecha >= '" + inicio.ToString("yyyy-MM-dd") + "' AND R.Fecha <= '" + fin.ToString("yyyy-MM-dd") + "'");
       
        List<EstadoCuenta> estadoCuenta = repositorioEstadoCuenta.ObtenerEstadoCuenta(query);

        return estadoCuenta;
    }
}