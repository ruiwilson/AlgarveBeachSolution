<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Albufeira_PraiaDaOura.aspx.cs" Inherits="AllgarveBeach.PerfilPraia.Albufeira_PraiaDaOura" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Praia da oura (Albufeira)</title>
</head>
<body>
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
<p><b>Praia da oura</b></p>
<br />
        <div align="center">
	<ul id="myGallery">
		<li><img src="http://static.panoramio.com/photos/large/51385448.jpg" alt="Praia da oura" />
		<li><img src="http://estaticos.guiadacidade.pt/foto2/data/media/4/AlgarvePraiaOura1_resize.JPG" alt="Praia da oura" />
		<li><img src="http://www.algarve-portal.com/objects/algarve/PraiaOura03_486.jpg" alt="Praia da oura" />
		<li><img src="http://c10.quickcachr.fotos.sapo.pt/i/obc041e3b/6755363_bTRE4.jpeg" alt="Praia da oura" />
	</ul>
<p>
    <asp:Table runat="server" BackColor="LightCyan" BorderStyle="Ridge">
        <asp:TableRow>
            <asp:TableCell><asp:Label ID="lblDimtxt" runat="server" BorderStyle="Outset" Text="Dimensão:"></asp:Label></asp:TableCell>
            <asp:TableCell><asp:Label ID="lblDim" runat="server" BorderStyle="Inset" Text="111m"></asp:Label></asp:TableCell>
            <asp:TableCell>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</asp:TableCell>
            <asp:TableCell><asp:ImageButton ID="Votopos" runat="server" ImageUrl="/images/pos.png" Height="35" Width="35"/></asp:TableCell>
            <asp:TableCell><asp:Label ID="lblpos" runat="server" BorderStyle="Inset" Text="111"></asp:Label></asp:TableCell>
            <asp:TableCell><asp:ImageButton ID="Votoneg" runat="server" ImageUrl="/images/neg.png" Height="35" Width="35"/></asp:TableCell>         
            <asp:TableCell><asp:Label ID="lblneg" runat="server" BorderStyle="Inset" Text="111"></asp:Label></asp:TableCell>
        </asp:TableRow>
    </asp:Table>
</p>
<asp:Table runat="server" BackColor="LightCyan" BorderStyle="Ridge">
    <asp:TableRow>
        <asp:TableCell><img src="/images/bazul.jpg" />  <asp:Label ID="lblBdazultxt" runat="server" BorderStyle="Outset" Text="Bandeira Azul:"></asp:Label></asp:TableCell>
        <asp:TableCell>  <asp:Label ID="lblBdazul" runat="server" BorderStyle="Inset" Text="Sim"></asp:Label></asp:TableCell>
        <asp:TableCell>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</asp:TableCell>
        <asp:TableCell><img src="/images/chuveiros.jpg" />  <asp:Label ID="lblChuveirostxt" runat="server" BorderStyle="Outset" Text="Chuveiros:"></asp:Label></asp:TableCell>
        <asp:TableCell>  <asp:Label ID="lblChuveiros" runat="server" BorderStyle="Inset" Text="Não"></asp:Label></asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell><img src="/images/pedonal.jpg" />  <asp:Label ID="lblPedonaltxt" runat="server" BorderStyle="Outset" Text="Acesso Pedonal:"></asp:Label></asp:TableCell>
        <asp:TableCell>  <asp:Label ID="lblPedonal" runat="server" BorderStyle="Inset" Text="Sim:"></asp:Label></asp:TableCell>
        <asp:TableCell>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</asp:TableCell>
        <asp:TableCell><img src="/images/defi.jpg" />  <asp:Label ID="lblDeficientxt" runat="server" BorderStyle="Outset" Text="Acesso p/Inválidos:"></asp:Label></asp:TableCell>
        <asp:TableCell>  <asp:Label ID="lblDeficien" runat="server" BorderStyle="Inset" Text="Sim"></asp:Label></asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell><img src="/images/parkitxt.jpg" />  <asp:Label ID="lblpark" runat="server" BorderStyle="Outset" Text="Parking:"></asp:Label></asp:TableCell>
        <asp:TableCell>  <asp:Label ID="lblparki" runat="server" BorderStyle="Inset" Text="Sim:"></asp:Label></asp:TableCell>
        <asp:TableCell>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</asp:TableCell>
        <asp:TableCell><img src="/images/resta.jpg" />  <asp:Label ID="lblrestaurtxt" runat="server" BorderStyle="Outset" Text="Restaurante(-500m):"></asp:Label></asp:TableCell>
        <asp:TableCell>  <asp:Label ID="lblrest" runat="server" BorderStyle="Inset" Text="Sim"></asp:Label></asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell><img src="/images/animais.jpg" />  <asp:Label ID="lblanimtxt" runat="server" BorderStyle="Outset" Text="Permite Animais:"></asp:Label></asp:TableCell>
        <asp:TableCell>  <asp:Label ID="lblanim" runat="server" BorderStyle="Inset" Text="Não"></asp:Label></asp:TableCell>
        <asp:TableCell>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</asp:TableCell>
        <asp:TableCell><img src="/images/tolds.jpg" />  <asp:Label ID="lbltoldtxt" runat="server" BorderStyle="Outset" Text="Aluguer de Toldos:"></asp:Label></asp:TableCell>
        <asp:TableCell>  <asp:Label ID="lbltold" runat="server" BorderStyle="Inset" Text="Não"></asp:Label></asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell><img src="/images/nadador.jpg" />  <asp:Label ID="lblnadadtxt" runat="server" BorderStyle="Outset" Text="Nadador Salvador:"></asp:Label></asp:TableCell>
        <asp:TableCell>  <asp:Label ID="lblnadad" runat="server" BorderStyle="Inset" Text="Dimensão:"></asp:Label></asp:TableCell>
        <asp:TableCell>&nbsp&nbsp&nbsp&nbsp&nbsp&nbsp</asp:TableCell>
        <asp:TableCell><img src="/images/guardasolarea.jpg" />  <asp:Label ID="lblguarsoltxt" runat="server" BorderStyle="Outset" Text="Area Guarda-Sol:"></asp:Label></asp:TableCell>
        <asp:TableCell>  <asp:Label ID="Label1" runat="server" BorderStyle="Inset" Text="Não:"></asp:Label></asp:TableCell>
    </asp:TableRow>
    <asp:TableRow>
        <asp:TableCell><img src="/images/servicos.jpg" /> <asp:Label ID="lblservitxt" runat="server" BorderStyle="Outset" Text="Serviços:"></asp:Label></asp:TableCell>
        <asp:TableCell></asp:TableCell>
        <asp:TableCell>&nbsp&nbsp&nbsp<asp:Label ID="lblbar" runat="server" BorderStyle="Inset" Text="Bar"></asp:Label></asp:TableCell>
        <asp:TableCell>&nbsp&nbsp&nbsp<asp:Label ID="lblwc" runat="server" BorderStyle="Inset" Text="WC"></asp:Label></asp:TableCell>
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
