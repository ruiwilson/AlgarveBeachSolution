using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DbBeach;

namespace TesteWeb
{
    public partial class Admin : System.Web.UI.Page
    {
        BDQuery novaquery = new BDQuery();

        protected void Page_Load(object sender, EventArgs e)
        {
            ltres.Text += "<table align='center' border='1'><tr>" +
            "<td bgcolor=rgb(255,255,255) align=center><b>Código</b></td>" +
            "<td bgcolor=rgb(255,255,255) align=center><b>Nome</b></td>" +
            "<td bgcolor=rgb(255,255,255) align=center><b>Apelido</b></td>" +
            "<td bgcolor=rgb(255,255,255) align=center><b>Username</b></td>" +
            "<td bgcolor=rgb(255,255,255) align=center><b>Password</b></td>" +
            "<td bgcolor=rgb(255,255,255) align=center><b>Email</b></td></tr>";

            ltres.Text += novaquery.ProcurarTodosClientes();

            ltres.Text += "</table>";
        }
    }
}