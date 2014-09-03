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
   public class Restaurante
    {
        private int mIDpraia;
        private string mNomeRest;
        private string mMoradaRest;
        private int mDistanPraia;


        //Método Construtor vazio permite construir um objecto carro sem propriedades iniciais
        public Restaurante()
        {
        }

        public Restaurante(int mIDpraia, string mNomeRest, string mMoradaRest, int mDistanPraia)
        {
            this.IDpraia = mIDpraia;
            this.NomeRest = mNomeRest;
            this.MoradaRest = mMoradaRest;
            this.DistanPraia = mDistanPraia;

        }

        //Método responsável por carregar os dados de um produto existente na base de dados
        public void CarregarRestaurante(string IDrest)
        {
            string[] campos = { "IDpraia", "NomeRest", "MoradaRest", "DistanPraia" };
            AcessoBD aBD = new AcessoBD("VAIO-TSANTOS" + "\\" + "SQLEXPRESS", "AlgarveBeach", "sa", "34419");
            string[] valores = aBD.LerTabela("Restaurantes", campos, "IDrest", IDrest);
            this.IDpraia = Convert.ToInt32(valores[0]);
            this.NomeRest = valores[1];
            this.MoradaRest = valores[2];
            this.DistanPraia = Convert.ToInt32(valores[3]);
        }

        //LISTAR TODOS OS RESTAURANTES
        public void CarregarRestauranteTudo(string IDrest)
        {
            string[] campos = { "IDpraia", "NomeRest", "MoradaRest", "DistanPraia" };
            AcessoBD aBD = new AcessoBD("VAIO-TSANTOS" + "\\" + "SQLEXPRESS", "AlgarveBeach", "sa", "34419");
            string[] valores = aBD.LerTabela("Restaurantes", campos, "IDrest", IDrest);
            this.IDpraia = Convert.ToInt32(valores[0]);
            this.NomeRest = valores[1];
            this.MoradaRest = valores[2];
            this.DistanPraia = Convert.ToInt32(valores[3]);
        }

        //Método responsável por actualizar um produto existente na base de dados
        public void ActualizarRestaurante(string IDrest)
        {
            string[] campos = { "IDpraia", "NomeRest", "MoradaRest", "DistanPraia" };
            string[] valores = { this.IDpraia.ToString().Replace(",", "."), this.NomeRest, this.MoradaRest.ToString().Replace(",", "."), this.DistanPraia.ToString().Replace(",", ".") };
            AcessoBD aBD = new AcessoBD("VAIO-TSANTOS" + "\\" + "SQLEXPRESS", "AlgarveBeach", "sa", "34419");
            aBD.ActualizaTabela("Restaurantes", campos, valores, "IDrest", IDrest);
        }

        //Método responsável por inserir um novo produto na base de dados
        public void InserirRestaurante()
        {
            string[] campos = { "IDpraia", "NomeRest", "MoradaRest", "DistanPraia" };
            string[] valores = { this.IDpraia.ToString().Replace(",", "."), this.NomeRest, this.MoradaRest.ToString().Replace(",", "."), this.DistanPraia.ToString().Replace(",", ".") };
            AcessoBD aBD = new AcessoBD("VAIO-TSANTOS" + "\\" + "SQLEXPRESS", "AlgarveBeach", "sa", "34419");
            aBD.InserirRegisto("Restaurantes", campos, valores);
        }

        //Método responsável pela caracterização do produto mostrando as suas propriedades básicas
        public string Caracteriza()
        {
            return "Este Restaurante chama-se " + this.NomeRest + ", localizar-se em " + this.MoradaRest + ", está a " + this.DistanPraia + "m da praia.";

        }


        //Método responsável por apagar Produtos
        public void ApagarRestaurante(string IDrest)
        {
            AcessoBD aBD = new AcessoBD("VAIO-TSANTOS" + "\\" + "SQLEXPRESS", "AlgarveBeach", "sa", "34419");
            aBD.ApagarRegisto("Restaurantes", "IDrest", IDrest);
        }



        //::::::::::::::::::::::Propriedades::::::::::::::::::::::::::::
        //::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::

        public int IDpraia
        {
            get { return mIDpraia; }
            set { mIDpraia = value; }
        }


        public string NomeRest
        {
            get { return mNomeRest; }
            set { mNomeRest = value; }
        }

        public string MoradaRest
        {
            get { return mMoradaRest; }
            set { mMoradaRest = value; }
        }
        public int DistanPraia
        {
            get { return mDistanPraia; }
            set { mDistanPraia = value; }
        }



    }
}
