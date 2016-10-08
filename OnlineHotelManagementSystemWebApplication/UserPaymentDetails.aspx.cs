using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace OnlineHotelManagementSystemWebApplication
{
    public partial class WebForm23 : System.Web.UI.Page
    {   
        protected void Page_Load(object sender, EventArgs e)
        {
            int _orderID = int.Parse(Session["OrderID"].ToString());
          
            PaymentHotelDBEntities _objEnt = new PaymentHotelDBEntities();
           
            var q= (from x in _objEnt.Payments where x.OrderID==_orderID select x);

            gvPaymentDisplay.DataSource =q;
            

            gvPaymentDisplay.DataBind();


        }
    }
}