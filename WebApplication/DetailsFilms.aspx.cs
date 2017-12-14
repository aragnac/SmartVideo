using BLL;
using FilmDTOLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class DetailsFilms : System.Web.UI.Page
    {
        private static ServiceHostReference.ToolsBDClient s;
        private static DBSmartVideoBLL dbSmartVideo;
        private static String VideoID;
        public static List<FilmDTO> listFilms;
        public static String titre;
        public static int _ERROR; //1 = pas connecté, 2 = location existe, 3 = location ok

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                titre = Request.QueryString["titre"];
                s = new ServiceHostReference.ToolsBDClient();
                dbSmartVideo = new DBSmartVideoBLL();
                listFilms = new List<FilmDTO>();
                listFilms = s.SearchMovies("Films", titre);
                _ERROR = 0;

                /*
                Gestion du trailer
                */
                if (listFilms[0].Trailerpath != null)
                {
                    String[] substrings = listFilms[0].Trailerpath.Split('=');
                    //Getting video ID
                    VideoID = substrings[1];
                }
            }
            else {
                //todo only on postback
            }


            // Display youtube video
            if(listFilms[0].Trailerpath != null)
                LabelShowYouTubeVideo.Text = "<object width='425' height='355'><param name='movie' value='http://www.youtube.com/v/" + VideoID + "'></param><param name='wmode' value='transparent'></param><embed src='http://www.youtube.com/v/" + VideoID + "' type='application/x-shockwave-flash' wmode='transparent' width='650' height='355'></embed></object>";

        }

        public int ERROR
        {
            get { return _ERROR; }
        }

        public List<FilmDTO> getListFilms
        {
            get { return listFilms; }
        }

        protected void locationBT_Click(object sender, EventArgs e)
        {
            if (!(bool)Session["connected"])
            {
                _ERROR = 1;
            }
            else
            {
                if(!dbSmartVideo.InsertLocation(new LocationDTO(listFilms[0].Id, (String)Session["user"], DateTime.Now, DateTime.Now))){
                    _ERROR = 2;
                }
                else
                {
                    _ERROR = 3;
                }
            }
        }
    }
}