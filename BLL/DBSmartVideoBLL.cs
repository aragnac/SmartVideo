using DAL;
using FilmDTOLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DBSmartVideoBLL
    {
        DBSmartVideo database;

        public DBSmartVideoBLL()
        {
            database = DBSmartVideo.Singleton();
        }

        public void addUser(UtilisateurDTO user)
        {
            database.addUser(user);
        }

        public List<UtilisateurDTO> getUser()
        {
            return database.GetUtilisateur();
        }
    }
}
