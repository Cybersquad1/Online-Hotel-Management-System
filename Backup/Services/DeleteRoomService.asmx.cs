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
    /// Summary description for DeleteRoomService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DeleteRoomService : System.Web.Services.WebService
    {

       
        SqlConnection _conobj = new SqlConnection("server=.; database=HotelDB; trusted_connection=yes");

        [WebMethod]
        public List<EntityLayers.Room> RoomDelete()
        {
            try
            {

                SqlCommand _cmd = new SqlCommand("select RoomID from Room", _conobj);
                _conobj.Open();
                SqlDataReader dr = _cmd.ExecuteReader();

                List<EntityLayers.Room> _listObj1 = new List<EntityLayers.Room>();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        EntityLayers.Room _roomdelObj = new EntityLayers.Room()
                        {
                            _roomID = int.Parse(dr[0].ToString())


                        };
                        _listObj1.Add(_roomdelObj);

                    }

                }

                return _listObj1;

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
        public void Deleteroom(int RoomID)
        {

            SqlConnection _conObj = new SqlConnection("Data Source=.;Initial Catalog=HotelDB;Integrated Security=True");
            SqlCommand _cmd;

            try
            {
                _conObj.Open();
                _cmd = new SqlCommand();
                _cmd.CommandText = "sp_Delete";
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Connection = _conObj;
                _cmd.Parameters.AddWithValue("@RoomID", RoomID);
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
