using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AllgarveBeach
{
    public partial class ProPraias : System.Web.UI.Page
    {
        AlgarveBeach.Concelho id;
        AlgarveBeach.GestaoPraias con;
        AlgarveBeach.GestaoPraias con1;

        AlgarveBeach.Concelho[] teste;
        AlgarveBeach.Freguesia[] freguesia;
        

        protected void Page_Load(object sender, EventArgs e)
        {
            con = new AlgarveBeach.GestaoPraias();
            teste = con.CarregarConcelho();
            id = new AlgarveBeach.Concelho();
            

            if (!IsPostBack)
            {
                    //CONCELHO
                    foreach (AlgarveBeach.Concelho c in teste)
                    {
                        DConcelho.Items.Add(c.NomeConcelho);
                    }
                    
                    //FREGUESIA
                    foreach (AlgarveBeach.Freguesia f in freguesia)
                    {
                        DFreguesia.Items.Add(f.NomeFreguesia);
                    }
                

                DHospedagem.Items.Add("0m-500m");
                DHospedagem.Items.Add("500m-1000m");
                DHospedagem.Items.Add("1000m-2000m");

                DRestaurante.Items.Add("0m-500m");
                DRestaurante.Items.Add("500m-1000m");
                DRestaurante.Items.Add("1000m-2000m");

                DTemperatura.Items.Add("<18°");
                DTemperatura.Items.Add("18°-21°");
                DTemperatura.Items.Add("21°-24°");
                
                DBandeira.Items.Add("Sim");
                DBandeira.Items.Add("Não");
            }
        }

        protected void DropDown_Concelho(object sender, EventArgs e)
        {

        }

        protected void DropDown_Freguesia(object sender, EventArgs e)
        {
            
            

            //freguesia = con1.CarregarFreguesia(DConcelho.SelectedItem);
        }

        protected void DropDown_Praia(object sender, EventArgs e)
        {

        }

        protected void DropDown_Hospedagem(object sender, EventArgs e)
        {

        }

        protected void DropDown_Restaurante(object sender, EventArgs e)
        {

        }

        protected void DropDown_Temperatura(object sender, EventArgs e)
        {

        }

        protected void DropDown_Bandeira(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            id.CarregarConcelhoID(Convert.ToString(DConcelho.SelectedItem));

            Literal1.Text = Convert.ToString(id.IDconcelho);
        }

        

       

       
    }
}