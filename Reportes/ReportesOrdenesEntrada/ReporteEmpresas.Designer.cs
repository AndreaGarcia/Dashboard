namespace Reportes.ReportesOrdenesEntrada
{
    partial class ReporteEmpresas
    {
        #region Component Designer generated code
        /// <summary>
        /// Required method for telerik Reporting designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReporteEmpresas));
            Telerik.Reporting.Group group1 = new Telerik.Reporting.Group();
            Telerik.Reporting.Group group2 = new Telerik.Reporting.Group();
            Telerik.Reporting.Drawing.StyleRule styleRule1 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule2 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule3 = new Telerik.Reporting.Drawing.StyleRule();
            Telerik.Reporting.Drawing.StyleRule styleRule4 = new Telerik.Reporting.Drawing.StyleRule();
            this.dsOrdenEntradaEmpresas = new Telerik.Reporting.SqlDataSource();
            this.nombreEmpresaGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.nombreEmpresaGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.nombreEmpresaCaptionTextBox = new Telerik.Reporting.TextBox();
            this.nombreEmpresaDataTextBox = new Telerik.Reporting.TextBox();
            this.labelsGroupHeaderSection = new Telerik.Reporting.GroupHeaderSection();
            this.labelsGroupFooterSection = new Telerik.Reporting.GroupFooterSection();
            this.idOrdenCaptionTextBox = new Telerik.Reporting.TextBox();
            this.nombreFideicomisoCaptionTextBox = new Telerik.Reporting.TextBox();
            this.tipoOrdenCaptionTextBox = new Telerik.Reporting.TextBox();
            this.estatusOrdenCaptionTextBox = new Telerik.Reporting.TextBox();
            this.importeOrdenCaptionTextBox = new Telerik.Reporting.TextBox();
            this.fechaCaptionTextBox = new Telerik.Reporting.TextBox();
            this.pageHeader = new Telerik.Reporting.PageHeaderSection();
            this.reportNameTextBox = new Telerik.Reporting.TextBox();
            this.pageFooter = new Telerik.Reporting.PageFooterSection();
            this.currentTimeTextBox = new Telerik.Reporting.TextBox();
            this.pageInfoTextBox = new Telerik.Reporting.TextBox();
            this.reportHeader = new Telerik.Reporting.ReportHeaderSection();
            this.titleTextBox = new Telerik.Reporting.TextBox();
            this.reportFooter = new Telerik.Reporting.ReportFooterSection();
            this.detail = new Telerik.Reporting.DetailSection();
            this.idOrdenDataTextBox = new Telerik.Reporting.TextBox();
            this.nombreFideicomisoDataTextBox = new Telerik.Reporting.TextBox();
            this.tipoOrdenDataTextBox = new Telerik.Reporting.TextBox();
            this.estatusOrdenDataTextBox = new Telerik.Reporting.TextBox();
            this.importeOrdenDataTextBox = new Telerik.Reporting.TextBox();
            this.fechaDataTextBox = new Telerik.Reporting.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // dsOrdenEntradaEmpresas
            // 
            this.dsOrdenEntradaEmpresas.ConnectionString = "Reportes.Properties.Settings.SICMST2";
            this.dsOrdenEntradaEmpresas.Name = "dsOrdenEntradaEmpresas";
            this.dsOrdenEntradaEmpresas.SelectCommand = resources.GetString("dsOrdenEntradaEmpresas.SelectCommand");
            // 
            // nombreEmpresaGroupHeaderSection
            // 
            this.nombreEmpresaGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567D);
            this.nombreEmpresaGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.nombreEmpresaCaptionTextBox,
            this.nombreEmpresaDataTextBox});
            this.nombreEmpresaGroupHeaderSection.Name = "nombreEmpresaGroupHeaderSection";
            // 
            // nombreEmpresaGroupFooterSection
            // 
            this.nombreEmpresaGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155D);
            this.nombreEmpresaGroupFooterSection.Name = "nombreEmpresaGroupFooterSection";
            // 
            // nombreEmpresaCaptionTextBox
            // 
            this.nombreEmpresaCaptionTextBox.CanGrow = true;
            this.nombreEmpresaCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.nombreEmpresaCaptionTextBox.Name = "nombreEmpresaCaptionTextBox";
            this.nombreEmpresaCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(3D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.nombreEmpresaCaptionTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.nombreEmpresaCaptionTextBox.StyleName = "Caption";
            this.nombreEmpresaCaptionTextBox.Value = "Nombre Empresa:";
            // 
            // nombreEmpresaDataTextBox
            // 
            this.nombreEmpresaDataTextBox.CanGrow = true;
            this.nombreEmpresaDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.1058332920074463D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.nombreEmpresaDataTextBox.Name = "nombreEmpresaDataTextBox";
            this.nombreEmpresaDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(12.602499961853027D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.nombreEmpresaDataTextBox.StyleName = "Data";
            this.nombreEmpresaDataTextBox.Value = "=Fields.NombreEmpresa";
            // 
            // labelsGroupHeaderSection
            // 
            this.labelsGroupHeaderSection.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567D);
            this.labelsGroupHeaderSection.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.idOrdenCaptionTextBox,
            this.nombreFideicomisoCaptionTextBox,
            this.tipoOrdenCaptionTextBox,
            this.estatusOrdenCaptionTextBox,
            this.importeOrdenCaptionTextBox,
            this.fechaCaptionTextBox});
            this.labelsGroupHeaderSection.Name = "labelsGroupHeaderSection";
            this.labelsGroupHeaderSection.PrintOnEveryPage = true;
            // 
            // labelsGroupFooterSection
            // 
            this.labelsGroupFooterSection.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155D);
            this.labelsGroupFooterSection.Name = "labelsGroupFooterSection";
            this.labelsGroupFooterSection.Style.Visible = false;
            // 
            // idOrdenCaptionTextBox
            // 
            this.idOrdenCaptionTextBox.CanGrow = true;
            this.idOrdenCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.0529166460037231D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.idOrdenCaptionTextBox.Name = "idOrdenCaptionTextBox";
            this.idOrdenCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4072916507720947D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.idOrdenCaptionTextBox.StyleName = "Caption";
            this.idOrdenCaptionTextBox.Value = "Id Orden";
            // 
            // nombreFideicomisoCaptionTextBox
            // 
            this.nombreFideicomisoCaptionTextBox.CanGrow = true;
            this.nombreFideicomisoCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.513124942779541D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.nombreFideicomisoCaptionTextBox.Name = "nombreFideicomisoCaptionTextBox";
            this.nombreFideicomisoCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4072916507720947D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.nombreFideicomisoCaptionTextBox.StyleName = "Caption";
            this.nombreFideicomisoCaptionTextBox.Value = "Nombre Fideicomiso";
            // 
            // tipoOrdenCaptionTextBox
            // 
            this.tipoOrdenCaptionTextBox.CanGrow = true;
            this.tipoOrdenCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.9733333587646484D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.tipoOrdenCaptionTextBox.Name = "tipoOrdenCaptionTextBox";
            this.tipoOrdenCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4072916507720947D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.tipoOrdenCaptionTextBox.StyleName = "Caption";
            this.tipoOrdenCaptionTextBox.Value = "Tipo Orden";
            // 
            // estatusOrdenCaptionTextBox
            // 
            this.estatusOrdenCaptionTextBox.CanGrow = true;
            this.estatusOrdenCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.4335412979125977D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.estatusOrdenCaptionTextBox.Name = "estatusOrdenCaptionTextBox";
            this.estatusOrdenCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4072916507720947D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.estatusOrdenCaptionTextBox.StyleName = "Caption";
            this.estatusOrdenCaptionTextBox.Value = "Estatus Orden";
            // 
            // importeOrdenCaptionTextBox
            // 
            this.importeOrdenCaptionTextBox.CanGrow = true;
            this.importeOrdenCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.893750190734863D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.importeOrdenCaptionTextBox.Name = "importeOrdenCaptionTextBox";
            this.importeOrdenCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4072916507720947D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.importeOrdenCaptionTextBox.StyleName = "Caption";
            this.importeOrdenCaptionTextBox.Value = "Importe Orden";
            // 
            // fechaCaptionTextBox
            // 
            this.fechaCaptionTextBox.CanGrow = true;
            this.fechaCaptionTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.353958129882813D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.fechaCaptionTextBox.Name = "fechaCaptionTextBox";
            this.fechaCaptionTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4072916507720947D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.fechaCaptionTextBox.StyleName = "Caption";
            this.fechaCaptionTextBox.Value = "Fecha";
            // 
            // pageHeader
            // 
            this.pageHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567D);
            this.pageHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.reportNameTextBox});
            this.pageHeader.Name = "pageHeader";
            // 
            // reportNameTextBox
            // 
            this.reportNameTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.reportNameTextBox.Name = "reportNameTextBox";
            this.reportNameTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.708333015441895D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.reportNameTextBox.StyleName = "PageInfo";
            this.reportNameTextBox.Value = "ReporteEmpresas";
            // 
            // pageFooter
            // 
            this.pageFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567D);
            this.pageFooter.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.currentTimeTextBox,
            this.pageInfoTextBox});
            this.pageFooter.Name = "pageFooter";
            // 
            // currentTimeTextBox
            // 
            this.currentTimeTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.currentTimeTextBox.Name = "currentTimeTextBox";
            this.currentTimeTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.8277082443237305D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.currentTimeTextBox.StyleName = "PageInfo";
            this.currentTimeTextBox.Value = "=NOW()";
            // 
            // pageInfoTextBox
            // 
            this.pageInfoTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(7.9335417747497559D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.pageInfoTextBox.Name = "pageInfoTextBox";
            this.pageInfoTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(7.8277082443237305D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.pageInfoTextBox.Style.TextAlign = Telerik.Reporting.Drawing.HorizontalAlign.Right;
            this.pageInfoTextBox.StyleName = "PageInfo";
            this.pageInfoTextBox.Value = "=PageNumber";
            // 
            // reportHeader
            // 
            this.reportHeader.Height = Telerik.Reporting.Drawing.Unit.Cm(2.0529167652130127D);
            this.reportHeader.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.titleTextBox});
            this.reportHeader.Name = "reportHeader";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(0D), Telerik.Reporting.Drawing.Unit.Cm(0D));
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(15.814167022705078D), Telerik.Reporting.Drawing.Unit.Cm(2D));
            this.titleTextBox.StyleName = "Title";
            this.titleTextBox.Value = "ReporteEmpresas";
            // 
            // reportFooter
            // 
            this.reportFooter.Height = Telerik.Reporting.Drawing.Unit.Cm(0.71437495946884155D);
            this.reportFooter.Name = "reportFooter";
            // 
            // detail
            // 
            this.detail.Height = Telerik.Reporting.Drawing.Unit.Cm(1.1058331727981567D);
            this.detail.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.idOrdenDataTextBox,
            this.nombreFideicomisoDataTextBox,
            this.tipoOrdenDataTextBox,
            this.estatusOrdenDataTextBox,
            this.importeOrdenDataTextBox,
            this.fechaDataTextBox});
            this.detail.Name = "detail";
            // 
            // idOrdenDataTextBox
            // 
            this.idOrdenDataTextBox.CanGrow = true;
            this.idOrdenDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(1.0529166460037231D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.idOrdenDataTextBox.Name = "idOrdenDataTextBox";
            this.idOrdenDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4072916507720947D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.idOrdenDataTextBox.StyleName = "Data";
            this.idOrdenDataTextBox.Value = "=Fields.IdOrden";
            // 
            // nombreFideicomisoDataTextBox
            // 
            this.nombreFideicomisoDataTextBox.CanGrow = true;
            this.nombreFideicomisoDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(3.513124942779541D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.nombreFideicomisoDataTextBox.Name = "nombreFideicomisoDataTextBox";
            this.nombreFideicomisoDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4072916507720947D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.nombreFideicomisoDataTextBox.StyleName = "Data";
            this.nombreFideicomisoDataTextBox.Value = "=Fields.NombreFideicomiso";
            // 
            // tipoOrdenDataTextBox
            // 
            this.tipoOrdenDataTextBox.CanGrow = true;
            this.tipoOrdenDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(5.9733333587646484D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.tipoOrdenDataTextBox.Name = "tipoOrdenDataTextBox";
            this.tipoOrdenDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4072916507720947D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.tipoOrdenDataTextBox.StyleName = "Data";
            this.tipoOrdenDataTextBox.Value = "=Fields.TipoOrden";
            // 
            // estatusOrdenDataTextBox
            // 
            this.estatusOrdenDataTextBox.CanGrow = true;
            this.estatusOrdenDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(8.4335412979125977D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.estatusOrdenDataTextBox.Name = "estatusOrdenDataTextBox";
            this.estatusOrdenDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4072916507720947D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.estatusOrdenDataTextBox.StyleName = "Data";
            this.estatusOrdenDataTextBox.Value = "=Fields.EstatusOrden";
            // 
            // importeOrdenDataTextBox
            // 
            this.importeOrdenDataTextBox.CanGrow = true;
            this.importeOrdenDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(10.893750190734863D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.importeOrdenDataTextBox.Name = "importeOrdenDataTextBox";
            this.importeOrdenDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4072916507720947D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.importeOrdenDataTextBox.StyleName = "Data";
            this.importeOrdenDataTextBox.Value = "=Fields.ImporteOrden";
            // 
            // fechaDataTextBox
            // 
            this.fechaDataTextBox.CanGrow = true;
            this.fechaDataTextBox.Location = new Telerik.Reporting.Drawing.PointU(Telerik.Reporting.Drawing.Unit.Cm(13.353958129882813D), Telerik.Reporting.Drawing.Unit.Cm(0.052916664630174637D));
            this.fechaDataTextBox.Name = "fechaDataTextBox";
            this.fechaDataTextBox.Size = new Telerik.Reporting.Drawing.SizeU(Telerik.Reporting.Drawing.Unit.Cm(2.4072916507720947D), Telerik.Reporting.Drawing.Unit.Cm(0.99999988079071045D));
            this.fechaDataTextBox.StyleName = "Data";
            this.fechaDataTextBox.Value = "=Fields.Fecha";
            // 
            // ReporteEmpresas
            // 
            this.DataSource = this.dsOrdenEntradaEmpresas;
            group1.GroupFooter = this.nombreEmpresaGroupFooterSection;
            group1.GroupHeader = this.nombreEmpresaGroupHeaderSection;
            group1.Groupings.Add(new Telerik.Reporting.Grouping("=Fields.NombreEmpresa"));
            group1.Name = "nombreEmpresaGroup";
            group2.GroupFooter = this.labelsGroupFooterSection;
            group2.GroupHeader = this.labelsGroupHeaderSection;
            group2.Name = "labelsGroup";
            this.Groups.AddRange(new Telerik.Reporting.Group[] {
            group1,
            group2});
            this.Items.AddRange(new Telerik.Reporting.ReportItemBase[] {
            this.nombreEmpresaGroupHeaderSection,
            this.nombreEmpresaGroupFooterSection,
            this.labelsGroupHeaderSection,
            this.labelsGroupFooterSection,
            this.pageHeader,
            this.pageFooter,
            this.reportHeader,
            this.reportFooter,
            this.detail});
            this.Name = "ReporteEmpresas";
            this.PageSettings.Margins = new Telerik.Reporting.Drawing.MarginsU(Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273D), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273D), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273D), Telerik.Reporting.Drawing.Unit.Mm(25.399999618530273D));
            this.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4;
            this.Style.BackgroundColor = System.Drawing.Color.White;
            styleRule1.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Title")});
            styleRule1.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
            styleRule1.Style.Font.Name = "Calibri";
            styleRule1.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(18D);
            styleRule2.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Caption")});
            styleRule2.Style.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(167)))), ((int)(((byte)(227)))));
            styleRule2.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
            styleRule2.Style.Font.Name = "Calibri";
            styleRule2.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(10D);
            styleRule2.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule3.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("Data")});
            styleRule3.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
            styleRule3.Style.Font.Name = "Calibri";
            styleRule3.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(9D);
            styleRule3.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            styleRule4.Selectors.AddRange(new Telerik.Reporting.Drawing.ISelector[] {
            new Telerik.Reporting.Drawing.StyleSelector("PageInfo")});
            styleRule4.Style.Color = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(34)))), ((int)(((byte)(77)))));
            styleRule4.Style.Font.Name = "Calibri";
            styleRule4.Style.Font.Size = Telerik.Reporting.Drawing.Unit.Point(8D);
            styleRule4.Style.VerticalAlign = Telerik.Reporting.Drawing.VerticalAlign.Middle;
            this.StyleSheet.AddRange(new Telerik.Reporting.Drawing.StyleRule[] {
            styleRule1,
            styleRule2,
            styleRule3,
            styleRule4});
            this.Width = Telerik.Reporting.Drawing.Unit.Cm(15.814167022705078D);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
        #endregion

        private Telerik.Reporting.SqlDataSource dsOrdenEntradaEmpresas;
        private Telerik.Reporting.GroupHeaderSection nombreEmpresaGroupHeaderSection;
        private Telerik.Reporting.TextBox nombreEmpresaCaptionTextBox;
        private Telerik.Reporting.TextBox nombreEmpresaDataTextBox;
        private Telerik.Reporting.GroupFooterSection nombreEmpresaGroupFooterSection;
        private Telerik.Reporting.GroupHeaderSection labelsGroupHeaderSection;
        private Telerik.Reporting.TextBox idOrdenCaptionTextBox;
        private Telerik.Reporting.TextBox nombreFideicomisoCaptionTextBox;
        private Telerik.Reporting.TextBox tipoOrdenCaptionTextBox;
        private Telerik.Reporting.TextBox estatusOrdenCaptionTextBox;
        private Telerik.Reporting.TextBox importeOrdenCaptionTextBox;
        private Telerik.Reporting.TextBox fechaCaptionTextBox;
        private Telerik.Reporting.GroupFooterSection labelsGroupFooterSection;
        private Telerik.Reporting.PageHeaderSection pageHeader;
        private Telerik.Reporting.TextBox reportNameTextBox;
        private Telerik.Reporting.PageFooterSection pageFooter;
        private Telerik.Reporting.TextBox currentTimeTextBox;
        private Telerik.Reporting.TextBox pageInfoTextBox;
        private Telerik.Reporting.ReportHeaderSection reportHeader;
        private Telerik.Reporting.TextBox titleTextBox;
        private Telerik.Reporting.ReportFooterSection reportFooter;
        private Telerik.Reporting.DetailSection detail;
        private Telerik.Reporting.TextBox idOrdenDataTextBox;
        private Telerik.Reporting.TextBox nombreFideicomisoDataTextBox;
        private Telerik.Reporting.TextBox tipoOrdenDataTextBox;
        private Telerik.Reporting.TextBox estatusOrdenDataTextBox;
        private Telerik.Reporting.TextBox importeOrdenDataTextBox;
        private Telerik.Reporting.TextBox fechaDataTextBox;

    }
}