using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de Enums
/// </summary>
public enum Rol
{
    Administrador,
    Concesionario,
    Generador,
    OperadorRecaudo,
    OperadorServicio,
    Autorizador,
    Fideicomiso
}

public enum OrdenSolicitada
{
    OperadorServicio,
    OperadorRecaudo,
    Concesionario,
    CajeroAutomatico,
    RedRecarga,
    TarifaEfectivo
}

public enum TipoOrdenesEntrada
{
    RedRecarga,
    CajerosAutomaticos,
    TarifaEfectivo
}

public enum EstadoOrden
{
    Aceptada,
    Pendiente,
    Rechazada
}

public enum Ordenes
{
    OperadorServicio,
    Concesionario,
    OperadorRecaudo
}