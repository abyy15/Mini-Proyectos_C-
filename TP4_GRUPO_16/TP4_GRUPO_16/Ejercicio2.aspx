<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2.aspx.cs" Inherits="TP4_GRUPO_16.Ejercicio2" %>

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
            width: 59px;
        }
        .auto-style3 {
            width: 129px;
        }
        .auto-style4 {
            width: 59px;
            height: 13px;
        }
        .auto-style5 {
            width: 129px;
            height: 13px;
        }
        .auto-style6 {
            height: 13px;
        }
        .auto-style7 {
            width: 59px;
            height: 26px;
        }
        .auto-style8 {
            width: 129px;
            height: 26px;
        }
        .auto-style9 {
            height: 26px;
        }
        .auto-style10 {
            width: 59px;
            height: 23px;
        }
        .auto-style11 {
            width: 129px;
            height: 23px;
        }
        .auto-style12 {
            height: 23px;
        }
        .auto-style13 {
        }
        .auto-style14 {
            height: 26px;
            width: 108px;
        }
        .auto-style15 {
            height: 23px;
            width: 108px;
        }
        .auto-style16 {
            height: 13px;
            width: 108px;
        }
        .auto-style17 {
            width: 215px;
        }
        .auto-style18 {
            height: 26px;
            width: 215px;
        }
        .auto-style19 {
            height: 23px;
            width: 215px;
        }
        .auto-style20 {
            height: 13px;
            width: 215px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style7"></td>
                <td class="auto-style8">
                    <asp:Label ID="lblIdProducto" runat="server" Text="Id Producto:"></asp:Label>
                </td>
                <td class="auto-style14">
                    <asp:DropDownList ID="ddlIdProducto" runat="server">
                    </asp:DropDownList>
                </td>
                <td class="auto-style18">
                    <asp:TextBox ID="txtProducto" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style9"></td>
                <td class="auto-style9"></td>
                <td class="auto-style9"></td>
                <td class="auto-style9"></td>
                <td class="auto-style9"></td>
                <td class="auto-style9"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">
                    <asp:Label ID="lblCategoria" runat="server" Text="Id Categoria:"></asp:Label>
                </td>
                <td class="auto-style13">
                    <asp:DropDownList ID="ddlIdCategoria" runat="server">
                    </asp:DropDownList>
                &nbsp;
                    </td>
                <td class="auto-style17">
                    <asp:TextBox ID="txtCategoria" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10"></td>
                <td class="auto-style11"></td>
                <td class="auto-style15"></td>
                <td class="auto-style19"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
                <td class="auto-style12"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style17">
                    <asp:Button ID="btnFiltrar" runat="server" Text="Filtrar" OnClick="btnFiltrar_Click" />
                </td>
                <td>
                    <asp:Button ID="btnQuitarFiltro" runat="server" Text="Quitar filtro" OnClick="btnQuitarFiltro_Click" />
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4"></td>
                <td class="auto-style5"></td>
                <td class="auto-style16"></td>
                <td class="auto-style20"></td>
                <td class="auto-style6"></td>
                <td class="auto-style6"></td>
                <td class="auto-style6"></td>
                <td class="auto-style6"></td>
                <td class="auto-style6"></td>
                <td class="auto-style6"></td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style13" colspan="3">
                    <asp:GridView ID="gvResultado" runat="server">
                    </asp:GridView>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style13">&nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>
</body>
</html>
