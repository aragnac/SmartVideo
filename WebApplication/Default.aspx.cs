using FilmDTOLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WCFLibrary;

namespace WebApplication
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ServiceHostReference.ToolsBDClient s;

            try
            {
                s = new ServiceHostReference.ToolsBDClient();
                MovieGridView.DataSource = s.GetFilms("Film", 1);
                MovieGridView.DataBind();
            }
            catch (Exception ex)
            {
                //ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Impossible d atteindre le service WCF')", true);
            }
        }

        protected void MovieGridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (MovieGridView.SelectedRow != null)
            String id = MovieGridView.SelectedRow.Cells[0].Text;
        }

        protected void OnRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Attributes["onclick"] = Page.ClientScript.GetPostBackClientHyperlink(MovieGridView, "Select$" + e.Row.RowIndex);
                e.Row.ToolTip = "Click to select this row.";
            }
        }
    }
}