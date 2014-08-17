using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

/// <summary>
/// Descripción breve de RepositorioEstadoDeCuenta
/// </summary>
public class RepositorioEstadoDeCuenta
{
    private SICMST2Entities context;
    private string connStr = "Data Source=calantha.arvixe.com;Initial Catalog=SICMST2;User ID=sicmst;Password=.tsmcis.;";
	public RepositorioEstadoDeCuenta()
	{
        context = new SICMST2Entities();
	}

    public List<EstadoCuenta> ObtenerEstadoCuenta(string query)
    {
        using (context = new SICMST2Entities())
        {
            using (var tran = context.Database.BeginTransaction())
            {
                try
                {
                    var result = context.Database.SqlQuery<EstadoCuenta>(query).ToList();
                    return result;
                }
                catch (Exception e)
                {
                    string x = e.Message;
                    return null;
                }
            }
        }
    }
}