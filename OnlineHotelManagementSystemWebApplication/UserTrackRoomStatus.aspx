<%@ Page Title="" Language="C#" MasterPageFile="~/UserInside.Master" AutoEventWireup="true" CodeBehind="UserTrackRoomStatus.aspx.cs" Inherits="OnlineHotelManagementSystemWebApplication.WebForm22" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<center>

<table>
<tr>
<td class="style1"><asp:Label ID="lblBookingID" runat="server" 
        Text="Enter Your Booking ID" Font-Bold="True" Font-Size="Large" 
        ForeColor="Black"></asp:Label></td>
<td class="style1">
    <asp:DropDownList ID="ddlBookID" runat="server" 
        onselectedindexchanged="ddlBookID_SelectedIndexChanged1" AutoPostBack="True" 
      >
    </asp:DropDownList>
</td>
</tr>
</table>

<br />
<br />

<asp:Label ID="lblStatus" runat="server" Text="You Booking is :" Font-Bold="True" 
        Font-Size="Large" ForeColor="Black"></asp:Label><asp:Label
    ID="lblStatusDisplay" runat="server" ></asp:Label>
<br />
<br />
<asp:GridView ID="gvBookingStatus" runat="server"> </asp:GridView>

<br />
<br />

<asp:Button ID="btnProceed" runat="server" Text="Proceed to Pay" 
        BackColor="#8F8F8F" BorderColor="Black" BorderWidth="2px" Font-Bold="True" 
        ForeColor="Red" onclick="btnProceed_Click" />


</center>
</asp:Content>
