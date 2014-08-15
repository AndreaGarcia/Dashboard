<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Reportes_Index" %>

<%@ Register Assembly="Telerik.ReportViewer.WebForms, Version=8.0.14.225, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" Namespace="Telerik.ReportViewer.WebForms" TagPrefix="telerik" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cpContenido" runat="Server">
    <article class="art-post art-article">
        <div class="art-postcontent art-postcontent-0 clearfix">
            <div class="art-content-layout">
                <div class="art-content-layout-row">
                    <h3>REPORTES</h3>
                    <div id="FiltradoReporte" style="padding-top:50px;padding-bottom:80px;display:flex">
                        <telerik:RadDropDownList ID="TipoReporte" runat="server" Skin="MetroTouch" DefaultMessage="Seleccione el tipo de reporte..." Width="250px" DropDownWidth="250px" OnSelectedIndexChanged="TipoReporte_SelectedIndexChanged" AutoPostBack="true">
                            <Items>
                                <telerik:DropDownListItem Text="Orden de pago" Value="1" runat="server"/>
                                <telerik:DropDownListItem Text="Orden de entrada" Value="2" runat="server" />
                            </Items>
                        </telerik:RadDropDownList>
                         <telerik:RadDropDownList ID="TipoOrden" runat="server" Skin="MetroTouch" DefaultMessage="Seleccione el tipo de orden..." Width="300px" DropDownWidth="300px" Visible="false" style="padding-left:10px" OnSelectedIndexChanged="TipoOrden_SelectedIndexChanged" AutoPostBack="true">
                        </telerik:RadDropDownList>
                        <div id="Boton" style="padding-left:10px">
                        <telerik:RadButton ID="GenerarReporte" runat="server" OnClick="GenerarReporte_Click" Text="GENERAR" Skin="MetroTouch" Visible="false"></telerik:RadButton>
                        </div>
                    </div>
                    <div id="rwReportes" runat="server" style="width:70%;margin:0 auto;">
                        <telerik:ReportViewer ID="ReportViewer1" runat="server" Width="100%" Height="1000px"></telerik:ReportViewer>
                    </div>
                </div>
            </div>
        </div>
    </article>
</asp:Content>