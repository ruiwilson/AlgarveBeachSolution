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
    public class Freguesia
    {

        private int mIDconcelho;
        private string mNomeFreguesia;
        private string NomeDoPresidenteDaJunta;

        //Método Construtor vazio permite construir um objecto carro sem propriedades iniciais
        public Freguesia()
        {
        }

        public Freguesia(int IDconcelho, string NomeFreguesia)
        {

            this.IDconcelho = IDconcelho;
            this.NomeFreguesia = NomeFreguesia;

        }



        //Método responsável por carregar os dados de um produto existente na base de dados
        public void CarregarFreguesia(string IDfreguesia)
        {
            string[] campos = { "IDconcelho", "NomeFreguesia" };
            AcessoBD aBD = new AcessoBD("VAIO-TSANTOS" + "\\" + "SQLEXPRESS", "AlgarveBeach", "sa", "34419");
            string[] valores = aBD.LerTabela("Freguesias", campos, "IDfreguesia", IDfreguesia);
            this.IDconcelho = Convert.ToInt32(valores[0]);
            this.NomeFreguesia = valores[1];
        }


        //CARREGAR FREGUESIAS POR IDconcelho
     /*   public void CarregarFreguesiaIDcon(string IDconcelho)
        {
            string[] campos = { "NomeFreguesia" };
            AcessoBD aBD = new AcessoBD("VAIO-TSANTOS" + "\\" + "SQLEXPRESS", "AlgarveBeach", "sa", "34419");
            string[] valores = aBD.LerTabelaCompletaCon(IDconcelho);
            this.NomeFreguesia = valores[0];
        }
        */

        //Método responsável por actualizar um produto existente na base de dados
        public void ActualizarFreguesia(string IDfreguesia)
        {
            string[] campos = { "IDconcelho", "NomeFreguesia" };
            string[] valores = { this.IDconcelho.ToString().Replace(",", "."), this.NomeFreguesia };
            AcessoBD aBD = new AcessoBD("VAIO-TSANTOS" + "\\" + "SQLEXPRESS", "AlgarveBeach", "sa", "34419");
            aBD.ActualizaTabela("Freguesias", campos, valores, "IDfreguesia", IDfreguesia);
        }

        //Método responsável por inserir um novo produto na base de dados
        public void InserirFreguesia()
        {
            string[] campos = { "IDconcelho", "NomeFreguesia" };
            string[] valores = { this.IDconcelho.ToString().Replace(",", "."), this.NomeFreguesia };
            AcessoBD aBD = new AcessoBD("VAIO-TSANTOS" + "\\" + "SQLEXPRESS", "AlgarveBeach", "sa", "34419");
            aBD.InserirRegisto("Freguesias", campos, valores);
        }

        public string Caracteriza()
        {
            return "Esta freguesia chama-se " + this.NomeFreguesia + " e pertence ao concelho de: " + this.IDconcelho;
        }

        //Método responsável por apagar Produtos
        public void ApagarFreguesia(string IDfreguesia)
        {
            AcessoBD aBD = new AcessoBD("VAIO-TSANTOS" + "\\" + "SQLEXPRESS", "AlgarveBeach", "sa", "34419");
            aBD.ApagarRegisto("Freguesias", "IDfreguesia", IDfreguesia);
        }



        //::::::::::::::::::::::Propriedades::::::::::::::::::::::::::::
        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        public int IDconcelho
        {
            get { return mIDconcelho; }
            set { mIDconcelho = value; }
        }


        public string NomeFreguesia
        {
            get { return mNomeFreguesia; }
            set { mNomeFreguesia = value; }
        }

    }
}