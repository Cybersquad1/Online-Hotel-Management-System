using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;

namespace OnlineHotelManagementSystemWebApplication
{
    public partial class UserInside : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblSession.Text = Session["UserID"].ToString();

        }

        protected void btnLogout_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut(); // The SignOut method invalidates the authentication cookie.
            Session.Abandon();
            Session.Clear(); // Clearing all Sessions
            if (Session["UserID"] == null)
            {
                Response.Redirect("Home.aspx");
            }
        }
    }
}