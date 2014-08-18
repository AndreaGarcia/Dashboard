using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


public class RepositorioPago
{
    private readonly SICMST2Entities bd;
	public RepositorioPago()
	{
        bd = new SICMST2Entities();
	}
    public InformacionBasica ObtenerInfoBasica(int idOrden)
    {
        return (from o in bd.OrdenesPago
                join s in bd.OrdenesPagoEstatus on o.Estatus equals s.IdEstatus
                join e in bd.Empresas on o.Empresa equals e.idEmpresa
                join c in bd.Ciudades on e.idCiudad equals c.IdCiudad
                join f in bd.Fideicomisos on o.Fideicomiso equals f.IdFideicomiso
                where o.IdOrdenPago == idOrden
                select new InformacionBasica
                {
                    Estatus = s.Estatus,
                    Fecha = o.FechaFin,
                    Fideicomiso = f.Fideicomiso,
                    NumOrden = (int)o.IdOrdenPago,
                    Empresa = e.Nombre
                }).FirstOrDefault();
    }

    public List<ContenedorConcesionamiento> ObtenerDetalleConcesionario(int idOrden)
    {
        return bd.OrdenesPagoDetalle.Where(x => x.Orden == idOrden).Select((i, x) => new ContenedorConcesionamiento {
            Concesion= i.Concesionario,
            Autobus = i.Autobus,
            Cantidad= i.Importe
        }).ToList();
    }
    public IEnumerable<ContenedorOperacionRecaudo> ObtenerDetalleRecaudo(long idOrden)
    {
        return from d in bd.OrdenesPagoDetalle
               join c in bd.OperacionesRecaudoClase  on d.ClaseRecaudo equals c.IdClase
               where d.Orden == idOrden
               select new ContenedorOperacionRecaudo
               {
                   Clase = c.Clase,
                   Transacciones = d.Transacciones,
                   Cantidad = d.Importe,
                   Porcentaje = d.Porcentaje,
                   Total = d.Importe * d.Porcentaje
               };
    }
    public List<ContenedorOperacionServicio> ObtenerDetalleServicio(long idOrden)
    {
        //return from d in bd.OrdenesPagoDetalle
        //       join c in bd.OperacionesRecaudoClase on d.ClaseRecaudo equals c.id
        //       where d.Orden == idOrden
        //       select new ContenedorOperacionRecaudo
        //       {
        //           Clase = c.Clase,
        //           Transacciones = d.Transacciones,
        //           Cantidad = d.Importe,
        //           Porcentaje = d.Porcentaje,
        //           Total = d.Importe * d.Porcentaje
        //       };
        return null;
    }
    public List<ContenedorGenerica> ObtenerDetalleGenerica(int idOrden)
    {
        return bd.OrdenesPagoDetalle.Where(x => x.Orden == idOrden).Select((i, x) => new ContenedorGenerica
        {
            Concepto = i.Concepto,
            Cantidad = i.Importe
        }).ToList();
    }
}