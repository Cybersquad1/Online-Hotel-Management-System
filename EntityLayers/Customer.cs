using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//------------------------------------------------------------------------------------------------------
// CLASS NAME: Customer
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
    public class Customer
    {
        public string _cname { get; set; }
        public string _cUserID { get; set; }
        public string _eMail { get; set; }
        public string _ph { get; set; }
        public string _house { get; set; }
        public string _street { get; set; }
        public int _countryID  { get; set; }
        public int _stateID { get; set; }
        public int _cityID{ get; set; }
    }
}
