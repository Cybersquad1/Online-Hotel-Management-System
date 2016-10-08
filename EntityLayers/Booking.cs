using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//------------------------------------------------------------------------------------------------------
// CLASS NAME: Booking
// =====================================================================================================
//DESCRIPTION:This class contains all the Properties that are used in DB operations
// =====================================================================================================
// CHANGE HISTORY
// -----------------------------------------------------------------------------------------------------
// Version   Date           Name                 Change 			Workdone
// -----------------------------------------------------------------------------------------------------
// 1.0       02/12/2015     TEAM 15          Initial Creation.		RLL Project
//------------------------------------------------------------------------------------------------------







namespace EntityLayers
{
    public class Booking
    {
        public int _bookingID { get; set; }
        public string _userID { get; set; }
        public string _guestName { get; set; }
        public string _bookingDate { get; set; }
        public string _checkIn { get; set; }
        public string _checkOut { get; set; }
        public int _noAdults { get; set; }
        public int _nochildren { get; set; }
        public int _noInfants { get; set; }
        public string _identityType { get; set; }
        public string _identityNO { get; set; }
        public string _status { get; set; }
        public int _roomTypeID { get; set; }
        public string _roomType { get; set; }
    }
}
