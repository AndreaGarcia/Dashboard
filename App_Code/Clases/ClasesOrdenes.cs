using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


//SUBTIPOS ORDENES DE ENTRADA
public class ContenedorRedRecarga:IContainer
{
    private Container _contenedor = Container.RedRecarga;
    public string Grupo { get; set; }
    public int Transacciones { get; set; }
    public decimal Cantidad { get; set; }

    public Container Contenedor
    {
        get
        {
            return _contenedor;
        }
    }
}
public class ContenedorCajerosAutomaticos : IContainer
{
    private Container _contenedor = Container.CajerosAutormaticos;
    public string Cajero { get; set; }
    public int Transacciones { get; set; }
    public decimal Cantidad { get; set; }

    public Container Contenedor
    {
        get
        {
            return _contenedor;
        }
    }
}
public class ContenedorTarifaEfectivo : IContainer
{
    private Container _contenedor = Container.TarifaEfectivo;
    public int Clase { get; set; }
    public int Transacciones { get; set; }
    public decimal Cantidad { get; set; }

    public Container Contenedor
    {
        get
        {
            return _contenedor;
        }
    }
}
//SUBTIPOS ORDENES DE PAGO/SALIDA
public class ContenedorConcesionamiento : IContainer
{
    private Container _contenedor = Container.Concesionamiento;
    public int? Concesion { get; set; }
    public int? Autobus { get; set; }
    public decimal? Cantidad { get; set; }

    public Container Contenedor
    {
        get
        {
            return _contenedor;
        }
    }
}
public class ContenedorOperacionServicio : IContainer
{
    private Container _contenedor = Container.OperacionServicio;
    public int Autobus { get; set; }
    public decimal KMServicio { get; set; }
    public decimal TarifaServicio { get; set; }
    public decimal KMFueraServicio { get; set; }
    public decimal TarifaFueraServicio { get; set; }
    public decimal TotalServicio { get; set; }
    public decimal TotalFueraServicio { get; set; }
    public decimal TotalGeneral { get; set; }

    public Container Contenedor
    {
        get
        {
            return _contenedor;
        }
    }
}
public class ContenedorOperacionRecaudo : IContainer
{
    private Container _contenedor = Container.OperacionRecaudo;
    public string Clase { get; set; }
    public int? Transacciones { get; set; }
    public decimal? Cantidad { get; set; }
    public decimal? Porcentaje { get; set; }
    public decimal? Total { get; set; }


    public Container Contenedor
    {
        get
        {
            return _contenedor;
        }
    }
}
//GENERICA PARA ENTRADA/PAGO
public class ContenedorGenerica : IContainer
{
    private Container _contenedor = Container.Generica;
    public string Concepto { get; set; }
    public decimal? Cantidad { get; set; }


    public Container Contenedor
    {
        get
        {
            return _contenedor;
        }
    }
}