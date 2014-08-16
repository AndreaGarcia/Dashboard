<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wcInfoBasica.ascx.cs" Inherits="Controles_wcDetalleEstadoCuenta_wcInfoBasica" %>

<div id="DetalleOrden" style="background-color: aliceblue; width:790px; font-family:Segoe UI">
    <table cellspacing="8" style="font-size:small; border-bottom:medium;font-family:Segoe UI" >
        <tr>
            <td><label>FIDEICOMISO:</label></td>
            <td> <asp:Label ID="Fideicomiso" runat="server"></asp:Label></td>

            <td style="width:166px; text-align:right"><label>ESTATUS:</label></td>
            <td><asp:Label ID="Estatus" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td ><label>EMPRESA:</label></td>
            <td><asp:Label ID="Empresa" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td><label>FECHA:</label></td>
            <td><asp:Label ID="FechaFin" runat="server"></asp:Label></td>
        </tr>
        <tr>
            <td><label>ORDEN:</label></td>
            <td><asp:Label ID="NumOrden" runat="server"></asp:Label></td>
        </tr>
    </table>
</div>
<asp:Label ID="errores" runat="server" Style="color: red; padding-top: 15px; padding-left: 40px;"></asp:Label>