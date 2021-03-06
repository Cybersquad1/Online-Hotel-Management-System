﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using EntityLayers;
using System.Data.SqlClient;
using System.Data;



//------------------------------------------------------------------------------------------------------
// CLASS NAME: UserOperation
// =====================================================================================================
//DESCRIPTION:This class contains all the methods that are used by User/Customer to perform tasks
// =====================================================================================================
// CHANGE HISTORY
// -----------------------------------------------------------------------------------------------------
// Version   Date           Name                                 Change 			Workdone
// -----------------------------------------------------------------------------------------------------
// 1.0       02/12/2015     TEAM 15 (Suhas V Kumar)          Initial Creation.		RLL Project
//------------------------------------------------------------------------------------------------------


namespace DataAccessLayer
{
    public class UserOperation
    {


        /// <summary>
        /// Registration Method for new users
        /// </summary>
        /// <param name="_reg">object of Customer class</param>
        /// <param name="_cre">Object of Credentials class</param>
        /// <returns> It returns integer if execution is successful</returns>
        public int Registraion(Customer _reg, Credentials _cre)
        {
            //Connection String
            SqlConnection _conObj = new SqlConnection("Data Source=.;Initial Catalog=HotelDB;Integrated Security=True");
            SqlCommand _cmd;
            int _result;
            try
            {
                _conObj.Open();
                _cmd = new SqlCommand();
                _cmd.CommandText = "sp_Register";
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Connection = _conObj;
                _cmd.Parameters.AddWithValue("@userID", _reg._cUserID);
                _cmd.Parameters.AddWithValue("@name", _reg._cname);
                _cmd.Parameters.AddWithValue("@cPassword", _cre._userPswd);
                _cmd.Parameters.AddWithValue("@emailID", _reg._eMail);
                _cmd.Parameters.AddWithValue("@phoneNO", _reg._ph);
                _cmd.Parameters.AddWithValue("@houseNO", _reg._house);
                _cmd.Parameters.AddWithValue("@streetName", _reg._street);
                _cmd.Parameters.AddWithValue("@cityID", _reg._cityID);
                _cmd.Parameters.AddWithValue("@stateID", _reg._stateID);
                _cmd.Parameters.AddWithValue("@countryID", _reg._countryID);
                _cmd.Parameters.Add("@result", System.Data.SqlDbType.Int);
                _cmd.Parameters["@result"].Direction = ParameterDirection.Output;
                _cmd.ExecuteNonQuery();
                _result = int.Parse(_cmd.Parameters["@result"].Value.ToString());

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





        /// <summary>
        /// Method for Booking method for Users to Book Rooms
        /// </summary>
        /// <param name="_bObj"> Object of Booking class</param>
        /// <returns>It returns integer if execution is successful</returns>
        public int BookNow(Booking _bObj)
        {
            //Connection String
            SqlConnection _conObj = new SqlConnection("Data Source=.;Initial Catalog=HotelDB;Integrated Security=True");
            SqlCommand _cmd;
            int _result;
            try
            {
                _conObj.Open();
                _cmd = new SqlCommand();
                _cmd.CommandText = "sp_Booking";
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.Connection = _conObj;
                _cmd.Parameters.AddWithValue("@userID", _bObj._userID);
                _cmd.Parameters.AddWithValue("@guestName", _bObj._guestName);
                _cmd.Parameters.AddWithValue("@bookingDate", _bObj._bookingDate);
                _cmd.Parameters.AddWithValue("@checkInDate", _bObj._checkIn);
                _cmd.Parameters.AddWithValue("@checkOutDate", _bObj._checkOut);
                _cmd.Parameters.AddWithValue("@noOfAdult", _bObj._noAdults);
                _cmd.Parameters.AddWithValue("@noOfChildren", _bObj._nochildren);
                _cmd.Parameters.AddWithValue("@noOfInfants", _bObj._noInfants);
                _cmd.Parameters.AddWithValue("@identityType", _bObj._identityType);
                _cmd.Parameters.AddWithValue("@identityNumber", _bObj._identityNO);
                _cmd.Parameters.AddWithValue("@roomTypeID", _bObj._roomTypeID);
                _cmd.Parameters.AddWithValue("@roomType", _bObj._roomType);
                _result = _cmd.ExecuteNonQuery();
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





        /// <summary>
        /// Method for Retreiving Values to Order Food
        /// </summary>
        /// <param name="_bObj1"> Object of Booking class</param>
        /// <returns>Returns Booking Status</returns>
        public List<EntityLayers.Booking> RetreiveOrderFood(Booking _bObj1)
        {
            SqlConnection _conobj = new SqlConnection("server=.; database=HotelDB; trusted_connection=yes");
            try
            {
                SqlCommand _cmd = new SqlCommand("select BookingStatus from Booking where BookingID = " + _bObj1._bookingID + " and UserID ='" + _bObj1._userID + "'  ", _conobj);
                _conobj.Open();

                SqlDataReader dr = _cmd.ExecuteReader();

                List<EntityLayers.Booking> _bObj = new List<EntityLayers.Booking>();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        EntityLayers.Booking _bookAddObj = new EntityLayers.Booking()
                        {
                            _status = dr[0].ToString()

                        };

                        _bObj.Add(_bookAddObj);

                    }

                }

                return _bObj;
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




        /// <summary>
        /// Method for Retreiving values for booking ID to check Booking Status
        /// </summary>
        /// <param name="_bobj">Object of Booking class</param>
        /// <returns>Returns List of Booking status and RoomTypeID</returns>
        public List<EntityLayers.Booking> BookingIDRetrival(Booking _bobj)
        {
            SqlConnection _conObj = new SqlConnection("Data Source=.;Initial Catalog=HotelDB;Integrated Security=True");
            try
            {

                SqlCommand _cmd = new SqlCommand("select BookingStatus, RoomTypeID from Booking where BookingID = '" + _bobj._bookingID + "' ", _conObj);
                _conObj.Open();
                SqlDataReader dr = _cmd.ExecuteReader();


                List<EntityLayers.Booking> _listObj = new List<EntityLayers.Booking>();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        EntityLayers.Booking _bookObject = new EntityLayers.Booking()
                        {
                            _status = dr[0].ToString(),
                            _roomTypeID = int.Parse(dr[1].ToString())

                        };
                        _listObj.Add(_bookObject);

                    }

                }

                return _listObj;

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




        /// <summary>
        /// Method for Retreiving values for Drop Down List for displaying OrderID
        /// </summary>
        /// <param name="id">It accepts UserID</param>
        /// <returns>Returns list of OrderID</returns>
        public List<EntityLayers.Orders> RetreiveOrderID(string id)
        {
            SqlConnection _conObj = new SqlConnection("Data Source=.;Initial Catalog=HotelDB;Integrated Security=True");
            try
            {
                SqlCommand _cmd = new SqlCommand("select OrderID from Orders where UserID = '" + id + "' ", _conObj);
                _conObj.Open();
                SqlDataReader dr = _cmd.ExecuteReader();

                List<EntityLayers.Orders> _listObj1 = new List<EntityLayers.Orders>();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        EntityLayers.Orders _orderObj = new EntityLayers.Orders()
                        {
                            _orderID = int.Parse(dr[0].ToString())

                        };
                        _listObj1.Add(_orderObj);
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




        /// <summary>
        /// Method to validate Card Information
        /// </summary>
        /// <param name="cIObj">Object of CardInfo class</param>
        /// <returns>Returns integer of count of first column retreived depending on mathching condition</returns>
        public int ValidateCardInfo(EntityLayers.CardInfo cIObj)
        {
            SqlConnection _conObj = new SqlConnection("Data Source=.;Initial Catalog=HotelDB;Integrated Security=True");
            try
            {
                string _cardNumber = cIObj._cardNO;
                string _nameOnCard = cIObj._NameOnCard;
                string _bankname = cIObj._bankName;
                string _cardType = cIObj._cardType;
                string _expDate = cIObj._expDate.ToString();
                _conObj.Open();
                string query="Select count(*) from CardInfo where [Card NO]='" + _cardNumber + "' and [Name On Card]='" + _nameOnCard + "' and [Card Type]='" + _cardType + "' and [Bank Name]='" + _bankname + "' and [Expiry Date]='" + _expDate + "'";
                SqlCommand _cmd = new SqlCommand("query", _conObj);
                int res = int.Parse(_cmd.ExecuteScalar().ToString());
                return res;
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




        /// <summary>
        /// Method to Insert into Payment Table after validation
        /// </summary>
        /// <param name="_tObj">Object of Orders Class</param>
        /// <param name="_payInsObj">Object of Payment Class</param>
        /// <returns>Returns no. of rows affected</returns>
        public int InsertInPayment(EntityLayers.Orders _tObj, EntityLayers.Payment _payInsObj)
        {
            SqlConnection _conObj = new SqlConnection("Data Source=.;Initial Catalog=HotelDB;Integrated Security=True");
            int _res = 0;
            try
            {
                SqlCommand _cmd = new SqlCommand();
                _cmd.Connection = _conObj;
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.CommandText = "sp_payment";
                _cmd.Parameters.AddWithValue("@OrderID", _tObj._orderID);
                _cmd.Parameters.AddWithValue("@DateOfPayment", _payInsObj._dateOfPayment);
                _cmd.Parameters.AddWithValue("@PaymentMode", _payInsObj._paymentMode);
                _cmd.Parameters.AddWithValue("@BankName", _payInsObj._bankName);
                _cmd.Parameters.AddWithValue("@CardType", _payInsObj._cardType);
                _cmd.Parameters.AddWithValue("@CardNumber", _payInsObj._cardNO);
                _cmd.Parameters.AddWithValue("@NameOnCard", _payInsObj._nameOnCard);
                _cmd.Parameters.AddWithValue("@Amount", _payInsObj._totalamount);
                _conObj.Open();
                _res = _cmd.ExecuteNonQuery();
                return _res;
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




        /// <summary>
        /// Method to Retreive Order Status
        /// </summary>
        /// <param name="_orderId">Accepts OrderID</param>
        /// <returns>Returns Order Status</returns>
        public List<EntityLayers.Orders> OrderIDRetrival(int _orderId)
        {
            SqlConnection _conObj = new SqlConnection("Data Source=.;Initial Catalog=HotelDB;Integrated Security=True");
            List<EntityLayers.Orders> _listObj = new List<EntityLayers.Orders>();
            try
            {
                SqlCommand _cmd1 = new SqlCommand("select OrderStatus from Orders where OrderID = '" + _orderId + "' ", _conObj);
                _conObj.Open();
                SqlDataReader dr = _cmd1.ExecuteReader();
                
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        EntityLayers.Orders _ordobj = new EntityLayers.Orders()
                        {
                            _orderStatus = dr[0].ToString()
                        };
                        _listObj.Add(_ordobj);
                    }
                }

                
                return _listObj;
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


        /// <summary>
        /// Method for retreiving Order Status
        /// </summary>
        /// <param name="_userId">Order Status for specific User ID obtained</param>
        /// <returns> Returns Order Status</returns>
        public List<EntityLayers.Orders> OrderIDRetrivals(string _userId)
        {
            SqlConnection _conObj = new SqlConnection("Data Source=.;Initial Catalog=HotelDB;Integrated Security=True");
            try
            {
                SqlCommand _cmd1 = new SqlCommand("select OrderStatus from Orders where UserID = '" + _userId + "' ", _conObj);
                _conObj.Open();
                SqlDataReader dr = _cmd1.ExecuteReader();
                List<EntityLayers.Orders> _listObj = new List<EntityLayers.Orders>();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        EntityLayers.Orders _ordobj = new EntityLayers.Orders()
                        {
                            _orderStatus = dr[0].ToString()
                        };
                        _listObj.Add(_ordobj);
                    }
                }
                return _listObj;
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






        /// <summary>
        /// Method for retreiving values from TempOrder Table
        /// </summary>
        /// <param name="_uID">Depending on UserID all the values are retreived</param>
        /// <returns>Returns List of Column in TempOrder Table</returns>
        public List<EntityLayers.TempOrders> BookingIDRetrival(string _uID)
        {
            SqlConnection _conObj = new SqlConnection("Data Source=.;Initial Catalog=HotelDB;Integrated Security=True");
            try
            {
                string _qurey = "select [MENU ITEM], [QUANTITY], [PRICE/QTY], [TOTAL PRICE] from TEMPORDER where UserID = '" + _uID + "'  ";
                SqlCommand _cmd = new SqlCommand(_qurey, _conObj);
                _conObj.Open();
                SqlDataReader dr = _cmd.ExecuteReader();
                List<EntityLayers.TempOrders> _listObj = new List<EntityLayers.TempOrders>();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        EntityLayers.TempOrders _bookObject = new EntityLayers.TempOrders()
                        {
                            _qty = int.Parse(dr[1].ToString()),
                            _subTotalPrice = int.Parse(dr[3].ToString()),
                        };
                        _listObj.Add(_bookObject);
                    }
                }
                return _listObj;
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





        /// <summary>
        /// Method for Inserting values into Orders Table
        /// </summary>
        /// <param name="_uID">UserID</param>
        /// <param name="_bID">BookingID</param>
        /// <param name="_amt">Amount</param>
        /// <returns>Returns 1 is execution is successful</returns>
        public int OrderTableUpdate(string _uID, int _bID, decimal _amt)
        {
            SqlConnection _conObj = new SqlConnection("Data Source=.;Initial Catalog=HotelDB;Integrated Security=True");
            int _res = 0;
            try
            {
                SqlCommand _cmd = new SqlCommand();
                _cmd.Connection = _conObj;
                _cmd.CommandType = CommandType.StoredProcedure;
                _cmd.CommandText = "sp_RoomIDRetrival";
                _cmd.Parameters.AddWithValue("@userID", _uID);
                _cmd.Parameters.AddWithValue("@bookingID", _bID);
                _cmd.Parameters.AddWithValue("@amount", _amt);
                _conObj.Open();
                _res = _cmd.ExecuteNonQuery();
                return 1;
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


        //
        /// <summary>
        /// MEthod for Retrieving BookingID 
        /// </summary>
        /// <param name="_userId"> User ID</param>
        /// <returns> Returns List of Booking ID</returns>
        public List<EntityLayers.Booking> RegBookingIDRetrival(string _userId)
        {
            SqlConnection _conObj = new SqlConnection("Data Source=.;Initial Catalog=HotelDB;Integrated Security=True");
            try
            {
                SqlCommand _cmd1 = new SqlCommand("select BookingId from Booking where UserID = '" + _userId + "' ", _conObj);
                _conObj.Open();
                SqlDataReader dr = _cmd1.ExecuteReader();
                List<EntityLayers.Booking> _listObj = new List<EntityLayers.Booking>();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        EntityLayers.Booking _bobj = new EntityLayers.Booking()
                        {
                            _bookingID = int.Parse(dr[0].ToString())
                        };
                        _listObj.Add(_bobj);
                    }
                }
                return _listObj;
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





































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































































