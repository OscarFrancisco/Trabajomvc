<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Formulario_Lista.aspx.cs" Inherits="Web_Aplicacion.Formularios.Formulario_Lista" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
        <div>Lista</div>
        <asp:ScriptManager ID="Test1" runat="server" />
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
                  <asp:LinkButton runat="server" Text="Editar" ></asp:LinkButton>
                </td>
                  <td style="background-color:#CCFFCC">
                  <asp:LinkButton ID="Eliminar" runat="server" Text="Eliminar" ></asp:LinkButton>
                </td>
              </tr>
            </ItemTemplate>
           <FooterTemplate>
              </table>
            </FooterTemplate>
            
        </asp:Repeater>

    </div>
    </form>
</body>
</html>
