<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProbarToken.aspx.cs" Inherits="CapaWSPresentacion.ProbarToken" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txtUsuario" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtClave" runat="server"></asp:TextBox>
        <br />
        <asp:TextBox ID="txtToken" runat="server" Width="584px"></asp:TextBox>
        <br />
        <asp:CheckBox ID="chkValido" runat="server" Text="Usuario Valido" />
        <br />
        <br />
        <asp:Button ID="txtArmarToken" runat="server" OnClick="txtArmarToken_Click" Text="Armar" />
        <asp:Button ID="txtValidarToken" runat="server" OnClick="txtValidarToken_Click" Text="Validar" />
    
    </div>
    </form>
</body>
</html>
