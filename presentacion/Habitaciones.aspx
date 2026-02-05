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
            <div>
                <h2>Agregar habitaciones</h2>
                <asp:Label ID="numeroLabel" runat="server" Text="Numero de habitacion"></asp:Label> <br />
                <asp:TextBox ID="txtNumero" runat="server" Placeholder="Número de habitación"></asp:TextBox> <br />
                <asp:Label ID="descripcionLabel" runat="server" Text="Descripcion"></asp:Label> <br/>
                <asp:TextBox ID="txtDescripcion" runat="server" Placeholder="Descripción"></asp:TextBox> <br />
                <asp:Label ID="cant_huespedesLabel" runat="server" Text="Cantidad de huespedes"></asp:Label> <br />
                <asp:TextBox ID="txtCantHuespedes" runat="server" Placeholder="cant_huespedes"></asp:TextBox> <br />
                <asp:Button ID="btnAgregar" runat="server" Text="Agregar" OnClick="btnAgregar_Click" /> <br />
            </div>
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
