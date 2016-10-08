using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using EntityLayers;
using DataAccessLayer;
using System.Data;

namespace AddMenuWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        SqlConnection _conObj = new SqlConnection("server=.; database=HotelDB; trusted_connection=yes");


        public List<EntityLayers.MenuTypes> AddMenuDDLWCF()
        {
            try
            {

                SqlCommand _cmd = new SqlCommand("select MenuType,MenuTypeID from MenuTypes", _conObj);
                _conObj.Open();
                SqlDataReader dr = _cmd.ExecuteReader();

                List<EntityLayers.MenuTypes> _listObj1 = new List<EntityLayers.MenuTypes>();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        EntityLayers.MenuTypes _menuIDObj = new EntityLayers.MenuTypes()
                        {

                            _menuType = dr[0].ToString(),
                            _menuTypeID = int.Parse(dr[1].ToString())

                        };
                        _listObj1.Add(_menuIDObj);
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
                _conObj.Close();
            }

        }



        //ADD MENU method for Admin to ADD MENU ITEMS
        public int AddMenuIns(EntityLayers.Menu _menuObj)
        {
            //Connection String
            //SqlConnection _conObj = new SqlConnection("Data Source=.;Initial Catalog=HotelDB;Integrated Security=True");
            SqlCommand _cmd;

            int _result;

            try
            {
                _conObj.Open();
                _cmd = new SqlCommand();
                _cmd.CommandText = "sp_AddMenu";
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Connection = _conObj;
                _cmd.Parameters.AddWithValue("@MenuItem", _menuObj._menuItem);
                _cmd.Parameters.AddWithValue("@MenuTypeID", _menuObj._menuTypeID);
                _cmd.Parameters.AddWithValue("@MenuDesc", _menuObj._menuDescription);
                _cmd.Parameters.AddWithValue("@MenuPrice", _menuObj._menuPrice);

             
               _result=  _cmd.ExecuteNonQuery();

                 return _result;
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
