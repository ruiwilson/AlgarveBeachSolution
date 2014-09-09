using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbBeach;

namespace DbBeach
{
    public class BDQuery
    {

        public void InserirCliente(string prinome, string ultnome, string user, string pass, string mail)
        {
           
            //abrimos ligação
            var ConnString = new SqlConnection(@"Server=LAP-TSUNAMI\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=1234;");
            //indicamos a base de dados
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);
            //criamos via codigo um novo cliente
            Clientes NewCliente = new Clientes()
            {
                PNome = prinome,
                UNome = ultnome,
                Username = user,
                Password = pass,
                EMail = mail
            };
            //inserimos virtualmente um novo cliente
            db.Clientes.InsertOnSubmit(NewCliente);
            //inserimos efetivamente na base de dados esse mesmo cliente
            db.SubmitChanges();
            db.Connection.Close();
        }

        public void ApagarClientePorID(int IDCLIENTE)
        {
            //abrimos ligação
            var ConnString = new SqlConnection(@"Server=LAP-TSUNAMI\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=1234;");
            //indicamos a base de dados
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);
            var TargetCliente = db.Clientes.SingleOrDefault(x => x.IDcliente == IDCLIENTE);
            db.Clientes.DeleteOnSubmit(TargetCliente);
            db.SubmitChanges();
            db.Connection.Close();
        }

        public void EditarCliente(int IDCliente, string Pnome,string Unome,string UserName,string PassWord,string Email)
        {
            //abrimos ligação
            var ConnString = new SqlConnection(@"Server=LAP-TSUNAMI\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=1234;");
            //indicamos a base de dados
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);       
            var ClienteAeditar = db.Clientes.SingleOrDefault(x => x.IDcliente == IDCliente);
            ClienteAeditar.PNome = Pnome;
            ClienteAeditar.UNome = Pnome;
            ClienteAeditar.Username = UserName;
            ClienteAeditar.Password = PassWord;
            ClienteAeditar.EMail = Email;
            db.SubmitChanges();
            db.Connection.Close();
        }
/*
        public void ProcurarClientes()
        {
            //abrimos ligação
            var ConnString = new SqlConnection(@"Server=LAP-TSUNAMI\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=1234;");
            //indicamos a base de dados
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);
            var ClientesAprocurar = from Clientes in db.GetTable<Clientes>() select Clientes;
            
        }*/

        public string ProcurarTodosClientes()
        {
            string a = "";
            //abrimos ligação
            var ConnString = new SqlConnection(@"Server=LAP-TSUNAMI\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=1234;");
            //indicamos a base de dados
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);
            var TodosOsClientes = from c in db.Clientes
                                  select c;
            //enviamos os resultados para uma lista para poder usar um foreach
            var TodosEmList = TodosOsClientes.ToList();
            //assim apareceria na consola os primeiros nomes de todos os clientes
          
            foreach(var Cliente in TodosEmList)
            {
                a += "<tr><td bgcolor=#ccffcc align=center>" +
                  Convert.ToString(Cliente.IDcliente) +
                  "</td><td bgcolor=#ccffcc align=center>" +
                          Cliente.PNome + "</td>";
              a += "<td bgcolor=#ccffcc align=center>" +
                  Cliente.UNome + "</td>";
              a += "<td bgcolor=#ccffcc align=center>" +
                  Cliente.Username + "</td>";
              a += "<td bgcolor=#ccffcc align=center>" +
                  Cliente.Password + "</td>";
              a += "<td bgcolor=#ccffcc align=center>" +
                  Cliente.EMail + "</td>";
            }
            return a;
        }
    }
}