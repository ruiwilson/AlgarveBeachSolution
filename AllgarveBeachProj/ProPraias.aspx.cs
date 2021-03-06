﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AllgarveBeach
{
    public partial class ProPraias : System.Web.UI.Page
    {
        AlgarveBeach.Concelho con;
        AlgarveBeach.Freguesia fre;
        AlgarveBeach.Praia pra;
        AlgarveBeach.GestaoPraias GP1, GP2, GP3;

        AlgarveBeach.Concelho[] concelho;
        AlgarveBeach.Freguesia[] freguesia;
        AlgarveBeach.Praia[] praia;

        //List<AlgarveBeach.Concelho> Concelhos = new List<AlgarveBeach.Concelho>();
        
        protected void Page_Load(object sender, EventArgs e)
        {

           /* var conc37 = Concelhos.SingleOrDefault(c => c.IDconcelho == 37);

            var ConcelhosOrdNome = Concelhos.OrderBy(x => x.NomeConcelho);

            foreach (var Concelho in ConcelhosOrdNome)
            {

            }*/

            GP1 = new AlgarveBeach.GestaoPraias();
            GP2 = new AlgarveBeach.GestaoPraias();
            GP3 = new AlgarveBeach.GestaoPraias();
            concelho = GP1.CarregarConcelho();
            con = new AlgarveBeach.Concelho();
            fre = new AlgarveBeach.Freguesia();
            pra = new AlgarveBeach.Praia();
            

            if (!IsPostBack)
            {
                DConcelho.Items.Add("Todos os Concelhos");
                DFreguesia.Items.Add("Todas as Freguesias");
                DPraia.Items.Add("Todas as Praias");
                    //CONCELHO
                    foreach (AlgarveBeach.Concelho c in concelho)
                    {
                        DConcelho.Items.Add(c.NomeConcelho);
                    }

                   
                    //FREGUESIA
                    /*foreach (AlgarveBeach.Freguesia f in freguesia)
                    {
                        DFreguesia.Items.Add(f.NomeFreguesia);
                    }*/

                   


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
            DFreguesia.Items.Clear();//ELIMINA TODOS OS ITEMS NA DropDown DFreguesias
            DFreguesia.Items.Add("Todas as Freguesias");
            // DConcelho.SelectedIndexChanged;
            con.CarregarConcelhoID(Convert.ToString(DConcelho.SelectedItem));

            //Literal1.Text = Convert.ToString(id.IDconcelho);
            freguesia = GP2.CarregarFreguesia(Convert.ToString(con.IDconcelho));

        
            foreach (AlgarveBeach.Freguesia f in freguesia)
            {
                DFreguesia.Items.Add(f.NomeFreguesia);
            }
        }

        protected void DropDown_Freguesia(object sender, EventArgs e)
        {

            DPraia.Items.Clear();//ELIMINA TODOS OS ITEMS NA DropDown DFreguesias
            DPraia.Items.Add("Todas as Praias");
            // DConcelho.SelectedIndexChanged;
            fre.CarregarFreguesiaID(Convert.ToString(DFreguesia.SelectedItem));

            //Literal1.Text = Convert.ToString(id.IDconcelho);
            praia = GP3.CarregarPraia(Convert.ToString(fre.IDfreguesia));


            foreach (AlgarveBeach.Praia p in praia)
            {
                DPraia.Items.Add(p.NomePraia);
            }   
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

            /*DFreguesia.Items.Clear();//ELIMINA TODOS OS ITEMS NA DropDown DFreguesias
            id.CarregarConcelhoID(Convert.ToString(DConcelho.SelectedItem));

            Literal1.Text = Convert.ToString(id.IDconcelho);
            freguesia = con1.CarregarFreguesia(Convert.ToString(Literal1.Text));

            
                foreach (AlgarveBeach.Freguesia f in freguesia)
                {
                    DFreguesia.Items.Add(f.NomeFreguesia);
                }*/
        }
    }
}