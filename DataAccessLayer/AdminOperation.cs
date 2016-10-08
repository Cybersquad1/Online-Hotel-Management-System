using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using EntityLayers;
using System.Data.SqlClient;
using System.Data;


//------------------------------------------------------------------------------------------------------
// CLASS NAME: AdminOperation
// =====================================================================================================
//DESCRIPTION:This class contains all the methods that are used by Admin to perform tasks
// =====================================================================================================
// CHANGE HISTORY
// -----------------------------------------------------------------------------------------------------
// Version   Date           Name                                    Change 		    	Workdone
// -----------------------------------------------------------------------------------------------------
// 1.0       02/12/2015     TEAM 15 (Vaishali Santhosh)          Initial Creation.		RLL Project
//------------------------------------------------------------------------------------------------------


namespace DataAccessLayer
{
    public class AdminOperation
     {
        /// <summary>
        /// Method to add Rooms using LINQ TO SQL CONCEPT
        /// </summary>
        /// <param name="_roomObj">It accepts Room object and returns void</param>
        public void AddRoomLinqToSql(EntityLayers.Room _roomObj)
        {
            try
            {
                DataAccessLayer.RoomDataContext _roomDataContext = new DataAccessLayer.RoomDataContext();
                _roomDataContext.sp_AddRoom(_roomObj._roomDesc, _roomObj._roomCharges, _roomObj._roomServices, _roomObj._roomTypeID);
            }
            catch(Exception)
            {
                throw;
            }
        }

        

        
        /// <summary>
        /// Method to Modify Rooms using LINQ TO SQL CONCEPT
        /// </summary>
        /// <param name="_roomObj">It accepts Room object and returns void</param>
        public void ModifyRoomLinqToSql(EntityLayers.Room _roomObj)
        {
            DataAccessLayer.RoomDataContext _roomDataContext = new DataAccessLayer.RoomDataContext();
            _roomDataContext.sp_ModifyRoom(_roomObj._roomID, _roomObj._roomDesc, _roomObj._roomCharges, _roomObj._roomServices);
        }

        
      

        /// <summary>
        /// Modifying Menu to MenuTable using LINQ TO SQL CONCEPT
        /// </summary>
        /// <param name="_menuObj">It accepts Menu object and returns void</param>
        public void ModifyRoomLinqToSql(EntityLayers.Menu _menuObj)
        {
            DataAccessLayer.MenuDataContext _menuDataContext = new DataAccessLayer.MenuDataContext();
            _menuDataContext.sp_ModifyMenu(_menuObj._menuID,_menuObj._menuItem,_menuObj._menuDescription,_menuObj._menuPrice);
        }



        
        /// <summary>
        /// APPROVE/REJECT ROOM method for Admin 
        /// </summary>
        /// <param name="_bookID"> It accepts BookID and returns void</param>
        public void ApproveRoom(Booking _bookID)
        {
            //Connection String
            SqlConnection _conObj = new SqlConnection("Data Source=.;Initial Catalog=HotelDB;Integrated Security=True");
            SqlCommand _cmd;

            try
            {
                _conObj.Open();
                _cmd = new SqlCommand();
                _cmd.CommandText = "sp_Status";
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Connection = _conObj;
                _cmd.Parameters.AddWithValue("@BookingID", _bookID._bookingID);
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

        public DataSet UpdateType(MenuTypes obj)
        {
            DataSet _ds = new DataSet();
            SqlConnection _conObj = new SqlConnection("Data Source=.;Initial Catalog=HotelDB;Integrated Security=True");
            SqlCommand _cmd;
            _cmd = new SqlCommand("select * from MenuTypes where MenuTypeID='" + obj._menuTypeID + "'", _conObj);
            SqlDataAdapter _dr = new SqlDataAdapter();
            _dr.SelectCommand = _cmd;
            _dr.SelectCommand.Connection = _conObj;
            _dr.Fill(_ds);
            return _ds;
        }
        int _result;
        public int DeleteMenuType(EntityLayers.MenuTypes obj)
        {

            SqlConnection _conObj = new SqlConnection("Data Source=.;Initial Catalog=HotelDB;Integrated Security=True");
            SqlCommand _cmd;

            try
            {
                _conObj.Open();
                _cmd = new SqlCommand("Delete from Menu where MenuTypeID='" +obj._menuTypeID + "'", _conObj);
                _result=_cmd.ExecuteNonQuery();
                return _result;
            }
            catch (Exception)
            {
                return 2;
            }

            finally
            {
                _conObj.Close();
            }


        }
        public DataSet GetMenutype()
        {

            DataSet _ds = new DataSet();
            SqlConnection _conObj = new SqlConnection("Data Source=.;Initial Catalog=HotelDB;Integrated Security=True");
            SqlCommand _cmd;
            _cmd = new SqlCommand("select * from MenuTypes ", _conObj);
            SqlDataAdapter _dr = new SqlDataAdapter();
            _dr.SelectCommand = _cmd;
            _dr.SelectCommand.Connection = _conObj;
            _dr.Fill(_ds);
            return _ds;
        }
     }
}
