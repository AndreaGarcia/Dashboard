using DGAF;
using System;
using System.Configuration;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls.WebParts;

public partial class _Default : Page
{
    string cnnConexion = WebConfigurationManager.ConnectionStrings["cnnSICMST"].ConnectionString;
    SqlParameter[] sqlparam;
    cDataSet ds;


    protected void Page_Load(object sender, EventArgs e)
    {
        if (!IsPostBack)
        {
            RadAjaxManager1.EnableAJAX = Page.Request.Browser.SupportsXmlHttp;
            txtUsuario.Focus();
        }
    }
    protected void btnAcceso_Click(object sender, EventArgs e)
    {
        try
        {
            ds = new cDataSet();
            sqlparam = new SqlParameter[]
            {
                new SqlParameter("@Opcion", 6),
                new SqlParameter("@Usuario", txtUsuario.Text),
                new SqlParameter("@Pwd", txtContrasena.Text)
            };

            //if (ds.ExecSP(cnnConexion, "spUsuarios", "USUARIO", sqlparam))
            string sql = @"SELECT TOP 1000 [IdUsuario]
                          ,[Usuario]
                          ,[Nombre]
                          ,[Email]
                          ,[IdRol]
                          ,[Rol]
                          ,[Activo]
                          ,[IdEmpresa]
                      FROM [SICMST2].[dbo].[vUsuarios]
                      WHERE Usuario=@Usuario AND Pwd=@Pwd";

            if (ds.ExecQuery(cnnConexion, sql, "USUARIO", sqlparam))
            {
                foreach (DataRow row in ds.Tables["USUARIO"].Rows)
                {
                    Session["IdUsuario"] = row["IdUsuario"];
                    Session["Usuario"] = row["Usuario"];
                    Session["Nombre"] = row["Nombre"];
                    Session["IdRol"] = row["IdRol"];
                    Session["Rol"] = row["Rol"];
                    Session["IdEmpresa"] = row["IdEmpresa"];

                    Usuario.IniciarValores(
                            int.Parse(row["IdUsuario"].ToString()), 
                            row["Usuario"].ToString(), 
                            row["Nombre"].ToString(), 
                            int.Parse(row["IdRol"].ToString())
                        );


                    switch (Usuario.Rol)
                    {
                        case Rol.Administrador:
                            Response.Redirect(Page.ResolveUrl("~/Graficas/GraficasOrdenesPago.aspx"));
                            break;
                    }
                }
            }
            else
            {

            }
        }
        catch (Exception ex)
        {
            RadAjaxManager1.Alert("Error: " + ex.Message);
        }
    }
}