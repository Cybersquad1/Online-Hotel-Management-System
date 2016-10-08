using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;
using System.Data.SqlClient;

namespace OnlineHotelManagementSystemWebApplication
{
    public partial class WebForm14 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string _conName = ConfigurationManager.ConnectionStrings["MyConnection"].ConnectionString;

            SqlConnection _conobj = new SqlConnection(_conName);
            _conobj.Open();

            if (txtOldPassword.Value == "abcd1234" && txtNewPassword1.Value == txtNewPassword2.Value)
            {
                SqlCommand _cmd = new SqlCommand("Update Credentials set Password = '" + txtNewPassword2.Value + "' where UserID ='AD1234'  ", _conobj);
                _cmd.ExecuteNonQuery();
                Response.Write("Update Successful");
            }
            else
            {

                Response.Redirect("Password Doesn't Match. Try Again !!!");
            }
        }
    }
}