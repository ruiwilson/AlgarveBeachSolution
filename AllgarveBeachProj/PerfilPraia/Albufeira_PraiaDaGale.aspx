<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Albufeira_PraiaDaGale.aspx.cs" Inherits="AllgarveBeach.PerfilPraia.Albufeira_PraiaDaGale" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Praia da galé (Albufeira)</title>
</head>
<body style="background-image:url(/images/beachbg.jpg)">
    <form id="form1" runat="server">

<script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jquery/1.7.1/jquery.min.js"></script>
<script type="text/javascript" src="https://ajax.googleapis.com/ajax/libs/jqueryui/1.8.18/jquery-ui.min.js"></script>

<!-- Second, add the Timer and Easing plugins -->
<script type="text/javascript" src="../js/jquery.timers-1.2.js"></script>
<script type="text/javascript" src="../js/jquery.easing.1.3.js"></script>

<!-- Third, add the GalleryView Javascript and CSS files -->
<script type="text/javascript" src="../js/jquery.galleryview-3.0-dev.js"></script>
<link type="text/css" rel="stylesheet" href="../css/jquery.galleryview-3.0-dev.css" />

<!-- Lastly, call the galleryView() function on your unordered list(s) -->
<script type="text/javascript">
    $(function () {
        $('#myGallery').galleryView();
    });
</script>
<br />
    <h1>Albufeira</h1>
<hr size='1'/>
<p><b>Praia da galé</b></p>
<br />
        <div align="center">
	<ul id="myGallery">
		<li><img src="http://2.bp.blogspot.com/-cPMtRPl64GY/UneZQVefcdI/AAAAAAAAAns/dGHFTlswjCc/s1600/NUMBER+ONE+BIKE++RENT+A+BIKE+IN+ALGARVE+CONTACT+US+Cycle+Hire+in+Loule+Vilamoura+quinta+do+Lago+Vale+do+Lobo+Dunas+Douradas+Vale+do+Garrao+Almancil+Albufeira+Olhos+de+Agua+Praia+da+Gale+Acoteias+Praia+da+Oura+Sao+Rafael+5.jpg" alt="Praia da galé" />
		<li><img src="http://www.cdpreisen.de/UserFiles/Image/Algarve%20albufeira%20praia%20da%20gale02%20600.jpg" alt="Praia da galé" />
		<li><img src="http://www.guiadacidade.pt/foto2/data/media/4/AlgarvePraiaGal1_resize.JPG" alt="Praia da galé" />
		<li><img src="http://www.sol-domus.com/wp-content/uploads/2012/10/praia-gale.jpg" alt="Praia da galé" />
	</ul>
<p>Dimensão: 300 metros</p>


<asp:Table runat="server" BackColor="LightCyan">
    <asp:TableRow>
        <asp:TableCell><img src="/images/bazul.jpg" />Bandeira azul:</asp:TableCell>
        <asp:TableCell>Sim</asp:TableCell>
        <asp:TableCell>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</asp:TableCell>
        <asp:TableCell><img src="/images/chuveiros.jpg" />Chuveiros:</asp:TableCell>
        <asp:TableCell>Não</asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell><img src="/images/pedonal.jpg" />Acesso pedonal fácil:</asp:TableCell>
        <asp:TableCell>Sim</asp:TableCell>
        <asp:TableCell>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</asp:TableCell>
        <asp:TableCell><img src="/images/defi.jpg" />Acesso deficientes:</asp:TableCell>
        <asp:TableCell>Sim</asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell><img src="/images/parki.jpg" />Parking gratuito:</asp:TableCell>
        <asp:TableCell>Sim</asp:TableCell>
        <asp:TableCell>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</asp:TableCell>
        <asp:TableCell><img src="/images/resta.jpg" />Restaurante(-500metros):</asp:TableCell>
        <asp:TableCell>Sim</asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell><img src="/images/animais.jpg" />Permite animais:</asp:TableCell>
        <asp:TableCell>Não</asp:TableCell>
        <asp:TableCell>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</asp:TableCell>
        <asp:TableCell><img src="/images/tolds.jpg" />Aluguer de toldos:</asp:TableCell>
        <asp:TableCell>Não</asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell><img src="/images/nadador.jpg" />Nadador salvador:</asp:TableCell>
        <asp:TableCell>Sim</asp:TableCell>
        <asp:TableCell>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</asp:TableCell>
        <asp:TableCell><img src="/images/guardasolarea.jpg" />Área de guarda-sóis:</asp:TableCell>
        <asp:TableCell>Não</asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell><img src="/images/servicos.jpg" />Serviços:</asp:TableCell>
        <asp:TableCell></asp:TableCell>
        <asp:TableCell>&nbsp&nbsp&nbspBar</asp:TableCell>
        <asp:TableCell>&nbsp&nbsp&nbspWC</asp:TableCell>
    </asp:TableRow>
</asp:Table>
</div>
<br />
    <hr size='1'/>
    <p>Escreva já a sua opinião</p>
    <asp:TextBox ID="ComentTesos" TextMode="multiline" Columns="50" Rows="5" runat="server"></asp:TextBox>
    <asp:Button ID="EnviarTesos" runat="server" Text="Enviar" OnClick="EnviarTesos_Click" />
    <br />
    <br />
    <br />
        <div align="center">
            <asp:Button ID="btnvertesos" runat="server" Height="20px" CausesValidation="False" OnClick="btnvertesos_Click" Text="Ver comentários" />
            <br />
            <asp:Button ID="btnocultartesos" runat="server" Height="20px" CausesValidation="False" OnClick="btnocultartesos_Click" Text="Ocultar" Width="143px" />
        </div>
    <br />
    <p>Comentários:</p>
    <asp:Literal ID="lttesos" runat="server"></asp:Literal>
	<br />
    <br />
	</form>
</body>
</html>
