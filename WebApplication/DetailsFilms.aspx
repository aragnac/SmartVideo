<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DetailsFilms.aspx.cs" Inherits="WebApplication.DetailsFilms" %>


<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
        
    <div class="jumbotron">
        <h1>SmartVideo</h1>
        <p class="lead">SmartVideo est une énorme base de donnée qui vous permet de rechercher tous les films mondiaux. <br /> Vous avez également la possibilité d'effectuer une location de films.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>   
    
    <%switch(this.ERROR) { %>
        <% case 1: %> <div class="info">Veuillez vous connecter afin de pouvoir louer ce film.</div>
        <%break; %>
        <%case 2: %>  <div class="warning">Ce film est deja en cours de location.</div>
        <%break; %>
        <%case 3: %> <div class="success">Film ajouté à vos locations avec succès !</div>
        <%break; %>

    <% } %>

    <%foreach (FilmDTOLibrary.FilmDTO film in this.getListFilms)
      { %>
        <div class="ticket">

            <img src="http://image.tmdb.org/t/p/w185/<% =film.Posterpath %>" alt="Mountain View" >
            <h2 class="title"><%= film.Title %></h2><br / />
            <p> Titre original : <%=film.Original_title %></p><br />
            <p>Durée du film : <%= film.Runtime %> minutes.</p><br />
            <%int i = 0; %>
            <p>Acteurs : <%foreach (FilmDTOLibrary.ActeurDTO acteur in film.Acteurlist)
                            {
                                    if (i < 20)
                                    {%>
                                    <%=acteur.Name + "(" + acteur.Character + ")" + ", " %>
                                    <%i++; %>
                                    <%}
                            }%>
                ...
            </p><br />
            <p>Réalisateurs : <%foreach (FilmDTOLibrary.RealisateurDTO real in film.Realisateurlist)
                    { %>
                <%=real.Name + ", " %>
                <%} %>
            </p><br />
            <p>Genre: <%foreach (FilmDTOLibrary.GenreDTO genre in film.Genrelist)
                    { %>
                <%=genre.Name + ", " %>
                <%} %>
            </p><br />
            <!--<iframe width="560" height="315" src="<%=film.Trailerpath %>" runat="server" frameborder="0" gesture="media" allow="encrypted-media" allowfullscreen></iframe>-->
            <div style="text-align:center">
                <%if (film.Trailerpath == null)
                    { %>
                <div class="info">Le trailer pour ce film n'est pas disponible.</div>
                <%}
                else
                { %>
                <asp:Label ID="LabelShowYouTubeVideo" runat="server"></asp:Label>
                <%} %>
                <br />
            </div>

            <div style="text-align:center">
                
                <asp:Button ID="locationBT" runat="server" Text="Louer ce film!" OnClick="locationBT_Click" />
            
            </div>

        </div>
    <%} %>
</asp:Content>
