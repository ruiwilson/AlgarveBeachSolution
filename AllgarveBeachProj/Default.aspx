<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AllgarveBeach.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" type="text/css" href="CSS/defs.css" />

    <style>

table.align{
    width: 30%;
    margin-left:35%; 
    margin-right:35%;
}

table, th, td {

    border: 0px solid black;
    border-collapse: collapse;
}

th, td {
    padding: 5px;
    text-align: center;    
}

table {
    border-spacing: 15px;
}

</style>

    <link href="themes/1/js-image-slider.css" rel="stylesheet" type="text/css" />
    <script src="themes/1/js-image-slider.js" type="text/javascript"></script>
    <link href="generic.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <div class="div1">
        <p><a href="demo1.html" class="current"></a><a href="demo2.html"></a><a href="demo3.html"></a><a href="demo4.html"></a>
        <a href="demo5.html"></a><a href="demo6.html"></a><a href="demo7.html"></a><a href="demo8.html"></a></p>
    </div>

    <div id="sliderFrame">
        <div id="slider">
            <a href="http://www.menucool.com/javascript-image-slider" target="_blank">
                <img src="images/Praia0.jpg" alt="Monte Clérigo (ALJEZUR)" />
            </a>
            <img src="images/Praia1.jpg" alt="Mareta (SAGRES)" />
            <img src="images/Praia2.jpg" alt="Praia do Camilo (LAGOS)" />
            <img src="images/Praia3.jpg" alt="Praia da Rocha (PORTIMAO)" />
            <img src="images/Praia4.jpg" alt="Barranco das Belharucas (ALBUFEIRA)" />
            <img src="images/Praia5.jpg" alt="Falésia (VILAMOURA)" />
            <img src="images/Praia6.jpg" alt="Praia de Faro (FARO)" />
            <img src="images/Praia7.jpg" alt="Praia do Barril (TAVIRA)" />
            <img src="images/Praia8.jpg" alt="Praia Verde (Vila Real Sto. António)" />
        </div>
        <div id="htmlcaption" style="display: none;">
            <em>HTML</em> caption. Link to <a href="http://www.google.com/">Google</a>.
        </div>
    </div>
    <!--<div id="cf" align="center">
        <img class="bottom" src="/CSS/praia1.jpg" width="700" height="300" />&nbsp;
    </div> -->



    <br />
    <h1 style="color: blue;text-align: center;">As Melhores Praias do Algarve!</h1>
    <br />

    <form id="form1" runat="server">
    <div>
        
        <div style="font-size: 14px;text-align: right;";>Não está registado? <a href="www.fffsdf.com">Registe-se aqui!</a></div>
        <div style="text-align: right;color: black;"><b>Utilizador:</b> 
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <b>Password: </b>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <br />
            <a href="http://www.w3schools.com">
                Login</a>
        </div>
       <hr />

       <br />
        <table class="align">
        <tr>
            <td><a href="www.gggg.com">Praias</a></td>
            <td><a href="Web.config">Galeria</a></td>
            <td><a href="www.ggg.com">Forum</a></td>
        </tr>
       </table>

    </div>
    </form>
</body>
</html>