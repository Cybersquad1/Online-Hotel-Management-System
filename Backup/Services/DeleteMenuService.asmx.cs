using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;

namespace Services
{
    /// <summary>
    /// Summary description for DeleteMenuService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DeleteMenuService : System.Web.Services.WebService
    {

        SqlConnection _conobj = new SqlConnection("server=.; database=HotelDB; trusted_connection=yes");

        [WebMethod]
        public List<EntityLayers.Menu> DeleteMenuList()
        {
            try
            {

                SqlCommand _cmd = new SqlCommand("select MenuID from Menu", _conobj);
                _conobj.Open();
                SqlDataReader dr = _cmd.ExecuteReader();

                List<EntityLayers.Menu> _listMenuObj = new List<EntityLayers.Menu>();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        EntityLayers.Menu _menuDelObj = new EntityLayers.Menu()
                        {
                            _menuID = int.Parse(dr[0].ToString())
                        };
                        _listMenuObj.Add(_menuDelObj);

                    }

                }

                return _listMenuObj;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _conobj.Close();
            }
        }


        [WebMethod]
        public void DeleteMenu(int MenuID)
        {

            SqlConnection _conObj = new SqlConnection("Data Source=.;Initial Catalog=HotelDB;Integrated Security=True");
            SqlCommand _cmd;

            try
            {
                _conObj.Open();
                _cmd = new SqlCommand();
                _cmd.CommandText = "sp_DeleteMenu";
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Connection = _conObj;
                _cmd.Parameters.AddWithValue("@MenuID", MenuID);
                _cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }

            finally
            {
                _conObj.Close();
            }


        }
    }
}
