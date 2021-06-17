using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_Gentle_Park.Model
{
    public class Sales_Offer_UIofPOS
    {
        public int Sl_No { get; set; }
        [DisplayName("OFFER CATEGORY")]
        public string OFFER_CATEGORY { get; set; }
        [DisplayName("OFFER NO")]
        public string OFFER_NO { get; set; }
        public int QUANTITY { get; set; }
        public decimal AMOUNT { get; set; }
        public int DISCOUNT { get; set; }
        public string BARCODE { get; set; }
        public string BRANCH { get; set; }
        public string STATUS { get; set; }

    }
}
