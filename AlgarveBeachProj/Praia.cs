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
    public class Praia
    {
        private int mIDfreguesia;
        private string mNomePraia;
        private string mMoradaPraia;
        private int mExtensaoPraia;
        private int mBandeiraAzul;
        private int mTemperaturaAgua;
        private int mAcessoSoBarco;


        //Método Construtor vazio permite construir um objecto carro sem propriedades iniciais
        public Praia()
        {
        }

        public Praia(int IDfreguesia, string NomePraia, string MoradaPraia, int ExtensaoPraia, int BandeiraAzul, int TemperaturaAgua, int AcessoSoBarco)
        {
            this.IDfreguesia = IDfreguesia;
            this.NomePraia = NomePraia;
            this.MoradaPraia = MoradaPraia;
            this.ExtensaoPraia = ExtensaoPraia;
            this.BandeiraAzul = BandeiraAzul;
            this.TemperaturaAgua = TemperaturaAgua;
            this.AcessoSoBarco = AcessoSoBarco;

        }

        //Método responsável por carregar os dados de um produto existente na base de dados
        public void CarregarPraia(string IDpraia)
        {
            string[] campos = { "IDfreguesia", "NomePraia", "MoradaPraia", "ExtensaoPraia", "BandeiraAzul", "TemperaturaAgua", "AcessoSoBarco" };
            AcessoBD aBD = new AcessoBD("VAIO-TSANTOS" + "\\" + "SQLEXPRESS", "AlgarveBeach", "sa", "34419");
            string[] valores = aBD.LerTabela("Praias", campos, "IDpraia", IDpraia);
            this.IDfreguesia = Convert.ToInt32(valores[0]);
            this.NomePraia = valores[1];
            this.MoradaPraia = valores[2];
            this.ExtensaoPraia = Convert.ToInt32(valores[3]);
            this.BandeiraAzul = Convert.ToInt16(valores[4]);
            this.TemperaturaAgua = Convert.ToInt16(valores[5]);
            this.AcessoSoBarco = Convert.ToInt16(valores[6]);
        }

        //Método responsável por actualizar um produto existente na base de dados
        public void ActualizarPraia(string IDpraia)
        {
            string[] campos = { "IDfreguesia", "NomePraia", "MoradaPraia", "ExtensaoPraia", "BandeiraAzul", "TemperaturaAgua", "AcessoSoBarco" };
            string[] valores = { this.IDfreguesia.ToString().Replace(",", "."), this.NomePraia, this.MoradaPraia, this.ExtensaoPraia.ToString().Replace(",", "."), this.BandeiraAzul.ToString().Replace(",", "."), this.TemperaturaAgua.ToString().Replace(",", "."), this.AcessoSoBarco.ToString().Replace(",", ".") };
            AcessoBD aBD = new AcessoBD("VAIO-TSANTOS" + "\\" + "SQLEXPRESS", "AlgarveBeach", "sa", "34419");
            aBD.ActualizaTabela("Praia", campos, valores, "IDpraia", IDpraia);
        }

        //Método responsável por inserir um novo produto na base de dados
        public void InserirPraia()
        {
            string[] campos = { "IDfreguesia", "NomePraia", "MoradaPraia", "ExtensaoPraia", "BandeiraAzul", "TemperaturaAgua", "AcessoSoBarco" };
            string[] valores = { this.IDfreguesia.ToString().Replace(",", "."), this.NomePraia, this.MoradaPraia, this.ExtensaoPraia.ToString().Replace(",", "."), this.BandeiraAzul.ToString().Replace(",", "."), this.TemperaturaAgua.ToString().Replace(",", "."), this.AcessoSoBarco.ToString().Replace(",", ".") };
            AcessoBD aBD = new AcessoBD("VAIO-TSANTOS" + "\\" + "SQLEXPRESS", "AlgarveBeach", "sa", "34419");
            aBD.InserirRegisto("Praia", campos, valores);
        }

        //Método responsável pela caracterização do produto mostrando as suas propriedades básicas
        public string Caracteriza()
        {
            return "Esta praia chama-se " + this.NomePraia + " pertence à freguesia: " + this.IDfreguesia;

        }


        //Método responsável por apagar Produtos
        public void ApagarPraia(string IDpraia)
        {
            AcessoBD aBD = new AcessoBD("VAIO-TSANTOS" + "\\" + "SQLEXPRESS", "AlgarveBeach", "sa", "34419");
            aBD.ApagarRegisto("Praia", "IDpraia", IDpraia);
        }



        //::::::::::::::::::::::Propriedades::::::::::::::::::::::::::::
        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
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

    }
}