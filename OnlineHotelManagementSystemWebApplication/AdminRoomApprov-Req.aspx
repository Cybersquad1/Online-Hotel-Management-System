<%@ Page Title="" Language="C#" MasterPageFile="~/AdminInside.Master" AutoEventWireup="true" CodeBehind="AdminRoomApprov-Req.aspx.cs" Inherits="OnlineHotelManagementSystemWebApplication.WebForm17" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center> 
   <table>
   <tr>
   <td> <asp:Label ID="lblBookingID" runat="server" Text="Select the booking ID" 
        ForeColor="White" Font-Bold="True"></asp:Label>
   </td>
   <td>
     <asp:DropDownList ID="ddlBookingID" 
           runat="server" AutoPostBack="True" 
           onselectedindexchanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList>
    </td>
   </tr>
   </table>

 

    <br />

   <br />
 <asp:GridView ID="gvAprovReq" runat="server" Width="433px" BackColor="White" 
        BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" 
        ForeColor="Black" GridLines="Vertical"  
        onrowcommand="gvAprovReq_RowCommand">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <Columns>
           
        <asp:TemplateField>
        <ItemTemplate>
           <asp:Button ID="btnAcceptID" runat="server" Text='APPROVE'
                  CommandName = "APPROVE"/>
                  </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField>
                          <ItemTemplate>
           <asp:Button ID="btnRejectID" runat="server" Text='REJECT'
                  CommandName = "REJECT"  />
        </ItemTemplate>
        </asp:TemplateField>
 
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>

       </center> 
</asp:Content>
