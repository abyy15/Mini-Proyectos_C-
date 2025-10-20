<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP4_GRUPO_16.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            height: 9px;
        }
        .auto-style3 {
            width: 173px;
        }
        .auto-style4 {
            height: 9px;
            width: 173px;
        }
        .auto-style5 {
            width: 58px;
        }
        .auto-style6 {
            height: 9px;
            width: 58px;
        }
        .auto-style7 {
            width: 220px;
        }
        .auto-style8 {
            height: 9px;
            width: 220px;
        }
        .auto-style9 {
            width: 58px;
            height: 23px;
        }
        .auto-style10 {
            width: 173px;
            height: 23px;
        }
        .auto-style11 {
            width: 220px;
            height: 23px;
        }
        .auto-style12 {
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style6"></td>
                    <td class="auto-style4">
                        <asp:Label ID="lblDestinoInicio" runat="server" Font-Bold="False" Font-Italic="True" Font-Underline="True" Text="Destino Inicio:"></asp:Label>
                    </td>
                    <td class="auto-style8"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="lblProvinciaInicio" runat="server" Font-Bold="True" Text="Provincia :"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:DropDownList ID="ddlProvinciaInicio" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProvinciaInicio_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="lblLocalidadinicio" runat="server" Font-Bold="True" Text="Localidad :"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:DropDownList ID="ddlLocalidadInicio" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="lblDestinoFinal" runat="server" Font-Bold="False" Font-Italic="True" Font-Underline="True" Text="Destino Final:"></asp:Label>
                    </td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">
                        <asp:Label ID="lblProvinciaDF" runat="server" Font-Bold="True" Text="Provincia:"></asp:Label>
                    </td>
                    <td class="auto-style7">
                        <asp:DropDownList ID="ddlProvinciaDF" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlProvinciaDF_SelectedIndexChanged">
                        </asp:DropDownList>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9"></td>
                    <td class="auto-style10">
                        <asp:Label ID="lblLocalidadDF" runat="server" Font-Bold="True" Text="Localidad:"></asp:Label>
                    </td>
                    <td class="auto-style11">
                        <asp:DropDownList ID="ddlLocalidadFinal" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style12"></td>
                </tr>
                <tr>
                    <td class="auto-style5">&nbsp;</td>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
