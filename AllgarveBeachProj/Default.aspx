<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AllgarveBeach.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

<style>
      html, body, #map-canvas {
        height: 100%;
        margin: 0px;
        padding: 0px
      }
    </style>

    <title></title>
    
    <link rel="stylesheet" href="css/style.css" type="text/css" />
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
    <br />
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
        
        <section id="container">

<div id="menu"><!-- Menu starts here -->

<ul class="menu"><!-- List starts here -->

	<li><a href="#">Quem somos</a><!-- 5 columns starts here -->
    
       <div class="dropdown-5columns"><!-- Container 5 columns starts here -->
        
        <div class="col-5">            
                <p>Home</p>
            </div>
        
            <div class="col-5">
                <h2>Quem Somos</h2>
            </div>
            
            <div class="textblock">
                AlgarveBeach nasceu da ideia de centralizar todas as praias algarvias numa só página web
                com o intuito de que o visitante possa aceder à praia com as características pelas quais ele
                irá procurar utilizando as buscas pretendidas (pode procurar praias com hóteis, bares ou
                restaurantes a determinada distância ou saber qual a praia com melhor temperatura de água
                de todo o algarve, dando assim ao visitante um grande apoio na hora de escolher a praia ideal
                para passar o dia ou fim de semana.
            </div>
        
        </div><!-- 5 columns ends here -->
    
    </li><!-- Container 5 columns ends here -->
    
     <li><a href="#">Praias</a><!-- 4 columns starts here -->
    
        <div class="dropdown-4columns"><!-- Container 4 columns starts here -->
        
            <div class="col-4">
                <h2>Algumas das principais praias</h2>
            </div>
            
            <div class="col-1">
            
                <ul class="blue">
                    <li><a href="#"><b>Portimão</b></a></li>
                    <li><a href="/perfilPraia/Portimao_PraiaDaRocha.aspx">Praia da Rocha</a></li>
                    <li><a href="/perfilPraia/Portimao_PraiaDoVau.aspx">Praia do Vau</a></li>
                    <li><a href="/perfilPraia/Portimao_PraiaDoAlvor.aspx">Praia do Alvor</a></li>
                </ul>   
                 
            </div>
    
            <div class="col-1">          
                <ul class="blue">
                    <li><a href="#"><b>Albufeira</b></a></li>
                    <li><a href="/perfilPraia/Albufeira_PraiaDaGale.aspx">Praia da Galé</a></li>
                    <li><a href="/perfilPraia/Albufeira_PraiaDaOura.aspx">Praia da Oura</a></li>
                    <li><a href="/perfilPraia/Albufeira_PraiaSaoRafael.aspx">Praia São Rafael</a></li>
                </ul>           
            </div>
    
            <div class="col-1">
            
                <ul class="blue">
                    <li><a href="#"><b>Olhão</b></a></li>
                    <li><a href="#">Ilha do Farol</a></li>
                    <li><a href="#">Ilha da Armona</a></li>
                    <li><a href="#">Praia dos Tesos</a></li>
                </ul>   
                 
            </div>
    
            <div class="col-1">
            
                <ul class="blue">
                    <li><a href="#"><b>Vila Real Stº António</b></a></li>
                    <li><a href="#">Praia da Alagoa</a></li>
                    <li><a href="#">Praia Verde</a></li>
                    <li><a href="#">Praia do Cabeço</a></li>
                </ul>   
                 
            </div>
            
             <div class="col-3">
                
                <p class="textblock"><img src="images/barlavento.jpg" width="152" height="152" class="imgclass2" alt="" />Barlavento<a href="#">Ver lista.</a></p>
        
                <p class="textblock"><img src="images/sotavento.jpg" width="152" height="152" class="imgclass2" alt="" />Sotavento<a href="#">Ver lista.</a></p>
            
            </div>
            
            <div class="col-1">
                <p class="blackbox"><b><i>Não encontrou a praia desejada?<br />Aceda já à nossa praia principal e efetue a busca desejada
                    tendo acesso a um serciço de busca que lhe permite facilmente aceder à praia com as características pretendidas!<br /><a><b>ACEDER</b></a>
                                       </i></b></p>
            </div>
            
        </div><!-- 4 columns ends here -->
    
    </li><!-- Container 4 columns ends here -->
    
    <li><a href="#">Galerias</a><!-- 3 columns starts here -->
    
        <div class="dropdown-3columns align_right"><!-- Container 3 columns starts here -->
            
            <div class="col-2">
                <h2>Conheça já os melhores serviços!</h2>
            </div>
            
            <div class="col-1">
    
                <ul class="grisbox">
                    <li><a href="#" title="Home">Praias</a></li>
                    <li><a href="#" title="About Us">Restaurantes</a></li>
                    <li><a href="#" title="Images">Hoteis</a></li>
                    <li><a href="#" title="Sign in">Campings</a></li>
                </ul>   
    
            </div>
            
            <div class="col-1">
    
                <p class="italic blackbox">Nota: Futuramente poderá colocar as suas fotos e ajudar a crescer a comunidade AlgarveBeach</p> 
    
            </div>
        
        </div><!-- 3 columns ends here -->
        
    </li><!-- Container 3 columns ends here -->
    
    <li><a href="#">Forum</a><!-- 2 columns starts here -->
    
        <div class="dropdown-2columns"><!-- Container 2 columns starts here -->
   
            
            <div class="col-1">
    
                <img src="images/img.png" width="70" height="70" class="imgclass" alt="" />
                <p class="text"><a href="#">Brevemente online</a></p>   
    
            </div>
          
        </div><!-- 2 columns ends here -->
    
    </li><!-- Container 2 columns ends here -->

	<li><a href="#">Contactos</a><!-- 1 column starts here -->
    
		<div class="dropdown-1column align_right"><!-- Container 1 column starts here -->
        
                <div class="col-5">
                
                    <ul class="grisbox">
                        <li><a href="#" title="Tlf">Telefone:289700200</a></li>
                        <li><a href="#" title="Tlm96">Tlm96:962343241</a></li>
                        <li><a href="#" title="Tlm91">Tlm91:912442342</a></li>
                        <li><a href="#" title="Tlm93">Tlm93:934225522</a></li>
                        <li><a href="#" title="EmailAdmin"><font size='1'>webadmin@algarvebeach.com</font></a></li>
                        <li><a href="#" title="EmailGeral"><font size='1'>geral@algarvebeach.com</font></a></li>
                    </ul>   
                     
                </div>
                
		</div><!-- 1 column ends here -->  
	</li><!-- Container 1 columnn ends here -->

  </ul><!-- List ends here -->

</div><!-- Menu ends here -->
</section>


<!-- ligação de like's do face para o site e vice versa T_~
        <fb:like href="http://praias.sapo.pt/praias/algarve/portimao/alemao" class=" fb_iframe_widget" 
fb-xfbml-state="rendered" fb-iframe-plugin-query="app_id=112121252159772&amp;
            href=http%3A%2F%2Fpraias.sapo.pt%2Fpraias%2Falgarve%2Fportimao%2Falemao&amp;locale=en_US&amp;sdk=joey">
<span style="vertical-align: bottom; width: 450px; height: 20px;">
<iframe name="f2de1de5cc" width="1000px" height="1000px" frameborder="0" allowtransparency="true" scrolling="no" title="fb:like Facebook Social Plugin" 
    src="http://www.facebook.com/plugins/like.php?app_id=112121252159772&amp;channel=http%3A%2F%2Fstatic.ak.facebook.com%2Fconnect%2Fxd_arbiter%2FZEbdHPQfV3x.js%3Fversion%3D41%23cb%3Df24e3eacb8%26domain%3Dpraias.sapo.pt%26origin%3Dhttp%253A%252F%252Fpraias.sapo.pt%252Ff1c7fa6b98%26relation%3Dparent.parent&amp;href=http%3A%2F%2Fpraias.sapo.pt%2Fpraias%2Falgarve%2Fportimao%2Falemao&amp;locale=en_US&amp;sdk=joey" 
    style="border: none; visibility: visible; width: 450px; height: 20px;" class=""></iframe></span></fb:like>
        */-->

        

        </div>
        <asp:Literal ID="ltmap" runat="server"></asp:Literal>

        

    </form>
</body>
</html>

