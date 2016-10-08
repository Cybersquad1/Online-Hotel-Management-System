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
    public partial class WebForm26 : System.Web.UI.Page
    {
        UserOperation _userObj = new UserOperation();
    

        protected void Page_Load(object sender, EventArgs e)
        {

            btnCancel.Visible = true;

            SqlConnection _conObj = new SqlConnection("server=.; database=HotelDB; trusted_connection=yes");
            _conObj.Open();
            SqlCommand _cmd = new SqlCommand("Select Amount as [TotalAmount] from Orders where OrderID= "+ Session["UserOrderID"]+" ", _conObj);

            SqlDataReader dr = _cmd.ExecuteReader();
            gvTotal.DataSource = dr;
            gvTotal.DataBind();
            _conObj.Close();
        }

        protected void btnPay_Click(object sender, EventArgs e)
        {
            string UserId = Session["UserID"].ToString();



            EntityLayers.CardInfo _objCardInfo = new EntityLayers.CardInfo()
          {
                _bankName = txtBankName.Text,
                _cardNO = txtCardNumber.Text,
                _cardType = txtCardType.Text,
                _expDate = txtExpiryDate.Text,
                _NameOnCard = txtNameOnCard.Text
            };

            int result = _userObj.ValidateCardInfo(_objCardInfo);
         
            if (result == 1)
                {

                EntityLayers.Orders _tOobj = new EntityLayers.Orders()
                {
                    _orderID = int.Parse(Session["UserOrderID"].ToString())
                };


               TableCell row1 = gvTotal.Rows[0].Cells[0];
               decimal amt = decimal.Parse(row1.Text);

                EntityLayers.Payment _Pobj = new EntityLayers.Payment()
                {
                    
                    _dateOfPayment = System.DateTime.Now,
                    _paymentMode = "CARD",
                    _bankName = txtBankName.Text,
                    _cardType = txtCardType.Text,
                    _cardNO = txtCardNumber.Text,
                    _nameOnCard = txtNameOnCard.Text,
                    _totalamount = amt

                };

                int result1 = _userObj.InsertInPayment(_tOobj, _Pobj);
                if (result1 == 1)
                {
                    Response.Write("<Script>alert('Payment is Successful')</script>");
                   
                }
                else if (result1 == 0)
                {
                    Response.Write("<Script>alert('Payment Not Successful Check Your details')</script>");
                }
            }
            else
            {
                Response.Write("<Script>alert('Payment Not Successful Check Your details')</script>");
            }
            Response.Redirect("UserHome.aspx");
            SqlConnection _conObj = new SqlConnection("server=.; database=HotelDB; trusted_connection=yes");
            SqlCommand _cmd1 = new SqlCommand("Truncate table TEMPORDER",_conObj);
            _cmd1.ExecuteNonQuery();



        }


        protected void btnHome_Click(object sender, EventArgs e)
        {
            Response.Redirect("UserOrderDetails.aspx");
        }
    }
}