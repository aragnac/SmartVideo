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
        public List<FilmDTO> listFilms;
        private ServiceHostReference.ToolsBDClient s;
        public String titre;
        private String VideoID;

        protected void Page_Load(object sender, EventArgs e)
        {
            titre = Request.QueryString["titre"];
            listFilms = new List<FilmDTO>();
            s = new ServiceHostReference.ToolsBDClient();
            listFilms = s.SearchMovies("Films", titre);


            /**
             Gestion du trailer
             */
            String[] substrings = listFilms[0].Trailerpath.Split('=');
            VideoID = substrings[1];

            // this is the YouTube Video ID, here you replace by 
            // the code of the one you want to show
            //string VideoID = "nQJACVmankY";

            // Here this code you show in the label the YouTube Video that you put the code
            LabelShowYouTubeVideo.Text = "<object width='425' height='355'><param name='movie' value='http://www.youtube.com/v/" + VideoID + "'></param><param name='wmode' value='transparent'></param><embed src='http://www.youtube.com/v/" + VideoID + "' type='application/x-shockwave-flash' wmode='transparent' width='650' height='355'></embed></object>";

        }
    }
}