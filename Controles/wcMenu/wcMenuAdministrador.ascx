<%@ Control Language="C#" AutoEventWireup="true" CodeFile="wcMenuAdministrador.ascx.cs" Inherits="Controles_wcMenuAdministrador" %>

<style>
    .ColorRenglon tr:hover {
        background: #E5E8EF;
    }
    #TablaMenu tr {
    cursor: pointer;
}
</style>
<div class="art-block clearfix">
    <div class="art-blockheader">
        <h3 class="t" style="color: white">GRÁFICAS</h3>
    </div>
    <div class="art-blockcontent">
        <table cellpadding="0" cellspacing="0" style="width: 100%; text-align: center;" class="ColorRenglon" id="TablaMenu">
            <tr id="Tr1" href="/Graficas/GraficasOrdenesPago.aspx">
                <td>
                    <asp:Image ID="Image6" runat="server" AlternateText="Gráficas" ImageUrl="~/Images/menuImages/Graficas.png" Width="32px" Height="32px"/>
                </td>
                <td style="text-align: left">
                    <b>Ordenes de Pago
                    </b>
                </td>
            </tr>
              <tr id="Tr2" href="/Graficas/GraficasOrdenesEntrada.aspx">
                <td>
                    <asp:Image ID="Image1" runat="server" AlternateText="Gráficas" ImageUrl="~/Images/menuImages/Graficas2.png" Width="32px" Height="32px"/>
                </td>
                <td style="text-align: left">
                    <b>Ordenes de Entrada
                    </b>
                </td>
            </tr>
        </table>
    </div>
    </div>


<script>
    $(document).ready(function () {
        $('#TablaMenu tr').click(function () {
            window.location = $(this).attr('href');
            return false;
        });
    });
</script>
