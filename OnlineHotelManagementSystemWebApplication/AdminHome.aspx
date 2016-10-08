<%@ Page Title="" Language="C#" MasterPageFile="~/AdminInside.Master" AutoEventWireup="true" CodeBehind="AdminHome.aspx.cs" Inherits="OnlineHotelManagementSystemWebApplication.WebForm5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <br />
  <br />
  <br />
  <br />
    <asp:ScriptManager ID="ScriptManager1" runat="server"/>
    <div class = "disp"> 
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
  <ContentTemplate>
    <asp:Timer ID="Timer1" runat="server" Interval="2000">
   </asp:Timer>
   
   <center>
  
   <table border = "10" bgcolor="White" >
   <tr> 
   <td>  
   
   <asp:AdRotator ID="adrAD" runat="server" 
        AdvertisementFile="~/Advertisement.xml"  Height = "280px" Width = "540px"/>
    </td>
    </tr>
   </table>
   
     </center>

   </ContentTemplate>
   </asp:UpdatePanel>
   </div>
</asp:Content>
