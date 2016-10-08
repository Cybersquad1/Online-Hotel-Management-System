using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using EntityLayers;
using DataAccessLayer;

namespace OnlineHotelManagementSystemWebApplication
{
    public partial class LoginController : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnlLogin_Click(object sender, EventArgs e)
        {
            DataAccessLayer.UtilityOperation _adminobj = new DataAccessLayer.UtilityOperation();
            EntityLayers.Credentials _loginobj = new EntityLayers.Credentials
            {
                _userID = txtUserID.Value.ToString(),
                _userPswd = txtPassword.Value.ToString()

            };

            if (txtUserID.Value.Length > 6)
            {
                Response.Write("<script>alert('Invalid User ID , Exceeding MAX characters !! TRY AGAIN')</script>");
            }

            string _result = _adminobj.Login1(_loginobj);

            Session["UserID"] = txtUserID.Value;

      
            if (_result == "A")
            {
                
                if (txtUserID.Value == "AD1234" && txtPassword.Value == "abcd1234")
                {                    
                    Response.Redirect("UpdatePassword.aspx");
                }


                Response.Redirect("AdminHome.aspx");
            }
            else if (_result == "U")
            {
                Response.Redirect("UserHome.aspx");
            }
            else
                Response.Write("<script>alert('Invalid User ID and Password !! TRY AGAIN')</script>");

        }
    }
}