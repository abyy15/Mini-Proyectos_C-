<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AgregarSucursal.aspx.cs" Inherits="TP5_GRUPO_16.AgregarSucursal" %>

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
        }
        .auto-style3 {
            height: 59px;
        }
        .auto-style4 {
            width: 189px;
            height: 59px;
        }
        .auto-style5 {
            height: 59px;
            width: 149px;
        }
        .auto-style6 {
            width: 149px;
        }
        .auto-style7 {
            width: 164px;
            height: 59px;
        }
        .auto-style8 {
        }
        .auto-style9 {
            height: 23px;
        }
        .auto-style10 {
            width: 149px;
            height: 23px;
        }
        .auto-style11 {
            width: 189px;
            height: 23px;
        }
        .auto-style12 {
            width: 164px;
            height: 23px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style5"></td>
                    <td class="auto-style4">
                        <asp:HyperLink ID="hlAgregarSucursal" runat="server" NavigateUrl="~/AgregarSucursal.aspx">Agregar sucursal</asp:HyperLink>
                    </td>
                    <td class="auto-style7">
                        <asp:HyperLink ID="hyListadoSucursales" runat="server" NavigateUrl="~/ListarSucursal.aspx">Listar sucursales</asp:HyperLink>
                    </td>
                    <td class="auto-style3">
                        <asp:HyperLink ID="hyListadoEliminarSucursal" runat="server" NavigateUrl="~/EliminarSucursal.aspx">Eliminar Sucursal</asp:HyperLink>
                    </td>
                    <td class="auto-style3"></td>
                    <td class="auto-style3"></td>
                    <td class="auto-style3"></td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td colspan="7">
                        <asp:Label ID="lblGrupo" runat="server" Font-Bold="True" Font-Size="Larger" Text="Grupo N°16"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style6">
                        <asp:Label ID="lblAgregarSucursal" runat="server" Font-Bold="False" Font-Italic="True" Font-Overline="False" Font-Size="Large" Font-Strikeout="False" Font-Underline="True" Text="Agregar sucursal:"></asp:Label>
                    </td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style6">&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style6">
                        <asp:Label ID="lblNombreSucursal" runat="server" Font-Bold="False" Font-Italic="True" Font-Overline="False" Font-Size="Medium" Font-Strikeout="False" Font-Underline="False" Text="Nombre Sucursal:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtNombreSucursal" runat="server" ValidationGroup="grupo1"></asp:TextBox>
                    </td>
                    <td class="auto-style8">
                        <asp:RequiredFieldValidator ID="rfvNombreSucursal" runat="server" ControlToValidate="txtNombreSucursal" ErrorMessage="Se debe ingresar un nombre de sucursal" ForeColor="Red" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revNombreSucursal" runat="server" ControlToValidate="txtNombreSucursal" ErrorMessage="No se puede ingresar un numero" ForeColor="Red" ValidationExpression="^[a-zA-Z\s]+$" ValidationGroup="grupo1">*</asp:RegularExpressionValidator>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style9"></td>
                    <td class="auto-style10"></td>
                    <td class="auto-style11"></td>
                    <td class="auto-style12"></td>
                    <td class="auto-style9"></td>
                    <td class="auto-style9"></td>
                    <td class="auto-style9"></td>
                    <td class="auto-style9"></td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style6">
                        <asp:Label ID="lblDescripcion" runat="server" Font-Italic="True" Font-Size="Medium" Text="Descripcion"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtDescripcion" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style8">
                        <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ControlToValidate="txtDescripcion" ErrorMessage="Se debe ingresar una descripcion" ForeColor="Red" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revDescripcion" runat="server" ControlToValidate="txtDescripcion" ErrorMessage="No se puede ingresar un numero" ForeColor="Red" ValidationExpression="^[a-zA-Z\s]+$" ValidationGroup="grupo1">*</asp:RegularExpressionValidator>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style6">
                        <asp:Label ID="lblProvincia" runat="server" Font-Italic="True" Font-Size="Medium" Text="Provincia: "></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:DropDownList ID="ddlProvincia" runat="server">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style8">
                        <asp:RequiredFieldValidator ID="rfvProvincia" runat="server" ControlToValidate="ddlProvincia" ErrorMessage="Se debe seleccionar una provincia" ForeColor="Red" ValidationGroup="grupo1" InitialValue="0">*</asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style6">
                        <asp:Label ID="lblDireccion" runat="server" Font-Italic="True" Font-Size="Medium" Text="Direccion:"></asp:Label>
                    </td>
                    <td class="auto-style2">
                        <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style8">
                        <asp:RequiredFieldValidator ID="rfvDireccion" runat="server" ControlToValidate="txtDireccion" ErrorMessage="Se debe ingresar una direccion" ForeColor="Red" ValidationGroup="grupo1">*</asp:RequiredFieldValidator>
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style2" colspan="3">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style2" colspan="3">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" HeaderText="Por favor corrija los siguientes errores:" Height="94px" ValidationGroup="grupo1" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td class="auto-style8">
                        &nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style2">
                        &nbsp;</td>
                    <td class="auto-style8">
                        <asp:Button ID="btnAceptar" runat="server" Text="Aceptar" OnClick="btnAceptar_Click" ValidationGroup="grupo1" />
                    </td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style6">
                        &nbsp;</td>
                    <td class="auto-style2">
                        <asp:Label ID="lblSeIngresoLaSucursal" runat="server" ForeColor="Red"></asp:Label>
                    </td>
                    <td class="auto-style8">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
