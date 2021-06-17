using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Gentle_Park.Model
{
    public class Receive_Details
    {
        [DisplayName(" CHALLAN NO")]
        public string CHALLAN_NO { get; set; }
        [DisplayName("QUANTITY ")]
        public decimal QUANTITY { get; set; }
        [DisplayName("PRE RECV QUANTITY ")]
        public decimal PRE_RECV_QUANTITY { get; set; }
        [DisplayName(" CURR RECV QUANTITY")]
        public decimal CURR_RECV_QUANTITY { get; set; }
        [DisplayName("SALES AMOUNT ")]
        public decimal SALES_AMOUNT { get; set; }
        [DisplayName("DETAILS ")]
        public string DETAILS { get; set; }
    }
}
