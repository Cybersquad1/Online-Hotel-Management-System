<%@ Page Title="" Language="C#" MasterPageFile="~/AdminInside.Master" AutoEventWireup="true" CodeBehind="AddRoom.aspx.cs" Inherits="OnlineHotelManagementSystemWebApplication.WebForm4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center> 
<br />
<br />    

<fieldset style="width: 400px">
    <legend style="color:White; font-size:large">Add Room Details</legend>

<table style="height: 216px; width: 356px">
   
    <tr><td></td><td class="style1"></td></tr>
       <tr>
    <td align="center">
        <asp:Label ID="lblRoomType" runat="server" Text="RoomType " 
            ForeColor="White"></asp:Label></td>
    <td align="center" class="style1">
        <asp:DropDownList ID="ddlRoomType" runat="server" AutoPostBack="True">
        </asp:DropDownList>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" 
            ControlToValidate="ddlRoomType" ErrorMessage="Enter Room Type">*</asp:RequiredFieldValidator>
     </td>
    </tr>

       <tr>
    <td align="center">
        <asp:Label ID="lblRoomDesc" runat="server" Text="Room Description" ForeColor="White"></asp:Label></td>
    <td class="style1" align="center">
        <asp:TextBox ID="txtRoomDesc" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" 
            ControlToValidate="txtRoomDesc" ErrorMessage="enter room description">*</asp:RequiredFieldValidator>
     </td>
    </tr>

       <tr>
    <td align="center">
        <asp:Label ID="lblRoomCharges" runat="server" Text="Room Charges" ForeColor="White"></asp:Label></td>
    <td align="center" class="style1">
        <asp:TextBox ID="txtRoomCharges" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
            ControlToValidate="txtRoomCharges" ErrorMessage="enter room charges">*</asp:RequiredFieldValidator>
     </td>
    </tr>

    
       <tr>
    <td align="center">
        <asp:Label ID="lblRoomService" runat="server" Text="Room Services" ForeColor="White"></asp:Label></td>
    <td align="center" class="style1">
        <asp:TextBox ID="txtRoomService" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" 
            ControlToValidate="txtRoomService" ErrorMessage="enter room services">*</asp:RequiredFieldValidator>
     </td>
    </tr>
  
  <tr><td>
      <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
      </td><td class="style1"></td></tr>
    <tr>
    <td></td>

       <td align="center" class="style1"> <asp:Button ID="btnAddRoom" runat="server" Text="ADD" BackColor="White" 
            BorderStyle="Dotted" ForeColor="Black" Height="25px" Width="70px" 
               onclick="btnAddRoom_Click" />
        </td>
    </tr>
     </table>
     
     </fieldset>
 </center>

</asp:Content>
<asp:Content ID="Content2" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .style1
        {
            width: 203px;
        }
    </style>
</asp:Content>

