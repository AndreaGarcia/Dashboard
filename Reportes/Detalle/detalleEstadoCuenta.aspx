<%@ Page Language="C#" AutoEventWireup="true" CodeFile="detalleEstadoCuenta.aspx.cs" Inherits="Reportes_Detalle_detalleEstadoCuenta" %>

<%@ Register Src="~/Controles/wcDetalleEstadoCuenta/wcInfoBasica.ascx" TagName="wcInfoBasica" TagPrefix="wcIB" %>
<%@ Register Src="~/Controles/wcDetalleEstadoCuenta/wcDetalleOrden.ascx" TagName="wcDetalleOrden" TagPrefix="wcD" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cpContenido" runat="Server">
    <article class="art-post art-article">
        <div class="art-postcontent art-postcontent-0 clearfix">
            <div class="art-content-layout">
                <div class="art-content-layout-row">
                    <div  id="botones" style="display:inline;float:right" runat="server">
                        <telerik:RadButton runat="server" ID="btnImprimir" Text="IMPRIMIR" Skin="MetroTouch"></telerik:RadButton>
                    </div>
                    <h3>INFORMACION DE LA ORDEN</h3>

                    <telerik:RadFormDecorator ID="QsfFromDecorator" runat="server" DecoratedControls="All" EnableRoundedCorners="false" />
                    <telerik:RadAjaxLoadingPanel runat="server" ID="LoadingPanel1" Skin="MetroTouch">
                    </telerik:RadAjaxLoadingPanel>
                    <telerik:RadAjaxManager runat="server" ID="RadAjaxManager1" EnablePageHeadUpdate="true">
                    </telerik:RadAjaxManager>

                    <div class="exampleWrapper">
                        <div>
                            <div id="InformacionBasicaControl" runat="server" style="margin-top: 10px; margin-left: 150px;">
                             <wcIB:wcInfoBasica ID="wcInfoBasica" runat="server" Visible="false" />
                            </div>
                             <div id="InformacionDetalleControl" runat="server" style="margin-top: 10px; margin-left: 150px;">
                             <wcD:wcDetalleOrden ID="wcDetalleOrden" runat="server" Visible="false" />
                            </div>
                        </div>
                        <asp:Label ID="errores" runat="server" Style="color: red; padding-top: 15px; padding-left: 40px;"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </article>
</asp:Content>