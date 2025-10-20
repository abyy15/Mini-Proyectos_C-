<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio2b.aspx.cs" Inherits="TP2_GRUPO16.Ejercicio2b" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style3 {
            width: 898px;
        }
        .auto-style4 {
            width: 1642px;
        }
        .auto-style5 {
            height: 31px;
        }
        .auto-style7 {
            width: 1642px;
            height: 31px;
        }
        .auto-style8 {
            width: 898px;
            height: 31px;
        }
        .auto-style9 {
            width: 141px;
        }
        .auto-style10 {
            height: 31px;
            width: 141px;
        }
        .auto-style11 {
            width: 240px;
        }
        .auto-style12 {
            height: 31px;
            width: 240px;
        }
        .auto-style13 {
            width: 371px;
        }
        .auto-style14 {
            height: 31px;
            width: 371px;
        }
        .auto-style15 {
            width: 141px;
            height: 23px;
        }
        .auto-style17 {
            width: 1642px;
            height: 23px;
        }
        .auto-style18 {
            width: 240px;
            height: 23px;
        }
        .auto-style19 {
            width: 371px;
            height: 23px;
        }
        .auto-style20 {
            width: 898px;
            height: 23px;
        }
        .auto-style21 {
            height: 23px;
        }
        .auto-style22 {
            width: 252px;
        }
        .auto-style23 {
            height: 31px;
            width: 252px;
        }
        .auto-style24 {
            width: 252px;
            height: 23px;
        }
        .auto-style25 {
            height: 26px;
            width: 141px;
        }
        .auto-style26 {
            height: 26px;
            width: 252px;
        }
        .auto-style27 {
            width: 1642px;
            height: 26px;
        }
        .auto-style28 {
            height: 26px;
            width: 240px;
        }
        .auto-style29 {
            height: 26px;
            width: 371px;
        }
        .auto-style30 {
            width: 898px;
            height: 26px;
        }
        .auto-style31 {
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:Label ID="lblResumen" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="RESUMEN"></asp:Label>
                    </td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10"></td>
                    <td class="auto-style23">
                        <asp:Label ID="lblNombre" runat="server" Text="Nombre:"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:Label ID="lblNombreIngresado" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style12"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style10"></td>
                    <td class="auto-style23">
                        <asp:Label ID="lblApellido0" runat="server" Text="Apellido:"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:Label ID="lblApellidoIngresado" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style12"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style22">&nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style15"></td>
                    <td class="auto-style24">
                        <asp:Label ID="lblZona" runat="server" Text="Zona: "></asp:Label>
                    </td>
                    <td class="auto-style17">
                        <asp:Label ID="lblZonaSeleccionada" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style18"></td>
                    <td class="auto-style19"></td>
                    <td class="auto-style20"></td>
                    <td class="auto-style21"></td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style22">
                        &nbsp;</td>
                    <td class="auto-style4">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9">&nbsp;</td>
                    <td class="auto-style22">
                        <asp:Label ID="lblTemasElegidos" runat="server" Text="Los temas elegidos son:"></asp:Label>
                    </td>
                    <td class="auto-style4">
                        <asp:Label ID="lblTemasSelecionados" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style25"></td>
                    <td class="auto-style26">
                        </td>
                    <td class="auto-style27">
                        &nbsp;</td>
                    <td class="auto-style28"></td>
                    <td class="auto-style29"></td>
                    <td class="auto-style30"></td>
                    <td class="auto-style31"></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
