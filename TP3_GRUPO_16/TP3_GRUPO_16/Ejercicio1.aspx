<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="TP3_GRUPO_16.WebForm1" %>

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
            width: 241px;
        }
        .auto-style3 {
            height: 50px;
        }
        .auto-style4 {
            width: 241px;
            height: 50px;
        }
        .auto-style5 {
            height: 27px;
        }
        .auto-style6 {
            width: 241px;
            height: 27px;
        }
        .auto-style7 {
            height: 26px;
        }
        .auto-style8 {
            width: 241px;
            height: 26px;
        }
        .auto-style9 {
            height: 25px;
        }
        .auto-style10 {
            width: 241px;
            height: 25px;
        }
        .auto-style11 {
            width: 268px;
        }
        .auto-style12 {
            height: 50px;
            width: 268px;
        }
        .auto-style13 {
            height: 26px;
            }
        .auto-style14 {
            height: 27px;
            width: 268px;
        }
        .auto-style15 {
            height: 25px;
            width: 268px;
        }
        .auto-style16 {
        }
        .auto-style17 {
            height: 50px;
            width: 22px;
        }
        .auto-style18 {
            height: 26px;
            }
        .auto-style19 {
            height: 27px;
            width: 22px;
        }
        .auto-style20 {
            height: 25px;
            width: 22px;
        }
        .auto-style21 {
        }
        .auto-style22 {
            height: 50px;
            }
        .auto-style23 {
            height: 26px;
            width: 9px;
        }
        .auto-style24 {
            height: 27px;
            width: 9px;
        }
        .auto-style25 {
            height: 25px;
            width: 9px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td class="auto-style21">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3"></td>
                    <td class="auto-style4"></td>
                    <td class="auto-style12">
                        <asp:Label ID="lblLocalidades" runat="server" Font-Bold="True" Font-Underline="True" Text="Localidades" Font-Size="Larger"></asp:Label>
                    </td>
                    <td class="auto-style17"></td>
                    <td class="auto-style22" colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td class="auto-style21">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Label ID="lblNombreLocalidad" runat="server" Text="Nombre de localidad:"></asp:Label>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="txtLocalidad" runat="server" Width="227px" ValidationGroup="GrupoLocalidades"></asp:TextBox>
                    </td>
                    <td class="auto-style16">
                        <asp:RequiredFieldValidator ID="rfvLocalidad" runat="server" ControlToValidate="txtLocalidad" ErrorMessage="ingrese localidad" ValidationGroup="GrupoLocalidades">*</asp:RequiredFieldValidator>
                    </td>
                    <td class="auto-style21">
                        <asp:CustomValidator ID="cvLocalidad" runat="server" ControlToValidate="txtLocalidad" ErrorMessage="Esa localidad ya esta cargada" OnServerValidate="cvLocalidad_ServerValidate" ValidationGroup="GrupoLocalidades">*</asp:CustomValidator>
                    </td>
                    <td>
                        &nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td class="auto-style21">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style11">
                        <asp:Button ID="btnGuardarLocalidad" runat="server" Text="Guardar localidad" OnClick="btnGuardarLocalidad_Click" ValidationGroup="GrupoLocalidades" />
                    </td>
                    <td class="auto-style16">&nbsp;</td>
                    <td class="auto-style21" colspan="3">
                        <asp:ValidationSummary ID="vsLocalidad" runat="server" ValidationGroup="GrupoLocalidades" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td class="auto-style21">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style11">
                        <asp:Label ID="lblUsuarios" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Usuarios"></asp:Label>
                    </td>
                    <td class="auto-style16">&nbsp;</td>
                    <td class="auto-style21" colspan="3">&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td class="auto-style21">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Label ID="lblNombreUsuario" runat="server" Text="Nombre usuario:"></asp:Label>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="tbNombreUsuario" runat="server" ValidationGroup="GrupoUsuarios"></asp:TextBox>
                    </td>
                    <td class="auto-style16" colspan="4">
                        <asp:RequiredFieldValidator ID="rfvNombreUsuario" runat="server" ControlToValidate="tbNombreUsuario" ErrorMessage="Debe ingresar un nombre de usuario. " ValidationGroup="GrupoUsuarios">*</asp:RequiredFieldValidator>
                        </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td class="auto-style21">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">
                        <asp:Label ID="lblContraseña" runat="server" Text="Contraseña:"></asp:Label>
                    </td>
                    <td class="auto-style11">
                        <asp:TextBox ID="tbContraseña" runat="server" TextMode="Password" ValidationGroup="GrupoUsuarios"></asp:TextBox>
                    </td>
                    <td class="auto-style16" colspan="4">
                        <asp:RequiredFieldValidator ID="rfvContraseña" runat="server" ControlToValidate="tbContraseña" ErrorMessage="Debe ingresar una contraseña" ValidationGroup="GrupoUsuarios">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style8"></td>
                    <td class="auto-style13"></td>
                    <td class="auto-style18"></td>
                    <td class="auto-style23"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style8">
                        <asp:Label ID="lblRepetirContraseña" runat="server" Text="Repetir Contraseña:"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <asp:TextBox ID="txtRepetirContraseña" runat="server" TextMode="Password" ValidationGroup="GrupoUsuarios"></asp:TextBox>
                    </td>
                    <td class="auto-style18" colspan="4">
                        <asp:RequiredFieldValidator ID="rfvRepetirContraseña" runat="server" ControlToValidate="txtRepetirContraseña" ErrorMessage="Debe repetir la contraseña" ValidationGroup="GrupoUsuarios">*</asp:RequiredFieldValidator>
                        <br />
                        <asp:CompareValidator ID="cvContraseñas" runat="server" ControlToCompare="tbContraseña" ControlToValidate="txtRepetirContraseña" ErrorMessage="Las contraseñas no coinciden" ValidationGroup="GrupoUsuarios">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style14"></td>
                    <td class="auto-style19"></td>
                    <td class="auto-style24"></td>
                    <td class="auto-style5"></td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style8">
                        <asp:Label ID="lblCorreoElectronico" runat="server" Text="Correo Electronico:"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <asp:TextBox ID="txtCorreoElectronico" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style18" colspan="4">
                        <asp:RegularExpressionValidator ID="revCorreo" runat="server" ControlToValidate="txtCorreoElectronico" ErrorMessage="Ingrese un correo valido" ValidationExpression="^[^@\s]+@[^@\s]+\.[^@\s]+$" ValidationGroup="GrupoUsuarios">*</asp:RegularExpressionValidator>
                        <br />
                        <asp:RequiredFieldValidator ID="rfvCorreo" runat="server" ControlToValidate="txtCorreoElectronico" ErrorMessage="Debe ingresar un correo" ValidationGroup="GrupoUsuarios">*</asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style11">&nbsp;</td>
                    <td class="auto-style16">&nbsp;</td>
                    <td class="auto-style21">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style8">
                        <asp:Label ID="lblCP" runat="server" Text="CP:"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <asp:TextBox ID="txbCP" runat="server"></asp:TextBox>
                    </td>
                    <td class="auto-style7" colspan="4">
                        <asp:RequiredFieldValidator ID="rfvCodigoPostal" runat="server" ControlToValidate="txbCP" ErrorMessage="Ingrese un CP" ValidationGroup="GrupoUsuarios">*</asp:RequiredFieldValidator>
                        <br />
                        <asp:RegularExpressionValidator ID="revCodigoPostal" runat="server" ControlToValidate="txbCP" ErrorMessage="Ingrese un CP valido" ValidationExpression="^\d{4}$" ValidationGroup="GrupoUsuarios">*</asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style8">&nbsp;</td>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style18">&nbsp;</td>
                    <td class="auto-style23">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style8">
                        <asp:Label ID="lblLocalidad" runat="server" Text="Localidades:"></asp:Label>
                    </td>
                    <td class="auto-style13">
                        <asp:DropDownList ID="ddlLocalidades" runat="server" ValidationGroup="GrupoUsuarios">
                        </asp:DropDownList>
                    </td>
                    <td class="auto-style18" colspan="4">
                        <asp:RequiredFieldValidator ID="rfvLocalidades" runat="server" ControlToValidate="ddlLocalidades" ErrorMessage="Debe seleccionar una localidad. " ValidationGroup="GrupoUsuarios" InitialValue="-Seleccione una opcion">*</asp:RequiredFieldValidator>
                        <br />
                        <asp:CompareValidator ID="cvLocalidades" runat="server" ControlToCompare="txtLocalidad" ControlToValidate="ddlLocalidades" ErrorMessage="CompareValidator" Operator="NotEqual" ValidationGroup="GrupoUsuarios">*</asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style9"></td>
                    <td class="auto-style10"></td>
                    <td class="auto-style15">
                        <asp:Button ID="btnGuardarUsuario" runat="server" Text="Guardar Usuario" ValidationGroup="GrupoUsuarios" OnClick="btnGuardarUsuario_Click" />
                    </td>
                    <td class="auto-style20"></td>
                    <td class="auto-style25">
                        <asp:Label ID="lblBienvenida" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style9"></td>
                    <td class="auto-style9"></td>
                </tr>
                <tr>
                    <td class="auto-style7"></td>
                    <td class="auto-style8">
                    </td>
                    <td class="auto-style13"></td>
                    <td class="auto-style18"></td>
                    <td class="auto-style23"></td>
                    <td class="auto-style7"></td>
                    <td class="auto-style7"></td>
                </tr>
                <tr>
                    <td class="auto-style7">&nbsp;</td>
                    <td class="auto-style8">
                        <asp:Button ID="btnIrInicio" runat="server" Text="Ir a inicio .aspx" Width="178px" OnClick="btnIrInicio_Click" ValidationGroup="GrupoInicio" />
                    </td>
                    <td class="auto-style13" colspan="4">
                        <asp:ValidationSummary ID="vsUsuario" runat="server" ValidationGroup="GrupoUsuarios" />
                    </td>
                    <td class="auto-style7">&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
