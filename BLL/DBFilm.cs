using System.Data.SqlClient;
using DAL;
using FilmDTOLibrary;
using System.Collections.Generic;
using System.Windows;

namespace BLL
{
    public class DBFilm
    {
        DB database;

        public DBFilm()
        {
            database = DB.Singleton();
        }

        public List<FilmDTO> GetFilms(string table, int start)
        {
            return database.GetFilms(table, start);
        }

        public List<GenreDTO> GetGenreWithId(int id)
        {
            return database.GetGenreWithId(id);
        }

        public List<ActeurDTO> GetActorWithId(int id)
        {
            return database.GetActorWithId(id);
        }

        public List<RealisateurDTO> GetDirectorWithId(int id)
        {
            return database.GetDirectorWithId(id);
        }

        /*public bool addTrailer(string trailerPath)
        {
            return database.addTrailer;
        }*/

    }
}
