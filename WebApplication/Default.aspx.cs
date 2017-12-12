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
        public List<ActeurDTO> listActorsMovie;
        //private string idActor;

        protected void Page_Load(object sender, EventArgs e)
        {
            filmBLL = new DBFilm();
            listFilms = new List<FilmDTO>();
            listActors = new List<ActeurDTO>();

            ListBox1.SelectedIndexChanged += new EventHandler(ListBox1_SelectedIndexChanged);
            searchButton.OnClientClick += new EventHandler(searchButton_Click);
            nextBT.OnClientClick += new EventHandler(NextBT_Click);
            previousBT.OnClientClick += new EventHandler(PreviousBT_Click);

            s = new ServiceHostReference.ToolsBDClient();

            if (!IsPostBack) { 
                try
                {
                    acteurCB.Checked = false;
                    filmCB.Checked = false;
                    Session["offset"] = 1;
                    Session["idActor"] = "1";
                    listFilms = s.GetFilms("Film", offset);
                    ListBox1.DataSource = listActors;
                    ListBox1.DataBind();
                    //MovieGridView.DataSource = s.GetFilms("Film", offset);
                    //MovieGridView.DataBind();
                }
                catch (Exception ex)
                {
                    ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", ex.Message, true);
                }
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

        protected void NextBT_Click(object sender, EventArgs e)
        {
            Session["offset"] = (int)Session["offset"] + 20;

            listFilms = s.GetFilms("Film", (int)Session["offset"]);
            ListBox1.DataSource = listActors;
            ListBox1.DataBind();

        }

        protected void PreviousBT_Click(object sender, EventArgs e)
        {
            if ((int)Session["offset"] != 0)
                Session["offset"] = (int)Session["offset"] - 20;

            listFilms = s.GetFilms("Film", (int)Session["offset"]);
            ListBox1.DataSource = listActors;
            ListBox1.DataBind();
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            if (acteurCB.Checked && !filmCB.Checked) {
                listActors = s.SearchActors("", searchTB.Text);
                listFilms = s.GetFilms("Film", (int)Session["offset"]);
                ListBox1.DataSource = listActors;
                ListBox1.DataBind();
            }
            else
            {
                if(acteurCB.Checked && filmCB.Checked)
                {
                    listActors = s.SearchActors("", searchTB.Text);
                    foreach (ActeurDTO acteur in listActors)
                    {
                        if (acteur.Name.Equals(searchTB.Text))
                        {
                            Session["idActor"] = acteur.Id.ToString();
                        }
                    }
                    listFilms = s.GetMoviesByActor((string)Session["idActor"]);
                }
                else 
                    listFilms = s.SearchMovies("Film", searchTB.Text);
            }

        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            searchTB.Text = ListBox1.SelectedItem.Text;

        }
    }
}