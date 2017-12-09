<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="jumbotron">
        <h1>SmartVideo</h1>
        <p class="lead">SmartVideo est une énorme base de donnée qui vous permet de rechercher tous les films mondiaux. <br /> Vous avez également la possibilité d'effectuer une location de films.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class ="col-md-4">
            <asp:Login ID="LoginForm" runat="server" OnAuthenticate="LoginForm_Authenticate">
            </asp:Login>
        </div>
    </div>
</asp:Content>
