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
    public partial class WebForm17 : System.Web.UI.Page
    {
        SqlConnection _conObj = new SqlConnection("server=.; database=HotelDB; trusted_connection=yes");
        UtilityOperation _uObj = new UtilityOperation();

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                try
                {
                    ddlBookingID.DataSource = _uObj.GetBookingID();
                    ddlBookingID.DataTextField = "_bookingID";
                    ddlBookingID.DataValueField = "_bookingID";
                    ddlBookingID.DataBind();
                    ddlBookingID.Items.Insert(0, "Select Booking ID");
                }
                catch (Exception e1)
                {
                    Response.Write(e1.Message);
                }
            }

        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                SqlCommand _cmd = new SqlCommand("select * from Booking where BookingID = " + ddlBookingID.SelectedValue + "  ", _conObj);
                _conObj.Open();
                SqlDataReader dr = _cmd.ExecuteReader();
                gvAprovReq.DataSource = dr;
                gvAprovReq.DataBind();
            }
            catch (Exception)
            {
                Response.Write("<script>alert(' select Booking ID') </script>");
            }
          
        }


        protected void gvAprovReq_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            AdminOperation _aObj = new AdminOperation();
            if (e.CommandName == "APPROVE")
            {
                SqlCommand _cmd = new SqlCommand("update Booking set BookingStatus = 'ACCEPTED' where BookingID = " + ddlBookingID.SelectedValue + "  ", _conObj);
                _conObj.Open();
                SqlDataReader dr = _cmd.ExecuteReader();
                gvAprovReq.DataSource = dr;
                gvAprovReq.DataBind();
                Response.Write("<script>alert('Booking ID successfully APPROVED')</script>");

                EntityLayers.Booking _bookobj = new EntityLayers.Booking()
                {
                    _bookingID = int.Parse(ddlBookingID.SelectedValue)
                };
                _aObj.ApproveRoom(_bookobj);

            }
            else if (e.CommandName == "REJECT")
            {
                SqlCommand _cmd = new SqlCommand("update Booking set BookingStatus = 'REJECTED' where BookingID = " + ddlBookingID.SelectedValue + "  ", _conObj);
                _conObj.Open();
                SqlDataReader dr = _cmd.ExecuteReader();
                gvAprovReq.DataSource = dr;
                gvAprovReq.DataBind();
                Response.Write("<script>alert('Booking ID successfully REJECTED')</script>");
            }

        }

      
       
    }
}