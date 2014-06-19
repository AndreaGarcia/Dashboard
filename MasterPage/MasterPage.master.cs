using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class MasterPage_MasterPage : System.Web.UI.MasterPage
{
    protected override void OnInit(EventArgs e)
    {
        NombreUsuario.Text = Session["Nombre"] == null ? "NA" : Session["Nombre"].ToString();
        
        if (!IsPostBack)
        {
            if (Session["IdUsuario"] == null)
            {
                ibCerrarSession_Click(null, null);
            }
        }
        switch (Session["IdRol"].ToString())
        {
            case "1":
                Control ctrl1 = Page.LoadControl("~/Controles/wcMenu/wcMenuAdministrador.ascx");
                ControlesMenu.Controls.Clear();
                ControlesMenu.Controls.Add(ctrl1);
                break;
        }

    }

    protected void ibCerrarSession_Click(object sender, ImageClickEventArgs e)
    {
        Session["IdUsuario"] = null;
        Session["Usuario"] = null;
        Session["Nombre"] = null;
        Session["IdRol"] = null;
        Session["Rol"] = null;
        Session["Usuario"] = null;
        Response.Redirect("~/Default.aspx");
    }
}
