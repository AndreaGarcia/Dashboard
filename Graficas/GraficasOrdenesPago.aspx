<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="GraficasOrdenesPago.aspx.cs" Inherits="Graficos_GraficasOrdenesPago" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cpContenido" runat="Server">
    <article class="art-post art-article">
        <div class="art-postcontent art-postcontent-0 clearfix">
            <div class="art-content-layout">
                <div class="art-content-layout-row">
                    <h3>GRÁFICAS</h3>
                    <asp:Literal ID="ltrChart" runat="server"></asp:Literal>
                </div>
            </div>
        </div>
    </article>
</asp:Content>
