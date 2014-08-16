using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

/// <summary>
/// Descripción breve de RepositorioEstadoDeCuenta
/// </summary>
public class RepositorioEstadoDeCuenta
{
    private readonly SICMST2Entities context;
	public RepositorioEstadoDeCuenta()
	{
        context = new SICMST2Entities();
	}

    public async Task<List<T>> ObtenerQueryGenerico<T>(string query)
    {
        return await context.Database.SqlQuery<T>(query).ToListAsync();
    }
}