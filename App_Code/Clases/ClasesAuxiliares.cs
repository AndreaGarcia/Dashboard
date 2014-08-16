using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Descripción breve de ClasesAuxiliares
/// </summary>
public class AnalisisOrdenesPago
{
    public string Tipo { get; set; }

    public int Cantidad { get; set; }
}
public class Rangos
{
    public double ValorMinimo { get; set; }

    public double ValorMaximo { get; set; }
}

public class InformacionBasica
{
    public string Fideicomiso { get; set; }

    public DateTime Fecha { get; set; }

    public int NumOrden { get; set; }

    public string Estatus { get; set; }

    public string Empresa { get; set; }
}
public class EstadoCuenta
{
    public int Orden { get; set; }

    public string Tipo { get; set; }

    public DateTime Fecha { get; set; }

    public int Fideicomiso { get; set; }

    public string Empresa { get; set; }

    public decimal ImporteEntrada { get; set; }

    public decimal ImporteSalida { get; set; }
}