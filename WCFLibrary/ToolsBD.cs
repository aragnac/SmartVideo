using BLL;
using FilmDTOLibrary;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Web.Services;
using System.Web.Services.Description;

namespace WCFLibrary
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" à la fois dans le code et le fichier de configuration.
    [CollectionDataContract]
    public class ToolsBD : IToolsBD
    {

        public static DBFilm filmBLL = new DBFilm();

        public List<FilmDTO> GetFilms(string table, int start)
        {
            return filmBLL.GetFilms(table, start);
        }

        public List<FilmDTO> SearchMovies(string table, string search)
        {
            return filmBLL.SearchMovies(table, search);
        }

        public List<FilmDTO> GetMoviesByActor(string id)
        {
            return filmBLL.GetMoviesByActor(id);
        }

        public List<ActeurDTO> SearchActors(string table, string search)
        {
            return filmBLL.SearchActors(table, search);
        }

        public List<FilmDTO> GetFilmById(int id)
        {
            return filmBLL.GetFilmById(id);
        }

        public Boolean InsertTrailer(string trailer, int id)
        {
            return filmBLL.InsertTrailer(trailer, id);
        }
    }
}
