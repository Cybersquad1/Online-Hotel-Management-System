<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="OnlineHotelManagementSystemWebApplication.WebForm2" %>
<%@ Register src="LoginController.ascx" tagname="LoginController" tagprefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
  
    <br />
 <br />
<center><uc1:LoginController ID="LoginController1" runat="server" /> 
<br />
    <asp:HyperLink ID="hlnkNewUser" runat="server" Height="30px" NavigateUrl="~/UserRegister.aspx" 
        Width="150px" EnableTheming="False" Font-Bold="True" Font-Italic="False" 
        Font-Names="Bradley Hand ITC" Font-Size="X-Large" ForeColor="#7BCF72">New User ??</asp:HyperLink>      
 </center>

        
</asp:Content>
