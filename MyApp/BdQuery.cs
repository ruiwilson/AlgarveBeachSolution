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


namespace MyApp
{
    public class BdQuery
    {
        //INSERIR

        public void InserirCliente(string PrimeiroNome, string UltimoNome, string UserName, string Password, string EMail)
        {
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            Clientes NewClientes = new Clientes()
            {
                Username = UserName,
                PNome = PrimeiroNome,
                UNome = UltimoNome,
                Password = Password,
                EMail = EMail
            };

            db.Clientes.InsertOnSubmit(NewClientes);

            db.SubmitChanges();
            db.Connection.Close();
        }

        public void InserirConcelho(string NomeConcelho)
        {
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            Concelho NewConcelho = new Concelho()
            {
                NomeConcelho = NomeConcelho
                
            };

            db.Concelho.InsertOnSubmit(NewConcelho);

            db.SubmitChanges();
            db.Connection.Close();
        }

        public void InserirFreguesia(int IDconcelho, string NomeFreguesia)
        {
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            Freguesias NewFreguesia = new Freguesias()
            {
                IDconcelho = IDconcelho,
                NomeFreguesia = NomeFreguesia

            };

            db.Freguesias.InsertOnSubmit(NewFreguesia);

            db.SubmitChanges();
            db.Connection.Close();
        }

        public void InserirPraia(int IDfreguesia, string NomePraia, string MoradaPraia, int ExtensaoPraia, Int16 BandeiraAzul, Int16 TemperaturaAgua, Int16 AcessoSoBarco, string Link)
        {
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            Praia NewPraia = new Praia()
            {
                IDfreguesia = IDfreguesia,
                NomePraia = NomePraia,
                MoradaPraia = MoradaPraia,
                ExtensaoPraia = ExtensaoPraia,
                BandeiraAzul = BandeiraAzul,
                TemperaturaAgua = TemperaturaAgua,
                AcessoSoBarco = AcessoSoBarco,
                Link = Link

            };

            db.Praia.InsertOnSubmit(NewPraia);

            db.SubmitChanges();
            db.Connection.Close();
        }

        public void InserirHospedagem(int IDpraia, string NomeHospe, string MoradaHospe, int DistanPraia, Int16 Classificacao, Int16 Camping, string Link)
        {
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            Hospedagem NewHospedagem = new Hospedagem()
            {
                IDpraia = IDpraia,
                NomeHospe = NomeHospe,
                MoradaHospe = MoradaHospe,
                DistanPraia = DistanPraia,
                Classificacao = Classificacao,
                Camping = Camping,
                Link=Link

            };

            db.Hospedagem.InsertOnSubmit(NewHospedagem);

            db.SubmitChanges();
            db.Connection.Close();
        }

        public void InserirRestaurante(int IDpraia, string NomeRest, string MoradaRest, int DistanPraia, string Link)
        {
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            Restaurantes NewRestaurante = new Restaurantes()
            {
                IDpraia = IDpraia,
                NomeRest = NomeRest,
                MoradaRest = MoradaRest,
                DistanPraia = DistanPraia,
                Link = Link

            };

            db.Restaurantes.InsertOnSubmit(NewRestaurante);

            db.SubmitChanges();
            db.Connection.Close();
        }

        //APAGAR

        public void ApagarCliente(int IDcliente)
        {
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var TargetCliente = db.Clientes.SingleOrDefault(x => x.IDcliente == IDcliente);
            db.Clientes.DeleteOnSubmit(TargetCliente);
            db.SubmitChanges();
            db.Connection.Close();
        }

        public void ApagarConcelho(int IDconcelho)
        {
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var TargetConcelho = db.Concelho.SingleOrDefault(x => x.IDconcelho == IDconcelho);
            db.Concelho.DeleteOnSubmit(TargetConcelho);
            db.SubmitChanges();
            db.Connection.Close();
        }

        public void ApagarFreguesia(int IDfreguesia)
        {
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var TargetFreguesia = db.Freguesias.SingleOrDefault(x => x.IDfreguesia == IDfreguesia);
            db.Freguesias.DeleteOnSubmit(TargetFreguesia);
            db.SubmitChanges();
            db.Connection.Close();
        }

        public void ApagarPraia(int IDpraia)
        {
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var TargetPraia = db.Praia.SingleOrDefault(x => x.IDpraia == IDpraia);
            db.Praia.DeleteOnSubmit(TargetPraia);
            db.SubmitChanges();
            db.Connection.Close();
        }

        public void ApagarHospe(int IDhospe)
        {
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var TargetHospe = db.Hospedagem.SingleOrDefault(x => x.IDhospe == IDhospe);
            db.Hospedagem.DeleteOnSubmit(TargetHospe);
            db.SubmitChanges();
            db.Connection.Close();
        }

        public void ApagarRestaurante(int IDrest)
        {
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var TargetRestaurante = db.Restaurantes.SingleOrDefault(x => x.IDrest == IDrest);
            db.Restaurantes.DeleteOnSubmit(TargetRestaurante);
            db.SubmitChanges();
            db.Connection.Close();
        }

        //EDITAR REGISTOS

        public void EditarCliente(int IDcliente, string PrimeiroNome, string UltimoNome, string UserName, string Password, string EMail)
        {
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var TargetCliente = db.Clientes.SingleOrDefault(x => x.IDcliente == IDcliente);

            TargetCliente.Username = UserName;
            TargetCliente.PNome = PrimeiroNome;
            TargetCliente.UNome = UltimoNome;
            TargetCliente.Password = Password;
            TargetCliente.EMail = EMail;

            db.SubmitChanges();
            db.Connection.Close();
        }

        public void EditarConcelho(int IDconcelho, string NomeConcelho)
        {
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var TargetConcelho = db.Concelho.SingleOrDefault(x => x.IDconcelho == IDconcelho);

            TargetConcelho.NomeConcelho = NomeConcelho;

            db.SubmitChanges();
            db.Connection.Close();
        }

        public void EditarFreguesia(int IDfreguesia, int IDconcelho, string NomeFreguesia)
        {
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var TargetFreguesia = db.Freguesias.SingleOrDefault(x => x.IDfreguesia == IDfreguesia);

            TargetFreguesia.IDconcelho = IDconcelho;
            TargetFreguesia.NomeFreguesia = NomeFreguesia;

            db.SubmitChanges();
            db.Connection.Close();
        }

        public void EditarPraia(int IDpraia, int IDfreguesia, string NomePraia, string MoradaPraia, int ExtensaoPraia, Int16 BandeiraAzul, Int16 TemperaturaAgua, Int16 AcessoSoBarco, int VotoPos, int VotoNeg, string Link)
        {
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var TargetPraia = db.Praia.SingleOrDefault(x => x.IDpraia == IDpraia);

            TargetPraia.IDfreguesia = IDfreguesia;
            TargetPraia.NomePraia = NomePraia;
            TargetPraia.MoradaPraia = MoradaPraia;
            TargetPraia.ExtensaoPraia = ExtensaoPraia;
            TargetPraia.BandeiraAzul = BandeiraAzul;
            TargetPraia.TemperaturaAgua = TemperaturaAgua;
            TargetPraia.AcessoSoBarco = AcessoSoBarco;
            TargetPraia.VotoPos = VotoPos;
            TargetPraia.VotoNeg = VotoNeg;
            TargetPraia.Link = Link;

            db.SubmitChanges();
            db.Connection.Close();
        }

        public void EditarHospedagem(int IDhospe, int IDpraia, string NomeHospe, string MoradaHospe, int DistanPraia, Int16 Classificacao, Int16 Camping, int VotoPos, int VotoNeg, string Link)
        {
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var TargetHospedagem = db.Hospedagem.SingleOrDefault(x => x.IDhospe == IDhospe);

            TargetHospedagem.IDpraia = IDpraia;
            TargetHospedagem.NomeHospe = NomeHospe;
            TargetHospedagem.MoradaHospe = MoradaHospe;
            TargetHospedagem.DistanPraia = DistanPraia;
            TargetHospedagem.Classificacao = Classificacao;
            TargetHospedagem.VotoPos = VotoPos;
            TargetHospedagem.VotoNeg = VotoNeg;
            TargetHospedagem.Link = Link;

            db.SubmitChanges();
            db.Connection.Close();
        }

        public void EditarRestaurante(int IDrest, int IDpraia, string NomeRest, string MoradaRest, int DistanPraia, int VotoPos, int VotoNeg, string Link )
        {
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var TargetRestaurante = db.Restaurantes.SingleOrDefault(x => x.IDrest == IDrest);

            TargetRestaurante.IDpraia = IDpraia;
            TargetRestaurante.NomeRest = NomeRest;
            TargetRestaurante.MoradaRest = MoradaRest;
            TargetRestaurante.DistanPraia = DistanPraia;
            TargetRestaurante.VotoPos = VotoPos;
            TargetRestaurante.VotoNeg = VotoNeg;
            TargetRestaurante.Link = Link;

            db.SubmitChanges();
            db.Connection.Close();
        }

        public string VerClientes()
        {
            string a = "";
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var TodosOsClientes = from c in db.Clientes
                                  select c;

            var TodosEmList = TodosOsClientes.ToList();

            /*TodosEmList.ForEach(x =>
            {
                Console.WriteLine(x.PNome);
            });*/

            foreach (var Cliente in TodosOsClientes)
            {
               a += Cliente.PNome + "<br />";
               
            }
            return a;
        }

    }
}
