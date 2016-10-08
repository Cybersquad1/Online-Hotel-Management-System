<%@ Page Title="" Language="C#" MasterPageFile="~/UserInside.Master" AutoEventWireup="true" CodeBehind="UserBooking.aspx.cs" Inherits="OnlineHotelManagementSystemWebApplication.WebForm16" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <%-- <style type="text/css">
        .style1
        {
            width: 338px;
        }
    </style>--%>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table border = "1">

 <tr>
 <td>
     <asp:Label ID="lblRoomType" runat="server" Text="Rooom Type" Font-Bold="True" 
         ForeColor="Black"></asp:Label> </td>
 <td class="style1">
     <asp:DropDownList ID="ddlRoomType" runat="server">
     </asp:DropDownList>
 </td>
 <td></td>
 </tr>

        <tr>
            <td>
                <asp:Label ID="lblUserID" runat="server" Text="User ID" Font-Bold="True" 
                    ForeColor="Black"></asp:Label></td>
            <td class="style1"><asp:TextBox ID="txtUserID" runat="server" BorderColor="Black" 
                    BorderWidth="2px"></asp:TextBox></td>
            <td> <asp:RequiredFieldValidator ID="rfvUser" runat="server" 
                    ErrorMessage="User ID cannpt be blank" ControlToValidate="txtUserID" 
                    Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revUserID" runat="server" 
                    ControlToValidate="txtUserID" ErrorMessage="Invalid Format, Try AGAIN !!!" 
                    ValidationExpression="[A-Z]{2}[0-9]{4}" Font-Bold="True" ForeColor="Red" 
                    ToolTip="Example : AH5784">*</asp:RegularExpressionValidator>
            </td>
       
        </tr>


        <tr>
            <td><asp:Label ID="lblGuest" runat="server" Text="Guest Name" Font-Bold="True" 
                    ForeColor="Black"></asp:Label></td>
            <td class="style1"><asp:TextBox ID="txtGuestName" runat="server" Height="22px" 
                    MaxLength="20" BorderColor="Black" BorderWidth="2px"></asp:TextBox></td>
            <td><asp:RequiredFieldValidator ID="rfvGuestName" runat="server" 
                    ErrorMessage="Guest Name Cannot be blank" ControlToValidate="txtGuestName" 
                    Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revGuestName" runat="server" 
                    ControlToValidate="txtGuestName" ErrorMessage="Invalid Format, Alphabets only" 
                    ValidationExpression="[a-zA-Z]*" Font-Bold="True" ForeColor="Red" 
                    ToolTip="Only Letters allowed">*</asp:RegularExpressionValidator>
            </td>
        </tr>
       
      
        <tr>
            <td><asp:Label ID="Label1" runat="server" Text="Booking Date" Font-Bold="True" 
                    ForeColor="Black"></asp:Label></td>
            <td class="style1" >
                <asp:TextBox ID="txtBookingDate" runat="server" BorderColor="Black" 
                    BorderWidth="2px"></asp:TextBox>
              
  
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvBookingDate" runat="server" 
                    ErrorMessage="Select Booking Date" ControlToValidate="txtBookingDate" 
                    Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
        

        <tr>
            <td style="width: 221px">
               <asp:Label ID="lblCheckIN" runat="server" Text="Check In Date" Font-Bold="True" 
                    ForeColor="Black"></asp:Label></td>
            <td class="style1">

                <asp:TextBox ID="txtCheckInDate" runat="server" 
                    ontextchanged="txtCheckInDate_TextChanged" BorderColor="Black" BorderWidth="2px" 
                  ></asp:TextBox>
                <asp:CalendarExtender ID="txtCheckInDate_CalendarExtender" runat="server" 
                    Enabled="True" TargetControlID="txtCheckInDate">
                </asp:CalendarExtender>
                &nbsp;<asp:Calendar ID="cldCheckInDate" runat="server" onselectionchanged="cldCheckInDate_SelectionChanged" 
                    ></asp:Calendar>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvCheckInDate" runat="server" 
                    ErrorMessage="Select Check In Date" ControlToValidate="txtCheckInDate" 
                    Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
   

        <tr>
            <td>
                <asp:Label ID="lblCheckOut" runat="server" Text="Check Out Date" 
                    Font-Bold="True" ForeColor="Black"></asp:Label></td>
            <td class="style1">
                <asp:TextBox ID="txtCheckOutDate" runat="server" 
                    ontextchanged="txtCheckOutDate_TextChanged" BorderColor="Black" 
                    BorderWidth="2px"></asp:TextBox>
                <asp:CalendarExtender ID="txtCheckOutDate_CalendarExtender" runat="server" 
                    Enabled="True" TargetControlID="txtCheckOutDate">
                </asp:CalendarExtender>
                &nbsp;<asp:Calendar ID="cldCheckOutDate" runat="server" onselectionchanged="cldCheckOutDate_SelectionChanged" 
                    ></asp:Calendar>
                <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server">
                </asp:ToolkitScriptManager>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvCheckOutDate" runat="server" 
                    ErrorMessage="Select CheckOutDate" ControlToValidate="txtCheckOutDate" 
                    Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
            </td>
        </tr>
   
   
        <tr>
            <td ><asp:Label ID="lblNoOfAdults" runat="server" Text="No Of Adults" 
                    Font-Bold="True" ForeColor="Black"></asp:Label>
               </td>
            <td class="style1">
                <asp:TextBox ID="txtNoOfAdults" runat="server" BorderColor="Black" 
                    BorderWidth="2px" ToolTip="Example: 02, 12, 09"></asp:TextBox>
            </td>
            <td> 
                <asp:RequiredFieldValidator ID="rfvNoOfAdults" runat="server" 
                    ErrorMessage="Enter No. of Adults" Font-Bold="True" Font-Italic="False" 
                    ForeColor="Red" ControlToValidate="txtNoOfAdults">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revNoOfAdults" runat="server" 
                    ControlToValidate="txtNoOfAdults" ErrorMessage="Only Digits Allowed" 
                    Font-Bold="True" ForeColor="Red" ValidationExpression="[0-9][0-9]">*</asp:RegularExpressionValidator>
            </td>
        </tr>
        
        

        <tr>
            <td >
                <asp:Label ID="lblNoOfChildren" runat="server" Text="No Of Children" 
                    Font-Bold="True" ForeColor="Black"></asp:Label></td>
            <td class="style1" >
                <asp:TextBox ID="txtNoOfChildren" runat="server" BorderColor="Black" 
                    BorderWidth="2px" ToolTip="Example: 02, 12, 09"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvNoOfChildren" runat="server" 
                    ErrorMessage="Enter No. of Children " Font-Bold="True" Font-Italic="False" 
                    ForeColor="Red" ControlToValidate="txtNoOfChildren">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revNoOfChildren" runat="server" 
                    ErrorMessage="Only Digits Allowed" Font-Bold="True" ForeColor="Red" 
                    ValidationExpression="[0-9][0-9]" ControlToValidate="txtNoOfChildren">*</asp:RegularExpressionValidator>
            </td>
        </tr>
   

        <tr>
            <td>
              <asp:Label ID="lblNoOfInfants" runat="server" Text="No Of Infants" 
                    Font-Bold="True" ForeColor="Black"></asp:Label></td>
            <td class="style1">
                <asp:TextBox ID="txtNoOfInfants" runat="server" BorderColor="Black" 
                    BorderWidth="2px" ToolTip="Example: 02, 12, 09"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvNoOfInfants" runat="server" 
                    ErrorMessage="Enter No. of Infants" Font-Bold="True" Font-Italic="False" 
                    ForeColor="Red" ControlToValidate="txtNoOfInfants">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revNoOfInfants" runat="server" 
                    ErrorMessage="Only Digits Allowed" Font-Bold="True" ForeColor="Red" 
                    ValidationExpression="[0-9][0-9]" ControlToValidate="txtNoOfInfants">*</asp:RegularExpressionValidator>
            </td>
        </tr>
    

        <tr>
            <td >
                <asp:Label ID="lblIdentityType" runat="server" Text="Identity Type" 
                    Font-Bold="True" ForeColor="Black"></asp:Label></td>
            <td class="style1">
                <asp:TextBox ID="txtIdentityType" runat="server" BorderColor="Black" 
                    BorderWidth="2px" ToolTip="Example: Pass Port,  Voter ID ,  Pan Card"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvIdentityType" runat="server" 
                    ErrorMessage="Give Identity Type" ControlToValidate="txtIdentityType" 
                    Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revIdentityType" runat="server" 
                    ControlToValidate="txtIdentityType" ErrorMessage="Only Letters Allowed" 
                    Font-Bold="True" ForeColor="Red" ValidationExpression="[a-zA-Z]*\s[a-zA-Z]*">*</asp:RegularExpressionValidator>
            </td>
        </tr>
  

        <tr>
            <td>
               <asp:Label ID="lblIdentityNumber" runat="server" Text="Identity Number" 
                    Font-Bold="True" ForeColor="Black"></asp:Label></td>
            <td class="style1">
                <asp:TextBox ID="txtIdentityNumber" runat="server" BorderColor="Black" 
                    BorderWidth="2px" ToolTip="Example: Cknp23423231, 322DSas, 2344, akscad"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="rfvIdentityNumber" runat="server" 
                    ErrorMessage="Give Identity Number" ControlToValidate="txtIdentityNumber" 
                    Font-Bold="True" ForeColor="Red">*</asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator ID="revIdentityNumber" runat="server" 
                    ControlToValidate="txtIdentityNumber" 
                    ErrorMessage="Invalid Identity Type Format" Font-Bold="True" ForeColor="Red" 
                    ValidationExpression="[a-zA-z0-9]*">*</asp:RegularExpressionValidator>
            </td>
        </tr>
      
      <tr>
      <td>
          <asp:ValidationSummary ID="ValidationSummary1" runat="server" />
          </td>
      <td></td>
      </tr>


        <tr>
            <td>
                </td>
                
            <td class="style1">
                <asp:Button ID="btnBook" runat="server" Text="Book Room" 
                    onclick="btnBook_Click" BackColor="#4F4F4F" ForeColor="White" 
                     />
                </td>
            <td></td>
        </tr>
    </table>



</asp:Content>
