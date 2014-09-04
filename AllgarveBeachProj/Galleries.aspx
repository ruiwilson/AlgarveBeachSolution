<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Galleries.aspx.cs" Inherits="AllgarveBeach.Galleries" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
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
</head>
<body>
<br />
    <h1>Galeria das melhores praias algarvias</h1>
<br />
<br />
<br />
<br />
<hr />
<p><b>Praia dos tesos(Fuseta - Olhão)</b></p>
<br />
	<ul id="myGallery">
		<li><img src="http://fotos.sapo.pt/FsY5SE2fzZQzc6QazBOJ/" alt="Praia dos tesos" />
		<li><img src="http://3.bp.blogspot.com/_ndRSDl0GAtg/TEV-7oqRlZI/AAAAAAAABLQ/17NtAdOh4RM/s1600/004.JPG" alt="Praia dos tesos" />
		<li><img src="http://2.bp.blogspot.com/_KyjCl24TcC4/TFs6l7eJoqI/AAAAAAAAAz0/rODuhXDWy2Q/s1600/DSCF0974.JPG" alt="Praia dos tesos" />
		<li><img src="http://static.panoramio.com/photos/large/48979565.jpg" alt="Praia dos tesos" />
	</ul>
<p>Dimensão: 300 metros</p>
<p>Bandeira azul: Sim</p>
<p>Serviços(-de 1Km): Restaurantes, cafés, camping, multibanco, lojas</p>
    <hr />
    <p>Escreva já a sua opinião</p>
    <asp:TextBox ID="ComentTesos" TextMode="multiline" Columns="50" Rows="5" runat="server" /></asp:TextBox>
    <asp:Button ID="EnviarTesos" runat="server" Text="Enviar" OnClick="EnviarTesos_Click" />
    <p>Comentários:</p>
    <asp:Literal ID="lttesos" runat="server"></asp:Literal>
	</form>
</body>
</html>