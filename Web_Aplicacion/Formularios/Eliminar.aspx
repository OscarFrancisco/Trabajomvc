<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Eliminar.aspx.cs" Inherits="Web_Aplicacion.Formularios.Eliminar" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="MainContent">
    <asp:HiddenField ID="hdfId" runat="server" ClientIDMode="Static" />
    <div>
            <table style="width:60%">
                <colgroup>
                    <col style="width:40%" />
                    <col style="width:60%" />
                </colgroup>
                <tr>
                    <td><strong>Nombre:</strong></td>
                    <td><asp:Label ID="lblNombre" runat="server" ClientIDMode="Static"></asp:Label></td>
                    
                </tr>
                <tr>
                    <td><strong>Telefono:</strong></td>
                    <td><asp:Label ID="lblTelefono" runat="server" ClientIDMode="Static"></asp:Label></td>
                </tr>
                <tr>
                    <td><strong>Correo:</strong></td>
                    <td><asp:Label ID="lblCorreo" runat="server" ClientIDMode="Static"></asp:Label></td>
                </tr>
                <tr>
                    <td><strong>Nombre de Usuario:</strong></td>
                    <td><asp:Label ID="lblNombreUsuario" runat="server" ClientIDMode="Static"></asp:Label></td>
                </tr>
            </table>
    </div>
    <div></div>
    <div>
        <asp:Button ID="btn_Eliminar" Width="200px" Text="Eliminar" runat="server" ClientIDMode="Static" OnClick="btn_Eliminar_Click"/>
        <asp:HyperLink  ID="hlRegresar" runat="server" NavigateUrl="~/Formularios/Formulario_Lista.aspx" >Regresar</asp:HyperLink>
    </div>
</asp:Content>