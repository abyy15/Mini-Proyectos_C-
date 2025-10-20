<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3.aspx.cs" Inherits="TP2_GRUPO16.Ejercicio3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 681px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" class="auto-style1">
        <div>
            <asp:LinkButton ID="lbRojo" runat="server" OnClick="lbRojo_Click">Rojo</asp:LinkButton>
        </div>
        <p>
            <asp:LinkButton ID="lbAzul0" runat="server">Azul</asp:LinkButton>
        </p>
        <asp:LinkButton ID="lbVerde" runat="server" OnClick="lbVerde_Click">Verde</asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="lbVioleta" runat="server" OnClick="lbVioleta_Click">Violeta</asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="lbAmarillo" runat="server" OnClick="lbAmarillo_Click">Amarillo</asp:LinkButton>
        <br />
        <br />
        <asp:LinkButton ID="lbNaranja" runat="server" OnClick="lbNaranja_Click">Naranja</asp:LinkButton>
        <br />
        <br />
        <br />
        <asp:Label ID="lblTexto" runat="server" Text="Texto coloreado"></asp:Label>
    </form>
</body>
</html>
