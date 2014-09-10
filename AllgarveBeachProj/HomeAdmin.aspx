<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomeAdmin.aspx.cs" Inherits="AllgarveBeach.HomeAdmin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
<link rel="stylesheet" type="text/css" href="CSS/defs.css">
    <title>Untitled Page</title>
    <style type="text/css">
        .footer
        {
            height: 70px;
            
        }
        .auto-style1 {
            height: 26px;
        }
        .auto-style2 {
            width: 118px;
        }
        .auto-style3 {
            height: 26px;
            width: 118px;
        }
        .auto-style4 {
            width: 83px;
        }
        .auto-style5 {
            width: 83px;
            height: 26px;
        }
        .auto-style6 {
            width: 73px;
        }
        .auto-style7 {
            width: 73px;
            height: 26px;
        }
        .auto-style8 {
            width: 70px;
        }
        .auto-style9 {
            width: 70px;
            height: 26px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">

    <div style="text-align:center"><h1>Área de Administração<asp:Label ID="lblsession2" runat="server" Text="Ola"></asp:Label>
            <asp:Label ID="lblsessao2" runat="server" Font-Bold="True" ForeColor="Red" 
                Text="Ola"></asp:Label>
    </div>
        
    <div style="top: 70px; left: 10px; position: absolute; height: 167px; width: 1002px">
    <!-- Invenção estilo groupbox eheh T_~  aqui para a parte das promoções/descontos... -->

        <asp:panel ID="Panel1" runat="server">
            <fieldset style="width:150px; top: 33px; left: 455px; position: absolute; height: 180px;">
                <legend>
                    <h5>
                        Praias</h5>
                </legend>
                <table style="width:100%;">
                    <tr>
                        <td>
                            <asp:label id="lblinserirPraia" runat="server" text="Inserir:" ></asp:label>
                        </td>
                        <td>
                            <asp:ImageButton ID="btnInserirPraia" runat="server" Width="66px" 
                                ImageUrl="images/botaoinserir.png" Height="26px" OnClick="btnInserirPraia_Click"/>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:label id="lblapagarPraia" runat="server" text="Apagar:" ></asp:label>
                        </td>
                        <td>
                            <asp:ImageButton ID="btnApagarPraia" runat="server" Width="66px" 
                                ImageUrl="images/botaoapagar.png" Height="26px" OnClick="btnApagarPraia_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:label id="lblmodPraia" runat="server" text="Modificar:" ></asp:label>
                        </td>
                        <td>
                            <asp:ImageButton ID="btnModPraia" runat="server"  Width="66px" 
                                ImageUrl="images/botaomodificar.png" Height="26px" OnClick="btnModPraia_Click"/>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:label id="lblverPraia" runat="server" text="Visualizar:" ></asp:label>
                        </td>
                        <td>
                            <asp:ImageButton ID="btnVerPraia" runat="server" Width="66px" 
                                ImageUrl="images/botaoverificar.png" Height="26px" OnClick="btnVerPraia_Click"/>
                        </td>
                    </tr>
                </table>
            </fieldset><fieldset 
                style="width:150px; top: 33px; left: 233px; position: absolute; height: 180px;">
                <legend>
                    <h5>
                        Freguesias</h5>
                </legend>
                <table style="width:100%;">
                    <tr>
                        <td>
                            <asp:Label ID="lblinserirFreg" runat="server" text="Inserir:"></asp:Label>
                        </td>
                        <td>
                            <asp:ImageButton ID="btnInserirFreg" runat="server" Width="66px" 
                                ImageUrl="images/botaoinserir.png" Height="26px" OnClick="btnInserirFreg_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblapagarFreg" runat="server" text="Apagar:"></asp:Label>
                        </td>
                        <td>
                            <asp:ImageButton ID="btnApagarFreg" runat="server" Width="66px" 
                                ImageUrl="images/botaoapagar.png" Height="26px" OnClick="btnApagarFreg_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblmodFreg" runat="server" text="Modificar:"></asp:Label>
                        </td>
                        <td>
                            <asp:ImageButton ID="btnModFreg" runat="server"  Width="66px" 
                                ImageUrl="images/botaomodificar.png" Height="26px" OnClick="btnModFreg_Click"/>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblverFreg" runat="server" text="Visualizar:"></asp:Label>
                        </td>
                        <td>
                            <asp:ImageButton ID="btnVerFreg" runat="server" Width="66px" 
                                ImageUrl="images/botaoverificar.png" Height="26px" OnClick="btnVerFreg_Click"/>
                        </td>
                    </tr>
                </table>
            </fieldset><fieldset 
                style="width:150px; top: 33px; left: 13px; position: absolute; height: 180px;">
                <legend>
                    <h5>
                        Concelhos</h5>
                </legend>
                <table style="width:100%;">
                    <tr>
                        <td>
                            <asp:Label ID="lblinserirConc" runat="server"  text="Inserir:"></asp:Label>
                        </td>
                        <td>
                            <asp:ImageButton ID="btnInserirConc" runat="server" Width="66px" 
                                ImageUrl="images/botaoinserir.png" Height="26px" OnClick="btnInserirConc_Click"/>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblapagarConc" runat="server" text="Apagar:"></asp:Label>
                        </td>
                        <td>
                            <asp:ImageButton ID="btnApagarCon" runat="server" Width="66px" 
                                ImageUrl="images/botaoapagar.png" Height="26px" OnClick="btnApagarCon_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblmodConc" runat="server" text="Modificar:"></asp:Label>
                        </td>
                        <td>
                            <asp:ImageButton ID="btnModConc" runat="server" Width="66px" 
                                ImageUrl="images/botaomodificar.png" Height="26px" OnClick="btnModConc_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:Label ID="lblverConc" runat="server" text="Visualizar:"></asp:Label>
                        </td>
                        <td>
                            <asp:ImageButton ID="btnVerConc" runat="server" Width="66px" 
                                ImageUrl="images/botaoverificar.png" Height="26px" OnClick="btnVerConc_Click"/>
                        </td>
                    </tr>
                </table>
            </fieldset>
            <fieldset style="width:150px; top: 33px; left: 677px; position: absolute; height: 180px;">
                <legend>
                    <h5>
                        Hospedagem</h5>
                </legend>
                <table style="width:100%;">
                    <tr>
                        <td>
                            <asp:label id="lblinserirHospe" runat="server" text="Inserir:" ></asp:label>
                        </td>
                        <td>
                            <asp:ImageButton ID="btnInsereHospe" runat="server" Width="66px" 
                                ImageUrl="images/botaoinserir.png" Height="26px" OnClick="btnInsereHospe_Click"/>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:label id="lblapagarHospe" runat="server" text="Apagar:" ></asp:label>
                        </td>
                        <td>
                            <asp:ImageButton ID="btnApagarHospe" runat="server" Width="66px" 
                                ImageUrl="images/botaoapagar.png" Height="26px" OnClick="btnApagarHospe_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:label id="lblmodHospe" runat="server" text="Modificar:" ></asp:label>
                        </td>
                        <td>
                            <asp:ImageButton ID="btnModHospe" runat="server"  Width="66px" 
                                ImageUrl="images/botaomodificar.png" Height="26px" OnClick="btnModHospe_Click"/>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:label id="lblverHospe" runat="server" text="Visualizar:" ></asp:label>
                        </td>
                        <td>
                            <asp:ImageButton ID="btnVerHospe" runat="server" Width="66px" 
                                ImageUrl="images/botaoverificar.png" Height="26px" OnClick="btnVerHospe_Click"/>
                        </td>
                    </tr>
                </table>
            </fieldset>
            <fieldset style="width:150px; top: 33px; left: 901px; position: absolute; height: 180px;">
                <legend>
                    <h5>
                        Restaurantes</h5>
                </legend>
                <table style="width:100%;">
                    <tr>
                        <td>
                            <asp:label id="lblinserirRest" runat="server" text="Inserir:" ></asp:label>
                        </td>
                        <td>
                            <asp:ImageButton ID="btnInserirRest" runat="server" Width="66px" 
                                ImageUrl="images/botaoinserir.png" Height="26px" OnClick="btnInserirRest_Click"/>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:label id="lblapagarRest" runat="server" text="Apagar:" ></asp:label>
                        </td>
                        <td>
                            <asp:ImageButton ID="btnApagarRest" runat="server" Width="66px" 
                                ImageUrl="images/botaoapagar.png" Height="26px" OnClick="btnApagarRest_Click" />
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:label id="lblmodRest" runat="server" text="Modificar:" ></asp:label>
                        </td>
                        <td>
                            <asp:ImageButton ID="btnModRest" runat="server"  Width="66px" 
                                ImageUrl="images/botaomodificar.png" Height="26px" OnClick="btnModRest_Click"/>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <asp:label id="lblverRest" runat="server" text="Visualizar:" ></asp:label>
                        </td>
                        <td>
                            <asp:ImageButton ID="btnVerRest" runat="server" Width="66px" 
                                ImageUrl="images/botaoverificar.png" Height="26px" OnClick="btnVerRest_Click"/>
                        </td>
                    </tr>
                </table>
            </fieldset>
            <hr />

            
            </asp:panel>
            </div>

          <br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><br /><hr />
        <p>
            <asp:Label ID="Label1" runat="server" Text="ID:"></asp:Label>
            <asp:TextBox ID="txtID" runat="server" Width="40px"></asp:TextBox>
&nbsp;&nbsp; (Nota: Para Apagar basta inserir o ID e clicar no botão apagar pretendido. Para 
            modificar insere-se ID,</p>
        <p>
            preenche-se o respectivo questionário e clica-se no 
            respectivo botão modificar,para inserir basta fazer como na modificação,omo na modificação,mas a 
            colocação do campo ID é desnecessária. Para visualizar coloca-se ID e carrega-se 
            no respectivo botão verificar).</p>
        <br />

        <!-- METADE DE BAIXO DA PAGINA-->


        <div style="width:100%; height:320px">        
            <fieldset 
                style="width:170px; position:absolute; margin-left:20px; height: 70px;">
                <legend>
                    <h5>
                        Concelho</h5>
                </legend>
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style1">
                            Nome:</td>
                        <td class="auto-style1">
                            <asp:TextBox ID="txtNomeConcelho" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </fieldset>

            <fieldset 
                style="width:210px; position:absolute; margin-left:250px; height: 160px;">
                <legend>
                    <h5>
                        Restaurantes</h5>
                </legend>
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style6">
                            Praia+Prox:</td>
                        <td class="auto-style4">
                            <asp:TextBox ID="txtPraiaMaProxR" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">
                            Nome:</td>
                        <td class="auto-style5">
                            <asp:TextBox ID="txtNomeRest" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">
                            Morada:</td>
                        <td class="auto-style5">
                            <asp:TextBox ID="txtMoradaRest" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">
                            Dist_Praia:</td>
                        <td class="auto-style4">
                            <asp:TextBox ID="txtDistPraiaRest" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </fieldset>
            <fieldset
 
                style="width:210px; position:absolute; margin-left:520px; height: 220px;">
                <legend>
                    <h5>
                        Hospedagem</h5>
                </legend>
                <table style="width:100%;">
                    <tr>
                        <td class="auto-style6">
                            Praia+Prox:</td>
                        <td class="auto-style8">
                            <asp:TextBox ID="txtPraiaMaProxH" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">
                            Nome:</td>
                        <td class="auto-style9">
                            <asp:TextBox ID="txtNomeHosp" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style7">
                            Morada:</td>
                        <td class="auto-style9">
                            <asp:TextBox ID="txtMoradaHosp" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">
                            Dist_Praia:</td>
                        <td class="auto-style8">
                            <asp:TextBox ID="txtDistPraia" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                                        <tr>
                        <td class="auto-style6">
                            Estrelas:</td>
                        <td class="auto-style8">
                            <asp:TextBox ID="txtClassifHosp" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style6">
                            É_Camping:</td>
                        <td class="auto-style8">
                            <asp:TextBox ID="txtCampingHosp" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                </table>
            </fieldset>
            <fieldset 
     
                style="width:210px; position:absolute; margin-left:790px; height: 305px;">
                <legend>
                    <h5>
                        Praias</h5>
                </legend>
                <table style="width:100%;">
                    <tr>
                        <td>
                            Fregesia:</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtFregPraia" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            Nome:</td>
                        <td class="auto-style3">
                            <asp:TextBox ID="txtNomePraia" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td class="auto-style1">
                            Morada:</td>
                        <td class="auto-style3">
                            <asp:TextBox ID="txtMoradaPraia" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Extensao:</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtExtenPraia" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Band_Azul:</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtBandAzul" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Temp_Agua:</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtTempAgua" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Só_Barco:</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtSoBarco" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                                        <tr>
                        <td>
                            Hospedagem:</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtPHospedagem" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Restaurante:</td>
                        <td class="auto-style2">
                            <asp:TextBox ID="txtPRestaurante" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    </table>
            </fieldset>
            <fieldset 
                
                style="width:210px; position:absolute; margin-left:1060px; height: 100px;">
                <legend>
                    <h5>
                        Freguesias</h5>
                </legend>
                <table style="width:100%;">
                    <tr>
                        <td>
                            Nome:</td>
                        <td>
                            <asp:TextBox ID="txtNomeFreg" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            Concelho:</td>
                        <td>
                            <asp:TextBox ID="txtconcelhFreg" runat="server" Width="100px"></asp:TextBox>
                        </td>
                    </tr>
                    </table>
            </fieldset>
        </div>
    <br />
    
        <div class="footer">
      <table align='center' cellpadding='2' cellspacing='2'>
    <tr>
      <td bgcolor=#FFF align=center height="50" width="150"><marquee behavior="alternate" scrollamount="1"><font color="#66ffff">Voltar a Home</font></marquee></td>
      <td bgcolor=#FFF align=center height="50" width="50"><a href="Home.aspx" title="Ir para Home"><img src='images/home.png' height='50' width='50'></a></td>
    </tr>
      </table>
    </div>
        <br />
        <br />
        <br />
        <br />
        <br />
            <asp:Literal ID="ltresultados" runat="server"></asp:Literal>
            
    </form>
    
    <br />
</body>
</html>
