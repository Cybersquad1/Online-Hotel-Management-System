<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UpdatePassword.aspx.cs" Inherits="OnlineHotelManagementSystemWebApplication.WebForm14" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table>
    <tr> 
    <td> Old Password</td>
    <td> 
        <input id="txtOldPassword" type="password" runat="server" /><asp:RequiredFieldValidator 
            ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtOldPassword" 
            ErrorMessage="Enter Old password">*</asp:RequiredFieldValidator>
        </td>
    </tr>

    <tr>
    <td>New Password</td>
    <td><input id="txtNewPassword1" type="password" runat="server"/><asp:RequiredFieldValidator 
            ID="RequiredFieldValidator2" runat="server" 
            ErrorMessage="Enter your new password">*</asp:RequiredFieldValidator>
        </td>
    </tr>

    <tr>
    <td>Confirm New Password</td>
    <td><input id="txtNewPassword2" type="password" runat="server"/><asp:CompareValidator 
            ID="CompareValidator1" runat="server" ControlToCompare="txtNewPassword1" 
            ControlToValidate="txtNewPassword2" ErrorMessage="Enter the same password">*</asp:CompareValidator>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
        </td>
    </tr>

    <tr>
    <td></td>
    <td> 
        <asp:Button ID="Button1" runat="server" Text="Submit Changes" 
            onclick="Button1_Click" /></td>
    </tr>
    </table>

</asp:Content>
