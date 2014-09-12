using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgarveBeach
{
    public class GestaoPraias
    {
        //CARREGAR CONCELHO ID
        /*public Concelho[] CarregarConcelhoID(string nomeconcelho)
        {
            string[] campos = { "NomeConcelho" };
            AcessoBD aBD = new AcessoBD("VAIO-TSANTOS" + "\\" + "SQLEXPRESS", "AlgarveBeach", "sa", "34419");
            DataTable dt = aBD.LerTabela("Concelho", "NomeConcelho", nomeconcelho);
            Concelho[] arrConcelho = new Concelho[dt.Rows.Count];
            int i = 0;
            foreach (DataRow rw in dt.Rows)
            {
                Concelho c = new Concelho();

                c.NomeConcelho = Convert.ToString(rw["NomeConcelho"]);

                arrConcelho[i] = c;
                i++;
            }
            return arrConcelho;
        }*/

        //Método para carregar CONSELHO       FUNCIONA!!!
        public Concelho[] CarregarConcelho()
        {
            string[] campos = { "NomeConcelho" };
            AcessoBD aBD = new AcessoBD(@"VAIO-TSANTOS\SQLEXPRESS", "AlgarveBeach", "sa", "34419;");
            DataTable dt = aBD.LerTabelaCompletaOrdem("Concelho", "NomeConcelho", "ASC");
            Concelho[] arrConcelho = new Concelho[dt.Rows.Count];
            int i = 0;
            foreach (DataRow rw in dt.Rows)
            {
                Concelho c = new Concelho();

                c.NomeConcelho = Convert.ToString(rw["NomeConcelho"]);

                arrConcelho[i] = c;
                i++;
            }
            return arrConcelho;
        }

        //Método para carregar FREGUESIA  POR ORDEM ASC(NOME)     FUNCIONA!!!
        public Freguesia[] CarregarFreguesia()
        {
            string[] campos = { "IDconcelho", "NomeFreguesia" };
            AcessoBD aBD = new AcessoBD(@"VAIO-TSANTOS\SQLEXPRESS", "AlgarveBeach", "sa", "34419;");
            DataTable dt = aBD.LerTabelaCompletaOrdem("Freguesias", "NomeFreguesia", "ASC");
            Freguesia[] arrFreguesia = new Freguesia[dt.Rows.Count];
            int i = 0;
            foreach (DataRow rw in dt.Rows)
            {
                Freguesia f = new Freguesia();

                f.IDconcelho = Convert.ToInt32(rw["IDconcelho"]);
                f.NomeFreguesia = Convert.ToString(rw["NomeFreguesia"]);

                arrFreguesia[i] = f;
                i++;
            }
            return arrFreguesia;
        }

        //Método para carregar Freguesia POR IDconcelho
        public Freguesia[] CarregarFreguesia(string IDconcelho)
        {

            string[] campos = { "NomeFreguesia" };
            AcessoBD aBD = new AcessoBD(@"VAIO-TSANTOS\SQLEXPRESS", "AlgarveBeach", "sa", "34419;");
            DataTable dt = aBD.LerTabelaCompletaCon(IDconcelho);
            Freguesia[] arrFreguesia = new Freguesia[dt.Rows.Count];
            int i = 0;
            foreach (DataRow rw in dt.Rows)
            {
                Freguesia f = new Freguesia();

                f.NomeFreguesia = Convert.ToString(rw["NomeFreguesia"]);

                arrFreguesia[i] = f;
                i++;
            }
            return arrFreguesia;
        }


        //Método para carregar PRAIAS POR IDfreguesia
        public Praia[] CarregarPraia(string IDfreguesia)
        {

            string[] campos = { "NomePraia" };
            AcessoBD aBD = new AcessoBD(@"VAIO-TSANTOS\SQLEXPRESS", "AlgarveBeach", "sa", "34419;");
            DataTable dt = aBD.LerTabelaCompletaConTeste("NomePraia", "Praia", "IDfreguesia", IDfreguesia);
            Praia[] arrPraia = new Praia[dt.Rows.Count];
            int i = 0;
            foreach (DataRow rw in dt.Rows)
            {
                Praia p = new Praia();

                p.NomePraia = Convert.ToString(rw["NomePraia"]);

                arrPraia[i] = p;
                i++;
            }
            return arrPraia;
        }

        public Praia[] CarregarPraiaTeste(string IDpraia)
        {

            string[] campos = { "NomePraia", "MoradaPraia", "ExtensaoPraia", "BandeiraAzul", "TemperaturaAgua", "AcessoSoBarco" };
            AcessoBD aBD = new AcessoBD(@"VAIO-TSANTOS\SQLEXPRESS", "AlgarveBeach", "sa", "34419;");
            DataTable dt = aBD.LerTabelaCompletaConTeste1(campos, "Praia", "IDpraia", IDpraia);
            Praia[] arrPraia = new Praia[dt.Rows.Count];
            int i = 0;
            foreach (DataRow rw in dt.Rows)
            {
                Praia p = new Praia();

                p.NomePraia = Convert.ToString(rw["NomePraia"]);
                p.MoradaPraia = Convert.ToString(rw["MoradaPraia"]);
                p.ExtensaoPraia = Convert.ToInt32(rw["ExtensaoPraia"]);
                p.BandeiraAzul = Convert.ToInt16(rw["BandeiraAzul"]);
                p.TemperaturaAgua = Convert.ToInt16(rw["TemperaturaAgua"]);
                p.AcessoSoBarco = Convert.ToInt16(rw["AcessoSoBarco"]);

                arrPraia[i] = p;
                i++;
            }
            return arrPraia;
        }





        //Método responsável por carregar os dados de todos as praias
        public Praia[] CarregarPraia()
        {
            string[] campos = { "NomePraia", "MoradaPraia", "ExtensaoPraia", "BandeiraAzul", "TemperaturaAgua", "AcessoSoBarco" };
            AcessoBD aBD = new AcessoBD(@"VAIO-TSANTOS\SQLEXPRESS", "AlgarveBeach", "sa", "34419;");
            DataTable dt = aBD.LerTabelaCompletaConTeste2(campos, "Praia");
            Praia[] arrPraias = new Praia[dt.Rows.Count];
            int i = 0;
            foreach (DataRow rw in dt.Rows)
            {
                Praia p = new Praia();

                p.NomePraia = rw["NomePraia"].ToString();
                p.MoradaPraia = rw["MoradaPraia"].ToString();
                p.ExtensaoPraia = Convert.ToInt16(rw["ExtensaoPraia"]);
                p.BandeiraAzul = Convert.ToInt16(rw["BandeiraAzul"]);
                p.TemperaturaAgua = Convert.ToInt16(rw["TemperaturaAgua"]);
                p.AcessoSoBarco = Convert.ToInt16(rw["AcessoSoBarco"]);


                arrPraias[i] = p;
                i++;
            }
            return arrPraias;


        }
        /*
        //Método responsável por carregar as praias mais proximas de dado hotel
        public Praia[] CarregarPraiaDistHotel(string IDcategoria)
        {
            string[] campos = { "IDfreguesia", "NomePraia", "MoradaPraia", "ExtensaoPraia", "BandeiraAzul", "TemperaturaAgua", "AcessoSoBarco" };
            AcessoBD aBD = new AcessoBD("VAIO-TSANTOS" + "\\" + "SQLEXPRESS", "AlgarveBeach", "sa", "34419");
            DataTable dt = aBD.LerTabelaCompletaOrdem("Produtos", "IDcategoria", IDcategoria);
            Praia[] arrPraias = new Praia[dt.Rows.Count];
            int i = 0;
            foreach (DataRow rw in dt.Rows)
            {
                Praia p = new Praia();

                p.IDfreguesia = Convert.ToInt32(rw["IDfreguesia"]);
                p.NomePraia = rw["NomePraia"].ToString();
                p.MoradaPraia = rw["Nomeproduto"].ToString();
                p.ExtensaoPraia = Convert.ToInt16(rw["ExtensaoPraia"]);
                p.BandeiraAzul = Convert.ToInt16(rw["BandeiraAzul"]);
                p.TemperaturaAgua = Convert.ToInt16(rw["TemperaturaAgua"]);
                p.AcessoSoBarco = Convert.ToInt16(rw["AcessoSoBarco"]);


                arrPraias[i] = p;
                i++;
            }
            return arrPraias;
        }

        //Método responsável por carregar as praias mais proximas de dado restaurante
        public Praia[] CarregarPraiaDistRestaur(string IDcategoria)
        {
            string[] campos = { "IDfreguesia", "NomePraia", "MoradaPraia", "ExtensaoPraia", "BandeiraAzul", "TemperaturaAgua", "AcessoSoBarco" };
            AcessoBD aBD = new AcessoBD("VAIO-TSANTOS" + "\\" + "SQLEXPRESS", "AlgarveBeach", "sa", "34419");
            DataTable dt = aBD.LerTabelaCompletaOrdem("Produtos", "IDcategoria", IDcategoria);
            Praia[] arrPraias = new Praia[dt.Rows.Count];
            int i = 0;
            foreach (DataRow rw in dt.Rows)
            {
                Praia p = new Praia();

                p.IDfreguesia = Convert.ToInt32(rw["IDfreguesia"]);
                p.NomePraia = rw["NomePraia"].ToString();
                p.MoradaPraia = rw["Nomeproduto"].ToString();
                p.ExtensaoPraia = Convert.ToInt16(rw["ExtensaoPraia"]);
                p.BandeiraAzul = Convert.ToInt16(rw["BandeiraAzul"]);
                p.TemperaturaAgua = Convert.ToInt16(rw["TemperaturaAgua"]);
                p.AcessoSoBarco = Convert.ToInt16(rw["AcessoSoBarco"]);


                arrPraias[i] = p;
                i++;
            }
            return arrPraias;
        }



        //Método responsável por carregar os dados de todos os produtos de uma categoria ordenada pelo preço
        public Praia[] CarregarProdutosCatPre(string IDcategoria, string Ordem)
        {
            string[] campos = { "IDcategoria", "Nomeproduto", "Precoproduto", "GastosEnvproduto" };
            AcessoBD aBD = new AcessoBD("VAIO-TSANTOS" + "\\" + "SQLEXPRESS", "AlgarveBeach", "sa", "34419");
            DataTable dt = aBD.LerTabelaCompletaCatPre("Produtos", "IDcategoria", IDcategoria, "Precoproduto", Ordem);
            Praia[] arrPraias = new Praia[dt.Rows.Count];
            int i = 0;
            foreach (DataRow rw in dt.Rows)
            {
                Praia p = new Praia();

                p.IDfreguesia = Convert.ToInt32(rw["IDfreguesia"]);
                p.NomePraia = rw["NomePraia"].ToString();
                p.MoradaPraia = rw["Nomeproduto"].ToString();
                p.ExtensaoPraia = Convert.ToInt16(rw["ExtensaoPraia"]);
                p.BandeiraAzul = Convert.ToInt16(rw["BandeiraAzul"]);
                p.TemperaturaAgua = Convert.ToInt16(rw["TemperaturaAgua"]);
                p.AcessoSoBarco = Convert.ToInt16(rw["AcessoSoBarco"]);


                arrPraias[i] = p;
                i++;
            }
            return arrPraias;
        }

        //Método responsável por carregar os dados de todos os produtos ordenados pelo preço
        /*public Praia[] CarregarProdutosPre(string Ordem)
        {
            string[] campos = { "IDcategoria", "Nomeproduto", "Precoproduto", "GastosEnvproduto" };
            AcessoBD aBD = new AcessoBD("VAIO-TSANTOS" + "\\" + "SQLEXPRESS", "AlgarveBeach", "sa", "34419");
            DataTable dt = aBD.LerTabelaCompletaOrdem("Produtos", "Precoproduto", Ordem);
            Praia[] arrPraias = new Praia[dt.Rows.Count];
            int i = 0;
            foreach (DataRow rw in dt.Rows)
            {
                Praia p = new Praia();

                p.IDfreguesia = Convert.ToInt32(rw["IDfreguesia"]);
                p.NomePraia = rw["NomePraia"].ToString();
                p.MoradaPraia = rw["Nomeproduto"].ToString();
                p.ExtensaoPraia = Convert.ToInt16(rw["ExtensaoPraia"]);
                p.BandeiraAzul = Convert.ToInt16(rw["BandeiraAzul"]);
                p.TemperaturaAgua = Convert.ToInt16(rw["TemperaturaAgua"]);
                p.AcessoSoBarco = Convert.ToInt16(rw["AcessoSoBarco"]);


                arrPraias[i] = p;
                i++;
            }
            return arrPraias;

        }*/
    }
}
