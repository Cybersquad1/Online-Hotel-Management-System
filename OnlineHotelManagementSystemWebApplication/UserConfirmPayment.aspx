<%@ Page Title="" Language="C#" MasterPageFile="~/UserInside.Master" AutoEventWireup="true" CodeBehind="UserConfirmPayment.aspx.cs" Inherits="OnlineHotelManagementSystemWebApplication.WebForm26" %>
<%@ Register assembly="AjaxControlToolkit" namespace="AjaxControlToolkit" tagprefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table>
        <tr>
            <td class="style1" colspan="2">
&nbsp;&nbsp;&nbsp; <strong>ENTER YOUR PAYMENT DETAILS</strong></td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Card Type&nbsp;</td>
            <td class="style3">
                <asp:TextBox ID="txtCardType" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" 
                    ControlToValidate="txtCardType" ErrorMessage="Card Type Can't be blank" 
                    Font-Bold="True" ForeColor="Red" ValidationGroup="vGroup">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                Bank Name&nbsp;</td>
            <td class="style3">
                <asp:TextBox ID="txtBankName" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" 
                    ControlToValidate="txtBankName" ErrorMessage="Please Specify bank Name" 
                    Font-Bold="True" ForeColor="Red" ValidationGroup="vGroup">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                Card Number&nbsp;</td>
            <td class="style3" align="left">
                <asp:TextBox ID="txtCardNumber" runat="server" Height="27px" Width="125px"></asp:TextBox>
            &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" 
                    ControlToValidate="txtCardNumber" 
                    ErrorMessage="Give your Correct Card Number" Font-Bold="True" ForeColor="Red" 
                    ValidationGroup="vGroup">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="style4">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                Name On Card&nbsp;</td>
            <td class="style5">
                <asp:TextBox ID="txtNameOnCard" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" 
                    ControlToValidate="txtNameOnCard" ErrorMessage="Your name is not correct" 
                    Font-Bold="True" ForeColor="Red" ValidationGroup="vGroup">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                Expiry Date&nbsp;</td>
            <td class="style3">
                <asp:TextBox ID="txtExpiryDate" runat="server"></asp:TextBox>
                <asp:CalendarExtender ID="txtExpiryDate_CalendarExtender" runat="server" 
                    Enabled="True" TargetControlID="txtExpiryDate">
                </asp:CalendarExtender>
&nbsp;<br />
                <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                </asp:ToolkitScriptManager>
                <br />
            </td>
        </tr>
        <tr>
            <td class="style2">
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
                Amount</td>
            <td class="style3">
                <asp:GridView ID="gvTotal" runat="server">
                </asp:GridView>
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="style2">
                &nbsp;</td>
            <td class="style3">
                <asp:Button ID="btnPay" runat="server" onclick="btnPay_Click" 
                    style="font-weight: 700; color: #FFFFFF; background-color: #0000FF" 
                    Text="Confirm Payment" ValidationGroup="vGroup" />
                
           
                &nbsp;&nbsp;&nbsp;&nbsp;
                
           
                <asp:Button ID="btnCancel" runat="server" onclick="btnHome_Click" 
                    style="font-weight: 700; color: #FFFFFF; background-color: #0000FF" 
                    Text="Cancel Payment" Visible="False" />
                
            </td>
        </tr>
    </table>
</asp:Content>
