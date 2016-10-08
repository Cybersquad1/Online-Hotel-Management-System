<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UserRegister.aspx.cs" Inherits="OnlineHotelManagementSystemWebApplication.WebForm13" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<center>
<fieldset style="border-color: #000000; width: 800px; height: 620px;">
<legend >Registration</legend>
                  
    <table style="width: 650px; height: 600px; ">
    <tr>
    <td> 
        <asp:Label ID="lblName" runat="server" Text="Name" Font-Bold="True" 
            ForeColor="Black"></asp:Label></td>
    <td><input id="txtName" type="text" runat="server" maxlength="20"/></td>
    <td align="left" class="style3">  
        <asp:RequiredFieldValidator ID="rfvName" runat="server" 
        ErrorMessage="Name Cannot be Blank" ForeColor="Red" 
            ControlToValidate="txtName" Display="Dynamic" SetFocusOnError="True" 
            Font-Bold="True" ValidationGroup="vgroup">*</asp:RequiredFieldValidator>
           <asp:RegularExpressionValidator
            ID="revName" runat="server" 
            ErrorMessage="Invalid Format, TRY AGAIN !!" ControlToValidate="txtName" 
            ForeColor="Red" ValidationExpression="[a-zA-Z]*\s[a-zA-Z]*" 
            Display="Dynamic" SetFocusOnError="True" Font-Bold="True" 
            ValidationGroup="vgroup">*</asp:RegularExpressionValidator>
    </td>
    </tr>
       
      
     <tr>
    <td>  <asp:Label ID="lblUserID" runat="server" Text="Choose User ID" 
            Font-Bold="True" ForeColor="Black"></asp:Label></td>
    <td> <input id="txtUserID" type="text" runat="server" maxlength="6" />
    </td>
    <td align="left" > 
        <asp:RequiredFieldValidator ID="rfvUserID" runat="server" 
        ErrorMessage="User ID Cannot be Blank" ControlToValidate="txtUserID" 
            ForeColor="Red" Display="Dynamic" Font-Bold="True" 
            ValidationGroup="vgroup">*</asp:RequiredFieldValidator>
        <asp:RegularExpressionValidator
            ID="revUserID" runat="server" 
            ErrorMessage="Invalid Format, TRY AGAIN !!" ControlToValidate="txtUserID" 
            ForeColor="Red" ValidationExpression="[A-Z][A-Z][0-9]{4}" 
            SetFocusOnError="True" Font-Bold="True" ValidationGroup="vgroup">*</asp:RegularExpressionValidator>
    </td>
    </tr>


     <tr>
    <td><asp:Label ID="lblEmail" runat="server" Text="E-Mail ID" Font-Bold="True" 
            ForeColor="Black"></asp:Label> </td>
    <td> 
        <input id="txtEmail" type="text" runat="server"/></td>
    <td class="style3" align="left"> 
        <asp:RequiredFieldValidator ID="rfvEmail" runat="server"
         ErrorMessage="Email ID cannot be Blank" ControlToValidate="txtEmail" 
            ForeColor="Red" Font-Bold="True" ValidationGroup="vgroup">*</asp:RequiredFieldValidator>
         <asp:RegularExpressionValidator
             ID="revEmail" runat="server" 
             ErrorMessage="Invalid Email-ID Format" ControlToValidate="txtEmail" 
            ForeColor="Red" 
            ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" 
            Display="Dynamic" Font-Bold="True" ValidationGroup="vgroup">*</asp:RegularExpressionValidator>
    </td>
    </tr>

    
     <tr>
    <td>
        <asp:Label ID="lblPhone" runat="server" Text="Phone Number" Font-Bold="True" 
            ForeColor="Black"></asp:Label></td>
    <td> 
        <input id="txtPhone" type="text" runat="server" /></td>
    <td class="style3" align="left">
        <asp:RequiredFieldValidator ID="rfvPH" runat="server" 
        ErrorMessage="Enter Phone Number" ControlToValidate="txtPhone" ForeColor="Red" 
            Font-Bold="True" ValidationGroup="vgroup">*</asp:RequiredFieldValidator> 
         <asp:RegularExpressionValidator
             ID="revPH" runat="server" 
             ErrorMessage="Invalid PH No. Format" ControlToValidate="txtPhone" 
            ForeColor="Red" ValidationExpression="[0-9]{10}" Font-Bold="True" 
            ValidationGroup="vgroup">*</asp:RegularExpressionValidator>
    </td>
    </tr>

     <tr>
    <td class="style1">
        <asp:Label ID="lblHouse" runat="server" Text="House No." Font-Bold="True" 
            ForeColor="Black"></asp:Label>  </td>
    <td class="style1"> 
        <input id="txtHouseNO" type="text" runat="server" /></td>
    <td class="style1" align="left"> 
        <asp:RequiredFieldValidator ID="rfvHouse" runat="server"
            ErrorMessage="Enter your House Number" ControlToValidate="txtHouseNO" 
            ForeColor="Red" Font-Bold="True" ValidationGroup="vgroup">*</asp:RequiredFieldValidator></td>
    </tr>

     <tr>
    <td>
        <asp:Label ID="lblStreet" runat="server" Text="Street Name" Font-Bold="True" 
            ForeColor="Black"></asp:Label>  </td>
    <td> 
        <input id="txtStreet" type="text" runat="server"/></td>
    <td class="style3" align="left">
        <asp:RequiredFieldValidator ID="rfvStreet" runat="server"
            ErrorMessage="Enter Street Name" ControlToValidate="txtStreet" 
            ForeColor="Red" Font-Bold="True" ValidationGroup="vgroup">*</asp:RequiredFieldValidator></td>
    </tr>

    <tr>
    <td> <asp:Label ID="lblCountry" runat="server" Text="Country" Font-Bold="True" 
            ForeColor="Black"></asp:Label> </td>
    <td> 
        <asp:DropDownList ID="ddlCountry" runat="server" 
            onselectedindexchanged="ddlCountry_SelectedIndexChanged" 
            AutoPostBack="True">
        </asp:DropDownList>
    </td>
    <td class="style3" align="left">
        <asp:RequiredFieldValidator ID="rfvCountry" runat="server" 
        ErrorMessage="Please Select the Country" ControlToValidate="ddlCountry" 
            ForeColor="Red" Font-Bold="True" ValidationGroup="vgroup">*</asp:RequiredFieldValidator> </td>
    </tr>


    <tr>
    <td> <asp:Label ID="lblState" runat="server" Text="State" Font-Bold="True" 
            ForeColor="Black"></asp:Label> </td>
    <td> 
       <asp:DropDownList ID="ddlState" runat="server" 
            onselectedindexchanged="ddlState_SelectedIndexChanged" AutoPostBack="True">
        </asp:DropDownList>
    </td>
    <td class="style3" align="left">
        <asp:RequiredFieldValidator ID="rfvState" runat="server" 
        ErrorMessage="Please Select State" ControlToValidate="ddlState" 
            ForeColor="Red" Font-Bold="True" ValidationGroup="vgroup">*</asp:RequiredFieldValidator></td>
    </tr>


    <tr>
    <td class="style1">  <asp:Label ID="lblCity" runat="server" Text="City" 
            Font-Bold="True" ForeColor="Black"></asp:Label>  </td>
    <td class="style1">  
        <asp:DropDownList ID="ddlCity" runat="server">
        </asp:DropDownList>
    </td>
    <td class="style4" align="left">  
        <asp:RequiredFieldValidator ID="rfvCity" runat="server" 
        ErrorMessage="Please Select City" ControlToValidate="ddlCity" ForeColor="Red" 
            Font-Bold="True" ValidationGroup="vgroup">*</asp:RequiredFieldValidator>
    </td>

    </tr>

    
      <tr>
    <td> 
        <asp:Label ID="lblPassword" runat="server" Text="Password" Font-Bold="True" 
            ForeColor="Black"></asp:Label></td>
    <td> 
        <input id="txtPass" type="password" runat="server" maxlength="20" /></td>
    <td align="left">
        <asp:RequiredFieldValidator ID="rfvPassword" runat="server" 
        ErrorMessage="Password cannot be Blank" ControlToValidate="txtPass" 
            ForeColor="Red" Font-Bold="True" ValidationGroup="vgroup">*</asp:RequiredFieldValidator> 
            <asp:RegularExpressionValidator
            ID="revPassword" runat="server" 
            ErrorMessage="Invalid Password Format !!" ControlToValidate="txtUserID" 
            ForeColor="Red" ValidationExpression="[a-zA-Z0-9@#%^&amp;*]*" 
            SetFocusOnError="True" Font-Bold="True" ValidationGroup="vgroup">*</asp:RegularExpressionValidator>

        </td>
    </tr>
    
      <tr>
    <td> 
        <asp:Label ID="lblConfirmPassword" runat="server" Text="Confirm Password" 
            Font-Bold="True" ForeColor="Black"></asp:Label>
        <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
          </td>
    <td> <input id="txtConfirmPass" type="password"  runat="server" maxlength="20"/></td>
    <td align="left" class="style3">
        <asp:RequiredFieldValidator ID="rfvCPassword" runat="server"
         ErrorMessage="Re-Enter your Password" ControlToValidate="txtConfirmPass" 
            ForeColor="Red" Font-Bold="True" ValidationGroup="vgroup">*</asp:RequiredFieldValidator> 
        <asp:CompareValidator ID="CompareValidator1" runat="server" 
            ErrorMessage="Password Mistmatch !! Retype Again" ControlToCompare="txtPass" 
            ControlToValidate="txtConfirmPass" ForeColor="Red" Display="Dynamic" 
            Font-Bold="True" ValidationGroup="vgroup">*</asp:CompareValidator>
    </td>
    </tr>
    

    <tr>
    <td class="style2" >
        <asp:Button ID="btnReset" runat="server" Text="Reset" 
            onclick="btnReset_Click" ValidationGroup="abc" BackColor="#4F4F4F" 
            ForeColor="#FFCCFF" Height="30px" Width="80px" /> </td>
    <td class="style2">
        <asp:Button ID="btnRegister" runat="server" Text="Register" 
            onclick="btnRegister_Click" BackColor="#4F4F4F" ForeColor="White" 
            Height="30px" Width="80px" ValidationGroup="vgroup" /> </td>

    <td class="style5">&nbsp;</td>
    </tr>

    </table>
    </fieldset>
    </center>
</asp:Content>
