﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

public partial class Autobuses
{
    public Autobuses()
    {
        this.AutobusesKmServicio = new HashSet<AutobusesKmServicio>();
        this.AutobusesKmFueraServicio = new HashSet<AutobusesKmFueraServicio>();
        this.OrdenesPagoDetalle = new HashSet<OrdenesPagoDetalle>();
    }

    public int IdAutobus { get; set; }
    public Nullable<int> Empresa { get; set; }
    public int NumeroEconomico { get; set; }
    public Nullable<int> IdPropietario { get; set; }
    public string CveLargaRF { get; set; }
    public string Descripcion { get; set; }
    public bool Activo { get; set; }
    public Nullable<int> Ciudad { get; set; }
    public Nullable<int> Ruta { get; set; }
    public string Referencia { get; set; }
    public string IMEI { get; set; }
    public Nullable<decimal> TarifaEnServicio { get; set; }
    public Nullable<decimal> TarifaFueraServicio { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }

    public virtual Propietarios Propietarios { get; set; }
    public virtual Rutas Rutas { get; set; }
    public virtual Ciudades Ciudades { get; set; }
    public virtual Empresas Empresas { get; set; }
    public virtual ICollection<AutobusesKmServicio> AutobusesKmServicio { get; set; }
    public virtual ICollection<AutobusesKmFueraServicio> AutobusesKmFueraServicio { get; set; }
    public virtual ICollection<OrdenesPagoDetalle> OrdenesPagoDetalle { get; set; }
}

public partial class AutobusesKmFueraServicio
{
    public long IdKmFueraServicio { get; set; }
    public Nullable<int> Empresa { get; set; }
    public Nullable<int> Autobus { get; set; }
    public Nullable<System.DateTime> Fecha { get; set; }
    public Nullable<decimal> Kilometros { get; set; }
    public Nullable<long> IdOrdenPago { get; set; }
    public Nullable<long> IdOrdenDetalle { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }

    public virtual Autobuses Autobuses { get; set; }
    public virtual Empresas Empresas { get; set; }
}

public partial class AutobusesKmServicio
{
    public long IdKmServicio { get; set; }
    public Nullable<int> Empresa { get; set; }
    public Nullable<int> Autobus { get; set; }
    public Nullable<System.DateTime> Fecha { get; set; }
    public Nullable<decimal> Kilometros { get; set; }
    public Nullable<long> IdOrdenPago { get; set; }
    public Nullable<long> IdOrdenDetalle { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }

    public virtual Autobuses Autobuses { get; set; }
    public virtual Empresas Empresas { get; set; }
}

public partial class AutobusesTurnos_
{
    public int IdTurno { get; set; }
    public Nullable<int> VTR_IDTURNO { get; set; }
    public Nullable<int> VTR_CLAVECOND { get; set; }
    public string VTR_RUTADESCRIP { get; set; }
    public Nullable<int> VTR_NUMECON { get; set; }
    public string VTR_FHINICIO { get; set; }
    public string VTR_FHFINAL { get; set; }
    public Nullable<System.DateTime> VTR_FECHATURNO { get; set; }
    public Nullable<int> VTR_CORRIDA { get; set; }
    public Nullable<int> VTR_SUBIDAS { get; set; }
    public Nullable<int> VTR_BAJADAS { get; set; }
    public Nullable<int> VTR_AUXILIARES { get; set; }
    public Nullable<int> VTR_BLOQUEOS { get; set; }
    public Nullable<int> VTR_VUELTASBEA { get; set; }
    public Nullable<int> VTR_ASCENSOS { get; set; }
    public Nullable<int> VTR_PASAJEROS { get; set; }
    public Nullable<int> VTR_TARPROM { get; set; }
    public Nullable<decimal> VTR_DISTANCIA { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }
    public Nullable<bool> Procesado { get; set; }
    public Nullable<System.DateTime> FechaProcesado { get; set; }
}

public partial class Cajeros
{
    public int IdCajero { get; set; }
    public Nullable<int> Empresa { get; set; }
    public string Cajero { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }

    public virtual Empresas Empresas { get; set; }
}

public partial class Ciudades
{
    public Ciudades()
    {
        this.Autobuses = new HashSet<Autobuses>();
        this.Empresas = new HashSet<Empresas>();
        this.Fideicomisos = new HashSet<Fideicomisos>();
        this.Parabuses = new HashSet<Parabuses>();
        this.POS = new HashSet<POS>();
        this.Propietarios = new HashSet<Propietarios>();
        this.PuntosControl = new HashSet<PuntosControl>();
        this.Rutas = new HashSet<Rutas>();
        this.UsuarioTransporte = new HashSet<UsuarioTransporte>();
    }

    public int IdCiudad { get; set; }
    public string Nombre { get; set; }
    public string Abreviatura { get; set; }
    public bool Activo { get; set; }
    public Nullable<double> VersionSinc { get; set; }
    public Nullable<byte> Codigo { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }

    public virtual ICollection<Autobuses> Autobuses { get; set; }
    public virtual ICollection<Empresas> Empresas { get; set; }
    public virtual ICollection<Fideicomisos> Fideicomisos { get; set; }
    public virtual ICollection<Parabuses> Parabuses { get; set; }
    public virtual ICollection<POS> POS { get; set; }
    public virtual ICollection<Propietarios> Propietarios { get; set; }
    public virtual ICollection<PuntosControl> PuntosControl { get; set; }
    public virtual ICollection<Rutas> Rutas { get; set; }
    public virtual ICollection<UsuarioTransporte> UsuarioTransporte { get; set; }
}

public partial class ClaseTarjeta
{
    public ClaseTarjeta()
    {
        this.Tarjetas = new HashSet<Tarjetas>();
    }

    public int idClaseTarjeta { get; set; }
    public byte Codigo { get; set; }
    public string Descripcion { get; set; }
    public bool esPersonalizable { get; set; }
    public byte PassBack { get; set; }
    public double LimiteCredito { get; set; }
    public bool estaActivo { get; set; }
    public double VersionSinc { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }

    public virtual ICollection<Tarjetas> Tarjetas { get; set; }
}

public partial class Concesiones
{
    public int IdConcesion { get; set; }
    public string Titulo { get; set; }
    public Nullable<int> Empresa { get; set; }
    public Nullable<int> Propietario { get; set; }
    public Nullable<decimal> Renta { get; set; }
    public Nullable<bool> Activo { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }

    public virtual Empresas Empresas { get; set; }
    public virtual Propietarios Propietarios { get; set; }
}

public partial class dCobroEfectivo
{
    public long idTransaccion { get; set; }
    public System.DateTime fechaHora { get; set; }
    public Nullable<long> idTarjeta { get; set; }
    public string idDispositivo { get; set; }
    public decimal monto { get; set; }
    public decimal tarifa { get; set; }
    public byte pases { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }
}

public partial class dCobroPrepago
{
    public long idTransaccion { get; set; }
    public System.DateTime fechaHora { get; set; }
    public long idTarjeta { get; set; }
    public string idDispositivo { get; set; }
    public decimal monto { get; set; }
    public decimal saldo { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }
}

public partial class DiasFestivos
{
    public int IdDiaFestivo { get; set; }
    public Nullable<System.DateTime> Fecha { get; set; }
    public string Descripcion { get; set; }
}

public partial class Dispositivos
{
    public int idDispositivo { get; set; }
    public int idGrupoDispositivo { get; set; }
    public string Serie { get; set; }
    public Nullable<System.DateTime> FechaAdquisicion { get; set; }
    public string Vendedor { get; set; }
    public string Descripcion { get; set; }
    public System.DateTime FechaUltimoEstatus { get; set; }
    public string Calle { get; set; }
    public string NumeroCasa { get; set; }
    public string Colonia { get; set; }
    public string CP { get; set; }
    public double VersionSinc { get; set; }
    public Nullable<System.DateTime> fechaInstalacion { get; set; }
    public Nullable<byte> tipoLector { get; set; }
    public string SerieLector { get; set; }
    public Nullable<int> idEmpresa { get; set; }
    public Nullable<bool> Online { get; set; }
    public Nullable<long> EstatusRemoto { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }

    public virtual Empresas Empresas { get; set; }
    public virtual GrupoDispositivos GrupoDispositivos { get; set; }
}

public partial class Documentos
{
    public int IdDocumento { get; set; }
    public Nullable<long> OrdenPago { get; set; }
    public Nullable<long> OrdenEntrada { get; set; }
    public string Titulo { get; set; }
    public string Descripcion { get; set; }
    public byte[] Archivo { get; set; }
    public string FileName { get; set; }
    public int Categoria { get; set; }
    public string Extension { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }
    public Nullable<System.DateTime> FechaUA { get; set; }
    public Nullable<int> UsuarioUA { get; set; }

    public virtual OrdenesEntrada OrdenesEntrada { get; set; }
    public virtual OrdenesPago OrdenesPago { get; set; }
}

public partial class DocumentosCategoria
{
    public int IdCategoriaDocumento { get; set; }
    public string Categoria { get; set; }
}

public partial class dPrepagoCajeros
{
    public long idTransaccion { get; set; }
    public System.DateTime fechaHora { get; set; }
    public Nullable<long> idTarjeta { get; set; }
    public int idDispositivo { get; set; }
    public decimal monto { get; set; }
    public decimal saldo { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }
}

public partial class dPrepagoEstablecimientos
{
    public long idTransaccion { get; set; }
    public Nullable<System.DateTime> fechaHora { get; set; }
    public Nullable<long> idTarjeta { get; set; }
    public string idDispositivo { get; set; }
    public int idEstablecimiento { get; set; }
    public Nullable<double> monto { get; set; }
    public Nullable<double> saldo { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }
}

public partial class dPrepagoRedRecarga
{
    public long idTransaccion { get; set; }
    public Nullable<System.DateTime> fechaHora { get; set; }
    public long idTarjeta { get; set; }
    public string idDispositivo { get; set; }
    public string idTienda { get; set; }
    public Nullable<decimal> monto { get; set; }
    public Nullable<decimal> saldo { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }
}

public partial class Empresas
{
    public Empresas()
    {
        this.Autobuses = new HashSet<Autobuses>();
        this.AutobusesKmFueraServicio = new HashSet<AutobusesKmFueraServicio>();
        this.AutobusesKmServicio = new HashSet<AutobusesKmServicio>();
        this.Cajeros = new HashSet<Cajeros>();
        this.Concesiones = new HashSet<Concesiones>();
        this.Dispositivos = new HashSet<Dispositivos>();
        this.FideicomisosEmpresas = new HashSet<FideicomisosEmpresas>();
        this.OperacionesRecaudo = new HashSet<OperacionesRecaudo>();
        this.OrdenesPago = new HashSet<OrdenesPago>();
        this.RedRecarga = new HashSet<RedRecarga>();
        this.Tarjetas = new HashSet<Tarjetas>();
        this.Usuarios = new HashSet<Usuarios>();
    }

    public int idEmpresa { get; set; }
    public Nullable<int> Tipo { get; set; }
    public string Nombre { get; set; }
    public string Calle { get; set; }
    public string Numero { get; set; }
    public string Colonia { get; set; }
    public string CP { get; set; }
    public Nullable<int> idCiudad { get; set; }
    public bool Activo { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }

    public virtual ICollection<Autobuses> Autobuses { get; set; }
    public virtual ICollection<AutobusesKmFueraServicio> AutobusesKmFueraServicio { get; set; }
    public virtual ICollection<AutobusesKmServicio> AutobusesKmServicio { get; set; }
    public virtual ICollection<Cajeros> Cajeros { get; set; }
    public virtual Ciudades Ciudades { get; set; }
    public virtual ICollection<Concesiones> Concesiones { get; set; }
    public virtual ICollection<Dispositivos> Dispositivos { get; set; }
    public virtual EmpresasTipo EmpresasTipo { get; set; }
    public virtual ICollection<FideicomisosEmpresas> FideicomisosEmpresas { get; set; }
    public virtual ICollection<OperacionesRecaudo> OperacionesRecaudo { get; set; }
    public virtual ICollection<OrdenesPago> OrdenesPago { get; set; }
    public virtual ICollection<RedRecarga> RedRecarga { get; set; }
    public virtual ICollection<Tarjetas> Tarjetas { get; set; }
    public virtual ICollection<Usuarios> Usuarios { get; set; }
}

public partial class EmpresasTipo
{
    public EmpresasTipo()
    {
        this.Empresas = new HashSet<Empresas>();
    }

    public int IdTipo { get; set; }
    public string Tipo { get; set; }

    public virtual ICollection<Empresas> Empresas { get; set; }
}

public partial class Fideicomisos
{
    public Fideicomisos()
    {
        this.FideicomisosEmpresas = new HashSet<FideicomisosEmpresas>();
        this.OrdenesPago = new HashSet<OrdenesPago>();
        this.Usuarios = new HashSet<Usuarios>();
    }

    public int IdFideicomiso { get; set; }
    public Nullable<int> Ciudad { get; set; }
    public string Fideicomiso { get; set; }

    public virtual Ciudades Ciudades { get; set; }
    public virtual ICollection<FideicomisosEmpresas> FideicomisosEmpresas { get; set; }
    public virtual ICollection<OrdenesPago> OrdenesPago { get; set; }
    public virtual ICollection<Usuarios> Usuarios { get; set; }
}

public partial class FideicomisosEmpresas
{
    public int IdEmpresaFideicomiso { get; set; }
    public Nullable<int> Fideicomiso { get; set; }
    public Nullable<int> Empresa { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }

    public virtual Empresas Empresas { get; set; }
    public virtual Fideicomisos Fideicomisos { get; set; }
}

public partial class GrupoDispositivos
{
    public GrupoDispositivos()
    {
        this.Dispositivos = new HashSet<Dispositivos>();
    }

    public int idGrupoDispositivo { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public double VersionSinc { get; set; }
    public byte TipoLector { get; set; }
    public Nullable<int> idTipoEquipo { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }

    public virtual ICollection<Dispositivos> Dispositivos { get; set; }
    public virtual TipoEquipos TipoEquipos { get; set; }
}

public partial class OperacionesRecaudo
{
    public long IdOperacion { get; set; }
    public Nullable<int> Empresa { get; set; }
    public Nullable<System.DateTime> FechaRecaudo { get; set; }
    public Nullable<int> TipoRecaudo { get; set; }
    public Nullable<int> Clase { get; set; }
    public Nullable<int> Transacciones { get; set; }
    public Nullable<decimal> Cantidad { get; set; }
    public Nullable<decimal> Porcentaje { get; set; }
    public Nullable<long> IdOrdenPago { get; set; }
    public Nullable<long> IdOrdenDetalle { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }

    public virtual Empresas Empresas { get; set; }
    public virtual OperacionesRecaudoClase OperacionesRecaudoClase { get; set; }
    public virtual OperacionesRecaudoTipo OperacionesRecaudoTipo { get; set; }
}

public partial class OperacionesRecaudoClase
{
    public OperacionesRecaudoClase()
    {
        this.OperacionesRecaudo = new HashSet<OperacionesRecaudo>();
    }

    public int IdClase { get; set; }
    public Nullable<int> TipoRecaudo { get; set; }
    public string Clase { get; set; }
    public Nullable<int> Orden { get; set; }

    public virtual ICollection<OperacionesRecaudo> OperacionesRecaudo { get; set; }
    public virtual OperacionesRecaudoTipo OperacionesRecaudoTipo { get; set; }
}

public partial class OperacionesRecaudoTipo
{
    public OperacionesRecaudoTipo()
    {
        this.OperacionesRecaudo = new HashSet<OperacionesRecaudo>();
        this.OperacionesRecaudoClase = new HashSet<OperacionesRecaudoClase>();
    }

    public int IdTipo { get; set; }
    public string Tipo { get; set; }

    public virtual ICollection<OperacionesRecaudo> OperacionesRecaudo { get; set; }
    public virtual ICollection<OperacionesRecaudoClase> OperacionesRecaudoClase { get; set; }
}

public partial class OrdenesEntrada
{
    public OrdenesEntrada()
    {
        this.Documentos = new HashSet<Documentos>();
        this.OrdenesEntradaCanceladas = new HashSet<OrdenesEntradaCanceladas>();
        this.OrdenesEntradaDetalle = new HashSet<OrdenesEntradaDetalle>();
    }

    public long IdOrdenEntrada { get; set; }
    public int Tipo { get; set; }
    public Nullable<int> Empresa { get; set; }
    public Nullable<int> Fideicomiso { get; set; }
    public string Concepto { get; set; }
    public int Estatus { get; set; }
    public decimal Importe { get; set; }
    public System.DateTime FechaFin { get; set; }
    public string Observaciones { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> UsuarioRegistro { get; set; }
    public Nullable<System.DateTime> FechaAprobacion { get; set; }
    public Nullable<int> UsuarioAprobacion { get; set; }
    public Nullable<System.DateTime> FechaAutorizacion { get; set; }
    public Nullable<int> UsuarioAutorizacion { get; set; }
    public Nullable<System.DateTime> FechaPago { get; set; }
    public Nullable<int> UsuarioPago { get; set; }

    public virtual ICollection<Documentos> Documentos { get; set; }
    public virtual ICollection<OrdenesEntradaCanceladas> OrdenesEntradaCanceladas { get; set; }
    public virtual ICollection<OrdenesEntradaDetalle> OrdenesEntradaDetalle { get; set; }
}

public partial class OrdenesEntradaCanceladas
{
    public long IdOrdenEntradaCancelada { get; set; }
    public long OrdenEntrada { get; set; }
    public string Justificacion { get; set; }
    public Nullable<System.DateTime> FechaCancelacion { get; set; }
    public Nullable<int> Usuario { get; set; }

    public virtual OrdenesEntrada OrdenesEntrada { get; set; }
}

public partial class OrdenesEntradaDetalle
{
    public long IdOrdenDetalle { get; set; }
    public Nullable<long> Orden { get; set; }
    public string Concepto { get; set; }
    public Nullable<int> Transacciones { get; set; }
    public Nullable<decimal> Importe { get; set; }
    public Nullable<decimal> ImporteEPS { get; set; }
    public Nullable<System.DateTime> FechaCorte { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }

    public virtual OrdenesEntrada OrdenesEntrada { get; set; }
}

public partial class OrdenesEntradaEstatus
{
    public int IdEstatus { get; set; }
    public string Estatus { get; set; }
}

public partial class OrdenesEntradaTipo
{
    public int IdTipoOrden { get; set; }
    public string Tipo { get; set; }
}

public partial class OrdenesPago
{
    public OrdenesPago()
    {
        this.Documentos = new HashSet<Documentos>();
        this.OrdenesPagoCanceladas = new HashSet<OrdenesPagoCanceladas>();
        this.OrdenesPagoDetalle = new HashSet<OrdenesPagoDetalle>();
        this.OrdenesPagoPagos = new HashSet<OrdenesPagoPagos>();
    }

    public long IdOrdenPago { get; set; }
    public int Tipo { get; set; }
    public Nullable<int> Empresa { get; set; }
    public Nullable<int> Fideicomiso { get; set; }
    public string Concepto { get; set; }
    public int Estatus { get; set; }
    public decimal Importe { get; set; }
    public Nullable<System.DateTime> FechaIni { get; set; }
    public System.DateTime FechaFin { get; set; }
    public string Observaciones { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> UsuarioRegistro { get; set; }
    public Nullable<System.DateTime> FechaAprobacion { get; set; }
    public Nullable<int> UsuarioAprobacion { get; set; }
    public Nullable<System.DateTime> FechaAutorizacion { get; set; }
    public Nullable<int> UsuarioAutorizacion { get; set; }
    public Nullable<System.DateTime> FechaPago { get; set; }
    public Nullable<int> UsuarioPago { get; set; }
    public Nullable<System.DateTime> FechaRegistroMasAntiguo { get; set; }

    public virtual ICollection<Documentos> Documentos { get; set; }
    public virtual Empresas Empresas { get; set; }
    public virtual Fideicomisos Fideicomisos { get; set; }
    public virtual OrdenesPagoEstatus OrdenesPagoEstatus { get; set; }
    public virtual OrdenesPagoTipo OrdenesPagoTipo { get; set; }
    public virtual ICollection<OrdenesPagoCanceladas> OrdenesPagoCanceladas { get; set; }
    public virtual ICollection<OrdenesPagoDetalle> OrdenesPagoDetalle { get; set; }
    public virtual ICollection<OrdenesPagoPagos> OrdenesPagoPagos { get; set; }
}

public partial class OrdenesPagoCanceladas
{
    public long IdOrdenPagoCancelada { get; set; }
    public long OrdenPago { get; set; }
    public string Justificacion { get; set; }
    public Nullable<System.DateTime> FechaCancelacion { get; set; }
    public Nullable<int> Usuario { get; set; }

    public virtual OrdenesPago OrdenesPago { get; set; }
}

public partial class OrdenesPagoDetalle
{
    public long IdOrdenDetalle { get; set; }
    public Nullable<long> Orden { get; set; }
    public Nullable<int> Concesionario { get; set; }
    public Nullable<int> Autobus { get; set; }
    public Nullable<long> IdKmServicio { get; set; }
    public Nullable<long> IdKmFueraServicio { get; set; }
    public Nullable<long> IdOperacionRecaudo { get; set; }
    public Nullable<int> ClaseRecaudo { get; set; }
    public string Concepto { get; set; }
    public Nullable<decimal> Importe { get; set; }
    public Nullable<int> Transacciones { get; set; }
    public Nullable<decimal> Porcentaje { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }

    public virtual Autobuses Autobuses { get; set; }
    public virtual OrdenesPago OrdenesPago { get; set; }
}

public partial class OrdenesPagoEstatus
{
    public OrdenesPagoEstatus()
    {
        this.OrdenesPago = new HashSet<OrdenesPago>();
    }

    public int IdEstatus { get; set; }
    public string Estatus { get; set; }

    public virtual ICollection<OrdenesPago> OrdenesPago { get; set; }
}

public partial class OrdenesPagoPagos
{
    public long IdPago { get; set; }
    public Nullable<long> Orden { get; set; }
    public Nullable<decimal> Importe { get; set; }
    public Nullable<System.DateTime> FechaPago { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }

    public virtual OrdenesPago OrdenesPago { get; set; }
}

public partial class OrdenesPagoTipo
{
    public OrdenesPagoTipo()
    {
        this.OrdenesPago = new HashSet<OrdenesPago>();
    }

    public int IdTipoOrden { get; set; }
    public string Tipo { get; set; }

    public virtual ICollection<OrdenesPago> OrdenesPago { get; set; }
}

public partial class Parabuses
{
    public int IdParabus { get; set; }
    public Nullable<int> Ciudad { get; set; }
    public Nullable<int> Ruta { get; set; }
    public string Descripcion { get; set; }
    public Nullable<decimal> Latitud { get; set; }
    public Nullable<decimal> Longitud { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }

    public virtual Ciudades Ciudades { get; set; }
    public virtual Rutas Rutas { get; set; }
}

public partial class POS
{
    public int IdPos { get; set; }
    public Nullable<int> Tipo { get; set; }
    public Nullable<int> Ciudad { get; set; }
    public Nullable<int> Ruta { get; set; }
    public string Descripcion { get; set; }
    public Nullable<int> CantidadAutobuses { get; set; }
    public Nullable<System.TimeSpan> HoraInicio { get; set; }
    public Nullable<System.TimeSpan> HoraGuardia { get; set; }
    public Nullable<System.TimeSpan> HoraFin { get; set; }

    public virtual Ciudades Ciudades { get; set; }
    public virtual PosTipo PosTipo { get; set; }
    public virtual Rutas Rutas { get; set; }
}

public partial class PosTipo
{
    public PosTipo()
    {
        this.POS = new HashSet<POS>();
    }

    public int IdTipoPos { get; set; }
    public string Tipo { get; set; }

    public virtual ICollection<POS> POS { get; set; }
}

public partial class Propietarios
{
    public Propietarios()
    {
        this.Autobuses = new HashSet<Autobuses>();
        this.Concesiones = new HashSet<Concesiones>();
    }

    public int IdPropietario { get; set; }
    public string TipoPersona { get; set; }
    public string RFC { get; set; }
    public string RazonSocial { get; set; }
    public string Nombre { get; set; }
    public string Paterno { get; set; }
    public string Materno { get; set; }
    public string Calle { get; set; }
    public string NumExterior { get; set; }
    public string NumInterior { get; set; }
    public string Colonia { get; set; }
    public Nullable<int> CP { get; set; }
    public Nullable<int> Ciudad { get; set; }
    public string Telefono1 { get; set; }
    public string Telefono2 { get; set; }
    public string Email { get; set; }
    public bool Activo { get; set; }
    public string Referencia { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }

    public virtual ICollection<Autobuses> Autobuses { get; set; }
    public virtual Ciudades Ciudades { get; set; }
    public virtual ICollection<Concesiones> Concesiones { get; set; }
}

public partial class PuntosControl
{
    public int IdPuntoControl { get; set; }
    public Nullable<int> Ciudad { get; set; }
    public Nullable<int> Ruta { get; set; }
    public Nullable<decimal> Latitud { get; set; }
    public Nullable<decimal> Longitud { get; set; }
    public string Descripcion { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }

    public virtual Ciudades Ciudades { get; set; }
    public virtual Rutas Rutas { get; set; }
}

public partial class RedRecarga
{
    public int IdRedRecarga { get; set; }
    public Nullable<int> Empresa { get; set; }
    public string Grupo { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }

    public virtual Empresas Empresas { get; set; }
}

public partial class Roles
{
    public Roles()
    {
        this.Usuarios = new HashSet<Usuarios>();
    }

    public int IdRol { get; set; }
    public string Rol { get; set; }
    public string Desccripcion { get; set; }

    public virtual ICollection<Usuarios> Usuarios { get; set; }
}

public partial class Rutas
{
    public Rutas()
    {
        this.Autobuses = new HashSet<Autobuses>();
        this.Parabuses = new HashSet<Parabuses>();
        this.POS = new HashSet<POS>();
        this.PuntosControl = new HashSet<PuntosControl>();
    }

    public int IdRuta { get; set; }
    public string Ruta { get; set; }
    public string Lado { get; set; }
    public string Descripcion { get; set; }
    public Nullable<decimal> Longitud { get; set; }
    public int Ciudad { get; set; }
    public bool Activo { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }

    public virtual ICollection<Autobuses> Autobuses { get; set; }
    public virtual Ciudades Ciudades { get; set; }
    public virtual ICollection<Parabuses> Parabuses { get; set; }
    public virtual ICollection<POS> POS { get; set; }
    public virtual ICollection<PuntosControl> PuntosControl { get; set; }
}

public partial class Tarjetas
{
    public Tarjetas()
    {
        this.TarjetasUsuarios = new HashSet<TarjetasUsuarios>();
    }

    public long idTarjeta { get; set; }
    public int Codigo { get; set; }
    public string CodigoFisico { get; set; }
    public System.DateTime FechaCaducidad { get; set; }
    public double Saldo { get; set; }
    public Nullable<System.DateTime> FechaUltimaValidacion { get; set; }
    public Nullable<System.DateTime> FechaUltimaRecarga { get; set; }
    public System.DateTime FechaCambioEstatus { get; set; }
    public int idClaseTarjeta { get; set; }
    public double Costo { get; set; }
    public bool Activo { get; set; }
    public double VersionSinc { get; set; }
    public short Puntos { get; set; }
    public Nullable<int> idEmpresaEmite { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }

    public virtual ClaseTarjeta ClaseTarjeta { get; set; }
    public virtual Empresas Empresas { get; set; }
    public virtual ICollection<TarjetasUsuarios> TarjetasUsuarios { get; set; }
}

public partial class TarjetasUsuarios
{
    public int OID { get; set; }
    public int idUsuario { get; set; }
    public long idTarjeta { get; set; }
    public System.DateTime Fecha { get; set; }
    public double VersionSinc { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }

    public virtual Tarjetas Tarjetas { get; set; }
    public virtual UsuarioTransporte UsuarioTransporte { get; set; }
}

public partial class TipoEquipos
{
    public TipoEquipos()
    {
        this.GrupoDispositivos = new HashSet<GrupoDispositivos>();
    }

    public int idTipoEquipo { get; set; }
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public double VersionSinc { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }

    public virtual ICollection<GrupoDispositivos> GrupoDispositivos { get; set; }
}

public partial class Usuarios
{
    public int IdUsuario { get; set; }
    public string Usuario { get; set; }
    public string Pwd { get; set; }
    public string Nombre { get; set; }
    public string Email { get; set; }
    public Nullable<int> Rol { get; set; }
    public Nullable<bool> Activo { get; set; }
    public Nullable<int> Empresa { get; set; }
    public Nullable<int> Fideicomiso { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }

    public virtual Empresas Empresas { get; set; }
    public virtual Fideicomisos Fideicomisos { get; set; }
    public virtual Roles Roles { get; set; }
}

public partial class UsuarioTransporte
{
    public UsuarioTransporte()
    {
        this.TarjetasUsuarios = new HashSet<TarjetasUsuarios>();
    }

    public int idUsuario { get; set; }
    public string ApellidoPaterno { get; set; }
    public string ApellidoMaterno { get; set; }
    public string Nombre { get; set; }
    public Nullable<System.DateTime> FechaNacimiento { get; set; }
    public string CURP { get; set; }
    public byte[] Foto { get; set; }
    public Nullable<bool> Sexo { get; set; }
    public string RFC { get; set; }
    public string Telefono { get; set; }
    public string eMail { get; set; }
    public string Calle { get; set; }
    public string Numero { get; set; }
    public string Colonia { get; set; }
    public string CP { get; set; }
    public Nullable<int> idCiudad { get; set; }
    public string NumeroIdentificacion { get; set; }
    public bool estaActivo { get; set; }
    public double VersionSinc { get; set; }
    public string NumInt { get; set; }
    public string TipoSangre { get; set; }
    public Nullable<bool> Donador { get; set; }
    public string NombreFamiliar { get; set; }
    public string TelefonoFamiliar { get; set; }
    public Nullable<int> Folio { get; set; }
    public Nullable<bool> esCurpOficial { get; set; }
    public Nullable<System.DateTime> FechaRegistro { get; set; }
    public Nullable<int> Usuario { get; set; }

    public virtual Ciudades Ciudades { get; set; }
    public virtual ICollection<TarjetasUsuarios> TarjetasUsuarios { get; set; }
}
