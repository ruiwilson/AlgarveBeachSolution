using AlgarveBeach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AllgarveBeach
{
    public partial class Regist : System.Web.UI.Page
    {
        Cliente novocliente;
        protected void Page_Load(object sender, EventArgs e)
        {
            novocliente = new Cliente();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            novocliente.Username = txtlogin.Text;
            novocliente.Password = txtpassword.Text;
            novocliente.Nome = txtpnome.Text + " " + txtunome.Text;
            novocliente.Email = txtemail.Text;
            novocliente.InserirCliente();
        }
    }
}