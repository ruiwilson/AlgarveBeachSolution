using AlgarveBeach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyApp;

namespace AllgarveBeach
{
    public partial class HomeAdmin : System.Web.UI.Page
    {

        Restaurante novoRestaurante;//Métodos nas suas respectivas classes
        static Hospedagem novaHospedagem;
        static Praia novaPraia;
        static Freguesia novaFreguesia;
        static Concelho novoConcelho;
        GestaoPraias con, con1;
        BdQuery db;

        Concelho[] concelho;//METODO NO GestaoPraias
        Freguesia[] freguesia;

        protected void Page_Load(object sender, EventArgs e)
        {
            db = new BdQuery();
            con = new GestaoPraias(); con1 = new GestaoPraias();
            concelho = con.CarregarConcelho();
            freguesia = con1.CarregarFreguesia();
        }

        private void MessageBox(string msg)
        {
            Label lblMessage = new Label();
            lblMessage.Text = "<script language='javascript'>" + Environment.NewLine + "window.alert('" + msg + "')</script>";
            Page.Controls.Add(lblMessage);
        }

        protected void btnVerConc_Click(object sender, ImageClickEventArgs e)
        {
            if (txtID.Text != "")
            {

                /*novoConcelho.CarregarConcelho(txtID.Text);
                ltresultados.Text = novoConcelho.Caracteriza();
                MessageBox("Concelho carregado com sucesso!");*/
                ltresultados.Text += "<table align='center' border='1'><tr>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>NomeConcelho</b></td></tr>";
                
                ltresultados.Text = db.VerConcelho();
                ltresultados.Text += "</table>";
                MessageBox("Concelho carregado com sucesso!");
            }
            else
            {
                /*ltresultados.Text = "";
                foreach (Concelho c in concelho)
                {
                    ltresultados.Text += c.NomeConcelho + "\r\n";
                }*/
                ltresultados.Text += "<table align='center' border='1'><tr>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>NomeConcelho</b></td></tr>";
                
                ltresultados.Text = db.VerConcelho();
                ltresultados.Text += "</table>";
                MessageBox("Concelhos carregados com sucesso!");
            }
        }


        //VISUALIZAR
        protected void btnVerFreg_Click(object sender, ImageClickEventArgs e)
        {
            if (txtID.Text != "")
            {
                /*novaFreguesia.CarregarFreguesia(txtID.Text);
                ltresultados.Text = novaFreguesia.Caracteriza();
                MessageBox("Freguesia carregada com sucesso!");*/
                ltresultados.Text += "<table align='center' border='1'><tr>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>IDconcelho</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>NomeFreguesia</b></td><tr>";
                
                ltresultados.Text = db.VerFreguesias();
                ltresultados.Text += "</table>";
                MessageBox("Freguesias carregadas com sucesso!");
            }
            else
            {
                /*ltresultados.Text = "";
                foreach (Freguesia f in freguesia)
                {
                    ltresultados.Text += "IDconcelho: " + f.IDconcelho + "\r\n" + "NomeFreguesia: " + f.NomeFreguesia + "\r\n";
                }*/
                ltresultados.Text += "<table align='center' border='1'><tr>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>IDconcelho</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>NomeFreguesia</b></td><tr>";
                
                ltresultados.Text = db.VerFreguesias();
                ltresultados.Text += "</table>";
                MessageBox("Freguesias carregadas com sucesso!");
            }
        }

        protected void btnVerPraia_Click(object sender, ImageClickEventArgs e)
        {

            /*novaPraia.CarregarPraia(txtID.Text);
            ltresultados.Text = novaPraia.Caracteriza();
            MessageBox("Praia carregada com sucesso!");*/
            ltresultados.Text += "<table align='center' border='1'><tr>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>IDfreguesia</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>NomePraia</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>MoradaPraia</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>ExtensaoPraia</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>BandeiraAzul</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>TemperaturaAgua</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>AcessoSoBarco</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>VotoPosP</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>VotoNegP</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>LinkP</b></td></tr>";
            
            ltresultados.Text = db.VerPraia();
            ltresultados.Text += "</table>";
            MessageBox("Praias carregadas com sucesso!");

        }

        protected void btnVerHospe_Click(object sender, ImageClickEventArgs e)
        {

            /*novaHospedagem.CarregarHospedagem(txtID.Text);
            ltresultados.Text = novaHospedagem.Caracteriza();
            MessageBox("Hospedagem carregada com sucesso!");*/
            ltresultados.Text += "<table align='center' border='1'><tr>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>IDpraia</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>NomeHospe</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>MoradaHospe</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>DistanPraiaH</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Classificacao</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Camping</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>VotoPosH</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>VotoNegH</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>LinkH</b></td></tr>";
            
            ltresultados.Text = db.VerHospedagem();
            ltresultados.Text += "</table>";
            MessageBox("Hospedagens carregadas com sucesso!");

        }

        protected void btnVerRest_Click(object sender, ImageClickEventArgs e)
        {

            /*novoRestaurante.CarregarRestaurante(txtID.Text);
            ltresultados.Text = novoRestaurante.Caracteriza();
            MessageBox("Restaurante carregado com sucesso!");*/
            ltresultados.Text += "<table align='center' border='1'><tr>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>IDpraia</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>NomeRest</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>MoradaHospe</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>DistanPraiaH</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Classificacao</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>Camping</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>VotoPosH</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>VotoNegH</b></td>" +
                        "<td bgcolor=rgb(255,255,255) align=center><b>LinkH</b></td></tr>";
            
            ltresultados.Text = db.VerRestaurantes();
            ltresultados.Text += "</table>";
            MessageBox("Restaurantes carregados com sucesso!");

        }

        //INSERIR
        protected void btnInserirConc_Click(object sender, ImageClickEventArgs e)
        {
            /*novoConcelho = new Concelho(txtNomeConcelho.Text);

            novoConcelho.InserirConcelho();

            MessageBox("Concelho inserido com sucesso!");*/
            db.InserirConcelho(txtNomeConcelho.Text);
            MessageBox("Concelho inserido com sucesso!");
        }

        protected void btnInserirFreg_Click(object sender, ImageClickEventArgs e)
        {
            /*novaFreguesia = new Freguesia(Convert.ToInt32(txtconcelhFreg.Text), txtNomeFreg.Text);

            novaFreguesia.InserirFreguesia();

            MessageBox("Freguesia inserida com sucesso!");*/
            db.InserirFreguesia(Convert.ToInt32(txtIDfreguesia.Text), txtNomeFreguesia.Text);
            MessageBox("Freguesia inserida com sucesso!");
        }

        protected void btnInserirPraia_Click(object sender, ImageClickEventArgs e)
        {
            /*novaPraia = new Praia(Convert.ToInt32(txtFregPraia.Text), txtNomePraia.Text, txtMoradaPraia.Text, Convert.ToInt32(txtExtenPraia.Text), Convert.ToInt16(txtBandAzul.Text), Convert.ToInt16(txtTempAgua.Text), Convert.ToInt16(txtSoBarco.Text));

            novaPraia.InserirPraia();

            MessageBox("Praia inserida com sucesso!");*/
            db.InserirPraia(Convert.ToInt32(txtIDfreguesia.Text), txtNomePraia.Text, txtMoradaPraia.Text, Convert.ToInt32(txtExtensaoPraia.Text), Convert.ToInt16(txtBandeiraAzul.Text), Convert.ToInt16(txtTemperaturaAgua.Text), Convert.ToInt16(txtAcessoSoBarco.Text), txtLinkP.Text);
            MessageBox("Praia inserida com sucesso!");
        }

        protected void btnInsereHospe_Click(object sender, ImageClickEventArgs e)
        {
            novaHospedagem = new Hospedagem(Convert.ToInt32(txtIDpraiaH.Text), txtNomeHospe.Text, txtMoradaHospe.Text, Convert.ToInt32(txtDistanPraiaH.Text), Convert.ToInt16(txtClassificacaoH.Text), Convert.ToInt16(txtCamping.Text));

            novaHospedagem.InserirHospedagem();

            MessageBox("Hospedagem inserida com sucesso!");
        }

        protected void btnInserirRest_Click(object sender, ImageClickEventArgs e)
        {
            novoRestaurante = new Restaurante(Convert.ToInt32(txtIDpraiaR.Text), txtNomeRest.Text, txtMoradaRest.Text, Convert.ToInt32(txtDistanPraiaR.Text));

            novoRestaurante.InserirRestaurante();

            MessageBox("Restaurante inserido com sucesso!");
        }

        //APAGAR
        protected void btnApagarCon_Click(object sender, ImageClickEventArgs e)
        {
            novoConcelho.ApagarConcelho(txtID.Text);

            MessageBox("Concelho apagado com sucesso!");
        }

        protected void btnApagarFreg_Click(object sender, ImageClickEventArgs e)
        {
            novaFreguesia.ApagarFreguesia(txtID.Text);

            MessageBox("Freguesia apagada com sucesso!");
        }

        protected void btnApagarPraia_Click(object sender, ImageClickEventArgs e)
        {
            novaPraia.ApagarPraia(txtID.Text);

            MessageBox("Praia apagada com sucesso!");
        }

        protected void btnApagarHospe_Click(object sender, ImageClickEventArgs e)
        {
            novaHospedagem.ApagarHospedagem(txtID.Text);

            MessageBox("Hospedagem apagada com sucesso!");
        }

        protected void btnApagarRest_Click(object sender, ImageClickEventArgs e)
        {
            novoRestaurante.ApagarRestaurante(txtID.Text);

            MessageBox("Restaurante apagado com sucesso!");
        }

        //MODIFICAR
        protected void btnModConc_Click(object sender, ImageClickEventArgs e)
        {

            /*novoConcelho = new Concelho(txtNomeConcelho.Text);
            novoConcelho.ActualizarConcelho(txtID.Text);

            MessageBox("Concelho modificado com sucesso!");*/
            db.EditarConcelho(Convert.ToInt32(txtID.Text), txtNomeConcelho.Text);
            MessageBox("Concelho modificado com sucesso!");
        }

        protected void btnModFreg_Click(object sender, ImageClickEventArgs e)
        {

            /*novaFreguesia = new Freguesia(Convert.ToInt32(txtIDconcelho.Text), txtNomeFreguesia.Text);
            novaFreguesia.ActualizarFreguesia(txtID.Text);

            MessageBox("Freguesia modificada com sucesso!");*/
            db.EditarFreguesia(Convert.ToInt32(txtID.Text), Convert.ToInt32(txtIDconcelho.Text), txtNomeFreguesia.Text);
            MessageBox("Freguesia modificada com sucesso!");

        }

        protected void btnModPraia_Click(object sender, ImageClickEventArgs e)
        {

            /*novaPraia = new Praia(Convert.ToInt32(txtIDfreguesia.Text), txtNomePraia.Text, txtMoradaPraia.Text, Convert.ToInt32(txtExtensaoPraia.Text), Convert.ToInt16(txtBandeiraAzul.Text), Convert.ToInt16(txtTemperaturaAgua.Text), Convert.ToInt16(txtAcessoSoBarco.Text));
            novaPraia.ActualizarPraia(txtID.Text);

            MessageBox("Praia modificada com sucesso!");*/
            db.EditarPraia(Convert.ToInt32(txtID.Text), Convert.ToInt32(txtIDfreguesia.Text), txtNomePraia.Text, txtMoradaPraia.Text, Convert.ToInt32(txtExtensaoPraia.Text), Convert.ToInt16(txtBandeiraAzul.Text), Convert.ToInt16(txtTemperaturaAgua.Text), Convert.ToInt16(txtAcessoSoBarco.Text), Convert.ToInt32(txtVotoPosP.Text), Convert.ToInt32(txtVotoNegP), txtLinkP.Text);
            MessageBox("Praia modificada com sucesso!");
        }

        protected void btnModHospe_Click(object sender, ImageClickEventArgs e)
        {

            /*novaHospedagem = new Hospedagem(Convert.ToInt32(txtPraiaMaProxH.Text), txtNomeHosp.Text, txtMoradaHosp.Text, Convert.ToInt32(txtDistPraia.Text), Convert.ToInt16(txtClassifHosp.Text), Convert.ToInt16(txtCampingHosp.Text));
            novaHospedagem.ActualizarHospedagem(txtID.Text);

            MessageBox("Hospedagem modificada com sucesso!");*/
            db.EditarHospedagem(Convert.ToInt32(txtID.Text), Convert.ToInt32(txtIDpraiaH.Text), txtNomeHospe.Text, txtMoradaHospe.Text, Convert.ToInt32(txtDistanPraiaH.Text), Convert.ToInt16(txtClassificacaoH.Text), Convert.ToInt16(txtCamping.Text), Convert.ToInt32(txtVotoPosH.Text), Convert.ToInt32(txtVotoNegH.Text), txtLinkH.Text);
            MessageBox("Hospedagem modificada com sucesso!");
        }

        protected void btnModRest_Click(object sender, ImageClickEventArgs e)
        {

            /*novoRestaurante = new Restaurante(Convert.ToInt32(txtPraiaMaProxR.Text), txtNomeRest.Text, txtMoradaRest.Text, Convert.ToInt32(txtDistPraiaRest.Text));
            novoRestaurante.ActualizarRestaurante(txtID.Text);

            MessageBox("Restaurante modificado com sucesso!");*/
            db.EditarRestaurante(Convert.ToInt32(txtID.Text), Convert.ToInt32(txtIDpraiaR.Text), txtNomeRest.Text, txtMoradaRest.Text, Convert.ToInt32(txtDistanPraiaR.Text), Convert.ToInt32(txtVotoPosR.Text), Convert.ToInt32(txtVotoNegR.Text), txtLinkR.Text);
            MessageBox("Restaurante modificado com sucesso!");
        }
    }
}