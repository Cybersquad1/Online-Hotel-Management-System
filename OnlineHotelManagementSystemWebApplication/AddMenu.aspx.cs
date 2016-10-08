using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;

namespace OnlineHotelManagementSystemWebApplication
{
    public partial class WebForm8 : System.Web.UI.Page
    {
        AddMenuServiceReference.Service1Client _svcObj = new AddMenuServiceReference.Service1Client();
 
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ddlMenuType.DataSource = _svcObj.AddMenuDDLWCF();
                ddlMenuType.DataTextField = "_menuType";
                ddlMenuType.DataValueField = "_menuTypeID";
                ddlMenuType.DataBind();
                ddlMenuType.Items.Insert(0, " Select Menu Type");
            }
        }

        protected void btnMenuAdd_Click(object sender, EventArgs e)
        {
            int _temp;
            EntityLayers.Menu _entityMenuObj = new EntityLayers.Menu()
            {
               
             
                _menuTypeID = int.Parse(ddlMenuType.SelectedValue),
                _menuDescription = txtMenuDesc.Text,
                _menuPrice = decimal.Parse(txtMenuPrice.Text),
                _menuItem = txtMenuItem.Text
          
            };


           _temp= _svcObj.AddMenuIns(_entityMenuObj);

           try
           {

               if (_temp == -1)
               {
                   Response.Write("<script>alert('Problem with the server register again')</script>");
               }
               else if (_temp == 1)
               {
                   Response.Write("<script>alert(' Menu Successfully added')</script>");
                   Response.Redirect("AdminHome.aspx");
               }
           }
           finally
           {
               Response.Write("<script>alert(' Menu Successfully added')</script>");
           }
        
        }
    }
}