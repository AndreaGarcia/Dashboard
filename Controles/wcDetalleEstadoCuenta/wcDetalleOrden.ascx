<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wcDetalleOrden.ascx.cs" Inherits="Controles_wcDetalleEstadoCuenta_wcDetalleOrden" %>

<telerik:RadAjaxPanel ID="radAjaxPanel1" runat="server"></telerik:RadAjaxPanel>

<telerik:RadGrid runat="server" ID="rgDetalle" AllowSorting="false" AllowAutomaticInserts="true" AllowPaging="true" GridLines="None" Skin="Metro" width="790"
    AllowAutomaticDeletes="False" PageSize="30" ShowStatusBar="true" AllowAutomaticUpdates="False" AutoGenerateColumns="true">
    <MasterTableView ShowFooter="true" AutoGenerateColumns="false" DataKeyNames="Orden" ClientDataKeyNames="Orden" PageSize="30" CommandItemDisplay="None">
    </MasterTableView>
</telerik:RadGrid>