<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeleccionarProductos.aspx.cs" Inherits="TP6_GRUPO_16.SeleccionarProductos" %>

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
        .auto-style3 {
            width: 18px;
        }
        .auto-style4 {
            height: 23px;
            width: 18px;
        }
        .auto-style5 {
            width: 18px;
            height: 161px;
        }
        .auto-style6 {
            height: 161px;
        }
        .auto-style7 {
            width: 485px;
        }
        .auto-style8 {
            height: 161px;
            width: 485px;
        }
        .auto-style9 {
            height: 23px;
            width: 485px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table class="auto-style1">
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style5"></td>
                    <td class="auto-style8">
                        <asp:GridView ID="gvProductos" runat="server" 
    BackColor="White" 
    BorderColor="#CCCCCC" 
    BorderStyle="None" 
    BorderWidth="1px" 
    CellPadding="3" 
    AllowPaging="True" 
    PageSize="14" 
    OnPageIndexChanging="gvProductos_PageIndexChanging" AutoGenerateColumns="False" AutoGenerateSelectButton="True" OnSelectedIndexChanging="gvProductos_SelectedIndexChanging">
    <Columns>
        <asp:TemplateField HeaderText="Id Producto">
            <ItemTemplate>
                <asp:Label ID="lbl_it_IdProducto" runat="server" Text='<%# Bind("IdProducto") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Nombre Producto">
            <ItemTemplate>
                <asp:Label ID="lbl_it_NombreProducto" runat="server" Text='<%# Bind("NombreProducto") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Id Proveedor">
            <ItemTemplate>
                <asp:Label ID="lbl_it_IdProveedor" runat="server" Text='<%# Bind("IdProveedor") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
        <asp:TemplateField HeaderText="Precio Unitario">
            <ItemTemplate>
                <asp:Label ID="lbl_it_PrecioUnitario" runat="server" Text='<%# Bind("PrecioUnidad") %>'></asp:Label>
            </ItemTemplate>
        </asp:TemplateField>
    </Columns>
    <FooterStyle BackColor="White" ForeColor="#000066" />
    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
    <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
    <RowStyle ForeColor="#000066" />
    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
    <SortedAscendingCellStyle BackColor="#F1F1F1" />
    <SortedAscendingHeaderStyle BackColor="#007DBB" />
    <SortedDescendingCellStyle BackColor="#CAC9C9" />
    <SortedDescendingHeaderStyle BackColor="#00547E" />
</asp:GridView>
                    </td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6">
                        <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                    </td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                    <td class="auto-style6"></td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style9"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style9">
                        <asp:Label ID="lblProdAgreg" runat="server" Text="Productos Agregados:"></asp:Label>
                    </td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2">
                        <asp:HyperLink ID="hlVolverInicio" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderWidth="1px" NavigateUrl="~/Ejercicio2.aspx">Volver al Inicio</asp:HyperLink>
                    </td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style9"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                    <td class="auto-style2"></td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3">&nbsp;</td>
                    <td class="auto-style7">&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
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
