<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="UserLogin.aspx.cs" Inherits="OnlineHotelManagementSystemWebApplication.WebForm3" %>
<%@ Register src="LoginController.ascx" tagname="LoginController" tagprefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
<br />
<br />
<br />
<center> <uc1:LoginController ID="ctrlLogin" runat="server"/> </center>
</asp:Content>
