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
    public class Hospedagem
    {
        private int mIDpraia;
        private string mNomeHospe;
        private string mMoradaHospe;
        private int mDistanPraia;
        private int mClassificacao;
        private int mCamping;

        //Método Construtor vazio permite construir um objecto carro sem propriedades iniciais
        public Hospedagem()
        {
        }

        public Hospedagem(int IDpraia, string NomeHospe, string MoradaHospe, int DistanPraia, int Classificacao, int Camping)
        {
            this.IDpraia = IDpraia;
            this.NomeHospe = NomeHospe;
            this.MoradaHospe = MoradaHospe;
            this.DistanPraia = DistanPraia;
            this.Classificacao = Classificacao;
            this.Camping = Camping;

        }

        //Método responsável por carregar os dados de um produto existente na base de dados
        public void CarregarHospedagem(string IDhospe)
        {
            string[] campos = { "IDpraia", "NomeHospe", "MoradaHospe", "DistanPraia", "Classificacao", "Camping" };
            AcessoBD aBD = new AcessoBD("VAIO-TSANTOS" + "\\" + "SQLEXPRESS", "AlgarveBeach", "sa", "34419");
            string[] valores = aBD.LerTabela("Hospedagem", campos, "IDhospe", IDhospe);
            this.IDpraia = Convert.ToInt32(valores[0]);
            this.NomeHospe = valores[1];
            this.MoradaHospe = valores[2];
            this.DistanPraia = Convert.ToInt32(valores[3]);
            this.Classificacao = Convert.ToInt16(valores[4]);
            this.Camping = Convert.ToInt16(valores[5]);
        }

        //Método responsável por actualizar um produto existente na base de dados
        public void ActualizarHospedagem(string IDhospe)
        {
            string[] campos = { "IDpraia", "NomeHospe", "MoradaHospe", "DistanPraia", "Classificacao", "Camping" };
            string[] valores = { this.IDpraia.ToString().Replace(",", "."), this.NomeHospe, this.MoradaHospe, this.DistanPraia.ToString().Replace(",", "."), this.Classificacao.ToString().Replace(",", "."), this.Camping.ToString().Replace(",", ".") };
            AcessoBD aBD = new AcessoBD("VAIO-TSANTOS" + "\\" + "SQLEXPRESS", "AlgarveBeach", "sa", "34419");
            aBD.ActualizaTabela("Hospedagem", campos, valores, "IDhospe", IDhospe);
        }

        //Método responsável por inserir um novo produto na base de dados
        public void InserirHospedagem()
        {
            string[] campos = { "IDpraia", "NomeHospe", "MoradaHospe", "DistanPraia", "Classificacao", "Camping" };
            string[] valores = { this.IDpraia.ToString().Replace(",", "."), this.NomeHospe, this.MoradaHospe, this.DistanPraia.ToString().Replace(",", "."), this.Classificacao.ToString().Replace(",", "."), this.Camping.ToString().Replace(",", ".") };
            AcessoBD aBD = new AcessoBD("VAIO-TSANTOS" + "\\" + "SQLEXPRESS", "AlgarveBeach", "sa", "34419");
            aBD.InserirRegisto("Hospedagem", campos, valores);
        }

        //Método responsável pela caracterização do produto mostrando as suas propriedades básicas
        public string Caracteriza()
        {
            return "Esta Hospedagem chama-se " + this.NomeHospe + " e situa-se a: " + this.DistanPraia + " metros da praia! ";

        }


        //Método responsável por apagar Produtos
        public void ApagarHospedagem(string IDhospe)
        {
            AcessoBD aBD = new AcessoBD("VAIO-TSANTOS" + "\\" + "SQLEXPRESS", "AlgarveBeach", "sa", "34419");
            aBD.ApagarRegisto("Hospedagem", "IDhospe", IDhospe);
        }



        //::::::::::::::::::::::Propriedades::::::::::::::::::::::::::::
        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::
        public int IDpraia
        {
            get { return mIDpraia; }
            set { mIDpraia = value; }
        }


        public string NomeHospe
        {
            get { return mNomeHospe; }
            set { mNomeHospe = value; }
        }

        public string MoradaHospe
        {
            get { return mMoradaHospe; }
            set { mMoradaHospe = value; }
        }
        public int DistanPraia
        {
            get { return mDistanPraia; }
            set { mDistanPraia = value; }
        }

        public int Classificacao
        {
            get { return mClassificacao; }
            set { mClassificacao = value; }
        }

        public int Camping
        {
            get { return mCamping; }
            set { mCamping = value; }
        }

    }
}
