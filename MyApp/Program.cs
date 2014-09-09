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
           /* var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            Clientes NewCliente = new Clientes()
            {
                PNome = "Rui",
                UNome = "Andrade",
                Username = "Jnobre",
                Password = "senha",
                EMail = "julio.nobre@mail.com"


            };

            db.Clientes.InsertOnSubmit(NewCliente);

            db.SubmitChanges();

            var TargetCliente = db.Clientes.SingleOrDefault(x => x.IDcliente == 2);

            TargetCliente.PNome += "x";

            db.SubmitChanges();

            var TodosOsClientes = from c in db.Clientes
                                  select c;

            var TodosEmList = TodosOsClientes.ToList();

            TodosEmList.ForEach(x =>
            {
                Console.WriteLine(x.PNome);
            });

            foreach (var Cliente in TodosOsClientes)
            {
                Console.WriteLine(Cliente.PNome);
            }


            db.Clientes.DeleteAllOnSubmit(TodosOsClientes);

             */
        }
    }
}
