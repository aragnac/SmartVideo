<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Locations.aspx.cs" Inherits="WebApplication.Locations" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    
       <%foreach (FilmDTOLibrary.LocationDTO location in this.listLocations)
           { %> 
    <div class="ticket">
            <%if (location.DateFin.CompareTo(DateTime.Now) < 0)
                { %>
                <%this.listFilms = this.s.GetFilmById(Int32.Parse(location.IdFilm)); %>
                <img src="http://image.tmdb.org/t/p/w185/<% =listFilms[0].Posterpath %>" alt="Mountain View" >
                <h2 class="title"><a href="DetailsFilms.aspx?titre=<%= listFilms[0].Title %>"><%= listFilms[0].Title %></a></h2><br / />
                <p>Location effectuée le : <%=location.DateDebut.Date %></p><br />
                <p>Ce film est disponible jusqu'au <%=location.DateFin.Date %></p><br />
                <br />
                <br />
                <br />
                <br />
            <%} %>
        </div>
        <%} %>
    
</asp:Content>
