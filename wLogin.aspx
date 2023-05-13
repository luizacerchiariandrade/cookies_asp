<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wLogin.aspx.cs" Inherits="AspModulo2.wLogin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Panel ID="Panel1" runat="server">
                <asp:Label ID="Label1" runat="server" Text="Usuário"></asp:Label>
                <asp:TextBox ID="txtLogin" runat="server"></asp:TextBox>
                <br />
                <asp:Label ID="Label2" runat="server" Text="Senha"></asp:Label>
                <asp:TextBox ID="txtSenha" runat="server"></asp:TextBox>
                <asp:Button ID="btnExecutar" runat="server" OnClick="btnExecutar_Click" Text="login" />
                <br />
                <br />
                <br />
            </asp:Panel>
        </div>
        <asp:Panel ID="Panel2" runat="server">
            <asp:Label ID="Label3" runat="server" Text="Usuario"></asp:Label>
            <asp:TextBox ID="txtUser2" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Senha2"></asp:Label>
            <asp:TextBox ID="txtSenha2" runat="server"></asp:TextBox>
            <asp:Button ID="btn2Logar" runat="server" Text="Button" />
        </asp:Panel>
    </form>
</body>
</html>
