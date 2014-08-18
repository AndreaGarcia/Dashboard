using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de IContainer
/// </summary>
public interface IContainer
{
     Container Contenedor { get; }
}
public enum Container
{
    RedRecarga,
    CajerosAutormaticos,
    TarifaEfectivo,
    Concesionamiento,
    OperacionServicio,
    OperacionRecaudo,
    Generica,
    Desconocida
}