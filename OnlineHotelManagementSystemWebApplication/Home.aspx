<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="OnlineHotelManagementSystemWebApplication.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
 
    <style type="text/css">
        .style1
        {
            width: 50%;
        }
    .style2
    {
        width: 50%;
        height: 196px;
    }
    </style>
 
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<center>
<table style="width:300;height:300%; " >
<tr>
<td class="style2"><center>
    <asp:Image ID="Image1" runat="server" Height="180px" 
        ImageUrl="~/Images/admin.jpg" Width="150px" BorderColor="#400040" 
        BorderWidth="4px" BorderStyle="Dotted" /> </center>
</td>

</tr>
<tr>
<td> <center > 
    <asp:HyperLink ID="HyperLink1" runat="server" Font-Size="XX-Large" 
      ForeColor="#694969" Target="_blank" NavigateUrl="~/Login.aspx">Login </asp:HyperLink>&nbsp;<asp:HyperLink 
        ID="hlnkUserRegistration" runat="server" NavigateUrl="~/UserRegister.aspx">Register</asp:HyperLink>
    </center>
    
</td>
</tr>
</table>
 </center>

</asp:Content>
