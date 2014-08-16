using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de RepositorioEntrada
/// </summary>
public class RepositorioEntrada
{
    private readonly SICMST2Entities bd;
	public RepositorioEntrada()
	{
        bd = new SICMST2Entities();
	}
    public InformacionBasica ObtenerInfoBasica(int idOrden)
    {
        return (from o in bd.OrdenesEntrada
                join f in bd.Fideicomisos on o.Fideicomiso equals f.IdFideicomiso
                join e in bd.Empresas on o.Empresa equals e.idEmpresa
                join s in bd.OrdenesEntradaEstatus on o.Estatus equals s.IdEstatus
                where o.IdOrdenEntrada == idOrden
                select new InformacionBasica
                {
                    Estatus = s.Estatus,
                    Fecha = o.FechaFin,
                    Fideicomiso = f.Fideicomiso,
                    NumOrden = (int)o.IdOrdenEntrada,
                    Empresa = e.Nombre

                }).FirstOrDefault();
    }
}