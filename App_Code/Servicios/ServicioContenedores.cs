using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ServicioContenedores
/// </summary>
public class ServicioContenedores
{
	public ServicioContenedores()
	{
		//
		// TODO: Agregar aquí la lógica del constructor
		//
	}

    public List<IContainer> ObtenerTipo(int tipoOrdenPrincipal, int tipoOrdenSecundario, int idOrden)
    {
        return null;
    }
    private IEnumerable<IContainer> ObtenerOrdenPago(int tipoOrdenSecundario, int idOrden)
    {
        RepositorioPago repositorioPago = new RepositorioPago();
        switch (tipoOrdenSecundario)
        {
            case 1: return repositorioPago.ObtenerDetalleConcesionario(idOrden); break;
            case 2: return repositorioPago.ObtenerDetalleServicio(idOrden); break;
            case 3: return repositorioPago.ObtenerDetalleRecaudo(idOrden); break;
            case 4: return repositorioPago.ObtenerDetalleGenerica(idOrden); break;
            case 5: break;
        }
        return null;
    }
    private IEnumerable<IContainer> ObtenerOrdenEntrada(int tipoOrdenSecundario, int idOrden)
    {
        RepositorioEntrada repositorioEntrada = new RepositorioEntrada();
        switch(tipoOrdenSecundario)
        {
            case 1: repositorioEntrada.ObtenerDetalleTarifa(idOrden).ToList(); break;
            case 2: repositorioEntrada.ObtenerDetalleRedRecarga(idOrden).ToList(); break;
            case 3: repositorioEntrada.ObtenerDetalleCajeros(idOrden).ToList(); break;
            case 4: repositorioEntrada.ObtenerDetalleGenerica(idOrden).ToList(); break;
            case 5: break;
        }
        return null;
    }

}