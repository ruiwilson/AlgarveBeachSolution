﻿using AlgarveBeach;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AllgarveBeach
{
    public partial class Galleries : System.Web.UI.Page
    {
        Ficheiros f = new Ficheiros();

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void EnviarTesos_Click(object sender, EventArgs e)
        {
   /*         if (Session.SessionID)
            {
            lttesos.Text += "<br>" + "Nick disse: " + ComentTesos.Text;
            }
            else+*/
            lttesos.Text += "<br>Data: " + System.DateTime.Today + "<br>Anónimo> " + ComentTesos.Text + " <<br><hr>";

            FileStream sw = File.Create("C://temp//tesos//coment.txt");


            f.CriarComentarioFile("C://temp//tesos//coment.txt",lttesos.Text);
            lttesos.Text = "";
        }
    }
}