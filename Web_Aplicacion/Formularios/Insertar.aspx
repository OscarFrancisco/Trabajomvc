<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Insertar.aspx.cs" Inherits="Web_Aplicacion.Formularios.Insertar" %>

<asp:Content ID="Content1" runat="server" ContentPlaceHolderID="MainContent">
    <div>
            <table style="width:60%">
                <colgroup>
                    <col style="width:40%" />
                    <col style="width:60%" />
                </colgroup>
                <tr>
                    <td><strong>Nombre:</strong></td>
                    <td><asp:TextBox ID="txtNombre" runat ="server" ClientIDMode="Static"></asp:TextBox></td>
                    
                </tr>
                <tr>
                    <td><strong>Telefono</strong></td>
                    <td><asp:TextBox ID="txtTelefono" runat ="server" ClientIDMode="Static"></asp:TextBox></td>
                    
                </tr>
                <tr>
                    <td><strong>Correo</strong></td>
                    <td><asp:TextBox ID="txtCorreo" runat ="server" ClientIDMode="Static"></asp:TextBox></td>
                    
                </tr>
                <tr>
                    <td><strong>Nombre de Usuario</strong></td>
                    <td><asp:TextBox ID="txtNombreUsuario" runat ="server" ClientIDMode="Static"></asp:TextBox></td>
                </tr>
            </table>
    </div>
    <div></div>
    <div>
        <asp:Button ID="btn_Agregar" Width="200px" Text="Agregar" runat="server" ClientIDMode="Static" OnClick="btn_Agregar_Click" />
        <asp:HyperLink ID="hlRegresar" runat="server" NavigateUrl="~/Formularios/Formulario_Lista.aspx" >Regresar</asp:HyperLink>
    </div>
</asp:Content>