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

        public List<LocationDTO> getLocation(string username)
        {
            return database.getLocation( username);
        }

        public List<HitDTO> GetHits()
        {
            return database.GetHits();   
        }

        public Boolean AddStatistiques(StatistiquesDTO stat)
        {
            if(database.AddStatistiques(stat))
                return true;
            else
                return false;
        }

        public Boolean InsertLocation(LocationDTO location)
        {
            //calcul de la date de fin 
            location.DateFin = location.DateDebut.AddMonths(3);
            if (database.InsertLocation(location))
                return true;
            else
                return false;
        }

        public Boolean InsertOrUpdateHit(HitDTO hit)
        {
            if (database.InsertOrUpdateHit(hit))
                return true;
            else
                return false;
        }
    }
}
