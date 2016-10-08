using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



//------------------------------------------------------------------------------------------------------
// CLASS NAME: Payement
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
    public class Payment
    {
        public int _paymentID { get; set; }
        public int _orderID { get; set; }
        public DateTime _dateOfPayment { get; set; }
        public string _paymentMode { get; set; }
        public string _bankName{ get; set; }
        public string _cardType { get; set; }
        public string _cardNO { get; set; }
        public string _nameOnCard { get; set; }
        public decimal _totalamount { get; set; }
    }
}
