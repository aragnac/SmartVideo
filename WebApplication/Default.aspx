<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" enableEventValidation="false" Inherits="WebApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>SmartVideo</h1>
        <p class="lead">SmartVideo est une énorme base de donnée qui vous permet de rechercher tous les films mondiaux. <br /> Vous avez également la possibilité d'effectuer une location de films.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="ticket" >
        <h4 class ="mainTitle">Rechercher un Film :</h4>
        
        <p>
            <asp:CheckBox ID="acteurCB" runat="server"  Text="Acteur" /><br />
            <asp:CheckBox ID="filmCB" runat="server" Text="Film" /><br />
        </p>
        <p><asp:TextBox ID="searchTB" runat="server" Height="31px" Width="625px" Font-Italic="True"></asp:TextBox></p>
        <%if (this.listActors.Count != 0)
          { %>
         <asp:ListBox ID="ListBox1" runat="server" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="343px"></asp:ListBox>
        <%} %>
        <p>&nbsp;</p>
        <asp:Button ID="searchButton" runat="server" Text="Rechercher" OnClick="searchButton_Click" />

    </div>

    
    <%foreach (FilmDTOLibrary.FilmDTO film in this.listFilms)
      { %>
        <div class="ticket">

                <img src="http://image.tmdb.org/t/p/w185/<% =film.Posterpath %>" alt="Mountain View" >
                <h2 class="title"><%= film.Title %></h2><br / />
                <p> Titre original : <%=film.Original_title %></p><br />
                <p>Durée du film : <%= film.Runtime %> minutes.</p><br />
                <p>Durée du film : <%= film.Runtime %> minutes.</p><br />
                <p>Durée du film : <%= film.Runtime %> minutes.</p><br />


        </div>
    <%} %>

    <!-- <div class="row">
        <div class ="col-md-4" >

            <asp:GridView ID="MovieGridView" HeaderStyle-BackColor="#525151" HeaderStyle-ForeColor="White" runat="server" selectedindex="0" OnRowDataBound = "OnRowDataBound" OnSelectedIndexChanged="MovieGridView_SelectedIndexChanged">
                <selectedrowstyle backcolor="DarkGray"
                forecolor="White"
                font-bold="true"/> 
            </asp:GridView>

            
            <asp:Button ID="previousBT" runat="server" Text="Précédent" OnClick="previousBT_Click" />
            <asp:Button ID="nextBT" runat="server" Text="suivant" OnClick="nextBT_Click" />
        </div>

    </div> -->

</asp:Content>
