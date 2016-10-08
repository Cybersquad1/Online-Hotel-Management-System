using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//------------------------------------------------------------------------------------------------------
// CLASS NAME: Room
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
    public class Room
    {
        public int _roomID { get; set; }
        public string _roomDesc { get; set; }
        public int _roomTypeID { get; set; }
        public decimal _roomCharges { get; set; }
        public string _roomServices { get; set; }
    }
}
