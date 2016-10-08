<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="LoginController.ascx.cs" Inherits="OnlineHotelManagementSystemWebApplication.LoginController" %>



<style type="text/css">
    .style1
    {
        height: 32px;
    }
</style>



<fieldset style="width: 520px">
    <legend style="color:White; font-size:x-large">Enter Details</legend>
<table style="width: 527px; height: 165px; margin-right: 77px; margin-bottom: 7px;">

<tr><td></td></tr>
<tr><td></td></tr>


<tr>
<td align="right">
    <asp:Label ID="lblUserID" runat="server" Text="ID" Font-Bold="False" 
        Font-Size="X-Large" ForeColor="White"></asp:Label></td>
<td align="center">
    &nbsp;
    <input id="txtUserID" type="text" runat ="server" align="middle" maxlength="6"/>
 </td>
 <td align="left">
     <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
     ErrorMessage="User ID cannot be Blank" ControlToValidate="txtUserID" 
         ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator> 
         
     <asp:RegularExpressionValidator ID="revUserID" runat="server" 
     ErrorMessage="InvalidFormat" ForeColor="Red" SetFocusOnError="True" 
         ValidationExpression="[A-Z]{2}[0-9]{4}" ControlToValidate="txtUserID" 
         ToolTip="Example: KD3424, LN2356"></asp:RegularExpressionValidator>
         </td>
</tr>


<tr>
<td align="right" class="style1">
    <asp:Label ID="lblPassword" runat="server" Text="PASSWORD" Font-Bold="False" 
        Font-Size="X-Large" ForeColor="White"></asp:Label></td>
<td class="style1" align="center">
    &nbsp;
    <input id="txtPassword" type="password" runat ="server" align="middle"/>
 </td>
 <td align="left" class="style1"> 
     <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server"
      ErrorMessage="Password Cannot be Blank" ControlToValidate="txtPassword" 
         ForeColor="Red" SetFocusOnError="True"></asp:RequiredFieldValidator>
 </td>
</tr>

<tr>
<td colspan = "2" class="style2">
    <center>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="btnlLogin" runat="server" Text="Login" Width="121px" 
            BorderColor="Black" BorderStyle="Dotted" ForeColor="Black" 
            onclick="btnlLogin_Click" />
     </center>
</td>
</tr>

</table>

</fieldset>
