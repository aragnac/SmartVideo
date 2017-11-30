using System.Data.SqlClient;
using DAL;
using FilmDTOLibrary;
using System.Collections.Generic;

namespace BLL
{
    public class DBFilm
    {
        public DBFilm()
        {

        }

        public List<FilmDTO> GetFilms(string table, int start)
        {
            return DB.Singleton().GetFilms(table, start);
        }

        public List<GenreDTO> GetGenreWithId(int id)
        {
            return DB.Singleton().GetGenreWithId(id);
        }

        public List<ActeurDTO> GetActorWithId(int id)
        {
            return DB.Singleton().GetActorWithId(id);
        }

        public List<RealisateurDTO> GetDirectorWithId(int id)
        {
            return DB.Singleton().GetDirectorWithId(id);
        }

    }
}
