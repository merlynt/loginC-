<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PanelPrincipal.aspx.cs" Inherits="presentacion.PanelPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Bienvenidos al panel principal</h2>
            <asp:Label ID="bienvenidoLabel" runat="server" Text="Label"></asp:Label>
            <asp:Button ID="cerrarSessionButton" runat="server" Text="Button" OnClick="btnCerrarSesion_Click" />
        </div>
    </form>
</body>
</html>
