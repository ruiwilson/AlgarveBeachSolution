<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProPraias.aspx.cs" Inherits="AllgarveBeach.ProPraias" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style>
        table.search{
            width:35%;
            margin-left:10%;
        }
    </style>

    <style>
        table.search1{
            width:30%;
            margin-left:10%;
        }
    </style>

</head>
<body>

    <form id="form1" runat="server">
    <div id="cf">
        <div style="text-align:center;">
        <img class="bottom" src="/CSS/praia1.jpg" width="700" height="300"  />
        <img class="top" src="/CSS/praia2.jpg" width="700" height="300" />
            
            </div>

    <br />
    <h2 style="color: blue; text-align: center; background-color:yellow;">Praias</h2>
    <br />

    

    <table style="width:100%">
        <tr>
            <td>
                <table class="search1">

            <tr>
                <td>Concelho:
                    <asp:DropDownList ID="DConcelho" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDown_Concelho">
                    </asp:DropDownList></td>
                 
                <td>
                     Freguesia:
                    <asp:DropDownList ID="DFreguesia" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDown_Freguesia">
                     </asp:DropDownList></td>
                 
                <td>
                     Praias:
                     <asp:DropDownList ID="DPraia" runat="server" OnSelectedIndexChanged="DropDown_Praia">
                    </asp:DropDownList>
         
                </td>
                <td style="vertical-align:bottom">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Pesquisar" />
                </td>
            </tr>

        </table>
            </td>
            <td>
                <table class="search" >
                    <tr>
                        <td>Hospedagem</td><td>Restaurantes</td><td>Temperatura</td><td>Bandeira Azul</td>
                    </tr>
                    <tr>
                       <td>
                         <asp:DropDownList ID="DHospedagem" runat="server" OnSelectedIndexChanged="DropDown_Hospedagem">
                            </asp:DropDownList>
                        </td>
                        <td>
                           <asp:DropDownList ID="DRestaurante" runat="server" OnSelectedIndexChanged="DropDown_Restaurante">
                           </asp:DropDownList>
                       </td>
                       <td>
                          <asp:DropDownList ID="DTemperatura" runat="server" OnSelectedIndexChanged="DropDown_Temperatura">
                         </asp:DropDownList>
                        </td>
                       <td>
                          <asp:DropDownList ID="DBandeira" runat="server" OnSelectedIndexChanged="DropDown_Bandeira">
                          </asp:DropDownList>
                        </td>
                        <td>
                            <asp:Button ID="Button2" runat="server" Text="Pesquisar" OnClick="Button2_Click" />
                        </td>
                   </tr>   
              </table>    
                 </td>
              </tr>
            </table>
        
        <br /><br /><br />

        <table align="center">
            <tr>
                <td>
                    <asp:Literal ID="Literal1" runat="server"></asp:Literal><br />
                </td>
            </tr>

        </table>
        

    </div>
    </form>

    
</body>
</html>

