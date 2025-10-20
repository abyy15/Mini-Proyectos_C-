<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio4a.aspx.cs" Inherits="TP2_GRUPO16.Ejercicio4a" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 19px">
        </div>
        <p style="height: 33px">
            <asp:Label ID="lblUsuario" runat="server" Text="Usuario:"></asp:Label>
        &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtUsuario" runat="server" BorderStyle="Double" BorderWidth="4px" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblErrorUsuario" runat="server" ForeColor="Red"></asp:Label>
        </p>
        <p style="height: 33px">
            <asp:Label ID="lblClave" runat="server" Text="Clave:"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtClave" runat="server" BorderStyle="Double" BorderWidth="4px" OnTextChanged="TextBox2_TextChanged" TextMode="Password"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblErrorClave" runat="server" ForeColor="Red"></asp:Label>
        &nbsp;</p>
        <p style="height: 33px">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnValidar" runat="server" Text="Validar" OnClick="btnValidar_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblEstadoUsuario" runat="server" ForeColor="Red"></asp:Label>
        </p>
    </form>
</body>
</html>  