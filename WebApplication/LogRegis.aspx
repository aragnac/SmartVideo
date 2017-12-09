<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="LogRegis.aspx.cs" Inherits="WebApplication.LogRegis" EnableEventValidation="false" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
                
    
    <div class="jumbotron">
        <h1>SmartVideo</h1>
        <p class="lead">SmartVideo est une énorme base de donnée qui vous permet de rechercher tous les films mondiaux. <br /> Vous avez également la possibilité d'effectuer une location de films.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class ="col-md-4">
            <h3><%=this.CheckMessage %></h3>
            <table border="0"  >
                <tr>
                    <th colspan="3">Inscription</th>
                </tr>
                <tr>
                    <td> Nom</td>
                    <td><asp:TextBox ID="nomTB" runat="server" /> </td>
                </tr>
                <tr>
                    <td> Prenom</td>
                    <td><asp:TextBox ID="prenomTB" runat="server" /> </td>
                </tr>
                <tr>
                    <td> Username</td>
                    <td><asp:TextBox ID="userNameTB" runat="server" /> </td>
                </tr>
                <tr>
                    <td>Password </td>
                    <td><asp:TextBox ID="passwordTB" runat="server" TextMode="Password" /></td>
                </tr>
                <tr>
                    <td>Confirm Password </td>
                    <td><asp:TextBox ID="passwordBisTB" runat="server" TextMode="Password" /></td>
                </tr>
                <!-- <tr>
                    <td> Email</td>
                    <td>
                        <asp:TextBox ID="txtEmail" runat="server" />
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ErrorMessage="Required" Display="Dynamic" ForeColor="Red"
                            ControlToValidate="txtEmail" runat="server" />
                        <asp:RegularExpressionValidator runat="server" Display="Dynamic" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                            ControlToValidate="txtEmail" ForeColor="Red" ErrorMessage="Invalid email address." />
                    </td>
                </tr> -->
                <tr>
                    <td></td>
                    <td><asp:Button Text="Valider" runat="server" ID="checkButton" OnClick="checkButton_Click" CausesValidation="False"/></td>
                    <td></td>
                </tr>
            </table>
        </div>

    </div>
    
</asp:Content>
