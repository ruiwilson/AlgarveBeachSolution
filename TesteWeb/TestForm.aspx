<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TestForm.aspx.cs" Inherits="TesteWeb.TestForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        table{ 
            width:100%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>


        <asp:TextBox ID="pnome" runat="server"></asp:TextBox>
&nbsp;primeiro nome<br />
        <br />
        <asp:TextBox ID="unome" runat="server"></asp:TextBox>
&nbsp;ultimo nome<br />
        <br />
        <asp:TextBox ID="username" runat="server"></asp:TextBox>
&nbsp;username<br />
        <br />
        <asp:TextBox ID="password" runat="server"></asp:TextBox>
&nbsp;password<br />
        <br />
        <asp:TextBox ID="email" runat="server"></asp:TextBox>
&nbsp;email<br />
        <asp:Button ID="brninserir" runat="server" OnClick="brninserir_Click" Text="Inserir" />
        <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Modificar" />
        <br />
        <br />
        <br />
        Apagar Cliente<br />
        <br />
        <br />
        <asp:TextBox ID="IDcliente" runat="server"></asp:TextBox>
&nbsp;ID do Cliente<br />
        <asp:Button ID="btnApagar" runat="server" OnClick="btnApagar_Click" Text="Apagar" />
        <br />
        <br />
        <br />
        <br />
        <div style="width:100%;text-align:left;font-size:medium">
        <asp:Literal ID="ltmostrar" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
