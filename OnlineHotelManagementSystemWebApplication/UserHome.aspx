<%@ Page Title="" Language="C#" MasterPageFile="~/UserInside.Master" AutoEventWireup="true" CodeBehind="UserHome.aspx.cs" Inherits="OnlineHotelManagementSystemWebApplication.WebForm11" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class = "wrap">
   <center>
    <div class = "table">
 <br />
 <br />
 <asp:ScriptManager ID="ScriptManager1" runat="server"/>
    <table border = "10">
    <tr>
    <td>
    <asp:UpdatePanel ID="upnl1" runat="server">
  <ContentTemplate>
    <asp:Timer ID="Timer1" runat="server" Interval="5000">
   </asp:Timer>

        <asp:AdRotator ID="adr1Facilities" runat="server" 
            AdvertisementFile="~/Facilities.xml" AlternateTextField="Facilities" 
            BackColor="White" height="200px" Width="200px" BorderColor="Black" 
          BorderStyle="Outset" BorderWidth="4px" />
   </ContentTemplate>
   </asp:UpdatePanel>
    </td>
    
    
    <td>
    <asp:UpdatePanel ID="upnl2" runat="server">
    <ContentTemplate>
    <asp:Timer ID="Timer2" runat="server" Interval="4000">
    </asp:Timer>

        <asp:AdRotator ID="adr1Food" runat="server" 
            AdvertisementFile="~/Food.xml" height="200px" Width="200px" 
            BorderColor="Black" BorderStyle="Outset" BorderWidth="4px"/>
             
   </ContentTemplate>
   </asp:UpdatePanel>
    </td>
    
    
    <td>
    <asp:UpdatePanel ID="upnl3" runat="server">
    <ContentTemplate>
    <asp:Timer ID="Timer3" runat="server" Interval="5000">
    </asp:Timer>

        <asp:AdRotator ID="adr1Room" runat="server" 
            AdvertisementFile="~/Room.xml" height="200px" Width="200px" 
            BorderColor="Black" BorderStyle="Inset" BorderWidth="4px" />
            
   </ContentTemplate>
   </asp:UpdatePanel>
    </td>
    </tr>

    <tr>
    
    <td>  <asp:UpdatePanel ID="upnl4" runat="server">
  <ContentTemplate>
    <asp:Timer ID="Timer4" runat="server" Interval="2000">
   </asp:Timer>

        <asp:AdRotator ID="adr2Facilities" runat="server" 
            AdvertisementFile="~/Room.xml" AlternateTextField="Facilities" 
            BackColor="White" height="200px" Width="200px" BorderColor="Black" 
          BorderStyle="Outset" BorderWidth="4px" />
   </ContentTemplate>
   </asp:UpdatePanel>
    </td>
    
    <td>
    <asp:UpdatePanel ID="upnl5" runat="server">
    <ContentTemplate>
    <asp:Timer ID="Timer5" runat="server" Interval="1500">
    </asp:Timer>

        <asp:AdRotator ID="adr2Food" runat="server" 
            AdvertisementFile="~/Facilities.xml" height="200px" Width="200px" 
            BorderColor="Black" BorderStyle="Outset" BorderWidth="4px"/>
             
   </ContentTemplate>
   </asp:UpdatePanel>
     </td>
    
    
    <td>
        <asp:UpdatePanel ID="upnl6" runat="server">
    <ContentTemplate>
    <asp:Timer ID="Timer6" runat="server" Interval="2000">
    </asp:Timer>

        <asp:AdRotator ID="adr2Room" runat="server" 
            AdvertisementFile="~/Food.xml" height="200px" Width="200px" 
            BorderColor="Black" BorderStyle="Inset" BorderWidth="4px" />
            
   </ContentTemplate>
   </asp:UpdatePanel>
     </td>
    
    </tr>

    </table>
    
    </div>
     </center>

</div>


</asp:Content>
