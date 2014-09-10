using DbBeach;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyApp;

namespace TesteWeb
{
    public partial class TesteForm : System.Web.UI.Page
    {
        BdQuery db = new BdQuery();
        BdQuery query = new BdQuery();

        protected void Page_Load(object sender, EventArgs e)
        {
           
            
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //query.InserirCliente(txtPNome.Text, txtUNome.Text, txtUserName.Text, txtPassword.Text, txtEMail.Text);
            Literal1.Text = query.VerClientes();
        }

        
           
    }
}