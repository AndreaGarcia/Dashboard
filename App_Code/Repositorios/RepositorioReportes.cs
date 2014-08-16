using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de RepositorioReportes
/// </summary>
public class RepositorioReportes
{
    private readonly SICMST2Entities context;
    private DateTime min;
    private DateTime max;
	public RepositorioReportes()
	{
		context = new SICMST2Entities();
	}
    public IEnumerable<Fideicomisos> ObtenerFideicomisos()
    {
        return context.Fideicomisos;
    }

}