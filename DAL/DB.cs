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
                //MessageBox.Show("Connexion Ouverte ");

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
                List<FilmDTO> list = _context.ExecuteQuery<FilmDTO>(query).Skip(start).Take(10).Select(f => new FilmDTO
                {
                    Id = f.Id,
                    Title = f.Title,
                    Original_title = f.Original_title,
                    Runtime = f.Runtime,
                    Posterpath = f.Posterpath,
                    Trailerpath = f.Trailerpath,
                    Genrelist = GetGenreWithId(f.Id),
                    Acteurlist = GetActorWithId(f.Id),
                    Realisateurlist = GetDirectorWithId(f.Id)
                    
                }).ToList();
                return list;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " impossible d'afficher les résultats.");
                return new List<FilmDTO>();
            }
        }

        public List<FilmDTO> GetFilmById(int id)
        {
            var query = "SELECT * FROM Film WHERE id = "+ id +";";
            try
            {
                List<FilmDTO> list = _context.ExecuteQuery<FilmDTO>(query).Select(f => new FilmDTO
                {
                    Id = f.Id,
                    Title = f.Title,
                    Original_title = f.Original_title,
                    Runtime = f.Runtime,
                    Posterpath = f.Posterpath,
                    Trailerpath = f.Trailerpath,
                    Genrelist = GetGenreWithId(f.Id),
                    Acteurlist = GetActorWithId(f.Id),
                    Realisateurlist = GetDirectorWithId(f.Id)

                }).ToList();
                return list;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + " impossible d'afficher les résultats.");
                return new List<FilmDTO>();
            }
        }

        public List<FilmDTO> GetMoviesByActor(string id)
        {
            var query = "select distinct Film.* from Film INNER JOIN FilmActor on FilmActor.id_film = Film.id WHERE FilmActor.id_actor = " + id + ";";

            try
            {
                List<FilmDTO> list = _context.ExecuteQuery<FilmDTO>(query).Select(f => new FilmDTO
                {
                    Id = f.Id,
                    Title = f.Title,
                    Original_title = f.Original_title,
                    Runtime = f.Runtime,
                    Posterpath = f.Posterpath,
                    Trailerpath = f.Trailerpath,
                    Genrelist = GetGenreWithId(f.Id),
                    Acteurlist = GetActorWithId(f.Id),
                    Realisateurlist = GetDirectorWithId(f.Id)
                }).ToList();
                return list;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message + " impossible d'afficher les résultats.");
                return new List<FilmDTO>();
            }
        }

        public List<FilmDTO> SearchMovies(string table, string search)
        {
            var query = "select * from Film where title LIKE '%" + search + "%' or original_title LIKE '%" + search + "%';";

            try
            {
                List<FilmDTO> list = _context.ExecuteQuery<FilmDTO>(query).Select(f => new FilmDTO
                {
                    Id = f.Id,
                    Title = f.Title,
                    Original_title = f.Original_title,
                    Runtime = f.Runtime,
                    Posterpath = f.Posterpath,
                    Trailerpath = f.Trailerpath,
                    Genrelist = GetGenreWithId(f.Id),
                    Acteurlist = GetActorWithId(f.Id),
                    Realisateurlist = GetDirectorWithId(f.Id)
                }).ToList();
                return list;

            }catch(Exception e)
            {
                Console.WriteLine(e.Message + " impossible d'afficher les résultats.");
                return new List<FilmDTO>();
            }
        }

        public List<ActeurDTO> SearchActors(string table, string search)
        {
            var query = "select * from Actor where name LIKE '%" + search + "%';";

            try
            {
                List<ActeurDTO> list = _context.ExecuteQuery<ActeurDTO>(query).Select(a => new ActeurDTO
                {
                    Name = a.Name,
                    Id = a.Id,
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

        public List<GenreDTO> GetGenreWithId(int id)
        {
            var query = "SELECT distinct Genre.* FROM FilmGenre INNER JOIN Genre ON FilmGenre.id_genre = Genre.id WHERE FilmGenre.id_film = " + id + ";";
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
            var query = "SELECT distinct Actor.* FROM FilmActor INNER JOIN Actor ON FilmActor.id_actor = Actor.id WHERE FilmActor.id_film = " + id + ";";
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

        public List<ActeurDTO> GetActorById(int id)
        {
            var query = "SELECT distinct * FROM Actor WHERE id =" + id + ";";
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
            var query = "SELECT distinct Realisateur.* FROM FilmRealisateur INNER JOIN Realisateur ON FilmRealisateur.id_realisateur = Realisateur.id WHERE FilmRealisateur.id_film = " + id + ";";
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

        public Boolean InsertTrailer(string trailer, int id)
        {
            //UPDATE Film SET trailerpath = 'https://www.youtube.com/watch?v=8dxh3lwdOFw' WHERE id = 15;

            //Update a record
            Film record = (from f in _context.Film
                           where f.id == id
                          select f).SingleOrDefault();


            if (record != default(Film))
            {
                record.trailerpath = trailer;
            }

            _context.SubmitChanges();

            return true;
        }
    }
}
