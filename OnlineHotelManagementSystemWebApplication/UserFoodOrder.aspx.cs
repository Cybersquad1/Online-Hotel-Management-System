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
    public partial class WebForm15 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string _uId = Session["UserID"].ToString();
            SqlConnection _conObj = new SqlConnection("server=.; database=HotelDB; trusted_connection=yes");
            EntityLayers.Booking _bObj = new EntityLayers.Booking();
            _conObj.Open();

            SqlCommand _cmd = new SqlCommand(" select BookingID from Booking where UserID='" + _uId + "' ", _conObj);
            SqlDataReader dr = _cmd.ExecuteReader();
            while (dr.Read())
            {
                _bObj._bookingID = int.Parse(dr[0].ToString());
            
            }
            _conObj.Close();
            txtBookID.Text = _bObj._bookingID.ToString();

          


            lblUserSession.Text = Session["UserID"].ToString();
          //  txtBookID.Text = Session["BookingID"].ToString();

            if (!IsPostBack)
            {

                lblIdli.Visible = false;
                txtIdli.Visible = false;

                lblBiryani.Visible = false;
                txtBiryani.Visible = false;

                lblPasta.Visible = false;
                txtPasta.Visible = false;

                lblBurger.Visible = false;
                txtBurger.Visible = false;

                lblIcecream.Visible = false;
                txtIcecream.Visible = false;

                lblDosa.Visible = false;
                txtDosa.Visible = false;
            }



        }

        protected void chkIdli_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIdli.Checked)
            {
                lblIdli.Visible = true;
                txtIdli.Visible = true;
            }
            else
            {
                lblIdli.Visible = false;
                txtIdli.Visible = false;
            }

        }

        protected void chkBiryani_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBiryani.Checked)
            {
                lblBiryani.Visible = true;
                txtBiryani.Visible = true;
            }
            else
            {
                lblBiryani.Visible = false;
                txtBiryani.Visible = false;

            }
        }

        protected void chkPasta_CheckedChanged(object sender, EventArgs e)
        {
            if (chkPasta.Checked)
            {
                 lblPasta.Visible = true;
                 txtPasta.Visible = true;
            }
            else
            {
                lblPasta.Visible = false;
                txtPasta.Visible = false;
            }

        }

        protected void chkBurger_CheckedChanged(object sender, EventArgs e)
        {
            if (chkBurger.Checked)
            {
                lblBurger.Visible = true;
                txtBurger.Visible = true;
            }
            else
            {
                lblBurger.Visible = false;
                txtBurger.Visible = false;
            }

         
        }

        protected void chkIcecream_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIcecream.Checked)
            {
                lblIcecream.Visible = true;
                txtIcecream.Visible = true;
            }
            else
            {
                lblIcecream.Visible = false;
                txtIcecream.Visible = false;

            }

        }

        protected void chkDosa_CheckedChanged(object sender, EventArgs e)
        {
            if (chkDosa.Checked)
            {
                lblDosa.Visible = true;
                txtDosa.Visible = true;
            }
            else
            {
                lblDosa.Visible = false;
                txtDosa.Visible = false;
            }
        }

        protected void btnOrder_Click(object sender, EventArgs e)
        {
           lblUserSession.Text = Session["UserID"].ToString();
           string uname = lblUserSession.Text;

            UserOperation _user = new UserOperation();

            List<EntityLayers.Booking> _temp;
            EntityLayers.Booking _bookobj = new EntityLayers.Booking()
            {
                //_bookingID = int.Parse(Session["BookingID"].ToString()),
                _bookingID = int.Parse(txtBookID.Text),
                _userID = uname
            };


             _temp = _user.RetreiveOrderFood(_bookobj);

             string _check = _temp[0]._status;

             decimal _tPrice = 0;
           


             if (_check == "ACCEPTED")
             {
                 SqlConnection _con = new SqlConnection ("server=.; database=HotelDB; trusted_connection=yes");
                 _con.Open();

                 if (chkIdli.Checked)
                 {
                     _tPrice= decimal.Parse(txtIdli.Text) * (decimal)55;
                    SqlCommand _cmd = new SqlCommand(" insert into TEMPORDER values ( 'idli', " + txtIdli.Text + ", '55' , " + _tPrice + ", '"+ lblUserSession.Text+"' )", _con);
                   _cmd.ExecuteNonQuery();                 
                 }


                 if (chkBiryani.Checked)
                 {
                     _tPrice= decimal.Parse(txtBiryani.Text) * (decimal)155;
                    SqlCommand _cmd = new SqlCommand("insert into TEMPORDER values ('biryani', " + txtBiryani.Text + ", '155' , " + _tPrice + " , '" + lblUserSession.Text + "' )", _con);
                     _cmd.ExecuteNonQuery();     
                 }

                 if (chkPasta.Checked)
                 {
                    _tPrice= decimal.Parse(txtPasta.Text) * (decimal)110;
                     SqlCommand _cmd = new SqlCommand(" insert into TEMPORDER values ('Pasta'," + txtPasta.Text + ", '110' ," + _tPrice + " , '" + lblUserSession.Text + "' )", _con);
                    _cmd.ExecuteNonQuery();     
                 }


                 if (chkBurger.Checked)
                 {
                     _tPrice= decimal.Parse(txtBurger.Text) * (decimal)60;
                     SqlCommand _cmd = new SqlCommand(" insert into TEMPORDER values ('Mexican burger', " + txtBurger.Text + ", '60' , " + _tPrice + ", '" + lblUserSession.Text + "' ) ", _con);
                     _cmd.ExecuteNonQuery();     
                 }


                 if (chkIcecream.Checked)
                 {
                     _tPrice = decimal.Parse(txtIcecream.Text) * (decimal)90;
                     SqlCommand _cmd = new SqlCommand(" insert into TEMPORDER values ('Triple Sunday', " + txtIcecream.Text + ", '90' , " + _tPrice +", '"+ lblUserSession.Text+"' ) ", _con);
                     _cmd.ExecuteNonQuery();     
                 }


                 if (chkDosa.Checked)
                 {
                     _tPrice = decimal.Parse(txtDosa.Text) * (decimal)60;
                     SqlCommand _cmd = new SqlCommand("insert into TEMPORDER values ('Masala Dosa'," + txtDosa.Text + ",'60' ,  " + _tPrice + ", '"+ lblUserSession.Text+"' )", _con);
                     _cmd.ExecuteNonQuery();     
                 }

                 _con.Close();
                 Response.Redirect("UserOrderDetails.aspx");
             }
             else if (_check=="REJECTED" || _check == "PENDING")
             {
                 Response.Write("<script> alert(' You need to book the room to order Food')</script>");
             }

        }
    }
}