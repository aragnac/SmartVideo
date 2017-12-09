using BLL;
using FilmDTOLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class Login : System.Web.UI.Page
    {
        DBSmartVideoBLL smartvideoBLL;

        protected void Page_Load(object sender, EventArgs e)
        {
            smartvideoBLL = new DBSmartVideoBLL();
        }

        protected void LoginForm_Authenticate(object sender, AuthenticateEventArgs e)
        {
            bool exist = false, check = false;

            List<UtilisateurDTO> temp = smartvideoBLL.getUser();
            foreach (UtilisateurDTO user in temp)
            {
                if (user.UserName.Equals(LoginForm.UserName))
                {
                    exist = true;
                    if (user.Password.Equals(LoginForm.Password))
                    {
                        check = true;
                    }
                }
            }
            //Si il n'existe pas on l'ajoute à la base
            if (exist)
            {
                if (check)
                {
                    Session["connected"] = true;
                    Session["user"] = LoginForm.UserName;
                    Response.Write("<script>alert('Connecté !');</script>");
                }
                else
                {
                    LoginForm.FailureText = "Mot de passe erroné.";
                }
            }
            else
            {
                LoginForm.FailureText = "Ce nom d'utilisateur n'existe pas.";
            }
           
        }

    }
}