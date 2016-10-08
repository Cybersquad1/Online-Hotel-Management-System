<%@ Page Title="" Language="C#" MasterPageFile="~/UserInside.Master" AutoEventWireup="true" CodeBehind="UserFoodOrder.aspx.cs" Inherits="OnlineHotelManagementSystemWebApplication.WebForm15" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
<br />
<center>
<table>
<tr>
<td><asp:Label ID="lblUserID" runat="server" Text="UserID" ForeColor="Black"></asp:Label>
</td>
<td>  
    <asp:Label ID="lblUserSession" runat="server"></asp:Label>
</td>
</tr>

<tr>
<td>  <asp:Label ID="lblBookID" runat="server" Text="BookingID" ForeColor="Black"></asp:Label>
</td>
<td> <asp:TextBox ID="txtBookID"
        runat="server" BorderColor="Black"></asp:TextBox>
</td>
</tr>

</table>

    <br />
  

<table border = " 5" style="border-color: #000000" width="700">
<tr>
    <td align="center"><asp:Label ID="Label1" runat="server" Text="Rs 55" 
            Font-Bold="True" Font-Size="Large"></asp:Label></td>
    <td align="center"><asp:Label ID="Label2" runat="server" Text="Rs 155" 
            Font-Bold="True" Font-Size="Large"></asp:Label></td>
    <td align="center"><asp:Label ID="Label3" runat="server" Text="Rs 110" 
            Font-Bold="True" Font-Size="Large"></asp:Label></td>
</tr>

<tr>
    <td><asp:Image ID="Image1" runat="server" Height="200px" 
            ImageUrl="~/Images/idlivada.jpg" Width="210px" BorderColor="Black" 
            BorderStyle="Double" BorderWidth="2px" /></td>
    <td><asp:Image ID="Image2" runat="server" Height="200px" 
            ImageUrl="~/Images/biryani.jpg" Width="210px" BorderColor="Black" 
            BorderStyle="Double" BorderWidth="2px" /></td>
    <td><asp:Image ID="Image3" runat="server" Height="200px" 
            ImageUrl="~/Images/pasta.jpg" Width="210px" BorderColor="Black" 
            BorderStyle="Double" BorderWidth="2px" /></td>
</tr>

<tr>

    <td align="center">  
        <asp:CheckBox ID="chkIdli" runat="server" AutoPostBack="True" 
            BorderColor="Black" BorderWidth="2px" 
            oncheckedchanged="chkIdli_CheckedChanged" />
      <br />
        <asp:Label ID="lblIdli" runat="server" Text="Quantity" Font-Bold="True" 
            Font-Italic="False" Font-Size="Large" Font-Strikeout="False"></asp:Label> 
        <asp:TextBox ID="txtIdli" runat="server" Width="30px" BorderColor="Black" 
            BorderWidth="1px"></asp:TextBox>
       
      </td>
    <td align="center">
        <asp:CheckBox ID="chkBiryani" runat="server" AutoPostBack="True" 
            BorderColor="Black" BorderWidth="2px" 
            oncheckedchanged="chkBiryani_CheckedChanged" />
             <br />
              <asp:Label ID="lblBiryani" runat="server" Text="Quantity" Font-Bold="True" 
            Font-Italic="False" Font-Size="Large" Font-Strikeout="False"></asp:Label> 
        <asp:TextBox ID="txtBiryani" runat="server" Width="30px" BorderColor="Black" 
            BorderWidth="1px"></asp:TextBox> 
    
    </td>
    
    <td align="center">
        <asp:CheckBox ID="chkPasta" runat="server" AutoPostBack="True" 
            BorderColor="Black" BorderWidth="2px" 
            oncheckedchanged="chkPasta_CheckedChanged" />
            <br />
             <asp:Label ID="lblPasta" runat="server" Text="Quantity" Font-Bold="True" 
            Font-Italic="False" Font-Size="Large" Font-Strikeout="False"></asp:Label> 
        <asp:TextBox ID="txtPasta" runat="server" Width="30px" BorderColor="Black" 
            BorderWidth="1px"></asp:TextBox> 
    </td>
</tr>

<tr>
    <td align="center"><asp:Label ID="Label7" runat="server" Text="Rs 60" 
            Font-Bold="True" Font-Size="Large"></asp:Label></td>
    <td align="center"><asp:Label ID="Label8" runat="server" Text="Rs 90" 
            Font-Bold="True" Font-Size="Large"></asp:Label></td>
    <td align="center"><asp:Label ID="Label9" runat="server" Text="Rs 60" 
            Font-Bold="True" Font-Size="Large"></asp:Label></td>
</tr>

<tr>
    <td><asp:Image ID="Image4" runat="server" Height="200px" 
            ImageUrl="~/Images/burger.jpg" Width="210px" BorderColor="Black" 
            BorderStyle="Double" BorderWidth="2px" /></td>
    <td><asp:Image ID="Image5" runat="server" Height="200px" 
            ImageUrl="~/Images/icecream.jpg" Width="210px" BorderColor="Black" 
            BorderStyle="Double" BorderWidth="2px" /></td>
    <td><asp:Image ID="Image6" runat="server" Height="200px" 
            ImageUrl="~/Images/masaldosa.jpg" Width="210px" BorderColor="Black" 
            BorderStyle="Double" BorderWidth="2px" /></td>
</tr>

<tr>
    <td align="center" class="style2"> 
        <asp:CheckBox ID="chkBurger" runat="server" AutoPostBack="True" 
            BorderColor="Black" BorderWidth="2px" 
            oncheckedchanged="chkBurger_CheckedChanged" />
             <br />
             <asp:Label ID="lblBurger" runat="server" Text="Quantity" Font-Bold="True" 
            Font-Italic="False" Font-Size="Large" Font-Strikeout="False"></asp:Label> 
        <asp:TextBox ID="txtBurger" runat="server" Width="30px" BorderColor="Black" 
            BorderWidth="1px"></asp:TextBox> 
    </td>
    
    <td align="center" class="style2">
        <asp:CheckBox ID="chkIcecream" runat="server" AutoPostBack="True" 
            BorderColor="Black" BorderWidth="2px" 
            oncheckedchanged="chkIcecream_CheckedChanged" />
              <br />
                <asp:Label ID="lblIcecream" runat="server" Text="Quantity" Font-Bold="True" 
            Font-Italic="False" Font-Size="Large" Font-Strikeout="False"></asp:Label> 
        <asp:TextBox ID="txtIcecream" runat="server" Width="30px" BorderColor="Black" 
            BorderWidth="1px"></asp:TextBox>
    </td>
    
    <td align="center">
        <asp:CheckBox ID="chkDosa" runat="server" AutoPostBack="True" 
            BorderColor="Black" BorderWidth="2px" 
            oncheckedchanged="chkDosa_CheckedChanged" />
             <br />
             <asp:Label ID="lblDosa" runat="server" Text="Quantity" Font-Bold="True" 
            Font-Italic="False" Font-Size="Large" Font-Strikeout="False"></asp:Label> 
        <asp:TextBox ID="txtDosa" runat="server" Width="30px" BorderColor="Black" 
            BorderWidth="1px"></asp:TextBox> 
    </td>
</tr>
</table>
<br />
<br />
    <asp:Button ID="btnOrder" runat="server" Text="Order" BackColor="#FF5050" 
        Height="50px" style="margin-left: 0px" Width="100px" 
        onclick="btnOrder_Click" />
 </center>

</asp:Content>
