using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



//------------------------------------------------------------------------------------------------------
// CLASS NAME: Menu
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
    public class Menu
    {
        public int _menuID { get; set; }
        public int _menuTypeID { get; set; }
        public string _menuDescription { get; set; }
        public decimal _menuPrice{ get; set; }
        public string _menuItem { get; set; }
    }
}
