<%@ Page Title="" Language="C#" MasterPageFile="~/AdminInside.Master" AutoEventWireup="true" CodeBehind="DeleteRoom.aspx.cs" Inherits="OnlineHotelManagementSystemWebApplication.WebForm6" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

  <br />
  <br />
  <br />  

   <center>
  <fieldset style="width: 304px">
    <legend style="color:White; font-size:large">Enter Room ID</legend>
   
 <table> 
 <tr> 
 <td> <asp:Label ID="lblID" runat="server" Text="Room ID" ForeColor="White"></asp:Label> </td>
 <td> 
     <asp:DropDownList ID="ddlRoomID" runat="server">
     </asp:DropDownList>
     </td>
 </tr>  
 <tr><td></td><td>
     <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" 
         ControlToValidate="ddlRoomID" ErrorMessage="Enter Room ID">*</asp:RequiredFieldValidator>
     <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
     </td></tr> 
 <tr>
 <td></td>
 <td> 
     <asp:Button ID="btnDelete" runat="server" Text="Delete" BackColor="White" 
         BorderStyle="Dotted" onclick="btnDelete_Click" /></td>
 </tr> 
 </table>
  
  </fieldset>
  </center>

</asp:Content>
