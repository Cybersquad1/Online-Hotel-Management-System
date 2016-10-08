using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using System.Data.SqlClient;
using EntityLayers;

namespace OnlineHotelManagementSystemWebApplication
{
    public partial class WebForm16 : System.Web.UI.Page
    {
        BookNowServiceReference.Service1Client _serbookObj = new BookNowServiceReference.Service1Client();
        UserOperation _userobj = new UserOperation();
        SqlConnection _conObj = new SqlConnection("server=.; database=HotelDB; trusted_connection=yes");

       // SqlCommand _cmd;

        protected void Page_Load(object sender, EventArgs e)
        {
            txtUserID.Text = Session["UserID"].ToString();
            txtBookingDate.Text = System.DateTime.Now.ToShortDateString();
            if (!IsPostBack)
            {
                ddlRoomType.DataSource = _serbookObj.BookNowDDLWCF();
                ddlRoomType.DataTextField = "_roomType";
                ddlRoomType.DataValueField = "_roomTypeID";
                ddlRoomType.DataBind();
                ddlRoomType.Items.Insert(0, " Select room Type");
            }

            cldCheckInDate.Visible = false;
            cldCheckOutDate.Visible = false;
            
        }

        protected void btnBook_Click(object sender, EventArgs e)
        {
            int _temp;
            txtBookingDate.Text = System.DateTime.Now.ToShortDateString();
            EntityLayers.Booking _bookobj = new EntityLayers.Booking()
            {
               
              _bookingDate = txtBookingDate.Text,
             _checkIn =  txtCheckInDate.Text,
              _checkOut = txtCheckOutDate.Text,
              _guestName = txtGuestName.Text,
              _identityNO = txtIdentityNumber.Text,
              _identityType = txtIdentityType.Text,
              _noAdults = int.Parse(txtNoOfAdults.Text),
              _nochildren = int.Parse(txtNoOfChildren.Text),
              _noInfants = int.Parse(txtNoOfInfants.Text),
              _userID = txtUserID.Text,
              _roomTypeID= Convert.ToInt32(ddlRoomType.SelectedValue),
              _roomType = ddlRoomType.SelectedItem.ToString()
            
             };

            _temp = _serbookObj.BookNow(_bookobj);



            if (_temp == -1)
            {
                Response.Write("<script>alert('Problem with the server register again')</script>");
            }
            else if (_temp == 1)
            {
                UserOperation _uObj = new UserOperation();
                string _uid = Session["UserID"].ToString();
                List<EntityLayers.Booking> _lObj = _uObj.RegBookingIDRetrival(_uid);

                int _bID = _lObj[0]._bookingID;
                Session["BookingID"] = _bID;
                Response.Write("<script>alert('Successfully "+_bID+" registered')</script>");
                Response.Redirect("UserHome.aspx");
            }
        }



        protected void cldCheckOutDate_SelectionChanged(object sender, EventArgs e)
        {
            txtCheckOutDate.Text = cldCheckOutDate.SelectedDate.ToShortDateString();
        }

        protected void cldCheckInDate_SelectionChanged(object sender, EventArgs e)
        {
            txtCheckInDate.Text = cldCheckInDate.SelectedDate.ToShortDateString();
        }

        protected void txtCheckInDate_TextChanged(object sender, EventArgs e)
        {
            cldCheckInDate.Visible = true;
        }

        protected void txtCheckOutDate_TextChanged(object sender, EventArgs e)
        {
            cldCheckOutDate.Visible = true;
        }

         
        }
    }
