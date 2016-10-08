using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EntityLayers;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;



//------------------------------------------------------------------------------------------------------
// CLASS NAME: UserOperation
// =====================================================================================================
//DESCRIPTION:This class contains all the methods that are used by User/Customer to perform tasks
// =====================================================================================================
// CHANGE HISTORY
// -----------------------------------------------------------------------------------------------------
// Version   Date           Name                  Change   			 Workdone
// -----------------------------------------------------------------------------------------------------
// 1.0       02/12/2015     TEAM 15          Initial Creation.		RLL Project
//------------------------------------------------------------------------------------------------------



namespace DataAccessLayer
{
    public class UtilityOperation
    {
        //Connection String
        string constr = ConfigurationManager.ConnectionStrings["HotelDBConnectionString"].ConnectionString;
        
        
        
        /// <summary>
        /// Login1 method for User/Admin to LOG-IN
        /// </summary>
        /// <param name="_login">Object of Credentials class</param>
        /// <returns>Returns the type of user, wheather 'A' or 'U'</returns>
        public string Login1(Credentials _login)
        {
            SqlConnection _conobj = new SqlConnection(constr);
            try
            {
                string name = " ";
                _conobj.Open();
                string query=" select UserType from Credentials where UserID= '" + _login._userID + "' and Password = '" + _login._userPswd + "' ";
                SqlCommand _cmd = new SqlCommand(query , _conobj);
                SqlDataReader dr = _cmd.ExecuteReader();
                while (dr.Read())
                {
                    name = dr[0].ToString(); ;
                }        
               return name;
            }
            catch (SqlException)
            {
                throw;
            }

            finally
            {
                _conobj.Close();     
            }
            
        }


    
        /// <summary>
        /// Method for Retreving values for Drop Down List for displaying Room Type
        /// </summary>
        /// <returns>Returns the list of Roomtype and RomTypeID</returns>
        public List<EntityLayers.RoomType> RoomTypes()
        {
            SqlConnection _conobj = new SqlConnection(constr);
            try
            {   
                SqlCommand _cmd = new SqlCommand("select RoomType,RoomTypeID from RoomType", _conobj);
                _conobj.Open();
             
                SqlDataReader dr = _cmd.ExecuteReader();

                List<EntityLayers.RoomType> _listObj = new List<EntityLayers.RoomType>();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        EntityLayers.RoomType _roomtypeObj = new EntityLayers.RoomType()
                        {
                            _roomType = dr[0].ToString(),
                            _roomTypeID = int.Parse(dr[1].ToString())
                        };
                        _listObj.Add(_roomtypeObj);
                    }
                }
                _cmd.Dispose();
                return _listObj;                 
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {
                _conobj.Close();
            }
        }


      
        /// <summary>
        /// Method for Retreiving values for Drop Down List for displaying Room ID
        /// </summary>
        /// <returns> Returns List of RoomID</returns>
         public List<EntityLayers.Room>ModifyRoom()
        {
            SqlConnection _conobj = new SqlConnection(constr);
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
                        EntityLayers.Room _roomObj = new EntityLayers.Room()
                        {
                            _roomID = int.Parse(dr[0].ToString())

                        };
                        _listObj1.Add(_roomObj);
                    }
                }             
                return _listObj1;             
            }
            catch (SqlException)
            {
                throw;
            }
            finally
            {                
                _conobj.Close();
            }         
         }


       
        /// <summary>
        /// Method for Retreiving Values for Modifying Room
        /// </summary>
        /// <param name="a">Accepts RoomID as Parameter</param>
        /// <returns>Returns RoomDescription, RoomCharges, RoomServices </returns>
         public List<EntityLayers.Room> RetreiveModifyRoom(string a)
         {
             SqlConnection _conobj = new SqlConnection(constr);
             int id = int.Parse(a);
             try
             {
                 
                 SqlCommand _cmd = new SqlCommand("select RoomDescription,RoomCharges, RoomServices from Room where RoomID = "+id, _conobj);
                 _conobj.Open();
                 SqlDataReader dr = _cmd.ExecuteReader();

                 List<EntityLayers.Room> _listObj1 = new List<EntityLayers.Room>();
                 if (dr.HasRows)
                 {
                     while (dr.Read())
                     {
                         EntityLayers.Room _roomObj = new EntityLayers.Room()
                         {
                             _roomDesc = dr.GetString(0),
                             _roomCharges = dr.GetDecimal(1),
                             _roomServices = dr.GetString(2)

                         };
                         _listObj1.Add(_roomObj);
                     }
                 }
                 return _listObj1;
             }

             catch (SqlException)
             {
                 throw;
             }
            
             finally
             {
                 _conobj.Close();
             }
         }
        


        /// <summary>
        /// MEthod for Retreiving values for Drop Down List for displaying Menu ID
        /// </summary>
        /// <returns>Does not return anything</returns>
         public List<EntityLayers.Menu> ModifyMenu()
         {
             SqlConnection _conobj = new SqlConnection(constr);
             try
             {
                 SqlCommand _cmd = new SqlCommand("select MenuID from Menu", _conobj);
                 _conobj.Open();
                 SqlDataReader dr = _cmd.ExecuteReader();

                 List<EntityLayers.Menu> _modifyMenuObj = new List<EntityLayers.Menu>();
                 if (dr.HasRows)
                 {
                     while (dr.Read())
                     {
                         EntityLayers.Menu _menuObj = new EntityLayers.Menu()
                         {
                             _menuID = int.Parse(dr[0].ToString())

                         };
                         _modifyMenuObj.Add(_menuObj);                                              
                     }
                 }
                 return _modifyMenuObj;                
             }
             catch (SqlException)
             {
                 throw;
             }
             finally
             {
                 _conobj.Close();
             }

         }




        /// <summary>
        /// Method for Retreiving Values for Modifying Menu
        /// </summary>
        /// <param name="a">Accepts MenuID as parameter</param>
        /// <returns></returns>
         public List<EntityLayers.Menu> RetreiveModifyMenu(string a)
         {
             SqlConnection _conobj = new SqlConnection(constr);
             int id = int.Parse(a);
             try
             {
                 SqlCommand _cmd = new SqlCommand("select MenuItem,[Description], Price from Menu where MenuID = " + id, _conobj);
                 _conobj.Open();
                 SqlDataReader dr = _cmd.ExecuteReader();

                 List<EntityLayers.Menu> _menuObj = new List<EntityLayers.Menu>();
                 if (dr.HasRows)
                 {
                     while (dr.Read())
                     {
                         EntityLayers.Menu _modifyMenu = new EntityLayers.Menu()
                         {
                             _menuItem = dr.GetString(0),
                             _menuDescription = dr.GetString(1),
                             _menuPrice = dr.GetDecimal(2)
                         };
                         _menuObj.Add(_modifyMenu);
                     }
                 }
                 return _menuObj;
             }

             catch (SqlException)
             {
                 throw;
             }
             finally
             {
                 _conobj.Close();
             }
         }



       
        /// <summary>
        /// Method for retreiving BookingID value for Drop down list
        /// </summary>
        /// <returns>Returns List of BookingID</returns>
         public List<EntityLayers.Booking>GetBookingID()
         {
             SqlConnection _conobj = new SqlConnection(constr);
             try
             {
                 SqlCommand _cmd = new SqlCommand("select BookingID from Booking Where BookingStatus = 'PENDING'  ", _conobj);
                 _conobj.Open();
                 SqlDataReader dr = _cmd.ExecuteReader();
                 List<EntityLayers.Booking> _listObj1 = new List<EntityLayers.Booking>();
                 if (dr.HasRows)
                 {
                     while (dr.Read())
                     {
                         EntityLayers.Booking _bookDDLObj = new EntityLayers.Booking()
                         {
                             _bookingID = int.Parse(dr[0].ToString())
                         };
                         _listObj1.Add(_bookDDLObj);
                     }
                 }
                return _listObj1;
             }

             catch (SqlException)
             {
                 throw;
             }
             finally
             {
                 _conobj.Close();
             }
         }

       
    
        /// <summary>
        /// Method for retreiving OrderID value for Drop down list
        /// </summary>
        /// <returns>Returns List of OrderID</returns>
         public List<EntityLayers.Orders> GetOrderID()
         {
             SqlConnection _conobj = new SqlConnection(constr);
             try
             {
                 SqlCommand _cmd = new SqlCommand("select OrderID from Orders Where OrderStatus = 'PENDING'  ", _conobj);
                 _conobj.Open();
                 SqlDataReader dr = _cmd.ExecuteReader();

                 List<EntityLayers.Orders> _listObj1 = new List<EntityLayers.Orders>();
                 if (dr.HasRows)
                 {
                     while (dr.Read())
                     {
                         EntityLayers.Orders _orderDDLObj = new EntityLayers.Orders()
                         {
                             _orderID = int.Parse(dr[0].ToString())

                         };
                         _listObj1.Add(_orderDDLObj);
                     }

                 }
                 return _listObj1;
             }
             
             catch (SqlException)
             {
                 throw;
             }
            
             finally
             {
                 _conobj.Close();
               
             }
         }

        
       


        }
    }

