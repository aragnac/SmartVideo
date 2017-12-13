using FilmDTOLibrary;
using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace DAL
{
    public class DBSmartVideo
    {
        public BDSmartVideoDataContext _context = null;
        private static DBSmartVideo _instance;

        public static DBSmartVideo Singleton()
        {
            return _instance ?? (_instance = new DBSmartVideo("ARAGNAC", "BDSmartVideo"));
        }

        public DBSmartVideo(String servername, String dbname)
        {
            String connectionString = "Data Source = " + servername + " ; Initial Catalog =" + dbname + "; Integrated Security = True";

            try
            {
                _context = new BDSmartVideoDataContext(connectionString);
                //MessageBox.Show("Connexion Ouverte ");

            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossible d'ouvrir la connexion! \n" + ex.Message);
            }

        }

        public Boolean addUser(UtilisateurDTO user)
        {
            //Data maping object to our database
            Utilisateur temp = new Utilisateur();
            temp.UserName = user.UserName;
            temp.Password = user.Password;
            temp.Prenom = user.Prenom;
            temp.Nom = user.Nom;

            //Adds an entity in a pending insert state to this System.Data.Linq.Table<TEntity>and parameter is the entity which to be added
            _context.Utilisateur.InsertOnSubmit(temp);
            // executes the appropriate commands to implement the changes to the database
            _context.SubmitChanges();

            return true;
        }

        public List<UtilisateurDTO> GetUtilisateur()
        {
            string query = "SELECT * from Utilisateur;";
            try
            {
                List<UtilisateurDTO> list = _context.ExecuteQuery<UtilisateurDTO>(query).Select(u => new UtilisateurDTO
                {
                    UserName = u.UserName,
                    Password = u.Password,
                    Nom = u.Nom,
                    Prenom = u.Prenom
                }).ToList();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " impossible d'afficher les résultats.");
                return new List<UtilisateurDTO>();
            }
        }

        public List<LocationDTO> getLocation(string username)
        {
            string query = "SELECT * from Location WHERE Username = "+ username + " AND DATEDIFF( day , "+ DateTime.Now +", DateFin ) >= 0;";
            try
            {
                List<LocationDTO> list = _context.ExecuteQuery<LocationDTO>(query).Select(l => new LocationDTO
                {
                    Username = l.Username,
                    IdFilm = l.IdFilm,
                    DateDebut = l.DateDebut,
                    DateFin = l.DateFin
                }).ToList();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " impossible d'afficher les résultats.");
                return new List<LocationDTO>();
            }
        }

        public List<HitDTO> GetHits()
        {
            var query = "select * from Hit order by Hits;";
            try
            {
                List<HitDTO> list = _context.ExecuteQuery<HitDTO>(query).Select(h => new HitDTO
                {
                    IdType = h.IdType,
                    TypeData = h.TypeData,
                    Date = h.Date,
                    Hits = h.Hits
                }).ToList();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " impossible d'afficher les résultats.");
                return new List<HitDTO>();
            }
        }

        public Boolean AddStatistiques(StatistiquesDTO stat)
        {

            //Data maping object to our database
            Statistiques temp = new Statistiques();
            temp.TypeData = stat.TypeData;
            temp.IdType = stat.IdType;
            temp.DateStat = stat.DateStat;
            temp.Position = stat.Position;

            //Adds an entity in a pending insert state to this System.Data.Linq.Table<TEntity>and parameter is the entity which to be added
            _context.Statistiques.InsertOnSubmit(temp);
            // executes the appropriate commands to implement the changes to the database
            _context.SubmitChanges();

            return true;
        }

        public Boolean InsertOrUpdateHit(HitDTO hit)
        {
            Hit temp = new Hit();

            temp.IdType = hit.IdType;
            temp.TypeData = hit.TypeData;
            temp.DateHit = hit.Date;
            temp.Hits = hit.Hits;

            //Update a record
            Hit record = (from h in _context.Hit
                               where h.IdType == temp.IdType where h.DateHit == temp.DateHit
                               select h).SingleOrDefault();

            
            if (record != default(Hit))
            {
                record.Hits = record.Hits + 1;
            }
            else//Si il n'existe pas on ajoute à la table
            {
                _context.Hit.InsertOnSubmit(temp);
            }

            _context.SubmitChanges();

            _context.SubmitChanges();

            return true;
        }

    }
}
