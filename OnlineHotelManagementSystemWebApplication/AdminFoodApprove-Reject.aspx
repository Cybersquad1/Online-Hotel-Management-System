<%@ Page Title="" Language="C#" MasterPageFile="~/AdminInside.Master" AutoEventWireup="true" CodeBehind="AdminFoodApprove-Reject.aspx.cs" Inherits="OnlineHotelManagementSystemWebApplication.WebForm25" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <center>
  <br />
  <br />
  <table>
  <tr>
  <td><asp:Label ID="lblOrderID" runat="server" Text="Select the Order ID" 
        ForeColor="White" Font-Bold="True"></asp:Label>  
  </td>
  <td> <asp:DropDownList ID="ddlOrderID" 
           runat="server" AutoPostBack="True" 
           onselectedindexchanged="DropDownList1_SelectedIndexChanged">
    </asp:DropDownList>
  </td>
  </tr>
  
  </table>
    
  


   <br />
   <br />

        <asp:Label ID="lblDisp" runat="server" Text=" Order Details are" 
            Font-Bold="True" Font-Overline="False" Font-Size="Large" ForeColor="White"></asp:Label>

    <asp:GridView ID="gvFoodDetails" runat="server" 
        BackColor="LightGoldenrodYellow" BorderColor="Tan" BorderWidth="1px" 
        CellPadding="2" ForeColor="Black" GridLines="None">
        <AlternatingRowStyle BackColor="PaleGoldenrod" />
        <FooterStyle BackColor="Tan" />
        <HeaderStyle BackColor="Tan" Font-Bold="True" />
        <PagerStyle BackColor="PaleGoldenrod" ForeColor="DarkSlateBlue" 
            HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="DarkSlateBlue" ForeColor="GhostWhite" />
        <SortedAscendingCellStyle BackColor="#FAFAE7" />
        <SortedAscendingHeaderStyle BackColor="#DAC09E" />
        <SortedDescendingCellStyle BackColor="#E1DB9C" />
        <SortedDescendingHeaderStyle BackColor="#C2A47B" />
    </asp:GridView>

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
