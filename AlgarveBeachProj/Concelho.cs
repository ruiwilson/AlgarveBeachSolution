using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;

namespace AlgarveBeach
{
    public class Concelho
    {
        private int mIDconcelho;
        private string mNomeConcelho;


        //Método Construtor vazio permite construir um objecto carro sem propriedades iniciais
        public Concelho()
        {
        }

        public Concelho(string NomeConcelho)
        {
            this.NomeConcelho = NomeConcelho;


        }

        //Método responsável por carregar os dados de um produto existente na base de dados
        public void CarregarConcelho(string IDconcelho)
        {
            string[] campos = { "NomeConcelho" };
            AcessoBD aBD = new AcessoBD("VAIO-TSANTOS" + "\\" + "SQLEXPRESS", "AlgarveBeach", "sa", "34419");
            string[] valores = aBD.LerTabela("Concelho", campos, "IDconcelho", IDconcelho);
            this.NomeConcelho = valores[0];
        }

        //CARREGA O ID DE UM NOMECONELHO
        public void CarregarConcelhoID(string nomeconcelho)
        {
            string[] campos = { "IDconcelho" };
            AcessoBD aBD = new AcessoBD("VAIO-TSANTOS" + "\\" + "SQLEXPRESS", "AlgarveBeach", "sa", "34419");
            string[] valores = aBD.LerTabela("Concelho", campos, "NomeConcelho", nomeconcelho);
            this.IDconcelho = Convert.ToInt32(valores[0]);
        }

        

        //Método responsável por actualizar um produto existente na base de dados
        public void ActualizarConcelho(string IDconcelho)
        {
            string[] campos = { "NomeConcelho" };
            string[] valores = { this.NomeConcelho };
            AcessoBD aBD = new AcessoBD("VAIO-TSANTOS" + "\\" + "SQLEXPRESS", "AlgarveBeach", "sa", "34419");
            aBD.ActualizaTabela("Concelho", campos, valores, "IDconcelho", IDconcelho);
        }

        //Método responsável por inserir um novo produto na base de dados
        public void InserirConcelho()
        {
            string[] campos = { "NomeConcelho" };
            string[] valores = { this.NomeConcelho };
            AcessoBD aBD = new AcessoBD("VAIO-TSANTOS" + "\\" + "SQLEXPRESS", "AlgarveBeach", "sa", "34419");
            aBD.InserirRegisto("Concelho", campos, valores);
        }

        //Método responsável pela caracterização do produto mostrando as suas propriedades básicas
        public string Caracteriza()
        {
            return "Este concelho chama-se " + this.NomeConcelho;

        }

        //Método responsável por apagar Produtos
        public void ApagarConcelho(string IDconcelho)
        {
            AcessoBD aBD = new AcessoBD("VAIO-TSANTOS" + "\\" + "SQLEXPRESS", "AlgarveBeach", "sa", "34419");
            aBD.ApagarRegisto("Concelho", "IDconcelho", IDconcelho);
        }



        //::::::::::::::::::::::Propriedades::::::::::::::::::::::::::::
        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        public string NomeConcelho
        {
            get { return mNomeConcelho; }
            set { mNomeConcelho = value; }
        }

        public int IDconcelho
        {
            get { return mIDconcelho; }
            set { mIDconcelho = value; }
        }

    }
}