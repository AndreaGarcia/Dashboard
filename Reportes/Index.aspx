<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Reportes_Index" %>

<%@ Register Assembly="Telerik.ReportViewer.WebForms, Version=8.0.14.225, Culture=neutral, PublicKeyToken=a9d7983dfcc261be" Namespace="Telerik.ReportViewer.WebForms" TagPrefix="telerik" %>

<%@ Register Assembly="Microsoft.ReportViewer.WebForms, Version=11.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" Namespace="Microsoft.Reporting.WebForms" TagPrefix="rsweb" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cpContenido" runat="Server">
    <article class="art-post art-article">
        <div class="art-postcontent art-postcontent-0 clearfix">
            <div class="art-content-layout">
                <div class="art-content-layout-row">
                    <h3>REPORTES</h3>
                    <div id="FiltradoReporte" style="padding-top:30px;padding-bottom:50px;display:flex">
                        <telerik:RadDropDownList ID="TipoReporte" runat="server" Skin="MetroTouch" DefaultMessage="Seleccione el tipo..." Width="200px" DropDownWidth="200px" OnSelectedIndexChanged="TipoReporte_SelectedIndexChanged" AutoPostBack="true">
                            <Items>
                                <telerik:DropDownListItem Text="Orden de pago" Value="1" runat="server"/>
                                <telerik:DropDownListItem Text="Orden de entrada" Value="2" runat="server" />
                                <telerik:DropDownListItem Text="Estado de cuenta" Value="3" runat="server" />
                            </Items>
                        </telerik:RadDropDownList>

                        <telerik:RadDropDownList ID="TipoOrden" runat="server" Skin="MetroTouch" DefaultMessage="Seleccione el reporte..." Width="300px" DropDownWidth="300px" Visible="false" style="padding-left:10px" OnSelectedIndexChanged="TipoOrden_SelectedIndexChanged" AutoPostBack="true">
                        </telerik:RadDropDownList>

                        <telerik:RadDropDownList ID="RadDropDownFideicomisos" runat="server" Skin="MetroTouch" DefaultMessage="Seleccione el Fideicomiso..." Width="250px" DropDownWidth="250px" Visible="false" style="padding-left:10px;padding-right:10px" AutoPostBack="true">
                        </telerik:RadDropDownList>

                         <asp:Label ID="lblInicio" runat="server" Visible="false">FECHA INICIAL:</asp:Label>
                        <telerik:RadDatePicker ID="fechaInicial" runat="server" Skin="MetroTouch" Visible="false" Width="150px">
                            <DateInput runat="server" DateFormat="MM/dd/yyyy"></DateInput> 
                        </telerik:RadDatePicker>
                        <asp:Label ID="lblFin" runat="server" Visible="false">FECHA FINAL:</asp:Label>
                        <telerik:RadDatePicker ID="fechaFinal" runat="server" Skin="MetroTouch" Visible="false" Width="150px">
                            <DateInput runat="server" DateFormat="MM/dd/yyyy"></DateInput> 
                        </telerik:RadDatePicker>

                        <div id="Boton" style="padding-left:10px">
                        <telerik:RadButton ID="GenerarReporte" runat="server" OnClick="GenerarReporte_Click" Text="GENERAR" Skin="MetroTouch" Visible="false"></telerik:RadButton>
                        </div>
                    </div>
                    <div id="rwReportes" runat="server" style="width:70%;margin:0 auto;">
                        <telerik:ReportViewer ID="ReportViewer1" runat="server" Width="100%" Height="1000px"></telerik:ReportViewer>
                    </div>

    <telerik:RadGrid ID="rgEstadoCuenta" runat="server" AllowSorting="false" Skin="Metro" AutoGenerateColumns="true" OnNeedDataSource="">

    </telerik:RadGrid>
    <telerik:RadGrid ID="rgOrdenesAceptadas" runat="server" AllowSorting="true" CellSpacing="0" GridLines="None" Skin="Metro"
        AllowAutomaticDeletes="false" AllowAutomaticInserts="false" AllowAutomaticUpdates="false" AllowPaging="true" PageSize="30">
        <MasterTableView AutoGenerateColumns="false" DataKeyNames="IdOrdenPago, IdEmpresa" ClientDataKeyNames="IdOrdenPago, IdEmpresa" PageSize="30" CommandItemDisplay="None">
              <Columns>
                <telerik:GridBoundColumn DataField="IdOrdenPago" DataType="System.Int32" FilterControlAltText="IdOrdenPago" HeaderText="IdOrdenPago" SortExpression="IdOrdenPago" UniqueName="IdOrdenPago" Visible="false">
                    <ItemStyle Width="50px" />
                </telerik:GridBoundColumn>
                 <telerik:GridBoundColumn DataField="IdEmpresa" DataType="System.Int32" HeaderText="IdEmpresa" SortExpression="IdEmpresa" UniqueName="IdEmpresa" Visible="false">
                    <ItemStyle Width="80px" />
                </telerik:GridBoundColumn>
                   <telerik:GridBoundColumn DataField="Ciudad" DataType="System.Int32" HeaderText="Ciudad" SortExpression="Ciudad" UniqueName="Ciudad">
                    <ItemStyle Width="150px" />
                </telerik:GridBoundColumn>
                 <telerik:GridBoundColumn DataField="Fideicomiso" DataType="System.Int32" HeaderText="Fideicomiso" SortExpression="Fideicomiso" UniqueName="Fideicomiso">
                    <ItemStyle Width="150px" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="NombreEmpresa" DataType="System.Int32" HeaderText="Empresa" SortExpression="NombreEmpresa" UniqueName="NombreEmpresa">
                    <ItemStyle Width="200px" />
                </telerik:GridBoundColumn>
                  <telerik:GridBoundColumn DataField="NombreEstatus" DataType="System.Int32" HeaderText="Estatus" SortExpression="NombreEstatus" UniqueName="NombreEstatus">
                    <ItemStyle Width="80px" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="ImporteOrden" HeaderText="Importe" SortExpression="ImporteOrden" UniqueName="ImporteOrden" DataFormatString="{0:C2}">
                    <ItemStyle Width="80px" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="FechaInicio" HeaderText="Fecha inicio" SortExpression="FechaInicio" UniqueName="FechaInicio" DataFormatString="{0:d/M/yyyy}">
                    <ItemStyle Width="100px" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="FechaFin" HeaderText="Fecha final" SortExpression="FechaFin" UniqueName="FechaFin" DataFormatString="{0:d/M/yyyy}">
                    <ItemStyle Width="100px" />
                </telerik:GridBoundColumn>
                <telerik:GridBoundColumn DataField="FechaEmision" HeaderText="Fecha de emision" SortExpression="FechaEmision" UniqueName="FechaEmision">
                    <ItemStyle Width="150px" />
                </telerik:GridBoundColumn>
                   <telerik:GridBoundColumn DataField="FechaAprobacion" HeaderText="Fecha de aprobacion" SortExpression="FechaAprobacion" UniqueName="FechaAprobacion">
                    <ItemStyle Width="150px" />
                </telerik:GridBoundColumn>
                   <telerik:GridBoundColumn DataField="NombreUsuario" HeaderText="Usuario que aprobo" SortExpression="NombreUsuario" UniqueName="NombreUsuario">
                    <ItemStyle Width="100px" />
                </telerik:GridBoundColumn>
            </Columns>
            <PagerStyle Position="TopAndBottom" />
            <NoRecordsTemplate>
                <center><strong><span style="color: #ff0000">No hay ordenes aceptadas</span></strong></center>
            </NoRecordsTemplate>
            <CommandItemStyle Wrap="true" HorizontalAlign="Left" Width="100%" VerticalAlign="Middle" Height="30px" />
            <HeaderStyle Font-Bold="true" HorizontalAlign="Center" Wrap="true" />

            <PagerStyle FirstPageToolTip="Primera Pagina" LastPageToolTip="Ultima Pagina" NextPagesToolTip="Siguiente Pagina"
                NextPageToolTip="Siguiente Pagina" PageButtonCount="20" PagerTextFormat="Pagina: {4} &amp;nbsp;Pagina &lt;strong&gt;{0}&lt;/strong&gt; 
                                de &lt;strong&gt;{1}&lt;/strong&gt;, Cobro &lt;strong&gt;{2}&lt;/strong&gt; de &lt;strong&gt;{3}&lt;/strong&gt; de &lt;strong&gt;{5}&lt;/strong&gt;."
                PageSizeLabelText="Cobros:" PrevPagesToolTip="Anterior Pagina" PrevPageToolTip="Siguiente Pagina"
                AlwaysVisible="true" />
        </MasterTableView>
        <ClientSettings>
            <Selecting AllowRowSelect="true" />
            <ClientEvents OnRowDblClick="rgOrdenesAceptadas_OnRowDblClick" />
        </ClientSettings>
    </telerik:RadGrid>
                </div>
            </div>
        </div>
    </article>
</asp:Content>