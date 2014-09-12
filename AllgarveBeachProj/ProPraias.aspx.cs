using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyApp;

namespace AllgarveBeach
{
    public partial class ProPraias : System.Web.UI.Page
    {
        BdQuery query = new BdQuery();
        AlgarveBeach.Concelho con;
        AlgarveBeach.Freguesia fre;
        AlgarveBeach.Praia pra;
        AlgarveBeach.GestaoPraias GP1, GP2, GP3, GP4;
        AlgarveBeach.Praia Bitch;

        AlgarveBeach.Concelho[] concelho;
        AlgarveBeach.Freguesia[] freguesia;
        AlgarveBeach.Praia[] praia;
        AlgarveBeach.Praia[] praiateste;

        //List<AlgarveBeach.Concelho> Concelhos = new List<AlgarveBeach.Concelho>();

        protected void Page_Load(object sender, EventArgs e)
        {
            /* var conc37 = Concelhos.SingleOrDefault(c => c.IDconcelho == 37);

             var ConcelhosOrdNome = Concelhos.OrderBy(x => x.NomeConcelho);

             foreach (var Concelho in ConcelhosOrdNome)
             {

             }*/

            if (!IsPostBack) { DFreguesia.Enabled = false; DPraia.Enabled = false; }
            if (IsPostBack)
            {
                if (DConcelho.SelectedIndex == 0) { DFreguesia.Enabled = false; DPraia.Enabled = false; }
                else
                {
                    DFreguesia.Enabled = true;
                    if (DFreguesia.SelectedIndex == 0) { DPraia.Enabled = false; }
                    else { DPraia.Enabled = true; }
                }

                // if (DConcelho.SelectedIndex == 0) { DFreguesia.Enabled = false; DPraia.Enabled = false; }
            }


            GP1 = new AlgarveBeach.GestaoPraias();
            GP2 = new AlgarveBeach.GestaoPraias();
            GP3 = new AlgarveBeach.GestaoPraias();
            GP4 = new AlgarveBeach.GestaoPraias();
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

                DHospedagem.Items.Add("Sem hospedagem");
                DHospedagem.Items.Add("Qualquer Distância");
                DHospedagem.Items.Add("0m-500m");
                DHospedagem.Items.Add("500m-1000m");
                DHospedagem.Items.Add("1000m-2000m");

                DRestaurante.Items.Add("Sem restaurante");
                DRestaurante.Items.Add("Qualquer Distância");
                DRestaurante.Items.Add("0m-500m");
                DRestaurante.Items.Add("500m-1000m");
                DRestaurante.Items.Add("1000m-2000m");

                DTemperatura.Items.Add("Qualquer Temperatura");
                DTemperatura.Items.Add("<18°");
                DTemperatura.Items.Add("18°-21°");
                DTemperatura.Items.Add("21°-24°");

                DBandeira.Items.Add("Não");
                DBandeira.Items.Add("Sim");

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
            if (DPraia.SelectedIndex != 0)
            {
                pra.CarregarPraiaID(Convert.ToString(DPraia.SelectedItem));

                praiateste = GP4.CarregarPraiaTeste(Convert.ToString(pra.IDpraia));

                foreach (AlgarveBeach.Praia p in praiateste)
                {
                    Literal1.Text = Convert.ToString("Nome: " + p.NomePraia + "<br>Morada: " + p.MoradaPraia + "<br>Tamanho: " + p.ExtensaoPraia + "<br>Bandeira: " + p.BandeiraAzul + "<br>Temperatura: " + p.TemperaturaAgua + "<br>Acesso por Barco: " + p.AcessoSoBarco + "<br>Hospedagem: ");
                }
            }
            else
            {

                praiateste = GP4.CarregarPraia();


            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Literal1.Text = "";
            /*  if(DHospedagem.SelectedIndex==1)
              {
                  pra.CarregarPraiaID(Convert.ToString(DPraia.SelectedItem));
              }*/
            int hosp1 = 0, rest1 = 0, temp1 = 0, band1 = 0;

            //Atribuimos valores para enviar para o metodo de busca da praia exacta
            if (DHospedagem.SelectedIndex == 1) { hosp1 = 10000; }
            if (DHospedagem.SelectedIndex == 2) { hosp1 = 501; }
            if (DHospedagem.SelectedIndex == 3) { hosp1 = 1001; }
            if (DHospedagem.SelectedIndex == 4) { hosp1 = 2001; }
            if (DRestaurante.SelectedIndex == 1) { rest1 = 10000; }
            if (DRestaurante.SelectedIndex == 2) { rest1 = 501; }
            if (DRestaurante.SelectedIndex == 3) { rest1 = 1001; }
            if (DRestaurante.SelectedIndex == 4) { rest1 = 2001; }
            if (DTemperatura.SelectedIndex == 0) { temp1 = 40; }
            if (DTemperatura.SelectedIndex == 1) { temp1 = 18; }
            if (DTemperatura.SelectedIndex == 2) { temp1 = 21; }
            if (DTemperatura.SelectedIndex == 3) { temp1 = 24; }
            if (DBandeira.SelectedIndex == 0) { band1 = 0; }
            if (DBandeira.SelectedIndex == 1) { band1 = 1; }

            pra.CarregarPraiaID(Convert.ToString(DPraia.SelectedItem));
            praiateste = GP4.CarregarPraiaTeste(Convert.ToString(pra.IDpraia));


            //UMA DETERMINADA PRAIA COM UMA DETERMINADA FREGUESIA E UM DETERMINADO CONCELHO
            if (DPraia.SelectedIndex > 0 && DFreguesia.SelectedIndex > 0 && DConcelho.SelectedIndex > 0)
            {
                //SE DETERMINADA PRAIA TEM HOSPEDAGEM MAS NAO TEM RESTAURANTE
                if (DHospedagem.SelectedIndex > 0 && DRestaurante.SelectedIndex == 0)
                {
                    Literal1.Text += "<table align='center' border='1'><tr>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Praia(nome)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Desc(Praia)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Restaurante</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Desc(Rest.)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Tmp.Água(ºC)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Band.Azul</b></td></tr>";
                    Literal1.Text += query.VerPraiasComHospTempBand(pra.IDpraia, hosp1, temp1, band1);
                    Literal1.Text += "</table>";
                }
                //SE DETERMINADA PRAIA TEM RESTAURANTE MAS NAO TEM HOSPEDAGEM
                if (DRestaurante.SelectedIndex > 0 && DHospedagem.SelectedIndex == 0)
                {
                    Literal1.Text += "<table align='center' border='1'><tr>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Praia(nome)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Desc(Praia)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Restaurante</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Desc(Rest.)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Tmp.Água(ºC)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Band.Azul</b></td></tr>";
                    Literal1.Text += query.VerPraiasComRestTempBand(pra.IDpraia, rest1, temp1, band1);
                    Literal1.Text += "</table>";
                }
                //SE DETERMINADA PRAIA TEM HOSPEDAGEM E RESTAURANTE
                if (DHospedagem.SelectedIndex > 0 && DRestaurante.SelectedIndex > 0)
                {
                    Literal1.Text += "<table align='center' border='1'><tr>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Praia(nome)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Desc(Praia)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Restaurante</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Desc(Rest.)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Hospedagem</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Desc(Hosp.)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Tmp.Água(ºC)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Band.Azul</b></td></tr>";
                    Literal1.Text += query.VerPraiasHospRestTempBand(pra.IDpraia, hosp1, rest1, temp1, band1);
                    Literal1.Text += "</table>";
                }
            }
            //FIM DE UMA DETERMINADA PRAIA COM UMA DETERMINADA FREGUESIA E UM DETERMINADO CONCELHO


            if (DPraia.SelectedIndex == 0 && DFreguesia.SelectedIndex == 0 && DConcelho.SelectedIndex == 0)
            {
                //INICIO DE QUALQUER PRAIA DE QUALQUER CONCELHO E DE QUALQUER FREGUESIA
                //SE QUALQUER PRAIA TEM HOSPEDAGEM MAS NAO TEM RESTAURANTE
                if (DHospedagem.SelectedIndex > 0 && DRestaurante.SelectedIndex == 0)
                {
                    Literal1.Text += "<table align='center' border='1'><tr>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Praia(nome)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Desc(Praia)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Restaurante</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Desc(Rest.)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Tmp.Água(ºC)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Band.Azul</b></td></tr>";
                    Literal1.Text += query.VerTodasPraiasComHospTempBand(hosp1, temp1, band1);
                    Literal1.Text += "</table>";
                }
                //SE QUALQUER PRAIA TEM RESTAURANTE MAS NAO TEM HOSPEDAGEM
                if (DRestaurante.SelectedIndex > 0 && DHospedagem.SelectedIndex == 0)
                {
                    Literal1.Text += "<table align='center' border='1'><tr>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Praia(nome)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Desc(Praia)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Restaurante</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Desc(Rest.)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Tmp.Água(ºC)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Band.Azul</b></td></tr>";
                    Literal1.Text += query.VerTodasPraiasComRestTempBand(rest1, temp1, band1);
                    Literal1.Text += "</table>";
                }

                //SE QUALQUER PRAIA TEM RESTAURANTE E HOSPEDAGEM
                if (DHospedagem.SelectedIndex > 0 && DRestaurante.SelectedIndex > 0 && DPraia.SelectedIndex == 0)
                {
                    Literal1.Text += "<table align='center' border='1'><tr>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Praia(nome)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Desc(Praia)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Restaurante</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Desc(Rest.)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Hospedagem</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Desc(Hosp.)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Tmp.Água(ºC)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Band.Azul</b></td></tr>";
                    Literal1.Text += query.VerTodasPraiasHospRestTempBand(hosp1, rest1, temp1, band1);
                    Literal1.Text += "</table>";
                }
                //FIM DE SE QUALQUER PRAIA DE QUALQUER CONCELHO E DE QUALQUER FREGUESIA TEM HOSPEDAGEM E RESTAURANTE
            }

            //INICIO DE QUALQUER PRAIA DE QUALQUER CONCELHO MAS DE DETERMINADA FREGUESIA
            if (DPraia.SelectedIndex == 0 && DFreguesia.SelectedIndex > 0 && DConcelho.SelectedIndex > 0)
            {
                //SE QUALQUER PRAIA TEM HOSPEDAGEM MAS NAO TEM RESTAURANTE
                if (DHospedagem.SelectedIndex > 0 && DRestaurante.SelectedIndex == 0)
                {
                    Literal1.Text += "<table align='center' border='1'><tr>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Praia(nome)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Desc(Praia)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Hospedagem</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Desc(Hosp.)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Tmp.Água(ºC)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Band.Azul</b></td></tr>";
                    fre.CarregarFreguesiaID(Convert.ToString(DFreguesia.SelectedItem));

                    Literal1.Text += query.VerTodasPraiasDeFreguesiaHospTempBand(fre.IDfreguesia, hosp1, temp1, band1);
                    Literal1.Text += "</table>";
                }
                //SE QUALQUER PRAIA TEM RESTAURANTE MAS NAO TEM HOSPEDAGEM
                if (DHospedagem.SelectedIndex > 0 && DRestaurante.SelectedIndex == 0)
                {
                    Literal1.Text += "<table align='center' border='1'><tr>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Praia(nome)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Desc(Praia)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Restaurante</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Desc(Rest.)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Tmp.Água(ºC)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Band.Azul</b></td></tr>";

                    fre.CarregarFreguesiaID(Convert.ToString(DFreguesia.SelectedItem));

                    Literal1.Text += query.VerTodasPraiasDeFreguesiaRestTempBand(fre.IDfreguesia, rest1, temp1, band1);
                    Literal1.Text += "</table>";
                }
                //SE QUALQUER PRAIA TEM RESTAURANTE E HOSPEDAGEM
                if (DHospedagem.SelectedIndex > 0 && DRestaurante.SelectedIndex > 0 && DPraia.SelectedIndex == 0)
                {
                    Literal1.Text += "<table align='center' border='1'><tr>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Praia(nome)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Desc(Praia)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Restaurante</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Desc(Rest.)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Hospedagem</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Desc(Hosp.)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Tmp.Água(ºC)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Band.Azul</b></td></tr>";

                    fre.CarregarFreguesiaID(Convert.ToString(DFreguesia.SelectedItem));

                    Literal1.Text += query.VerTodasPraiasDeFreguesiaRestHostTempBand(fre.IDfreguesia, rest1, hosp1, temp1, band1);
                    Literal1.Text += "</table>";
                }
                //FIM DE SE QUALQUER PRAIA DE QUALQUER CONCELHO E DE DETERMINADA FREGUESIA TEM HOSPEDAGEM E RESTAURANTE
            }


            if (DPraia.SelectedIndex == 0 && DFreguesia.SelectedIndex == 0 && DConcelho.SelectedIndex > 0)
            {
                //INICIO DE QUALQUER PRAIA DE DETERMINADO CONCELHO E QUALQUER FREGUESIA E QUALQUER PRAIA
                //SE QUALQUER PRAIA TEM HOSPEDAGEM MAS NAO TEM RESTAURANTE
                if (DHospedagem.SelectedIndex > 0 && DRestaurante.SelectedIndex == 0)
                {
                    Literal1.Text += "<table align='center' border='1'><tr>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Praia(nome)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Desc(Praia)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Hospedagem</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Desc(Hosp.)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Tmp.Água(ºC)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Band.Azul</b></td></tr>";

                    con.CarregarConcelhoID(Convert.ToString(DConcelho.SelectedItem));

                    Literal1.Text += query.VerTodasPraiasDeConcelhoHospTempBand(con.IDconcelho,hosp1, temp1, band1);
                    Literal1.Text += "</table>";
                }

                //SE QUALQUER PRAIA TEM RESTAURANTE MAS NAO TEM HOSPEDAGEM
                if (DRestaurante.SelectedIndex > 0 && DHospedagem.SelectedIndex == 0)
                {
                    Literal1.Text += "<table align='center' border='1'><tr>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Praia(nome)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Desc(Praia)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Restaurante</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Desc(Rest.)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Tmp.Água(ºC)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Band.Azul</b></td></tr>";

                    
                    con.CarregarConcelhoID(Convert.ToString(DConcelho.SelectedItem));
                    

                    Literal1.Text += query.VerTodasPraiasDeConcelhoRestTempBand(con.IDconcelho, rest1, temp1, band1);
                    Literal1.Text += "</table>";
                }

                //SE QUALQUER PRAIA TEM RESTAURANTE E HOSPEDAGEM
                if (DHospedagem.SelectedIndex > 0 && DRestaurante.SelectedIndex > 0)
                {
                    Literal1.Text += "<table align='center' border='1'><tr>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Praia(nome)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Desc(Praia)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Restaurante</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Desc(Rest.)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Hospedagem</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Desc(Hosp.)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Tmp.Água(ºC)</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Band.Azul</b></td></tr>";

                    con.CarregarConcelhoID(Convert.ToString(DConcelho.SelectedItem));

                    Literal1.Text += query.VerTodasPraiasDeFreguesiaRestHostTempBand(con.IDconcelho, rest1, hosp1, temp1, band1);
                    Literal1.Text += "</table>";
                }
                //FIM DE SE QUALQUER PRAIA DE DETERMINADO CONCELHO E DE QUALQUER FREGUESIA TEM HOSPEDAGEM E RESTAURANTE

            }
        }
    }
}