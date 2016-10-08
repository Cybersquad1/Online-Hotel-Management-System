<%@ Page Title="" Language="C#" MasterPageFile="~/UserInside.Master" AutoEventWireup="true" CodeBehind="UserTrackFoodStatus.aspx.cs" Inherits="OnlineHotelManagementSystemWebApplication.WebForm21" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<center>

<table>
<tr>
<td class="style1">
    <asp:Label ID="lblOrderID" runat="server" 
        Text="Enter Your OrderID" Font-Bold="True" ForeColor="Black"></asp:Label></td>
<td class="style1">
    <asp:DropDownList ID="ddlOrderID" runat="server" 
        onselectedindexchanged="ddlOrderID_SelectedIndexChanged" 
        AutoPostBack="True">
    </asp:DropDownList>
</td>
</tr>
</table>

<br />
<br />

<asp:Label ID="lblStatus" runat="server" Text="You Order is :" Font-Bold="True" 
        ForeColor="Black"></asp:Label><asp:Label
    ID="lblStatusDisplay" runat="server" ></asp:Label>
<br />
<br />
<asp:GridView ID="gvOrderStatus" runat="server"> </asp:GridView>
<br />
<br />

    <asp:Button ID="btnProceed" runat="server" Text="Proceed to Pay" 
        BackColor="#8F8F8F" BorderColor="Black" BorderWidth="2px" Font-Bold="True" 
        ForeColor="Red" onclick="btnProceed_Click" />


</center>

</asp:Content>
