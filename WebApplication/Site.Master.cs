﻿using FilmDTOLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{

    public partial class SiteMaster : MasterPage
    {
        //ServiceHostReference.ToolsBDClient s;
        protected string _user = "";
        protected Boolean _connected = false;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void MovieGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void LogoutBtn_Click(object sender, EventArgs e)
        {
            Session["connected"] = false;
        }

        protected void SignIn_Click(object sender, EventArgs e)
        {
            //Connexion = true;
            Session["Master"] = this;
            Server.Transfer("~/LogRegis.aspx");

            //Ou Response.Redirect("page.aspx?query=bla")
        }
        protected void SignUp_Click(object sender, EventArgs e)
        {

        }

        public string User
        {
            get { return _user; }
            set { _user = value; }
        }

        public Boolean Connexion
        {
            get { return _connected; }
            set { _connected = value; }
        }
    }
}