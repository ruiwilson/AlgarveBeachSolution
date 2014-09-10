using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Reflection;
using DbBeach;


namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            JoinDuasTabelas();


            //abrimos ligação
            var ConnString = new SqlConnection(@"Server=LAP-TSUNAMI\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=1234;");
            //indicamos a base de dados
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);
            //criamos via codigo um novo cliente
            Clientes NewCliente = new Clientes()
            {
                PNome = "Tiago",
                UNome = "Santos",
                Username = "Tsantos",
                Password = "senha2",
                EMail = "tiago_santos@gmail.com"


            };
            //inserimos virtualmente um novo cliente
            db.Clientes.InsertOnSubmit(NewCliente);
            //inserimos efetivamente na base de dados esse mesmo cliente
            db.SubmitChanges();







            //procuramos por um ou nenhum cliente, caso seja single tem de ser obrigatoriamente um
            //o resultado, caso queiramos colecçao haveria de se por db.Clientes.Where etcetc..
            var TargetCliente = db.Clientes.SingleOrDefault(x => x.IDcliente == 2);
            //Assim adicionariamos um x ao primeiro nome do cliente com idcliente=2
            TargetCliente.PNome += "x";
            //inserimos efetivamente na base de dados as novas modificações
            db.SubmitChanges();

            //lemos os dados de todos os clientes
            var TodosOsClientes = from c in db.Clientes
                                  select c;
            //enviamos os resultados para uma lista para poder usar um foreach
            var TodosEmList = TodosOsClientes.ToList();
            //assim apareceria na consola os primeiros nomes de todos os clientes
            TodosEmList.ForEach(x =>
            {
                Console.WriteLine(x.PNome);
            });

            //assim apagariamso todos os clientes
            db.Clientes.DeleteAllOnSubmit(TodosOsClientes);

             
        }

        public static string JoinDuasTabelas()
        {
            string a = "";

            var ConnString = new SqlConnection(@"Server=LAP-TSUNAMI\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=1234;");
            //indicamos a base de dados
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var query = (from p in db.Praia
                         join h in db.Hospedagem on p.IDpraia equals h.IDpraia
                         select new
                         {
                             NomeHospedagem = h.NomeHospe,
                             NomePraia = p.NomePraia,
                             DistanPraia = h.DistanPraia
                         }).Where(x => x.DistanPraia < 500);

            var TudoEmList = query.ToList();

            foreach (var Resultados in query)
            {
                a += "<tr><td bgcolor=#ccffcc align=center>" +
                  Resultados.NomePraia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.NomeHospedagem + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.DistanPraia + "</td>";
            }
            return a;
        }
    }
}
