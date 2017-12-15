using BLL;
using FilmDTOLibrary;
using System;
using System.Collections.Generic;

namespace WebApplication
{
    public partial class Tops : System.Web.UI.Page
    {
        private static DBSmartVideoBLL DBStat;
        private static List<StatistiquesDTO> listeStats;
        private static DBFilm dbFilm;
        public List<ActeurDTO> listeActors;
        public List<FilmDTO> listeFilms;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DBStat = new DBSmartVideoBLL();
                dbFilm = new DBFilm();
                listeStats = new List<StatistiquesDTO>();
                listeActors = new List<ActeurDTO>();
                listeFilms = new List<FilmDTO>();

                listeStats = DBStat.GetStatistiques(DateTime.Now);
                GetActorsMovies();
            }

        }

        private void GetActorsMovies()
        {
            foreach(StatistiquesDTO stat in listeStats)
            {
                if (stat.TypeData.Equals("Film"))
                {
                    listeFilms.AddRange(dbFilm.GetFilmById(Int32.Parse(stat.IdType)));
                }
                else //sinon on rempli la liste des acteurs
                {
                    listeActors.AddRange(dbFilm.GetActorById(Int32.Parse(stat.IdType)));
                }
            }
        }

        public List<StatistiquesDTO> GetListeStats
        {
            get { return listeStats; }
        }

        public DBFilm DbFilm
        {
            get { return dbFilm; }
        }
    }
}