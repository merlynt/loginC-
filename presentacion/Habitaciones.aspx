<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Habitaciones.aspx.cs" Inherits="presentacion.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="bienvenidoLabel" runat="server" Text="Label"></asp:Label>
            <asp:GridView ID="dvgHabitaciones" runat="server" AutoGenerateColumns ="false">
                <Columns>
                    <asp:BoundField DataField="id_habitaciones" HeaderText="ID" />
                    <asp:BoundField DataField="numero" HeaderText="#" />
                    <asp:BoundField DataField="descripcion" HeaderText="Descripcion" />
                    <asp:BoundField DataField="cant_huespedes" HeaderText="Max-Personas" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
