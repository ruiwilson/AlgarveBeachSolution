using DbBeach;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Linq.Expressions;
using System.Reflection;



namespace TesteWeb
{
    public partial class TestForm : System.Web.UI.Page
    {
        BDQuery novaquery = new BDQuery();

        protected void Page_Load(object sender, EventArgs e)
        {
            ltmostrar.Text += "<table align='center' border='1'><tr>" +
             "<td bgcolor=rgb(255,255,255) align=center><b>Código</b></td>" +
             "<td bgcolor=rgb(255,255,255) align=center><b>Nome</b></td>" +
             "<td bgcolor=rgb(255,255,255) align=center><b>Apelido</b></td>" +
             "<td bgcolor=rgb(255,255,255) align=center><b>Username</b></td>" +
             "<td bgcolor=rgb(255,255,255) align=center><b>Password</b></td>" +
             "<td bgcolor=rgb(255,255,255) align=center><b>Email</b></td></tr>";

            ltmostrar.Text += novaquery.ProcurarTodosClientes();

            ltmostrar.Text += "</table>";
        }

        private void MessageBox(string msg)
        {
            Label lblMessage = new Label();
            lblMessage.Text = "<script language='javascript'>" + Environment.NewLine + "window.alert('" + msg + "')</script>";
            Page.Controls.Add(lblMessage);
        }

        protected void brninserir_Click(object sender, EventArgs e)
        {
            novaquery.InserirCliente(pnome.Text, unome.Text, username.Text, password.Text, email.Text);
            MessageBox("Cliente inserido com sucesso!");
        }

        protected void btnApagar_Click(object sender, EventArgs e)
        {
            novaquery.ApagarClientePorID(Convert.ToInt32(IDcliente.Text));
            MessageBox("Cliente apagado com sucesso!");
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            novaquery.EditarCliente(Convert.ToInt32(IDcliente.Text),pnome.Text, unome.Text, username.Text, password.Text, email.Text);
            MessageBox("Cliente editado com sucesso!");
        }

       
    }
}