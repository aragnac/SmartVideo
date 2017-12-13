<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Locations.aspx.cs" Inherits="WebApplication.Locations" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    
    <div class="ticket">
       <%foreach (FilmDTOLibrary.LocationDTO location in this.listLocations)
           { %> 
            <%this.listFilms = this.s.GetFilmById(Int32.Parse(location.IdFilm)); %>
            <img src="http://image.tmdb.org/t/p/w185/<% =listFilms[0].Posterpath %>" alt="Mountain View" >
            <h2 class="title"><a href="DetailsFilms.aspx?titre=<%= listFilms[0].Title %>"><%= listFilms[0].Title %></a></h2><br / />
            <p>Location effectuée le : <%=location.DateDebut %></p></br>
            <p>Ce film est disponible jusqu'au <%=location.DateFin %></p><br />
        <%} %>
    
    </div>
</asp:Content>
