using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using AlgarveBeach;
using System.IO;
using System.Text;

namespace AllgarveBeach.PerfilPraia
{
    public partial class Albufeira_PraiaDaOura : System.Web.UI.Page
    {
        Ficheiros novoficheiro = new Ficheiros();

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void EnviarTesos_Click(object sender, EventArgs e)
        {
            btnvertesos.Visible = true;
            /*if (Session.SessionID)
            {
            lttesos.Text += "<br>" + "Nick disse: " + ComentTesos.Text;
            }
            else+*/

            lttesos.Text += "<table text-align='left' border='1' width='100%'><tr>" +
             "<td style='text-align:left' bgcolor=#ccff00 align=center><b>Data: </b>" + System.DateTime.Today +
             "</tr><tr><td style='text-align:left' bgcolor=#cccccc align=center height='30' width='100%'>Anónimo> " + ComentTesos.Text + " </td></tr></table>";



            System.IO.Directory.CreateDirectory("C://temp//oura");
            novoficheiro.CriarComentarioFile("C://temp//oura//coment.txt", lttesos.Text);
            lttesos.Text = "";
        }

        protected void btnocultartesos_Click(object sender, EventArgs e)
        {
            btnvertesos.Visible = true;
            lttesos.Text = "";
        }

        protected void btnvertesos_Click(object sender, EventArgs e)
        {
            btnocultartesos.Visible = true;
            btnvertesos.Visible = false;

            string path = "C://temp//oura//coment.txt";

            if (!string.IsNullOrEmpty(path))
            {
                string[] readText = File.ReadAllLines(path);
                System.Text.StringBuilder strbuild = new StringBuilder();
                foreach (string s in readText)
                {
                    strbuild.Append(s);
                    strbuild.AppendLine();
                }
                lttesos.Text = strbuild.ToString();
            }
        }
    }
}