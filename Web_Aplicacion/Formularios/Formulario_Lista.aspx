<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Formulario_Lista.aspx.cs" Inherits="Web_Aplicacion.Formularios.Formulario_Lista" %>



<asp:Content runat="server" ContentPlaceHolderID="MainContent">
    
    <div>
        <asp:HyperLink runat="server" NavigateUrl="~/Formularios/Insertar.aspx" BackColor="Gray" ForeColor="White">Agregar Nuevo</asp:HyperLink>
    </div>
    <div>
        <asp:HiddenField id="hdf_Id" ClientIDMode="Static" runat="server" />
        
        
        <asp:Repeater ID="repetidor" runat="server" ClientIDMode="Static" >
            <HeaderTemplate>
                <table class="table table-bordered table-hover">
                <colgroup>
                    <col style="width:30%"/>
                    <col style="width:20%"/>
                    <col style="width:20%"/>
                    <col style="width:20%"/>
                    <col style="width:10%"/>
                    <col style="width:10%"/>
                </colgroup>
                <tr>
                        <th>Nombre</th>
                        <th>Telefono</th>
                        <th>Correo</th>
                        <th>Nombre de Usuario</th>
                        <th>&nbsp</th>
                        <th>&nbsp</th>
                </tr>
            </HeaderTemplate>
            <ItemTemplate>
              <tr>
                <td style="background-color:#CCFFCC">
                  <asp:Label runat="server" Text='<%# Eval("Nombre") %>' />
                </td>
                <td style="background-color:#CCFFCC">
                  <asp:Label runat="server" Text='<%# Eval("Telefono") %>' />
                </td>
                  <td style="background-color:#CCFFCC">
                  <asp:Label runat="server" Text='<%# Eval("Correo") %>' />
                </td>
                  <td style="background-color:#CCFFCC">
                  <asp:Label runat="server" Text='<%# Eval("NombreUsuario") %>' />
                </td>
                  <td style="background-color:#CCFFCC">
                    <asp:HyperLink runat="server" NavigateUrl='<%# string.Format("~/Formularios/Editar.aspx?id={0}", Eval("Id")) %>' >Editar</asp:HyperLink> 
                </td>
                <td style="background-color:#CCFFCC">
                    <asp:LinkButton ID="Eliminar" runat="server" Text="Eliminar" OnClick="Eliminar_Click" OnClientClick='<%# string.Format("document.getElementById(\"hdf_Id\").value = {0};", Eval("Id")) %>'  ></asp:LinkButton>
                </td>
              </tr>
            </ItemTemplate>
           <FooterTemplate>
              </table>
            </FooterTemplate>
            
        </asp:Repeater>
    </div>
</asp:Content>