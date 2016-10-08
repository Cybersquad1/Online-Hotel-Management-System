<%@ Page Title="" Language="C#" MasterPageFile="~/AdminInside.Master" AutoEventWireup="true" CodeBehind="ModifyRoom.aspx.cs" Inherits="OnlineHotelManagementSystemWebApplication.WebForm7" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
   <br />
   <br />
   <br />
   
    <center> 
    <div class="dropdown">

<table> 
<tr>
<td>
    <asp:Label ID="lblRoomID" runat="server" Text="Room No" ForeColor = "White"></asp:Label> </td>
<td>   
 <asp:DropDownList ID="ddlRoomID" runat="server" Width="120px" Height="20px" 
        AutoPostBack="True" onselectedindexchanged="ddlRoomID_SelectedIndexChanged">
    </asp:DropDownList>
    <asp:RequiredFieldValidator ID="rfvMenuID" runat="server"
     ErrorMessage="Please Select Menu ID" ControlToValidate="ddlRoomID" 
        ForeColor="Red">*</asp:RequiredFieldValidator> 
</td>
</tr>

</table>

</div>

<br />
<br />

<div class = "details">

<fieldset style="width: 400px">
    <legend style="color:White; font-size:large">Modify Room Details</legend>
<table style="height: 216px; width: 356px">
    
    <tr><td></td><td></td></tr>

    <tr>
    <td >
        <asp:Label ID="lblRoomDesc" runat="server" Text="Room Description" ForeColor="White"></asp:Label></td>
    <td class="style1" align="center">
        <asp:TextBox ID="txtRoomDesc" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvMenuItem" runat="server"
     ErrorMessage="Menu Item Cannot be blank" ControlToValidate="txtRoomDesc" 
             ForeColor="Red">*</asp:RequiredFieldValidator> 
     </td>
    </tr>

       <tr>
    <td >
        <asp:Label ID="lblRoomCharges" runat="server" Text="Room Charges" ForeColor="White"></asp:Label></td>
    <td align="center">
        <asp:TextBox ID="txtRoomCharges" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvMenuItem0" runat="server"
     ErrorMessage="Menu Item Cannot be blank" ControlToValidate="txtRoomCharges" 
             ForeColor="Red">*</asp:RequiredFieldValidator> 
     </td>
    </tr>

    
       <tr>
    <td align="center">
        <asp:Label ID="lblRoomServices" runat="server" Text="Room Services" ForeColor="White"></asp:Label></td>
    <td align="center">
        <asp:TextBox ID="txtRoomServices" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="rfvMenuItem1" runat="server"
     ErrorMessage="Menu Item Cannot be blank" ControlToValidate="txtRoomServices" 
             ForeColor="Red">*</asp:RequiredFieldValidator> 
     </td>
    </tr>
  
  <tr><td></td><td>
      <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
      </td></tr>
    <tr>
    <td></td>

       <td align="center"> 
           <asp:Button ID="btnModify" runat="server" Text="Modify" BackColor="White" 
            BorderStyle="Dotted" ForeColor="Black" Height="25px" Width="70px" 
               onclick="btnModify_Click" />
        </td>
    </tr>
     </table>
     
     </fieldset>
</div>


</center>
</asp:Content>
