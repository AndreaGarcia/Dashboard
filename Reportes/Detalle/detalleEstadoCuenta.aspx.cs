using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Reportes_Detalle_detalleEstadoCuenta : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.QueryString["tp"] != null && Request.QueryString["ts"] != null && Request.QueryString["id"] != null)
        {
            int tipoPrincipal;
            int.TryParse(Request.QueryString["tp"], out tipoPrincipal);
            int tipoSecundario;
            int.TryParse(Request.QueryString["ts"], out tipoSecundario);
            int idOrden;
            int.TryParse(Request.QueryString["id"], out idOrden);

            wcInfoBasica.TipoOrdenPrincipal = tipoPrincipal;
            wcInfoBasica.TipoOrdenSecundario = tipoSecundario;
            wcInfoBasica.IdOrden = idOrden;
            wcInfoBasica.OnInit();

            wcDetalleOrden.TipoOrdenPrincipal = tipoPrincipal;
            wcDetalleOrden.TipoOrdenSecundario = tipoSecundario;
            wcDetalleOrden.IdOrden = idOrden;
            wcDetalleOrden.OnInit();
        }
        else
        {
            errores.Text = "Ocurrio un error validando su Orden";
        }
    }
}