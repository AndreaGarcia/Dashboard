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

                    <telerik:RadGrid ID="rgEstadoCuenta" runat="server" AllowSorting="false" Skin="Metro" AutoGenerateColumns="false">
                        <MasterTableView AutoGenerateColumns="false" DataKeyNames="Orden, Fideicomiso" ClientDataKeyNames="Orden, Fideicomiso" PageSize="30" CommandItemDisplay="None">
                        <Columns>
                         <telerik:GridBoundColumn DataField="Fecha" DataType="System.Int32" FilterControlAltText="Fecha" HeaderText="Fecha" SortExpression="Fecha" UniqueName="Fecha" Visible="True">
                                    <ItemStyle Width="50px" />
                          </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="Concepto" DefaultInsertValue="N/A" DataType="System.String" FilterControlAltText="Concepto" HeaderText="Concepto" SortExpression="Concepto" UniqueName="Concepto" Visible="True">
                                    <ItemStyle Width="50px" />
                          </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="Empresa" DataType="System.String" FilterControlAltText="Empresa" HeaderText="Empresa" SortExpression="Empresa" UniqueName="Empresa" Visible="True">
                                    <ItemStyle Width="50px" />
                          </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="ImporteEntrada" DefaultInsertValue="0.00" DataType="System.Decimal" FilterControlAltText="ImporteEntrada" HeaderText="Importe Entrada" SortExpression="ImporteEntrada" UniqueName="ImporteEntrada" Visible="True">
                                    <ItemStyle Width="50px" />
                          </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="ImporteSalida" DefaultInsertValue="0.00" DataType="System.Decimal" FilterControlAltText="ImporteSalida" HeaderText="Importe Salida" SortExpression="ImporteSalida" UniqueName="ImporteSalida" Visible="True">
                                    <ItemStyle Width="50px" />
                          </telerik:GridBoundColumn>
                         </Columns>
                            </MasterTableView>
                    </telerik:RadGrid>
                    <div id="lblFooter" style="float:right;padding-top:10px;font-size:large">
                    <asp:Label ID="SumatoriaEntrada" runat="server">Total de entrada:</asp:Label><br />
                    <asp:Label ID="SumatoriaSalida" runat="server">Total de salida:</asp:Label><br />
                    <asp:Label ID="Residuo" runat="server">Residuo:</asp:Label>
                    </div>
                </div>
            </div>
        </div>
    </article>
</asp:Content>