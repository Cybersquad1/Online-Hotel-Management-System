<%@ Page Title="" Language="C#" MasterPageFile="~/AdminInside.Master" AutoEventWireup="true" CodeBehind="DeleteMenu.aspx.cs" Inherits="OnlineHotelManagementSystemWebApplication.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .style1
        {
            width: 77px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<br />
  <br />
  <br />  

   <center>
  <fieldset style="width: 304px">
    <legend style="color:White; font-size:large">Enter Menu ID</legend>
   
 <table> 
 <tr> 
 <td> <asp:Label ID="lblMenuID" runat="server" Text="Menu ID" ForeColor="White"></asp:Label> </td>
 <td class="style1"> 
     <asp:DropDownList ID="ddlMenuID" runat="server"  >
     </asp:DropDownList>
     <td>
         <asp:RequiredFieldValidator ID="rfvMenuID" runat="server" 
             ControlToValidate="ddlMenuID" ErrorMessage="Please Slect Any Of the MenuID" 
             Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
         <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
     </td>
     </td>
 </tr>  
 <tr>
 <td></td>
 <td class="style1"> 
     <asp:Button ID="btnMenuDelete" runat="server" Text="Delete" BackColor="White" 
         BorderStyle="Dotted" onclick="btnMenuDelete_Click" /></td>
 </tr> 
 </table>
  
  </fieldset>
  </center>

</asp:Content>
