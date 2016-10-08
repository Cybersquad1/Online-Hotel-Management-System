<%@ Page Title="" Language="C#" MasterPageFile="~/UserInside.Master" AutoEventWireup="true" CodeBehind="ViewRoom.aspx.cs" Inherits="OnlineHotelManagementSystemWebApplication.WebForm12" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
   
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
<br />

<asp:ScriptManager ID="ScriptManager1" runat="server"/>
    
    <asp:UpdatePanel ID="UpdatePanel1" runat="server">
  <ContentTemplate>
    <asp:Timer ID="Timer1" runat="server" Interval="2000">
   </asp:Timer>
   

<center> 

<table border="10" 
        style="border-style: solid; border-color: #000000; width: 900px;" 
        width="700">

<tr>
<td bgcolor="#990033" height="40" class="style1">
<asp:Label ID="lblSingle" runat="server" Text="Single Bed Room" Font-Bold="True" 
        Font-Italic="False" Font-Size="Large" ForeColor="White"></asp:Label>
 </td>

<td bgcolor="#990033" height="40" class="style1"><asp:Label ID="Label3" runat="server" Text="Delux" 
        Font-Bold="True" Font-Size="Large" ForeColor="White"></asp:Label>
</td>
</tr>

<tr>
<td class="style1">
    <asp:AdRotator ID="adrsimple" runat="server" height="200px" Width="420px" 
        BorderColor="Black" AdvertisementFile="~/SingleRoom.xml" 
        BorderWidth="3px" />
</td>
<td class="style1">
    <asp:AdRotator ID="adrdouble" runat="server" height="200px" Width="420px" 
        BorderColor="Black" AdvertisementFile="~/Delexue.xml" BorderWidth="3px" />
</td>
</tr>


<tr>
<td align="center" bgcolor="#FFFFCC" class="style1" height="0">
    <asp:Label ID="Label4" runat="server" 
        Text="MRP: (Rs 7,350 )   5% OFF NOW @ RS 6982 " Font-Overline="False" 
        ForeColor="Red" Font-Bold="True"></asp:Label>  
    &nbsp;<br />
    <asp:HyperLink ID="hlnkSingle" runat="server" 
    ImageUrl="~/Images/booknow.jpg" Width="60px" Height = "60px" 
        BackColor="#FFCC99" NavigateUrl="~/UserBooking.aspx"></asp:HyperLink>

</td>

<td bgcolor="#FFFFCC" class="style1" align="center">
   
    <asp:Label ID="Label5" runat="server" 
        Text="MRP: (Rs 9,490 )   15% OFF NOW @ RS 8,540 " ForeColor="Red" 
        Font-Bold="True"></asp:Label>  
    <br />
   <asp:HyperLink ID="HyperLink1" runat="server" 
    ImageUrl="~/Images/booknow.jpg" Width="60px" Height="60px" 
        NavigateUrl="~/UserBooking.aspx"></asp:HyperLink>
</td>
</tr>


<tr>
<td bgcolor="#990033" height="40" class="style1">
<asp:Label ID="Label2" runat="server" Text="Suite" Font-Bold="True" 
        Font-Size="Large" ForeColor="White"></asp:Label>
 </td>
<td bgcolor="#990033" height="40" class="style1"> 
<asp:Label ID="Label6" runat="server" Text="Luxury" Font-Bold="True" 
        Font-Size="Large" ForeColor="White"></asp:Label>
</td>
</tr>

<tr>
<td class="style1">
    <asp:AdRotator ID="adrSuite" runat="server" height="200px" Width="420px" 
        BorderColor="Black" AdvertisementFile="~/Suite.xml" BorderWidth="3px" />
</td>
<td class="style1">
    <asp:AdRotator ID="adrLuxury" runat="server" height="200px" Width="420px" 
         AdvertisementFile="~/Luxury.xml"   BorderColor="Black" 
        BorderWidth="3px" />
</td>
</tr>

<tr>
<td bgcolor="#FFFFCC" class="style1" align="center">
    <asp:Label ID="Label7" runat="server" 
        Text="MRP: (Rs 17,000 )   20% OFF NOW @ RS 13,600 " ForeColor="Red" 
        Font-Bold="True"></asp:Label>  
    <br />
   <asp:HyperLink ID="HyperLink2" runat="server" 
    ImageUrl="~/Images/booknow.jpg" Width="60px" Height="60px" 
        NavigateUrl="~/UserBooking.aspx"></asp:HyperLink>
</td>
<td  bgcolor="#FFFFCC" class="style1" align="center">
   
    <asp:Label ID="Label8" runat="server" 
        Text="MRP: (Rs 14,750 )   15% OFF NOW @ RS 12,535 " ForeColor="Red" 
        Font-Bold="True"></asp:Label>  
    <br />
  <asp:HyperLink ID="HyperLink3" runat="server" 
    ImageUrl="~/Images/booknow.jpg" Width="60px" Height="60px" 
        NavigateUrl="~/UserBooking.aspx"></asp:HyperLink>
</td>
</tr>

</table>

</center>


   </ContentTemplate>
   </asp:UpdatePanel>

</asp:Content>
