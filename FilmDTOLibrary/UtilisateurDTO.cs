using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmDTOLibrary
{
    public class UtilisateurDTO
    {
        private string _username;
        private string _password;
        private string _nom;
        private string _prenom;


        public string UserName
        {
            get{return _username;}
            set{_username = value;}
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }

        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }

        public UtilisateurDTO(string username, string pass, string nom, string prenom)
        {
            UserName = username;
            Password = pass;
            Nom = nom;
            Prenom = prenom;
        }

        public UtilisateurDTO()
        {
        }
    }
}
