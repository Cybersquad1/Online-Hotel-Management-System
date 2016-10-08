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
    public partial class WebForm4 : System.Web.UI.Page
    {
        UtilityOperation _utilObj = new UtilityOperation();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlRoomType.DataSource = _utilObj.RoomTypes();
                ddlRoomType.DataTextField = "_roomType";
                ddlRoomType.DataValueField = "_roomTypeID";
                ddlRoomType.DataBind();
                ddlRoomType.Items.Insert(0, " Select Room Type");
            }
        }

        protected void btnAddRoom_Click(object sender, EventArgs e)
        {
            AdminOperation _addRoomObj = new AdminOperation();
            EntityLayers.Room _entityRoomObj = new EntityLayers.Room()
            {
                _roomDesc = txtRoomDesc.Text,
                _roomTypeID = int.Parse(ddlRoomType.SelectedValue),
                _roomCharges = decimal.Parse(txtRoomCharges.Text),
                _roomServices = txtRoomService.Text

            };

         _addRoomObj.AddRoomLinqToSql(_entityRoomObj);
         Response.Write("<script>alert(' Successfully Added Room') </script> ");
         Response.Redirect("AdminHome.aspx");
        }
    }
}