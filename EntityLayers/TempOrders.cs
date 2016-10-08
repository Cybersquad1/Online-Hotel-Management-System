using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//------------------------------------------------------------------------------------------------------
// CLASS NAME: TempOrders
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
    public class TempOrders
    {
        public string _menuItem { get; set; }
        public int _qty { get; set; }
        public decimal _pricePerQty { get; set; }
        public decimal _subTotalPrice { get; set; }
        public string _userID { get; set; }
      
    }
}
