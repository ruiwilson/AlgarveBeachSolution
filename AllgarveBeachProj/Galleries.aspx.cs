﻿using AlgarveBeach;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
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
        /*    btnocultartesos.Visible = true;
            btnvertesos.Visible = false;

            string path = "C://temp//tesos//coment.txt";
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
            }*/
        }

        protected void EnviarTesos_Click(object sender, EventArgs e)
        {
   /*         if (Session.SessionID)
            {
            lttesos.Text += "<br>" + "Nick disse: " + ComentTesos.Text;
            }
            else+*/
            lttesos.Text += "<br>Data: " + System.DateTime.Today + "<br>Anónimo> " + ComentTesos.Text + " <<br><hr>";


            System.IO.Directory.CreateDirectory("C://temp//tesos");
            f.CriarComentarioFile("C://temp//tesos//coment.txt",lttesos.Text);
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