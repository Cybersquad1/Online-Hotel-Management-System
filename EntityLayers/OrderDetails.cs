using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



//------------------------------------------------------------------------------------------------------
// CLASS NAME: OrderDetails
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
    public class OrderDetails
    {
        public int _orderID { get; set; }
        public int _menuID { get; set; }
        public int _reqQTY { get; set; }
        public decimal _subamount { get; set; }

    }
}
