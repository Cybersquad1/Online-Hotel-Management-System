using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using DataAccessLayer;

namespace OnlineHotelManagementSystemWebApplication
{
    public partial class WebForm25 : System.Web.UI.Page
    {

        SqlConnection _conObj = new SqlConnection("server=.; database=HotelDB; trusted_connection=yes");
        UtilityOperation _uObj = new UtilityOperation();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                try
                {
                    ddlOrderID.DataSource = _uObj.GetOrderID();
                    ddlOrderID.DataTextField = "_OrderID";
                    ddlOrderID.DataValueField = "_OrderID";
                    ddlOrderID.DataBind();
                    ddlOrderID.Items.Insert(0, "Select Order ID");
                }
                catch (Exception e1)
                {
                    Response.Write(e1.Message);
                }
            }
            lblDisp.Visible = false;
            
           
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblDisp.Visible = true;

            try
            {
                SqlCommand _cmd = new SqlCommand("select * from Orders where OrderID = " + ddlOrderID.SelectedValue + "  ", _conObj);
                _conObj.Open();
                SqlDataReader dr = _cmd.ExecuteReader();
                gvAprovReq.DataSource = dr;
                gvAprovReq.DataBind();
            }
            catch (Exception)
            {
                Response.Write("<script>alert(' select Menu ID') </script>");
            }

        


        }

        protected void gvAprovReq_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            AdminOperation _aObj = new AdminOperation();
            if (e.CommandName == "APPROVE")
            {
                SqlCommand _cmd = new SqlCommand("update Orders set OrderStatus = 'ACCEPTED' where OrderID = " + ddlOrderID.SelectedValue + "  ", _conObj);
                _conObj.Open();
                SqlDataReader dr = _cmd.ExecuteReader();
                gvAprovReq.DataSource = dr;
                gvAprovReq.DataBind();
                Response.Write("<script>alert('Order ID successfully APPROVED')</script>");

            }
            else if (e.CommandName == "REJECT")
            {
                SqlCommand _cmd = new SqlCommand("update Orders set OrderStatus = 'REJECTED' where OrderID = " + ddlOrderID.SelectedValue + "  ", _conObj);
                _conObj.Open();
                SqlDataReader dr = _cmd.ExecuteReader();
                gvAprovReq.DataSource = dr;
                gvAprovReq.DataBind();
                Response.Write("<script>alert('Order ID successfully REJECTED')</script>");
            }

        }
    }
}