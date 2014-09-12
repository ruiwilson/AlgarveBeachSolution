﻿using DbBeach;
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
        private int mIDpraia;
        private int mIDfreguesia;
        private string mNomePraia;
        private string mMoradaPraia;
        private int mExtensaoPraia;
        private int mBandeiraAzul;
        private int mTemperaturaAgua;
        private int mAcessoSoBarco;
        private int mVotoPosP;
        private int mVotoNegP;
        private string mLinkP;


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
                LinkP = Link

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
                DistanPraiaH = DistanPraia,
                Classificacao = Classificacao,
                Camping = Camping,
                LinkH = Link

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
                DistanPraiaR = DistanPraia,
                LinkR = Link

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
            TargetPraia.VotoPosP = VotoPos;
            TargetPraia.VotoNegP = VotoNeg;
            TargetPraia.LinkP = Link;

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
            TargetHospedagem.DistanPraiaH = DistanPraia;
            TargetHospedagem.Classificacao = Classificacao;
            TargetHospedagem.VotoPosH = VotoPos;
            TargetHospedagem.VotoNegH = VotoNeg;
            TargetHospedagem.LinkH = Link;

            db.SubmitChanges();
            db.Connection.Close();
        }

        public void EditarRestaurante(int IDrest, int IDpraia, string NomeRest, string MoradaRest, int DistanPraia, int VotoPos, int VotoNeg, string Link)
        {
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var TargetRestaurante = db.Restaurantes.SingleOrDefault(x => x.IDrest == IDrest);

            TargetRestaurante.IDpraia = IDpraia;
            TargetRestaurante.NomeRest = NomeRest;
            TargetRestaurante.MoradaRest = MoradaRest;
            TargetRestaurante.DistanPraiaR = DistanPraia;
            TargetRestaurante.VotoPosR = VotoPos;
            TargetRestaurante.VotoNegR = VotoNeg;
            TargetRestaurante.LinkR = Link;

            db.SubmitChanges();
            db.Connection.Close();
        }

        //VISUALIZAR TODAS AS TABELAS
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

        public string VerConcelho()
        {
            string a = "";
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var TodosConcelho = from c in db.Concelho
                                  select c;

            var TodosEmList = TodosConcelho.ToList();

            /*TodosEmList.ForEach(x =>
            {
                Console.WriteLine(x.PNome);
            });*/

            foreach (var c in TodosConcelho)
            {
                a += "<tr><td bgcolor=#ccffcc align=center>" + c.NomeConcelho + "</td>";

            }
            return a;
        }

        public string VerFreguesias()
        {
            string a = "";
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var TodasFreguesias = from f in db.Freguesias
                                  select f;

            var TodosEmList = TodasFreguesias.ToList();

            /*TodosEmList.ForEach(x =>
            {
                Console.WriteLine(x.PNome);
            });*/

            foreach (var f in TodasFreguesias)
            {
                a += "<tr><td bgcolor=#ccffcc align=center>" + f.IDconcelho + "</td>";
                a += "<tr><td bgcolor=#ccffcc align=center>" + f.NomeFreguesia + "</td>";
            }
            return a;
        }

        public string VerPraia()
        {
            string a = "";
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var TodasPraias = from p in db.Praia
                              select p;

            var TodosEmList = TodasPraias.ToList();

            /*TodosEmList.ForEach(x =>
            {
                Console.WriteLine(x.PNome);
            });*/
            foreach (var p in TodasPraias)
            {
                a += "<tr><td bgcolor=#ccffcc align=center>" + p.IDfreguesia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" + p.NomePraia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" + p.MoradaPraia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" + p.ExtensaoPraia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" + p.BandeiraAzul + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" + p.TemperaturaAgua + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" + p.AcessoSoBarco + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" + p.VotoPosP + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" + p.VotoNegP + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" + p.LinkP + "</td>";
            }
            return a;
        }

        public string VerPraia(int idpraia)
        {
            string a = "";
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var TodasPraias = from p in db.Praia
                              where p.IDpraia == idpraia
                                  select p;

            var TodosEmList = TodasPraias.ToList();

            /*TodosEmList.ForEach(x =>
            {
                Console.WriteLine(x.PNome);
            });*/
            foreach (var p in TodasPraias)
            {
                a += "<tr><td bgcolor=#ccffcc align=center>" + p.IDfreguesia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" + p.NomePraia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" + p.MoradaPraia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" + p.ExtensaoPraia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" + p.BandeiraAzul + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" + p.TemperaturaAgua + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" + p.AcessoSoBarco + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" + p.VotoPosP + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" + p.VotoNegP + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" + p.LinkP + "</td>";
            }
            return a;
        }

        public void VerPraiaTeste(int idpraia)
        {
            //string a = "";
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var TodasPraias = from p in db.Praia
                              where p.IDpraia == idpraia
                              select p;

            var TodosEmList = TodasPraias.ToList();

            /*TodosEmList.ForEach(x =>
            {
                Console.WriteLine(x.PNome);
            });*/
            foreach (var p in TodasPraias)
            {
                /*a += "<tr><td bgcolor=#ccffcc align=center>" + p.IDfreguesia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" + p.NomePraia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" + p.MoradaPraia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" + p.ExtensaoPraia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" + p.BandeiraAzul + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" + p.TemperaturaAgua + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" + p.AcessoSoBarco + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" + p.VotoPosP + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" + p.VotoNegP + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" + p.LinkP + "</td>";*/
                this.IDfreguesia = p.IDfreguesia;
                this.NomePraia = p.NomePraia;
                this.MoradaPraia = p.MoradaPraia;
                this.ExtensaoPraia = p.ExtensaoPraia;
                this.BandeiraAzul = p.BandeiraAzul;
                this.TemperaturaAgua = p.TemperaturaAgua;
                this.AcessoSoBarco = p.AcessoSoBarco;
                this.VotoPosP = Convert.ToInt32(p.VotoPosP);
                this.VotoNegP = Convert.ToInt32(p.VotoNegP);
                this.LinkP = p.LinkP;
            }
           // return a;
        }

        public string VerHospedagem()
        {
            string a = "";
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var TodasHospedagens = from h in db.Hospedagem
                              select h;

            var TodosEmList = TodasHospedagens.ToList();

            /*TodosEmList.ForEach(x =>
            {
                Console.WriteLine(x.PNome);
            });*/

            foreach (var h in TodasHospedagens)
            {
                a += "<tr><td bgcolor=#ccffcc align=center>" + h.IDpraia + "</td>";
                a += "<tr><td bgcolor=#ccffcc align=center>" + h.NomeHospe + "</td>";
                a += "<tr><td bgcolor=#ccffcc align=center>" + h.MoradaHospe + "</td>";
                a += "<tr><td bgcolor=#ccffcc align=center>" + h.DistanPraiaH + "</td>";
                a += "<tr><td bgcolor=#ccffcc align=center>" + h.Classificacao + "</td>";
                a += "<tr><td bgcolor=#ccffcc align=center>" + h.Camping + "</td>";
                a += "<tr><td bgcolor=#ccffcc align=center>" + h.VotoPosH + "</td>";
                a += "<tr><td bgcolor=#ccffcc align=center>" + h.VotoNegH + "</td>";
                a += "<tr><td bgcolor=#ccffcc align=center>" + h.LinkH + "</td>";
            }
            return a;
        }

        public string VerRestaurantes()
        {
            string a = "";
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var TodosRestaurantes = from r in db.Restaurantes
                              select r;

            var TodosEmList = TodosRestaurantes.ToList();

            /*TodosEmList.ForEach(x =>
            {
                Console.WriteLine(x.PNome);
            });*/

            foreach (var r in TodosRestaurantes)
            {
                a += "<tr><td bgcolor=#ccffcc align=center>" + r.IDpraia + "</td>";
                a += "<tr><td bgcolor=#ccffcc align=center>" + r.NomeRest + "</td>";
                a += "<tr><td bgcolor=#ccffcc align=center>" + r.MoradaRest + "</td>";
                a += "<tr><td bgcolor=#ccffcc align=center>" + r.DistanPraiaR + "</td>";
                a += "<tr><td bgcolor=#ccffcc align=center>" + r.VotoPosR + "</td>";
                a += "<tr><td bgcolor=#ccffcc align=center>" + r.VotoNegR + "</td>";
                a += "<tr><td bgcolor=#ccffcc align=center>" + r.LinkR + "</td>";
            }
            return a;
        }


        //PROCURAR PRAIAS SABENDO SE HÁ HOSPEDAGEM À DISTANCIA PRETENDIDA, SE TEM BANDEIRA OU NAO E A TEMPERATURA DA AGUA NO MOMENTO
        public string VerPraiasComHospTempBand(int IDPRAIA, int ValorDistancia, int ValorTemperatura, int ValorBandeira)
        {
            string a = "";

            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            //indicamos a base de dados
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var query = (from p in db.Praia
                         join h in db.Hospedagem on p.IDpraia equals h.IDpraia
                         where p.IDpraia == IDPRAIA && h.DistanPraiaH < ValorDistancia && p.TemperaturaAgua < ValorTemperatura && p.BandeiraAzul == ValorBandeira
                         select new
                         {
                             NomeHospedagem = h.NomeHospe,
                             NomePraia = p.NomePraia,
                             DistanPraiaH = h.DistanPraiaH,
                             LinkP = p.LinkP,
                             LinkH = h.LinkH,
                             Bandeira = p.BandeiraAzul,
                             TempAgua = p.TemperaturaAgua
                         });

            var TudoEmList = query.ToList();

            foreach (var Resultados in query)
            {
                a += "<tr><td bgcolor=#ccffcc align=center>" +
                  Resultados.NomePraia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                  Resultados.LinkP + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.NomeHospedagem + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.LinkH + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.TempAgua + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.Bandeira + "</td>";
            }
            return a;
        }



        //PROCURAR PRAIAS SABENDO SE HÁ RESTAURANTES À DISTANCIA PRETENDIDA, SE TEM BANDEIRA OU NAO E A TEMPERATURA DA AGUA NO MOMENTO
        public string VerPraiasComRestTempBand(int IDPRAIA, int ValorDistancia, int ValorTemperatura, int ValorBandeira)
        {
            string a = "";

            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            //indicamos a base de dados
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var query = (from p in db.Praia
                         join r in db.Restaurantes on p.IDpraia equals r.IDpraia
                         where p.IDpraia == IDPRAIA && r.DistanPraiaR < ValorDistancia && p.TemperaturaAgua < ValorTemperatura && p.BandeiraAzul == ValorBandeira
                         select new
                         {
                             NomeRestaurante = r.NomeRest,
                             NomePraia = p.NomePraia,
                             DistanPraiaR = r.DistanPraiaR,
                             LinkP = p.LinkP,
                             LinkR = r.LinkR,
                             Bandeira = p.BandeiraAzul,
                             TempAgua = p.TemperaturaAgua
                         });

            var TudoEmList = query.ToList();

            foreach (var Resultados in query)
            {
                a += "<tr><td bgcolor=#ccffcc align=center>" +
                  Resultados.NomePraia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                  Resultados.LinkP + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.NomeRestaurante + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.LinkR + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.TempAgua + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.Bandeira + "</td>";
            }
            return a;
        }



        //PROCURAR PRAIAS SABENDO SE HÁ RESTAURANTES E HOSPEDAGENS À DISTANCIA PRETENDIDA, SE TEM BANDEIRA OU NAO E A TEMPERATURA DA AGUA NO MOMENTO
        public string VerPraiasHospRestTempBand(int IDPRAIA, int ValorDistanciaH, int ValorDistanciaR, int ValorTemperatura, int ValorBandeira)
        {
            string a = "";

            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            //indicamos a base de dados
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var query = (from Hospedagem in db.Hospedagem
                         from Restaurantes in db.Restaurantes
                         where
                         Hospedagem.Praia.IDpraia == IDPRAIA &&
                         Hospedagem.DistanPraiaH < ValorDistanciaH &&
                         Restaurantes.DistanPraiaR < ValorDistanciaR &&
                         Hospedagem.Praia.TemperaturaAgua < ValorTemperatura &&
                         Hospedagem.Praia.BandeiraAzul == ValorBandeira
                         select new
                         {
                             Hospedagem.Praia.NomePraia,
                             Hospedagem.Praia.LinkP,
                             Restaurantes.NomeRest,
                             Restaurantes.LinkR,
                             Hospedagem.NomeHospe,
                             Hospedagem.LinkH,
                             Hospedagem.Praia.TemperaturaAgua,
                             Hospedagem.Praia.BandeiraAzul
                         });

            var TudoEmList = query.ToList();

            foreach (var Resultados in query)
            {
                a += "<tr><td bgcolor=#ccffcc align=center>" +
                  Resultados.NomePraia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                  Resultados.LinkP + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.NomeRest + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.LinkR + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.NomeHospe + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.LinkH + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.TemperaturaAgua + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.BandeiraAzul + "</td>";
            }
            return a;
        }


        //PROCURAR PRAIAS SABENDO SE HÁ RESTAURANTES À DISTANCIA PRETENDIDA, SE TEM BANDEIRA OU NAO E A TEMPERATURA DA AGUA NO MOMENTO
        /*public string VerPraiasComRestTempBand(int IDPRAIA, int ValorDistancia, int ValorTemperatura, int ValorBandeira)
            {
            string a = "";

            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            //indicamos a base de dados
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var query = (from p in db.Praia
                         join r in db.Restaurantes on p.IDpraia equals r.IDpraia
                         where p.IDpraia == IDPRAIA && r.DistanPraiaR < ValorDistancia && p.TemperaturaAgua < ValorTemperatura && p.BandeiraAzul == ValorBandeira
                         select new
                         {
                             NomeRestaurante = r.NomeRest,
                             NomePraia = p.NomePraia,
                             DistanPraiaR = r.DistanPraiaR,
                             LinkP = p.LinkP,
                             LinkR = r.LinkR,
                             Bandeira = p.BandeiraAzul,
                             TempAgua = p.TemperaturaAgua
                         });

            var TudoEmList = query.ToList();

            foreach (var Resultados in query)
            {
                a += "<tr><td bgcolor=#ccffcc align=center>" +
                  Resultados.NomePraia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                  Resultados.LinkP + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.NomeRestaurante + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.LinkR + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.TempAgua + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.Bandeira + "</td>";
            }
            return a;
        }*/
         
        //PROCURAR PRAIAS SABENDO SE HÁ HOSPEDAGEM À DISTANCIA PRETENDIDA, SE TEM BANDEIRA OU NAO E A TEMPERATURA DA AGUA NO MOMENTO
        public string VerTodasPraiasComHospTempBand(int ValorDistancia, int ValorTemperatura, int ValorBandeira)
        {
            string a = "";

            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            //indicamos a base de dados
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var query = (from p in db.Praia
                         join h in db.Hospedagem on p.IDpraia equals h.IDpraia
                         where h.DistanPraiaH < ValorDistancia && p.TemperaturaAgua < ValorTemperatura && p.BandeiraAzul == ValorBandeira
                         select new
                         {
                             NomeHospedagem = h.NomeHospe,
                             NomePraia = p.NomePraia,
                             DistanPraiaH = h.DistanPraiaH,
                             LinkP = p.LinkP,
                             LinkH = h.LinkH,
                             Bandeira = p.BandeiraAzul,
                             TempAgua = p.TemperaturaAgua
                         });

            var TudoEmList = query.ToList();

            foreach (var Resultados in query)
            {
                a += "<tr><td bgcolor=#ccffcc align=center>" +
                  Resultados.NomePraia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                  Resultados.LinkP + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.NomeHospedagem + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.LinkH + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.TempAgua + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.Bandeira + "</td>";
            }
            return a;
        }

        //PROCURAR PRAIAS SABENDO SE HÁ RESTAURANTES E HOSPEDAGENS À DISTANCIA PRETENDIDA, SE TEM BANDEIRA OU NAO E A TEMPERATURA DA AGUA NO MOMENTO
        /*public string VerPraiasHospRestTempBand(int IDPRAIA, int ValorDistanciaH, int ValorDistanciaR, int ValorTemperatura, int ValorBandeira)
        {
            string a = "";

            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            //indicamos a base de dados
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var query = (from Hospedagem in db.Hospedagem
                         from Restaurantes in db.Restaurantes
                         where
                         Hospedagem.Praia.IDpraia == IDPRAIA &&
                         Hospedagem.DistanPraiaH < ValorDistanciaH &&
                         Restaurantes.DistanPraiaR < ValorDistanciaR &&
                         Hospedagem.Praia.TemperaturaAgua < ValorTemperatura &&
                         Hospedagem.Praia.BandeiraAzul == ValorBandeira
                         select new
                         {
                             Hospedagem.Praia.NomePraia,
                             Hospedagem.Praia.LinkP,
                             Restaurantes.NomeRest,
                             Restaurantes.LinkR,
                             Hospedagem.NomeHospe,
                             Hospedagem.LinkH,
                             Hospedagem.Praia.TemperaturaAgua,
                             Hospedagem.Praia.BandeiraAzul
                         });

            var TudoEmList = query.ToList();

            foreach (var Resultados in query)
            {
                a += "<tr><td bgcolor=#ccffcc align=center>" +
                  Resultados.NomePraia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                  Resultados.LinkP + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.NomeRest + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.LinkR + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.NomeHospe + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.LinkH + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.TemperaturaAgua + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.BandeiraAzul + "</td>";
            }
            return a;
        }*/


        //PROCURAR PRAIAS SABENDO SE HÁ HOSPEDAGEM À DISTANCIA PRETENDIDA, SE TEM BANDEIRA OU NAO E A TEMPERATURA DA AGUA NO MOMENTO
        /*public string VerTodasPraiasComHospTempBand(int ValorDistancia, int ValorTemperatura, int ValorBandeira)
        {
            string a = "";

            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            //indicamos a base de dados
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var query = (from p in db.Praia
                         join h in db.Hospedagem on p.IDpraia equals h.IDpraia
                         where h.DistanPraiaH < ValorDistancia && p.TemperaturaAgua < ValorTemperatura && p.BandeiraAzul == ValorBandeira
                         select new
                         {
                             NomeHospedagem = h.NomeHospe,
                             NomePraia = p.NomePraia,
                             DistanPraiaH = h.DistanPraiaH,
                             LinkP = p.LinkP,
                             LinkH = h.LinkH,
                             Bandeira = p.BandeiraAzul,
                             TempAgua = p.TemperaturaAgua
                         });

            var TudoEmList = query.ToList();

            foreach (var Resultados in query)
            {
                a += "<tr><td bgcolor=#ccffcc align=center>" +
                  Resultados.NomePraia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                  Resultados.LinkP + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.NomeHospedagem + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.LinkH + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.TempAgua + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.Bandeira + "</td>";
            }
            return a;
        }*/



        //PROCURAR PRAIAS SABENDO SE HÁ RESTAURANTES À DISTANCIA PRETENDIDA, SE TEM BANDEIRA OU NAO E A TEMPERATURA DA AGUA NO MOMENTO
        public string VerTodasPraiasComRestTempBand(int ValorDistancia, int ValorTemperatura, int ValorBandeira)
        {
            string a = "";


            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");

            //indicamos a base de dados
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var query = (from p in db.Praia
                         join r in db.Restaurantes on p.IDpraia equals r.IDpraia
                         where r.DistanPraiaR < ValorDistancia && p.TemperaturaAgua < ValorTemperatura && p.BandeiraAzul == ValorBandeira
                         select new
                         {
                             NomeRestaurante = r.NomeRest,
                             NomePraia = p.NomePraia,
                             DistanPraiaR = r.DistanPraiaR,
                             LinkP = p.LinkP,
                             LinkR = r.LinkR,
                             Bandeira = p.BandeiraAzul,
                             TempAgua = p.TemperaturaAgua
                         });

            var TudoEmList = query.ToList();

            foreach (var Resultados in query)
            {
                a += "<tr><td bgcolor=#ccffcc align=center>" +
                  Resultados.NomePraia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                  Resultados.LinkP + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.NomeRestaurante + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.LinkR + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.TempAgua + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.Bandeira + "</td>";
            }
            return a;
        }



        //PROCURAR PRAIAS SABENDO SE HÁ RESTAURANTES E HOSPEDAGENS À DISTANCIA PRETENDIDA, SE TEM BANDEIRA OU NAO E A TEMPERATURA DA AGUA NO MOMENTO
        public string VerTodasPraiasHospRestTempBand(int ValorDistanciaH, int ValorDistanciaR, int ValorTemperatura, int ValorBandeira)
        {
            string a = "";

            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            //indicamos a base de dados
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var query = (from Hospedagem in db.Hospedagem
                         from Restaurantes in db.Restaurantes
                         where
                         Hospedagem.DistanPraiaH < ValorDistanciaH &&
                         Restaurantes.DistanPraiaR < ValorDistanciaR &&
                         Hospedagem.Praia.TemperaturaAgua < ValorTemperatura &&
                         Hospedagem.Praia.BandeiraAzul == ValorBandeira
                         select new
                         {
                             Hospedagem.Praia.NomePraia,
                             Hospedagem.Praia.LinkP,
                             Restaurantes.NomeRest,
                             Restaurantes.LinkR,
                             Hospedagem.NomeHospe,
                             Hospedagem.LinkH,
                             Hospedagem.Praia.TemperaturaAgua,
                             Hospedagem.Praia.BandeiraAzul
                         });

            var TudoEmList = query.ToList();

            foreach (var Resultados in query)
            {
                a += "<tr><td bgcolor=#ccffcc align=center>" +
                  Resultados.NomePraia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                  Resultados.LinkP + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.NomeRest + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.LinkR + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.NomeHospe + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.LinkH + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.TemperaturaAgua + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.BandeiraAzul + "</td>";
            }
            return a;
        }


        //PROCURAR PRAIAS DE DETERMINADA FREGUESIA SABENDO SE HÁ RESTAURANTES E HOSPEDAGENS À DISTANCIA PRETENDIDA, SE TEM BANDEIRA OU NAO E A TEMPERATURA DA AGUA NO MOMENTO
        public string VerTodasPraiasDeFreguesiaRestHostTempBand(int IDfreguesia, int ValorDistanciaR, int ValorDistanciaH, int ValorTemperatura, int ValorBandeira)
        {
            string a = "";

            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            //indicamos a base de dados
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var query = (from Hospedagem in db.Hospedagem
                         from Restaurantes in db.Restaurantes
                         where
                           Hospedagem.Praia.IDfreguesia == IDfreguesia &&
                           Hospedagem.DistanPraiaH < ValorDistanciaH &&
                           Restaurantes.DistanPraiaR < ValorDistanciaR &&
                           Hospedagem.Praia.TemperaturaAgua < 22 &&
                           Hospedagem.Praia.BandeiraAzul == 1
                         select new
                         {
                             Hospedagem.Praia.IDfreguesia,
                             Hospedagem.Praia.NomePraia,
                             Hospedagem.Praia.LinkP,
                             Restaurantes.NomeRest,
                             Restaurantes.LinkR,
                             Hospedagem.NomeHospe,
                             Hospedagem.LinkH,
                             Hospedagem.Praia.TemperaturaAgua,
                             Hospedagem.Praia.BandeiraAzul
                         });

            var TudoEmList = query.ToList();

            foreach (var Resultados in query)
            {
                a += "<tr><td bgcolor=#ccffcc align=center>" +
                  Resultados.NomePraia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                  Resultados.LinkP + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.NomeRest + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.LinkR + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.NomeHospe + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.LinkH + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.TemperaturaAgua + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.BandeiraAzul + "</td>";
            }
            return a;
        }


        //PROCURAR PRAIAS DE DETERMINADA FREGUESIA SABENDO SE HÁ RESTAURANTES À DISTANCIA PRETENDIDA, SE TEM BANDEIRA OU NAO E A TEMPERATURA DA AGUA NO MOMENTO
        public string VerTodasPraiasDeFreguesiaRestTempBand(int IDfreguesia, int ValorDistanciaR, int ValorTemperatura, int ValorBandeira)
        {
            string a = "";

            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            //indicamos a base de dados
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var query = (from p in db.Praia
                         join r in db.Restaurantes on p.IDpraia equals r.IDpraia
                         where p.IDfreguesia == IDfreguesia && r.DistanPraiaR < ValorDistanciaR && p.TemperaturaAgua < ValorTemperatura && p.BandeiraAzul == ValorBandeira
                         select new
                         {
                             IDfreguesia = p.IDfreguesia,
                             NomeRestaurante = r.NomeRest,
                             NomePraia = p.NomePraia,
                             DistanPraiaH = r.DistanPraiaR,
                             LinkP = p.LinkP,
                             LinkR = r.LinkR,
                             Bandeira = p.BandeiraAzul,
                             TempAgua = p.TemperaturaAgua
                         });

            var TudoEmList = query.ToList();

            foreach (var Resultados in query)
            {
                a += "<tr><td bgcolor=#ccffcc align=center>" +
                  Resultados.NomePraia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                  Resultados.LinkP + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.NomeRestaurante + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.LinkR + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.TempAgua + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.Bandeira + "</td>";
            }
            return a;
        }


        //PROCURAR PRAIAS SABENDO SE HÁ RESTAURANTES E HOSPEDAGENS À DISTANCIA PRETENDIDA, SE TEM BANDEIRA OU NAO E A TEMPERATURA DA AGUA NO MOMENTO
        /*public string VerTodasPraiasHospRestTempBand(int ValorDistanciaH, int ValorDistanciaR, int ValorTemperatura, int ValorBandeira)
            {
            string a = "";

            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            //indicamos a base de dados
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var query = (from Hospedagem in db.Hospedagem
                         from Restaurantes in db.Restaurantes
                         where
                         Hospedagem.DistanPraiaH < ValorDistanciaH &&
                         Restaurantes.DistanPraiaR < ValorDistanciaR &&
                         Hospedagem.Praia.TemperaturaAgua < ValorTemperatura &&
                         Hospedagem.Praia.BandeiraAzul == ValorBandeira
                         select new
                         {
                             Hospedagem.Praia.NomePraia,
                             Hospedagem.Praia.LinkP,
                             Restaurantes.NomeRest,
                             Restaurantes.LinkR,
                             Hospedagem.NomeHospe,
                             Hospedagem.LinkH,
                             Hospedagem.Praia.TemperaturaAgua,
                             Hospedagem.Praia.BandeiraAzul
                         });

            var TudoEmList = query.ToList();

            foreach (var Resultados in query)
            {
                a += "<tr><td bgcolor=#ccffcc align=center>" +
                  Resultados.NomePraia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                  Resultados.LinkP + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.NomeRest + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.LinkR + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.NomeHospe + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.LinkH + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.TemperaturaAgua + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.BandeiraAzul + "</td>";
            }
            return a;
        }*/

        //PROCURAR PRAIAS DE DETERMINADA FREGUESIA SABENDO SE HÁ HOSPEDAGENS À DISTANCIA PRETENDIDA, SE TEM BANDEIRA OU NAO E A TEMPERATURA DA AGUA NO MOMENTO
        public string VerTodasPraiasDeFreguesiaHospTempBand(int IDfreguesia, int ValorDistanciaH, int ValorTemperatura, int ValorBandeira)
        {
            string a = "";

            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            //indicamos a base de dados
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var query = (from p in db.Praia
                         join h in db.Hospedagem on p.IDpraia equals h.IDpraia
                         where p.IDfreguesia == IDfreguesia && h.DistanPraiaH < ValorDistanciaH && p.TemperaturaAgua < ValorTemperatura && p.BandeiraAzul == ValorBandeira
                         select new
                         {
                             IDfreguesia = p.IDfreguesia,
                             NomeHospedagem = h.NomeHospe,
                             NomePraia = p.NomePraia,
                             DistanPraiaH = h.DistanPraiaH,
                             LinkP = p.LinkP,
                             LinkH = h.LinkH,
                             Bandeira = p.BandeiraAzul,
                             TempAgua = p.TemperaturaAgua
                         });

            var TudoEmList = query.ToList();

            foreach (var Resultados in query)
            {
                a += "<tr><td bgcolor=#ccffcc align=center>" +
                  Resultados.NomePraia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                  Resultados.LinkP + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.NomeHospedagem + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.LinkH + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.TempAgua + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.Bandeira + "</td>";
            }
            return a;
        }


        //PROCURAR PRAIAS DE DETERMINADA FREGUESIA SABENDO SE HÁ RESTAURANTES E HOSPEDAGENS À DISTANCIA PRETENDIDA, SE TEM BANDEIRA OU NAO E A TEMPERATURA DA AGUA NO MOMENTO
        /*public string VerTodasPraiasDeFreguesiaRestHostTempBand(int IDfreguesia, int ValorDistanciaR, int ValorDistanciaH, int ValorTemperatura, int ValorBandeira)
        {
            string a = "";

            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            //indicamos a base de dados
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var query = (from Hospedagem in db.Hospedagem
                         from Restaurantes in db.Restaurantes
                         where
                           Hospedagem.Praia.IDfreguesia == IDfreguesia &&
                           Hospedagem.DistanPraiaH < ValorDistanciaH &&
                           Restaurantes.DistanPraiaR < ValorDistanciaR &&
                           Hospedagem.Praia.TemperaturaAgua < 22 &&
                           Hospedagem.Praia.BandeiraAzul == 1
                         select new
                         {
                             Hospedagem.Praia.IDfreguesia,
                             Hospedagem.Praia.NomePraia,
                             Hospedagem.Praia.LinkP,
                             Restaurantes.NomeRest,
                             Restaurantes.LinkR,
                             Hospedagem.NomeHospe,
                             Hospedagem.LinkH,
                             Hospedagem.Praia.TemperaturaAgua,
                             Hospedagem.Praia.BandeiraAzul
                         });

            var TudoEmList = query.ToList();

            foreach (var Resultados in query)
            {
                a += "<tr><td bgcolor=#ccffcc align=center>" +
                  Resultados.NomePraia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                  Resultados.LinkP + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.NomeRest + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.LinkR + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.NomeHospe + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.LinkH + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.TemperaturaAgua + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.BandeiraAzul + "</td>";
            }
            return a;
        }*/


        //PROCURAR PRAIAS DE DETERMINADA FREGUESIA SABENDO SE HÁ RESTAURANTES À DISTANCIA PRETENDIDA, SE TEM BANDEIRA OU NAO E A TEMPERATURA DA AGUA NO MOMENTO
        /*public string VerTodasPraiasDeFreguesiaRestTempBand(int IDfreguesia, int ValorDistanciaR, int ValorTemperatura, int ValorBandeira)
        {
            string a = "";

            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            //indicamos a base de dados
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var query = (from p in db.Praia
                         join r in db.Restaurantes on p.IDpraia equals r.IDpraia
                         where p.IDfreguesia == IDfreguesia && r.DistanPraiaR < ValorDistanciaR && p.TemperaturaAgua < ValorTemperatura && p.BandeiraAzul == ValorBandeira
                         select new
                         {
                             IDfreguesia = p.IDfreguesia,
                             NomeRestaurante = r.NomeRest,
                             NomePraia = p.NomePraia,
                             DistanPraiaH = r.DistanPraiaR,
                             LinkP = p.LinkP,
                             LinkR = r.LinkR,
                             Bandeira = p.BandeiraAzul,
                             TempAgua = p.TemperaturaAgua
                         });

            var TudoEmList = query.ToList();

            foreach (var Resultados in query)
            {
                a += "<tr><td bgcolor=#ccffcc align=center>" +
                  Resultados.NomePraia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                  Resultados.LinkP + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.NomeRestaurante + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.LinkR + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.TempAgua + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.Bandeira + "</td>";
            }
            return a;
        }*/

        //PROCURAR PRAIAS DE DETERMINADA FREGUESIA SABENDO SE HÁ HOSPEDAGENS À DISTANCIA PRETENDIDA, SE TEM BANDEIRA OU NAO E A TEMPERATURA DA AGUA NO MOMENTO
        /*public string VerTodasPraiasDeFreguesiaHospTempBand(int IDfreguesia, int ValorDistanciaH, int ValorTemperatura, int ValorBandeira)
        {
            string a = "";

            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            //indicamos a base de dados
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);

            var query = (from p in db.Praia
                         join h in db.Hospedagem on p.IDpraia equals h.IDpraia
                         where p.IDfreguesia == IDfreguesia && h.DistanPraiaH < ValorDistanciaH && p.TemperaturaAgua < ValorTemperatura && p.BandeiraAzul == ValorBandeira
                         select new
                         {
                             IDfreguesia = p.IDfreguesia,
                             NomeHospedagem = h.NomeHospe,
                             NomePraia = p.NomePraia,
                             DistanPraiaH = h.DistanPraiaH,
                             LinkP = p.LinkP,
                             LinkH = h.LinkH,
                             Bandeira = p.BandeiraAzul,
                             TempAgua = p.TemperaturaAgua
                         });

            var TudoEmList = query.ToList();

            foreach (var Resultados in query)
            {
                a += "<tr><td bgcolor=#ccffcc align=center>" +
                  Resultados.NomePraia + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                  Resultados.LinkP + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.NomeHospedagem + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.LinkH + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.TempAgua + "</td>";
                a += "<td bgcolor=#ccffcc align=center>" +
                    Resultados.Bandeira + "</td>";
            }
            return a;
        }*/

        /*      public string VerPraiasComHotelDistancia(int distancia)
              {
                  string a = "";

                  var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
                  //indicamos a base de dados
                  var db = new DbBeach.BaseDeDadosDataContext(ConnString);

                  var query = (from p in db.Praia
                               join h in db.Hospedagem on p.IDpraia equals h.IDpraia
                               select new
                               {
                                   NomeHospedagem = h.NomeHospe,
                                   NomePraia = p.NomePraia,
                                   DistanPraia = h.DistanPraiaH
                               }).Where(x => x.DistanPraia < distancia);

                  var TudoEmList = query.ToList();

                  foreach (var Resultados in query)
                  {
                      a += "<tr><td bgcolor=#ccffcc align=center>" +
                        Resultados.NomePraia + "</td>";
                      a += "<td bgcolor=#ccffcc align=center>" +
                          Resultados.NomeHospedagem + "</td>";
                      a += "<td bgcolor=#ccffcc align=center>" +
                          Resultados.DistanPraiaH + "</td>";
                  }
                  return a;
              }*/


        public string ProcurarTodosClientes()
        {
            string a = "";
            //abrimos ligação
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            //indicamos a base de dados
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);
            var TodosOsClientes = from c in db.Clientes
                                  select c;
            //enviamos os resultados para uma lista para poder usar um foreach
            var TodosEmList = TodosOsClientes.ToList();
            //assim apareceria na consola os primeiros nomes de todos os clientes

            foreach (var Cliente in TodosEmList)
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

        /*      public string VerPraiasComHotelDistancia(int distancia)
              {
                  string a = "";

                  var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
                  //indicamos a base de dados
                  var db = new DbBeach.BaseDeDadosDataContext(ConnString);

                  var query = (from p in db.Praia
                               join h in db.Hospedagem on p.IDpraia equals h.IDpraia
                               select new
                               {
                                   NomeHospedagem = h.NomeHospe,
                                   NomePraia = p.NomePraia,
                                   DistanPraia = h.DistanPraiaH
                               }).Where(x => x.DistanPraia < distancia);

                  var TudoEmList = query.ToList();

                  foreach (var Resultados in query)
                  {
                      a += "<tr><td bgcolor=#ccffcc align=center>" +
                        Resultados.NomePraia + "</td>";
                      a += "<td bgcolor=#ccffcc align=center>" +
                          Resultados.NomeHospedagem + "</td>";
                      a += "<td bgcolor=#ccffcc align=center>" +
                          Resultados.DistanPraiaH + "</td>";
                  }
                  return a;
              }*/


        /*public string ProcurarTodosClientes()
        {
            string a = "";
            //abrimos ligação
            var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");
            //indicamos a base de dados
            var db = new DbBeach.BaseDeDadosDataContext(ConnString);
            var TodosOsClientes = from c in db.Clientes
                                  select c;
            //enviamos os resultados para uma lista para poder usar um foreach
            var TodosEmList = TodosOsClientes.ToList();
            //assim apareceria na consola os primeiros nomes de todos os clientes

            foreach (var Cliente in TodosEmList)
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
        }*/


        /* public string VerPraiasComHotel()
         {
             string a = "";


             var ConnString = new SqlConnection(@"Server=VAIO-TSANTOS\SQLEXPRESS; Database=AlgarveBeach; User id=sa; Password=34419;");

             //indicamos a base de dados
             var db = new DbBeach.BaseDeDadosDataContext(ConnString);

             var query = (from p in db.Praia
                          join h in db.Hospedagem on p.IDpraia equals h.IDpraia
                          select new
                          {
                              NomeHospedagem = h.NomeHospe,
                              NomePraia = p.NomePraia
                          });

             var TudoEmList = query.ToList();

             foreach (var Resultados in query)
             {
                 a += "<tr><td bgcolor=#ccffcc align=center>" +
                   Resultados.NomePraia + "</td>";
                 a += "<td bgcolor=#ccffcc align=center>" +
                     Resultados.NomeHospedagem + "</td>";
             }
             return a;
         }*/

        //::::::::::::::::::::::Propriedades::::::::::::::::::::::::::::
        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        public int IDpraia
        {
            get { return mIDpraia; }
            set { mIDpraia = value; }
        }

        public int IDfreguesia
        {
            get { return mIDfreguesia; }
            set { mIDfreguesia = value; }
        }


        public string NomePraia
        {
            get { return mNomePraia; }
            set { mNomePraia = value; }
        }

        public string MoradaPraia
        {
            get { return mMoradaPraia; }
            set { mMoradaPraia = value; }
        }
        public int ExtensaoPraia
        {
            get { return mExtensaoPraia; }
            set { mExtensaoPraia = value; }
        }

        public int BandeiraAzul
        {
            get { return mBandeiraAzul; }
            set { mBandeiraAzul = value; }
        }

        public int TemperaturaAgua
        {
            get { return mTemperaturaAgua; }
            set { mTemperaturaAgua = value; }
        }

        public int AcessoSoBarco
        {
            get { return mAcessoSoBarco; }
            set { mAcessoSoBarco = value; }
        }

        public int VotoPosP
        {
            get { return mVotoPosP; }
            set { mVotoPosP = value; }
        }

        public int VotoNegP
        {
            get { return mVotoNegP; }
            set { mVotoNegP = value; }
        }

        public string LinkP
        {
            get { return mLinkP; }
            set { mLinkP = value; }
        }
    }
}
