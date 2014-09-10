<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TesteForm.aspx.cs" Inherits="TesteWeb.TesteForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Primeiro Nome:
        <asp:TextBox ID="txtPNome" runat="server"></asp:TextBox>
        <br />
        Ultimo Nome:
        <asp:TextBox ID="txtUNome" runat="server"></asp:TextBox>
        <br />
        UserName:
        <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
        <br />
        Password:
        <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
        <br />
        E-Mail:
        <asp:TextBox ID="txtEMail" runat="server"></asp:TextBox>
    
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    
    </div>
        <asp:Literal ID="Literal1" runat="server"></asp:Literal>
    </form>
</body>
</html>
