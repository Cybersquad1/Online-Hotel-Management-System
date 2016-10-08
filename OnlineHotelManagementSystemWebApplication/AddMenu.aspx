<%@ Page Title="" Language="C#" MasterPageFile="~/AdminInside.Master" AutoEventWireup="true" CodeBehind="AddMenu.aspx.cs" Inherits="OnlineHotelManagementSystemWebApplication.WebForm8" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center> 
<br />
<br />    

<fieldset style="width: 550px">
    <legend style="color:White; font-size:large">Add Menu Details</legend>

<table style="height: 250px; width: 450px">
   
    <tr><td></td><td></td></tr>
    <tr>
    <td align="center">
        <asp:Label ID="lblType" runat="server" Text="Menu Type" ForeColor="White"></asp:Label></td>
    <td align="center">
        <asp:DropDownList ID="ddlMenuType" runat="server" style="margin-left: 0px" 
            AutoPostBack="True">
        </asp:DropDownList>
     </td>
     <td>
         <asp:RequiredFieldValidator ID="rfvMenu" runat="server" 
         ErrorMessage="MenuType has not been selected" ForeColor="Red" 
             ControlToValidate="ddlMenuType">*</asp:RequiredFieldValidator> </td>
    </tr>

       <tr>
    <td align="center">
        <asp:Label ID="lblMenuItem" runat="server" Text="Menu Item" 
            ForeColor="White"></asp:Label></td>
    <td align="center">
        <asp:TextBox ID="txtMenuItem" runat="server" ValidationGroup="Example: "></asp:TextBox>
     </td>
     <td>
         <asp:RequiredFieldValidator ID="rfvMenuItem" runat="server" 
         ErrorMessage="Menu Item is not entered" ForeColor="Red" 
             ControlToValidate="txtMenuItem">*</asp:RequiredFieldValidator> 
         <asp:RegularExpressionValidator ID="revMenuItem" runat="server" 
             ControlToValidate="txtMenuItem" ErrorMessage="No numbers" 
             ForeColor="Red" ValidationExpression="[a-zA-Z]*">*</asp:RegularExpressionValidator>
           </td>
    </tr>

       <tr>
    <td align="center">
        <asp:Label ID="lblMenuDesc" runat="server" Text="Menu Description" ForeColor="White"></asp:Label></td>
    <td class="style1" align="center">
        <asp:TextBox ID="txtMenuDesc" runat="server"></asp:TextBox>
     </td>
     <td>
         <asp:RequiredFieldValidator ID="rfvMenuDesc" runat="server" 
         ErrorMessage="Menu Description not Given" ForeColor="Red" 
             ControlToValidate="txtMenuDesc">*</asp:RequiredFieldValidator> </td>
    </tr>

       <tr>
    <td align="center">
        <asp:Label ID="lblMenuPrice" runat="server" Text="Menu Price" ForeColor="White"></asp:Label></td>
    <td align="center">
        <asp:TextBox ID="txtMenuPrice" runat="server"></asp:TextBox>
     </td>
     <td> 
         <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
         ErrorMessage="Menu Price is not specified" ForeColor="Red" 
             ControlToValidate="txtMenuPrice">*</asp:RequiredFieldValidator></td>
    </tr>
  
  <tr><td></td><td>
      <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
      </td></tr>
    <tr>
    <td></td>

       <td align="center"> 
           <asp:Button ID="btnMenuAdd" runat="server" Text="ADD" BackColor="White" 
            BorderStyle="Dotted" ForeColor="Black" Height="25px" Width="70px" 
               onclick="btnMenuAdd_Click" />
        </td>
    </tr>
     </table>
     
     </fieldset>
 </center>


</asp:Content>
