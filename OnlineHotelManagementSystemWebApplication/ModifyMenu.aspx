<%@ Page Title="" Language="C#" MasterPageFile="~/AdminInside.Master" AutoEventWireup="true" CodeBehind="ModifyMenu.aspx.cs" Inherits="OnlineHotelManagementSystemWebApplication.WebForm10" %>
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
    <asp:Label ID="lblMenuID" runat="server" Text="Menu ID" ForeColor = "White"></asp:Label> </td>
<td>   
 <asp:DropDownList ID="ddlMenuID" runat="server" Width="59px" Height="16px" 
        onselectedindexchanged="ddlMenuID_SelectedIndexChanged" 
        AutoPostBack="True">
    </asp:DropDownList>
</td>
<td>
    <asp:RequiredFieldValidator ID="rfvMenuID" runat="server"
     ErrorMessage="Please Select Menu ID" ControlToValidate="ddlMenuID" 
        ForeColor="Red">*</asp:RequiredFieldValidator> 
 </td>
</tr>

</table>

</div>

<br />
<br />

<div class = "details">

<fieldset style="width: 400px">
    <legend style="color:White; font-size:large">Modify Menu Details</legend>
<table style="height: 216px; width: 356px">
    
    <tr><td></td><td></td></tr>

       <tr>
    <td >
        <asp:Label ID="lblMenuItem" runat="server" Text="Menu Item" 
            ForeColor="White"></asp:Label></td>
    <td align="center">
        <asp:TextBox ID="txtMenuItem" runat="server"></asp:TextBox>
     </td>
     <td>
    <asp:RequiredFieldValidator ID="rfvMenuItem" runat="server"
     ErrorMessage="Menu Item Cannot be blank" ControlToValidate="txtMenuItem" 
             ForeColor="Red">*</asp:RequiredFieldValidator> 
 </td>
    </tr>

       <tr>
    <td >
        <asp:Label ID="lblMenuDesc" runat="server" Text="Menu Description" ForeColor="White"></asp:Label></td>
    <td class="style1" align="center">
        <asp:TextBox ID="txtMenuDescription" runat="server"></asp:TextBox>
     </td>
     <td>
    <asp:RequiredFieldValidator ID="rfvMenuDesc" runat="server"
     ErrorMessage="Menu Description Cannot be blank" 
             ControlToValidate="txtMenuDescription" ForeColor="Red">*</asp:RequiredFieldValidator> 
 </td>
    </tr>

       <tr>
    <td >
        <asp:Label ID="lblMenuPrice" runat="server" Text="Menu Price" ForeColor="White"></asp:Label></td>
    <td align="center">
        <asp:TextBox ID="txtMenuPrice" runat="server"></asp:TextBox>
     </td>
     <td>
    <asp:RequiredFieldValidator ID="rfvMenuPrice" runat="server"
     ErrorMessage="Please enter Menu Price" ControlToValidate="txtMenuPrice" 
             ForeColor="Red">*</asp:RequiredFieldValidator> 
 </td>
    </tr>

  <tr><td></td><td>
      <asp:ValidationSummary ID="ValidationSummary2" runat="server" />
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
