<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SeleccionarSucursales.aspx.cs" Inherits="TP7_GRUPO_16.SeleccionarSucursales" %>

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
            width: 625px;
        }
        .auto-style3 {
            height: 27px;
        }
        .auto-style4 {
            width: 625px;
            height: 27px;
        }
        .auto-style7 {
            width: 150px;
        }
        .auto-style8 {
            height: 27px;
            width: 150px;
        }
        .auto-style9 {
            width: 589px;
        }
        .auto-style10 {
            height: 811px;
        }
        .auto-style11 {
            width: 625px;
            height: 811px;
        }
        .auto-style12 {
            width: 150px;
            height: 811px;
        }
        .auto-style14 {
            width: 10px;
        }
        .auto-style15 {
            height: 811px;
            width: 10px;
        }
        .auto-style16 {
            height: 27px;
            width: 10px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">
                    <asp:HyperLink ID="hlkListadoSucursales" runat="server" ForeColor="#0033CC">Listado de Sucursales</asp:HyperLink>
                </td>
                <td class="auto-style7">
                    <asp:HyperLink ID="hlMostrarSucursales" runat="server" ForeColor="#0033CC" NavigateUrl="~/SucursalesSeleccionadas.aspx">Mostrar Sucursales Seleccionadas</asp:HyperLink>
                </td>
                <td>&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="lblListadoSucursales" runat="server" BorderColor="Black" Font-Bold="True" ForeColor="Black" Height="38px" style="font-size: x-large; text-align: center" Text="Listado de Sucursales" Width="347px"></asp:Label>
                </td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="lblBusquedaSucursales" runat="server" Height="37px" Text="Busqueda por nombre de Sucursales:" Width="397px"></asp:Label>
                </td>
                <td class="auto-style7">
                    <asp:TextBox ID="txtBuscar" runat="server" Width="195px"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnBuscar" runat="server" Text="Buscar" Width="68px" OnClick="btnBuscar_Click" />
                </td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style10">
                    <asp:DataList ID="DataListProvincias" runat="server" DataKeyField="Id_Provincia" Height="1109px">
                        <ItemTemplate>
                            <asp:Button ID="btnProvincias" runat="server" CommandArgument='<%# Eval("Id_Provincia") %>' Text='<%# Eval("DescripcionProvincia") %>' CommandName="botonProvincia" OnCommand="btnProvincias_Command" />
                        </ItemTemplate>
                    </asp:DataList>
                </td>
                <td class="auto-style11">
                    <asp:ListView ID="ListViewSucursales" runat="server" DataSourceID="SqlDataSourceSucursales" GroupItemCount="3" OnSelectedIndexChanged="ListViewSucursales_SelectedIndexChanged">
                        <LayoutTemplate>
                            <table runat="server">
                                <tr runat="server">
                                    <td runat="server" class="auto-style9">
                                        <table id="groupPlaceholderContainer" runat="server" border="1" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;font-family: Verdana, Arial, Helvetica, sans-serif;">
                                            <tr id="groupPlaceholder" runat="server">
                                            </tr>
                                        </table>
                                    </td>
                                </tr>
                                <tr runat="server">
                                    <td runat="server" class="auto-style9" style="text-align: center;background-color: #5D7B9D;font-family: Verdana, Arial, Helvetica, sans-serif;color: #FFFFFF">
                                        <asp:DataPager ID="DataPager1" runat="server" PageSize="6">
                                            <Fields>
                                                <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                                <asp:NumericPagerField />
                                                <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                            </Fields>
                                        </asp:DataPager>
                                    </td>
                                </tr>
                            </table>
                        </LayoutTemplate>
                        <AlternatingItemTemplate>
                            <td runat="server" style="background-color: #FFFFFF;color: #284775;">
                                <asp:Label ID="NombreSucursalLabel" runat="server" Text='<%# Eval("NombreSucursal") %>' />
                                <br />
                                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl='<%# Eval("URL_Imagen_Sucursal") %>' />
                                <br />
                                <asp:Label ID="DescripcionSucursalLabel" runat="server" Text='<%# Eval("DescripcionSucursal") %>' />
                                <br />
                                <asp:Button ID="btnSeleccionar" runat="server" CommandArgument='<%# Eval("Id_Sucursal") %>' CommandName="seleccionarSucursal" OnCommand="btnSeleccionar_Command1" Text="Seleccionar" />
                            </td>
                        </AlternatingItemTemplate>
                        <EditItemTemplate>
                            <td runat="server" style="background-color: #999999;">NombreSucursal:
                                <asp:TextBox ID="NombreSucursalTextBox" runat="server" Text='<%# Bind("NombreSucursal") %>' />
                                <br />
                                DescripcionSucursal:
                                <asp:TextBox ID="DescripcionSucursalTextBox" runat="server" Text='<%# Bind("DescripcionSucursal") %>' />
                                <br />
                                URL_Imagen_Sucursal:
                                <asp:TextBox ID="URL_Imagen_SucursalTextBox" runat="server" Text='<%# Bind("URL_Imagen_Sucursal") %>' />
                                <br />
                                <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                                <br />
                                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                                <br />
                            </td>
                        </EditItemTemplate>
                        <EmptyDataTemplate>
                            <table runat="server" style="background-color: #FFFFFF;border-collapse: collapse;border-color: #999999;border-style:none;border-width:1px;">
                                <tr>
                                    <td>No data was returned.</td>
                                </tr>
                            </table>
                        </EmptyDataTemplate>
                        <EmptyItemTemplate>
                            <td runat="server" />
                        </EmptyItemTemplate>
                        <GroupTemplate>
                            <tr id="itemPlaceholderContainer" runat="server">
                                <td id="itemPlaceholder" runat="server"></td>
                            </tr>
                        </GroupTemplate>
                        <InsertItemTemplate>
                            <td runat="server" style="">NombreSucursal:
                                <asp:TextBox ID="NombreSucursalTextBox" runat="server" Text='<%# Bind("NombreSucursal") %>' />
                                <br />
                                DescripcionSucursal:
                                <asp:TextBox ID="DescripcionSucursalTextBox" runat="server" Text='<%# Bind("DescripcionSucursal") %>' />
                                <br />
                                URL_Imagen_Sucursal:
                                <asp:TextBox ID="URL_Imagen_SucursalTextBox" runat="server" Text='<%# Bind("URL_Imagen_Sucursal") %>' />
                                <br />
                                <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                                <br />
                                <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                                <br />
                            </td>
                        </InsertItemTemplate>
                        <ItemTemplate>
                            <td runat="server" style="background-color: #E0FFFF;color: #333333;">
                                <asp:Label ID="NombreSucursalLabel" runat="server" Text='<%# Eval("NombreSucursal") %>' />
                                <br />
                                <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl='<%# Eval("URL_Imagen_Sucursal") %>' />
                                <br />
                                <asp:Label ID="DescripcionSucursalLabel" runat="server" Text='<%# Eval("DescripcionSucursal") %>' />
                                <br />
                                <asp:Button ID="btnSeleccionar" runat="server" CommandArgument='<%# Eval("Id_Sucursal") %>' CommandName="seleccionarSucursal" OnCommand="btnSeleccionar_Command" Text="Seleccionar" />
                                <br />
                            </td>
                        </ItemTemplate>
                        <SelectedItemTemplate>
                            <td runat="server" style="background-color: #E2DED6;font-weight: bold;color: #333333;">NombreSucursal:
                                <asp:Label ID="NombreSucursalLabel" runat="server" Text='<%# Eval("NombreSucursal") %>' />
                                <br />
                                DescripcionSucursal:
                                <asp:Label ID="DescripcionSucursalLabel" runat="server" Text='<%# Eval("DescripcionSucursal") %>' />
                                <br />
                                URL_Imagen_Sucursal:
                                <asp:Label ID="URL_Imagen_SucursalLabel" runat="server" Text='<%# Eval("URL_Imagen_Sucursal") %>' />
                                <br />
                            </td>
                        </SelectedItemTemplate>
                    </asp:ListView>
                </td>
                <td class="auto-style12">
                    <asp:Label ID="lblMensaje" runat="server"></asp:Label>
                </td>
                <td class="auto-style10"></td>
                <td class="auto-style15"></td>
            </tr>
            <tr>
                <td class="auto-style3">
                    &nbsp;</td>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style8"></td>
                <td class="auto-style3"></td>
                <td class="auto-style16"></td>
            </tr>
            <tr>
                <td>
                    <asp:SqlDataSource ID="sdsProvincias" runat="server" ConnectionString="<%$ ConnectionStrings:BDSucursalesConnectionString %>" ProviderName="<%$ ConnectionStrings:BDSucursalesConnectionString.ProviderName %>" SelectCommand="SELECT [Id_Provincia], [DescripcionProvincia] FROM [Provincia]"></asp:SqlDataSource>
                </td>
                <td class="auto-style2">
                    <asp:SqlDataSource ID="SqlDataSourceSucursales" runat="server" ConnectionString="<%$ ConnectionStrings:BDSucursalesConnectionStringSucursales %>" SelectCommand="SELECT [NombreSucursal], [DescripcionSucursal], [URL_Imagen_Sucursal], [Id_Sucursal], [Id_ProvinciaSucursal] FROM [Sucursal]"></asp:SqlDataSource>
                </td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style7">&nbsp;</td>
                <td>&nbsp;</td>
                <td class="auto-style14">&nbsp;</td>
            </tr>
            </table>
        <div>
        </div>
    </form>
</body>
</html>