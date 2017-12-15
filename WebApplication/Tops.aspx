<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Tops.aspx.cs" Inherits="WebApplication.Tops" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>Les Tops</h1>
        <p class="lead">Vous retrouvez dans cette section un classement quotidien des 3 films ainsi que des 3 acteurs les plus recherché sur notre site.<br /></p>
        
    </div> 
    
    <div class="ticket">
        <div class = "top" style="width: 49%; float:left">
            <h2 class="toptitle" style="color: cadetblue;">Top Films</h2><br />
            <%int i = 0; %>
            <%foreach (FilmDTOLibrary.FilmDTO film in this.listeFilms) {
                    i++;%>
              <p><%=i %> : <%=film.Original_title %></p><br />
            <%} %>
        </div>

        <div class = "top" style="width: 49%; float:right; display : contents">
            <h2 class="toptitle" style="color: cadetblue;">Top Acteurs</h2><br />
            <%int j = 0; %>
            <%foreach (FilmDTOLibrary.ActeurDTO actor in this.listeActors) {
                    j++;%>
              <p><%=j %> : <%=actor.Name %> (<%=actor.Character %>)</p><br />
            <%} %>
        </div>
    </div>
</asp:Content>
