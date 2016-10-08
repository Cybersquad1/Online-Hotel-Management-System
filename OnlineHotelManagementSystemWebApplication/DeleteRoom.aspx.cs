using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using System.ServiceModel;

namespace OnlineHotelManagementSystemWebApplication
{
    public partial class WebForm6 : System.Web.UI.Page
    {
        DeleteRoomReference.DeleteRoomServiceSoapClient _obj = new DeleteRoomReference.DeleteRoomServiceSoapClient();
       protected void Page_Load(object sender, EventArgs e)
        {
            //UtilityOperation _utilObj = new UtilityOperation();

            if (!IsPostBack)
            {
                ddlRoomID.DataSource = _obj.RoomDelete();
                ddlRoomID.DataTextField = "_roomID";
                ddlRoomID.DataValueField = "_roomID";
                ddlRoomID.DataBind();
                ddlRoomID.Items.Insert(0, "Select Room ID");
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            
            _obj.Deleteroom(int.Parse(ddlRoomID.SelectedValue));
            Response.Write("<script>alert(' Successfully Deleted Room') </script> ");
            Response.Redirect("AdminHome.aspx");
        }
        }
    }
