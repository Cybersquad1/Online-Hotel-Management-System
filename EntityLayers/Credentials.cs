using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//------------------------------------------------------------------------------------------------------
// CLASS NAME: Credentials
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
    public class Credentials
    {
        public string _userID { get; set; }
        public string _userPswd { get; set; }
        public string _userType { get; set; }
    }
}
