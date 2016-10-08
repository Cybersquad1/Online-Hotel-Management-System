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
    public partial class WebForm20 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SqlConnection _conObj = new SqlConnection("server=.; database=HotelDB; trusted_connection=yes");
            _conObj.Open();
            SqlCommand _cmd = new SqlCommand("Select * from TEMPORDER", _conObj);
            SqlDataReader dr = _cmd.ExecuteReader();
            gvOrderDetails.DataSource = dr;
            gvOrderDetails.DataBind();
            _conObj.Close();

            _conObj.Open();
            SqlCommand _cmd1 = new SqlCommand("Select SUM([TOTAL PRICE]) as [TOTAL PRICE] from TEMPORDER", _conObj);
            SqlDataReader dr1 = _cmd1.ExecuteReader();
            gvTotal.DataSource = dr1;
            gvTotal.DataBind();
            _conObj.Close();
        }

        protected void gvOrderDetails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            TableCell cell = gvOrderDetails.Rows[e.RowIndex].Cells[1];

            SqlConnection _conObj = new SqlConnection("server=.; database=HotelDB; trusted_connection=yes");

            SqlCommand _cmd = new SqlCommand("Delete from TEMPORDER where [MENU ITEM] = '"+cell.Text+"' ",_conObj);

             SqlCommand _cmd1 = new SqlCommand("select * from TEMPORDER", _conObj);
                
              _conObj.Open();
              _cmd.ExecuteNonQuery();
                SqlDataReader dr = _cmd1.ExecuteReader();
                gvOrderDetails.DataSource = dr;
                gvOrderDetails.DataBind();
                Response.Write("<script>alert('Item Deleted Successfully')</script>");
            
        }

        protected void btnConfirm_Click(object sender, EventArgs e)
        {
            SqlConnection _conObj = new SqlConnection("server=.; database=HotelDB; trusted_connection=yes");
            _conObj.Open();
            foreach (GridViewRow g1 in gvOrderDetails.Rows)
            {
                SqlCommand _cmd = new SqlCommand("insert into OrdersDetails (MenuItem,RequiredQuantity,SubTotal,UserID) values ('" + g1.Cells[1].Text + "'," + g1.Cells[2].Text + "," + g1.Cells[4].Text + ",'" + g1.Cells[5].Text+ "')", _conObj);
                
                _cmd.ExecuteNonQuery();
                
            }


            
            TableCell row1 = gvTotal.Rows[0].Cells[0];
            decimal _totalamt = decimal.Parse(row1.Text);

            string _userID = Session["UserID"].ToString();
            int _bookID = 10005;
            
            UserOperation _uObj = new UserOperation();

            int res = _uObj.OrderTableUpdate(_userID,_bookID,_totalamt);

            List<EntityLayers.Orders> _lObj = _uObj.OrderIDRetrivals(_userID);

            int _oID = _lObj[0]._orderID;

            //Session["OrderID"] = _oID;
            //SqlCommand _cmd1 = new SqlCommand("Truncate table TEMPORDER",_conObj);
            //_cmd1.ExecuteNonQuery();

            _conObj.Close();

            if (res == 1)
            {
                Response.Write("<script> alert('Order Received " + _oID + " Please wait for Confirmation, Thank You !!! ')</script>");    
            }

            Response.Redirect("UserHome.aspx");

           

        }

    

     

    }
}