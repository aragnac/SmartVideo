using BLL;
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
        int offset = 1;
        ServiceHostReference.ToolsBDClient s;
        DBFilm filmBLL;
        public List<FilmDTO> listFilms;
        public List<ActeurDTO> listActors;

        protected void Page_Load(object sender, EventArgs e)
        { 
        
            try
            {
                filmBLL = new DBFilm();
                listFilms = new List<FilmDTO>();
                listActors = new List<ActeurDTO>();
                //listFilms = filmBLL.GetFilms("Films", offset);
                s = new ServiceHostReference.ToolsBDClient();
                listFilms = s.GetFilms("Film", offset);
                //MovieGridView.DataSource = s.GetFilms("Film", offset);
                //MovieGridView.DataBind();
            }
            catch (Exception ex)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", ex.Message, true);
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

        protected void nextBT_Click(object sender, EventArgs e)
        {
            offset += 20;

        }

        protected void previousBT_Click(object sender, EventArgs e)
        {
            if (offset != 0)
                offset -= 20;
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            if (acteurCB.Checked) {
                listActors = s.SearchActors("", searchTB.Text);
                ListBox1.DataSource = listActors;
                ListBox1.DataBind();
            }
            else
            {
                listFilms = s.SearchMovies("Film", searchTB.Text);
            }

        }

        protected void acteurCB_CheckedChanged(object sender, EventArgs e)
        {
            if (filmCB.Checked)
                filmCB.Checked = false;
        }

        protected void filmCB_CheckedChanged(object sender, EventArgs e)
        {
            if (acteurCB.Checked)
                acteurCB.Checked = false;
        }
    }
}