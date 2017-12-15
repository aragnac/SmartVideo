<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebApplication.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">  
  
    <html>  
      <head>  
            <title></title>  
            <meta name="viewport" content="initial-scale=1.0, user-scalable=no">  
            <meta charset="utf-8">  
            <style type="text/css">  
              html, body, #canvasMap {  
                height: 100%;  
                margin: 0px;  
                padding: 0px  
              }  
            </style>  
            <script type="text/javascript" src="https://maps.googleapis.com/maps/api/js?v=3.exp"></script>  
            <script type="text/javascript">  
                var map;
                function LoadGoogleMAP() {
                    var SetmapOptions = {
                        zoom: 10,
                        center: new google.maps.LatLng(-34.397, 150.644)
                    };
                    map = new google.maps.Map(document.getElementById('canvasMap'),
                        SetmapOptions);
                }

                google.maps.event.addDomListener(window, 'load', LoadGoogleMAP);

            </script>  
          </head>  
  <body>  
      
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
        <div id="canvasMap"> </div>  
  </body>  

</html>  
</asp:Content>
