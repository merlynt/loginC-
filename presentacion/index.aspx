<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="presentacion.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>Bienvenidos</h2>
            <h3>Inicio de sesion</h3>
            <asp:Label ID="usuarioLabel" runat="server" Text="Label">Usuario</asp:Label>
            <br />
            <asp:TextBox ID="usuarioTextBox" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="contrasenaLabel" runat="server" Text="Label">Contraseña</asp:Label>
            <br />
            <asp:TextBox ID="contrasenaTextBox" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnIniciar" runat="server" Text="Iniciar Sesión" OnClick="btnIniciar_Click" />
            
            <br />
            <br />
            <asp:Label ID="lblMensaje" runat="server" ForeColor="Red"></asp:Label>
            <br />
            <asp:LinkButton ID="lnkOlvide" runat="server">Olvidé mi contraseña</asp:LinkButton>
        </div>
    </form>
</body>
</html>
