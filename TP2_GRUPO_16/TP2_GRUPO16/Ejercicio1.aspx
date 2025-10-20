<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP2_GRUPO16.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 40px;
        }
        .auto-style3 {
            width: 325px;
        }
        .auto-style4 {
            width: 175px;
        }
        .auto-style5 {
            width: 85px;
        }
        .auto-style6 {
            width: 87px;
        }
        .auto-style7 {
            width: 40px;
            height: 23px;
        }
        .auto-style8 {
            width: 325px;
            height: 23px;
        }
        .auto-style9 {
            width: 175px;
            height: 23px;
        }
        .auto-style10 {
            width: 85px;
            height: 23px;
        }
        .auto-style11 {
            width: 87px;
            height: 23px;
        }
        .auto-style12 {
            height: 23px;
        }
        .auto-style13 {
            width: 84px;
        }
        .auto-style14 {
            height: 23px;
            width: 84px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="lblProducto1" runat="server" Text="Ingrese el nombre del producto:"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtProducto1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="lbCantProd1" runat="server" Text="Cantidad:"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="tbCantProd1" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style13">
                    <asp:Label ID="lblPrecioProd1" runat="server" Text="Precio: "></asp:Label>
                </td>
                <td style="margin-left: 40px">
                    <asp:TextBox ID="tbPrecioProd1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="lblProducto2" runat="server" Text="Ingrese el nombre del producto:"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtProducto2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="lbCantProd2" runat="server" Text="Cantidad:"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="tbCantProd2" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style13">
                    <asp:Label ID="lblPrecioProd2" runat="server" Text="Precio: "></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="tbPrecioProd2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style8"></td>
                <td class="auto-style9"></td>
                <td class="auto-style10"></td>
                <td class="auto-style11"></td>
                <td class="auto-style14"></td>
                <td class="auto-style12"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3" id="lblIngresarProducto">Ingrese el nombre del producto: </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtProducto3" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="lblCantProd3" runat="server" Text="Cantidad:"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="tbCantProd3" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style13">
                    <asp:Label ID="LblPrecioProd3" runat="server" Text="Precio:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="tbPrecioProd3" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Button ID="btnGenerarTabla" runat="server" Text="Generar Tabla" Width="199px" OnClick="btnGenerarTabla_Click" />
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">
                    <asp:Label ID="lblValidacion" runat="server" Font-Bold="True"></asp:Label>
                </td>
                <td class="auto-style13">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="lblTabla" runat="server"></asp:Label>
                </td>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td class="auto-style6">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        </div>
    </form>
</body>
</html>
