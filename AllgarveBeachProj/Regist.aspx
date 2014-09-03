<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Regist.aspx.cs" Inherits="AllgarveBeach.Regist" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="CSS/defs.css">
    <style type="text/css">

                    #login
            {
                top: 151px;
                left: 243px;
                position: absolute;
                height: 22px;
                width: 128px;
            }
            #senha
            {
                top: 181px;
                left: 243px;
                position: absolute;
                height: 22px;
                width: 128px;
            }
            #pnome
            {
                top: 208px;
                left: 244px;
                position: absolute;
                height: 22px;
                width: 128px;
            }
            #unome
            {
                top: 235px;
                left: 244px;
                position: absolute;
                height: 22px;
                width: 128px;
            }
            #funcao
            {
                top: 263px;
                left: 244px;
                position: absolute;
                height: 22px;
                width: 128px;
            }
            #numtlm
            {
                top: 292px;
                left: 244px;
                position: absolute;
                height: 22px;
                width: 128px;
            }
            #numc
            {
                top: 320px;
                left: 245px;
                position: absolute;
                height: 22px;
                width: 128px;
            }
            #Registar
            {
                top: 369px;
                left: 270px;
                position: absolute;
                width: 70px;
            }
            .footer
            {
                top: 551px;
                left: 49px;
                position: absolute;
                height: 70px;
                width: 1055px;
            }
            #email
            {
                top: 318px;
                left: 245px;
                position: absolute;
                height: 22px;
                width: 128px;
            }
            #morada
            {
                top: 264px;
                left: 245px;
                position: absolute;
                height: 19px;
                width: 128px;
            }
        </style>
	
<script language="javascript" type="text/javascript">
// <!CDATA[

// ]]>
</script>
</head>
	<body>

    <div>
        <h2><i>Registo simples e rápido!!</i></h2>
    </div>
        <br />
        <br />
        <br />
    <div>
        Vantagens de ser utilizador registado:
        <p>*Votar positiva ou negativamente nas praias, hoteis ou restaurantes</p>
        <p>*Comentar mas pode receber resposta privada sobre as praias, hoteis ou restaurantes que comentou</p>
        <p>*Participar em discussões no forum, para além de partilhar imagens, criar album online sobre visitas</p>
        <p>*Interagir com os outros utilizadores em tempo real através do chat</p>
    </div>
        <br />
        <br />
        <br />
    <hr />
    	<form id="form2" runat="server">
<!-- Cadastrar-se, ou seja, registar-se no sistema de login T_T melhor colocar na parte do admin... -->
  <br>
  <br>
  <br>
    <div align="left"> 
     <font face='Vani'>
        <fieldset style="width: 654px; top: 415px; left: 173px; position: absolute; height: 332px;">
      		<br>
      		<font face='Vani'>
      		
  
    <!-- Continuação do formulário T_~... --> 
     
    	    </font><br>
      		<br>
      		<br>
      		<br>
      		            Username:<font face='Vani'><asp:TextBox ID="txtlogin" runat="server" style="width: 154px; top: 144px; left: 89px; position: absolute; height: 16px"></asp:TextBox>
     </font><br>
      		            Password:<br>
            Primeiro nome:
            <div align="right" style="width: 650px; top: 394px; left: -8px; position: absolute; height: 24px"><font size="2"><i>* Campos o* Campos obrigatorios</i></font></div>
     <font face='Vani'>
    	            <asp:TextBox ID="txtpnome" runat="server"></asp:TextBox>
     </font>
            <br />
            Apelido:<font face='Vani'><asp:TextBox ID="txtunome" runat="server"></asp:TextBox>
     </font>
                    <br />
            Email:<font face='Vani'><asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
     </font>
                    <br />
     <font face='Vani'>
    	    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                style="width: 56px; top: 352px; left: 278px; position: absolute; height: 26px" 
                Text="Registar" />
     </font>
        </fieldset>
     </font>
    <br>
    <br>
    <div class="footer">
      <table align='center' cellpadding='2' cellspacing='2'>
    <tr>
      <td bgcolor=#FFF align=center height="50" width="150"><marquee behavior="alternate" scrollamount="1"><font color="#66ffff">Voltar a Home</font></marquee><font face='Vani'><asp:TextBox ID="txtpassword" runat="server" style="top: 39px; left: 219px; position: absolute; height: 19px; width: 151px"></asp:TextBox>
     </font>
            </td>
      <td bgcolor=#FFF align=center height="50" width="50"><a href="Index.aspx" title="Ir para LoginZone"><img src='images/home.png' height='50' width='50'></a></td>
    </tr>
      </table>
    </div>
    <br>
    <br>
     </form>
     </body>
