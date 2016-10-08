using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using EntityLayers;


namespace UserBookingWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        SqlConnection _conObj = new SqlConnection("server=.; database=HotelDB; trusted_connection=yes");


        public List<EntityLayers.RoomType> BookNowDDLWCF()
        {
            try
            {

                SqlCommand _cmd = new SqlCommand("select RoomType, RoomTypeID from RoomType", _conObj);
                _conObj.Open();
                SqlDataReader dr = _cmd.ExecuteReader();

                List<EntityLayers.RoomType> _listObj1 = new List<EntityLayers.RoomType>();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        EntityLayers.RoomType _menuIDObj = new EntityLayers.RoomType()
                        {

                            _roomType = dr[0].ToString(),
                            _roomTypeID=int.Parse(dr[1].ToString())

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



        //Booking method for USer to Book Room Tickets
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

    }
}
