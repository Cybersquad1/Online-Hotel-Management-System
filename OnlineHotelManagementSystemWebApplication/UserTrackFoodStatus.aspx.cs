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
    public partial class WebForm21 : System.Web.UI.Page
    {
            
         UserOperation _userobj = new UserOperation();
      
       
        SqlConnection _conObj = new SqlConnection("server=.; database=HotelDB; trusted_connection=yes");

        SqlCommand _cmd;

        protected void Page_Load(object sender, EventArgs e)
        {
            btnProceed.Visible = false;
            string _uID = Session["UserID"].ToString();
            try
            {
                if (!IsPostBack)
                {
                    _cmd = new SqlCommand("select OrderID from Orders where UserID ='" + _uID + "'", _conObj);
                    _conObj.Open();
                    SqlDataReader dr = _cmd.ExecuteReader();
                    ddlOrderID.DataSource = dr;
                    ddlOrderID.DataValueField = "OrderID";
                    ddlOrderID.DataBind();
                    ddlOrderID.Items.Insert(0, "select Order ID");
                   
                }

            }
            catch (Exception)
            {
                Response.Write("<script>alert('Not yet Ordered Yet ')</script>");
            }
            lblStatus.Visible = false;
            btnProceed.Visible = false;

        }

        protected void ddlOrderID_SelectedIndexChanged(object sender, EventArgs e)
        {

            Session["UserOrderID"] = ddlOrderID.SelectedValue;
            //List<Orders> _temp;

            int _oid = int.Parse(Session["UserOrderID"].ToString());
            List<Orders> _temp;
            _temp = _userobj.OrderIDRetrival(_oid);

            string status = _temp[0]._orderStatus.ToString();
            if (status == "ACCEPTED")
            {
                btnProceed.Visible = true;
            }
            else
            {
                btnProceed.Visible = false;
            }

            EntityLayers.Orders _bookObj = new Orders()
            {
                _orderID = int.Parse(ddlOrderID.SelectedValue)
            };

            //string name = Session["UserID"].ToString();
            //_temp = _userobj.OrderIDRetrival(name);

            //lblStatusDisplay.Text = _temp[0]._orderStatus.ToString();

            _cmd = new SqlCommand("select * from Orders where OrderID=" + ddlOrderID.SelectedValue + " ", _conObj);
            _conObj.Open();
            SqlDataReader dr = _cmd.ExecuteReader();
            gvOrderStatus.DataSource = dr;
            gvOrderStatus.DataBind();
        }

        protected void btnProceed_Click(object sender, EventArgs e)
        {

            _cmd = new SqlCommand("select * from Orders where OrderID=" + ddlOrderID.SelectedValue + " ", _conObj);
            _conObj.Open();
            SqlDataReader dr = _cmd.ExecuteReader();

            
            Response.Redirect("UserConfirmPayment.aspx");
        }

      
    }
}