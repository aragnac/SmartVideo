using FilmDTOLibrary;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows;

namespace DAL
{

    public class DB
    {
        public DataClassesDataContext _context = null;
        private static DB _instance;

        public static DB Singleton()
        {
            return _instance ?? (_instance = new DB("ARAGNAC", "FilmDB"));
        }

        public DB(String servername, String dbname)
        {
            String connectionString = "Data Source = " + servername + " ; Initial Catalog =" + dbname + "; Integrated Security = True";

            try {
                _context = new DataClassesDataContext(connectionString);
                MessageBox.Show("Connexion Ouverte ");

            }catch (Exception ex) {
                MessageBox.Show("Impossible d'ouvrir la connexion! \n" + ex.Message);
            }



        }

        /*public void CloseConnexionBD()
        {
            try
            {
                conn.Close();
                MessageBox.Show("Base de données déconnectée");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Déconnexion de la base de données impossible ! \n" + ex.Message);
            }

        }*/

        public List<FilmDTO> GetFilms(string table, int start)
        {
            var query = "SELECT * FROM "+ table + ";";
            try
            {
                List<FilmDTO> list = _context.ExecuteQuery<FilmDTO>(query).Skip(start).Take(20).Select(f => new FilmDTO
                {
                    Id = f.Id,
                    Title = f.Title,
                    Original_title = f.Original_title,
                    Runtime = f.Runtime,
                    Posterpath = f.Posterpath,
                    Trailerpath = f.Trailerpath
                }).ToList();
                return list;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " impossible d'afficher les résultats.");
                return new List<FilmDTO>();
            }
        }

        public List<GenreDTO> GetGenreWithId(int id)
        {
            var query = "SELECT Genre.* FROM FilmGenre INNER JOIN Genre ON FilmGenre.id_genre = Genre.id WHERE FilmGenre.id_film = " + id + ";";
            try
            {
                var list = _context.ExecuteQuery<GenreDTO>(query).Select(g => new GenreDTO
                {
                    Id = g.Id,
                    Name = g.Name
                }).ToList();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " impossible d'afficher les résultats.");
                return new List<GenreDTO>();
            }
        }

        public List<ActeurDTO> GetActorWithId(int id)
        {
            var query = "SELECT Actor.* FROM FilmActor INNER JOIN Actor ON FilmActor.id_actor = Actor.id WHERE FilmActor.id_film = " + id + ";";
            try
            {
                var list = _context.ExecuteQuery<ActeurDTO>(query).Select(a => new ActeurDTO
                {
                    Id = a.Id,
                    Name = a.Name,
                    Character = a.Character
                }).ToList();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " impossible d'afficher les résultats.");
                return new List<ActeurDTO>();
            }
        }

        public List<RealisateurDTO> GetDirectorWithId(int id)
        {
            var query = "SELECT Realisateur.* FROM FilmRealisateur INNER JOIN Realisateur ON FilmRealisateur.id_realisateur = Realisateur.id WHERE FilmRealisateur.id_film = " + id + ";";
            try
            {
                var list = _context.ExecuteQuery<RealisateurDTO>(query).Select(g => new RealisateurDTO
                {
                    Id = g.Id,
                    Name = g.Name

                }).ToList();
                return list;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " impossible d'afficher les résultats.");
                return new List<RealisateurDTO>();
            }
        }
    }
}
