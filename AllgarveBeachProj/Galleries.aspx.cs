﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace AllgarveBeach
{
    public partial class Galleries : System.Web.UI.Page
    {
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
            lttesos.Text += "<br>Anónimo> " + ComentTesos.Text + " <" + System.DateTime.Today;
        }
    }
}