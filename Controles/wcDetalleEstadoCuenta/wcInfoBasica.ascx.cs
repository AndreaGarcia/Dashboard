using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controles_wcDetalleEstadoCuenta_wcInfoBasica : System.Web.UI.UserControl, IExtendedUserControl
{
    private int _tipoPrincipal;
    private int _tipoSecundario;
    private int _idOrden;
    private readonly RepositorioEntrada repositorioEntrada;
    private readonly RepositorioPago repositorioPago;
    public int TipoOrdenPrincipal
    {
        get
        {
            return _tipoPrincipal;
        }
        set
        {
            _tipoPrincipal = value;
        }
    }
    public int TipoOrdenSecundario
    {
        get
        {
            return _tipoSecundario;
        }
        set
        {
            _tipoSecundario = value;
        }
    }
    public int IdOrden
    {
        get
        {
            return _idOrden;
        }
        set
        {
            _idOrden = value;
        }
    }
    public Controles_wcDetalleEstadoCuenta_wcInfoBasica()
    {
        repositorioEntrada = new RepositorioEntrada();
    }
    public void OnInit()
    {
        errores.Text = string.Empty;

        if (TipoOrdenPrincipal == 1) //ORDEN DE PAGO/SALIDA
        {
            var informacion = repositorioPago.ObtenerInfoBasica(IdOrden);

            if (informacion != null)
            {
                Fideicomiso.Text = informacion.Fideicomiso;
                FechaFin.Text = informacion.Fecha.ToShortDateString();
                Empresa.Text = informacion.Empresa;
                NumOrden.Text = informacion.NumOrden.ToString();
                Estatus.Text = informacion.Estatus;
            }
        }
        if(TipoOrdenPrincipal==2) //ORDEN DE ENTRADA
        {
            var informacion = repositorioEntrada.ObtenerInfoBasica(IdOrden);

            if (informacion != null)
            {
                Fideicomiso.Text = informacion.Fideicomiso;
                FechaFin.Text = informacion.Fecha.ToShortDateString();
                Empresa.Text = informacion.Empresa;
                NumOrden.Text = informacion.NumOrden.ToString();
                Estatus.Text = informacion.Estatus;
            }
        }
        errores.Text = "Ocurrio un error al validar la Orden";
    }

}