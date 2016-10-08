using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace OnlineHotelManagementSystemWebApplication
{
    public partial class WebForm10 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UtilityOperation _utilObj = new UtilityOperation();

            if (!IsPostBack)
            {
                ddlMenuID.DataSource = _utilObj.ModifyMenu();
                ddlMenuID.DataTextField = "_menuID";
                ddlMenuID.DataValueField = "_menuID";
                ddlMenuID.DataBind();
                ddlMenuID.Items.Insert(0, "Select Menu ID");
            }
        }

        protected void ddlMenuID_SelectedIndexChanged(object sender, EventArgs e)
        {
            UtilityOperation _utilObj = new UtilityOperation();
            List<EntityLayers.Menu> _listObj1 = new List<EntityLayers.Menu>();
            _listObj1 = _utilObj.RetreiveModifyMenu(ddlMenuID.SelectedValue);

            EntityLayers.Menu _menuObj = new EntityLayers.Menu();
            txtMenuItem.Text = _listObj1[0]._menuItem;
            txtMenuPrice.Text = _listObj1[0]._menuPrice.ToString();
            txtMenuDescription.Text = _listObj1[0]._menuDescription;
  
        }

        protected void btnModify_Click(object sender, EventArgs e)
        {
            try
            {
                AdminOperation _addMenuObj = new AdminOperation();
                EntityLayers.Menu _entityMenuObj = new EntityLayers.Menu()
                {
                    _menuDescription = txtMenuDescription.Text,
                    _menuID = int.Parse(ddlMenuID.SelectedValue),
                    _menuPrice = decimal.Parse(txtMenuPrice.Text),
                    _menuItem = txtMenuItem.Text

                };

                _addMenuObj.ModifyRoomLinqToSql(_entityMenuObj);

                Response.Write("<script>alert(' Successfully Modified Menu') </script> ");
                Response.Redirect("AdminHome.aspx");
            }
            catch (Exception)
            {
                throw;
            }
          
        }
    }
}