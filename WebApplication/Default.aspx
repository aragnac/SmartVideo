<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" enableEventValidation="false" Inherits="WebApplication._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class ="col-md-4">

            <asp:GridView ID="MovieGridView" HeaderStyle-BackColor="#525151" HeaderStyle-ForeColor="White" runat="server" selectedindex="0" OnRowDataBound = "OnRowDataBound" OnSelectedIndexChanged="MovieGridView_SelectedIndexChanged">
                <selectedrowstyle backcolor="DarkGray"
                forecolor="White"
                font-bold="true"/> 
            </asp:GridView>
             <asp:LinkButton ID="lnkDummy" runat="server"></asp:LinkButton>
        </div>

    </div>

</asp:Content>
