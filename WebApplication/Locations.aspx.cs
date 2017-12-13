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
    public partial class Locations : System.Web.UI.Page
    {
        private DBSmartVideoBLL dbSmartVideo;
        public List<LocationDTO> listLocations;
        public List<FilmDTO> listFilms;
        public ServiceHostReference.ToolsBDClient s;

        protected void Page_Load(object sender, EventArgs e)
        {
            dbSmartVideo = new DBSmartVideoBLL();
            listLocations = new List<LocationDTO>();
            listFilms = new List<FilmDTO>();
            s = new ServiceHostReference.ToolsBDClient();

            //On charge les locations pour l'utilisateur courant
            listLocations = dbSmartVideo.getLocation((String)Session["user"]);
        }
    }
}