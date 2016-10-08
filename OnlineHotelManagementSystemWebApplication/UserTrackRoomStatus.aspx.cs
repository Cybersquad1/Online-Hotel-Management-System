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
    public partial class WebForm22 : System.Web.UI.Page
    {
        UserOperation _userobj = new UserOperation();
        SqlConnection _conObj = new SqlConnection("server=.; database=HotelDB; trusted_connection=yes");

        SqlCommand _cmd;

        protected void Page_Load(object sender, EventArgs e)
        {

            try
            {
                string _uid = Session["UserID"].ToString();
                if (!IsPostBack)
                {
                    _cmd = new SqlCommand("select BookingID from Booking where UserID = '" + _uid + "'", _conObj);
                    _conObj.Open();
                    SqlDataReader dr = _cmd.ExecuteReader();
                    ddlBookID.DataSource = dr;
                    ddlBookID.DataValueField = "BookingID";
                    ddlBookID.DataBind();
                    ddlBookID.Items.Insert(0, "select Booking ID");
                }
            }
            catch (Exception)
            {
                Response.Write("<script>alert('Not Yet Booked the Room ')</script>");
            }

            lblStatus.Visible = false;
            btnProceed.Visible = false;

        }

     
        protected void ddlBookID_SelectedIndexChanged1(object sender, EventArgs e)
        {
            lblStatus.Visible = true;
            btnProceed.Visible = true;
            List<Booking> _temp;

            EntityLayers.Booking _bookObj = new Booking()
            {
                _bookingID = int.Parse(ddlBookID.SelectedValue)
            };

            _temp = _userobj.BookingIDRetrival(_bookObj);

            lblStatusDisplay.Text = _temp[0]._status.ToString();

            _cmd = new SqlCommand("select * from Booking where BookingID=" + ddlBookID.SelectedValue + " ", _conObj);
            _conObj.Open();
            SqlDataReader dr = _cmd.ExecuteReader();
            gvBookingStatus.DataSource = dr;
            gvBookingStatus.DataBind();
        }

        protected void btnProceed_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserConfirmPayment.aspx");
        }

        }


    }
