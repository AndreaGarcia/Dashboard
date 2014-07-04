<%@ Page Language="C#" MasterPageFile="~/MasterPage/MasterPage.master" AutoEventWireup="true" CodeFile="GraficasOrdenesEntrada.aspx.cs" Inherits="Graficas_GraficasOrdenesEntrada" %>

<asp:Content ID="Content2" ContentPlaceHolderID="cpContenido" runat="Server">
<script src="http://code.highcharts.com/modules/exporting.js"></script>

    <article class="art-post art-article">
        <div class="art-postcontent art-postcontent-0 clearfix">
            <div class="art-content-layout">
                <div class="art-content-layout-row">
                    <h3>GRÁFICAS</h3>
                    <div class="filtradoChart1" style="padding-top:50px">
                        <label>FECHA INICIAL:</label>
                        <telerik:RadDatePicker ID="fechaInicialChart1" runat="server" Skin="MetroTouch" AutoPostBack="false">
                            <DateInput runat="server" DateFormat="MM/dd/yyyy"></DateInput> 
                        </telerik:RadDatePicker>
                        <label>FECHA FINAL:</label>
                        <telerik:RadDatePicker ID="fechaFinalChart1" runat="server" Skin="MetroTouch">
                            <DateInput runat="server" DateFormat="MM/dd/yyyy"></DateInput> 
                        </telerik:RadDatePicker>
                        <button id="filtrarChart1" class="RadButton RadButton_MetroTouch rbSkinnedButton">FILTRAR</button>
                    </div><br />


                    <div id="ltrChart" runat="server"></div>
                    <br /><br />

                     <div class="filtradoChart2" style="padding-top:50px">
                        <label>FECHA INICIAL:</label>
                        <telerik:RadDatePicker ID="fechaInicialChart2" runat="server" Skin="MetroTouch" AutoPostBack="false">
                            <DateInput runat="server" DateFormat="MM/dd/yyyy"></DateInput> 
                        </telerik:RadDatePicker>
                        <label>FECHA FINAL:</label>
                        <telerik:RadDatePicker ID="fechaFinalChart2" runat="server" Skin="MetroTouch">
                            <DateInput runat="server" DateFormat="MM/dd/yyyy"></DateInput> 
                        </telerik:RadDatePicker>
                        <button id="filtrarChart2" class="RadButton RadButton_MetroTouch rbSkinnedButton">FILTRAR</button>
                    </div><br />
                    <div id="ltrChart2" runat="server"></div>
                    <br /><br />

                     <div class="filtradoChart3" style="padding-top:50px">
                        <label>FECHA INICIAL:</label>
                        <telerik:RadDatePicker ID="fechaInicialChart3" runat="server" Skin="MetroTouch" AutoPostBack="false">
                            <DateInput runat="server" DateFormat="MM/dd/yyyy"></DateInput> 
                        </telerik:RadDatePicker>
                        <label>FECHA FINAL:</label>
                        <telerik:RadDatePicker ID="fechaFinalChart3" runat="server" Skin="MetroTouch">
                            <DateInput runat="server" DateFormat="MM/dd/yyyy"></DateInput> 
                        </telerik:RadDatePicker>
                        <button id="filtrarChart3" class="RadButton RadButton_MetroTouch rbSkinnedButton">FILTRAR</button>
                    </div><br />
                    <div id="ltrChart3" runat="server"></div>

                </div>
            </div>
        </div>
    </article>
    <script type="text/javascript">
        $(function () {

            $('#filtrarChart1').click(function (e) {
                e.preventDefault();
                var index = $("#chart_container").data('highcharts-chart');
                var myChart = Highcharts.charts[index];
                var xAxis = myChart.xAxis[0]

                xAxis.options.startOnTick = true;
                xAxis.options.endOnTick = true;

                var pickerInicio = $find('<%= fechaInicialChart1.ClientID %>');
        var selectedDate = pickerInicio.get_selectedDate().format("dd/MM/yyyy").split("/");

        var fechaFin = $find("<%=fechaFinalChart1.ClientID %>");
        var selectedDate2 = fechaFin.get_selectedDate().format("dd/MM/yyyy").split("/");

        myChart.xAxis[0].setExtremes(Date.UTC(parseInt(selectedDate[2]), parseInt(selectedDate[1]) - 1, parseInt(selectedDate[0])),
            Date.UTC(parseInt(selectedDate2[2]), parseInt(selectedDate2[1]) - 1, parseInt(selectedDate2[0])));
    });

    $('#filtrarChart2').click(function (e) {
        e.preventDefault();
        var index = $("#chartFideicomiso_container").data('highcharts-chart');
        var myChart = Highcharts.charts[index];
        var xAxis = myChart.xAxis[0]

        xAxis.options.startOnTick = true;
        xAxis.options.endOnTick = true;

        var pickerInicio = $find('<%= fechaInicialChart2.ClientID %>');
        var selectedDate = pickerInicio.get_selectedDate().format("dd/MM/yyyy").split("/");

        var fechaFin = $find("<%=fechaFinalChart2.ClientID %>");
        var selectedDate2 = fechaFin.get_selectedDate().format("dd/MM/yyyy").split("/");

        myChart.xAxis[0].setExtremes(Date.UTC(parseInt(selectedDate[2]), parseInt(selectedDate[1]) - 1, parseInt(selectedDate[0])),
            Date.UTC(parseInt(selectedDate2[2]), parseInt(selectedDate2[1]) - 1, parseInt(selectedDate2[0])));
    });

    $('#filtrarChart3').click(function (e) {
        e.preventDefault();
        var index = $("#chartEmpresa_container").data('highcharts-chart');
        var myChart = Highcharts.charts[index];
        var xAxis = myChart.xAxis[0]

        xAxis.options.startOnTick = true;
        xAxis.options.endOnTick = true;

        var pickerInicio = $find('<%= fechaInicialChart3.ClientID %>');
        var selectedDate = pickerInicio.get_selectedDate().format("dd/MM/yyyy").split("/");

        var fechaFin = $find("<%=fechaFinalChart3.ClientID %>");
        var selectedDate2 = fechaFin.get_selectedDate().format("dd/MM/yyyy").split("/");

        myChart.xAxis[0].setExtremes(Date.UTC(parseInt(selectedDate[2]), parseInt(selectedDate[1]) - 1, parseInt(selectedDate[0])),
            Date.UTC(parseInt(selectedDate2[2]), parseInt(selectedDate2[1]) - 1, parseInt(selectedDate2[0])));
    });

});
</script>
</asp:Content>