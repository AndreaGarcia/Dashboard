using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Controles_wcDetalleEstadoCuenta_wcDetalleOrden : System.Web.UI.UserControl, IExtendedUserControl
{
    private int _tipoPrincipal;
    private int _tipoSecundario;
    private int _idOrden;
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

    private ServicioContenedores servicioContenedores;
    public Controles_wcDetalleEstadoCuenta_wcDetalleOrden()
    {
        servicioContenedores = new ServicioContenedores();
    }
    public void OnInit()
    {
        var resultado = servicioContenedores.ObtenerTipo(TipoOrdenPrincipal, TipoOrdenSecundario, IdOrden);
        if(resultado != null && resultado.Count > 0){
            switch (resultado.FirstOrDefault().Contenedor)
            {
                case Container.Concesionamiento: rgDetalle.DataSource = resultado.ConvertAll(x => (ContenedorConcesionamiento)x); break;
                case Container.OperacionRecaudo: rgDetalle.DataSource = resultado.ConvertAll(x => (ContenedorOperacionRecaudo)x); break;
                case Container.OperacionServicio: rgDetalle.DataSource = resultado.ConvertAll(x => (ContenedorOperacionServicio)x); break;
                case Container.RedRecarga: rgDetalle.DataSource = resultado.ConvertAll(x => (ContenedorRedRecarga)x); break;
                case Container.CajerosAutormaticos: rgDetalle.DataSource = resultado.ConvertAll(x => (ContenedorCajerosAutomaticos)x); break;
                case Container.TarifaEfectivo: rgDetalle.DataSource = resultado.ConvertAll(x => (ContenedorTarifaEfectivo)x); break;
                case Container.Generica: rgDetalle.DataSource = resultado.ConvertAll(x => (ContenedorGenerica)x); break;
            }
        }
    }
    protected void Page_Load(object sender, EventArgs e)
    {

    }
}