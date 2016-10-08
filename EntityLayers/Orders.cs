using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



//------------------------------------------------------------------------------------------------------
// CLASS NAME: Orders
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
    public class Orders
    {
        public int _orderID { get; set; }
        public string _userID { get; set; }
        public int _roomID { get; set; }
        public string _orderDate { get; set; }
        public string _servingDate { get; set; }
        public decimal _amount { get; set; }
        public string _orderStatus { get; set; }
    }

}
