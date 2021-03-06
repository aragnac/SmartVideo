﻿<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="WebApplication.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

      
    <h2><%: Title %>.</h2>
    <h3>Contact @ SmartVideo.</h3>
    <address>
        Inpres<br />
        Parc des marets, WA 98052-6399<br />
        <abbr title="Phone">P: 0032 (0) 367 25 96</abbr>
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@smartVideo.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@smartVideo.com</a>
    </address>
     
     <div id="mapsearch">
    <span style="color:#676767;font-size:11px;margin:10px;padding:4px;">Loading...</span>
  </div>
 
  <!-- Maps Api, Ajax Search Api and Stylesheet
  // Note: If you are already using the Maps API then do not include it again
  //       If you are already using the AJAX Search API, then do not include it
  //       or its stylesheet again
  //
  // The Key Embedded in the following script tags is designed to work with
  // the following site:
  // http://www.abhilashaengineering.com
  -->
  <script src="http://maps.google.com/maps?file=api&v=2&key=ABQIAAAAjfewZCwoKLTq3HmI_i3FYBQIrbY-MYJHVPV3NhA9XUpGkb0yzhRskeXa2xR_0Y55q4MAqbDm5loJxw">
    type="text/javascript"></script>
  <script src="http://www.google.com/uds/api?file=uds.js&v=1.0&source=uds-msw&key=ABQIAAAAjfewZCwoKLTq3HmI_i3FYBQIrbY-MYJHVPV3NhA9XUpGkb0yzhRskeXa2xR_0Y55q4MAqbDm5loJxw">
    type="text/javascript"></script>
  <style type="text/css">
    @import url("http://www.google.com/uds/css/gsearch.css");
  </style>
 
  <!-- Map Search Control and Stylesheet -->
  <script type="text/javascript">
      window._uds_msw_donotrepair = true;
  </script>
  <script src="http://www.google.com/uds/solutions/mapsearch/gsmapsearch.js?mode=new">
    type="text/javascript"></script>
  <style type="text/css">
    @import url("http://www.google.com/uds/solutions/mapsearch/gsmapsearch.css");
  </style>
 
  <style type="text/css">
    .gsmsc-mapDiv {
      height : 300px;
    }
 
    .gsmsc-idleMapDiv {
      height : 300px;
    }
 
    #mapsearch {
      width : 550px;
      margin: 10px;
      padding: 4px;
    }
  </style>
  <script type="text/javascript">
      function LoadMapSearchControl() {

          var options = {
              zoomControl: GSmapSearchControl.ZOOM_CONTROL_ENABLE_ALL,
              title: "Googleplex",
              url: "http://www.google.com/corporate/index.html",
              idleMapZoom: GSmapSearchControl.ACTIVE_MAP_ZOOM,
              activeMapZoom: GSmapSearchControl.ACTIVE_MAP_ZOOM
          }

          new GSmapSearchControl(
              document.getElementById("mapsearch"),
              "1600 Amphitheatre Parkway, Mountain View, CA",
              options
          );

      }
      // arrange for this function to be called during body.onload
      // event processing
      GSearch.setOnLoadCallback(LoadMapSearchControl);
  </script>
<!-- ++End Map Search Control Wizard Generated Code++ -->
    
</asp:Content>
