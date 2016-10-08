using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataAccessLayer;
using EntityLayers;
using System.Data.SqlClient;
using System.Configuration;

namespace OnlineHotelManagementSystemWebApplication
{
    public partial class WebForm13 : System.Web.UI.Page
    {
        UserOperation _userobj = new UserOperation();
        SqlConnection _conObj = new SqlConnection("server=.; database=HotelDB; trusted_connection=yes");

        SqlCommand _cmd;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                _cmd = new SqlCommand("select CountryID,CountryName from Country", _conObj);
                _conObj.Open();
                SqlDataReader dr = _cmd.ExecuteReader();
                ddlCountry.DataSource = dr;
                ddlCountry.DataTextField = "CountryName";
                ddlCountry.DataValueField = "CountryID";
                ddlCountry.DataBind();
                ddlCountry.Items.Insert(0, "select country");
            }
            
        }

        protected void ddlCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewState["pwd"] = txtPass.Value;
            _cmd = new SqlCommand("select StateID,StateName from [State] where CountryID =@countryID", _conObj);

            _cmd.Parameters.AddWithValue("@countryID", ddlCountry.SelectedValue);
            _conObj.Open();
            SqlDataReader dr = _cmd.ExecuteReader();

            ddlState.DataSource = dr;
            ddlState.DataTextField = "StateName";
            ddlState.DataValueField = "StateID";
            ddlState.DataBind();
            ddlState.Items.Insert(0, "select state");
            txtPass.Value = ViewState["pwd"].ToString();
            txtConfirmPass.Value = ViewState["pwd"].ToString();
           
        }
        
        protected void ddlState_SelectedIndexChanged(object sender, EventArgs e)
        {

            _cmd = new SqlCommand("select CityID,CityName from [City] where StateID=@stateID", _conObj);
            _cmd.Parameters.AddWithValue("@stateID", ddlState.SelectedValue);

            _conObj.Open();
            SqlDataReader dr = _cmd.ExecuteReader();

            ddlCity.DataSource = dr;
            ddlCity.DataTextField = "CityName";
            ddlCity.DataValueField = "CityID";
            ddlCity.DataBind();
            ddlCity.Items.Insert(0, "select sity");
            txtPass.Value = ViewState["pwd"].ToString();
            txtConfirmPass.Value = ViewState["pwd"].ToString();
           

        }

        protected void btnReset_Click(object sender, EventArgs e)
        {
            Reset();
        }

       public void Reset()
        {
            txtName.Value = "";
            txtUserID.Value = "";
            txtPass.Value = "";
            txtConfirmPass.Value = "";
            txtEmail.Value = "";
            txtHouseNO.Value = "";
            txtPhone.Value = "";
            txtStreet.Value = "";
            ddlCity.SelectedIndex = 0;
            ddlCountry.SelectedIndex = 0;
            ddlState.SelectedIndex = 0;
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            int _temp;
            Customer _cObj= new Customer()
            {
                _cname = txtName.Value,
                _cUserID = txtUserID.Value,
                _eMail = txtEmail.Value,
                _ph =txtPhone.Value,
                _house = txtHouseNO.Value,
                _street = txtStreet.Value,
                _cityID = int.Parse(ddlCity.Text),
                _stateID = int.Parse(ddlState.Text),
                _countryID = int.Parse(ddlCountry.Text)
                
            };

            Credentials _creObj = new Credentials()
            {
                _userPswd = txtConfirmPass.Value
            };

        
                _temp = _userobj.Registraion(_cObj, _creObj);


                if (_temp == -1)
                {

                    Response.Write("<script>alert('User ID already Exists, Try Again !!!')</script>");
                    Reset();
                }
                else if (_temp == 1)
                {
                    Response.Write("<script>alert('Successfully registered')</script>");
                    Response.Redirect("Login.aspx");
                    Reset();
                }
           
        }
      

    }
}