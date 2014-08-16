using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de IExtendedUserControl
/// </summary>
public interface IExtendedUserControl
{
    int TipoOrdenPrincipal { get; set; }
    int TipoOrdenSecundario { get; set; }
    int IdOrden { get; set; }
    void OnInit();
}