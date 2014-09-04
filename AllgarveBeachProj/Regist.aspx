<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Regist.aspx.cs" Inherits="AllgarveBeach.Regist" %>

<!DOCTYPE html>
<!--TERMINADO-->
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="CSS/defs.css">
</head>
	<body>     
        <div>
            <h2><i>Registo simples e rápido!!</i></h2>
        </div>
    	<form id="form2" runat="server">
<!-- Cadastrar-se, ou seja, registar-se no sistema de login T_T melhor colocar na parte do admin... -->
        <div align="left"> 
    <!-- Continuação do formulário T_~... --> 
    <br>
        <asp:Table runat="server" CellPadding="5" GridLines="horizontal" HorizontalAlign="Center">
                <asp:TableHeaderRow>
                    <asp:TableHeaderCell ColumnSpan="2">Preencha os seguintes dados</asp:TableHeaderCell> 
                </asp:TableHeaderRow>
                <asp:TableRow>
                    <asp:TableCell>Username</asp:TableCell>
                    <asp:TableCell><font face='Vani'><asp:TextBox ID="txtlogin" runat="server"></asp:TextBox></font></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Password</asp:TableCell>
                    <asp:TableCell><font face='Vani'><asp:TextBox ID="txtpassword" runat="server"></asp:TextBox></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Primeiro Nome</asp:TableCell>
                    <asp:TableCell><font face='Vani'><asp:TextBox ID="txtpnome" runat="server"></asp:TextBox></font></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Apelido</asp:TableCell>
                    <asp:TableCell><font face='Vani'><asp:TextBox ID="txtunome" runat="server"></asp:TextBox></font></asp:TableCell>
                </asp:TableRow>
                <asp:TableRow>
                    <asp:TableCell>Email</asp:TableCell>
                    <asp:TableCell><font face='Vani'><asp:TextBox ID="txtemail" runat="server"></asp:TextBox></font></asp:TableCell>
                </asp:TableRow>
                <asp:TableFooterRow>
                    <asp:TableCell ColumnSpan="2" HorizontalAlign="Center"><font face='Vani'><asp:Button ID="Button1" runat="server" onclick="Button1_Click" style="width: 76px; height: 26px" Text="Registar" /></font></asp:TableCell>
                </asp:TableFooterRow>
         </asp:Table>
    <br />
        </div>
     </form>
        <hr />
    <div>
        Vantagens de ser utilizador registado:
        <p>*Votar positiva ou negativamente nas praias, hoteis ou restaurantes</p>
        <p>*Comentar mas pode receber resposta privada sobre as praias, hoteis ou restaurantes que comentou</p>
        <p>*Participar em discussões no forum, para além de partilhar imagens, criar album online sobre visitas</p>
        <p>*Interagir com os outros utilizadores em tempo real através do chat</p>
    </div>
        <hr />
        <div class="footer">
      <table align='center' cellpadding='2' cellspacing='2'>
    <tr>
      <td bgcolor=#FFF align=center height="50" width="150"><marquee behavior="alternate" scrollamount="1"><font color="#66ffff">Voltar a Home</font></marquee>
            </td>
      <td bgcolor=#FFF align=center height="50" width="50"><a href="Index.aspx" title="Ir para LoginZone"><img src='images/home.png' height='50' width='50'></a></td>
    </tr>
          </div>
      </table>
     </body>
