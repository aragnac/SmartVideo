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
    public partial class LogRegis : System.Web.UI.Page
    {
        DBSmartVideoBLL smartvideoBLL;
        private string _checkMessage="";

        protected void Page_Load(object sender, EventArgs e)
        {
            smartvideoBLL = new DBSmartVideoBLL();
        }


        public string CheckMessage
        {
            get { return _checkMessage; }
        }

        protected void checkButton_Click(object sender, EventArgs e)
        {
            bool exist = false;

            if (Check_Fields()) {

                List<UtilisateurDTO> temp = smartvideoBLL.getUser();
                foreach (UtilisateurDTO user in temp)
                {
                    if (user.UserName == prenomTB.Text)
                    {
                        _checkMessage = "Ce nom d'utilisateur existe deja";
                        exist = true;
                    }
                }
                //Si il n'existe pas on l'ajoute à la base
                if (!exist)
                {
                    smartvideoBLL.addUser(new UtilisateurDTO(userNameTB.Text, passwordTB.Text, nomTB.Text, prenomTB.Text));
                    _checkMessage = "Enregistrement effectué avec succès";
                }
                Session["connected"] = true;
            }
        }

        private Boolean Check_Fields()
        {
            bool exit = true;

            if(nomTB.Text.Equals("") || prenomTB.Text.Equals("") || userNameTB.Text.Equals("") || passwordTB.Text.Equals(""))
            {
                _checkMessage = "Tous les champs marqué d'une * doivent être rempli.";
                exit = false;
            }
            if (!passwordTB.Text.Equals(passwordBisTB.Text))
            {
                _checkMessage = "Erreur de correspondance entre les Mots de passe.";
                exit = false;
            }

            return exit;
        }
    }
}