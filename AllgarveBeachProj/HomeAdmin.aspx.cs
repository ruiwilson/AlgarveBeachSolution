using AlgarveBeach;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

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

        Concelho[] concelho;//METODO NO GestaoPraias
        Freguesia[] freguesia;

        protected void Page_Load(object sender, EventArgs e)
        {
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

                novoConcelho.CarregarConcelho(txtID.Text);
                ltresultados.Text = novoConcelho.Caracteriza();
                MessageBox("Concelho carregado com sucesso!");

            }
            else
            {
                ltresultados.Text = "";
                foreach (Concelho c in concelho)
                {
                    ltresultados.Text += c.NomeConcelho + "\r\n";
                }
            }
        }


        //VISUALIZAR
        protected void btnVerFreg_Click(object sender, ImageClickEventArgs e)
        {
            if (txtID.Text != "")
            {
                novaFreguesia.CarregarFreguesia(txtID.Text);
                ltresultados.Text = novaFreguesia.Caracteriza();
                MessageBox("Freguesia carregada com sucesso!");
            }
            else
            {
                ltresultados.Text = "";
                foreach (Freguesia f in freguesia)
                {
                    ltresultados.Text += "IDconcelho: " + f.IDconcelho + "\r\n" + "NomeFreguesia: " + f.NomeFreguesia + "\r\n";
                }
            }
        }

        protected void btnVerPraia_Click(object sender, ImageClickEventArgs e)
        {

            novaPraia.CarregarPraia(txtID.Text);
            ltresultados.Text = novaPraia.Caracteriza();
            MessageBox("Praia carregada com sucesso!");

        }

        protected void btnVerHospe_Click(object sender, ImageClickEventArgs e)
        {

            novaHospedagem.CarregarHospedagem(txtID.Text);
            ltresultados.Text = novaHospedagem.Caracteriza();
            MessageBox("Hospedagem carregada com sucesso!");

        }

        protected void btnVerRest_Click(object sender, ImageClickEventArgs e)
        {

            novoRestaurante.CarregarRestaurante(txtID.Text);
            ltresultados.Text = novoRestaurante.Caracteriza();
            MessageBox("Restaurante carregado com sucesso!");

        }

        //INSERIR
        protected void btnInserirConc_Click(object sender, ImageClickEventArgs e)
        {
            novoConcelho = new Concelho(txtNomeConcelho.Text);

            novoConcelho.InserirConcelho();

            MessageBox("Concelho inserido com sucesso!");
        }

        protected void btnInserirFreg_Click(object sender, ImageClickEventArgs e)
        {
            novaFreguesia = new Freguesia(Convert.ToInt32(txtconcelhFreg.Text), txtNomeFreg.Text);

            novaFreguesia.InserirFreguesia();

            MessageBox("Freguesia inserida com sucesso!");
        }

        protected void btnInserirPraia_Click(object sender, ImageClickEventArgs e)
        {
            novaPraia = new Praia(Convert.ToInt32(txtFregPraia.Text), txtNomePraia.Text, txtMoradaPraia.Text, Convert.ToInt32(txtExtenPraia.Text), Convert.ToInt16(txtBandAzul.Text), Convert.ToInt16(txtTempAgua.Text), Convert.ToInt16(txtSoBarco.Text), Convert.ToInt16(txtPHospedagem.Text), Convert.ToInt16(txtPRestaurante.Text));

            novaPraia.InserirPraia();

            MessageBox("Praia inserida com sucesso!");
        }

        protected void btnInsereHospe_Click(object sender, ImageClickEventArgs e)
        {
            novaHospedagem = new Hospedagem(Convert.ToInt32(txtPraiaMaProxH.Text), txtNomeHosp.Text, txtMoradaHosp.Text, Convert.ToInt32(txtDistPraia.Text), Convert.ToInt16(txtClassifHosp.Text), Convert.ToInt16(txtCampingHosp.Text));

            novaHospedagem.InserirHospedagem();

            MessageBox("Hospedagem inserida com sucesso!");
        }

        protected void btnInserirRest_Click(object sender, ImageClickEventArgs e)
        {
            novoRestaurante = new Restaurante(Convert.ToInt32(txtPraiaMaProxR.Text), txtNomeRest.Text, txtMoradaRest.Text, Convert.ToInt32(txtDistPraiaRest.Text));

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

            novoConcelho = new Concelho(txtNomeConcelho.Text);
            novoConcelho.ActualizarConcelho(txtID.Text);

            MessageBox("Concelho modificado com sucesso!");
        }

        protected void btnModFreg_Click(object sender, ImageClickEventArgs e)
        {

            novaFreguesia = new Freguesia(Convert.ToInt32(txtconcelhFreg.Text), txtNomeFreg.Text);
            novaFreguesia.ActualizarFreguesia(txtID.Text);

            MessageBox("Freguesia modificada com sucesso!");
        }

        protected void btnModPraia_Click(object sender, ImageClickEventArgs e)
        {

            novaPraia = new Praia(Convert.ToInt32(txtFregPraia.Text), txtNomePraia.Text, txtMoradaPraia.Text, Convert.ToInt32(txtExtenPraia.Text), Convert.ToInt16(txtBandAzul.Text), Convert.ToInt16(txtTempAgua.Text), Convert.ToInt16(txtSoBarco.Text), Convert.ToInt16(txtPHospedagem.Text), Convert.ToInt16(txtPRestaurante.Text));
            novaPraia.ActualizarPraia(txtID.Text);

            MessageBox("Praia modificada com sucesso!");
        }

        protected void btnModHospe_Click(object sender, ImageClickEventArgs e)
        {

            novaHospedagem = new Hospedagem(Convert.ToInt32(txtPraiaMaProxH.Text), txtNomeHosp.Text, txtMoradaHosp.Text, Convert.ToInt32(txtDistPraia.Text), Convert.ToInt16(txtClassifHosp.Text), Convert.ToInt16(txtCampingHosp.Text));
            novaHospedagem.ActualizarHospedagem(txtID.Text);

            MessageBox("Hospedagem modificada com sucesso!");
        }

        protected void btnModRest_Click(object sender, ImageClickEventArgs e)
        {

            novoRestaurante = new Restaurante(Convert.ToInt32(txtPraiaMaProxR.Text), txtNomeRest.Text, txtMoradaRest.Text, Convert.ToInt32(txtDistPraiaRest.Text));
            novoRestaurante.ActualizarRestaurante(txtID.Text);

            MessageBox("Restaurante modificado com sucesso!");
        }
    }
}