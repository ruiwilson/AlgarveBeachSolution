using AlgarveBeach;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AllgarveBeach.PerfilPraia
{
    public partial class Olhao_PraiaDosTesos : System.Web.UI.Page
    {

        Ficheiros f = new Ficheiros();

        protected void Page_Load(object sender, EventArgs e)
        {
            btnocultartesos.Visible = false;
        }

        protected void EnviarTesos_Click(object sender, EventArgs e)
        {
            btnvertesos.Visible = true;

            /*         if (Session.SessionID)
                     {
                     lttesos.Text += "<br>" + "Nick disse: " + ComentTesos.Text;
                     }
                     else+*/

            /*if (Session.SessionID)
            {
            lttesos.Text += "<br>" + "Nick disse: " + ComentTesos.Text;
            }
            else+*/


            lttesos.Text += "<table text-align='left' border='1' width='100%'><tr>" +
             "<td style='text-align:left' bgcolor=#ccff00 align=center><b>Data: </b>" + System.DateTime.Today +
             "</tr><tr><td style='text-align:left' bgcolor=#cccccc align=center height='30' width='100%'>Anónimo> " + ComentTesos.Text + " </td></tr></table>";



            System.IO.Directory.CreateDirectory("C://temp//tesos");
            f.CriarComentarioFile("C://temp//tesos//coment.txt", lttesos.Text);
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

            string path = "C://temp//tesos//coment.txt";

            if (string.IsNullOrEmpty(path))
            {
                System.IO.Directory.CreateDirectory("C://temp//tesos");
                f.CriarComentarioFile("C://temp//tesos//coment.txt", lttesos.Text);
            }
            else

            
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