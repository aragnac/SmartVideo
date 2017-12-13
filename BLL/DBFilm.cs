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

        public List<FilmDTO> SearchMovies(string table, string search)
        {
            return database.SearchMovies(table, search);
        }

        public List<FilmDTO> GetMoviesByActor(string id)
        {
            return database.GetMoviesByActor(id);
        }

        public List<FilmDTO> GetFilmById(int id)
        {
            return database.GetFilmById(id);
        }

        public List<ActeurDTO> SearchActors(string table, string search)
        {
            return database.SearchActors(table, search);
        }

        /*public bool addTrailer(string trailerPath)
        {
            return database.addTrailer;
        }*/

    }
}
