<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TP6_GRUPO_16.Ejercicio2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Label ID="lblInicio" runat="server" Font-Bold="True" Font-Overline="False" Font-Size="Larger" Font-Underline="True" Text="Inicio"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hlSeleccionarProductos" runat="server" NavigateUrl="~/SeleccionarProductos.aspx">Ir a seleccionar productos</asp:HyperLink>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2">
                        <asp:LinkButton ID="lbEliminarProductoSeleccionado" runat="server" OnClick="lbEliminarProductoSeleccionado_Click">Eliminar Producto Seleccionado</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:LinkButton ID="lbMostarProductos" runat="server" OnClick="lbMostarProductos_Click" PostBackUrl="~/MostrarProductos.aspx">Mostar Productos</asp:LinkButton>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>
                        <asp:HyperLink ID="hlVolverInicio" runat="server" NavigateUrl="~/Inicio.aspx">Volver a inicio</asp:HyperLink>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
