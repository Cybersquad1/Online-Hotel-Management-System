using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



//------------------------------------------------------------------------------------------------------
// CLASS NAME: CardInfo
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
    public class CardInfo
    {
        public string _cardNO { get; set; }
        public string _NameOnCard { get; set; }
        public string _cardType { get; set; }
        public string _bankName { get; set; }
        public string _expDate { get; set; }
    }
}
