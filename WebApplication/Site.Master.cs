using FilmDTOLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication
{
    public partial class SiteMaster : MasterPage
    {
        //ServiceHostReference.ToolsBDClient s;

        protected void Page_Load(object sender, EventArgs e)
        {
           /* try
            {
                s = new ServiceHostReference.ToolsBDClient();
                MovieGridView.DataSource = s.GetFilms("Films", 0);
                MovieGridView.DataBind();
                List<FilmDTO> film = new List<FilmDTO>();
                //film = s.GetFilms("Films", 0);
                
            }
            catch (Exception ex)
            {
                //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Impossible d atteindre le service WCF')", true);
            }*/
        }

        protected void MovieGridView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}