using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace OnlineHotelManagementSystemWebApplication
{
    public partial class WebForm7 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UtilityOperation _utilObj = new UtilityOperation();

            if (!IsPostBack)
            {
                ddlRoomID.DataSource = _utilObj.ModifyRoom();
                ddlRoomID.DataTextField = "_roomID";
                ddlRoomID.DataValueField = "_roomID";
                ddlRoomID.DataBind();
                ddlRoomID.Items.Insert(0, "Select Room ID");
            }
        }

        protected void ddlRoomID_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                UtilityOperation _utilObj = new UtilityOperation();
                List<EntityLayers.Room> _listObj1 = new List<EntityLayers.Room>();
               _listObj1 = _utilObj.RetreiveModifyRoom(ddlRoomID.SelectedValue);
                
                EntityLayers.Room _roomObj = new EntityLayers.Room();
                txtRoomDesc.Text = _listObj1[0]._roomDesc;
                txtRoomCharges.Text = _listObj1[0]._roomCharges.ToString();
                txtRoomServices.Text = _listObj1[0]._roomServices;
  
            
        }

        protected void btnModify_Click(object sender, EventArgs e)
        {
            AdminOperation _addRoomObj = new AdminOperation();
            EntityLayers.Room _entityRoomObj = new EntityLayers.Room()
            {
                _roomDesc = txtRoomDesc.Text,
                _roomID = int.Parse(ddlRoomID.SelectedValue),
                _roomCharges = decimal.Parse(txtRoomCharges.Text),
                _roomServices = txtRoomServices.Text

            };

            _addRoomObj.ModifyRoomLinqToSql(_entityRoomObj);

            Response.Write("<script>alert(' Successfully Modified Room') </script> ");
            Response.Redirect("AdminHome.aspx");
        }
    }
}