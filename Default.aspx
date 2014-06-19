<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>
<html dir="ltr" lang="en-US">
<head id="Head1" runat="server">
    <meta charset="utf-8" />
    <title>.:: SICMST ::.</title>
    <link rel="shortcut icon" href="/SICMST/Images/favicon.ico" type="image/x-icon" />
    <meta name="viewport" content="initial-scale = 1.0, maximum-scale = 1.0, user-scalable = no, width = device-width, height = device-height" />
    <!--[if lt IE 9]><script src="http://html5shiv.googlecode.com/svn/trunk/html5.js"></script><![endif]-->
    <!--[if lte IE 6]><script type="text/javascript" src="/SICMST/Includes/pngfix/supersleight-min.js"></script><![endif]-->
    <link href="/SICMST/CSS/Login.css" rel="stylesheet" type="text/css" />
    <script src="/Scripts/jquery-1.8.2.min.js"></script>

</head>
<body>
    <form id="Form1" runat="server">
        <telerik:RadScriptManager ID="ScriptManager1" runat="server" EnableTheming="True">
            <Scripts>
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.Core.js" />
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQuery.js" />
                <asp:ScriptReference Assembly="Telerik.Web.UI" Name="Telerik.Web.UI.Common.jQueryInclude.js" />
            </Scripts>
        </telerik:RadScriptManager>
        <table id="login" border="0" cellpadding="1" cellspacing="1">
            <tr>
                <td>
                    <asp:Image ID="iLogo" AlternateText="SICMST" ImageUrl="Images/nuevo_sonora_logo.png" runat="server" Style="margin-left: auto; margin-right: auto; float: right" Height="132px" Width="144px" />
                    <h2 style="color: #FE9304">Sistema Integral de Control y Monitoreo del Sistema de Transporte</h2>
                    <fieldset id="inputs">
                        <legend></legend>
                        <asp:TextBox ID="txtUsuario" runat="server" placeholder="USUARIO" autofocus required Width="343px" Style="text-transform: uppercase"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="*" ControlToValidate="txtUsuario"></asp:RequiredFieldValidator>
                        <asp:TextBox ID="txtContrasena" runat="server" TextMode="Password" placeholder="CONTRASEÑA" required Width="343px"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="*" ControlToValidate="txtContrasena"></asp:RequiredFieldValidator>
                    </fieldset>
                    <fieldset id="actions">
                        <legend></legend>
                        <asp:Button ID="btnAcceso" runat="server" Text="ACCESO" OnClick="btnAcceso_Click" />
                    </fieldset>
                </td>
            </tr>
            <tr>
                <td>
                    <br />
                    <br />
                    <a href="javascript:RecuperarContrasena();" id="Recuperar">Recuperar Contraseña</a>
                    <p style="text-align: center;">Derechos Reservados ® 2014.<br /> <a href="#">Centro de Control de Servicios Públicos</a>.</p>
                </td>
            </tr>
        </table>
        <telerik:RadCodeBlock ID="RadCodeBlock1" runat="server">
            <script type="text/javascript">

                function rwRecuperarContrasena_Close(sender, args) {
                    window.location.reload();
                }

                function RecuperarContrasena() {
                    var oWnd = $find("<%= rwRecuperarContrasena.ClientID %>");
                    oWnd.setUrl("RecuperarContrasena.aspx");
                    oWnd.add_close(rwRecuperarContrasena_Close);
                    oWnd.show();
                }

                function testNotifications() {
                    //nos devuelve true si podemos usar notificaciones
                    if (window.webkitNotifications || window.notifications || Notification)
                        return true;
                    return false;
                }

                function checkPermission() {
                    if (window.webkitNotifications && window.webkitNotifications.checkPermission() == 0) {
                        return true;
                    } else if (Notification && Notification.permission == 'granted') {
                        return true;
                    }
                    return false;
                }

                function requestPermission() {
                    //pedimos permiso para mostrar notificaciones 184.168.27.39
                    if (window.webkitNotifications && window.webkitNotifications.checkPermission() != 0) {//Chrome
                        window.webkitNotifications.requestPermission();
                    } else if (Notification && Notification.permission != 'granted') {//Firefox
                        Notification.requestPermission();
                    }
                }

                function newNotification(title, content, img_uri) {
                    if (window.webkitNotifications && checkPermission()) {
                        var notification = window.webkitNotifications.createNotification(
                            img_uri,
                            title,
                            content
                        );
                        return notification;
                    } else if (Notification && checkPermission()) {
                        return {
                            show: function () {
                                new Notification(title,
                                {
                                    body: content,
                                    iconUrl: img_uri
                                });
                            }
                        }
                    }
                }

            </script>
        </telerik:RadCodeBlock>
        <telerik:RadAjaxManager ID="RadAjaxManager1" runat="server">
        </telerik:RadAjaxManager>
        <telerik:RadWindowManager ID="RadWindowManager1" runat="server">
            <Windows>
                <telerik:RadWindow ID="rwRecuperarContrasena" runat="server" Behaviors="Close" ReloadOnShow="true"
                    Width="500px" Height="240px" EnableShadow="true" Modal="true" OnClientClose="rwRecuperarContrasena_Close" VisibleStatusbar="false">
                </telerik:RadWindow>
            </Windows>
        </telerik:RadWindowManager>
    </form>
</body>
</html>