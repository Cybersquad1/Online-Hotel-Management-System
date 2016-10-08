using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace OnlineHotelManagementSystemWebApplication
{
    public partial class WebForm9 : System.Web.UI.Page
    {
        DeleteMenuReference.DeleteMenuServiceSoapClient _delMenuObj = new DeleteMenuReference.DeleteMenuServiceSoapClient();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                 ddlMenuID.DataSource = _delMenuObj.DeleteMenuList();
                 ddlMenuID.DataTextField = "_menuID";
                 ddlMenuID.DataValueField = "_menuID";
                 ddlMenuID.DataBind();
                 ddlMenuID.Items.Insert(0, "Select Menu ID");
            }
        }

        protected void btnMenuDelete_Click(object sender, EventArgs e)
        {
            _delMenuObj.DeleteMenu(int.Parse(ddlMenuID.SelectedValue));
            Response.Write("<script>alert(' Successfully Deleted Menu') </script> ");
            Response.Redirect("AdminHome.aspx");
        }

 


    }
}