<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio3.aspx.cs" Inherits="TP4_GRUPO_16.Ejercicio3" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 151px;
        }
    </style>
    <script type="text/javascript">
        function redirigirVerLibros() {
            var temaSeleccionado = document.getElementById('<%= ddlTemas.ClientID %>').value;
            var lblError = document.getElementById('<%= lblError.ClientID %>');
            if (temaSeleccionado === "0") {
                lblError.style.display = 'block';
                return false; 
            } else {
                lblError.style.display = 'none';
                window.location.href = 'Ejercicio3b.aspx?IdTema=' + temaSeleccionado;
                return false; 
            }
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="lblSeleccionarTema" runat="server" Text="Seleccione un tema:"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="ddlTemas" runat="server">
                    </asp:DropDownList>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">
                    <asp:LinkButton ID="lbVerLibros" runat="server" OnClick="lbVerLibros_Click">Ver libros</asp:LinkButton>
                </td>
                <td>
                    <asp:Label ID="lblError" runat="server" ForeColor="Red" Text="Por favor, seleccione un tema." Visible="false"></asp:Label>
                </td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>