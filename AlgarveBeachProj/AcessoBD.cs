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
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace AlgarveBeach
{
    class AcessoBD
    {
        private string mServidor;
        private string mBasedeDados;
        private string mUtilizador;
        private string mPalavraPasse;
        private SqlConnection sqlLigacao;



  public AcessoBD(string Server, string DB, string User, string Pass)
        {
            this.Servidor = Server;
            this.BasedeDados = DB;
            this.Utilizador = User;
            this.PalavraPasse = Pass;
            this.sqlLigacao = new SqlConnection("Server=" + this.Servidor + "; Database=" + this.BasedeDados + "; User id= " + this.Utilizador + "; Password=" + this.PalavraPasse + ";");
        }

        //Ler tabela através de Chave Primária
        public string[] LerTabela(string NomedaTabela, string[] arrCampos, string CampoChave, string ValorChave)
        {
            string[] arrResultadoPesquisa = new string[arrCampos.Length];
            string SelectList = "";
            for (int i = 0; i < arrCampos.Length; i++)
            {
                SelectList += arrCampos[i];
                if (i != arrCampos.Length - 1) { SelectList += ", "; }
            }

            SqlCommand sqlComando = new SqlCommand("SELECT " + SelectList + " FROM " + NomedaTabela + " WHERE " + CampoChave + " = '" + ValorChave + "';", sqlLigacao);
            this.sqlLigacao.Open();
            SqlDataReader sqlLeitor = sqlComando.ExecuteReader();
            while (sqlLeitor.Read())
            {
                int i = 0;
                foreach (string s in arrCampos)
                {
                    arrResultadoPesquisa[i] = sqlLeitor.GetSqlValue(i).ToString();
                    i++;
                }
            }
            sqlLigacao.Close();
            return arrResultadoPesquisa;
        }


        //LerTabelaCompleta2
        
                public DataTable LerTabelaCompleta2(string NomedaTabela)
                {
                    
                    string strSelect = "SELECT * FROM " + NomedaTabela + ";";
                    this.sqlLigacao.Open();
                    SqlDataAdapter da = new SqlDataAdapter(strSelect, sqlLigacao);
                   
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    sqlLigacao.Close();

                    return dt;
                    
                }


                //LerTabelaCompleta Freguesia por IDConcelho

                public DataTable LerTabelaCompletaCon(string ValorChave)
                {

                    string strSelect = "SELECT NomeFreguesia FROM Freguesias WHERE IDconcelho = " +  ValorChave + ";";
                    //string strSelect = "SELECT Freguesias.NomeFreguesia FROM Freguesias INNER JOIN  ON Freguesias.IDconcelho = Concelho.IDconcelho WHERE Concelho.NomeConcelho = '" + ValorChave + "';";
                    this.sqlLigacao.Open();
                    SqlDataAdapter da = new SqlDataAdapter(strSelect, sqlLigacao);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    sqlLigacao.Close();

                    return dt;

                }


                //LerTabelaCompleta por categoria ordenada por preço

                public DataTable LerTabelaCompletaCatPre(string NomedaTabela, string CampoChave, string ValorChave, string CampoOrder, string ordem)
                {

                    string strSelect = "SELECT * FROM " + NomedaTabela + " WHERE " + CampoChave + " = '" + ValorChave + "' ORDER BY " + CampoOrder + " " + ordem;
                    this.sqlLigacao.Open();
                    SqlDataAdapter da = new SqlDataAdapter(strSelect, sqlLigacao);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    sqlLigacao.Close();

                    return dt;

                }


                //LerTabelaCompleta ordenada por preço

                public DataTable LerTabelaCompletaOrdem(string NomedaTabela, string CampoOrder, string ordem)
                {

                    string strSelect = "SELECT * FROM " + NomedaTabela + " ORDER BY " + CampoOrder + " " + ordem;
                    this.sqlLigacao.Open();
                    SqlDataAdapter da = new SqlDataAdapter(strSelect, sqlLigacao);

                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    sqlLigacao.Close();

                    return dt;

                }




        //Actualizar tabela em SQL Server 
        public int ActualizaTabela(string NomedaTabela, string[] arrCampos, string[] arrValores, string CampoChave, string ValorChave)
        {
            string UpdateList = " SET ";
            for (int i = 0; i < arrCampos.Length; i++)
            {
                UpdateList += arrCampos[i] + "='" + arrValores[i] + "' ";
                if (i != arrCampos.Length - 1) { UpdateList += ", "; }
            }
            SqlCommand sqlComando = new SqlCommand("UPDATE " + NomedaTabela + UpdateList + " WHERE " + CampoChave + " = '" + ValorChave + "';", sqlLigacao);
            this.sqlLigacao.Open();
            return sqlComando.ExecuteNonQuery();
        }

        //Inserir registo tabela em SQL Server com ID autonunber 
        public int InserirRegisto(string NomedaTabela, string[] arrCampos, string[] arrValores)
        {
            string InsertList = "(";
            for (int i = 0; i < arrCampos.Length; i++)
            {
                InsertList += arrCampos[i];
                if (i != arrCampos.Length - 1) { InsertList += ", "; }
                else { InsertList += ") VALUES ("; }
            }

            for (int i = 0; i < arrValores.Length; i++)
            {
                InsertList += "'" + arrValores[i] + "'";
                if (i != arrValores.Length - 1) { InsertList += ", "; }
                else { InsertList += ");"; }
            }



            SqlCommand sqlComando = new SqlCommand("INSERT INTO " + NomedaTabela + InsertList, sqlLigacao);
            this.sqlLigacao.Open();
            return sqlComando.ExecuteNonQuery();
        }


        public int ApagarRegisto(string NomedaTabela, string Campo, string Valor)
        {

            SqlCommand sqlComando = new SqlCommand("DELETE FROM " + NomedaTabela + " WHERE " + Campo + "='" + Valor + "'", sqlLigacao);
            this.sqlLigacao.Open();
            return sqlComando.ExecuteNonQuery();
        }



        public string Servidor
        {
            get { return mServidor; }
            set { mServidor = value; }
        }
        public string BasedeDados
        {
            get { return mBasedeDados; }
            set { mBasedeDados = value; }
        }
        public string Utilizador
        {
            get { return mUtilizador; }
            set { mUtilizador = value; }
        }
        public string PalavraPasse
        {
            get { return mPalavraPasse; }
            set { mPalavraPasse = value; }
        }



    }
}