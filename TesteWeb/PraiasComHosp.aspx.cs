using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DbBeach;

namespace TesteWeb
{
    public partial class PraiasComHosp : System.Web.UI.Page
    {

        BDQuery novaquery = new BDQuery();

        protected void Page_Load(object sender, EventArgs e)
        {
            ltres.Text += "<table align='center' border='1'><tr>" +
                       "<td bgcolor=rgb(255,255,255) align=center><b>Praia</b></td>" +
                       "<td bgcolor=rgb(255,255,255) align=center><b>Detalhes(Praia)</b></td>" +
                       "<td bgcolor=rgb(255,255,255) align=center><b>Restaurante</b></td>" +
                       "<td bgcolor=rgb(255,255,255) align=center><b>Detalhes(Rest.)</b></td>" +
                       "<td bgcolor=rgb(255,255,255) align=center><b>Distancia(metros)</b></td></tr>";

            ltres.Text += novaquery.VerPraiasComHotel();

            ltres.Text += "</table>";
        }
    }
}