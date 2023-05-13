<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="wPrincipal.aspx.cs" Inherits="AspModulo2.wPrincipal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>prin</h1>
            <p>
                <asp:Label ID="lLogin" runat="server" Text="Label"></asp:Label>
                <asp:Label ID="lsenha" runat="server" Text="Label"></asp:Label>
                <asp:Button ID="btExecutar" runat="server" Text="Apagar cookie" OnClick="btExecutar_Click" />
                <asp:Button ID="btListar" runat="server" Text="listarCookies" OnClick="btListar_Click" />
            </p>
        </div>
    </form>
</body>
</html>
